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
    public partial class AuthForm : Form, IUser
    {
        public MainForm mainForm;
        public AuthForm()
        {
            InitializeComponent();
            //mainForm = new MainForm(this) { Visible = false };
            mainForm = new MainForm();
        }

        public string LoginText { get => textBox_login.Text; set => textBox_login.Text = value; }
        public string PasswordText { get => textBox_password.Text; set => textBox_password.Text = value; }
        public bool AuthText { get => false; set { } }

        private void button_auth_Click(object sender, EventArgs e)
        {
            String login = textBox_login.Text;
            String password = textBox_password.Text;

            UserPresenter presenter = new UserPresenter(this);

            bool result = presenter.Auth(login, password);

            if (result)
            {
                /*this.Visible = false;
                mainForm.Visible = true;*/
                mainForm.Show();
                this.Hide();
            }

            else
                MessageBox.Show("Неправильный логин или пароль");

            //Этот код был написан сразу в форме в событии кнопки, я переделал на архитектуру MVP (почти то же самое что MVC)
            /*DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `Login` = @log AND `Password` = @pas", db.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Visible = false;
                startMenuForm.Visible = true;
                MessageBox.Show("Вы авторизованы");
            }
                
            else
                MessageBox.Show("Ошибка");*/
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
