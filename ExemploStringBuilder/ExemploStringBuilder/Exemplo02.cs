using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploStringBuilder
{
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("__________________________________");
            sb.AppendLine("|\t1\tQboa                       |");
            sb.AppendLine("|\t2\tAmaciante                  |");
            sb.AppendLine("|\t3\tSopa                       |");
            sb.AppendLine("|\t4\tBolo de cenoura            |");
            sb.AppendLine("|________________________________|");

            txtResultado.Text = Convert.ToString(sb);
        }
    }
}
