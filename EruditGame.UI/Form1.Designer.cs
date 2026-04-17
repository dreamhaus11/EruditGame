namespace EruditGame.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonCheckWord = new Button();
            labelCurrentPlayer = new Label();
            labelScore = new Label();
            listBoxLetters = new ListBox();
            btnSkipTurn = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 350);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonCheckWord
            // 
            buttonCheckWord.BackColor = SystemColors.InactiveCaption;
            buttonCheckWord.FlatStyle = FlatStyle.Popup;
            buttonCheckWord.Location = new Point(170, 368);
            buttonCheckWord.Name = "buttonCheckWord";
            buttonCheckWord.Size = new Size(137, 39);
            buttonCheckWord.TabIndex = 0;
            buttonCheckWord.Text = "Проверить слово";
            buttonCheckWord.UseVisualStyleBackColor = false;
            buttonCheckWord.Click += buttonCheckWord_Click;
            // 
            // labelCurrentPlayer
            // 
            labelCurrentPlayer.AutoSize = true;
            labelCurrentPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            labelCurrentPlayer.Location = new Point(521, 413);
            labelCurrentPlayer.Name = "labelCurrentPlayer";
            labelCurrentPlayer.Size = new Size(54, 21);
            labelCurrentPlayer.TabIndex = 0;
            labelCurrentPlayer.Text = "Игрок";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 12F);
            labelScore.Location = new Point(659, 403);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(48, 21);
            labelScore.TabIndex = 1;
            labelScore.Text = "Очки";
            // 
            // listBoxLetters
            // 
            listBoxLetters.BackColor = SystemColors.GradientInactiveCaption;
            listBoxLetters.FormattingEnabled = true;
            listBoxLetters.ItemHeight = 15;
            listBoxLetters.Location = new Point(345, 356);
            listBoxLetters.Name = "listBoxLetters";
            listBoxLetters.Size = new Size(112, 109);
            listBoxLetters.TabIndex = 2;
            listBoxLetters.SelectedIndexChanged += listBoxLetters_SelectedIndexChanged;
            // 
            // btnSkipTurn
            // 
            btnSkipTurn.BackColor = SystemColors.Info;
            btnSkipTurn.FlatStyle = FlatStyle.Popup;
            btnSkipTurn.Location = new Point(170, 428);
            btnSkipTurn.Name = "btnSkipTurn";
            btnSkipTurn.Size = new Size(137, 35);
            btnSkipTurn.TabIndex = 3;
            btnSkipTurn.Text = "Пропустить ход";
            btnSkipTurn.UseVisualStyleBackColor = false;
            btnSkipTurn.Click += btnSkipTurn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 475);
            Controls.Add(btnSkipTurn);
            Controls.Add(listBoxLetters);
            Controls.Add(labelScore);
            Controls.Add(labelCurrentPlayer);
            Controls.Add(buttonCheckWord);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonCheckWord;
        private Label labelCurrentPlayer;
        private Label labelScore;
        private ListBox listBoxLetters;
        private Button btnSkipTurn;
    }
}
