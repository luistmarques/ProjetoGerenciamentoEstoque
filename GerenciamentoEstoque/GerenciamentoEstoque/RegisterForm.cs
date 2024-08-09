using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEstoque
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(tbRegisterUsername.Text == "" || tbRegisterSenha.Text == "" || tbRegisterSenhaC.Text == "")
            {
                MessageBox.Show("Porfavor, Informe todos os campos corretamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
