using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_01
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            lb_mensagem.Text = "Olá, Amigo " + tBox_nome.Text + 
                "\n Seu curso é: " + cBox_curso.Text;
        }

        private void lb_mensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
