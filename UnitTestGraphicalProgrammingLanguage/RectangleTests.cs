using System.Windows.Forms;
using GraphicProgrammingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGraphicalProgrammingLanguage
{
    /// <summary>
    /// Tests the Rectangle command
    /// </summary>
    [TestClass]
    public class RectangleTests
    {
        /// <summary>
        /// Tests that the rectangle command leaves a shape on the canvas
        /// </summary>
        [TestMethod]
        public void Rectangle_Execute_Pass()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "20", "50" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Rectangle.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.IsNotNull(pictureBox.Image);
        }

        /// <summary>
        /// Tests that no shape is left on the canvas if the parameters are incorrect
        /// </summary>
        [TestMethod]
        public void Rectangle_Execute_Fail()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "This is not a number!" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Rectangle.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.IsNull(pictureBox.Image);
        }
    }
}