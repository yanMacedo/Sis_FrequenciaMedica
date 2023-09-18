namespace FrequenciaMedica.Telas
{
    partial class Form_Frequencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Frequencia));
            this.dgv_Master = new System.Windows.Forms.DataGridView();
            this.GRID_Ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvNumCra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiraCc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSinc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TituloMaior = new System.Windows.Forms.Label();
            this.chk_InverteSelecao = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Master)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Master
            // 
            this.dgv_Master.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Master.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRID_Ok,
            this.dgvNumCra,
            this.dgvNumCad,
            this.dgvData,
            this.dgvHora,
            this.dgvNome,
            this.dgvDiraCc,
            this.dgvSinc});
            resources.ApplyResources(this.dgv_Master, "dgv_Master");
            this.dgv_Master.Name = "dgv_Master";
            this.dgv_Master.RowTemplate.Height = 25;
            // 
            // GRID_Ok
            // 
            resources.ApplyResources(this.GRID_Ok, "GRID_Ok");
            this.GRID_Ok.Name = "GRID_Ok";
            // 
            // dgvNumCra
            // 
            this.dgvNumCra.DataPropertyName = "NUMCRA";
            resources.ApplyResources(this.dgvNumCra, "dgvNumCra");
            this.dgvNumCra.Name = "dgvNumCra";
            this.dgvNumCra.ReadOnly = true;
            // 
            // dgvNumCad
            // 
            this.dgvNumCad.DataPropertyName = "NUMCAD";
            resources.ApplyResources(this.dgvNumCad, "dgvNumCad");
            this.dgvNumCad.Name = "dgvNumCad";
            this.dgvNumCad.ReadOnly = true;
            // 
            // dgvData
            // 
            this.dgvData.DataPropertyName = "DATA";
            resources.ApplyResources(this.dgvData, "dgvData");
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            // 
            // dgvHora
            // 
            this.dgvHora.DataPropertyName = "HORA";
            resources.ApplyResources(this.dgvHora, "dgvHora");
            this.dgvHora.Name = "dgvHora";
            this.dgvHora.ReadOnly = true;
            // 
            // dgvNome
            // 
            this.dgvNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNome.DataPropertyName = "NOME";
            resources.ApplyResources(this.dgvNome, "dgvNome");
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.ReadOnly = true;
            // 
            // dgvDiraCc
            // 
            this.dgvDiraCc.DataPropertyName = "DIRACC";
            resources.ApplyResources(this.dgvDiraCc, "dgvDiraCc");
            this.dgvDiraCc.Name = "dgvDiraCc";
            this.dgvDiraCc.ReadOnly = true;
            // 
            // dgvSinc
            // 
            this.dgvSinc.DataPropertyName = "SINC";
            resources.ApplyResources(this.dgvSinc, "dgvSinc");
            this.dgvSinc.Name = "dgvSinc";
            this.dgvSinc.ReadOnly = true;
            // 
            // lbl_TituloMaior
            // 
            resources.ApplyResources(this.lbl_TituloMaior, "lbl_TituloMaior");
            this.lbl_TituloMaior.Name = "lbl_TituloMaior";
            // 
            // chk_InverteSelecao
            // 
            resources.ApplyResources(this.chk_InverteSelecao, "chk_InverteSelecao");
            this.chk_InverteSelecao.Name = "chk_InverteSelecao";
            this.chk_InverteSelecao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbl_Titulo
            // 
            resources.ApplyResources(this.lbl_Titulo, "lbl_Titulo");
            this.lbl_Titulo.Name = "lbl_Titulo";
            // 
            // Form_Frequencia
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_InverteSelecao);
            this.Controls.Add(this.lbl_TituloMaior);
            this.Controls.Add(this.dgv_Master);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form_Frequencia";
            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Frequencia_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_Master;
        private Label lbl_TituloMaior;
        private CheckBox chk_InverteSelecao;
        private Button button1;
        private Button button2;
        private Label lbl_Titulo;
        private DataGridView dgv_TabelaFrequencia;
        private DataGridView dataGridView1;
        private Button button3;
        private DataGridViewCheckBoxColumn GRID_Ok;
        private DataGridViewTextBoxColumn dgvNumCra;
        private DataGridViewTextBoxColumn dgvNumCad;
        private DataGridViewTextBoxColumn dgvData;
        private DataGridViewTextBoxColumn dgvHora;
        private DataGridViewTextBoxColumn dgvNome;
        private DataGridViewTextBoxColumn dgvDiraCc;
        private DataGridViewTextBoxColumn dgvSinc;
    }
}