using System.Windows.Forms;
using GraphicProgrammingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGraphicalProgrammingLanguage
{
    /// <summary>
    /// Tests the reset command
    /// </summary>
    [TestClass]
    public class ResetTests
    {
        /// <summary>
        /// Tests that when the reset command is entered, the drawing position resets back to 0,0, as expected.
        /// </summary>
        [TestMethod]
        public void Reset_Execute_Pass()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "200, 200" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Reset.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.AreEqual(0, drawingPosition.X, 0);
            Assert.AreEqual(0, drawingPosition.Y);
        }
    }
}