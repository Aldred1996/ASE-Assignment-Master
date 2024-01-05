/// <summary>
/// Represents the position for drawing on the canvas
/// </summary>
public class DrawingPosition
{
    /// <summary>
    /// The X coordinate for the drawing position
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// The Y coodrinate for the drawing position
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// The color that will be used for drawing
    /// </summary>
    public Color PenColor { get; set; }

    /// <summary>
    /// The toggle to indicate if the Fill option is enabled or not
    /// </summary>
    public bool FillOn { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DrawingPosition"/> class
    /// </summary>
    /// <param name="x">The X coordinate for the drawing position</param>
    /// <param name="y">The Y coordinate for the drawing position</param>
    public DrawingPosition(int x, int y)
    {
        X = x;
        Y = y;


        // Default pen color to black
        PenColor = Color.Black;

        //Default fill status to off
        FillOn = false;

    }
}