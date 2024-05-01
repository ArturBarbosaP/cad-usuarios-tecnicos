namespace OS_03
{
    partial class frmOSusuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_criar = new System.Windows.Forms.Button();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dtg_listar = new System.Windows.Forms.DataGridView();
            this.lbl_tecnico = new System.Windows.Forms.Label();
            this.cbx_tecnico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(464, 288);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 17;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(251, 288);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(75, 23);
            this.btn_listar.TabIndex = 15;
            this.btn_listar.Text = "Listar OS";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(38, 288);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(75, 23);
            this.btn_criar.TabIndex = 14;
            this.btn_criar.Text = "Criar OS";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(218, 243);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(152, 20);
            this.txt_descricao.TabIndex = 13;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(38, 243);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(152, 20);
            this.txt_id.TabIndex = 12;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(215, 217);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(58, 13);
            this.lbl_descricao.TabIndex = 11;
            this.lbl_descricao.Text = "Descrição:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(35, 217);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "ID:";
            // 
            // dtg_listar
            // 
            this.dtg_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listar.Location = new System.Drawing.Point(38, 22);
            this.dtg_listar.Name = "dtg_listar";
            this.dtg_listar.Size = new System.Drawing.Size(502, 166);
            this.dtg_listar.TabIndex = 9;
            // 
            // lbl_tecnico
            // 
            this.lbl_tecnico.AutoSize = true;
            this.lbl_tecnico.Location = new System.Drawing.Point(392, 217);
            this.lbl_tecnico.Name = "lbl_tecnico";
            this.lbl_tecnico.Size = new System.Drawing.Size(49, 13);
            this.lbl_tecnico.TabIndex = 18;
            this.lbl_tecnico.Text = "Técnico:";
            // 
            // cbx_tecnico
            // 
            this.cbx_tecnico.FormattingEnabled = true;
            this.cbx_tecnico.Location = new System.Drawing.Point(395, 243);
            this.cbx_tecnico.Name = "cbx_tecnico";
            this.cbx_tecnico.Size = new System.Drawing.Size(145, 21);
            this.cbx_tecnico.TabIndex = 19;
            // 
            // frmOSusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 332);
            this.Controls.Add(this.cbx_tecnico);
            this.Controls.Add(this.lbl_tecnico);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.dtg_listar);
            this.Name = "frmOSusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOSusuario";
            this.Load += new System.EventHandler(this.frmOSusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridView dtg_listar;
        private System.Windows.Forms.Label lbl_tecnico;
        private System.Windows.Forms.ComboBox cbx_tecnico;
    }
}