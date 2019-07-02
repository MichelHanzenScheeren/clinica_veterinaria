namespace Interface
{
    partial class InformacoesCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacoesCadastro));
            this.Top = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ttFechar = new System.Windows.Forms.ToolTip(this.components);
            this.ttAlterarTamanho = new System.Windows.Forms.ToolTip(this.components);
            this.ttMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttVOLTAR = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFuncionario = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.pnlVeterinario = new System.Windows.Forms.Panel();
            this.lblDoutorado = new System.Windows.Forms.Label();
            this.lblMestrado = new System.Windows.Forms.Label();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.lblGraduacao = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblAreaAtuacao = new System.Windows.Forms.Label();
            this.lblCRMV_Estado = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlTras = new System.Windows.Forms.Panel();
            this.pnlprincipal = new System.Windows.Forms.Panel();
            this.PnlInformacoes = new System.Windows.Forms.Panel();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listAnimais = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlEndereco = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumCasa = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlEsquerdo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnNovoAnimal = new System.Windows.Forms.Button();
            this.Top.SuspendLayout();
            this.pnlFuncionario.SuspendLayout();
            this.pnlVeterinario.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.pnlTras.SuspendLayout();
            this.pnlprincipal.SuspendLayout();
            this.PnlInformacoes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            this.pnlEsquerdo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Top.Controls.Add(this.btnAlterar);
            this.Top.Controls.Add(this.btnVoltar);
            this.Top.Controls.Add(this.btnMinimizar);
            this.Top.Controls.Add(this.btnFechar);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(1370, 61);
            this.Top.TabIndex = 0;
            this.Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_MouseDown);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(1251, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(55, 55);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttAlterarTamanho.SetToolTip(this.btnAlterar, "ALTERAR TAMANHO");
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(55, 55);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttVOLTAR.SetToolTip(this.btnVoltar, "VOLTAR");
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1190, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(55, 55);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttMinimizar.SetToolTip(this.btnMinimizar, "MINIMIZAR");
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1312, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 55);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttFechar.SetToolTip(this.btnFechar, "FECHAR PROGRAMA");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pnlFuncionario
            // 
            this.pnlFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFuncionario.Controls.Add(this.lblCargo);
            this.pnlFuncionario.Controls.Add(this.lblCargaHoraria);
            this.pnlFuncionario.Controls.Add(this.lblSalario);
            this.pnlFuncionario.Controls.Add(this.label27);
            this.pnlFuncionario.Enabled = false;
            this.pnlFuncionario.Location = new System.Drawing.Point(5, 266);
            this.pnlFuncionario.Name = "pnlFuncionario";
            this.pnlFuncionario.Size = new System.Drawing.Size(417, 135);
            this.pnlFuncionario.TabIndex = 96;
            this.pnlFuncionario.Visible = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(9, 52);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(172, 21);
            this.lblCargo.TabIndex = 167;
            this.lblCargo.Text = "CARGO OCUPADO: ";
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHoraria.ForeColor = System.Drawing.Color.White;
            this.lblCargaHoraria.Location = new System.Drawing.Point(9, 102);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(242, 21);
            this.lblCargaHoraria.TabIndex = 166;
            this.lblCargaHoraria.Text = "CARGA HORÁRIA SEMANAL: ";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(9, 77);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(88, 21);
            this.lblSalario.TabIndex = 157;
            this.lblSalario.Text = "SALÁRIO: ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(8, 12);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 23);
            this.label27.TabIndex = 79;
            this.label27.Text = "EXTRAS";
            // 
            // pnlVeterinario
            // 
            this.pnlVeterinario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlVeterinario.Controls.Add(this.lblDoutorado);
            this.pnlVeterinario.Controls.Add(this.lblMestrado);
            this.pnlVeterinario.Controls.Add(this.lblEspecializacao);
            this.pnlVeterinario.Controls.Add(this.lblInstituicao);
            this.pnlVeterinario.Controls.Add(this.lblGraduacao);
            this.pnlVeterinario.Controls.Add(this.label23);
            this.pnlVeterinario.Controls.Add(this.lblAreaAtuacao);
            this.pnlVeterinario.Controls.Add(this.lblCRMV_Estado);
            this.pnlVeterinario.Enabled = false;
            this.pnlVeterinario.Location = new System.Drawing.Point(6, 268);
            this.pnlVeterinario.Name = "pnlVeterinario";
            this.pnlVeterinario.Size = new System.Drawing.Size(415, 236);
            this.pnlVeterinario.TabIndex = 96;
            this.pnlVeterinario.Visible = false;
            // 
            // lblDoutorado
            // 
            this.lblDoutorado.AutoSize = true;
            this.lblDoutorado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoutorado.ForeColor = System.Drawing.Color.White;
            this.lblDoutorado.Location = new System.Drawing.Point(4, 203);
            this.lblDoutorado.Name = "lblDoutorado";
            this.lblDoutorado.Size = new System.Drawing.Size(126, 21);
            this.lblDoutorado.TabIndex = 166;
            this.lblDoutorado.Text = "DOUTORADO: ";
            // 
            // lblMestrado
            // 
            this.lblMestrado.AutoSize = true;
            this.lblMestrado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMestrado.ForeColor = System.Drawing.Color.White;
            this.lblMestrado.Location = new System.Drawing.Point(4, 178);
            this.lblMestrado.Name = "lblMestrado";
            this.lblMestrado.Size = new System.Drawing.Size(107, 21);
            this.lblMestrado.TabIndex = 163;
            this.lblMestrado.Text = "MESTRADO: ";
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecializacao.ForeColor = System.Drawing.Color.White;
            this.lblEspecializacao.Location = new System.Drawing.Point(4, 103);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(157, 21);
            this.lblEspecializacao.TabIndex = 161;
            this.lblEspecializacao.Text = "ESPECIALIZAÇÃO: ";
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstituicao.ForeColor = System.Drawing.Color.White;
            this.lblInstituicao.Location = new System.Drawing.Point(4, 153);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(120, 21);
            this.lblInstituicao.TabIndex = 159;
            this.lblInstituicao.Text = "INSTITUIÇÃO: ";
            // 
            // lblGraduacao
            // 
            this.lblGraduacao.AutoSize = true;
            this.lblGraduacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraduacao.ForeColor = System.Drawing.Color.White;
            this.lblGraduacao.Location = new System.Drawing.Point(4, 128);
            this.lblGraduacao.Name = "lblGraduacao";
            this.lblGraduacao.Size = new System.Drawing.Size(131, 21);
            this.lblGraduacao.TabIndex = 157;
            this.lblGraduacao.Text = "GRADUAÇÃO: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(3, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 23);
            this.label23.TabIndex = 79;
            this.label23.Text = "EXTRAS";
            // 
            // lblAreaAtuacao
            // 
            this.lblAreaAtuacao.AutoSize = true;
            this.lblAreaAtuacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAtuacao.ForeColor = System.Drawing.Color.White;
            this.lblAreaAtuacao.Location = new System.Drawing.Point(4, 73);
            this.lblAreaAtuacao.Name = "lblAreaAtuacao";
            this.lblAreaAtuacao.Size = new System.Drawing.Size(103, 21);
            this.lblAreaAtuacao.TabIndex = 85;
            this.lblAreaAtuacao.Text = "ATUAÇÃO: ";
            // 
            // lblCRMV_Estado
            // 
            this.lblCRMV_Estado.AutoSize = true;
            this.lblCRMV_Estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRMV_Estado.ForeColor = System.Drawing.Color.White;
            this.lblCRMV_Estado.Location = new System.Drawing.Point(4, 48);
            this.lblCRMV_Estado.Name = "lblCRMV_Estado";
            this.lblCRMV_Estado.Size = new System.Drawing.Size(67, 21);
            this.lblCRMV_Estado.TabIndex = 81;
            this.lblCRMV_Estado.Text = "CRMV: ";
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificacao.ForeColor = System.Drawing.Color.White;
            this.lblClassificacao.Location = new System.Drawing.Point(9, 198);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(151, 21);
            this.lblClassificacao.TabIndex = 96;
            this.lblClassificacao.Text = "CLASSIFICAÇÃO: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 23);
            this.label9.TabIndex = 79;
            this.label9.Text = "INFORMAÇÕES BÁSICAS";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(9, 123);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 21);
            this.lblCPF.TabIndex = 84;
            this.lblCPF.Text = "CPF: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(9, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 21);
            this.lblEmail.TabIndex = 85;
            this.lblEmail.Text = "EMAIL: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(9, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 21);
            this.lblNome.TabIndex = 81;
            this.lblNome.Text = "NOME: ";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.Color.White;
            this.lblNascimento.Location = new System.Drawing.Point(9, 97);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(202, 21);
            this.lblNascimento.TabIndex = 87;
            this.lblNascimento.Text = "DATA DE NASCIMENTO: ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(9, 148);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(94, 21);
            this.lblTelefone.TabIndex = 91;
            this.lblTelefone.Text = "TELEFONE: ";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(9, 73);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(58, 21);
            this.lblSexo.TabIndex = 80;
            this.lblSexo.Text = "SEXO: ";
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlCentral.Controls.Add(this.pnlTras);
            this.pnlCentral.Controls.Add(this.pnlEsquerdo);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 61);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1370, 669);
            this.pnlCentral.TabIndex = 96;
            // 
            // pnlTras
            // 
            this.pnlTras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlTras.Controls.Add(this.pnlprincipal);
            this.pnlTras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTras.Location = new System.Drawing.Point(201, 0);
            this.pnlTras.Name = "pnlTras";
            this.pnlTras.Size = new System.Drawing.Size(1169, 669);
            this.pnlTras.TabIndex = 101;
            // 
            // pnlprincipal
            // 
            this.pnlprincipal.Controls.Add(this.PnlInformacoes);
            this.pnlprincipal.Controls.Add(this.pnlVeterinario);
            this.pnlprincipal.Controls.Add(this.panel2);
            this.pnlprincipal.Controls.Add(this.pnlFuncionario);
            this.pnlprincipal.Controls.Add(this.pnlEndereco);
            this.pnlprincipal.Location = new System.Drawing.Point(182, 74);
            this.pnlprincipal.Name = "pnlprincipal";
            this.pnlprincipal.Size = new System.Drawing.Size(800, 504);
            this.pnlprincipal.TabIndex = 100;
            // 
            // PnlInformacoes
            // 
            this.PnlInformacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlInformacoes.Controls.Add(this.lblDataCadastro);
            this.PnlInformacoes.Controls.Add(this.lblID);
            this.PnlInformacoes.Controls.Add(this.lblClassificacao);
            this.PnlInformacoes.Controls.Add(this.label9);
            this.PnlInformacoes.Controls.Add(this.lblNome);
            this.PnlInformacoes.Controls.Add(this.lblSexo);
            this.PnlInformacoes.Controls.Add(this.lblNascimento);
            this.PnlInformacoes.Controls.Add(this.lblCPF);
            this.PnlInformacoes.Controls.Add(this.lblTelefone);
            this.PnlInformacoes.Controls.Add(this.lblEmail);
            this.PnlInformacoes.Location = new System.Drawing.Point(6, 3);
            this.PnlInformacoes.Name = "PnlInformacoes";
            this.PnlInformacoes.Size = new System.Drawing.Size(415, 255);
            this.PnlInformacoes.TabIndex = 97;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ForeColor = System.Drawing.Color.White;
            this.lblDataCadastro.Location = new System.Drawing.Point(9, 225);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(189, 21);
            this.lblDataCadastro.TabIndex = 98;
            this.lblDataCadastro.Text = "DATA DO CADASTRO: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(256, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 21);
            this.lblID.TabIndex = 97;
            this.lblID.Text = "Nº  ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listAnimais);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(429, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 236);
            this.panel2.TabIndex = 99;
            // 
            // listAnimais
            // 
            this.listAnimais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listAnimais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.listAnimais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAnimais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAnimais.ForeColor = System.Drawing.Color.White;
            this.listAnimais.FormattingEnabled = true;
            this.listAnimais.ItemHeight = 21;
            this.listAnimais.Location = new System.Drawing.Point(25, 54);
            this.listAnimais.Name = "listAnimais";
            this.listAnimais.Size = new System.Drawing.Size(330, 147);
            this.listAnimais.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 23);
            this.label7.TabIndex = 79;
            this.label7.Text = "ANIMAIS CADASTRADOS:";
            // 
            // pnlEndereco
            // 
            this.pnlEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEndereco.Controls.Add(this.label17);
            this.pnlEndereco.Controls.Add(this.lblEstado);
            this.pnlEndereco.Controls.Add(this.lblCidade);
            this.pnlEndereco.Controls.Add(this.lblBairro);
            this.pnlEndereco.Controls.Add(this.lblRua);
            this.pnlEndereco.Controls.Add(this.lblNumCasa);
            this.pnlEndereco.Controls.Add(this.lblCep);
            this.pnlEndereco.Controls.Add(this.label14);
            this.pnlEndereco.Location = new System.Drawing.Point(429, 3);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Size = new System.Drawing.Size(368, 254);
            this.pnlEndereco.TabIndex = 94;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(6, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 23);
            this.label17.TabIndex = 126;
            this.label17.Text = "ENDEREÇO";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(7, 172);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 21);
            this.lblEstado.TabIndex = 75;
            this.lblEstado.Text = "ESTADO: ";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(7, 147);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(82, 21);
            this.lblCidade.TabIndex = 73;
            this.lblCidade.Text = "CIDADE: ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(7, 122);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(79, 21);
            this.lblBairro.TabIndex = 71;
            this.lblBairro.Text = "BAIRRO: ";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.White;
            this.lblRua.Location = new System.Drawing.Point(7, 97);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(52, 21);
            this.lblRua.TabIndex = 68;
            this.lblRua.Text = "RUA: ";
            // 
            // lblNumCasa
            // 
            this.lblNumCasa.AutoSize = true;
            this.lblNumCasa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCasa.ForeColor = System.Drawing.Color.White;
            this.lblNumCasa.Location = new System.Drawing.Point(7, 72);
            this.lblNumCasa.Name = "lblNumCasa";
            this.lblNumCasa.Size = new System.Drawing.Size(87, 21);
            this.lblNumCasa.TabIndex = 67;
            this.lblNumCasa.Text = "Nº CASA: ";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.Color.White;
            this.lblCep.Location = new System.Drawing.Point(7, 47);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(49, 21);
            this.lblCep.TabIndex = 66;
            this.lblCep.Text = "CEP: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, -17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "ENDEREÇO";
            // 
            // pnlEsquerdo
            // 
            this.pnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlEsquerdo.Controls.Add(this.panel1);
            this.pnlEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            this.pnlEsquerdo.Size = new System.Drawing.Size(201, 669);
            this.pnlEsquerdo.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnFinanceiro);
            this.panel1.Controls.Add(this.btnNovoAnimal);
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 452);
            this.panel1.TabIndex = 97;
            // 
            // btnDeletar
            // 
            this.btnDeletar.AccessibleName = "";
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(8, 354);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(187, 78);
            this.btnDeletar.TabIndex = 106;
            this.btnDeletar.Text = "   DELETAR";
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleName = "";
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(8, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(187, 78);
            this.btnEditar.TabIndex = 105;
            this.btnEditar.Text = "       EDITAR INFO";
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.AccessibleName = "";
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.Color.White;
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.Location = new System.Drawing.Point(8, 240);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(190, 78);
            this.btnFinanceiro.TabIndex = 101;
            this.btnFinanceiro.Text = "      FINANCEIRO";
            this.btnFinanceiro.Click += new System.EventHandler(this.BtnFinanceiro_Click);
            // 
            // btnNovoAnimal
            // 
            this.btnNovoAnimal.AccessibleName = "";
            this.btnNovoAnimal.FlatAppearance.BorderSize = 0;
            this.btnNovoAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAnimal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAnimal.ForeColor = System.Drawing.Color.White;
            this.btnNovoAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAnimal.Image")));
            this.btnNovoAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAnimal.Location = new System.Drawing.Point(8, 127);
            this.btnNovoAnimal.Name = "btnNovoAnimal";
            this.btnNovoAnimal.Size = new System.Drawing.Size(187, 78);
            this.btnNovoAnimal.TabIndex = 104;
            this.btnNovoAnimal.Text = "            NOVO ANIMAL";
            this.btnNovoAnimal.Click += new System.EventHandler(this.BtnNovoAnimal_Click);
            // 
            // InformacoesCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformacoesCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Top.ResumeLayout(false);
            this.pnlFuncionario.ResumeLayout(false);
            this.pnlFuncionario.PerformLayout();
            this.pnlVeterinario.ResumeLayout(false);
            this.pnlVeterinario.PerformLayout();
            this.pnlCentral.ResumeLayout(false);
            this.pnlTras.ResumeLayout(false);
            this.pnlprincipal.ResumeLayout(false);
            this.PnlInformacoes.ResumeLayout(false);
            this.PnlInformacoes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            this.pnlEsquerdo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ToolTip ttAlterarTamanho;
        private System.Windows.Forms.ToolTip ttVOLTAR;
        private System.Windows.Forms.ToolTip ttMinimizar;
        private System.Windows.Forms.ToolTip ttFechar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNumCasa;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Panel pnlEsquerdo;
        private System.Windows.Forms.Panel pnlTras;
        private System.Windows.Forms.Panel pnlVeterinario;
        private System.Windows.Forms.Label lblDoutorado;
        private System.Windows.Forms.Label lblMestrado;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.Label lblGraduacao;
        private System.Windows.Forms.Label lblAreaAtuacao;
        private System.Windows.Forms.Label lblCRMV_Estado;
        private System.Windows.Forms.Panel pnlFuncionario;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnNovoAnimal;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlInformacoes;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlprincipal;
        private System.Windows.Forms.ListBox listAnimais;
    }
}

