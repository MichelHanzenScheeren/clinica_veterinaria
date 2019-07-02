namespace Interface
{
    partial class ControleServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleServicos));
            this.Top = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ttFechar = new System.Windows.Forms.ToolTip(this.components);
            this.ttAlterarTamanho = new System.Windows.Forms.ToolTip(this.components);
            this.ttMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttVOLTAR = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlTras = new System.Windows.Forms.Panel();
            this.pnlCirurgia = new System.Windows.Forms.Panel();
            this.cbClassificacaoCirurgia = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPrecoCirurgia = new System.Windows.Forms.TextBox();
            this.lblIDCirurgia = new System.Windows.Forms.Label();
            this.txtIDCirurgia = new System.Windows.Forms.TextBox();
            this.lblCirurgia = new System.Windows.Forms.Label();
            this.btnSalvarCirurgia = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNomeCirurgia = new System.Windows.Forms.TextBox();
            this.pnlVacina = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPrecoVacina = new System.Windows.Forms.TextBox();
            this.txtInformacoesVacina = new System.Windows.Forms.TextBox();
            this.lblIDVacina = new System.Windows.Forms.Label();
            this.txtIDVacina = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSalvarVacina = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.pnlExame = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPrecoExame = new System.Windows.Forms.TextBox();
            this.lblIDExame = new System.Windows.Forms.Label();
            this.txtIDExame = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConfirmarExame = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTipoExame = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNomeExame = new System.Windows.Forms.TextBox();
            this.pnlMedicamentos = new System.Windows.Forms.Panel();
            this.lblIDMedicamento = new System.Windows.Forms.Label();
            this.txtIDMedicamento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvarMedicamento = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbClassificacao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeMedicamento = new System.Windows.Forms.TextBox();
            this.pnlEsquerdo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTodos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Top.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.pnlTras.SuspendLayout();
            this.pnlCirurgia.SuspendLayout();
            this.pnlVacina.SuspendLayout();
            this.pnlExame.SuspendLayout();
            this.pnlMedicamentos.SuspendLayout();
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
            this.pnlTras.Controls.Add(this.pnlCirurgia);
            this.pnlTras.Controls.Add(this.pnlVacina);
            this.pnlTras.Controls.Add(this.pnlExame);
            this.pnlTras.Controls.Add(this.pnlMedicamentos);
            this.pnlTras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTras.Location = new System.Drawing.Point(349, 0);
            this.pnlTras.Name = "pnlTras";
            this.pnlTras.Size = new System.Drawing.Size(1021, 669);
            this.pnlTras.TabIndex = 101;
            // 
            // pnlCirurgia
            // 
            this.pnlCirurgia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCirurgia.Controls.Add(this.cbClassificacaoCirurgia);
            this.pnlCirurgia.Controls.Add(this.label20);
            this.pnlCirurgia.Controls.Add(this.txtPrecoCirurgia);
            this.pnlCirurgia.Controls.Add(this.lblIDCirurgia);
            this.pnlCirurgia.Controls.Add(this.txtIDCirurgia);
            this.pnlCirurgia.Controls.Add(this.lblCirurgia);
            this.pnlCirurgia.Controls.Add(this.btnSalvarCirurgia);
            this.pnlCirurgia.Controls.Add(this.label23);
            this.pnlCirurgia.Controls.Add(this.label24);
            this.pnlCirurgia.Controls.Add(this.txtNomeCirurgia);
            this.pnlCirurgia.Enabled = false;
            this.pnlCirurgia.Location = new System.Drawing.Point(276, 167);
            this.pnlCirurgia.Name = "pnlCirurgia";
            this.pnlCirurgia.Size = new System.Drawing.Size(466, 336);
            this.pnlCirurgia.TabIndex = 100;
            this.pnlCirurgia.Visible = false;
            // 
            // cbClassificacaoCirurgia
            // 
            this.cbClassificacaoCirurgia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClassificacaoCirurgia.FormattingEnabled = true;
            this.cbClassificacaoCirurgia.Items.AddRange(new object[] {
            "Preventiva",
            "Emergencial",
            "Castração"});
            this.cbClassificacaoCirurgia.Location = new System.Drawing.Point(52, 150);
            this.cbClassificacaoCirurgia.Name = "cbClassificacaoCirurgia";
            this.cbClassificacaoCirurgia.Size = new System.Drawing.Size(355, 22);
            this.cbClassificacaoCirurgia.TabIndex = 124;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(49, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 17);
            this.label20.TabIndex = 123;
            this.label20.Text = "PREÇO:";
            // 
            // txtPrecoCirurgia
            // 
            this.txtPrecoCirurgia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCirurgia.Location = new System.Drawing.Point(52, 226);
            this.txtPrecoCirurgia.MaxLength = 50;
            this.txtPrecoCirurgia.Name = "txtPrecoCirurgia";
            this.txtPrecoCirurgia.Size = new System.Drawing.Size(355, 22);
            this.txtPrecoCirurgia.TabIndex = 122;
            this.txtPrecoCirurgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecoCirurgia_KeyPress);
            // 
            // lblIDCirurgia
            // 
            this.lblIDCirurgia.AutoSize = true;
            this.lblIDCirurgia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCirurgia.ForeColor = System.Drawing.Color.White;
            this.lblIDCirurgia.Location = new System.Drawing.Point(302, 6);
            this.lblIDCirurgia.Name = "lblIDCirurgia";
            this.lblIDCirurgia.Size = new System.Drawing.Size(25, 17);
            this.lblIDCirurgia.TabIndex = 120;
            this.lblIDCirurgia.Text = "ID:";
            this.lblIDCirurgia.Visible = false;
            // 
            // txtIDCirurgia
            // 
            this.txtIDCirurgia.Enabled = false;
            this.txtIDCirurgia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCirurgia.Location = new System.Drawing.Point(333, 4);
            this.txtIDCirurgia.MaxLength = 50;
            this.txtIDCirurgia.Name = "txtIDCirurgia";
            this.txtIDCirurgia.Size = new System.Drawing.Size(74, 22);
            this.txtIDCirurgia.TabIndex = 119;
            this.txtIDCirurgia.Visible = false;
            // 
            // lblCirurgia
            // 
            this.lblCirurgia.AutoSize = true;
            this.lblCirurgia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirurgia.ForeColor = System.Drawing.Color.White;
            this.lblCirurgia.Location = new System.Drawing.Point(48, 3);
            this.lblCirurgia.Name = "lblCirurgia";
            this.lblCirurgia.Size = new System.Drawing.Size(82, 19);
            this.lblCirurgia.TabIndex = 118;
            this.lblCirurgia.Text = "CIRURGIA";
            // 
            // btnSalvarCirurgia
            // 
            this.btnSalvarCirurgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSalvarCirurgia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalvarCirurgia.FlatAppearance.BorderSize = 0;
            this.btnSalvarCirurgia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCirurgia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCirurgia.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCirurgia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCirurgia.Location = new System.Drawing.Point(0, 267);
            this.btnSalvarCirurgia.Name = "btnSalvarCirurgia";
            this.btnSalvarCirurgia.Size = new System.Drawing.Size(466, 69);
            this.btnSalvarCirurgia.TabIndex = 117;
            this.btnSalvarCirurgia.Text = "CONFIRMAR";
            this.btnSalvarCirurgia.UseVisualStyleBackColor = false;
            this.btnSalvarCirurgia.Click += new System.EventHandler(this.BtnSalvarCirurgia_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(49, 127);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 17);
            this.label23.TabIndex = 114;
            this.label23.Text = "CLASSIFICAÇÃO";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(49, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 17);
            this.label24.TabIndex = 98;
            this.label24.Text = "NOME:";
            // 
            // txtNomeCirurgia
            // 
            this.txtNomeCirurgia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCirurgia.Location = new System.Drawing.Point(52, 68);
            this.txtNomeCirurgia.MaxLength = 50;
            this.txtNomeCirurgia.Name = "txtNomeCirurgia";
            this.txtNomeCirurgia.Size = new System.Drawing.Size(355, 22);
            this.txtNomeCirurgia.TabIndex = 97;
            // 
            // pnlVacina
            // 
            this.pnlVacina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlVacina.Controls.Add(this.label18);
            this.pnlVacina.Controls.Add(this.txtPrecoVacina);
            this.pnlVacina.Controls.Add(this.txtInformacoesVacina);
            this.pnlVacina.Controls.Add(this.lblIDVacina);
            this.pnlVacina.Controls.Add(this.txtIDVacina);
            this.pnlVacina.Controls.Add(this.label15);
            this.pnlVacina.Controls.Add(this.btnSalvarVacina);
            this.pnlVacina.Controls.Add(this.label16);
            this.pnlVacina.Controls.Add(this.label17);
            this.pnlVacina.Controls.Add(this.txtNomeVacina);
            this.pnlVacina.Enabled = false;
            this.pnlVacina.Location = new System.Drawing.Point(277, 165);
            this.pnlVacina.Name = "pnlVacina";
            this.pnlVacina.Size = new System.Drawing.Size(466, 336);
            this.pnlVacina.TabIndex = 99;
            this.pnlVacina.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(49, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 17);
            this.label18.TabIndex = 123;
            this.label18.Text = "PREÇO:";
            // 
            // txtPrecoVacina
            // 
            this.txtPrecoVacina.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVacina.Location = new System.Drawing.Point(52, 226);
            this.txtPrecoVacina.MaxLength = 50;
            this.txtPrecoVacina.Name = "txtPrecoVacina";
            this.txtPrecoVacina.Size = new System.Drawing.Size(355, 22);
            this.txtPrecoVacina.TabIndex = 122;
            this.txtPrecoVacina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreco_KeyPress);
            // 
            // txtInformacoesVacina
            // 
            this.txtInformacoesVacina.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacoesVacina.Location = new System.Drawing.Point(52, 147);
            this.txtInformacoesVacina.MaxLength = 50;
            this.txtInformacoesVacina.Name = "txtInformacoesVacina";
            this.txtInformacoesVacina.Size = new System.Drawing.Size(355, 22);
            this.txtInformacoesVacina.TabIndex = 121;
            // 
            // lblIDVacina
            // 
            this.lblIDVacina.AutoSize = true;
            this.lblIDVacina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVacina.ForeColor = System.Drawing.Color.White;
            this.lblIDVacina.Location = new System.Drawing.Point(302, 6);
            this.lblIDVacina.Name = "lblIDVacina";
            this.lblIDVacina.Size = new System.Drawing.Size(25, 17);
            this.lblIDVacina.TabIndex = 120;
            this.lblIDVacina.Text = "ID:";
            this.lblIDVacina.Visible = false;
            // 
            // txtIDVacina
            // 
            this.txtIDVacina.Enabled = false;
            this.txtIDVacina.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVacina.Location = new System.Drawing.Point(333, 4);
            this.txtIDVacina.MaxLength = 50;
            this.txtIDVacina.Name = "txtIDVacina";
            this.txtIDVacina.Size = new System.Drawing.Size(74, 22);
            this.txtIDVacina.TabIndex = 119;
            this.txtIDVacina.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(48, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 19);
            this.label15.TabIndex = 118;
            this.label15.Text = "VACINA";
            // 
            // btnSalvarVacina
            // 
            this.btnSalvarVacina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSalvarVacina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalvarVacina.FlatAppearance.BorderSize = 0;
            this.btnSalvarVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarVacina.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarVacina.ForeColor = System.Drawing.Color.White;
            this.btnSalvarVacina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarVacina.Location = new System.Drawing.Point(0, 267);
            this.btnSalvarVacina.Name = "btnSalvarVacina";
            this.btnSalvarVacina.Size = new System.Drawing.Size(466, 69);
            this.btnSalvarVacina.TabIndex = 117;
            this.btnSalvarVacina.Text = "CONFIRMAR";
            this.btnSalvarVacina.UseVisualStyleBackColor = false;
            this.btnSalvarVacina.Click += new System.EventHandler(this.BtnSalvarVacina_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(49, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 17);
            this.label16.TabIndex = 114;
            this.label16.Text = "INFORMAÇÕES";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(49, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 17);
            this.label17.TabIndex = 98;
            this.label17.Text = "NOME:";
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVacina.Location = new System.Drawing.Point(52, 68);
            this.txtNomeVacina.MaxLength = 50;
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(355, 22);
            this.txtNomeVacina.TabIndex = 97;
            // 
            // pnlExame
            // 
            this.pnlExame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlExame.Controls.Add(this.label19);
            this.pnlExame.Controls.Add(this.txtPrecoExame);
            this.pnlExame.Controls.Add(this.lblIDExame);
            this.pnlExame.Controls.Add(this.txtIDExame);
            this.pnlExame.Controls.Add(this.label11);
            this.pnlExame.Controls.Add(this.btnConfirmarExame);
            this.pnlExame.Controls.Add(this.label13);
            this.pnlExame.Controls.Add(this.cbTipoExame);
            this.pnlExame.Controls.Add(this.label14);
            this.pnlExame.Controls.Add(this.txtNomeExame);
            this.pnlExame.Enabled = false;
            this.pnlExame.Location = new System.Drawing.Point(276, 166);
            this.pnlExame.Name = "pnlExame";
            this.pnlExame.Size = new System.Drawing.Size(466, 336);
            this.pnlExame.TabIndex = 98;
            this.pnlExame.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(52, 193);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 17);
            this.label19.TabIndex = 125;
            this.label19.Text = "PREÇO:";
            // 
            // txtPrecoExame
            // 
            this.txtPrecoExame.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoExame.Location = new System.Drawing.Point(55, 213);
            this.txtPrecoExame.MaxLength = 50;
            this.txtPrecoExame.Name = "txtPrecoExame";
            this.txtPrecoExame.Size = new System.Drawing.Size(355, 22);
            this.txtPrecoExame.TabIndex = 124;
            this.txtPrecoExame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecoExame_KeyPress);
            // 
            // lblIDExame
            // 
            this.lblIDExame.AutoSize = true;
            this.lblIDExame.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDExame.ForeColor = System.Drawing.Color.White;
            this.lblIDExame.Location = new System.Drawing.Point(302, 6);
            this.lblIDExame.Name = "lblIDExame";
            this.lblIDExame.Size = new System.Drawing.Size(25, 17);
            this.lblIDExame.TabIndex = 120;
            this.lblIDExame.Text = "ID:";
            this.lblIDExame.Visible = false;
            // 
            // txtIDExame
            // 
            this.txtIDExame.Enabled = false;
            this.txtIDExame.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDExame.Location = new System.Drawing.Point(333, 4);
            this.txtIDExame.MaxLength = 50;
            this.txtIDExame.Name = "txtIDExame";
            this.txtIDExame.Size = new System.Drawing.Size(74, 22);
            this.txtIDExame.TabIndex = 119;
            this.txtIDExame.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(48, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 118;
            this.label11.Text = "EXAME";
            // 
            // btnConfirmarExame
            // 
            this.btnConfirmarExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnConfirmarExame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfirmarExame.FlatAppearance.BorderSize = 0;
            this.btnConfirmarExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarExame.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarExame.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarExame.Location = new System.Drawing.Point(0, 267);
            this.btnConfirmarExame.Name = "btnConfirmarExame";
            this.btnConfirmarExame.Size = new System.Drawing.Size(466, 69);
            this.btnConfirmarExame.TabIndex = 117;
            this.btnConfirmarExame.Text = "CONFIRMAR";
            this.btnConfirmarExame.UseVisualStyleBackColor = false;
            this.btnConfirmarExame.Click += new System.EventHandler(this.BtnSalvarExame_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(49, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 17);
            this.label13.TabIndex = 114;
            this.label13.Text = "MATERIAL NECESSÁRIO:";
            // 
            // cbTipoExame
            // 
            this.cbTipoExame.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoExame.FormattingEnabled = true;
            this.cbTipoExame.Items.AddRange(new object[] {
            "Amostra de Sangue",
            "Amostra de Urina",
            "Amostra de Fezes",
            "Ultrassom",
            "Raio-X",
            "Outro"});
            this.cbTipoExame.Location = new System.Drawing.Point(52, 147);
            this.cbTipoExame.Name = "cbTipoExame";
            this.cbTipoExame.Size = new System.Drawing.Size(355, 22);
            this.cbTipoExame.TabIndex = 113;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(49, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 98;
            this.label14.Text = "NOME:";
            // 
            // txtNomeExame
            // 
            this.txtNomeExame.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeExame.Location = new System.Drawing.Point(52, 68);
            this.txtNomeExame.MaxLength = 50;
            this.txtNomeExame.Name = "txtNomeExame";
            this.txtNomeExame.Size = new System.Drawing.Size(355, 22);
            this.txtNomeExame.TabIndex = 97;
            // 
            // pnlMedicamentos
            // 
            this.pnlMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMedicamentos.Controls.Add(this.lblIDMedicamento);
            this.pnlMedicamentos.Controls.Add(this.txtIDMedicamento);
            this.pnlMedicamentos.Controls.Add(this.label9);
            this.pnlMedicamentos.Controls.Add(this.btnSalvarMedicamento);
            this.pnlMedicamentos.Controls.Add(this.label7);
            this.pnlMedicamentos.Controls.Add(this.cbClassificacao);
            this.pnlMedicamentos.Controls.Add(this.label6);
            this.pnlMedicamentos.Controls.Add(this.cbTipo);
            this.pnlMedicamentos.Controls.Add(this.label5);
            this.pnlMedicamentos.Controls.Add(this.txtNomeMedicamento);
            this.pnlMedicamentos.Enabled = false;
            this.pnlMedicamentos.Location = new System.Drawing.Point(277, 166);
            this.pnlMedicamentos.Name = "pnlMedicamentos";
            this.pnlMedicamentos.Size = new System.Drawing.Size(466, 336);
            this.pnlMedicamentos.TabIndex = 97;
            this.pnlMedicamentos.Visible = false;
            // 
            // lblIDMedicamento
            // 
            this.lblIDMedicamento.AutoSize = true;
            this.lblIDMedicamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMedicamento.ForeColor = System.Drawing.Color.White;
            this.lblIDMedicamento.Location = new System.Drawing.Point(302, 6);
            this.lblIDMedicamento.Name = "lblIDMedicamento";
            this.lblIDMedicamento.Size = new System.Drawing.Size(25, 17);
            this.lblIDMedicamento.TabIndex = 120;
            this.lblIDMedicamento.Text = "ID:";
            this.lblIDMedicamento.Visible = false;
            // 
            // txtIDMedicamento
            // 
            this.txtIDMedicamento.Enabled = false;
            this.txtIDMedicamento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMedicamento.Location = new System.Drawing.Point(333, 4);
            this.txtIDMedicamento.MaxLength = 50;
            this.txtIDMedicamento.Name = "txtIDMedicamento";
            this.txtIDMedicamento.Size = new System.Drawing.Size(74, 22);
            this.txtIDMedicamento.TabIndex = 119;
            this.txtIDMedicamento.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 118;
            this.label9.Text = "MEDICAMENTO";
            // 
            // btnSalvarMedicamento
            // 
            this.btnSalvarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSalvarMedicamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalvarMedicamento.FlatAppearance.BorderSize = 0;
            this.btnSalvarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarMedicamento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMedicamento.ForeColor = System.Drawing.Color.White;
            this.btnSalvarMedicamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarMedicamento.Location = new System.Drawing.Point(0, 267);
            this.btnSalvarMedicamento.Name = "btnSalvarMedicamento";
            this.btnSalvarMedicamento.Size = new System.Drawing.Size(466, 69);
            this.btnSalvarMedicamento.TabIndex = 117;
            this.btnSalvarMedicamento.Text = "CONFIRMAR";
            this.btnSalvarMedicamento.UseVisualStyleBackColor = false;
            this.btnSalvarMedicamento.Click += new System.EventHandler(this.BtnSalvarMedicamento_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(49, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 116;
            this.label7.Text = "CLASSIFICAÇÃO:";
            // 
            // cbClassificacao
            // 
            this.cbClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClassificacao.FormattingEnabled = true;
            this.cbClassificacao.Items.AddRange(new object[] {
            "Antibiótico",
            "Anti-Inflamatório",
            "Higiene",
            "Suplementação"});
            this.cbClassificacao.Location = new System.Drawing.Point(52, 229);
            this.cbClassificacao.Name = "cbClassificacao";
            this.cbClassificacao.Size = new System.Drawing.Size(355, 22);
            this.cbClassificacao.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 114;
            this.label6.Text = "TIPO:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Comprimido",
            "Aerosol",
            "Líquido"});
            this.cbTipo.Location = new System.Drawing.Point(52, 147);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(355, 22);
            this.cbTipo.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "NOME:";
            // 
            // txtNomeMedicamento
            // 
            this.txtNomeMedicamento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMedicamento.Location = new System.Drawing.Point(52, 68);
            this.txtNomeMedicamento.MaxLength = 50;
            this.txtNomeMedicamento.Name = "txtNomeMedicamento";
            this.txtNomeMedicamento.Size = new System.Drawing.Size(355, 22);
            this.txtNomeMedicamento.TabIndex = 97;
            // 
            // pnlEsquerdo
            // 
            this.pnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlEsquerdo.Controls.Add(this.panel1);
            this.pnlEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            this.pnlEsquerdo.Size = new System.Drawing.Size(349, 669);
            this.pnlEsquerdo.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbTodos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbServico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbOpcao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 397);
            this.panel1.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 117;
            this.label8.Text = "CONTROLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 112;
            this.label4.Text = "CADASTRADOS";
            // 
            // cbTodos
            // 
            this.cbTodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTodos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodos.FormattingEnabled = true;
            this.cbTodos.Location = new System.Drawing.Point(25, 263);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(259, 22);
            this.cbTodos.TabIndex = 111;
            this.cbTodos.SelectedIndexChanged += new System.EventHandler(this.CbTodos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "SERVIÇO";
            // 
            // cbServico
            // 
            this.cbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServico.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Items.AddRange(new object[] {
            "Medicamento",
            "Exame",
            "Vacina",
            "Cirurgia"});
            this.cbServico.Location = new System.Drawing.Point(25, 161);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(259, 22);
            this.cbServico.TabIndex = 109;
            this.cbServico.SelectedIndexChanged += new System.EventHandler(this.CbServico_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 108;
            this.label1.Text = "OPÇÃO";
            // 
            // cbOpcao
            // 
            this.cbOpcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "Novo",
            "Editar",
            "Excluir"});
            this.cbOpcao.Location = new System.Drawing.Point(25, 71);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(259, 22);
            this.cbOpcao.TabIndex = 107;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.CbOpcao_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-139, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "STATUS:";
            // 
            // ControleServicos
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
            this.Name = "ControleServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Top.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlTras.ResumeLayout(false);
            this.pnlCirurgia.ResumeLayout(false);
            this.pnlCirurgia.PerformLayout();
            this.pnlVacina.ResumeLayout(false);
            this.pnlVacina.PerformLayout();
            this.pnlExame.ResumeLayout(false);
            this.pnlExame.PerformLayout();
            this.pnlMedicamentos.ResumeLayout(false);
            this.pnlMedicamentos.PerformLayout();
            this.pnlEsquerdo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlEsquerdo;
        private System.Windows.Forms.Panel pnlTras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMedicamentos;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMedicamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbClassificacao;
        private System.Windows.Forms.Button btnSalvarMedicamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIDMedicamento;
        private System.Windows.Forms.TextBox txtIDMedicamento;
        private System.Windows.Forms.Panel pnlExame;
        private System.Windows.Forms.Label lblIDExame;
        private System.Windows.Forms.TextBox txtIDExame;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConfirmarExame;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTipoExame;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNomeExame;
        private System.Windows.Forms.Panel pnlVacina;
        private System.Windows.Forms.Label lblIDVacina;
        private System.Windows.Forms.TextBox txtIDVacina;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSalvarVacina;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNomeVacina;
        private System.Windows.Forms.TextBox txtInformacoesVacina;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPrecoVacina;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPrecoExame;
        private System.Windows.Forms.Panel pnlCirurgia;
        private System.Windows.Forms.ComboBox cbClassificacaoCirurgia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPrecoCirurgia;
        private System.Windows.Forms.Label lblIDCirurgia;
        private System.Windows.Forms.TextBox txtIDCirurgia;
        private System.Windows.Forms.Label lblCirurgia;
        private System.Windows.Forms.Button btnSalvarCirurgia;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtNomeCirurgia;
    }
}

