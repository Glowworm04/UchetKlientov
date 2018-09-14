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
    public partial class fmAddUsluga : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.KlientiConnectionString);
        SqlDataReader read;
        SqlCommand cmd;
        public fmAddUsluga()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUslaga.Text))
            {
                MessageBox.Show("Введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUslaga.Focus();
                return;
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO dbo.[Usluga] (Name,Opisanie) " +
                    "VALUES (@Name,@Opisanie)", con);
                cmd.Parameters.AddWithValue("Name", tbUslaga.Text);
                cmd.Parameters.AddWithValue("Opisanie", tbOpisanie.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Услуга " + tbUslaga.Text + " зарегистрирована", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanAllTextBoxesIn(this);
        }
        private static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
