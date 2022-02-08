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

namespace AccesDonnees1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=gescom;User ID=sa;password=mdp";
            cnx.Open();
            lblMessage.Text = cnx.ToString();
            cnx.Close();
        }
    }
}
