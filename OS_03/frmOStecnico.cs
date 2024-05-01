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
    public partial class frmOStecnico : Form
    {
        public frmOStecnico()
        {
            InitializeComponent();
        }

        DTO_OS obj_dtoOS = new DTO_OS();
        BLL_OS obj_bllOS = new BLL_OS();

        private void Carregar_Grid()
        {
            dtg_listar.DataSource = obj_bllOS.Listar_OS();
            cbx_status.SelectedIndex = -1;
            txt_id.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOStecnico_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoOS.Id = int.Parse(txt_id.Text);
                obj_dtoOS.Status_os = cbx_status.Text;
                obj_bllOS.Alterar_OS(obj_dtoOS);
                MessageBox.Show("Status alterado com sucesso!");
                Carregar_Grid();
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
                obj_dtoOS.Id = int.Parse(txt_id.Text);
                obj_bllOS.Excluir_OS(obj_dtoOS);
                MessageBox.Show("OS excluida com sucesso!");
                Carregar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}