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

namespace Elektronikai
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            string varos = varos_txtbox.Text.Trim();
            string iranyitoszam = iranyitoszam_txtbox.Text.Trim();

            if (ValidateLogin(varos, iranyitoszam))
            {
                varos_txtbox.Text = "";
                iranyitoszam_txtbox.Text = "";
                var parent = (Gigatron)this.Parent;
                parent.ShowTermekModositas();
            }
            else
            {
                MessageBox.Show("Invalid city or postal code. Please try again.");
            }
        }
        private bool ValidateLogin(string varos, string iranyitoszam)
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT COUNT(*) FROM uzletek WHERE varos = @varos AND iranyitoszam = @iranyitoszam";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@varos", varos);
                    cmd.Parameters.AddWithValue("@iranyitoszam", iranyitoszam);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
