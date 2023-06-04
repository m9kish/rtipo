namespace rtipo
{
    partial class StartMenuForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(50, 48);
            button1.Name = "button1";
            button1.Size = new Size(88, 48);
            button1.TabIndex = 0;
            button1.Text = "Реестр животных";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(144, 48);
            button2.Name = "button2";
            button2.Size = new Size(88, 47);
            button2.TabIndex = 1;
            button2.Text = "Реестр организаций";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(235, 48);
            button3.Name = "button3";
            button3.Size = new Size(88, 45);
            button3.TabIndex = 2;
            button3.Text = "Реестр контрактов";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(329, 49);
            button4.Name = "button4";
            button4.Size = new Size(88, 47);
            button4.TabIndex = 3;
            button4.Text = "Статистика";
            button4.UseVisualStyleBackColor = true;
            // 
            // menu_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 147);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "menu_form";
            Text = "menu_form";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}