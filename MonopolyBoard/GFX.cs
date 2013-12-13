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
    }
}