using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaRabota
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ComeToStartMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartEkran SE = new StartEkran();
            SE.ShowDialog();
            Close();
        }
    }
}
