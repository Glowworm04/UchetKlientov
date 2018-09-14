using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetKlientov
{
    public partial class fmAvtorizacia : Form
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.KlientiConnectionString);
        SqlDataReader read;
        SqlCommand cmd;
        public fmAvtorizacia()
        {
            InitializeComponent();
        }

        private void btnVhod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Введите Логин");
                tbLogin.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Введите Пароль");
                tbPassword.Focus();
                return;
            }
            else
            {
                connect.Open(); //открытие подключения к БД

                cmd = new SqlCommand(@"SELECT [Password],[Dolzhnost] FROM dbo.[Avtorizacia] WHERE Login='" + tbLogin.Text + "'", connect);
                try
                {
                    read = cmd.ExecuteReader();
                    read.Read();

                    if (tbPassword.Text == read[0].ToString())
                    {
                        Program.Login = tbLogin.Text;
                        Program.Password = tbPassword.Text;
                        Program.Dolzhnost = read[1].ToString();

                        switch (Program.Dolzhnost)
                        {
                            case "Администратор":
                                this.Visible = false;
                                fmUchet administrator = new fmUchet();
                                Program.Zagolovok = Program.Dolzhnost;
                                administrator.ShowDialog();
                                tbLogin.Clear();
                                tbPassword.Clear();
                                this.Visible = true;
                                break;

                            case "Менеджер":
                                this.Visible = false;
                                fmUchet manager = new fmUchet();
                                Program.Zagolovok = Program.Dolzhnost;
                                manager.ShowDialog();
                                tbLogin.Clear();
                                tbPassword.Clear();
                                this.Visible = true;
                                break;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Связка логин-пароль введена не верно\n Проверьте введенные данные и повторите попытку");
                        tbLogin.Focus();
                        read.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Пользователь с таким имененм не зарегистрирован в системе \n Проверьте введенные данные и повторите попытку");
                    tbLogin.Focus();
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Application.Exit(); }
            else
            { return; }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
