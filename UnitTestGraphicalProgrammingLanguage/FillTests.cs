using System.Windows.Forms;
using GraphicProgrammingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGraphicalProgrammingLanguage
{
    /// <summary>
    /// Tests the Fill class
    /// </summary>
    [TestClass]
    public class FillTests
    {
        /// <summary>
        /// Tests to see if the Fill bool behaves as expected when receiving the "on" argument
        /// </summary>
        [TestMethod]
        public void Fill_Execute_Pass()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "on" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Fill.Execute(drawingPosition, args);

            // Then
            Assert.IsTrue(drawingPosition.FillOn);
        }

        /// <summary>
        /// Tests to see the behaviour is as expected when an invalid argument is passed for this command
        /// </summary>
        [TestMethod]
        public void Fill_Execute_Fail()
        {
            // Given
            var pictureBox = new PictureBox();
            var args = new String[] { "I will neither confirm nor deny if fill is on" };
            var drawingPosition = new DrawingPosition(250, 250);

            // When
            Fill.Execute(drawingPosition, args);

            // Then
            Assert.IsFalse(drawingPosition.FillOn);
        }
    }
}