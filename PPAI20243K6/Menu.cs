using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI20243K6
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void opc_GenerarRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaRankingVinos pantalla = new PantallaRankingVinos();
            pantalla.Show();
        }
    }
}
