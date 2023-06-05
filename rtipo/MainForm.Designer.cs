namespace rtipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView = new DataGridView();
            add_button = new Button();
            delete_button = new Button();
            export_button = new Button();
            saveFileDialog1 = new SaveFileDialog();
            toolStrip1 = new ToolStrip();
            animals_fill_button = new ToolStripButton();
            organisations_fill_button = new ToolStripButton();
            contracts_fill_button = new ToolStripButton();
            to_statistics_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 27);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(831, 500);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // add_button
            // 
            add_button.Location = new Point(849, 27);
            add_button.Name = "add_button";
            add_button.Size = new Size(104, 38);
            add_button.TabIndex = 2;
            add_button.Text = "Добавить";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(849, 71);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(104, 38);
            delete_button.TabIndex = 4;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // export_button
            // 
            export_button.Location = new Point(849, 115);
            export_button.Name = "export_button";
            export_button.Size = new Size(104, 38);
            export_button.TabIndex = 5;
            export_button.Text = "Экспорт";
            export_button.UseVisualStyleBackColor = true;
            export_button.Click += export_button_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { animals_fill_button, organisations_fill_button, contracts_fill_button });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(965, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // animals_fill_button
            // 
            animals_fill_button.DisplayStyle = ToolStripItemDisplayStyle.Text;
            animals_fill_button.Image = (Image)resources.GetObject("animals_fill_button.Image");
            animals_fill_button.ImageTransparentColor = Color.Magenta;
            animals_fill_button.Name = "animals_fill_button";
            animals_fill_button.Size = new Size(69, 22);
            animals_fill_button.Text = "Животные";
            animals_fill_button.Click += animals_fill_button_Click;
            // 
            // organisations_fill_button
            // 
            organisations_fill_button.DisplayStyle = ToolStripItemDisplayStyle.Text;
            organisations_fill_button.Image = (Image)resources.GetObject("organisations_fill_button.Image");
            organisations_fill_button.ImageTransparentColor = Color.Magenta;
            organisations_fill_button.Name = "organisations_fill_button";
            organisations_fill_button.Size = new Size(84, 22);
            organisations_fill_button.Text = "Организации";
            organisations_fill_button.Click += organisations_fill_button_Click;
            // 
            // contracts_fill_button
            // 
            contracts_fill_button.DisplayStyle = ToolStripItemDisplayStyle.Text;
            contracts_fill_button.Image = (Image)resources.GetObject("contracts_fill_button.Image");
            contracts_fill_button.ImageTransparentColor = Color.Magenta;
            contracts_fill_button.Name = "contracts_fill_button";
            contracts_fill_button.Size = new Size(70, 22);
            contracts_fill_button.Text = "Контракты";
            contracts_fill_button.Click += contracts_fill_button_Click;
            // 
            // to_statistics_button
            // 
            to_statistics_button.Location = new Point(849, 489);
            to_statistics_button.Name = "to_statistics_button";
            to_statistics_button.Size = new Size(104, 38);
            to_statistics_button.TabIndex = 7;
            to_statistics_button.Text = "Статистика";
            to_statistics_button.UseVisualStyleBackColor = true;
            to_statistics_button.Click += to_statistics_button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 539);
            Controls.Add(to_statistics_button);
            Controls.Add(toolStrip1);
            Controls.Add(export_button);
            Controls.Add(delete_button);
            Controls.Add(add_button);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "Реестр";
            FormClosed += MainForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button add_button;
        private Button delete_button;
        private Button export_button;
        private SaveFileDialog saveFileDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton animals_fill_button;
        private ToolStripButton organisations_fill_button;
        private ToolStripButton contracts_fill_button;
        private Button to_statistics_button;
    }
}