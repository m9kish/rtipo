using rtipo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rtipo
{
    public partial class OrganisationForm : Form
    {
        public bool created_org = false;
        public string title, inn, kpp, adres, ip, type, location;
        public OrganisationForm()
        {
            InitializeComponent();

            DataTable table = new();

            table = new DB().DataTable("SELECT * FROM OrganisationTypes");
            type_comboBox.DataSource = table;
            type_comboBox.ValueMember = "Title";

            table = new DB().DataTable("SELECT * FROM Localities");
            location_comboBox.DataSource = table;
            location_comboBox.ValueMember = "Title";
        }

        private void OrganisationForm_Load(object sender, EventArgs e)
        {
            if (created_org == true)
            {
                location_comboBox.Text = location.ToString();
                type_comboBox.Text = type.ToString();
                title_textBox.Text = title.ToString();
                inn_textBox.Text = inn.ToString();
                kpp_textBox.Text = kpp.ToString();
                adres_textBox.Text = adres.ToString();
                ip_comboBox.Text = ip.ToString();

                location_comboBox.Enabled = false;
                type_comboBox.Enabled = false;
                title_textBox.ReadOnly = true;
                inn_textBox.ReadOnly = true;
                kpp_textBox.ReadOnly = true;
                adres_textBox.ReadOnly = true;
                ip_comboBox.Enabled = false;
            }
        }

        private void editOrg_button_Click(object sender, EventArgs e)
        {
            location_comboBox.Enabled = true;
            type_comboBox.Enabled = true;
            title_textBox.ReadOnly = false;
            inn_textBox.ReadOnly = false;
            kpp_textBox.ReadOnly = false;
            adres_textBox.ReadOnly = false;
            ip_comboBox.Enabled = true;
        }
    }
}
