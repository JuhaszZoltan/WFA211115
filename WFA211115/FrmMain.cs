using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA211115
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; private set; }

        public FrmMain()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = jogastudio;";
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e) 
            => Application.Exit();

        private void btnOktatok_Click(object sender, EventArgs e)
            => new FrmOktatok(ConnectionString).ShowDialog();

        private void btnProgramok_Click(object sender, EventArgs e)
            => new FrmProgramok(ConnectionString).ShowDialog();
    }
}
