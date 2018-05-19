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
    public partial class Principal : Form
    {

        int Opcao = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
//____________________________________________________________________________________________________

        private void txtOpcao_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                if (Opcao == 1)
                {
                Exemplo01 exemplo01 = new Exemplo01();
                exemplo01.Show();
                }
                else if (Opcao == 2)
                {
                    Exemplo02 exemplo02 = new Exemplo02();
                    exemplo02.Show();
                }

            try
            {
                Opcao = Convert.ToInt32(txtOpcao.Text);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite apenas numeros !!");
            }
            }


//_________________________________________________________________________________________________________
        }
    }
}
