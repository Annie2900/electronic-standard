using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Elektronikai
{
    public partial class Gigatron : Form
    {
        public Gigatron()
        {
            InitializeComponent();

            fooldal_btn.Click += new EventHandler(fooldal_btn_Click);
            temerkmodositas_btn.Click += new EventHandler(temerkmodositas_btn_Click);
            vasarlasielozmenyek_btn.Click += new EventHandler(vasarlasielozmenyek_btn_Click);
            kosar_btn.Click += new EventHandler(kosar_btn_Click);
            kereses_btn.Click += new EventHandler(kereses_btn_Click);
            exit_btn.Click += new EventHandler(exit_btn_Click);
        }

        public FoOldal FoOldalControl
        {
            get { return foOldal1; }
        }

        private void HideAllUserControls()
        {
            foOldal1.Visible = false;
            termekModositas1.Visible = false;
            vasarlasiElozmenyek1.Visible = false;
            kosar1.Visible = false;
            login1.Visible = false;
        }

        private void fooldal_btn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            foOldal1.Visible = true;
        }

        private void temerkmodositas_btn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            login1.Visible = true;
        }

        private void vasarlasielozmenyek_btn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            vasarlasiElozmenyek1.Visible = true;
        }

        private void kosar_btn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            kosar1.Visible = true;

        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void kereses_btn_Click(object sender, EventArgs e)
        {
            string searchTerm = tb_search.Text.Trim();
            if (foOldal1.Visible)
            {
                foOldal1.SearchTermekek(searchTerm);
            }
        }

        public void ShowTermekModositas()
        {
            HideAllUserControls();
            termekModositas1.Visible = true;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
