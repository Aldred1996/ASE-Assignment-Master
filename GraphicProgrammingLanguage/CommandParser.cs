using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphicProgrammingLanguage
{
    /// <summary>
    /// Parses commands, seperates the command and argument from each other
    /// </summary>
    public class CommandParser
    {
        /// <summary>
        /// Gets the command
        /// </summary>
        public string Command { get; private set; }

        /// <summary>
        /// Gets the arguments for the given command
        /// </summary>
        public string[] Args { get; private set; }

        /// <summary>
        /// Initialises a new instance of the CommandParser class
        /// </summary>
        /// <param name="pictureBox">The canvas in which the drawing occurs</param>
        /// <param name="enteredCommand">The command string to be parsed</param>
        public CommandParser( PictureBox pictureBox, string enteredCommand)
        {
            ParseCommand(enteredCommand);
        }

        private void ParseCommand(string commandText)
        {
            string[] commandParts = commandText.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (commandParts.Length == 0)
            {
                Command = "";
                Args = Array.Empty<string>();
                return;
            }

            Command = commandParts[0];

            if (commandParts.Length > 1)
            {
                Args = ParseArguments(commandParts, 1);
            }
            else
            {
                Args = Array.Empty<string>();
            }
        }

        private string[] ParseArguments(string[] commandParts, int startIndex)
        {
            List<string> arguments = new List<string>();

            for (int i = startIndex; i < commandParts.Length; i++)
            {
                arguments.Add(commandParts[i]);
            }

            return arguments.ToArray();
        }
    }
}
