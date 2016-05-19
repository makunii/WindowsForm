using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            DbTesteEntities banco = new DbTesteEntities();
            Client cadastro = new Client();
            cadastro.Nome = textNome.Text;
            cadastro.CPF = Convert.ToInt32(textCPF.Text);
            cadastro.Endereco = textEndereco.Text;

            banco.Clients.Add(cadastro);
            banco.SaveChanges();
            MessageBox.Show("Cadastro do(a) " + textNome.Text + " foi realizado com sucesso!");     
           
        }
    }
}
