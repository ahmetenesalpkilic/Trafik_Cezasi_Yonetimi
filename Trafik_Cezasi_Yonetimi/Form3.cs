using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Cezasi_Yonetimi
{
    public partial class Form3 : Form
    {
        string sürücütc;
        public Form3(string sürücütc)
        {
            InitializeComponent();

            this.sürücütc = sürücütc;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
