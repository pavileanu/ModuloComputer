using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo.Operation;

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
            NumberBox.Text = ModuloAlgebra.modOf(Convert.ToInt64(NumberBox.Text)).ToString();
        }

        private void setModuloBlur(object sender, EventArgs e)
        {
            long aux;
            if (Int64.TryParse(ModuloBox.Text.ToString(), out aux))
                if (aux > 0)
                {
                    ModuloAlgebra.ModuloSetNumber = aux;
                    return;
                }
          
            MessageBox.Show("Modulo number has to be positive integer!");
        }

        private void Modulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
    }

}
