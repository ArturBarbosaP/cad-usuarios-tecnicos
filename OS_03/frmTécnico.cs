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
    public partial class frmTécnico : Form
    {
        public frmTécnico()
        {
            InitializeComponent();
        }

        BLL_Tecnico obj_bllTecnico = new BLL_Tecnico();
        BLL_Especialidade obj_bllEspecialidade = new BLL_Especialidade();
        DTO_Tecnico obj_dtoTecnico = new DTO_Tecnico();

        public void CarregarGrid()
        {
            try
            {
                cbx_especialidade.DataSource = obj_bllEspecialidade.ConsultarEspecialidade();
                cbx_especialidade.DisplayMember = "descricao";
                cbx_especialidade.ValueMember = "id";
                dtg_tecnico.DataSource = obj_bllTecnico.ListarTecnico();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Limpar()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_email.Clear();
            txt_senha.Clear();
            cbx_especialidade.SelectedIndex = -1;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoTecnico.Nome = txt_nome.Text;
                obj_dtoTecnico.Id_espec = int.Parse(cbx_especialidade.SelectedValue.ToString());
                obj_dtoTecnico.Email = txt_email.Text;
                obj_dtoTecnico.Senha = txt_senha.Text;
                obj_bllTecnico.CadTecnico(obj_dtoTecnico);
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
                obj_dtoTecnico.Id = int.Parse(txt_id.Text);
                obj_bllTecnico.ExcluirTecnico(obj_dtoTecnico);
                MessageBox.Show("Tecnico excluido com sucesso");
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

        private void frmTécnico_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}