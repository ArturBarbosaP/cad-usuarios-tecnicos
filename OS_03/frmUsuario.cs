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
using OS_03.DTO;

namespace OS_03
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        BLL_Usuario obj_bllUsuario = new BLL_Usuario();
        BLL_Setor obj_bllSetor = new BLL_Setor();
        DTO_Usuario obj_dtoUsuario = new DTO_Usuario();

        public void CarregarGrid()
        {
            try
            {
                cbx_setor.DataSource = obj_bllSetor.ConsultarSetor();
                cbx_setor.DisplayMember = "descricao";
                cbx_setor.ValueMember = "id";
                dtg_usuarios.DataSource = obj_bllUsuario.ListarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpar()
        {
            txt_email.Clear();
            txt_id.Clear();
            txt_nome.Clear();
            txt_telefone.Clear();
            txt_senha.Clear();
            cbx_setor.SelectedIndex = -1;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoUsuario.Nome = txt_nome.Text;
                obj_dtoUsuario.Telefone = txt_telefone.Text;
                obj_dtoUsuario.Email = txt_email.Text;
                obj_dtoUsuario.Id_Setor = int.Parse(cbx_setor.SelectedValue.ToString());
                obj_dtoUsuario.Senha = txt_senha.Text;
                obj_bllUsuario.CadUsuario(obj_dtoUsuario);
                MessageBox.Show("Cadastro efetuado com sucesso");
                CarregarGrid();
                Limpar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoUsuario.Id = int.Parse(txt_id.Text);
                obj_bllUsuario.ExcluirUsuario(obj_dtoUsuario);
                MessageBox.Show("Cadastro excluido com sucesso");
                CarregarGrid();
                Limpar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}