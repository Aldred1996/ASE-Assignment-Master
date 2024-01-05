using System.Windows.Forms;
using GraphicProgrammingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGraphicalProgrammingLanguage
{
    /// <summary>
    /// Tests the CommandParser class behaves as expected
    /// </summary>
    [TestClass]
    public class CommandParserTests
    {
        /// <summary>
        /// Tests to see if the command parser correctly parses the command and the argument
        /// </summary>
        [TestMethod]
        public void CommandParser_Parses_Command_With_Arguments()
        {
            // Given
            var pictureBox = new PictureBox();
            var enteredCommand = "drawto 200 200";

            // When
            var commandParser = new CommandParser(pictureBox, enteredCommand);

            // Then
            Assert.AreEqual("drawto", commandParser.Command);
            CollectionAssert.AreEqual(new[] { "200", "200" }, commandParser.Args);
        }

        /// <summary>
        /// Tests to see if the command parser correctly handles empty commands
        /// </summary>
        [TestMethod]
        public void CommandParser_Parses_Empty_Command()
        {
            // Given
            var pictureBox = new PictureBox();
            var enteredCommand = "";

            // When
            var commandParser = new CommandParser(pictureBox, enteredCommand);

            // Then
            Assert.AreEqual("", commandParser.Command);
            CollectionAssert.AreEqual(Array.Empty<string>(), commandParser.Args);
        }
    }
}