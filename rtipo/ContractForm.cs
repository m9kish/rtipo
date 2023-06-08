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
    public partial class ContractForm : Form
    {
        public bool created_contract = false;

        public string order, executor, firstdate, lastdate, number;
        public ContractForm()
        {
            InitializeComponent();

            DataTable table = new();

            table = new DB().DataTable("SELECT * FROM Organisations");
            order_comboBox.DataSource = table;
            order_comboBox.ValueMember = "Full_title";

            table = new DB().DataTable("SELECT * FROM Organisations");
            executor_comboBox.DataSource = table;
            executor_comboBox.ValueMember = "Full_title";
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {          
            if (created_contract == true)
            {
                order_comboBox.Text = order.ToString();
                executor_comboBox.Text = executor.ToString();
                first_dateTimePicker.Text = firstdate.ToString();
                last_dateTimePicker.Text = lastdate.ToString();
                num_textBox.Text = number.ToString();

                order_comboBox.Enabled = false;
                executor_comboBox.Enabled = false;
                first_dateTimePicker.Enabled = false;
                last_dateTimePicker.Enabled = false;
                num_textBox.ReadOnly = true;

            }
        }

        private void editContract_button_Click(object sender, EventArgs e)
        {
            order_comboBox.Enabled = true;
            executor_comboBox.Enabled = true;
            first_dateTimePicker.Enabled = true;
            last_dateTimePicker.Enabled = true;
            num_textBox.ReadOnly = false;
        }
    }
}
