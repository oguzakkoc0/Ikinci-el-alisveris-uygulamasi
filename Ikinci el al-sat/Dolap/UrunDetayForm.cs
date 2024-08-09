using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolap
{
    public partial class UrunDetayForm : Form
    {
        private int urunId;

        public UrunDetayForm()
        {
            InitializeComponent();
        }

        public UrunDetayForm(int urunId)
        {
            this.urunId = urunId;
        }

        private void UrunDetayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
