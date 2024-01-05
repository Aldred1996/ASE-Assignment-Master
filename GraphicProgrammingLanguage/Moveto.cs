using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Enables the ability to move to a different drawing position on the canvas
/// </summary>
public static class Moveto
{
    /// <summary>
    /// Executes the moveto command, moving to a given position on the canvas and creating a small dot
    /// </summary>
    /// <param name="pictureBox">The canvas in which the drawing occurs</param>
    /// <param name="args">The array of strings containing the x and y coordinates</param>
    /// <param name="drawingPosition">The current position for drawing, as well as settings (fill/pen color)</param>
    public static void Execute(PictureBox pictureBox, string[] args, DrawingPosition drawingPosition)
    {
        if (args.Length != 2)
        {
            MessageBox.Show("The moveto command expects two arguments (x and y coordinates)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (int.TryParse(args[0], out int x) && int.TryParse(args[1], out int y))
        {
            drawingPosition.X = x ;
            drawingPosition.Y = y ;

            // check to see if the pictureBox.Image is null, if it is, instantiate.
            if (pictureBox.Image == null)
            {
                pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            }

            // Set the pen color using CanvasPen
            CanvasPen.Execute(pictureBox, args, drawingPosition);

            // Draw a small circle at the new drawing position
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                Pen markerPen = new Pen(drawingPosition.PenColor);
                int markerSize = 5;
                g.DrawEllipse(markerPen, x - markerSize / 2, y - markerSize / 2, markerSize, markerSize);
            }

            pictureBox.Refresh(); // Refresh the PictureBox to display the changes
        }
        else
        {
            MessageBox.Show("Invalid x or y values for Moveto command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
