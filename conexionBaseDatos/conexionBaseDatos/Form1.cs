using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace conexionBaseDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Data.SqlClient.SqlConnection conn =
                new System.Data.SqlClient.SqlConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            //conn.ConnectionString =
            // "integrated security=SSPI;data source=SQL Server Name;" +
            // "persist security info=False;initial catalog=primeraconexion";

            conn.ConnectionString =
            "Data Source=localhost;" +
            "Initial Catalog=primeraconexion;" +
            "User id=umantram;" +
            "Password=Secret;";

            

            try
            {
                conn.Open();
                // Insert code to process data.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
