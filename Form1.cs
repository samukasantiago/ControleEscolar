using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEscolar
{
    public partial class FrmMedia : Form
    {
        private object txtBim1;
        private object txtBim2;

        public FrmMedia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FrmMedia_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Aqui é um comentário 
            // Criando as variaveis 
            // boa pratica criar as variaveis 
            decimal nota1 = decimal.Parse(txtN1.Text);
            decimal nota2 = decimal.Parse(txtN2.Text);
            decimal nota3 = decimal.Parse(txtN3.Text);
            decimal nota4 = decimal.Parse(txtN4.Text);
            decimal media1, media2, mediaFinal;
            if (nota1 > 10|| nota1 < 0){
                // só para colocar o cursor na caixinha que esta com erro
                txtN1.Focus();
                //mostrar mensagem para usuario
                MessageBox.Show("A nota 1 está errada, notas entre 0 e 10", "Erro Nota 1",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //finalizar o código, quando aparece o return o código é finalizado.
                return;
            }
            if (nota2 > 10 || nota2 < 0)
            {
                // só para colocar o cursor na caixinha que esta com erro
                txtN2.Focus();
                //mostrar mensagem para usuario
                MessageBox.Show("A nota 2 está errada, notas entre 0 e 10", "Erro Nota 2",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //finalizar o código, quando aparece o return o código é finalizado.
                return;
            }
            if (nota3 > 10|| nota3 < 0)
            {
                // só para colocar o cursor na caixinha que esta com erro
                txtN3.Focus();
                //mostrar mensagem para usuario
                MessageBox.Show("A nota 1 está errada, notas entre 0 e 10", "Erro Nota 1",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //finalizar o código, quando aparece o return o código é finalizado.
                return;
            }
            if (nota4 > 10 || nota4 < 0)
            {
                // só para colocar o cursor na caixinha que esta com erro
                txtN4.Focus();
                //mostrar mensagem para usuario
                MessageBox.Show("A nota 1 está errada, notas entre 0 e 10", "Erro Nota 1",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //finalizar o código, quando aparece o return o código é finalizado.
                return;
            }
            // o C# é case sensitive, faz diferenciação entre maiusculo e minusculo
            // Parse = transformar, neste caso em decimal
            nota1 = decimal.Parse(txtN1.Text);
            nota2 = decimal.Parse(txtN2.Text);
            nota3 = decimal.Parse(txtN3.Text);
            // calculo das médias 
            media1 = ((nota1 * 4) + (nota2 * 6)) / 10;
            media2 = ((nota3 * 4) + (nota4 * 6)) / 10;
            mediaFinal = (media1 + media2) / 2;
            // mostrar as médias 
            //.ToString() = transformar rm texto isto é um método/função
            Bim1.Text = media1.ToString();
            Bim2.Text = media2.ToString();     
            txtMedia.Text = mediaFinal.ToString();
        }

        private void txtID_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

