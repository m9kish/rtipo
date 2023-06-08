namespace rtipo
{
    partial class ContractForm
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
            order_comboBox = new ComboBox();
            executor_comboBox = new ComboBox();
            first_dateTimePicker = new DateTimePicker();
            last_dateTimePicker = new DateTimePicker();
            num_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            editContract_button = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // order_comboBox
            // 
            order_comboBox.FormattingEnabled = true;
            order_comboBox.Location = new Point(12, 12);
            order_comboBox.Name = "order_comboBox";
            order_comboBox.Size = new Size(141, 23);
            order_comboBox.TabIndex = 0;
            // 
            // executor_comboBox
            // 
            executor_comboBox.FormattingEnabled = true;
            executor_comboBox.Location = new Point(12, 41);
            executor_comboBox.Name = "executor_comboBox";
            executor_comboBox.Size = new Size(141, 23);
            executor_comboBox.TabIndex = 1;
            // 
            // first_dateTimePicker
            // 
            first_dateTimePicker.Location = new Point(12, 70);
            first_dateTimePicker.Name = "first_dateTimePicker";
            first_dateTimePicker.Size = new Size(141, 23);
            first_dateTimePicker.TabIndex = 2;
            // 
            // last_dateTimePicker
            // 
            last_dateTimePicker.Location = new Point(12, 99);
            last_dateTimePicker.Name = "last_dateTimePicker";
            last_dateTimePicker.Size = new Size(141, 23);
            last_dateTimePicker.TabIndex = 3;
            // 
            // num_textBox
            // 
            num_textBox.Location = new Point(12, 128);
            num_textBox.Name = "num_textBox";
            num_textBox.Size = new Size(141, 23);
            num_textBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 15);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Заказчик";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 44);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 6;
            label2.Text = "Исполнитель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 76);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 7;
            label3.Text = "Дата заключения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 105);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Дата окончания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 131);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 9;
            label5.Text = "Номер контракта";
            // 
            // editContract_button
            // 
            editContract_button.Location = new Point(279, 12);
            editContract_button.Name = "editContract_button";
            editContract_button.Size = new Size(91, 47);
            editContract_button.TabIndex = 10;
            editContract_button.Text = "Изменить карточку";
            editContract_button.UseVisualStyleBackColor = true;
            editContract_button.Click += editContract_button_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(279, 171);
            button2.Name = "button2";
            button2.Size = new Size(91, 47);
            button2.TabIndex = 11;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Location = new Point(279, 65);
            button3.Name = "button3";
            button3.Size = new Size(91, 47);
            button3.TabIndex = 12;
            button3.Text = "Загрузить файл";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(279, 118);
            button4.Name = "button4";
            button4.Size = new Size(91, 47);
            button4.TabIndex = 13;
            button4.Text = "Удалить файл";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 157);
            button5.Name = "button5";
            button5.Size = new Size(92, 59);
            button5.TabIndex = 14;
            button5.Text = "Скачать файл";
            button5.UseVisualStyleBackColor = true;
            // 
            // ContractForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 228);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(editContract_button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(num_textBox);
            Controls.Add(last_dateTimePicker);
            Controls.Add(first_dateTimePicker);
            Controls.Add(executor_comboBox);
            Controls.Add(order_comboBox);
            Name = "ContractForm";
            Text = "Контракт";
            Load += ContractForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox order_comboBox;
        private ComboBox executor_comboBox;
        private DateTimePicker first_dateTimePicker;
        private DateTimePicker last_dateTimePicker;
        private TextBox num_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button editContract_button;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}