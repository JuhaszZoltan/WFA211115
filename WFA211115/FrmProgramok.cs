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

namespace WFA211115
{
    public partial class FrmProgramok : Form
    {
        public string ConnectionString { get; private set; }

        public FrmProgramok(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmProgramok_Load(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT nev FROM tagok WHERE mester = 1;",
                    c).ExecuteReader();
                while (r.Read()) cbOktatok.Items.Add(r[0]);
                r.Close();

                r = new SqlCommand(
                    "SELECT nev FROM pozok;", c).ExecuteReader();
                while (r.Read()) cbGyakorlat.Items.Add(r[0]);
                r.Close();

                r = new SqlCommand(
                    "SELECT idopont, tagok.nev, pozok.nev, diakok " +
                    "FROM tagok " +
                    "INNER JOIN beosztas ON instruktor = tagok.id " +
                    "INNER JOIN pozok ON tananyag = pozok.id;",
                    c).ExecuteReader();

                while (r.Read())
                {
                    dgvProgramok.Rows.Add(
                        r.GetDateTime(0).ToString("yyyy-MM-dd"),
                        r.GetDateTime(0).ToString("HH:mm"),
                        r[1],
                        r[2],
                        r.GetString(3).Split('-').Length);
                }
            }
        }


    }
}
