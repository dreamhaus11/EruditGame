using EruditGame.Core;

namespace EruditGame.UI
{
    public partial class Form1 : Form
    {
        LetterBag letterBag = new LetterBag();
        List<Player> players = new List<Player>();
        int currentPlayerIndex = 0;
        HashSet<string> dictionary = new HashSet<string>();
        Point? startPoint = null;
        Point? endPoint = null;
        Board board = new Board(10);

        Button[,] buttons;

        char selectedLetter = 'А';

        private int playerCount;
        private int winScore = 30;

        public Form1(int playerCount)
        {
            InitializeComponent();

            this.playerCount = playerCount;

            InitializeBoard();
            LoadDictionary();
            InitializePlayers();
            UpdateCurrentPlayerLabel();
            UpdateLetters();

            selectedLetter = players[currentPlayerIndex].Letters[0];
        }

        private void InitializeBoard()
        {
            int size = 10;
            buttons = new Button[size, size];

            tableLayoutPanel1.Controls.Clear();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Tag = new Point(i, j);
                    btn.Click += Cell_Click;

                    int mult = board.GetMultiplier(i, j);

                    if (mult == 2)
                    {
                        btn.BackColor = Color.LightBlue;
                    }
                    else if (mult == 3)
                    {
                        btn.BackColor = Color.Orange;
                    }

                    buttons[i, j] = btn;
                    tableLayoutPanel1.Controls.Add(btn, j, i);
                }
            }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var point = (Point)btn.Tag;

            var player = players[currentPlayerIndex];

            if (btn.Text == "")
            {
                if (!player.Letters.Contains(selectedLetter))
                {
                    MessageBox.Show("У вас нет такой буквы!");
                    return;
                }

                board.PlaceLetter(point.X, point.Y, selectedLetter);
                btn.Text = selectedLetter.ToString();
                btn.BackColor = Color.LightGray;

                player.Letters.Remove(selectedLetter);
                UpdateLetters();

                return;
            }
            if (startPoint != null && endPoint != null)
            {
                ClearSelection();
                startPoint = point;
                endPoint = null;
                buttons[point.X, point.Y].BackColor = Color.Yellow;
                return;
            }

