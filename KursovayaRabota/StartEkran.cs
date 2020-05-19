using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KursovayaRabota
{
    public partial class StartEkran : Form
    {
        public StartEkran()
        {
            InitializeComponent();

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if(textBR.Text == "" || textBB.Text == "" || textBG.Text == "" || textBY.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите названия для всех фишек");
            }
            else if (textBR.Text == textBB.Text || textBR.Text == textBG.Text || textBR.Text == textBY.Text || textBB.Text == textBG.Text || textBB.Text == textBY.Text || textBG.Text == textBY.Text)
            {
                MessageBox.Show("Для вашего удобства исключите повторяющиеся названия");
            }
            else
            {
                this.Hide();
                string textR = textBR.Text;
                string textB = textBB.Text;
                string textG = textBG.Text;
                string textY = textBY.Text;
                IgrovoePole IP = new IgrovoePole(textR, textB, textG, textY);
                IP.ShowDialog();
                Close();
            }
            
        }

        private void StartEkran_Load(object sender, EventArgs e)
        {

        }
        #region Ограничения первого текстбокса
        private void textBR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Ограничения второго текстбокса
        private void textBB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Ограничения третьего текстбокса
        private void textBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Ограничения четвёртого текстбокса
        private void textBY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Запрет на копирование
        private void textBR_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

        private void textBB_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

        private void textBG_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

        private void textBY_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }
        #endregion

        private void Pravilaa_Click(object sender, EventArgs e)
        {
            this.Hide();
            About ab = new About();
            ab.ShowDialog();
            Close();
        }

        private void Statistika_Click(object sender, EventArgs e)
        {
            try
            {
                string Path = @"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Pobediteli.txt";
                StreamReader sr = new StreamReader(Path);
                MessageBox.Show(sr.ReadToEnd(), "Предыдущие победители");              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
