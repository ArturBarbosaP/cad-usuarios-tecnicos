using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_03.DTO;
using OS_03.BLL;

namespace OS_03
{
    public partial class frmOSusuario : Form
    {
        public frmOSusuario()
        {
            InitializeComponent();
        }

        DTO_OS obj_dtoOS = new DTO_OS();
        BLL_OS obj_bllOS = new BLL_OS();
        BLL_Tecnico obj_bllTecnico = new BLL_Tecnico();
        BLL_Login obj_bllLogin = new BLL_Login();

        private void Carregar_Grid()
        {
            try
            {
                obj_dtoOS.Usuario = obj_bllLogin.ID_Usuario();
                dtg_listar.DataSource = obj_bllOS.Listar_OS_Usuario(obj_dtoOS);
                cbx_tecnico.DataSource = obj_bllTecnico.ListarTecnico();
                cbx_tecnico.DisplayMember = "nome";
                cbx_tecnico.ValueMember = "id";
                txt_descricao.Clear();
                txt_id.Clear();
                cbx_tecnico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoOS.Descricao = txt_descricao.Text;
                obj_dtoOS.Status_os = "EM ABERTO";
                obj_dtoOS.Tecnico = int.Parse(cbx_tecnico.SelectedValue.ToString());
                obj_dtoOS.Usuario = obj_bllLogin.ID_Usuario();
                obj_bllOS.Criar_OS(obj_dtoOS);
                MessageBox.Show("OS criada com sucesso!");
                Carregar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmOSusuario_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            frmOStecnico tecnico = new frmOStecnico();
            tecnico.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
