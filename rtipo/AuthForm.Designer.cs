namespace rtipo
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
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            button_auth = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(63, 14);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(214, 23);
            textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(63, 54);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(214, 23);
            textBox_password.TabIndex = 1;
            // 
            // button_auth
            // 
            button_auth.BackColor = SystemColors.Info;
            button_auth.Location = new Point(99, 90);
            button_auth.Name = "button_auth";
            button_auth.Size = new Size(103, 43);
            button_auth.TabIndex = 2;
            button_auth.Text = "Вход";
            button_auth.UseVisualStyleBackColor = false;
            button_auth.Click += button_auth_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 57);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 145);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_auth);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Name = "AuthForm";
            Text = "Авторизация";
            FormClosed += AuthForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_login;
        private TextBox textBox_password;
        private Button button_auth;
        private Label label1;
        private Label label2;
    }
}