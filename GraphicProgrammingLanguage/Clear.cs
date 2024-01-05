using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Enables the functionality to clear the canvas of any drawings
/// </summary>
public static class Clear
{
    /// <summary>
    /// Executes the clearing of the canvas
    /// </summary>
    /// <param name="pictureBox">The canvas in which the drawing occurs</param>
    /// <param name="args"></param>
    /// <param name="drawingPosition">The current position for drawing, as well as settings (fill/pen color)</param>
    public static void Execute(PictureBox pictureBox, string[] args, DrawingPosition drawingPosition)
    {
        // Clears the PictureBox
        pictureBox.Image = null;

        MessageBox.Show("Canvas cleared!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
