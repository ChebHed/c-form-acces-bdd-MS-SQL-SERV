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
    public partial class LireUnClient : Form
    {
        public LireUnClient()
        {
            InitializeComponent();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //connexion BDD
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=gescom;User ID=sa;password=mdp";
            cnx.Open();
            //lblMessage.Text = cnx.ToString();
            cnx.Close();

            //construire la requete
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from client where id_client = " + txtIdClient.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            //Construire le dataset
            DataSet ds = new DataSet();

            //Remplir le dataset
            da.Fill(ds, "client");
            //fermer la connexion
            cnx.Close();

            // Récupérer la table client
            DataTable dt = ds.Tables["client"];
            // Exploiter les données de la table
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                lblRSClient.Text = dr["rs_client"].ToString();
                lblCAClient.Text = dr["ca_client"].ToString();
            }
            else
            {
                MessageBox.Show("Le client n° : " + txtIdClient.Text + " n'existe pas.");
            }
        }
    }
}
