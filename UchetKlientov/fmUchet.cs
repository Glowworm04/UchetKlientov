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
    public partial class fmUchet : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.KlientiConnectionString);
        SqlDataReader read;
        SqlCommand cmd;

        public fmUchet()
        {
            InitializeComponent();
        }

        private void klientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klientiDataSet);

        }

        private void fmUchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klientiDataSet.Usluga". При необходимости она может быть перемещена или удалена.
            this.uslugaTableAdapter.Fill(this.klientiDataSet.Usluga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klientiDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.klientiDataSet.Klient);

            this.Text +=" ("+Program.Zagolovok+")";
            cbUsluga.SelectedIndex = -1;

            if (Program.Zagolovok == "Администратор")
            {
                добавитьУслугуToolStripMenuItem.Visible = true;
            }
            else
            {
                добавитьУслугуToolStripMenuItem.Visible = false;
            }

        }

        private void dgvKlient_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tbNum.Text = dgvKlient.SelectedRows[0].Cells[0].Value.ToString();
                tbFIOKlienta.Text = dgvKlient.SelectedRows[0].Cells[1].Value.ToString();
                tbFIOSoprovozhd.Text = dgvKlient.SelectedRows[0].Cells[2].Value.ToString();
                mtbPhone.Text = dgvKlient.SelectedRows[0].Cells[3].Value.ToString();
                dtpDateOfBirth.Text = dgvKlient.SelectedRows[0].Cells[4].Value.ToString();
                cbUsluga.Text = dgvKlient.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ups!");
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFIOKlienta.Text))
            {
                MessageBox.Show("Введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFIOKlienta.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbFIOSoprovozhd.Text))
            {
                MessageBox.Show("Введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFIOSoprovozhd.Focus();
                return;
            }
            //else if (string.IsNullOrEmpty(mtbPhone.Text))
            //{
            //    MessageBox.Show("Введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mtbPhone.Focus();
            //    return;
            //}
            else if (string.IsNullOrEmpty(cbUsluga.Text))
            {
                MessageBox.Show("Введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUsluga.Focus();
                return;
            }

            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO dbo.[Klient] (FIOKlienta,FIORoditela,Phone,DateOfBirth,Usluga) " +
                    "VALUES (@FIOKlienta,@FIORoditela,@Phone,@DateOfBirth,@Usluga)", con);
                cmd.Parameters.AddWithValue("FIOKlienta", tbFIOKlienta.Text);
                cmd.Parameters.AddWithValue("FIORoditela", tbFIOSoprovozhd.Text);
                cmd.Parameters.AddWithValue("Phone", mtbPhone.Text);
                cmd.Parameters.AddWithValue("DateOfBirth", dtpDateOfBirth.Text);
                cmd.Parameters.AddWithValue("Usluga", cbUsluga.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Клиент "+tbFIOKlienta.Text+" зарегистрирован\n для просмотра обновите данные", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanAllTextBoxesIn(this);
            dtpDateOfBirth.ResetText();
            cbUsluga.SelectedIndex = -1;
            mtbPhone.Text="";
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

        private async void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(FIOKlienta,FIORoditela,Phone,DateOfBirth,Usluga)
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Klient] SET [FIOKlienta]=@FIOKlienta, " +
            "[FIORoditela]=@FIORoditela, [Phone]=@Phone, [DateOfBirth]=@DateOfBirth, [Usluga]=@Usluga WHERE [Id]=@Id", con);

            int num = Convert.ToInt32(tbNum.Text);
            cmd.Parameters.AddWithValue("Id", num);
            cmd.Parameters.AddWithValue("FIOKlienta", tbFIOKlienta.Text);
            cmd.Parameters.AddWithValue("FIORoditela", tbFIOSoprovozhd.Text);
            cmd.Parameters.AddWithValue("Phone", mtbPhone.Text);
            cmd.Parameters.AddWithValue("DateOfBirth", dtpDateOfBirth.Text);
            cmd.Parameters.AddWithValue("Usluga", cbUsluga.Text);



            await cmd.ExecuteNonQueryAsync();
            MessageBox.Show("Данные отредактированы. Для просмотра обновите таблицу данных");
            con.Close();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Klient";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dgvKlient.DataSource = dt;
            con.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Application.Exit(); }
            else
            { return; }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvKlient.Rows.Remove(this.dgvKlient.CurrentRow);
                this.klientTableAdapter.Update(this.klientiDataSet);
                MessageBox.Show("Удалено");
            }
            catch
            {
                MessageBox.Show("Ups!");
            }
        }

        private void добавитьУслугуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAddUsluga addUsluga = new fmAddUsluga();
            addUsluga.ShowDialog();
        }

        private void экпортВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            excel.Columns.ColumnWidth = 30;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Отчет по клиентам";

                int cellRowIndex = 2;
                int cellColumnIndex = 1;

                (worksheet.Cells[1, 1] as Microsoft.Office.Interop.Excel.Range).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                (worksheet.Cells[1, 2] as Microsoft.Office.Interop.Excel.Range).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                (worksheet.Cells[1, 3] as Microsoft.Office.Interop.Excel.Range).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                (worksheet.Cells[1, 4] as Microsoft.Office.Interop.Excel.Range).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                (worksheet.Cells[1, 5] as Microsoft.Office.Interop.Excel.Range).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                worksheet.Cells[1, 1].Font.Bold = true;
                worksheet.Cells[1, 1].Font.Size = 14;
                worksheet.Cells[1, 1].Font.Name = "Gabriola";
                worksheet.Cells[1, 2].Font.Bold = true;
                worksheet.Cells[1, 2].Font.Size = 14;
                worksheet.Cells[1, 2].Font.Name = "Gabriola";
                worksheet.Cells[1, 3].Font.Bold = true;
                worksheet.Cells[1, 3].Font.Size = 14;
                worksheet.Cells[1, 3].Font.Name = "Gabriola";
                worksheet.Cells[1, 4].Font.Bold = true;
                worksheet.Cells[1, 4].Font.Size = 14;
                worksheet.Cells[1, 4].Font.Name = "Gabriola";
                worksheet.Cells[1, 5].Font.Bold = true;
                worksheet.Cells[1, 5].Font.Size = 14;
                worksheet.Cells[1, 5].Font.Name = "Gabriola";
                worksheet.Cells[1, 6].Font.Bold = true;
                worksheet.Cells[1, 6].Font.Size = 14;
                worksheet.Cells[1, 6].Font.Name = "Gabriola";

                excel.Cells[1, 1] = "№п/п";
                excel.Cells[1, 2] = "ФИО клиента";
                excel.Cells[1, 3] = "ФИО родителей";
                excel.Cells[1, 4] = "Номер телефона";
                excel.Cells[1, 5] = "Дата рождения";
                excel.Cells[1, 6] = "услуга";



                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgvKlient.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKlient.Columns.Count; j++)
                    {

                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 0)
                        {

                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvKlient.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Font.Size = 14;
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Font.Name = "Gabriola";
                        }
                        else
                        {

                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvKlient.Rows[i].Cells[j].Value.ToString();
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Font.Size = 14;
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Font.Name = "Gabriola";
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Выполнено успешно");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Visible = true;
                workbook = null;
                excel = null;

            }

        }

        private void tbFIOKlienta_TextChanged(object sender, EventArgs e)
        {
            klientBindingSource.Filter = "FIOKlienta LIKE'" + tbFIOKlienta.Text + "%'";
        }
    }
}
