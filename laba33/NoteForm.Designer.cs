namespace laba33
{
    partial class NoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NoteButton = new Button();
            NoteLabel = new Label();
            NoteTextBox = new TextBox();
            SuspendLayout();
            // 
            // NoteButton
            // 
            NoteButton.Location = new Point(194, 154);
            NoteButton.Name = "NoteButton";
            NoteButton.Size = new Size(111, 46);
            NoteButton.TabIndex = 0;
            NoteButton.Text = "Записать";
            NoteButton.UseVisualStyleBackColor = true;
            NoteButton.Click += NoteButton_Click;
            // 
            // NoteLabel
            // 
            NoteLabel.AutoSize = true;
            NoteLabel.Location = new Point(70, 59);
            NoteLabel.Name = "NoteLabel";
            NoteLabel.Size = new Size(96, 15);
            NoteLabel.TabIndex = 1;
            NoteLabel.Text = "Введите заметку";
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(70, 100);
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(378, 23);
            NoteTextBox.TabIndex = 2;
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 244);
            Controls.Add(NoteTextBox);
            Controls.Add(NoteLabel);
            Controls.Add(NoteButton);
            Name = "NoteForm";
            Text = "Заметки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NoteButton;
        private Label NoteLabel;
        private TextBox NoteTextBox;
    }
}