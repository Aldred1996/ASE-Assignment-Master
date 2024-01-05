using System.Windows.Forms;
using GraphicProgrammingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGraphicalProgrammingLanguage
{
    /// <summary>
    /// Tests the Moveto command
    /// </summary>
    [TestClass]
    public class MovetoTests
    {
        /// <summary>
        /// Tests that the moveto command works as expected via validating the canvas is not null after use - as it leaves
        /// a small circle showing the user where abouts they are now located on the canvas
        /// </summary>
        [TestMethod]
        public void Moveto_Execute_Pass()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "200", "200" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Moveto.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.IsNotNull(pictureBox.Image);
        }

        /// <summary>
        /// Tests that if it fails, the canvas is still empty as the circle will not have been drawn to show the
        /// user whereabouts they are on the canvas
        /// </summary>
        [TestMethod]
        public void Moveto_Execute_Fail()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "This is not a number!" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Moveto.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.IsNull(pictureBox.Image);
        }
    }
}