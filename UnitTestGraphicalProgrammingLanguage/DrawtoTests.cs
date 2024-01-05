using System.Windows.Forms;
using GraphicProgrammingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGraphicalProgrammingLanguage
{
    /// <summary>
    /// Tests the Drawto command
    /// </summary>
    [TestClass]
    public class DrawtoTests
    {
        /// <summary>
        /// Tests to see if the drawto command correctly applies a line to the canvas
        /// </summary>
        [TestMethod]
        public void Drawto_Execute_Pass()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "200", "200" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Drawto.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.IsNotNull(pictureBox.Image);
        }

        /// <summary>
        /// Tests to make sure that if an invalid argument is passed, the execute fails as expected.
        /// </summary>
        [TestMethod]
        public void Drawto_Execute_Fail()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "This is not a number!" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Drawto.Execute(pictureBox, args, drawingPosition);

            // Then
            Assert.IsNull(pictureBox.Image);
        }
    }
}