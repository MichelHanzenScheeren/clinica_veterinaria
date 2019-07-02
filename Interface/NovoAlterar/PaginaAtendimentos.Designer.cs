namespace Interface
{
    partial class PaginaAtendimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaAtendimentos));
            this.Top = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ttFechar = new System.Windows.Forms.ToolTip(this.components);
            this.ttAlterarTamanho = new System.Windows.Forms.ToolTip(this.components);
            this.ttMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttVOLTAR = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSub = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.pnlOutros = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.numParcelas = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConclusao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.pnlEsquerdo = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.btnAdicionarAnimal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbVeterinarios = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbAgendamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cbClassificacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Top.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.pnlDireito.SuspendLayout();
            this.pnlOutros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).BeginInit();
            this.pnlEsquerdo.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.TabStop = false;
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
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.TabStop = false;
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
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.TabStop = false;
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
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttFechar.SetToolTip(this.btnFechar, "FECHAR PROGRAMA");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pnlSub
            // 
            this.pnlSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlSub.Controls.Add(this.btnCancelar);
            this.pnlSub.Controls.Add(this.btnSalvar);
            this.pnlSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSub.Location = new System.Drawing.Point(0, 657);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(1370, 73);
            this.pnlSub.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(685, 73);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR O CADASTRO";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(685, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(685, 73);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR NOVO CADASTRO";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.pnlDireito);
            this.pnlCentral.Controls.Add(this.pnlEsquerdo);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 61);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1370, 596);
            this.pnlCentral.TabIndex = 96;
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlDireito.Controls.Add(this.pnlOutros);
            this.pnlDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireito.Location = new System.Drawing.Point(685, 0);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(685, 596);
            this.pnlDireito.TabIndex = 101;
            // 
            // pnlOutros
            // 
            this.pnlOutros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOutros.Controls.Add(this.lblAviso);
            this.pnlOutros.Controls.Add(this.lblParcelas);
            this.pnlOutros.Controls.Add(this.numParcelas);
            this.pnlOutros.Controls.Add(this.label15);
            this.pnlOutros.Controls.Add(this.dtVencimento);
            this.pnlOutros.Controls.Add(this.label14);
            this.pnlOutros.Controls.Add(this.cbMetodoPagamento);
            this.pnlOutros.Controls.Add(this.label9);
            this.pnlOutros.Controls.Add(this.label6);
            this.pnlOutros.Controls.Add(this.label11);
            this.pnlOutros.Controls.Add(this.txtPreco);
            this.pnlOutros.Controls.Add(this.label10);
            this.pnlOutros.Controls.Add(this.txtConclusao);
            this.pnlOutros.Controls.Add(this.label12);
            this.pnlOutros.Controls.Add(this.txtResumo);
            this.pnlOutros.Location = new System.Drawing.Point(98, 110);
            this.pnlOutros.Name = "pnlOutros";
            this.pnlOutros.Size = new System.Drawing.Size(477, 409);
            this.pnlOutros.TabIndex = 107;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(-3, 372);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(478, 16);
            this.lblAviso.TabIndex = 124;
            this.lblAviso.Text = "REGISTROS FINANCEIROS PODEM SER MODIFICADOS NA ABA \"FINANÇAS\"";
            this.lblAviso.Visible = false;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Enabled = false;
            this.lblParcelas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.ForeColor = System.Drawing.Color.White;
            this.lblParcelas.Location = new System.Drawing.Point(245, 311);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(72, 17);
            this.lblParcelas.TabIndex = 123;
            this.lblParcelas.Text = "PARCELAS";
            this.lblParcelas.Visible = false;
            // 
            // numParcelas
            // 
            this.numParcelas.Enabled = false;
            this.numParcelas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numParcelas.Location = new System.Drawing.Point(248, 331);
            this.numParcelas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numParcelas.Name = "numParcelas";
            this.numParcelas.Size = new System.Drawing.Size(195, 22);
            this.numParcelas.TabIndex = 5;
            this.numParcelas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numParcelas.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 122;
            this.label15.Text = "VENCIMENTO:";
            // 
            // dtVencimento
            // 
            this.dtVencimento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(3, 331);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(198, 22);
            this.dtVencimento.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(245, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 17);
            this.label14.TabIndex = 120;
            this.label14.Text = "MÉTODO DE PAGAMENTO:";
            // 
            // cbMetodoPagamento
            // 
            this.cbMetodoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodoPagamento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodoPagamento.FormattingEnabled = true;
            this.cbMetodoPagamento.Items.AddRange(new object[] {
            "À Vista - Dinheiro",
            "A Prazo - Dinheiro",
            "À Vista - Cartão",
            "A Prazo - Cartão"});
            this.cbMetodoPagamento.Location = new System.Drawing.Point(248, 283);
            this.cbMetodoPagamento.Name = "cbMetodoPagamento";
            this.cbMetodoPagamento.Size = new System.Drawing.Size(195, 22);
            this.cbMetodoPagamento.TabIndex = 3;
            this.cbMetodoPagamento.SelectedIndexChanged += new System.EventHandler(this.CbMetodoPagamento_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-1, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 118;
            this.label9.Text = "PAGAMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 117;
            this.label6.Text = "RESUMO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-3, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 116;
            this.label11.Text = "PREÇO:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(0, 283);
            this.txtPreco.MaxLength = 50;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(201, 22);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreco_KeyPress_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-3, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 114;
            this.label10.Text = "CONCLUSÕES:";
            // 
            // txtConclusao
            // 
            this.txtConclusao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConclusao.Location = new System.Drawing.Point(0, 144);
            this.txtConclusao.MaxLength = 500;
            this.txtConclusao.Multiline = true;
            this.txtConclusao.Name = "txtConclusao";
            this.txtConclusao.Size = new System.Drawing.Size(443, 80);
            this.txtConclusao.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-3, -20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 110;
            this.label12.Text = "Resumo:";
            // 
            // txtResumo
            // 
            this.txtResumo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumo.Location = new System.Drawing.Point(0, 18);
            this.txtResumo.MaxLength = 500;
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(443, 80);
            this.txtResumo.TabIndex = 0;
            // 
            // pnlEsquerdo
            // 
            this.pnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlEsquerdo.Controls.Add(this.pnlInfo);
            this.pnlEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            this.pnlEsquerdo.Size = new System.Drawing.Size(685, 596);
            this.pnlEsquerdo.TabIndex = 100;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInfo.Controls.Add(this.cbPaciente);
            this.pnlInfo.Controls.Add(this.btnAdicionarAnimal);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.lblID);
            this.pnlInfo.Controls.Add(this.cbVeterinarios);
            this.pnlInfo.Controls.Add(this.txtID);
            this.pnlInfo.Controls.Add(this.cbAgendamento);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.dtHora);
            this.pnlInfo.Controls.Add(this.label13);
            this.pnlInfo.Controls.Add(this.cbClassificacao);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.dtData);
            this.pnlInfo.Controls.Add(this.cbTipo);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Location = new System.Drawing.Point(121, 110);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(467, 363);
            this.pnlInfo.TabIndex = 5;
            // 
            // cbPaciente
            // 
            this.cbPaciente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(4, 309);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(390, 22);
            this.cbPaciente.TabIndex = 111;
            // 
            // btnAdicionarAnimal
            // 
            this.btnAdicionarAnimal.FlatAppearance.BorderSize = 0;
            this.btnAdicionarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarAnimal.Image")));
            this.btnAdicionarAnimal.Location = new System.Drawing.Point(405, 289);
            this.btnAdicionarAnimal.Name = "btnAdicionarAnimal";
            this.btnAdicionarAnimal.Size = new System.Drawing.Size(48, 55);
            this.btnAdicionarAnimal.TabIndex = 112;
            this.btnAdicionarAnimal.TabStop = false;
            this.btnAdicionarAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarAnimal.Click += new System.EventHandler(this.BtnAdicionarAnimal_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "VETERINÁRIO RESPONSÁVEL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 113;
            this.label7.Text = "PACIENTE:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(341, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 118;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // cbVeterinarios
            // 
            this.cbVeterinarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVeterinarios.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeterinarios.FormattingEnabled = true;
            this.cbVeterinarios.Location = new System.Drawing.Point(0, 61);
            this.cbVeterinarios.Name = "cbVeterinarios";
            this.cbVeterinarios.Size = new System.Drawing.Size(443, 22);
            this.cbVeterinarios.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(372, 3);
            this.txtID.MaxLength = 50;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(77, 22);
            this.txtID.TabIndex = 117;
            this.txtID.Visible = false;
            // 
            // cbAgendamento
            // 
            this.cbAgendamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgendamento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgendamento.FormattingEnabled = true;
            this.cbAgendamento.Location = new System.Drawing.Point(0, 180);
            this.cbAgendamento.Name = "cbAgendamento";
            this.cbAgendamento.Size = new System.Drawing.Size(447, 22);
            this.cbAgendamento.TabIndex = 4;
            this.cbAgendamento.SelectedIndexChanged += new System.EventHandler(this.CbAgendamento_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "AGENDAMENTO ASSOCIADO:";
            // 
            // dtHora
            // 
            this.dtHora.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(354, 249);
            this.dtHora.Name = "dtHora";
            this.dtHora.ShowUpDown = true;
            this.dtHora.Size = new System.Drawing.Size(93, 22);
            this.dtHora.TabIndex = 6;
            this.dtHora.Value = new System.DateTime(2019, 6, 16, 8, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(168, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 17);
            this.label13.TabIndex = 96;
            this.label13.Text = "INFORMAÇÕES ESPECÍFICAS:";
            // 
            // cbClassificacao
            // 
            this.cbClassificacao.DropDownHeight = 150;
            this.cbClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClassificacao.FormattingEnabled = true;
            this.cbClassificacao.IntegralHeight = false;
            this.cbClassificacao.Location = new System.Drawing.Point(171, 122);
            this.cbClassificacao.MaxDropDownItems = 20;
            this.cbClassificacao.Name = "cbClassificacao";
            this.cbClassificacao.Size = new System.Drawing.Size(276, 22);
            this.cbClassificacao.TabIndex = 3;
            this.cbClassificacao.SelectedIndexChanged += new System.EventHandler(this.CbClassificacao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "HORÁRIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "DATA:";
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Location = new System.Drawing.Point(4, 249);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(304, 22);
            this.dtData.TabIndex = 5;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Consulta",
            "Exame",
            "Vacina",
            "Cirurgia"});
            this.cbTipo.Location = new System.Drawing.Point(0, 122);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(138, 22);
            this.cbTipo.TabIndex = 2;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 96;
            this.label5.Text = "TIPO:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 150;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // PaginaAtendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlSub);
            this.Controls.Add(this.Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaAtendimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.PaginaCadastro_Resize);
            this.Top.ResumeLayout(false);
            this.pnlSub.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlDireito.ResumeLayout(false);
            this.pnlOutros.ResumeLayout(false);
            this.pnlOutros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).EndInit();
            this.pnlEsquerdo.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlEsquerdo;
        private System.Windows.Forms.Panel pnlDireito;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.ComboBox cbAgendamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlOutros;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConclusao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.ComboBox cbClassificacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMetodoPagamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.NumericUpDown numParcelas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVeterinarios;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.Button btnAdicionarAnimal;
        private System.Windows.Forms.Label label7;
    }
}

