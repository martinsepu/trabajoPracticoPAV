using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PavTpGrupo11
{
    public partial class EstadisticasProveedoresXbarrio : Form
    {
        public EstadisticasProveedoresXbarrio()
        {
            InitializeComponent();
        }

        private void EstadisticasProveedoresXbarrio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
