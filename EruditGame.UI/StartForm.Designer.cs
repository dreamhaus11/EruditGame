namespace EruditGame.UI
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            label1 = new Label();
            comboBoxPlayers = new ComboBox();
            btnStart = new Button();
            btnExit = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(314, 22);
            label1.Name = "label1";
            label1.Size = new Size(182, 54);
            label1.TabIndex = 0;
            label1.Text = "ЭРУДИТ";
            // 
            // comboBoxPlayers
            // 
            comboBoxPlayers.BackColor = SystemColors.ScrollBar;
            comboBoxPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlayers.Font = new Font("Segoe UI", 11F);
            comboBoxPlayers.FormattingEnabled = true;
            comboBoxPlayers.Location = new Point(336, 208);
            comboBoxPlayers.Name = "comboBoxPlayers";
            comboBoxPlayers.Size = new Size(134, 28);
            comboBoxPlayers.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ActiveCaption;
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnStart.Location = new Point(302, 269);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 86);
            btnStart.TabIndex = 2;
            btnStart.Text = "Начать игру";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveBorder;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(349, 376);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 49);
            btnExit.TabIndex = 3;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.Location = new Point(221, 115);
            label2.Name = "label2";
            label2.Size = new Size(360, 41);
            label2.TabIndex = 4;
            label2.Text = "ДОБРО ПОЖАЛОВАТЬ!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(231, 175);
            label3.Name = "label3";
            label3.Size = new Size(350, 30);
            label3.TabIndex = 5;
            label3.Text = "Выберите количество игроков:";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(comboBoxPlayers);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxPlayers;
        private Button btnStart;
        private Button btnExit;
        private Label label2;
        private Label label3;
    }
}