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
using Microsoft.EntityFrameworkCore;
using Excel = Microsoft.Office.Interop.Excel;

namespace rtipo
{
    public partial class MainForm : Form, IWorkWithMainForm
    {
        public DataTable DataTable { get => (DataTable)(dataGridView.DataSource = 0); set => dataGridView.DataSource = value; }
        public int Id { get => animal_id; set => animal_id = value; }

        public int animal_id;
        //public string locality, category, regnum, birthday, chipnum, nickname, sex, special, owner;

        public MainForm()
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

            this.Text = "Реестр животных";

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

            this.Text = "Реестр организаций";
        }

        private void contracts_fill_button_Click(object sender, EventArgs e)
        {
            FillContractsPresenter presenterContracts = new FillContractsPresenter(this);
            dataGridView.DataSource = presenterContracts.FillTable();

            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "Заказчик";
            dataGridView.Columns[2].HeaderText = "Исполнитель";
            dataGridView.Columns[3].HeaderText = "Дата заключения";
            dataGridView.Columns[4].HeaderText = "Дата окончания";
            dataGridView.Columns[5].HeaderText = "Номер контракта";

            this.Text = "Реестр контрактов";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Text == "Реестр животных")
            {
                AnimalForm animal = new AnimalForm();

                animal.animal_id = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());

                animal.localion = dataGridView.CurrentRow.Cells[10].Value.ToString();
                animal.category = dataGridView.CurrentRow.Cells[9].Value.ToString();
                animal.regnum = dataGridView.CurrentRow.Cells[1].Value.ToString();
                animal.birthday = dataGridView.CurrentRow.Cells[2].Value.ToString();
                animal.chipnum = dataGridView.CurrentRow.Cells[3].Value.ToString();
                animal.nickname = dataGridView.CurrentRow.Cells[4].Value.ToString();
                animal.sex = dataGridView.CurrentRow.Cells[5].Value.ToString();
                animal.special = dataGridView.CurrentRow.Cells[7].Value.ToString();
                animal.owner = dataGridView.CurrentRow.Cells[8].Value.ToString();
                animal.photo = dataGridView.CurrentRow.Cells[6].Value.ToString();

                animal.created_animal = true;

                animal.ShowDialog();
            }

            if (this.Text == "Реестр организаций")
            {
                OrganisationForm organisation = new OrganisationForm();

                organisation.title = dataGridView.CurrentRow.Cells[1].Value.ToString();
                organisation.inn = dataGridView.CurrentRow.Cells[2].Value.ToString();
                organisation.kpp = dataGridView.CurrentRow.Cells[3].Value.ToString();
                organisation.adres = dataGridView.CurrentRow.Cells[4].Value.ToString();
                organisation.ip = dataGridView.CurrentRow.Cells[5].Value.ToString();
                organisation.type = dataGridView.CurrentRow.Cells[6].Value.ToString();
                organisation.location = dataGridView.CurrentRow.Cells[7].Value.ToString();

                organisation.created_org = true;

                organisation.ShowDialog();
            }

            if (this.Text == "Реестр контрактов")
            {
                ContractForm contract = new ContractForm();

                contract.order = dataGridView.CurrentRow.Cells[1].Value.ToString();
                contract.executor = dataGridView.CurrentRow.Cells[2].Value.ToString();
                contract.firstdate = dataGridView.CurrentRow.Cells[3].Value.ToString();
                contract.lastdate = dataGridView.CurrentRow.Cells[4].Value.ToString();
                contract.number = dataGridView.CurrentRow.Cells[5].Value.ToString();

                contract.created_contract = true;

                contract.ShowDialog();
            }
        }
        private void add_button_Click(object sender, EventArgs e)
        {

            if (this.Text == "Реестр животных")
            {
                AnimalForm animal = new AnimalForm();

                animal.created_animal = false;

                animal.ShowDialog();
            }
            if (this.Text == "Реестр организаций")
            {
                OrganisationForm organisation = new OrganisationForm();

                organisation.created_org = false;

                organisation.ShowDialog();
            }
            if (this.Text == "Реестр контрактов")
            {
                ContractForm contract = new ContractForm();

                contract.created_contract = false;

                contract.ShowDialog();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void export_button_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j, r, c;
            for (i = 0, r = 1; i <= dataGridView.RowCount - 1; i++, r++)
            {
                for (j = 0, c = 1; j <= dataGridView.ColumnCount - 1; j++, c++)
                {
                    wsh.Cells[1, j + 1] = dataGridView.Columns[j].HeaderText.ToString();
                    wsh.Cells[r + 1, c + 1] = dataGridView[j, i].Value.ToString();
                    
                }
            }
            exApp.Visible = true;
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