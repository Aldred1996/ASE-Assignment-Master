using System.Windows.Forms;
using GraphicProgrammingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGraphicalProgrammingLanguage
{
    /// <summary>
    /// Tests the clear command
    /// </summary>
    [TestClass]
    public class ClearTests
    {
        /// <summary>
        /// Tests to see if the clear command behaves as expected when it executes
        /// </summary>
        [TestMethod]
        public void Clear_Execute_Pass()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "200" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Triangle.Execute(pictureBox, args, drawingPosition);
            Clear.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.IsNull(pictureBox.Image);
        }

        /// <summary>
        /// Tests to make sure that if something is drawn after the clear command, it performs correctly. Showcases clear does not prevent the
        /// image from being drawn on even after it has been used.
        /// </summary>
        [TestMethod]
        public void Clear_Execute_Fail()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "200" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Clear.Execute(pictureBox, args, drawingPosition);
            Triangle.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.IsNotNull(pictureBox.Image);
        }
    }
}