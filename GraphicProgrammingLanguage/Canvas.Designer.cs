namespace GraphicProgrammingLanguage
{
    partial class Canvas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            commandTextBox = new TextBox();
            runButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(653, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(703, 631);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // commandTextBox
            // 
            commandTextBox.Location = new Point(52, 41);
            commandTextBox.Multiline = true;
            commandTextBox.Name = "commandTextBox";
            commandTextBox.Size = new Size(557, 367);
            commandTextBox.TabIndex = 1;
            // 
            // runButton
            // 
            runButton.Location = new Point(52, 437);
            runButton.Name = "runButton";
            runButton.Size = new Size(158, 52);
            runButton.TabIndex = 2;
            runButton.Text = "Run Command";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(251, 437);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(158, 52);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(451, 437);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(158, 52);
            loadButton.TabIndex = 4;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // Canvas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 655);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(runButton);
            Controls.Add(commandTextBox);
            Controls.Add(pictureBox);
            Name = "Canvas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private TextBox commandTextBox;
        private Button runButton;
        private Button saveButton;
        private Button loadButton;
    }
}