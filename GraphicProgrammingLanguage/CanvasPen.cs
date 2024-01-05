using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Handles commands for the pen color for drawing on the canvas
/// </summary>
public static class CanvasPen
{
    /// <summary>
    /// Executes the pen color command to select from specific colors for the canvas pen
    /// </summary>
    /// <param name="pictureBox">The canvas in which the drawing occurs</param>
    /// <param name="args">The argument containing the pen color</param>
    /// <param name="drawingPosition">The current position for drawing, as well as settings (fill/pen color)</param>
    public static void Execute(PictureBox pictureBox, string[] args, DrawingPosition drawingPosition)
    {
        if (args.Length < 1)
        {
            MessageBox.Show("Pen command expects one argument (colour).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // the argument is the color
        string colorArg = args[0].ToLower();

        // Define some standard colors for pen
        Color penColor;
        switch (colorArg)
        {
            case "black":
                penColor = Color.Black;
                break;

            case "red":
                penColor = Color.Red;
                break;

            case "blue":
                penColor = Color.Blue;
                break;

            case "green":
                penColor = Color.Green;
                break;

            case "yellow":
                penColor = Color.Yellow;
                break;
            // a bit of a workaround to stop invalid error prompts. Need to investigate further.
            default:
                Console.WriteLine("Invalid color value for Pen command.");
                return;
        }

        // Set the pen color
        drawingPosition.PenColor = penColor;

        MessageBox.Show($"Pen color set to {colorArg}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
