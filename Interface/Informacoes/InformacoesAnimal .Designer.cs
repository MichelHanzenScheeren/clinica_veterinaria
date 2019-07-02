namespace Interface
{
    partial class InformacoesAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacoesAnimal));
            this.Top = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ttFechar = new System.Windows.Forms.ToolTip(this.components);
            this.ttAlterarTamanho = new System.Windows.Forms.ToolTip(this.components);
            this.ttMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttVOLTAR = new System.Windows.Forms.ToolTip(this.components);
            this.lblPeso = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlTras = new System.Windows.Forms.Panel();
            this.PnlInformacoes = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblPedigree = new System.Windows.Forms.Label();
            this.lblEsterilizacao = new System.Windows.Forms.Label();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlEsquerdo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProntuario = new System.Windows.Forms.Button();
            this.btnReceita = new System.Windows.Forms.Button();
            this.brnInternamento = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtendimento = new System.Windows.Forms.Button();
            this.btnNovoAgendamento = new System.Windows.Forms.Button();
            this.Top.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.pnlTras.SuspendLayout();
            this.PnlInformacoes.SuspendLayout();
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
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(9, 198);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(62, 22);
            this.lblPeso.TabIndex = 96;
            this.lblPeso.Text = "PESO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "INFORMAÇÕES BÁSICAS";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.ForeColor = System.Drawing.Color.White;
            this.lblRaca.Location = new System.Drawing.Point(9, 123);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(77, 22);
            this.lblRaca.TabIndex = 84;
            this.lblRaca.Text = "RAÇA: ";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.White;
            this.lblCor.Location = new System.Drawing.Point(9, 173);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(216, 22);
            this.lblCor.TabIndex = 85;
            this.lblCor.Text = "COR PREDOMINANTE: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(9, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(78, 22);
            this.lblNome.TabIndex = 81;
            this.lblNome.Text = "NOME: ";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.Color.White;
            this.lblNascimento.Location = new System.Drawing.Point(9, 97);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(230, 22);
            this.lblNascimento.TabIndex = 87;
            this.lblNascimento.Text = "DATA DE NASCIMENTO: ";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.ForeColor = System.Drawing.Color.White;
            this.lblEspecie.Location = new System.Drawing.Point(9, 148);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(90, 22);
            this.lblEspecie.TabIndex = 91;
            this.lblEspecie.Text = "ESPÉCIE: ";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(9, 73);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(68, 22);
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
            this.pnlTras.Controls.Add(this.PnlInformacoes);
            this.pnlTras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTras.Location = new System.Drawing.Point(234, 0);
            this.pnlTras.Name = "pnlTras";
            this.pnlTras.Size = new System.Drawing.Size(1136, 669);
            this.pnlTras.TabIndex = 101;
            // 
            // PnlInformacoes
            // 
            this.PnlInformacoes.Controls.Add(this.lblCadastro);
            this.PnlInformacoes.Controls.Add(this.lblPedigree);
            this.PnlInformacoes.Controls.Add(this.lblEsterilizacao);
            this.PnlInformacoes.Controls.Add(this.lblProprietario);
            this.PnlInformacoes.Controls.Add(this.lblTamanho);
            this.PnlInformacoes.Controls.Add(this.lblID);
            this.PnlInformacoes.Controls.Add(this.lblPeso);
            this.PnlInformacoes.Controls.Add(this.label9);
            this.PnlInformacoes.Controls.Add(this.lblNome);
            this.PnlInformacoes.Controls.Add(this.lblSexo);
            this.PnlInformacoes.Controls.Add(this.lblNascimento);
            this.PnlInformacoes.Controls.Add(this.lblRaca);
            this.PnlInformacoes.Controls.Add(this.lblEspecie);
            this.PnlInformacoes.Controls.Add(this.lblCor);
            this.PnlInformacoes.Location = new System.Drawing.Point(253, 136);
            this.PnlInformacoes.Name = "PnlInformacoes";
            this.PnlInformacoes.Size = new System.Drawing.Size(629, 397);
            this.PnlInformacoes.TabIndex = 97;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(10, 313);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(213, 22);
            this.lblCadastro.TabIndex = 102;
            this.lblCadastro.Text = "DATA DO CADASTRO:";
            // 
            // lblPedigree
            // 
            this.lblPedigree.AutoSize = true;
            this.lblPedigree.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedigree.ForeColor = System.Drawing.Color.White;
            this.lblPedigree.Location = new System.Drawing.Point(8, 283);
            this.lblPedigree.Name = "lblPedigree";
            this.lblPedigree.Size = new System.Drawing.Size(135, 22);
            this.lblPedigree.TabIndex = 101;
            this.lblPedigree.Text = "Nº PEDIGREE: ";
            // 
            // lblEsterilizacao
            // 
            this.lblEsterilizacao.AutoSize = true;
            this.lblEsterilizacao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsterilizacao.ForeColor = System.Drawing.Color.White;
            this.lblEsterilizacao.Location = new System.Drawing.Point(8, 254);
            this.lblEsterilizacao.Name = "lblEsterilizacao";
            this.lblEsterilizacao.Size = new System.Drawing.Size(159, 22);
            this.lblEsterilizacao.TabIndex = 100;
            this.lblEsterilizacao.Text = "ESTERILIZAÇÃO: ";
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProprietario.ForeColor = System.Drawing.Color.White;
            this.lblProprietario.Location = new System.Drawing.Point(8, 365);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(155, 22);
            this.lblProprietario.TabIndex = 99;
            this.lblProprietario.Text = "PROPRIETÁRIO: ";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.ForeColor = System.Drawing.Color.White;
            this.lblTamanho.Location = new System.Drawing.Point(9, 225);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(119, 22);
            this.lblTamanho.TabIndex = 98;
            this.lblTamanho.Text = "TAMANHO: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(363, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 22);
            this.lblID.TabIndex = 97;
            this.lblID.Text = "ANIMAL Nº ";
            // 
            // pnlEsquerdo
            // 
            this.pnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlEsquerdo.Controls.Add(this.panel1);
            this.pnlEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            this.pnlEsquerdo.Size = new System.Drawing.Size(234, 669);
            this.pnlEsquerdo.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnProntuario);
            this.panel1.Controls.Add(this.btnReceita);
            this.panel1.Controls.Add(this.brnInternamento);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAtendimento);
            this.panel1.Controls.Add(this.btnNovoAgendamento);
            this.panel1.Location = new System.Drawing.Point(3, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 515);
            this.panel1.TabIndex = 97;
            // 
            // btnProntuario
            // 
            this.btnProntuario.AccessibleName = "";
            this.btnProntuario.FlatAppearance.BorderSize = 0;
            this.btnProntuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProntuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProntuario.ForeColor = System.Drawing.Color.White;
            this.btnProntuario.Image = ((System.Drawing.Image)(resources.GetObject("btnProntuario.Image")));
            this.btnProntuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProntuario.Location = new System.Drawing.Point(9, 365);
            this.btnProntuario.Name = "btnProntuario";
            this.btnProntuario.Size = new System.Drawing.Size(207, 65);
            this.btnProntuario.TabIndex = 109;
            this.btnProntuario.Text = "          PRONTUÁRIO";
            this.btnProntuario.Click += new System.EventHandler(this.BtnProntuario_Click);
            // 
            // btnReceita
            // 
            this.btnReceita.AccessibleName = "";
            this.btnReceita.FlatAppearance.BorderSize = 0;
            this.btnReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceita.ForeColor = System.Drawing.Color.White;
            this.btnReceita.Image = ((System.Drawing.Image)(resources.GetObject("btnReceita.Image")));
            this.btnReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceita.Location = new System.Drawing.Point(8, 294);
            this.btnReceita.Name = "btnReceita";
            this.btnReceita.Size = new System.Drawing.Size(207, 65);
            this.btnReceita.TabIndex = 108;
            this.btnReceita.Text = "RECEITA";
            this.btnReceita.Click += new System.EventHandler(this.BtnReceita_Click);
            // 
            // brnInternamento
            // 
            this.brnInternamento.AccessibleName = "";
            this.brnInternamento.FlatAppearance.BorderSize = 0;
            this.brnInternamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnInternamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnInternamento.ForeColor = System.Drawing.Color.White;
            this.brnInternamento.Image = ((System.Drawing.Image)(resources.GetObject("brnInternamento.Image")));
            this.brnInternamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnInternamento.Location = new System.Drawing.Point(8, 223);
            this.brnInternamento.Name = "brnInternamento";
            this.brnInternamento.Size = new System.Drawing.Size(207, 65);
            this.brnInternamento.TabIndex = 107;
            this.brnInternamento.Text = "              INTERNAMENTO";
            this.brnInternamento.Click += new System.EventHandler(this.BrnInternamento_Click);
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
            this.btnDeletar.Location = new System.Drawing.Point(9, 436);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(207, 65);
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
            this.btnEditar.Location = new System.Drawing.Point(8, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(207, 65);
            this.btnEditar.TabIndex = 105;
            this.btnEditar.Text = "           EDITAR INFO";
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnAtendimento
            // 
            this.btnAtendimento.AccessibleName = "";
            this.btnAtendimento.FlatAppearance.BorderSize = 0;
            this.btnAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtendimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendimento.ForeColor = System.Drawing.Color.White;
            this.btnAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("btnAtendimento.Image")));
            this.btnAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtendimento.Location = new System.Drawing.Point(8, 152);
            this.btnAtendimento.Name = "btnAtendimento";
            this.btnAtendimento.Size = new System.Drawing.Size(207, 65);
            this.btnAtendimento.TabIndex = 101;
            this.btnAtendimento.Text = "         ATENDIMENTO";
            this.btnAtendimento.Click += new System.EventHandler(this.BtnAtendimento_Click);
            // 
            // btnNovoAgendamento
            // 
            this.btnNovoAgendamento.AccessibleName = "";
            this.btnNovoAgendamento.FlatAppearance.BorderSize = 0;
            this.btnNovoAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAgendamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnNovoAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAgendamento.Image")));
            this.btnNovoAgendamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAgendamento.Location = new System.Drawing.Point(9, 81);
            this.btnNovoAgendamento.Name = "btnNovoAgendamento";
            this.btnNovoAgendamento.Size = new System.Drawing.Size(207, 65);
            this.btnNovoAgendamento.TabIndex = 104;
            this.btnNovoAgendamento.Text = "         AGENDAMENTO";
            this.btnNovoAgendamento.Click += new System.EventHandler(this.BtnNovoAgendamento_Click);
            // 
            // InformacoesAnimal
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
            this.Name = "InformacoesAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.InformacoesAnimal_Resize);
            this.Top.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlTras.ResumeLayout(false);
            this.PnlInformacoes.ResumeLayout(false);
            this.PnlInformacoes.PerformLayout();
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
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Panel pnlEsquerdo;
        private System.Windows.Forms.Panel pnlTras;
        private System.Windows.Forms.Button btnAtendimento;
        private System.Windows.Forms.Button btnNovoAgendamento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlInformacoes;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.Label lblPedigree;
        private System.Windows.Forms.Label lblEsterilizacao;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button brnInternamento;
        private System.Windows.Forms.Button btnReceita;
        private System.Windows.Forms.Button btnProntuario;
    }
}

