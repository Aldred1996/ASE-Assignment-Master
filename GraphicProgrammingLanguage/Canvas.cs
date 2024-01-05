using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace GraphicProgrammingLanguage
{
    public partial class Canvas : Form
    {
        private DrawingPosition drawingPosition;
        public Canvas()
        {
            InitializeComponent();
            runButton.Click += runButton_Click;
            saveButton.Click += saveButton_Click;
            loadButton.Click += loadButton_Click;

            drawingPosition = new DrawingPosition(0, 0);
        }

        /// <summary>
        /// Handles the event of clicking the save button, which will allow the user to store commands in the text box to a text file
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save Commands File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.Write(commandTextBox.Text);
                    }

                    MessageBox.Show("Commands saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving commands: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the event of clicking the load button, which will allow users to load a text file of commands into the text box
        /// </summary>
        private void loadButton_Click(Object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Open Commands File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        commandTextBox.Text = reader.ReadToEnd();
                    }

                    MessageBox.Show("Commands loaded successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading commands: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the event of clicking the run button, providing the ability to exectue the commands and draw shapes on the canvas
        /// </summary>
        private void runButton_Click(object sender, EventArgs e)
        {
            string enteredCommand = commandTextBox.Text;
            string[] commands = enteredCommand.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // loops over and treats each command as unique, allowing the multi-line functionality.
            foreach (var command in commands)
            {
                CommandParser parser = new CommandParser(pictureBox, command);

                // Switch statement to go through all expected commands and call the appropriate classes.

                switch (parser.Command.ToLower())
                {
                    case "rectangle":
                        Rectangle.Execute(pictureBox, parser.Args, drawingPosition);
                        break;

                    case "circle":
                        Circle.Execute(pictureBox, parser.Args, drawingPosition);
                        break;

                    case "triangle":
                        Triangle.Execute(pictureBox, parser.Args, drawingPosition);
                        break;

                    case "moveto":
                        Moveto.Execute(pictureBox, parser.Args, drawingPosition);
                        break;

                    case "drawto":
                        Drawto.Execute(pictureBox, parser.Args, drawingPosition);
                        break;

                    case "pen":
                        CanvasPen.Execute(pictureBox, parser.Args, drawingPosition);
                        break;

                    case "fill":
                        Fill.Execute(drawingPosition, parser.Args);
                        break;

                    case "clear":
                        Clear.Execute(pictureBox, parser.Args, drawingPosition);
                        break;

                    case "reset":
                        Reset.Execute(pictureBox, parser.Args, drawingPosition);
                        break;

                    // default if none of the commands are called by the user - error handles inside the switch statement instead of each class!
                    default:
                        MessageBox.Show($"Command '{parser.Command}' not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
        }

    }
}
