using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace EruditGame.UI
{
    public partial class StartForm : Form
    {
        //Настройка стартовой формы
        public StartForm()
        {
            InitializeComponent();

            comboBoxPlayers.Items.AddRange(new object[] { 2, 3, 4 });
            comboBoxPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlayers.SelectedIndex = 0;
        }

        //Кнопка "Начать игру"
        private void btnStart_Click(object sender, EventArgs e)
        {
            int playerCount = (int)comboBoxPlayers.SelectedItem;

            Form1 gameForm = new Form1(playerCount);
            gameForm.Show();

            this.Hide();
        }

        //Кнопка "Выход"
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
