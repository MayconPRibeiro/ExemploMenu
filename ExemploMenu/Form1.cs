using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploMenu
{
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
        }//Fim construtor

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            cad.ShowDialog();//Mostrando a tela ao ser chamado
            Visible = true;
        }//Fim do botão cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {
            Visible = false;
            con.ShowDialog();//Mostrando a tela ao ser chamado
            Visible = true;
        }//Fim do botão consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Visible = false;
            atu.ShowDialog();//Mostrando a tela ao ser chamado
            Visible = true;
        }//Fim do botão atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {
            Visible = false;
            exc.ShowDialog();//Mostrando a tela ao ser chamado
            Visible = true;
        }//Fim do botão excluir
    }//Fim da classe
}//Fim do projeto
