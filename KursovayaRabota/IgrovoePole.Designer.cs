namespace KursovayaRabota
{
    partial class IgrovoePole
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgrovoePole));
            this.RollKub = new System.Windows.Forms.Button();
            this.PointR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PointB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PointG = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PointY = new System.Windows.Forms.Label();
            this.Green1 = new System.Windows.Forms.PictureBox();
            this.Red1 = new System.Windows.Forms.PictureBox();
            this.Yellow1 = new System.Windows.Forms.PictureBox();
            this.Blue1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Kubik = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelYellow = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Green1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kubik)).BeginInit();
            this.SuspendLayout();
            // 
            // RollKub
            // 
            this.RollKub.Location = new System.Drawing.Point(824, 171);
            this.RollKub.Name = "RollKub";
            this.RollKub.Size = new System.Drawing.Size(132, 52);
            this.RollKub.TabIndex = 3;
            this.RollKub.Text = "Roll";
            this.RollKub.UseVisualStyleBackColor = true;
            this.RollKub.Click += new System.EventHandler(this.RollKub_Click);
            // 
            // PointR
            // 
            this.PointR.AutoSize = true;
            this.PointR.BackColor = System.Drawing.SystemColors.Control;
            this.PointR.ForeColor = System.Drawing.Color.Red;
            this.PointR.Location = new System.Drawing.Point(953, 504);
            this.PointR.Name = "PointR";
            this.PointR.Size = new System.Drawing.Size(14, 13);
            this.PointR.TabIndex = 9;
            this.PointR.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Позиция красной фишки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Player\'s Turn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(804, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Позиция синей фишки:";
            // 
            // PointB
            // 
            this.PointB.AutoSize = true;
            this.PointB.ForeColor = System.Drawing.Color.MediumBlue;
            this.PointB.Location = new System.Drawing.Point(953, 531);
            this.PointB.Name = "PointB";
            this.PointB.Size = new System.Drawing.Size(14, 13);
            this.PointB.TabIndex = 13;
            this.PointB.Text = "P";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Позиция зелёной фишки:";
            // 
            // PointG
            // 
            this.PointG.AutoSize = true;
            this.PointG.ForeColor = System.Drawing.Color.LimeGreen;
            this.PointG.Location = new System.Drawing.Point(953, 561);
            this.PointG.Name = "PointG";
            this.PointG.Size = new System.Drawing.Size(14, 13);
            this.PointG.TabIndex = 15;
            this.PointG.Text = "P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(804, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Позиция жёлтой фишки:";
            // 
            // PointY
            // 
            this.PointY.AutoSize = true;
            this.PointY.ForeColor = System.Drawing.Color.Orange;
            this.PointY.Location = new System.Drawing.Point(953, 588);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(14, 13);
            this.PointY.TabIndex = 17;
            this.PointY.Text = "P";
            // 
            // Green1
            // 
            this.Green1.BackColor = System.Drawing.Color.Transparent;
            this.Green1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Green1.BackgroundImage")));
            this.Green1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Green1.Location = new System.Drawing.Point(810, 434);
            this.Green1.Name = "Green1";
            this.Green1.Size = new System.Drawing.Size(59, 50);
            this.Green1.TabIndex = 6;
            this.Green1.TabStop = false;
            // 
            // Red1
            // 
            this.Red1.BackColor = System.Drawing.Color.Transparent;
            this.Red1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Red1.BackgroundImage")));
            this.Red1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Red1.Location = new System.Drawing.Point(810, 348);
            this.Red1.Name = "Red1";
            this.Red1.Size = new System.Drawing.Size(59, 50);
            this.Red1.TabIndex = 7;
            this.Red1.TabStop = false;
            // 
            // Yellow1
            // 
            this.Yellow1.BackColor = System.Drawing.Color.Transparent;
            this.Yellow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Yellow1.BackgroundImage")));
            this.Yellow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Yellow1.Location = new System.Drawing.Point(907, 434);
            this.Yellow1.Name = "Yellow1";
            this.Yellow1.Size = new System.Drawing.Size(59, 50);
            this.Yellow1.TabIndex = 4;
            this.Yellow1.TabStop = false;
            // 
            // Blue1
            // 
            this.Blue1.BackColor = System.Drawing.Color.Transparent;
            this.Blue1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Blue1.BackgroundImage")));
            this.Blue1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Blue1.Location = new System.Drawing.Point(907, 348);
            this.Blue1.Name = "Blue1";
            this.Blue1.Size = new System.Drawing.Size(59, 50);
            this.Blue1.TabIndex = 5;
            this.Blue1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(903, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 48);
            this.panel2.TabIndex = 12;
            // 
            // Kubik
            // 
            this.Kubik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kubik.BackgroundImage")));
            this.Kubik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kubik.Location = new System.Drawing.Point(821, 33);
            this.Kubik.Name = "Kubik";
            this.Kubik.Size = new System.Drawing.Size(139, 107);
            this.Kubik.TabIndex = 8;
            this.Kubik.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 606);
            this.panel1.TabIndex = 0;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRed.Location = new System.Drawing.Point(804, 327);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(69, 18);
            this.labelRed.TabIndex = 19;
            this.labelRed.Text = "Player1";
            this.labelRed.TextChanged += new System.EventHandler(this.labelRed_TextChanged);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelBlue.Location = new System.Drawing.Point(902, 327);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(69, 18);
            this.labelBlue.TabIndex = 20;
            this.labelBlue.Text = "Player2";
            // 
            // labelYellow
            // 
            this.labelYellow.AutoSize = true;
            this.labelYellow.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYellow.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelYellow.Location = new System.Drawing.Point(903, 413);
            this.labelYellow.Name = "labelYellow";
            this.labelYellow.Size = new System.Drawing.Size(69, 18);
            this.labelYellow.TabIndex = 21;
            this.labelYellow.Text = "Player4";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreen.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelGreen.Location = new System.Drawing.Point(804, 413);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(69, 18);
            this.labelGreen.TabIndex = 22;
            this.labelGreen.Text = "Player3";
            // 
            // IgrovoePole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1001, 619);
            this.Controls.Add(this.Green1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Yellow1);
            this.Controls.Add(this.Blue1);
            this.Controls.Add(this.PointY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PointG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PointB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PointR);
            this.Controls.Add(this.Kubik);
            this.Controls.Add(this.RollKub);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Red1);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelYellow);
            this.Controls.Add(this.labelBlue);
            this.MaximizeBox = false;
            this.Name = "IgrovoePole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.IgrovoePole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Green1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kubik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RollKub;
        private System.Windows.Forms.PictureBox Kubik;
        private System.Windows.Forms.Label PointR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PointB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PointG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PointY;
        private System.Windows.Forms.PictureBox Red1;
        private System.Windows.Forms.PictureBox Yellow1;
        private System.Windows.Forms.PictureBox Blue1;
        private System.Windows.Forms.PictureBox Green1;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelYellow;
        private System.Windows.Forms.Label labelGreen;
    }
}

