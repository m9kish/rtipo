using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtipo.Views;
using rtipo.Presenters;

namespace rtipo
{
    public partial class MainForm : Form, IWorkWithMainForm
    {
        public DataTable DataTable { get => (DataTable)(dataGridView.DataSource = 0); set => dataGridView.DataSource = value; }

        public MainForm(AuthForm authForm)
        {
            InitializeComponent();
        }

        private void animals_fill_button_Click(object sender, EventArgs e)
        {
            FillAnimalsPresenter presenterAnimals = new FillAnimalsPresenter(this);
            dataGridView.DataSource = presenterAnimals.FillTable();
            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "Номер регистрации";
            dataGridView.Columns[2].HeaderText = "Год рождения";
            dataGridView.Columns[3].HeaderText = "Номер чипа";
            dataGridView.Columns[4].HeaderText = "Кличка";
            dataGridView.Columns[5].HeaderText = "Пол";
            dataGridView.Columns[6].HeaderText = "Фото";
            dataGridView.Columns[7].HeaderText = "Отличительные знаки";
            dataGridView.Columns[8].HeaderText = "Признаки владельца";
            dataGridView.Columns[9].HeaderText = "Категория";
            dataGridView.Columns[10].HeaderText = "Локация";

        }

        private void organisations_fill_button_Click(object sender, EventArgs e)
        {
            FillOrganisationsPresenter presenterOrg = new FillOrganisationsPresenter(this);
            dataGridView.DataSource = presenterOrg.FillTable();
            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "Название организации";
            dataGridView.Columns[2].HeaderText = "ИНН";
            dataGridView.Columns[3].HeaderText = "КПП";
            dataGridView.Columns[4].HeaderText = "Адрес регистрации";
            dataGridView.Columns[5].HeaderText = "ИП";
            dataGridView.Columns[6].HeaderText = "Тип организации";
            dataGridView.Columns[7].HeaderText = "Локация";
        }

        private void contracts_fill_button_Click(object sender, EventArgs e)
        {
            FillContractsPresenter presenterContracts = new FillContractsPresenter(this);
            dataGridView.DataSource = presenterContracts.FillTable();
            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "Дата заключения";
            dataGridView.Columns[2].HeaderText = "Дата окончания";
            dataGridView.Columns[3].HeaderText = "Номер контракта";
            dataGridView.Columns[4].HeaderText = "Заказчик";
            dataGridView.Columns[5].HeaderText = "Исполнитель";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void export_button_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            //System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void to_statistics_button_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}