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
    public partial class FrmOktatok : Form
    {
        public string ConnectionString { get; private set; }

        public FrmOktatok(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void LbOktatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbIdopontok.Clear();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT idopont FROM beosztas " +
                    "INNER JOIN tagok ON instruktor = tagok.id " +
                    $"WHERE tagok.nev LIKE '{lbOktatok.SelectedItem}';", c)
                    .ExecuteReader();
                while (r.Read())
                {
                    rtbIdopontok.Text +=
                        $"{r.GetDateTime(0).ToString("yyyy-MM-dd      HH:mm")}\n";
                }
            }
        }

        private void LbOktatok_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ?
            Brushes.Orange : new SolidBrush(e.BackColor);
            g.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawString(
            (sender as ListBox).Items[e.Index].ToString(), e.Font,
                new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void FrmOktatok_Load(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT nev FROM tagok " +
                    "WHERE mester = 1;", c).ExecuteReader();
                while (r.Read()) lbOktatok.Items.Add(r[0]);
            }
        }
    }
}
