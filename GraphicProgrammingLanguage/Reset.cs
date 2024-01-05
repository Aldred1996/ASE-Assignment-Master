using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Enables the ability to reset the drawing position
/// </summary>
public static class Reset
{
    /// <summary>
    /// Executes the reset command, resetting the drawing position to 0, 0
    /// </summary>
    /// <param name="pictureBox">The canvas in which the drawing occurs</param>
    /// <param name="args"></param>
    /// <param name="drawingPosition">The current position for drawing, as well as settings (fill/pen color)</param>
    public static void Execute(PictureBox pictureBox, string[] args, DrawingPosition drawingPosition)
    {
        // Reset the drawing position
        drawingPosition.X = 0;
        drawingPosition.Y = 0;

        MessageBox.Show("Drawing position reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
