using System.Drawing;

namespace MonopolyBoard
{
    public class GFX
    {
        private static Graphics gObject;

        frmMonopoly frm = new frmMonopoly();

        public GFX(Graphics g)
        {
            gObject = g;
            setUpCanvas();

        }

        public void setUpCanvas()
        {
            Pen lines = new Pen(Color.Gray);

            /* Draw monopoly board */
            drawVerticalLines(lines);
            drawHorisontalLines(lines);

            frm.picPlayer0.Location = new Point(500, 500);
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
    }
}
