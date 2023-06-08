namespace rtipo
{
    partial class OrganisationForm
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
            type_comboBox = new ComboBox();
            location_comboBox = new ComboBox();
            title_textBox = new TextBox();
            inn_textBox = new TextBox();
            kpp_textBox = new TextBox();
            adres_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            editOrg_button = new Button();
            button2 = new Button();
            ip_comboBox = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // type_comboBox
            // 
            type_comboBox.FormattingEnabled = true;
            type_comboBox.Location = new Point(12, 12);
            type_comboBox.Name = "type_comboBox";
            type_comboBox.Size = new Size(121, 23);
            type_comboBox.TabIndex = 0;
            // 
            // location_comboBox
            // 
            location_comboBox.FormattingEnabled = true;
            location_comboBox.Location = new Point(12, 41);
            location_comboBox.Name = "location_comboBox";
            location_comboBox.Size = new Size(121, 23);
            location_comboBox.TabIndex = 1;
            // 
            // title_textBox
            // 
            title_textBox.Location = new Point(12, 70);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(121, 23);
            title_textBox.TabIndex = 2;
            // 
            // inn_textBox
            // 
            inn_textBox.Location = new Point(12, 99);
            inn_textBox.Name = "inn_textBox";
            inn_textBox.Size = new Size(121, 23);
            inn_textBox.TabIndex = 3;
            // 
            // kpp_textBox
            // 
            kpp_textBox.Location = new Point(12, 128);
            kpp_textBox.Name = "kpp_textBox";
            kpp_textBox.Size = new Size(121, 23);
            kpp_textBox.TabIndex = 4;
            // 
            // adres_textBox
            // 
            adres_textBox.Location = new Point(12, 157);
            adres_textBox.Name = "adres_textBox";
            adres_textBox.Size = new Size(121, 23);
            adres_textBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 15);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 7;
            label1.Text = "Тип организации";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 44);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Локация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 73);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 9;
            label3.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 102);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 10;
            label4.Text = "ИНН";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 131);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 11;
            label5.Text = "КПП";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 160);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 12;
            label6.Text = "Адрес регистрации";
            // 
            // editOrg_button
            // 
            editOrg_button.Location = new Point(256, 11);
            editOrg_button.Name = "editOrg_button";
            editOrg_button.Size = new Size(89, 48);
            editOrg_button.TabIndex = 17;
            editOrg_button.Text = "Изменить карточку";
            editOrg_button.UseVisualStyleBackColor = true;
            editOrg_button.Click += editOrg_button_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(258, 157);
            button2.Name = "button2";
            button2.Size = new Size(89, 48);
            button2.TabIndex = 18;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            // 
            // ip_comboBox
            // 
            ip_comboBox.FormattingEnabled = true;
            ip_comboBox.Items.AddRange(new object[] { "True", "False" });
            ip_comboBox.Location = new Point(12, 187);
            ip_comboBox.Name = "ip_comboBox";
            ip_comboBox.Size = new Size(121, 23);
            ip_comboBox.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 190);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 20;
            label7.Text = "ИП";
            // 
            // OrganisationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 222);
            Controls.Add(label7);
            Controls.Add(ip_comboBox);
            Controls.Add(button2);
            Controls.Add(editOrg_button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(adres_textBox);
            Controls.Add(kpp_textBox);
            Controls.Add(inn_textBox);
            Controls.Add(title_textBox);
            Controls.Add(location_comboBox);
            Controls.Add(type_comboBox);
            Name = "OrganisationForm";
            Text = "Организация";
            Load += OrganisationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox type_comboBox;
        private ComboBox location_comboBox;
        private TextBox title_textBox;
        private TextBox inn_textBox;
        private TextBox kpp_textBox;
        private TextBox adres_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button editOrg_button;
        private Button button2;
        private ComboBox ip_comboBox;
        private Label label7;
    }
}