using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void getValueClick(object sender, System.EventArgs e)
        {
            textBox1.Text = Modulo.Operation.Modulo.modOf(Convert.ToInt64(textBox1.Text)).ToString();
        }

        private void setModuloBlur(object sender, EventArgs e)
        {
            Modulo.Operation.Modulo.ModuloSetNumber = Convert.ToInt64(textBox2.Text);
        }
        
    }

}
