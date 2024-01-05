using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Enables the ability to draw triangles on the canvas
/// </summary>
public static class Triangle
{
    /// <summary>
    /// Executes the Triangle command to draw a triangle onto the canvas with the given parameters
    /// </summary>
    /// <param name="pictureBox">The canvas in which the drawing occurs</param>
    /// <param name="args">The array of strings containing the side length</param>
    /// <param name="drawingPosition">The current position for drawing, as well as settings (fill/pen color)</param>
    public static void Execute(PictureBox pictureBox, string[] args, DrawingPosition drawingPosition)
    {
        if (args.Length != 1)
        {
            MessageBox.Show("The triangle command expects one argument (side length)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (int.TryParse(args[0], out int sideLength))
        {
            // Check to make see if the pictureBox.Image is null; if it is, instantiate
            if (pictureBox.Image == null)
            {
                pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            }

            // Set the pen color using CanvasPen
            CanvasPen.Execute(pictureBox, args, drawingPosition);

            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                // Set the fill color if FillOn is true
                if (drawingPosition.FillOn)
                {
                    SolidBrush fillBrush = new SolidBrush(drawingPosition.PenColor);

                    // Calculate the points of the triangle.
                    // point1 is the top, point2 is bottom-left and point3 is bottom-right
                    Point fillPoint1 = new Point(drawingPosition.X, drawingPosition.Y - sideLength);
                    Point fillPoint2 = new Point(drawingPosition.X - sideLength / 2, drawingPosition.Y + sideLength / 2);
                    Point fillPoint3 = new Point(drawingPosition.X + sideLength / 2, drawingPosition.Y + sideLength / 2);

                    g.FillPolygon(fillBrush, new[] { fillPoint1, fillPoint2, fillPoint3 });
                }

                Pen pen = new Pen(drawingPosition.PenColor);

                // Calculate the points of the triangle.
                // point1 is the top, point2 is bottom-left and point3 is bottom-right
                Point drawPoint1 = new Point(drawingPosition.X, drawingPosition.Y - sideLength);
                Point drawPoint2 = new Point(drawingPosition.X - sideLength / 2, drawingPosition.Y + sideLength / 2);
                Point drawPoint3 = new Point(drawingPosition.X + sideLength / 2, drawingPosition.Y + sideLength / 2);

                g.DrawPolygon(pen, new[] { drawPoint1, drawPoint2, drawPoint3 });
            }

            pictureBox.Refresh(); // Refresh the PictureBox to display the changes
        }
        else
        {
            MessageBox.Show("Invalid side length value entered for Triangle command.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
