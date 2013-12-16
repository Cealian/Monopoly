using System;
using System.Drawing;

namespace MonopolyBoard
{
    public class GFX
    {
        /* ----- Members ----- */
        private static Graphics gObject;
        frmMonopoly board = new frmMonopoly();

        /* ----- Constructors ----- */
        public GFX(Graphics g)
        {
            gObject = g;
            setUpCanvas();

        }

        /* ----- Functions ----- */
        public void setUpCanvas()
        {
            Pen lines = new Pen(Color.Gray);

            /* Draw monopoly board */
            drawVerticalLines(lines);
            drawHorisontalLines(lines);
            fillStreets();
            streetPrices();
            images();
            texts();
        }

        private static void drawVerticalLines(Pen lines) /* Draws the vertical lines for the monopoly board */
        {
            gObject.DrawLine(lines, new Point(81, 0), new Point(81, 648)); // Left vertical line
            gObject.DrawLine(lines, new Point(567, 0), new Point(567, 648)); // Right veritcal line

            for (int i = 1; i < 9; i++)
            {
                int xVal = 81 + (54 * i);
                gObject.DrawLine(lines, new Point(xVal, 0), new Point(xVal, 81)); // Upper street vetrical lines

                gObject.DrawLine(lines, new Point(xVal, 567), new Point(xVal, 648)); // Lower street vertical lines
            }
        }

        private static void drawHorisontalLines(Pen lines) /* Draws the horisontal lines for the monopoly board */
        {
            gObject.DrawLine(lines, new Point(0, 81), new Point(648, 81)); // Upper horisontal line
            gObject.DrawLine(lines, new Point(0, 567), new Point(648, 567)); // Bottom horisontal line

            for (int i = 1; i < 9; i++)
            {
                int yVal = 81 + (54 * i);
                gObject.DrawLine(lines, new Point(0, yVal), new Point(81, yVal)); // Upper street vetrical lines

                gObject.DrawLine(lines, new Point(567, yVal), new Point(648, yVal)); // Lower street vertical lines
            }

        }

        public void UpdateOwner(int squarePosition, int player)
        {
            int markPositionX = 0;
            int markPositionY = 0;

            if(squarePosition > 0 && squarePosition < 10)
            {
                markPositionX = 567 - (54 * squarePosition);
                markPositionY = 638;
            }
            else if (squarePosition > 10 && squarePosition < 20)
            {
                markPositionX = 0;
                markPositionY = 567 - (54 * (squarePosition - 10));
            }
            else if (squarePosition > 20 && squarePosition < 30)
            {
                markPositionX = 27 + (54 * (squarePosition - 20));
                markPositionY = 0;
            }
            else if (squarePosition > 30 && squarePosition < 40)
            {
                markPositionX = 638;
                markPositionY = 27 + (54 * (squarePosition - 30));
            }

            SolidBrush brush = new SolidBrush(board.GetPlayerColor(player));

            gObject.FillRectangle(brush, markPositionX, markPositionY, 10, 10);
            Console.WriteLine("New player: "+ player + " New pos: " + squarePosition);

        }
         private static void fillStreets()
         {
             int x = 82, y = 567, colorX = 53, colorY = 20, i = 54, edge = 506;

             gObject.FillRectangle(Brushes.RoyalBlue, new Rectangle(x, y, colorX, colorY));
             gObject.FillRectangle(Brushes.RoyalBlue, new Rectangle(x + i, y, colorX, colorY));
             gObject.FillRectangle(Brushes.RoyalBlue, new Rectangle(x + 3 * i, y, colorX, colorY));
             gObject.FillRectangle(Brushes.SaddleBrown, new Rectangle(x + 6 * i, y, colorX, colorY));
             gObject.FillRectangle(Brushes.SaddleBrown, new Rectangle(x + 8 * i, y, colorX, colorY));

             gObject.FillRectangle(Brushes.Red, new Rectangle(x, y - edge, colorX, colorY));
             gObject.FillRectangle(Brushes.Red, new Rectangle(x + 2 * i, y - edge, colorX, colorY));
             gObject.FillRectangle(Brushes.Red, new Rectangle(x + 3 * i, y - edge, colorX, colorY));
             gObject.FillRectangle(Brushes.Yellow, new Rectangle(x + 5 * i, y - edge, colorX, colorY));
             gObject.FillRectangle(Brushes.Yellow, new Rectangle(x + 6 * i, y - edge, colorX, colorY));
             gObject.FillRectangle(Brushes.Yellow, new Rectangle(x + 8 * i, y - edge, colorX, colorY));

             gObject.FillRectangle(Brushes.Orange, new Rectangle(x - colorY, y + 1 - edge + colorY, colorY, colorX));
             gObject.FillRectangle(Brushes.Orange, new Rectangle(x - colorY, y + 1 - edge + colorY + i, colorY, colorX));
             gObject.FillRectangle(Brushes.Orange, new Rectangle(x - colorY, y + 1 - edge + colorY + 3 * i, colorY, colorX));
             gObject.FillRectangle(Brushes.Purple, new Rectangle(x - colorY, y + 1 - edge + colorY + 5 * i, colorY, colorX));
             gObject.FillRectangle(Brushes.Purple, new Rectangle(x - colorY, y + 1 - edge + colorY + 6 * i, colorY, colorX));
             gObject.FillRectangle(Brushes.Purple, new Rectangle(x - colorY, y + 1 - edge + colorY + 8 * i, colorY, colorX));

             gObject.FillRectangle(Brushes.Green, new Rectangle(x + edge - colorY, y + 1 - edge + colorY + 3 * i, colorY, colorX));
             gObject.FillRectangle(Brushes.Green, new Rectangle(x + edge - colorY, y + 1 - edge + colorY + i, colorY, colorX));
             gObject.FillRectangle(Brushes.Green, new Rectangle(x + edge - colorY, y + 1 - edge + colorY, colorY, colorX));

             gObject.FillRectangle(Brushes.Blue, new Rectangle(x + edge - colorY, y + 1 - edge + colorY + 8 * i, colorY, colorX));
             gObject.FillRectangle(Brushes.Blue, new Rectangle(x + edge - colorY, y + 1 - edge + colorY + 6 * i, colorY, colorX));
         }

