namespace rtipo
{
    partial class auth_form
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
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(123, 65);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(214, 23);
            textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(123, 105);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(214, 23);
            textBox_password.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(182, 134);
            button1.Name = "button1";
            button1.Size = new Size(103, 43);
            button1.TabIndex = 2;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = true;
            // 
            // auth_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 263);
            Controls.Add(button1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Name = "auth_form";
            Text = "auth_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_login;
        private TextBox textBox_password;
        private Button button1;
    }
}