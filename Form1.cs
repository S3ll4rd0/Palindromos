using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindromos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            String Texto = TextBox.Text.ToString();
            String TextoMayus = Texto.ToUpper();
            char[] Array = TextoMayus.ToCharArray();
            if (Array[0] == Array[Array.Length - 1])
            {
                Label.Text = "Si es palíndroma";
            }
            else
            {
                Label.Text = "No es palíndroma";
            }
        }
    }
}
