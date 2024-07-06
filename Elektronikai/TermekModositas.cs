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
    public partial class TermekModositas : UserControl
    {
        public TermekModositas()
        {
            InitializeComponent();
        }

        private void TermekModositas_Load(object sender, EventArgs e)
        {
            // Set textboxes to read-only
            termekNev.Enabled = false;
            tipus.Enabled = false;
            termekAr.Enabled = false;
            termekDatum.Enabled = false;
            gyartoID.Enabled = false;
            eanKod.Enabled = false;

            // Fill the combobox with termek_id values
            FillComboBoxWithTermekIDs();
            FillComboBoxWithGyartoIDs();
        }
        private void FillComboBoxWithTermekIDs()
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            string query = "SELECT termek_id FROM termekek";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        temekID.Items.Add(reader["termek_id"].ToString());
                    }
                }
            }
        }

        private void FillComboBoxWithGyartoIDs()
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            string query = "SELECT gyarto_id FROM gyartok"; // Adjust the table name if needed

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        gyartoID2.Items.Add(reader["gyarto_id"].ToString());
                    }
                }
            }
        }
        private void temekID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FillTextBoxesWithTermekData(string termekID)
        {
            termekNev.Enabled = true;
            tipus.Enabled = true;
            termekAr.Enabled = true;
            termekDatum.Enabled = true;
            gyartoID.Enabled = true;
            eanKod.Enabled = true;
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            string query = "SELECT * FROM termekek WHERE termek_id = @termekID";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@termekID", termekID);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate textboxes with retrieved data
                        termekNev.Text = reader["termek_nev"].ToString();
                        tipus.Text = reader["tipus"].ToString();
                        termekAr.Text = reader["termek_ar"].ToString();
                        termekDatum.Text = reader["termek_datum"].ToString();
                        gyartoID.Text = reader["gyarto_id"].ToString();
                        eanKod.Text = reader["EAN_kod"].ToString();
                    }
                    else
                    {
                        Console.WriteLine("Nem találahtó adat ehhez: termekID: " + termekID);
                    }
                }
            }
        }

        private void modosit_Click(object sender, EventArgs e)
        {
            string selectedTermekID = temekID.SelectedItem.ToString();
            UpdateTermekData(selectedTermekID);
        }

        private void UpdateTermekData(string termekID)
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            string query = "UPDATE termekek SET termek_nev = @termekNev, tipus = @tipus, termek_ar = @termekAr, termek_datum = @termekDatum, gyarto_id = @gyartoID, EAN_kod = @eanKod WHERE termek_id = @termekID";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@termekNev", termekNev.Text);
                    cmd.Parameters.AddWithValue("@tipus", tipus.Text);
                    cmd.Parameters.AddWithValue("@termekAr", termekAr.Text);
                    cmd.Parameters.AddWithValue("@termekDatum", termekDatum.Text);
                    cmd.Parameters.AddWithValue("@gyartoID", gyartoID.Text);
                    cmd.Parameters.AddWithValue("@eanKod", eanKod.Text);
                    cmd.Parameters.AddWithValue("@termekID", termekID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Termék adatok frissítve!");
                    ClearTextBoxes();
                }
            }
            var gigatronForm = (Gigatron)this.ParentForm;
            gigatronForm.FoOldalControl.RefreshDataGridView();
        }

        private void temekID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedTermekID = temekID.SelectedItem.ToString();
            FillTextBoxesWithTermekData(selectedTermekID);

        }

        private void mentes_btn_Click(object sender, EventArgs e)
        {
            // Ensure that the termek_id doesn't already exist
            if (CheckIfTermekIDExists(temekID2.Text))
            {
                MessageBox.Show("Már létezik ilyen ID. Kérlek válassz másikat.");
                return;
            }

            // Insert the new product data into the database
            InsertNewProduct();
        }
        private bool CheckIfTermekIDExists(string termekID)
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            string query = "SELECT COUNT(*) FROM termekek WHERE termek_id = @termekID";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@termekID", termekID);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void InsertNewProduct()
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            string query = "INSERT INTO termekek (termek_id, termek_nev, tipus, termek_ar, termek_datum, gyarto_id, EAN_kod) " +
                           "VALUES (@termekID, @termekNev, @tipus, @termekAr, @termekDatum, @gyartoID, @eanKod)";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@termekID", temekID2.Text);
                    cmd.Parameters.AddWithValue("@termekNev", termekNev2.Text);
                    cmd.Parameters.AddWithValue("@tipus", tipus2.Text);
                    cmd.Parameters.AddWithValue("@termekAr", termekAr2.Text);
                    cmd.Parameters.AddWithValue("@termekDatum", termekDatum2.Value);
                    cmd.Parameters.AddWithValue("@gyartoID", gyartoID2.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@eanKod", eanKod2.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Új termék sikeresen hozzáadva!");

                    // Optionally, clear the textboxes after insertion
                    temekID2.Clear();
                    termekNev2.Clear();
                    tipus2.Clear();
                    termekAr2.Clear();
                    eanKod2.Clear();
                    gyartoID2.SelectedIndex = -1;
                    termekDatum2.Value = DateTime.Now; // Reset to current date or desired default value

                    // Refresh the DataGridView in the FoOldal UserControl
                    var gigatronForm = (Gigatron)this.ParentForm;
                    gigatronForm.FoOldalControl.RefreshDataGridView();
                }
            }
        }

        private void torles_btn_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected in the ComboBox
            if (temekID.SelectedIndex == -1)
            {
                MessageBox.Show("Kérlek válassz egy ID-t, hogy ki lehessen törölni.");
                return;
            }

            // Confirm the deletion
            DialogResult dialogResult = MessageBox.Show("Biztos ki szeretnéd törölni ezt a terméket?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Perform the deletion
                string selectedTermekID = temekID.SelectedItem.ToString();
                DeleteProduct(selectedTermekID);
            }
        }
        private void DeleteProduct(string termekID)
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Elektronikai_szabvany;Integrated Security=SSPI";
            string query = "DELETE FROM termekek WHERE termek_id = @termekID";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@termekID", termekID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Termék sikeresen kitörölve!");

                    // Remove the deleted item from the ComboBox and clear the textboxes
                    temekID.Items.Remove(termekID);
                    ClearTextBoxes();

                    // Refresh the DataGridView in the FoOldal UserControl
                    var gigatronForm = (Gigatron)this.ParentForm;
                    gigatronForm.FoOldalControl.RefreshDataGridView();
                }
            }
        }

        private void ClearTextBoxes()
        {
            termekNev.Enabled = false;
            tipus.Enabled = false;
            termekAr.Enabled = false;
            termekDatum.Enabled = false;
            gyartoID.Enabled = false;
            eanKod.Enabled = false;
            termekNev.Text = "";
            tipus.Text = "";
            termekAr.Text = "";
            termekDatum.Text = "";
            gyartoID.Text = "";
            eanKod.Text = "";
            temekID.Text = "";          // eanKod is a TextBox
        }
    }
}