         private static void streetPrices()
         {
             
            int x = 84, y = 622, i = 54, edgex = 618, edgey = 580, color = 20;

             gObject.DrawString("2400kr", SystemFonts.CaptionFont, Brushes.Black, x, y);
             gObject.DrawString("2000kr", SystemFonts.CaptionFont, Brushes.Black, x + i, y);
             gObject.DrawString("2000kr", SystemFonts.CaptionFont, Brushes.Black, x + 3 * i, y);
             gObject.DrawString("2000kr", SystemFonts.CaptionFont, Brushes.Black, x + 6 * i, y);
             gObject.DrawString("1200kr", SystemFonts.CaptionFont, Brushes.Black, x + 8 * i, y);

             gObject.DrawString("2800kr", SystemFonts.CaptionFont, Brushes.Black, x - i - color, y - i - color);
             gObject.DrawString("2800kr", SystemFonts.CaptionFont, Brushes.Black, x - i - color, y - 3 * i - color);
             gObject.DrawString("3200kr", SystemFonts.CaptionFont, Brushes.Black, x - i - color, y - 4 * i - color);
             gObject.DrawString("3600kr", SystemFonts.CaptionFont, Brushes.Black, x - i - color, y - 6 * i - color);
             gObject.DrawString("3600kr", SystemFonts.CaptionFont, Brushes.Black, x - i - color, y - 8 * i - color);
             gObject.DrawString("4000kr", SystemFonts.CaptionFont, Brushes.Black, x - i - color, y - 9 * i - color);

             gObject.DrawString("4400kr", SystemFonts.CaptionFont, Brushes.Black, x, y - edgey);
             gObject.DrawString("4400kr", SystemFonts.CaptionFont, Brushes.Black, x + 2 * i, y - edgey);
             gObject.DrawString("4800kr", SystemFonts.CaptionFont, Brushes.Black, x + 3 * i, y - edgey);
             gObject.DrawString("5200kr", SystemFonts.CaptionFont, Brushes.Black, x + 6 * i, y - edgey);
             gObject.DrawString("5200kr", SystemFonts.CaptionFont, Brushes.Black, x + 5 * i, y - edgey);
             gObject.DrawString("5600kr", SystemFonts.CaptionFont, Brushes.Black, x + 8 * i, y - edgey);

             gObject.DrawString("6000kr", SystemFonts.CaptionFont, Brushes.Black, x - 2 * i + edgex, y - 9 * i - color);
             gObject.DrawString("6000kr", SystemFonts.CaptionFont, Brushes.Black, x - 2 * i + edgex, y - 8 * i - color);
             gObject.DrawString("6400kr", SystemFonts.CaptionFont, Brushes.Black, x - 2 * i + edgex, y - 6 * i - color);
             gObject.DrawString("7000kr", SystemFonts.CaptionFont, Brushes.Black, x - 2 * i + edgex, y - 3 * i - color);
             gObject.DrawString("8000kr", SystemFonts.CaptionFont, Brushes.Black, x - 2 * i + edgex, y - 1 * i - color);


        }
         private void images()
         {
             int x = 310, y = 600, i = 280;
             gObject.DrawImage(Properties.Resources._30px_Crystal_Clear_app_agent, 590, 30);
             gObject.DrawImage(Properties.Resources._30px_Db_Schild_svg, x, y);
             gObject.DrawImage(Properties.Resources._30px_Db_Schild_svg, x - i, y - i);
             gObject.DrawImage(Properties.Resources._30px_Db_Schild_svg, x, y - 2 * i);
             gObject.DrawImage(Properties.Resources._30px_Db_Schild_svg, x + i, y - i);
             gObject.DrawImage(Properties.Resources._30px_Sinnbild_Kfz_svg, 25, 25);
         }

