using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Enables the ability to draw rectangles on the canvas
/// </summary>
public static class Rectangle
{
    /// <summary>
    /// Executes the Rectangle command to draw a rectangle onto the canvas with the given parameters
    /// </summary>
    /// <param name="pictureBox">The canvas in which the drawing occurs</param>
    /// <param name="args">The array of strings containing the width and height</param>
    /// <param name="drawingPosition">The current position for drawing, as well as settings (fill/pen color)</param>
    public static void Execute(PictureBox pictureBox, string[] args, DrawingPosition drawingPosition)
    {
        if (args.Length != 2)
        {
            MessageBox.Show("The rectangle command expects two arguments (width and height).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (int.TryParse(args[0], out int width) && int.TryParse(args[1], out int height))
        {
            // check to see if the pictureBox.Image is null, if it is, instantiate.
            if (pictureBox.Image == null)
            {
                pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            }

            // Set the pen color using CanvasPen
            CanvasPen.Execute(pictureBox, args, drawingPosition);

            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                if (drawingPosition.FillOn)
                {
                    SolidBrush fillBrush = new SolidBrush(drawingPosition.PenColor);
                    g.FillRectangle(fillBrush, drawingPosition.X, drawingPosition.Y, width, height);
                }

                Pen pen = new Pen(drawingPosition.PenColor);
                g.DrawRectangle(pen, drawingPosition.X, drawingPosition.Y, width, height);
            }

            pictureBox.Refresh(); // Refresh the PictureBox to display the changes
        }
        else
        {
            MessageBox.Show("Invalid width or height values for Rectangle command.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
