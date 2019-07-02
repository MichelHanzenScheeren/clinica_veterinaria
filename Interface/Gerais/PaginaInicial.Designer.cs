namespace Interface
{
    partial class PaginaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicial));
            this.btnCadastros = new System.Windows.Forms.Button();
            this.ttFechar = new System.Windows.Forms.ToolTip(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.ttAlterarTamanho = new System.Windows.Forms.ToolTip(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.ttMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnInternacao = new System.Windows.Forms.Button();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.btnATENDIMENTO = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlImagem = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagemCentral = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.ttMenu = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLateral.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.pnlImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemCentral)).BeginInit();
            this.Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastros
            // 
            this.btnCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastros.Image")));
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(3, 79);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(231, 60);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "CADASTROS";
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.BtnCadastros_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1066, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 67);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttFechar.SetToolTip(this.btnFechar, "FECHAR PROGRAMA");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(1005, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(55, 67);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttAlterarTamanho.SetToolTip(this.btnAlterar, "ALTERAR TAMANHO");
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(944, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(55, 67);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttMinimizar.SetToolTip(this.btnMinimizar, "MINIMIZAR");
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlLateral.Controls.Add(this.btnResultados);
            this.pnlLateral.Controls.Add(this.btnControle);
            this.pnlLateral.Controls.Add(this.btnCaixa);
            this.pnlLateral.Controls.Add(this.btnInternacao);
            this.pnlLateral.Controls.Add(this.btnReceitas);
            this.pnlLateral.Controls.Add(this.btnATENDIMENTO);
            this.pnlLateral.Controls.Add(this.btnAgendamentos);
            this.pnlLateral.Controls.Add(this.btnAnimais);
            this.pnlLateral.Controls.Add(this.btnCadastros);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(246, 730);
            this.pnlLateral.TabIndex = 5;
            // 
            // btnResultados
            // 
            this.btnResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultados.FlatAppearance.BorderSize = 0;
            this.btnResultados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultados.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.ForeColor = System.Drawing.Color.White;
            this.btnResultados.Image = ((System.Drawing.Image)(resources.GetObject("btnResultados.Image")));
            this.btnResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultados.Location = new System.Drawing.Point(9, 609);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(231, 60);
            this.btnResultados.TabIndex = 9;
            this.btnResultados.Text = "RESULTADOS";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
            // 
            // btnControle
            // 
            this.btnControle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnControle.FlatAppearance.BorderSize = 0;
            this.btnControle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControle.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControle.ForeColor = System.Drawing.Color.White;
            this.btnControle.Image = ((System.Drawing.Image)(resources.GetObject("btnControle.Image")));
            this.btnControle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControle.Location = new System.Drawing.Point(6, 543);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(231, 60);
            this.btnControle.TabIndex = 8;
            this.btnControle.Text = "CONTROLE";
            this.btnControle.UseVisualStyleBackColor = true;
            this.btnControle.Click += new System.EventHandler(this.BtnControle_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnCaixa.Image")));
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(6, 477);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(231, 60);
            this.btnCaixa.TabIndex = 7;
            this.btnCaixa.Text = "FINANÇAS";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.BtnCaixa_Click);
            // 
            // btnInternacao
            // 
            this.btnInternacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInternacao.FlatAppearance.BorderSize = 0;
            this.btnInternacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnInternacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternacao.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnInternacao.ForeColor = System.Drawing.Color.White;
            this.btnInternacao.Image = ((System.Drawing.Image)(resources.GetObject("btnInternacao.Image")));
            this.btnInternacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternacao.Location = new System.Drawing.Point(6, 411);
            this.btnInternacao.Name = "btnInternacao";
            this.btnInternacao.Size = new System.Drawing.Size(231, 60);
            this.btnInternacao.TabIndex = 6;
            this.btnInternacao.Text = "       INTERNAMENTO";
            this.btnInternacao.UseVisualStyleBackColor = true;
            this.btnInternacao.Click += new System.EventHandler(this.BtnInternacao_Click);
            // 
            // btnReceitas
            // 
            this.btnReceitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceitas.FlatAppearance.BorderSize = 0;
            this.btnReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitas.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnReceitas.ForeColor = System.Drawing.Color.White;
            this.btnReceitas.Image = ((System.Drawing.Image)(resources.GetObject("btnReceitas.Image")));
            this.btnReceitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitas.Location = new System.Drawing.Point(12, 345);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Size = new System.Drawing.Size(231, 60);
            this.btnReceitas.TabIndex = 5;
            this.btnReceitas.Text = "           RECEITA";
            this.btnReceitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitas.UseVisualStyleBackColor = true;
            this.btnReceitas.Click += new System.EventHandler(this.BtnReceitas_Click);
            // 
            // btnATENDIMENTO
            // 
            this.btnATENDIMENTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnATENDIMENTO.FlatAppearance.BorderSize = 0;
            this.btnATENDIMENTO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnATENDIMENTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnATENDIMENTO.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnATENDIMENTO.ForeColor = System.Drawing.Color.White;
            this.btnATENDIMENTO.Image = ((System.Drawing.Image)(resources.GetObject("btnATENDIMENTO.Image")));
            this.btnATENDIMENTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnATENDIMENTO.Location = new System.Drawing.Point(6, 279);
            this.btnATENDIMENTO.Name = "btnATENDIMENTO";
            this.btnATENDIMENTO.Size = new System.Drawing.Size(231, 60);
            this.btnATENDIMENTO.TabIndex = 4;
            this.btnATENDIMENTO.Text = "   ATENDIMENTO";
            this.btnATENDIMENTO.UseVisualStyleBackColor = true;
            this.btnATENDIMENTO.Click += new System.EventHandler(this.BtnATENDIMENTO_Click);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgendamentos.FlatAppearance.BorderSize = 0;
            this.btnAgendamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAgendamentos.ForeColor = System.Drawing.Color.White;
            this.btnAgendamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendamentos.Image")));
            this.btnAgendamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamentos.Location = new System.Drawing.Point(6, 213);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Size = new System.Drawing.Size(231, 60);
            this.btnAgendamentos.TabIndex = 3;
            this.btnAgendamentos.Text = "           AGENDA";
            this.btnAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamentos.UseVisualStyleBackColor = true;
            this.btnAgendamentos.Click += new System.EventHandler(this.BtnAgendamentos_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnimais.FlatAppearance.BorderSize = 0;
            this.btnAnimais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAnimais.ForeColor = System.Drawing.Color.White;
            this.btnAnimais.Image = ((System.Drawing.Image)(resources.GetObject("btnAnimais.Image")));
            this.btnAnimais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimais.Location = new System.Drawing.Point(6, 147);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(231, 60);
            this.btnAnimais.TabIndex = 2;
            this.btnAnimais.Text = "           ANIMAIS";
            this.btnAnimais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.BtnAnimais_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlCentral.Controls.Add(this.pnlImagem);
            this.pnlCentral.Controls.Add(this.Top);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(246, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1124, 730);
            this.pnlCentral.TabIndex = 7;
            this.pnlCentral.Resize += new System.EventHandler(this.PnlCentral_Resize);
            // 
            // pnlImagem
            // 
            this.pnlImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImagem.Controls.Add(this.pictureBox1);
            this.pnlImagem.Controls.Add(this.imagemCentral);
            this.pnlImagem.Location = new System.Drawing.Point(15, 79);
            this.pnlImagem.Name = "pnlImagem";
            this.pnlImagem.Size = new System.Drawing.Size(1097, 639);
            this.pnlImagem.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 58);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // imagemCentral
            // 
            this.imagemCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagemCentral.Image = ((System.Drawing.Image)(resources.GetObject("imagemCentral.Image")));
            this.imagemCentral.Location = new System.Drawing.Point(0, 0);
            this.imagemCentral.Name = "imagemCentral";
            this.imagemCentral.Size = new System.Drawing.Size(1097, 639);
            this.imagemCentral.TabIndex = 2;
            this.imagemCentral.TabStop = false;
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Top.Controls.Add(this.btnMenu);
            this.Top.Controls.Add(this.btnAlterar);
            this.Top.Controls.Add(this.btnMinimizar);
            this.Top.Controls.Add(this.btnFechar);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(1124, 73);
            this.Top.TabIndex = 1;
            this.Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_MouseDown);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(3, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(62, 55);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttMenu.SetToolTip(this.btnMenu, "MENU");
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PaginaInicial_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemCentral)).EndInit();
            this.Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttAlterarTamanho;
        private System.Windows.Forms.ToolTip ttMinimizar;
        private System.Windows.Forms.ToolTip ttFechar;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnATENDIMENTO;
        private System.Windows.Forms.Button btnReceitas;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnInternacao;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlImagem;
        private System.Windows.Forms.PictureBox imagemCentral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.ToolTip ttMenu;
    }
}

