using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Elektronikai
{
    public partial class FoOldal : UserControl
    {
        public FoOldal()
        {
            InitializeComponent();
        }

        private void FoOldal_Load(object sender, EventArgs e)
        {
            this.BindGrid();

        }
        public void BindGrid()
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM termekek", con))
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
        public void RefreshDataGridView()
        {
            // Call your method to rebind data to the DataGridView
            BindGrid();
        }
        public void SearchTermekek(string searchTerm)
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT * FROM termekek WHERE termek_nev LIKE @searchTerm";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
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
    }
}
