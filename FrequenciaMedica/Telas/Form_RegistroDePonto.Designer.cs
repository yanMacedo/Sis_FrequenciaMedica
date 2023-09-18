namespace FrequenciaMedica.Telas
{
    partial class Form_RegistroDePonto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegistroDePonto));
            this.flp_Barra = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_DataHora = new System.Windows.Forms.Label();
            this.img_Colaborador = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_NomeDoColaborador = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Registrado = new System.Windows.Forms.Label();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.lbl_Equipe = new System.Windows.Forms.Label();
            this.lbl_UltimoPonto = new System.Windows.Forms.Label();
            this.pic_LogoImetame = new System.Windows.Forms.PictureBox();
            this.lbl_ContaRegistros = new System.Windows.Forms.Label();
            this.timer_DataHora = new System.Windows.Forms.Timer(this.components);
            this.lbl_UltimaViagem = new System.Windows.Forms.Label();
            this.lbl_Alocacao = new System.Windows.Forms.Label();
            this.lbl_LiberadoBloqueado = new System.Windows.Forms.Label();
            this.lbl_barraInferior = new System.Windows.Forms.Label();
            this.flp_Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Colaborador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoImetame)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Barra
            // 
            this.flp_Barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Barra.BackColor = System.Drawing.Color.Green;
            this.flp_Barra.Controls.Add(this.label2);
            this.flp_Barra.Controls.Add(this.label3);
            this.flp_Barra.Controls.Add(this.lbl_DataHora);
            this.flp_Barra.Location = new System.Drawing.Point(0, 25);
            this.flp_Barra.Name = "flp_Barra";
            this.flp_Barra.Size = new System.Drawing.Size(781, 95);
            this.flp_Barra.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(778, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(772, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 4;
            // 
            // lbl_DataHora
            // 
            this.lbl_DataHora.AutoSize = true;
            this.lbl_DataHora.BackColor = System.Drawing.Color.White;
            this.lbl_DataHora.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataHora.Location = new System.Drawing.Point(766, 0);
            this.lbl_DataHora.Name = "lbl_DataHora";
            this.lbl_DataHora.Size = new System.Drawing.Size(0, 23);
            this.lbl_DataHora.TabIndex = 5;
            // 
            // img_Colaborador
            // 
            this.img_Colaborador.BackColor = System.Drawing.Color.White;
            this.img_Colaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_Colaborador.Location = new System.Drawing.Point(44, 82);
            this.img_Colaborador.Name = "img_Colaborador";
            this.img_Colaborador.Size = new System.Drawing.Size(127, 168);
            this.img_Colaborador.TabIndex = 2;
            this.img_Colaborador.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 7);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(124, 15);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "FREQUENCIA MÉDICA";
            // 
            // lbl_NomeDoColaborador
            // 
            this.lbl_NomeDoColaborador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NomeDoColaborador.AutoSize = true;
            this.lbl_NomeDoColaborador.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomeDoColaborador.Location = new System.Drawing.Point(191, 138);
            this.lbl_NomeDoColaborador.Name = "lbl_NomeDoColaborador";
            this.lbl_NomeDoColaborador.Size = new System.Drawing.Size(0, 25);
            this.lbl_NomeDoColaborador.TabIndex = 2;
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Matricula.Location = new System.Drawing.Point(191, 181);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(0, 25);
            this.lbl_Matricula.TabIndex = 3;
            // 
            // lbl_Registrado
            // 
            this.lbl_Registrado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Registrado.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_Registrado.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Registrado.ForeColor = System.Drawing.Color.White;
            this.lbl_Registrado.Location = new System.Drawing.Point(233, 449);
            this.lbl_Registrado.Name = "lbl_Registrado";
            this.lbl_Registrado.Padding = new System.Windows.Forms.Padding(36, 10, 36, 10);
            this.lbl_Registrado.Size = new System.Drawing.Size(348, 78);
            this.lbl_Registrado.TabIndex = 7;
            this.lbl_Registrado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Registrado.Visible = false;
            // 
            // lbl_Situacao
            // 
            this.lbl_Situacao.AutoSize = true;
            this.lbl_Situacao.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Situacao.Location = new System.Drawing.Point(44, 264);
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Size = new System.Drawing.Size(0, 19);
            this.lbl_Situacao.TabIndex = 8;
            // 
            // lbl_Equipe
            // 
            this.lbl_Equipe.AutoSize = true;
            this.lbl_Equipe.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Equipe.Location = new System.Drawing.Point(44, 309);
            this.lbl_Equipe.Name = "lbl_Equipe";
            this.lbl_Equipe.Size = new System.Drawing.Size(0, 19);
            this.lbl_Equipe.TabIndex = 9;
            // 
            // lbl_UltimoPonto
            // 
            this.lbl_UltimoPonto.AutoSize = true;
            this.lbl_UltimoPonto.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UltimoPonto.Location = new System.Drawing.Point(44, 349);
            this.lbl_UltimoPonto.Name = "lbl_UltimoPonto";
            this.lbl_UltimoPonto.Size = new System.Drawing.Size(0, 19);
            this.lbl_UltimoPonto.TabIndex = 10;
            // 
            // pic_LogoImetame
            // 
            this.pic_LogoImetame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_LogoImetame.Image = ((System.Drawing.Image)(resources.GetObject("pic_LogoImetame.Image")));
            this.pic_LogoImetame.Location = new System.Drawing.Point(661, 496);
            this.pic_LogoImetame.Name = "pic_LogoImetame";
            this.pic_LogoImetame.Size = new System.Drawing.Size(109, 60);
            this.pic_LogoImetame.TabIndex = 11;
            this.pic_LogoImetame.TabStop = false;
            // 
            // lbl_ContaRegistros
            // 
            this.lbl_ContaRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ContaRegistros.AutoSize = true;
            this.lbl_ContaRegistros.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ContaRegistros.Location = new System.Drawing.Point(74, 517);
            this.lbl_ContaRegistros.Name = "lbl_ContaRegistros";
            this.lbl_ContaRegistros.Size = new System.Drawing.Size(0, 25);
            this.lbl_ContaRegistros.TabIndex = 12;
            this.lbl_ContaRegistros.Visible = false;
            // 
            // timer_DataHora
            // 
            this.timer_DataHora.Enabled = true;
            this.timer_DataHora.Interval = 1000;
            this.timer_DataHora.Tick += new System.EventHandler(this.timer_DataHora_Tick);
            // 
            // lbl_UltimaViagem
            // 
            this.lbl_UltimaViagem.AutoSize = true;
            this.lbl_UltimaViagem.Location = new System.Drawing.Point(44, 390);
            this.lbl_UltimaViagem.Name = "lbl_UltimaViagem";
            this.lbl_UltimaViagem.Size = new System.Drawing.Size(0, 15);
            this.lbl_UltimaViagem.TabIndex = 14;
            // 
            // lbl_Alocacao
            // 
            this.lbl_Alocacao.AutoSize = true;
            this.lbl_Alocacao.Location = new System.Drawing.Point(44, 433);
            this.lbl_Alocacao.Name = "lbl_Alocacao";
            this.lbl_Alocacao.Size = new System.Drawing.Size(0, 15);
            this.lbl_Alocacao.TabIndex = 15;
            // 
            // lbl_LiberadoBloqueado
            // 
            this.lbl_LiberadoBloqueado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_LiberadoBloqueado.BackColor = System.Drawing.Color.Red;
            this.lbl_LiberadoBloqueado.Location = new System.Drawing.Point(233, 504);
            this.lbl_LiberadoBloqueado.Name = "lbl_LiberadoBloqueado";
            this.lbl_LiberadoBloqueado.Size = new System.Drawing.Size(348, 23);
            this.lbl_LiberadoBloqueado.TabIndex = 16;
            // 
            // lbl_barraInferior
            // 
            this.lbl_barraInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_barraInferior.BackColor = System.Drawing.Color.Green;
            this.lbl_barraInferior.Location = new System.Drawing.Point(0, 562);
            this.lbl_barraInferior.Name = "lbl_barraInferior";
            this.lbl_barraInferior.Size = new System.Drawing.Size(781, 23);
            this.lbl_barraInferior.TabIndex = 17;
            // 
            // Form_RegistroDePonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 585);
            this.Controls.Add(this.lbl_barraInferior);
            this.Controls.Add(this.lbl_LiberadoBloqueado);
            this.Controls.Add(this.lbl_Alocacao);
            this.Controls.Add(this.lbl_UltimaViagem);
            this.Controls.Add(this.lbl_ContaRegistros);
            this.Controls.Add(this.pic_LogoImetame);
            this.Controls.Add(this.lbl_UltimoPonto);
            this.Controls.Add(this.lbl_Equipe);
            this.Controls.Add(this.lbl_Situacao);
            this.Controls.Add(this.img_Colaborador);
            this.Controls.Add(this.lbl_Registrado);
            this.Controls.Add(this.lbl_Matricula);
            this.Controls.Add(this.lbl_NomeDoColaborador);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.flp_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form_RegistroDePonto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FREQUENCIA ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_RegistroDePonto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_RegistroDePonto_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Leitura_KeyUp);
            this.flp_Barra.ResumeLayout(false);
            this.flp_Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Colaborador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoImetame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flp_Barra;
        private PictureBox img_Colaborador;
        private Label lbl_Titulo;
        private Label label2;
        private Label label3;
        private Label lbl_NomeDoColaborador;
        private Label lbl_Matricula;
        private Label lbl_Registrado;
        private Label lbl_Situacao;
        private Label lbl_Equipe;
        private Label lbl_UltimoPonto;
        private PictureBox pic_LogoImetame;
        private Label lbl_ContaRegistros;
        private System.Windows.Forms.Timer timer_DataHora;
        private Label lbl_DataHora;
        private Label lbl_UltimaViagem;
        private Label lbl_Alocacao;
        private Label lbl_LiberadoBloqueado;
        private Label lbl_barraInferior;
    }
}