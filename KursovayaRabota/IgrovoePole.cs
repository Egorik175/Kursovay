using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KursovayaRabota
{
    public partial class IgrovoePole : Form
    {
            #region переменные
            int flag = 0;
            bool red = false;
            bool blue = false;
            bool green = false;
            bool yellow = false;
            int px = 3;
            int py = 545;
            int bx = 3;
            int by = 545;
            int gx = 3;
            int gy = 545;
            int yx = 3;
            int yy = 545;
            int pR = 1;
            int pB = 1;
            int pG = 1;
            int pY = 1;
            int schetR = 1;
            int schetB = 1;
            int schetG = 1;
            int schetY = 1;
            int redbros = 0;
            int bluebros = 0;
            int greenbros = 0;
            int yellowbros = 0;
            #endregion
        public IgrovoePole(string textR, string textB, string textG, string textY)
        {
            InitializeComponent();
            labelRed.Text = textR;
            labelBlue.Text = textB;
            labelGreen.Text = textG;
            labelYellow.Text = textY;
            
        }
        private void IgrovoePole_Load(object sender, EventArgs e)
        {
        }
        StartEkran SE = new StartEkran();
        private void labelRed_TextChanged(object sender, EventArgs e)
        {
        }
        private void RollKub_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                int bros = Pravila.brosokkub(Kubik);
                try
                {
                    panel2.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Krasnaya fishka.png");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (red == true)
                {
                    try
                    {
                        Yellow1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii temnaya.png");
                        Yellow1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Red1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Red.png");
                        Red1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Pravila.moveR(ref px, ref py, ref schetR, ref pR, bros, Red1);
                    PointR.Text = Convert.ToString(pR);
                    Red1.Parent = panel1;
                    redbros += 1;
                    flag = 1;

                }
                if (bros == 6 && red == false)
                {
                    try
                    {
                        Yellow1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii temnaya.png");
                        Yellow1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Red1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Red.png");
                        Red1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Red1.Location = new Point(px, py);
                    PointR.Text = "1";
                    red = true;
                    Red1.Parent = panel1;
                    redbros += 1;
                    flag = 1;
                }
                if (bros != 6 && red == false)
                {
                    try
                    {
                        Yellow1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii temnaya.png");
                        Yellow1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Red1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Red.png");
                        Red1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    redbros += 1;
                    flag = 1;
                }
                if (redbros == 4)
                {
                    if (red == false)
                    {
                        try
                        {
                            Yellow1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii temnaya.png");
                            Yellow1.SizeMode = PictureBoxSizeMode.StretchImage;
                            Red1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Red.png");
                            Red1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Red1.Location = new Point(px, py);
                        PointR.Text = "1";
                        red = true;
                        Red1.Parent = panel1;
                        redbros += 1;
                        flag = 1;
                    }
                }
                
            }
            else if (flag == 1)
            {
                int bros = Pravila.brosokkub(Kubik);
                try
                {
                    panel2.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka.png");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (blue == true)
                {
                    try
                    {
                        Red1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Red temnaya.png");
                        Red1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Blue1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka.png");
                        Blue1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Pravila.moveB(ref bx, ref by, ref schetB, ref pB, bros, Blue1);
                    PointB.Text = Convert.ToString(pB);
                    Blue1.Parent = panel1;
                    bluebros += 1;
                    flag = 2;

                }
                if (bros == 6 && blue == false)
                {
                    try
                    {
                        Red1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Red temnaya.png");
                        Red1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Blue1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka.png");
                        Blue1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Blue1.Location = new Point(bx, by);
                    PointB.Text = "1";
                    blue = true;
                    Blue1.Parent = panel1;
                    bluebros += 1;
                    flag = 2;
                }
                if (bros != 6 && blue == false)
                {
                    try
                    {
                        Red1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Red temnaya.png");
                        Red1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Blue1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka.png");
                        Blue1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    bluebros += 1;
                    flag = 2;
                }
               if (bluebros == 4)
                {
                    if (blue == false)
                    {
                        try
                        {
                            Red1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Red temnaya.png");
                            Red1.SizeMode = PictureBoxSizeMode.StretchImage;
                            Blue1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka.png");
                            Blue1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Blue1.Location = new Point(bx, by);
                        PointB.Text = "1";
                        blue = true;
                        Blue1.Parent = panel1;
                        bluebros += 1;
                        flag = 2;
                    }
                }
                
            }
            else if (flag == 2)
            {
                int bros = Pravila.brosokkub(Kubik);
                try
                {
                    panel2.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii.png");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (green == true)
                {
                    try
                    {
                        Blue1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka temnaya.png");
                        Blue1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Green1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii.png");
                        Green1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Pravila.moveG(ref gx, ref gy, ref schetG, ref pG, bros, Green1);
                    PointG.Text = Convert.ToString(pG);
                    Green1.Parent = panel1;
                    greenbros += 1;
                    flag = 3;

                }
                if (bros == 6 && green == false)
                {
                    try
                    {
                        Blue1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka temnaya.png");
                        Blue1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Green1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii.png");
                        Green1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Green1.Location = new Point(gx, gy);
                    PointG.Text = "1";
                    green = true;
                    Green1.Parent = panel1;
                    greenbros += 1;
                    flag = 3;
                }
                if (bros != 6 && green == false)
                {
                    try
                    {
                        Blue1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka temnaya.png");
                        Blue1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Green1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii.png");
                        Green1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    greenbros += 1;
                    flag = 3;
                }
                 if (greenbros == 4)
                {
                    if (green == false)
                    {
                        try
                        {
                            Blue1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Sinya fishka temnaya.png");
                            Blue1.SizeMode = PictureBoxSizeMode.StretchImage;
                            Green1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii.png");
                            Green1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Green1.Location = new Point(gx, gy);
                        PointG.Text = "1";
                        green = true;
                        Green1.Parent = panel1;
                        greenbros += 1;
                        flag = 3;
                    }
                }
                  
            }
            else if (flag == 3)
            {
                int bros = Pravila.brosokkub(Kubik);
                try
                {
                    panel2.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii.png");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (yellow == true)
                {
                    try
                    {
                        Green1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii temnaya.png");
                        Green1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Yellow1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii.png");
                        Yellow1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Pravila.moveY(ref yx, ref yy, ref schetY, ref pY, bros, Yellow1);
                    PointY.Text = Convert.ToString(pY);
                    Yellow1.Parent = panel1;
                    yellowbros += 1;
                    flag = 0;

                }
                if (bros == 6 && yellow == false)
                {
                    try
                    {
                        Green1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii temnaya.png");
                        Green1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Yellow1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii.png");
                        Yellow1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Yellow1.Location = new Point(yx, yy);
                    PointY.Text = "1";
                    yellow = true;
                    Yellow1.Parent = panel1;
                    yellowbros += 1;
                    flag = 0;
                }
                if (bros != 6 && yellow == false)
                {
                    try
                    {
                        Green1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii temnaya.png");
                        Green1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Yellow1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii.png");
                        Yellow1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    yellowbros += 1;
                    flag = 0;
                }
                if (yellowbros == 4)
                {
                    if (yellow == false)
                    {
                        try
                        {
                            Green1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zelenii temnaya.png");
                            Green1.SizeMode = PictureBoxSizeMode.StretchImage;
                            Yellow1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\Zheltii.png");
                            Yellow1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Yellow1.Location = new Point(yx, yy);
                        PointY.Text = "1";
                        yellow = true;
                        Yellow1.Parent = panel1;
                        yellowbros += 1;
                        flag = 0;
                    }
                }
            }
            if (pR == 100)
            {
                MessageBox.Show($"ПОБЕДА {labelRed.Text}! На это ему понадобилось {redbros} броска(-ов) ");
                try
                {
                    StreamWriter file = new StreamWriter(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Pobediteli.txt", true);
                    file.WriteLine($"{labelRed.Text} - красная фишка - {redbros} броска(-ов)");
                    file.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.Hide();
                StartEkran st = new StartEkran();        
                st.ShowDialog();
                Close();               
            }
            if (pB == 100)
            {
                MessageBox.Show($"ПОБЕДА { labelBlue.Text}! На это ему понадобилось {bluebros} броска(-ов) ");
                try
                {
                    StreamWriter file = new StreamWriter(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Pobediteli.txt", true);
                    file.WriteLine($"{labelBlue.Text} - синяя фишка - {bluebros} броска(-ов)");
                    file.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.Hide();
                StartEkran st = new StartEkran();
                st.ShowDialog();
                Close();
                
            }
            if (pG == 100)
            {
                MessageBox.Show($"ПОБЕДА {labelGreen.Text}! На это ему понадобилось {greenbros} броска(-ов) ");
                try
                {
                    StreamWriter file = new StreamWriter(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Pobediteli.txt", true);
                    file.WriteLine($"{labelGreen.Text} - зелёная фишка - {greenbros} броска(-ов)");
                    file.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.Hide();
                StartEkran st = new StartEkran();
                st.ShowDialog();
                Close();
                
            }
            if (pY == 100)
            {
                MessageBox.Show($"ПОБЕДА {labelYellow.Text}! На это ему понадобилось {yellowbros} броска(-ов) ");
                try
                {
                    StreamWriter file = new StreamWriter(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Pobediteli.txt", true);
                    file.WriteLine($"{labelYellow.Text} - жёлтая фишка - {yellowbros} броска(-ов)");
                    file.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.Hide();
                StartEkran st = new StartEkran();
                st.ShowDialog();
                Close();
                
            }                       

        }

    }
}
