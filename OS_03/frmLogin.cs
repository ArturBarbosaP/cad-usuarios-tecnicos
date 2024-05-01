using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_03.BLL;

namespace OS_03
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        BLL_Login obj_bllLogin = new BLL_Login();

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "admin@admin.com.br" && txt_senha.Text == "123456")
            {
                frmPrincipal principal = new frmPrincipal();
                this.Visible = false;
                principal.ShowDialog();
                this.Visible = true;
            }
            else if (obj_bllLogin.Logar(txt_usuario.Text, txt_senha.Text) == "Usuario")
            {
                frmOSusuario usuario = new frmOSusuario();
                usuario.ShowDialog();
            }
            else if (obj_bllLogin.Logar(txt_usuario.Text, txt_senha.Text) == "Tecnico")
            {
                frmOStecnico tecnico = new frmOStecnico();
                tecnico.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Incorretos!");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}