         private static void texts()
         {
             int i = 67, x = 642, y = 735, edgey = 732, edgeX = 547, j = 94, colour = 25;
            
             gObject.DrawString("GÅ", SystemFonts.CaptionFont, Brushes.Black, 595, 595);
             gObject.DrawString("På besök \n\ni fängelse", SystemFonts.CaptionFont, Brushes.Black, 5, 570);
             gObject.DrawString("Fri\nParkering", SystemFonts.CaptionFont, Brushes.Black, 1, 40);
             gObject.DrawString("Gå i\n\n\nfängelse", SystemFonts.CaptionFont, Brushes.Black, 570, 2);
            
             gObject.ScaleTransform(0.8F, 0.8F);
             gObject.DrawString("Västerlång-\ngatan", SystemFonts.DefaultFont, Brushes.Black, x,y);             
             gObject.DrawString("Allmänning", SystemFonts.DefaultFont, Brushes.Black, x - i, y - colour);             
             gObject.DrawString("Hornsgatan", SystemFonts.DefaultFont, Brushes.Black, x - 2 * i, y);
             gObject.DrawString("Inkomst-\nskatt", SystemFonts.DefaultFont, Brushes.Black, x - i * 3, y - colour);
             gObject.DrawString("Södrastation", SystemFonts.DefaultFont, Brushes.Black, x - 4 * i - 5, y - colour);
             gObject.DrawString("Folkkunga-\ngatan", SystemFonts.DefaultFont, Brushes.Black, x - i * 5, y);
             gObject.DrawString("Chans", SystemFonts.DefaultFont, Brushes.Black, x - i * 6, y - colour);
             gObject.DrawString("Götgatan", SystemFonts.DefaultFont, Brushes.Black, x - i * 7, y);
             gObject.DrawString("Ringvägen", SystemFonts.DefaultFont, Brushes.Black, x - i * 8, y);

             gObject.DrawString("S:t Eriks-\ngatan", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j);
             gObject.DrawString("Elverket", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j - i);
             gObject.DrawString("Odengatan", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j - i * 2);
             gObject.DrawString("Valhalla-\nvägen", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j - i * 3);
             gObject.DrawString("Östrastation", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j - i * 4);
             gObject.DrawString("Sturegatan", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j - i * 5);
             gObject.DrawString("Allmänning", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j - i * 6);
             gObject.DrawString("Karlavägen", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j - i * 7);
             gObject.DrawString("Narvavägen", SystemFonts.DefaultFont, Brushes.Black, x - j - edgeX, y - j - i * 8);
             
             gObject.DrawString("Stureplan", SystemFonts.DefaultFont, Brushes.Black, x, y - edgey);
             gObject.DrawString("Vatten-\nverket", SystemFonts.DefaultFont, Brushes.Black, x - i, y - edgey);
             gObject.DrawString("Kungsgatan", SystemFonts.DefaultFont, Brushes.Black, x - 2 * i, y - edgey);
             gObject.DrawString("Vasagatan", SystemFonts.DefaultFont, Brushes.Black, x - 3 * i, y - edgey);
             gObject.DrawString("Central-\nstation", SystemFonts.DefaultFont, Brushes.Black, x - 4 * i, y - edgey);
             gObject.DrawString("Hamngatan", SystemFonts.DefaultFont, Brushes.Black, x - 5 * i, y - edgey);
             gObject.DrawString("Kungsträd-\ngårdsgatan", SystemFonts.DefaultFont, Brushes.Black, x - 6 * i, y - edgey);
             gObject.DrawString("Chans", SystemFonts.DefaultFont, Brushes.Black, x - 7 * i, y - edgey);
             gObject.DrawString("Strand-\nvägen", SystemFonts.DefaultFont, Brushes.Black, x - 8 * i, y - edgey);

             gObject.DrawString("Norrmalms-\ntorg", SystemFonts.DefaultFont, Brushes.Black, x + j, y - j);
             gObject.DrawString("Lyxskatt", SystemFonts.DefaultFont, Brushes.Black, x + j - colour, y - j - i);
             gObject.DrawString("Centrum", SystemFonts.DefaultFont, Brushes.Black, x + j, y - j - 2 * i);
             gObject.DrawString("Chans", SystemFonts.DefaultFont, Brushes.Black, x + j - colour, y - j - 3 * i);
             gObject.DrawString("Norra station", SystemFonts.DefaultFont, Brushes.Black, x + j - 28, y - j - 4 * i);
             gObject.DrawString("Diplomat-\nstaden", SystemFonts.DefaultFont, Brushes.Black, x + j, y - j - 5 * i);
             gObject.DrawString("Allmänning", SystemFonts.DefaultFont, Brushes.Black, x + j - colour, y - j - 6 * i);
             gObject.DrawString("Drottning-\ngatan", SystemFonts.DefaultFont, Brushes.Black, x + j, y - j - 7 * i);
             gObject.DrawString("Gustaf Adolfs\ntorg", SystemFonts.DefaultFont, Brushes.Black, x + j, y - j - 8 * i);
             gObject.ScaleTransform(1.25F, 1.25F);
             

         }
        
    }
}