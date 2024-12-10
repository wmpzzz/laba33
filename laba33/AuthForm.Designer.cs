namespace laba33
{
    partial class AuthForm
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
            AuthButton = new Button();
            LoginTextBox = new TextBox();
            LoginLabel = new Label();
            SuspendLayout();
            // 
            // AuthButton
            // 
            AuthButton.Location = new Point(187, 203);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(136, 57);
            AuthButton.TabIndex = 0;
            AuthButton.Text = "Авторизоваться";
            AuthButton.UseVisualStyleBackColor = true;
            AuthButton.Click += AuthButton_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(128, 138);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(268, 23);
            LoginTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(128, 110);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(86, 15);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Введите логин";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 315);
            Controls.Add(LoginLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(AuthButton);
            Name = "AuthForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AuthButton;
        private TextBox LoginTextBox;
        private Label LoginLabel;
    }
}