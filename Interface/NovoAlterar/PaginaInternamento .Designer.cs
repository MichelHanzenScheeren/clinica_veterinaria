namespace Interface
{
    partial class PaginaInternamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInternamento));
            this.Top = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ttFechar = new System.Windows.Forms.ToolTip(this.components);
            this.ttAlterarTamanho = new System.Windows.Forms.ToolTip(this.components);
            this.ttMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttVOLTAR = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkSaida = new System.Windows.Forms.CheckBox();
            this.checkEntrada = new System.Windows.Forms.CheckBox();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numQuarto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.btnAdicionarAnimal = new System.Windows.Forms.Button();
            this.dtHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.dtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtSaida = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSaida = new System.Windows.Forms.Panel();
            this.lblAviso2 = new System.Windows.Forms.Label();
            this.lblAviso1 = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.numParcelas = new System.Windows.Forms.NumericUpDown();
            this.cbMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtConclusao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFundo.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuarto)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).BeginInit();
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
            this.btnAlterar.TabIndex = 10;
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
            this.btnVoltar.TabIndex = 9;
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
            this.btnMinimizar.TabIndex = 8;
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
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TabStop = false;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttFechar.SetToolTip(this.btnFechar, "FECHAR PROGRAMA");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 631);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 99);
            this.panel1.TabIndex = 2;
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
            this.btnCancelar.Size = new System.Drawing.Size(685, 99);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.btnSalvar.Size = new System.Drawing.Size(685, 99);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR INTERNAMENTO";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlFundo.Controls.Add(this.pnlCentral);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 61);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1370, 570);
            this.pnlFundo.TabIndex = 95;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCentral.Controls.Add(this.panel3);
            this.pnlCentral.Controls.Add(this.panel2);
            this.pnlCentral.Location = new System.Drawing.Point(199, 100);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(971, 369);
            this.pnlCentral.TabIndex = 101;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkSaida);
            this.panel3.Controls.Add(this.checkEntrada);
            this.panel3.Controls.Add(this.dtEntrada);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.numQuarto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbPaciente);
            this.panel3.Controls.Add(this.btnAdicionarAnimal);
            this.panel3.Controls.Add(this.dtHoraSaida);
            this.panel3.Controls.Add(this.dtHoraEntrada);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.dtSaida);
            this.panel3.Location = new System.Drawing.Point(14, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 353);
            this.panel3.TabIndex = 125;
            // 
            // checkSaida
            // 
            this.checkSaida.AutoSize = true;
            this.checkSaida.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSaida.ForeColor = System.Drawing.Color.White;
            this.checkSaida.Location = new System.Drawing.Point(241, 64);
            this.checkSaida.Name = "checkSaida";
            this.checkSaida.Size = new System.Drawing.Size(66, 18);
            this.checkSaida.TabIndex = 113;
            this.checkSaida.TabStop = false;
            this.checkSaida.Text = "SAÍDA";
            this.checkSaida.UseVisualStyleBackColor = true;
            this.checkSaida.CheckedChanged += new System.EventHandler(this.CheckSaida_CheckedChanged);
            // 
            // checkEntrada
            // 
            this.checkEntrada.AutoSize = true;
            this.checkEntrada.Checked = true;
            this.checkEntrada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEntrada.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEntrada.ForeColor = System.Drawing.Color.White;
            this.checkEntrada.Location = new System.Drawing.Point(115, 64);
            this.checkEntrada.Name = "checkEntrada";
            this.checkEntrada.Size = new System.Drawing.Size(84, 18);
            this.checkEntrada.TabIndex = 112;
            this.checkEntrada.TabStop = false;
            this.checkEntrada.Text = "ENTRADA";
            this.checkEntrada.UseVisualStyleBackColor = true;
            this.checkEntrada.CheckedChanged += new System.EventHandler(this.CheckEntrada_CheckedChanged);
            // 
            // dtEntrada
            // 
            this.dtEntrada.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEntrada.Location = new System.Drawing.Point(7, 117);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(331, 22);
            this.dtEntrada.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "DATA DE ENTRADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "PACIENTE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(384, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 111;
            this.label7.Text = "QUARTO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(384, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "HORÁRIO:";
            // 
            // numQuarto
            // 
            this.numQuarto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuarto.Location = new System.Drawing.Point(387, 275);
            this.numQuarto.Name = "numQuarto";
            this.numQuarto.Size = new System.Drawing.Size(111, 22);
            this.numQuarto.TabIndex = 3;
            this.numQuarto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 23);
            this.label9.TabIndex = 79;
            this.label9.Text = "INTERNAMENTO";
            // 
            // cbPaciente
            // 
            this.cbPaciente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(7, 275);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(314, 22);
            this.cbPaciente.TabIndex = 2;
            // 
            // btnAdicionarAnimal
            // 
            this.btnAdicionarAnimal.FlatAppearance.BorderSize = 0;
            this.btnAdicionarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarAnimal.Image")));
            this.btnAdicionarAnimal.Location = new System.Drawing.Point(327, 255);
            this.btnAdicionarAnimal.Name = "btnAdicionarAnimal";
            this.btnAdicionarAnimal.Size = new System.Drawing.Size(51, 55);
            this.btnAdicionarAnimal.TabIndex = 102;
            this.btnAdicionarAnimal.TabStop = false;
            this.btnAdicionarAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarAnimal.Click += new System.EventHandler(this.BtnAdicionarAnimal_Click);
            // 
            // dtHoraSaida
            // 
            this.dtHoraSaida.Enabled = false;
            this.dtHoraSaida.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraSaida.Location = new System.Drawing.Point(387, 195);
            this.dtHoraSaida.Name = "dtHoraSaida";
            this.dtHoraSaida.ShowUpDown = true;
            this.dtHoraSaida.Size = new System.Drawing.Size(111, 22);
            this.dtHoraSaida.TabIndex = 1;
            this.dtHoraSaida.Value = new System.DateTime(2019, 6, 16, 8, 0, 0, 0);
            // 
            // dtHoraEntrada
            // 
            this.dtHoraEntrada.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraEntrada.Location = new System.Drawing.Point(387, 117);
            this.dtHoraEntrada.Name = "dtHoraEntrada";
            this.dtHoraEntrada.ShowUpDown = true;
            this.dtHoraEntrada.Size = new System.Drawing.Size(111, 22);
            this.dtHoraEntrada.TabIndex = 1;
            this.dtHoraEntrada.Value = new System.DateTime(2019, 6, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 109;
            this.label1.Text = "HORÁRIO:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(401, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 104;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 108;
            this.label2.Text = "DATA DA SAÍDA";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(432, 13);
            this.txtID.MaxLength = 50;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(66, 22);
            this.txtID.TabIndex = 103;
            this.txtID.Visible = false;
            // 
            // dtSaida
            // 
            this.dtSaida.Enabled = false;
            this.dtSaida.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSaida.Location = new System.Drawing.Point(7, 195);
            this.dtSaida.Name = "dtSaida";
            this.dtSaida.Size = new System.Drawing.Size(331, 22);
            this.dtSaida.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlSaida);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtResumo);
            this.panel2.Location = new System.Drawing.Point(543, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 353);
            this.panel2.TabIndex = 124;
            // 
            // pnlSaida
            // 
            this.pnlSaida.Controls.Add(this.lblAviso2);
            this.pnlSaida.Controls.Add(this.lblAviso1);
            this.pnlSaida.Controls.Add(this.lblParcelas);
            this.pnlSaida.Controls.Add(this.dtVencimento);
            this.pnlSaida.Controls.Add(this.label14);
            this.pnlSaida.Controls.Add(this.numParcelas);
            this.pnlSaida.Controls.Add(this.cbMetodoPagamento);
            this.pnlSaida.Controls.Add(this.txtPreco);
            this.pnlSaida.Controls.Add(this.txtConclusao);
            this.pnlSaida.Controls.Add(this.label10);
            this.pnlSaida.Controls.Add(this.label3);
            this.pnlSaida.Controls.Add(this.label11);
            this.pnlSaida.Controls.Add(this.label15);
            this.pnlSaida.Enabled = false;
            this.pnlSaida.Location = new System.Drawing.Point(3, 77);
            this.pnlSaida.Name = "pnlSaida";
            this.pnlSaida.Size = new System.Drawing.Size(409, 276);
            this.pnlSaida.TabIndex = 0;
            this.pnlSaida.Visible = false;
            // 
            // lblAviso2
            // 
            this.lblAviso2.AutoSize = true;
            this.lblAviso2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso2.ForeColor = System.Drawing.Color.Red;
            this.lblAviso2.Location = new System.Drawing.Point(13, 254);
            this.lblAviso2.Name = "lblAviso2";
            this.lblAviso2.Size = new System.Drawing.Size(117, 16);
            this.lblAviso2.TabIndex = 134;
            this.lblAviso2.Text = "ABA \"FINANÇAS\"";
            this.lblAviso2.Visible = false;
            // 
            // lblAviso1
            // 
            this.lblAviso1.AutoSize = true;
            this.lblAviso1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso1.ForeColor = System.Drawing.Color.Red;
            this.lblAviso1.Location = new System.Drawing.Point(7, 231);
            this.lblAviso1.Name = "lblAviso1";
            this.lblAviso1.Size = new System.Drawing.Size(369, 16);
            this.lblAviso1.TabIndex = 133;
            this.lblAviso1.Text = "REGISTROS FINANCEIROS PODEM SER MODIFICADOS  NA";
            this.lblAviso1.Visible = false;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Enabled = false;
            this.lblParcelas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.ForeColor = System.Drawing.Color.White;
            this.lblParcelas.Location = new System.Drawing.Point(218, 167);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(72, 17);
            this.lblParcelas.TabIndex = 132;
            this.lblParcelas.Text = "PARCELAS";
            this.lblParcelas.Visible = false;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(6, 187);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(148, 22);
            this.dtVencimento.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(218, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 17);
            this.label14.TabIndex = 129;
            this.label14.Text = "FORMA DE PAGAMENTO:";
            // 
            // numParcelas
            // 
            this.numParcelas.Enabled = false;
            this.numParcelas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numParcelas.Location = new System.Drawing.Point(227, 187);
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
            this.numParcelas.Size = new System.Drawing.Size(154, 22);
            this.numParcelas.TabIndex = 4;
            this.numParcelas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numParcelas.Visible = false;
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
            this.cbMetodoPagamento.Location = new System.Drawing.Point(221, 132);
            this.cbMetodoPagamento.Name = "cbMetodoPagamento";
            this.cbMetodoPagamento.Size = new System.Drawing.Size(160, 22);
            this.cbMetodoPagamento.TabIndex = 2;
            this.cbMetodoPagamento.SelectedIndexChanged += new System.EventHandler(this.CbMetodoPagamento_SelectedIndexChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(6, 132);
            this.txtPreco.MaxLength = 50;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(151, 22);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreco_KeyPress);
            // 
            // txtConclusao
            // 
            this.txtConclusao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConclusao.Location = new System.Drawing.Point(6, 22);
            this.txtConclusao.MaxLength = 500;
            this.txtConclusao.Multiline = true;
            this.txtConclusao.Name = "txtConclusao";
            this.txtConclusao.Size = new System.Drawing.Size(379, 50);
            this.txtConclusao.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 122;
            this.label10.Text = "CONCLUSÕES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 127;
            this.label3.Text = "PAGAMENTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 126;
            this.label11.Text = "PREÇO:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 131;
            this.label15.Text = "VENCIMENTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 123;
            this.label8.Text = "RESUMO:";
            // 
            // txtResumo
            // 
            this.txtResumo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumo.Location = new System.Drawing.Point(9, 20);
            this.txtResumo.MaxLength = 500;
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(379, 50);
            this.txtResumo.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 150;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // PaginaInternamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFundo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaInternamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlFundo.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuarto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSaida.ResumeLayout(false);
            this.pnlSaida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Button btnAdicionarAnimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtEntrada;
        private System.Windows.Forms.DateTimePicker dtHoraEntrada;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtHoraSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSaida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numQuarto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConclusao;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.NumericUpDown numParcelas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMetodoPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.CheckBox checkSaida;
        private System.Windows.Forms.CheckBox checkEntrada;
        private System.Windows.Forms.Panel pnlSaida;
        private System.Windows.Forms.Label lblAviso1;
        private System.Windows.Forms.Label lblAviso2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