            if (startPoint == null)
            {
                startPoint = point;
                btn.BackColor = Color.Yellow;
            }
            else
            {
                endPoint = point;
                HighlightWord();
            }
        }

        private void HighlightWord()
        {
            if (startPoint == null || endPoint == null)
                return;

            var start = startPoint.Value;
            var end = endPoint.Value;

            if (start.X == end.X)
            {
                int row = start.X;
                int min = Math.Min(start.Y, end.Y);
                int max = Math.Max(start.Y, end.Y);

                for (int j = min; j <= max; j++)
                {
                    buttons[row, j].BackColor = Color.LightGreen;
                }
            }
        
            else if (start.Y == end.Y)
            {
                int col = start.Y;
                int min = Math.Min(start.X, end.X);
                int max = Math.Max(start.X, end.X);

                for (int i = min; i <= max; i++)
                {
                    buttons[i, col].BackColor = Color.LightGreen;
                }
            }
        }

        private void LoadDictionary()
        {
            if (File.Exists("words.txt"))
            {
                var words = File.ReadAllLines("words.txt");

                foreach (var word in words)
                {
                    dictionary.Add(word.ToLower());
                }
            }
        }

        private void InitializePlayers()
        {
            players = new List<Player>();

            for (int i = 1; i <= playerCount; i++)
            {
                players.Add(new Player($"Игрок {i}"));
            }

            foreach (var player in players)
            {
                player.FillLetters(letterBag);
            }
        }

        private void UpdateCurrentPlayerLabel()
        {
            labelCurrentPlayer.Text = $"Ход: {players[currentPlayerIndex].Name}";
        }

        private void NextTurn()
        {
            currentPlayerIndex++;

            if (currentPlayerIndex >= players.Count)
                currentPlayerIndex = 0;

            players[currentPlayerIndex].FillLetters(letterBag);

            UpdateLetters();

            if (players[currentPlayerIndex].Letters.Count > 0)
                selectedLetter = players[currentPlayerIndex].Letters[0];

            UpdateCurrentPlayerLabel();
        }

        private void UpdateScoreLabel()
        {
            string text = "";

            foreach (var player in players)
            {
                text += $"{player.Name}: {player.Score}\n";
            }

            labelScore.Text = text;
        }

        private void ClearSelection()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (buttons[i, j].Text != "")
                        buttons[i, j].BackColor = Color.LightGray;
                }
            }
        }

        private void UpdateLetters()
        {
            listBoxLetters.Items.Clear();

            var currentPlayer = players[currentPlayerIndex];

            foreach (var letter in currentPlayer.Letters)
            {
                int score = LetterScore.GetScore(letter);
                listBoxLetters.Items.Add($"{letter} ({score})");
            }
        }

        private void buttonCheckWord_Click(object sender, EventArgs e)
        {
            if (startPoint == null || endPoint == null)
            {
                MessageBox.Show("Выберите слово");
                return;
            }

            string word = "";

            var start = startPoint.Value;
            var end = endPoint.Value;

            if (start.X == end.X)
            {
                int row = start.X;
                int min = Math.Min(start.Y, end.Y);
                int max = Math.Max(start.Y, end.Y);

                for (int j = min; j <= max; j++)
                {
                    word += board.GetLetter(row, j);
                }
            }
            else if (start.Y == end.Y)
            {
                int col = start.Y;
                int min = Math.Min(start.X, end.X);
                int max = Math.Max(start.X, end.X);

                for (int i = min; i <= max; i++)
                {
                    word += board.GetLetter(i, col);
                }
            }

            word = word.ToUpper();

            if (dictionary.Contains(word.ToLower()))
            {
                MessageBox.Show($"Слово верное: {word}");
            }
            else
            {
                MessageBox.Show($"Слово не найдено: {word}");
            }

            if (dictionary.Contains(word.ToLower()))
            {
                int points = 0;

                if (start.X == end.X)
                {
                    int row = start.X;
                    int min = Math.Min(start.Y, end.Y);
                    int max = Math.Max(start.Y, end.Y);

                    for (int j = min; j <= max; j++)
                    {
                        char c = board.GetLetter(row, j);
                        int mult = board.GetMultiplier(row, j);

                        points += LetterScore.GetScore(c) * mult;
                    }
                }
                else if (start.Y == end.Y)
                {
                    int col = start.Y;
                    int min = Math.Min(start.X, end.X);
                    int max = Math.Max(start.X, end.X);

                    for (int i = min; i <= max; i++)
                    {
                        char c = board.GetLetter(i, col);
                        int mult = board.GetMultiplier(i, col);

                        points += LetterScore.GetScore(c) * mult;
                    }
                }

                players[currentPlayerIndex].AddScore(points);

                if (players[currentPlayerIndex].Score >= winScore)
                {
                    ShowWinner(players[currentPlayerIndex]);
                    return;
                }

                UpdateScoreLabel();

                MessageBox.Show($"{word} (+{points} очков)");

            }
            else
            {
                MessageBox.Show($"{word} (0 очков)");
            }

            NextTurn();
            ClearSelection();
            startPoint = null;
            endPoint = null;
        }

        private void listBoxLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLetters.SelectedItem != null)
            {
                var item = listBoxLetters.SelectedItem.ToString();
                selectedLetter = item[0];
            }
        }

        private void ShowWinner(Player winner)
        {
            MessageBox.Show($"Победил {winner.Name}!");

            StartForm startForm = new StartForm();
            startForm.Show();

            this.Close();
        }

        private void btnSkipTurn_Click(object sender, EventArgs e)
        {
            var player = players[currentPlayerIndex];

            MessageBox.Show($"{player.Name} пропустил ход");

            player.ReplaceLetters(letterBag);

            UpdateLetters();

            ClearSelection();
            startPoint = null;
            endPoint = null;

            NextTurn();
        }
    }
}
