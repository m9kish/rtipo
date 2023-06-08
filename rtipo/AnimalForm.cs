using MySqlConnector;
using rtipo.Presenters;
using rtipo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rtipo
{
    public partial class AnimalForm : Form, IWorkWithMainForm
    {
        public DataTable DataTable { get => (DataTable)(dataGridView.DataSource = 0); set => dataGridView.DataSource = value; }
        public int Id { get => animal_id; set => animal_id = value; }

        public int animal_id;

        public string localion, category, regnum, birthday, chipnum, nickname, sex, special, owner, photo;

        public bool created_animal = false;

        public AnimalForm()
        {
            InitializeComponent();

            DataTable table = new();

            table = new DB().DataTable("SELECT * FROM Localities");
            location_comboBox.DataSource = table;
            location_comboBox.ValueMember = "Title";

            table = new DB().DataTable("SELECT * FROM Categories");
            category_comboBox.DataSource = table;
            category_comboBox.ValueMember = "Title";

            table = new DB().DataTable("SELECT * FROM OwnerSigns");
            owner_comboBox.DataSource = table;
            owner_comboBox.ValueMember = "Title";
            owner_comboBox.SelectedIndex = -1;

            sex_comboBox.SelectedIndex = 2;
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {

            if (created_animal == true)
            {
                location_comboBox.Text = localion.ToString();
                category_comboBox.Text = category.ToString();
                regnum_textBox.Text = regnum.ToString();
                birthday_dateTimePicker.Text = birthday.ToString();
                chipnum_textBox.Text = chipnum.ToString();
                nickname_textBox.Text = nickname.ToString();
                sex_comboBox.Text = sex.ToString();
                signs_textBox.Text = special.ToString();
                owner_comboBox.Text = owner.ToString();
                pictureBox.Load(photo);

                location_comboBox.Enabled = false;
                category_comboBox.Enabled = false;
                regnum_textBox.ReadOnly = true;
                birthday_dateTimePicker.Enabled = false;
                chipnum_textBox.ReadOnly = true;
                nickname_textBox.ReadOnly = true;
                sex_comboBox.Enabled = false;
                signs_textBox.ReadOnly = true;
                owner_comboBox.Enabled = false;
            }

            FillInspectionsPresenter presenterInspections = new FillInspectionsPresenter(this);
            dataGridView.DataSource = presenterInspections.FillTable(animal_id);

            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "Фамилия ветеринара";
            dataGridView.Columns[2].HeaderText = "Номер контракта";
            dataGridView.Columns[3].HeaderText = "Организация";
            dataGridView.Columns[4].HeaderText = "Особенности";
            dataGridView.Columns[5].HeaderText = "Состояние";
            dataGridView.Columns[6].HeaderText = "Температура";
            dataGridView.Columns[7].HeaderText = "Кожный покров";
            dataGridView.Columns[8].HeaderText = "Состояние шерсти";
            dataGridView.Columns[9].HeaderText = "Повреждения";
            dataGridView.Columns[10].HeaderText = "Срочная помощь";
            dataGridView.Columns[11].HeaderText = "Диагноз";
            dataGridView.Columns[12].HeaderText = "Проведённое лечение";
            dataGridView.Columns[13].HeaderText = "Особенности характера";
            dataGridView.Columns[14].HeaderText = "Дата осмотра";
        }

        private void editAnimal_button_Click(object sender, EventArgs e)
        {
            location_comboBox.Enabled = true;
            category_comboBox.Enabled = true;
            regnum_textBox.ReadOnly = false;
            birthday_dateTimePicker.Enabled = true;
            chipnum_textBox.ReadOnly = false;
            nickname_textBox.ReadOnly = false;
            sex_comboBox.Enabled = true;
            signs_textBox.ReadOnly = false;
            owner_comboBox.Enabled = true;
        }
    }
}
