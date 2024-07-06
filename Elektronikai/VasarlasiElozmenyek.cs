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
using IronBarCode;

namespace Elektronikai
{
    public partial class VasarlasiElozmenyek : UserControl
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public VasarlasiElozmenyek()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI");
            command = connection.CreateCommand();
            BindGrid();
        }

        private void VasarlasiElozmenyek_Load(object sender, EventArgs e)
        {
            this.BindGrid();
        }
        public void BindGrid()
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM eladasok", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void generalas_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string rowData = GetRowDataAsString(selectedRow);
                string uzletID = selectedRow.Cells["uzlet_id"].Value.ToString();
                string termekID = selectedRow.Cells["termek_id"].Value.ToString();
                string fileName = $"{uzletID}_{termekID}.png";

                QRCodeWriter.CreateQrCode(rowData, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng(fileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(fileName);
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }
        private string GetRowDataAsString(DataGridViewRow row)
        {
            string rowData = "";
            foreach (DataGridViewCell cell in row.Cells)
            {
                rowData += cell.OwningColumn.HeaderText + ": " + cell.Value.ToString() + ", ";
            }
            return rowData.TrimEnd(new char[] { ',', ' ' });
        }
    }
}
