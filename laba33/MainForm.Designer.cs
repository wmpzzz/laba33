namespace laba33
{
    partial class MainForm
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
            ToNotesButton = new Button();
            ToAuthButton = new Button();
            ToDataAppend = new Button();
            SuspendLayout();
            // 
            // ToNotesButton
            // 
            ToNotesButton.Location = new Point(193, 99);
            ToNotesButton.Name = "ToNotesButton";
            ToNotesButton.Size = new Size(132, 75);
            ToNotesButton.TabIndex = 0;
            ToNotesButton.Text = "Заметки";
            ToNotesButton.UseVisualStyleBackColor = true;
            ToNotesButton.Click += ToNotesButton_Click;
            // 
            // ToAuthButton
            // 
            ToAuthButton.Location = new Point(193, 199);
            ToAuthButton.Name = "ToAuthButton";
            ToAuthButton.Size = new Size(132, 59);
            ToAuthButton.TabIndex = 1;
            ToAuthButton.Text = "Авторизация";
            ToAuthButton.UseVisualStyleBackColor = true;
            ToAuthButton.Click += ToAuthButton_Click;
            // 
            // ToDataAppend
            // 
            ToDataAppend.Location = new Point(193, 279);
            ToDataAppend.Name = "ToDataAppend";
            ToDataAppend.Size = new Size(132, 54);
            ToDataAppend.TabIndex = 2;
            ToDataAppend.Text = "Таблица цен";
            ToDataAppend.UseVisualStyleBackColor = true;
            ToDataAppend.Click += ToDataAppend_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(ToDataAppend);
            Controls.Add(ToAuthButton);
            Controls.Add(ToNotesButton);
            Name = "MainForm";
            Text = "Основная форма";
            ResumeLayout(false);
        }

        #endregion

        private Button ToNotesButton;
        private Button ToAuthButton;
        private Button ToDataAppend;
    }
}
