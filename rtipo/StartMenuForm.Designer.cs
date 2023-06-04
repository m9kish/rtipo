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
            to_animals_button = new Button();
            to_organisations_button = new Button();
            to_contracts_button = new Button();
            to_statistics_button = new Button();
            SuspendLayout();
            // 
            // to_animals_button
            // 
            to_animals_button.Location = new Point(12, 12);
            to_animals_button.Name = "to_animals_button";
            to_animals_button.Size = new Size(88, 48);
            to_animals_button.TabIndex = 0;
            to_animals_button.Text = "Реестр животных";
            to_animals_button.UseVisualStyleBackColor = true;
            to_animals_button.Click += to_animals_button_Click;
            // 
            // to_organisations_button
            // 
            to_organisations_button.Location = new Point(106, 12);
            to_organisations_button.Name = "to_organisations_button";
            to_organisations_button.Size = new Size(88, 47);
            to_organisations_button.TabIndex = 1;
            to_organisations_button.Text = "Реестр организаций";
            to_organisations_button.UseVisualStyleBackColor = true;
            to_organisations_button.Click += to_organisations_button_Click;
            // 
            // to_contracts_button
            // 
            to_contracts_button.Location = new Point(197, 12);
            to_contracts_button.Name = "to_contracts_button";
            to_contracts_button.Size = new Size(88, 45);
            to_contracts_button.TabIndex = 2;
            to_contracts_button.Text = "Реестр контрактов";
            to_contracts_button.UseVisualStyleBackColor = true;
            to_contracts_button.Click += to_contracts_button_Click;
            // 
            // to_statistics_button
            // 
            to_statistics_button.Location = new Point(291, 13);
            to_statistics_button.Name = "to_statistics_button";
            to_statistics_button.Size = new Size(88, 47);
            to_statistics_button.TabIndex = 3;
            to_statistics_button.Text = "Статистика";
            to_statistics_button.UseVisualStyleBackColor = true;
            to_statistics_button.Click += to_statistics_button_Click;
            // 
            // StartMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 74);
            Controls.Add(to_statistics_button);
            Controls.Add(to_contracts_button);
            Controls.Add(to_organisations_button);
            Controls.Add(to_animals_button);
            Name = "StartMenuForm";
            Text = "Стартовое меню";
            FormClosed += StartMenuForm_FormClosed;
            Load += StartMenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button to_animals_button;
        private Button to_organisations_button;
        private Button to_contracts_button;
        private Button to_statistics_button;
    }
}