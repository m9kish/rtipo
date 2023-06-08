namespace rtipo
{
    partial class AnimalForm
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
            label1 = new Label();
            label2 = new Label();
            regnum_textBox = new TextBox();
            chipnum_textBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            signs_textBox = new TextBox();
            label6 = new Label();
            nickname_textBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            birthday_dateTimePicker = new DateTimePicker();
            pictureBox = new PictureBox();
            dataGridView = new DataGridView();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            location_comboBox = new ComboBox();
            sex_comboBox = new ComboBox();
            editAnimal_button = new Button();
            owner_comboBox = new ComboBox();
            label9 = new Label();
            category_comboBox = new ComboBox();
            label10 = new Label();
            updateGrid_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Локация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 73);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 1;
            label2.Text = "Регистрационный номер";
            // 
            // regnum_textBox
            // 
            regnum_textBox.Location = new Point(12, 70);
            regnum_textBox.Name = "regnum_textBox";
            regnum_textBox.Size = new Size(100, 23);
            regnum_textBox.TabIndex = 3;
            // 
            // chipnum_textBox
            // 
            chipnum_textBox.Location = new Point(12, 128);
            chipnum_textBox.Name = "chipnum_textBox";
            chipnum_textBox.Size = new Size(100, 23);
            chipnum_textBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 105);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Дата рождения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 131);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 4;
            label4.Text = "Номер чипа";
            // 
            // signs_textBox
            // 
            signs_textBox.Location = new Point(12, 215);
            signs_textBox.Name = "signs_textBox";
            signs_textBox.Size = new Size(100, 23);
            signs_textBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 218);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 12;
            label6.Text = "Отличительные знаки";
            // 
            // nickname_textBox
            // 
            nickname_textBox.Location = new Point(12, 157);
            nickname_textBox.Name = "nickname_textBox";
            nickname_textBox.Size = new Size(100, 23);
            nickname_textBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 189);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 9;
            label7.Text = "Пол";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(118, 160);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 8;
            label8.Text = "Кличка";
            // 
            // birthday_dateTimePicker
            // 
            birthday_dateTimePicker.Location = new Point(12, 99);
            birthday_dateTimePicker.Name = "birthday_dateTimePicker";
            birthday_dateTimePicker.Size = new Size(141, 23);
            birthday_dateTimePicker.TabIndex = 16;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(428, 11);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(300, 300);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 17;
            pictureBox.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 317);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(764, 342);
            dataGridView.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 19;
            label5.Text = "Осмотры";
            // 
            // button1
            // 
            button1.Location = new Point(782, 11);
            button1.Name = "button1";
            button1.Size = new Size(79, 39);
            button1.TabIndex = 20;
            button1.Text = "Добавить фото";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(782, 56);
            button2.Name = "button2";
            button2.Size = new Size(79, 39);
            button2.TabIndex = 21;
            button2.Text = "Удалить фото";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(782, 296);
            button3.Name = "button3";
            button3.Size = new Size(79, 39);
            button3.TabIndex = 22;
            button3.Text = "Добавить осмотр";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(782, 341);
            button4.Name = "button4";
            button4.Size = new Size(79, 39);
            button4.TabIndex = 23;
            button4.Text = "Удалить осмотр";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Info;
            button5.Location = new Point(782, 620);
            button5.Name = "button5";
            button5.Size = new Size(79, 39);
            button5.TabIndex = 24;
            button5.Text = "Сохранить";
            button5.UseVisualStyleBackColor = false;
            // 
            // location_comboBox
            // 
            location_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            location_comboBox.FormattingEnabled = true;
            location_comboBox.Location = new Point(12, 12);
            location_comboBox.Name = "location_comboBox";
            location_comboBox.Size = new Size(100, 23);
            location_comboBox.TabIndex = 25;
            // 
            // sex_comboBox
            // 
            sex_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sex_comboBox.FormattingEnabled = true;
            sex_comboBox.Items.AddRange(new object[] { "Мужской", "Женский", "Неизвестно" });
            sex_comboBox.Location = new Point(12, 186);
            sex_comboBox.Name = "sex_comboBox";
            sex_comboBox.Size = new Size(100, 23);
            sex_comboBox.TabIndex = 26;
            // 
            // editAnimal_button
            // 
            editAnimal_button.Location = new Point(782, 223);
            editAnimal_button.Name = "editAnimal_button";
            editAnimal_button.Size = new Size(79, 39);
            editAnimal_button.TabIndex = 27;
            editAnimal_button.Text = "Изменить карточку";
            editAnimal_button.UseVisualStyleBackColor = true;
            editAnimal_button.Click += editAnimal_button_Click;
            // 
            // owner_comboBox
            // 
            owner_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            owner_comboBox.FormattingEnabled = true;
            owner_comboBox.Location = new Point(12, 244);
            owner_comboBox.Name = "owner_comboBox";
            owner_comboBox.Size = new Size(100, 23);
            owner_comboBox.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(118, 247);
            label9.Name = "label9";
            label9.Size = new Size(121, 15);
            label9.TabIndex = 29;
            label9.Text = "Признаки владельца";
            // 
            // category_comboBox
            // 
            category_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            category_comboBox.FormattingEnabled = true;
            category_comboBox.Location = new Point(12, 41);
            category_comboBox.Name = "category_comboBox";
            category_comboBox.Size = new Size(100, 23);
            category_comboBox.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(118, 44);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 31;
            label10.Text = "Категория";
            // 
            // updateGrid_button
            // 
            updateGrid_button.Location = new Point(782, 450);
            updateGrid_button.Name = "updateGrid_button";
            updateGrid_button.Size = new Size(79, 39);
            updateGrid_button.TabIndex = 32;
            updateGrid_button.Text = "Обновить";
            updateGrid_button.UseVisualStyleBackColor = true;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 671);
            Controls.Add(updateGrid_button);
            Controls.Add(label10);
            Controls.Add(category_comboBox);
            Controls.Add(label9);
            Controls.Add(owner_comboBox);
            Controls.Add(editAnimal_button);
            Controls.Add(sex_comboBox);
            Controls.Add(location_comboBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(dataGridView);
            Controls.Add(pictureBox);
            Controls.Add(birthday_dateTimePicker);
            Controls.Add(signs_textBox);
            Controls.Add(label6);
            Controls.Add(nickname_textBox);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(chipnum_textBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(regnum_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AnimalForm";
            Text = "Животное";
            Load += AnimalForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox regnum_textBox;
        private TextBox chipnum_textBox;
        private Label label3;
        private Label label4;
        private TextBox signs_textBox;
        private Label label6;
        private TextBox nickname_textBox;
        private Label label7;
        private Label label8;
        private DateTimePicker birthday_dateTimePicker;
        private PictureBox pictureBox;
        private DataGridView dataGridView;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox location_comboBox;
        private ComboBox sex_comboBox;
        private Button editAnimal_button;
        private ComboBox owner_comboBox;
        private Label label9;
        private ComboBox category_comboBox;
        private Label label10;
        private Button updateGrid_button;
    }
}