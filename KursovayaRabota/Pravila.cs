using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaRabota
{
    class Pravila
    {

        public static int brosokkub(PictureBox kub)
        {

            int brosokkub = 0;
        Random ran = new Random();
        brosokkub = ran.Next(1, 7);
            kub.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\KursovayaRabota\KursovayaRabota\Resources\"+brosokkub+".png");
            return brosokkub;

        }
        public static void moveR(ref int px, ref int py, ref int schetR, ref int pR, int brosokkub, PictureBox fishkaR)
        {
            #region redmove
            if (brosokkub + pR > 100)
            {
                return;
            }
            for (int b = 0; b < brosokkub; b++)
            {
                if (pR == 10)
                {
                    px = 702;
                    py = 487;
                    schetR = 2;
                }
                else if (pR == 20)
                {
                    px = 7;
                    py = 427;
                    schetR = 3;
                }
                else if (pR == 30)
                {
                    px = 704;
                    py = 367;
                    schetR = 4;
                }
                else if (pR == 40)
                {
                    px = 7;
                    py = 306;
                    schetR = 5;
                }
                else if (pR == 50)
                {
                    px = 703;
                    py = 246;
                    schetR = 6;
                }
                else if (pR == 60)
                {
                    px = 8;
                    py = 186;
                    schetR = 7;
                }
                else if (pR == 70)
                {
                    px = 702;
                    py = 126;
                    schetR = 8;
                }
                else if (pR == 80)
                {
                    px = 7;
                    py = 66;
                    schetR = 9;
                }
                else if (pR == 90)
                {
                    px = 702;
                    py = 7;
                    schetR = 10;
                }
                else if (schetR % 2 != 0)
                {
                    px += 77;
                }
                else if (schetR % 2 == 0)
                {
                    px -= 77;
                }
                fishkaR.Location = new Point(px, py);
                pR++;
            }

            #region лестницы
            if (pR == 4)
            {
                px = 475;
                py = 486;
                pR = 14;
                schetR = 2;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 9)
            {
                px = 706;
                py = 366;
                pR = 31;
                schetR = 4;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 21)
            {
                px = 83;
                py = 304;
                pR = 42;
                schetR = 5;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 28)
            {
                px = 237;
                py = 64;
                pR = 84;
                schetR = 9;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 51)
            {
                px = 466;
                py = 186;
                pR = 67;
                schetR = 7;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 71)
            {
                px = 706;
                py = 6;
                pR = 91;
                schetR = 10;
                fishkaR.Location = new Point(px, py);
            }

            if (pR == 4)
            {
                px = 475;
                py = 486;
                pR = 14;
                schetR = 2;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 9)
            {
                px = 706;
                py = 366;
                pR = 31;
                schetR = 4;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 21)
            {
                px = 83;
                py = 304;
                pR = 42;
                schetR = 5;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 28)
            {
                px = 237;
                py = 64;
                pR = 84;
                schetR = 9;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 51)
            {
                px = 466;
                py = 186;
                pR = 67;
                schetR = 7;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 71)
            {
                px = 706;
                py = 6;
                pR = 91;
                schetR = 10;
                fishkaR.Location = new Point(px, py);
            }
            #endregion

            #region змеи
            if (pR == 17)
            {
                px = 463;
                py = 547;
                pR = 7;
                schetR = 1;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 54)
            {
                px = 475;
                py = 368;
                pR = 34;
                schetR = 4;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 62)
            {
                px = 93;
                py = 486;
                pR = 19;
                schetR = 2;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 64)
            {
                px = 18;
                py = 245;
                pR = 60;
                schetR = 6;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 87)
            {
                px = 235;
                py = 428;
                pR = 24;
                schetR = 3;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 93)
            {
                px = 552;
                py = 125;
                pR = 73;
                schetR = 8;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 95)
            {
                px = 400;
                py = 126;
                pR = 75;
                schetR = 8;
                fishkaR.Location = new Point(px, py);
            }
            if (pR == 98)
            {
                px = 93;
                py = 128;
                pR = 79;
                schetR = 8;
                fishkaR.Location = new Point(px, py);
            }
            #endregion
            #endregion
        }

        public static void moveB(ref int bx, ref int by, ref int schetB, ref int pB, int brosokkub, PictureBox fishkaB)
        {
            #region bluemove
            if (brosokkub + pB > 100)
            {
                return;
            }
            for (int c = 0; c < brosokkub; c++)
            {
                if (pB == 10)
                {
                    bx = 702;
                    by = 487;
                    schetB = 2;
                }
                else if (pB == 20)
                {
                    bx = 7;
                    by = 427;
                    schetB = 3;
                }
                else if (pB == 30)
                {
                    bx = 704;
                    by = 367;
                    schetB = 4;
                }
                else if (pB == 40)
                {
                    bx = 7;
                    by = 306;
                    schetB = 5;
                }
                else if (pB == 50)
                {
                    bx = 703;
                    by = 246;
                    schetB = 6;
                }
                else if (pB == 60)
                {
                    bx = 8;
                    by = 186;
                    schetB = 7;
                }
                else if (pB == 70)
                {
                    bx = 702;
                    by = 126;
                    schetB = 8;
                }
                else if (pB == 80)
                {
                    bx = 7;
                    by = 66;
                    schetB = 9;
                }
                else if (pB == 90)
                {
                    bx = 702;
                    by = 7;
                    schetB = 10;
                }
                else if (schetB % 2 != 0)
                {
                    bx += 77;
                }
                else if (schetB % 2 == 0)
                {
                    bx -= 77;
                }
                fishkaB.Location = new Point(bx, by);
                pB++;
            }

            #region лестницы
            if (pB == 4)
            {
                bx = 475;
                by = 486;
                pB = 14;
                schetB = 2;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 9)
            {
                bx = 706;
                by = 366;
                pB = 31;
                schetB = 4;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 21)
            {
                bx = 83;
                by = 304;
                pB = 42;
                schetB = 5;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 28)
            {
                bx = 237;
                by = 64;
                pB = 84;
                schetB = 9;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 51)
            {
                bx = 466;
                by = 186;
                pB = 67;
                schetB = 7;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 71)
            {
                bx = 706;
                by = 6;
                pB = 91;
                schetB = 10;
                fishkaB.Location = new Point(bx, by);
            }

            if (pB == 4)
            {
                bx = 475;
                by = 486;
                pB = 14;
                schetB = 2;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 9)
            {
                bx = 706;
                by = 366;
                pB = 31;
                schetB = 4;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 21)
            {
                bx = 83;
                by = 304;
                pB = 42;
                schetB = 5;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 28)
            {
                bx = 237;
                by = 64;
                pB = 84;
                schetB = 9;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 51)
            {
                bx = 466;
                by = 186;
                pB = 67;
                schetB = 7;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 71)
            {
                bx = 706;
                by = 6;
                pB = 91;
                schetB = 10;
                fishkaB.Location = new Point(bx, by);
            }
            #endregion

            #region змеи
            if (pB == 17)
            {
                bx = 463;
                by = 547;
                pB = 7;
                schetB = 1;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 54)
            {
                bx = 475;
                by = 368;
                pB = 34;
                schetB = 4;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 62)
            {
                bx = 93;
                by = 486;
                pB = 19;
                schetB = 2;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 64)
            {
                bx = 18;
                by = 245;
                pB = 60;
                schetB = 6;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 87)
            {
                bx = 235;
                by = 428;
                pB = 24;
                schetB = 3;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 93)
            {
                bx = 552;
                by = 125;
                pB = 73;
                schetB = 8;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 95)
            {
                bx = 400;
                by = 126;
                pB = 75;
                schetB = 8;
                fishkaB.Location = new Point(bx, by);
            }
            if (pB == 98)
            {
                bx = 93;
                by = 128;
                pB = 79;
                schetB = 8;
                fishkaB.Location = new Point(bx, by);
            }
            #endregion

            #endregion

        }

        public static void moveG(ref int gx, ref int gy, ref int schetG, ref int pG, int brosokkub, PictureBox fishkaG)
        {
            #region greenmove
            if (brosokkub + pG > 100)
            {
                return;
            }
            for (int b = 0; b < brosokkub; b++)
            {
                if (pG == 10)
                {
                    gx = 702;
                    gy = 487;
                    schetG = 2;
                }
                else if (pG == 20)
                {
                    gx = 7;
                    gy = 427;
                    schetG = 3;
                }
                else if (pG == 30)
                {
                    gx = 704;
                    gy = 367;
                    schetG = 4;
                }
                else if (pG == 40)
                {
                    gx = 7;
                    gy = 306;
                    schetG = 5;
                }
                else if (pG == 50)
                {
                    gx = 703;
                    gy = 246;
                    schetG = 6;
                }
                else if (pG == 60)
                {
                    gx = 8;
                    gy = 186;
                    schetG = 7;
                }
                else if (pG == 70)
                {
                    gx = 702;
                    gy = 126;
                    schetG = 8;
                }
                else if (pG == 80)
                {
                    gx = 7;
                    gy = 66;
                    schetG = 9;
                }
                else if (pG == 90)
                {
                    gx = 702;
                    gy = 7;
                    schetG = 10;
                }
                else if (schetG % 2 != 0)
                {
                    gx += 77;
                }
                else if (schetG % 2 == 0)
                {
                    gx -= 77;
                }
                fishkaG.Location = new Point(gx, gy);
                pG++;
            }

            #region лестницы
            if (pG == 4)
            {
                gx = 475;
                gy = 486;
                pG = 14;
                schetG = 2;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 9)
            {
                gx = 706;
                gy = 366;
                pG = 31;
                schetG = 4;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 21)
            {
                gx = 83;
                gy = 304;
                pG = 42;
                schetG = 5;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 28)
            {
                gx = 237;
                gy = 64;
                pG = 84;
                schetG = 9;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 51)
            {
                gx = 466;
                gy = 186;
                pG = 67;
                schetG = 7;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 71)
            {
                gx = 706;
                gy = 6;
                pG = 91;
                schetG = 10;
                fishkaG.Location = new Point(gx, gy);
            }

            if (pG == 4)
            {
                gx = 475;
                gy = 486;
                pG = 14;
                schetG = 2;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 9)
            {
                gx = 706;
                gy = 366;
                pG = 31;
                schetG = 4;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 21)
            {
                gx = 83;
                gy = 304;
                pG = 42;
                schetG = 5;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 28)
            {
                gx = 237;
                gy = 64;
                pG = 84;
                schetG = 9;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 51)
            {
                gx = 466;
                gy = 186;
                pG = 67;
                schetG = 7;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 71)
            {
                gx = 706;
                gy = 6;
                pG = 91;
                schetG = 10;
                fishkaG.Location = new Point(gx, gy);
            }
            #endregion

            #region змеи
            if (pG == 17)
            {
                gx = 463;
                gy = 547;
                pG = 7;
                schetG = 1;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 54)
            {
                gx = 475;
                gy = 368;
                pG = 34;
                schetG = 4;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 62)
            {
                gx = 93;
                gy = 486;
                pG = 19;
                schetG = 2;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 64)
            {
                gx = 18;
                gy = 245;
                pG = 60;
                schetG = 6;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 87)
            {
                gx = 235;
                gy = 428;
                pG = 24;
                schetG = 3;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 93)
            {
                gx = 552;
                gy = 125;
                pG = 73;
                schetG = 8;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 95)
            {
                gx = 400;
                gy = 126;
                pG = 75;
                schetG = 8;
                fishkaG.Location = new Point(gx, gy);
            }
            if (pG == 98)
            {
                gx = 93;
                gy = 128;
                pG = 79;
                schetG = 8;
                fishkaG.Location = new Point(gx, gy);
            }
            #endregion
            #endregion
        }

        public static void moveY(ref int yx, ref int yy, ref int schetY, ref int pY, int brosokkub, PictureBox fishkaY)
        {
            #region yellowmove
            if (brosokkub + pY > 100)
            {
                return;
            }
            for (int b = 0; b < brosokkub; b++)
            {
                if (pY == 10)
                {
                    yx = 702;
                    yy = 487;
                    schetY = 2;
                }
                else if (pY == 20)
                {
                    yx = 7;
                    yy = 427;
                    schetY = 3;
                }
                else if (pY == 30)
                {
                    yx = 704;
                    yy = 367;
                    schetY = 4;
                }
                else if (pY == 40)
                {
                    yx = 7;
                    yy = 306;
                    schetY = 5;
                }
                else if (pY == 50)
                {
                    yx = 703;
                    yy = 246;
                    schetY = 6;
                }
                else if (pY == 60)
                {
                    yx = 8;
                    yy = 186;
                    schetY = 7;
                }
                else if (pY == 70)
                {
                    yx = 702;
                    yy = 126;
                    schetY = 8;
                }
                else if (pY == 80)
                {
                    yx = 7;
                    yy = 66;
                    schetY = 9;
                }
                else if (pY == 90)
                {
                    yx = 702;
                    yy = 7;
                    schetY = 10;
                }
                else if (schetY % 2 != 0)
                {
                    yx += 77;
                }
                else if (schetY % 2 == 0)
                {
                    yx -= 77;
                }
                fishkaY.Location = new Point(yx, yy);
                pY++;
            }

            #region лестницы
            if (pY == 4)
            {
                yx = 475;
                yy = 486;
                pY = 14;
                schetY = 2;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 9)
            {
                yx = 706;
                yy = 366;
                pY = 31;
                schetY = 4;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 21)
            {
                yx = 83;
                yy = 304;
                pY = 42;
                schetY = 5;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 28)
            {
                yx = 237;
                yy = 64;
                pY = 84;
                schetY = 9;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 51)
            {
                yx = 466;
                yy = 186;
                pY = 67;
                schetY = 7;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 71)
            {
                yx = 706;
                yy = 6;
                pY = 91;
                schetY = 10;
                fishkaY.Location = new Point(yx, yy);
            }

            if (pY == 4)
            {
                yx = 475;
                yy = 486;
                pY = 14;
                schetY = 2;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 9)
            {
                yx = 706;
                yy = 366;
                pY = 31;
                schetY = 4;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 21)
            {
                yx = 83;
                yy = 304;
                pY = 42;
                schetY = 5;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 28)
            {
                yx = 237;
                yy = 64;
                pY = 84;
                schetY = 9;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 51)
            {
                yx = 466;
                yy = 186;
                pY = 67;
                schetY = 7;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 71)
            {
                yx = 706;
                yy = 6;
                pY = 91;
                schetY = 10;
                fishkaY.Location = new Point(yx, yy);
            }
            #endregion

            #region змеи
            if (pY == 17)
            {
                yx = 463;
                yy = 547;
                pY = 7;
                schetY = 1;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 54)
            {
                yx = 475;
                yy = 368;
                pY = 34;
                schetY = 4;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 62)
            {
                yx = 93;
                yy = 486;
                pY = 19;
                schetY = 2;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 64)
            {
                yx = 18;
                yy = 245;
                pY = 60;
                schetY = 6;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 87)
            {
                yx = 235;
                yy = 428;
                pY = 24;
                schetY = 3;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 93)
            {
                yx = 552;
                yy = 125;
                pY = 73;
                schetY = 8;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 95)
            {
                yx = 400;
                yy = 126;
                pY = 75;
                schetY = 8;
                fishkaY.Location = new Point(yx, yy);
            }
            if (pY == 98)
            {
                yx = 93;
                yy = 128;
                pY = 79;
                schetY = 8;
                fishkaY.Location = new Point(yx, yy);
            }
            #endregion
            #endregion
        }
    }
}
