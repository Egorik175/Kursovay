namespace KursovayaRabota
{
    partial class StartEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartEkran));
            this.StartGame = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBR = new System.Windows.Forms.TextBox();
            this.textBG = new System.Windows.Forms.TextBox();
            this.textBB = new System.Windows.Forms.TextBox();
            this.textBY = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Pravilaa = new System.Windows.Forms.Button();
            this.Statistika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.DarkOrange;
            this.StartGame.Font = new System.Drawing.Font("HP Simplified", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(64, 343);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(240, 88);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(64, 183);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 47);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::KursovayaRabota.Properties.Resources.Red;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(64, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(64, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 48);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(64, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 48);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBR
            // 
            this.textBR.Location = new System.Drawing.Point(211, 50);
            this.textBR.MaxLength = 8;
            this.textBR.Name = "textBR";
            this.textBR.Size = new System.Drawing.Size(93, 20);
            this.textBR.TabIndex = 5;
            this.textBR.Enter += new System.EventHandler(this.textBR_Enter);
            this.textBR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBR_KeyPress);
            // 
            // textBG
            // 
            this.textBG.Location = new System.Drawing.Point(211, 198);
            this.textBG.MaxLength = 8;
            this.textBG.Name = "textBG";
            this.textBG.Size = new System.Drawing.Size(93, 20);
            this.textBG.TabIndex = 6;
            this.textBG.Enter += new System.EventHandler(this.textBG_Enter);
            this.textBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBG_KeyPress);
            // 
            // textBB
            // 
            this.textBB.Location = new System.Drawing.Point(211, 125);
            this.textBB.MaxLength = 8;
            this.textBB.Name = "textBB";
            this.textBB.Size = new System.Drawing.Size(93, 20);
            this.textBB.TabIndex = 7;
            this.textBB.Enter += new System.EventHandler(this.textBB_Enter);
            this.textBB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBB_KeyPress);
            // 
            // textBY
            // 
            this.textBY.Location = new System.Drawing.Point(211, 271);
            this.textBY.MaxLength = 8;
            this.textBY.Name = "textBY";
            this.textBY.Size = new System.Drawing.Size(93, 20);
            this.textBY.TabIndex = 8;
            this.textBY.Enter += new System.EventHandler(this.textBY_Enter);
            this.textBY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBY_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("HP Simplified", 14.15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(342, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(200, 146);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Перед началом игры введите названия для ваших фишек. Ограничение - 8 символов. Уд" +
    "ачи!";
            // 
            // Pravilaa
            // 
            this.Pravilaa.BackColor = System.Drawing.Color.LightGreen;
            this.Pravilaa.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pravilaa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Pravilaa.Location = new System.Drawing.Point(342, 343);
            this.Pravilaa.Name = "Pravilaa";
            this.Pravilaa.Size = new System.Drawing.Size(200, 88);
            this.Pravilaa.TabIndex = 10;
            this.Pravilaa.Text = "Правила";
            this.Pravilaa.UseVisualStyleBackColor = false;
            this.Pravilaa.Click += new System.EventHandler(this.Pravilaa_Click);
            // 
            // Statistika
            // 
            this.Statistika.BackColor = System.Drawing.Color.Transparent;
            this.Statistika.Location = new System.Drawing.Point(558, 5);
            this.Statistika.Name = "Statistika";
            this.Statistika.Size = new System.Drawing.Size(81, 42);
            this.Statistika.TabIndex = 11;
            this.Statistika.Text = "Статистика";
            this.Statistika.UseVisualStyleBackColor = false;
            this.Statistika.Click += new System.EventHandler(this.Statistika_Click);
            // 
            // StartEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::KursovayaRabota.Properties.Resources.Фоновая;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 457);
            this.Controls.Add(this.Statistika);
            this.Controls.Add(this.Pravilaa);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBY);
            this.Controls.Add(this.textBB);
            this.Controls.Add(this.textBG);
            this.Controls.Add(this.textBR);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartGame);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "StartEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartEkran";
            this.Load += new System.EventHandler(this.StartEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox textBR;
        public System.Windows.Forms.TextBox textBG;
        public System.Windows.Forms.TextBox textBB;
        public System.Windows.Forms.TextBox textBY;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Pravilaa;
        private System.Windows.Forms.Button Statistika;
    }
}