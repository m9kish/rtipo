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
            dataGridView.Columns[1].HeaderText = "����� �����������";
            dataGridView.Columns[2].HeaderText = "��� ��������";
            dataGridView.Columns[3].HeaderText = "����� ����";
            dataGridView.Columns[4].HeaderText = "������";
            dataGridView.Columns[5].HeaderText = "���";
            dataGridView.Columns[6].HeaderText = "����";
            dataGridView.Columns[7].HeaderText = "������������� �����";
            dataGridView.Columns[8].HeaderText = "�������� ���������";
            dataGridView.Columns[9].HeaderText = "���������";
            dataGridView.Columns[10].HeaderText = "�������";

        }

        private void organisations_fill_button_Click(object sender, EventArgs e)
        {
            FillOrganisationsPresenter presenterOrg = new FillOrganisationsPresenter(this);
            dataGridView.DataSource = presenterOrg.FillTable();
            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "�������� �����������";
            dataGridView.Columns[2].HeaderText = "���";
            dataGridView.Columns[3].HeaderText = "���";
            dataGridView.Columns[4].HeaderText = "����� �����������";
            dataGridView.Columns[5].HeaderText = "��";
            dataGridView.Columns[6].HeaderText = "��� �����������";
            dataGridView.Columns[7].HeaderText = "�������";
        }

        private void contracts_fill_button_Click(object sender, EventArgs e)
        {
            FillContractsPresenter presenterContracts = new FillContractsPresenter(this);
            dataGridView.DataSource = presenterContracts.FillTable();
            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "���� ����������";
            dataGridView.Columns[2].HeaderText = "���� ���������";
            dataGridView.Columns[3].HeaderText = "����� ���������";
            dataGridView.Columns[4].HeaderText = "��������";
            dataGridView.Columns[5].HeaderText = "�����������";
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
            // �������� ��������� ����
            string filename = saveFileDialog1.FileName;
            // ��������� ����� � ����
            //System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("���� ��������");
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