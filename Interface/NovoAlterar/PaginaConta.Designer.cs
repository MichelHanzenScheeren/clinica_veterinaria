namespace Interface
{
    partial class PaginaConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaConta));
            this.Top = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ttFechar = new System.Windows.Forms.ToolTip(this.components);
            this.ttAlterarTamanho = new System.Windows.Forms.ToolTip(this.components);
            this.ttMinimizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttVOLTAR = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSub = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlConta = new System.Windows.Forms.Panel();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscarCadastro = new System.Windows.Forms.Button();
            this.cbCadastro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numValorPago = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.numParcelas = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Top.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Top.Controls.Add(this.btnFechar);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(649, 61);
            this.Top.TabIndex = 0;
            this.Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(591, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 55);
            this.btnFechar.TabIndex = 3;
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
            this.pnlSub.Location = new System.Drawing.Point(0, 408);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(649, 73);
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
            this.btnCancelar.Size = new System.Drawing.Size(320, 73);
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
            this.btnSalvar.Location = new System.Drawing.Point(320, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(329, 73);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInfo.Controls.Add(this.pnlConta);
            this.pnlInfo.Controls.Add(this.numValor);
            this.pnlInfo.Controls.Add(this.lblParcelas);
            this.pnlInfo.Controls.Add(this.numParcelas);
            this.pnlInfo.Controls.Add(this.label15);
            this.pnlInfo.Controls.Add(this.dtVencimento);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Controls.Add(this.cbMetodoPagamento);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.lblID);
            this.pnlInfo.Controls.Add(this.txtID);
            this.pnlInfo.Location = new System.Drawing.Point(78, 89);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(498, 300);
            this.pnlInfo.TabIndex = 6;
            // 
            // pnlConta
            // 
            this.pnlConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlConta.Controls.Add(this.cbTipo);
            this.pnlConta.Controls.Add(this.cbCategoria);
            this.pnlConta.Controls.Add(this.btnBuscarCadastro);
            this.pnlConta.Controls.Add(this.cbCadastro);
            this.pnlConta.Controls.Add(this.label4);
            this.pnlConta.Controls.Add(this.numValorPago);
            this.pnlConta.Controls.Add(this.label3);
            this.pnlConta.Controls.Add(this.label2);
            this.pnlConta.Controls.Add(this.label1);
            this.pnlConta.Location = new System.Drawing.Point(3, 181);
            this.pnlConta.Name = "pnlConta";
            this.pnlConta.Size = new System.Drawing.Size(495, 119);
            this.pnlConta.TabIndex = 126;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbTipo.Location = new System.Drawing.Point(16, 25);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(201, 22);
            this.cbTipo.TabIndex = 0;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(258, 25);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(201, 22);
            this.cbCategoria.TabIndex = 1;
            // 
            // btnBuscarCadastro
            // 
            this.btnBuscarCadastro.FlatAppearance.BorderSize = 0;
            this.btnBuscarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCadastro.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCadastro.Image")));
            this.btnBuscarCadastro.Location = new System.Drawing.Point(462, 61);
            this.btnBuscarCadastro.Name = "btnBuscarCadastro";
            this.btnBuscarCadastro.Size = new System.Drawing.Size(33, 55);
            this.btnBuscarCadastro.TabIndex = 139;
            this.btnBuscarCadastro.TabStop = false;
            this.btnBuscarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarCadastro.Click += new System.EventHandler(this.BtnBuscarDono_Click);
            // 
            // cbCadastro
            // 
            this.cbCadastro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCadastro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadastro.FormattingEnabled = true;
            this.cbCadastro.Location = new System.Drawing.Point(258, 79);
            this.cbCadastro.Name = "cbCadastro";
            this.cbCadastro.Size = new System.Drawing.Size(201, 22);
            this.cbCadastro.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(255, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 137;
            this.label4.Text = "CADASTRO:";
            // 
            // numValorPago
            // 
            this.numValorPago.DecimalPlaces = 2;
            this.numValorPago.Location = new System.Drawing.Point(16, 81);
            this.numValorPago.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numValorPago.Name = "numValorPago";
            this.numValorPago.Size = new System.Drawing.Size(201, 20);
            this.numValorPago.TabIndex = 2;
            this.numValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValorPago_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "VALOR PAGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 133;
            this.label2.Text = "CATEGORIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 131;
            this.label1.Text = "TIPO:";
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Location = new System.Drawing.Point(19, 91);
            this.numValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(195, 20);
            this.numValor.TabIndex = 0;
            this.numValor.ValueChanged += new System.EventHandler(this.NumValor_ValueChanged);
            this.numValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValor_KeyPress);
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Enabled = false;
            this.lblParcelas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.ForeColor = System.Drawing.Color.White;
            this.lblParcelas.Location = new System.Drawing.Point(258, 133);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(76, 17);
            this.lblParcelas.TabIndex = 132;
            this.lblParcelas.Text = "PARCELAS:";
            this.lblParcelas.Visible = false;
            // 
            // numParcelas
            // 
            this.numParcelas.Enabled = false;
            this.numParcelas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numParcelas.Location = new System.Drawing.Point(261, 153);
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
            this.numParcelas.Size = new System.Drawing.Size(204, 22);
            this.numParcelas.TabIndex = 3;
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
            this.label15.Location = new System.Drawing.Point(16, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 131;
            this.label15.Text = "VENCIMENTO:";
            // 
            // dtVencimento
            // 
            this.dtVencimento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(16, 153);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(198, 22);
            this.dtVencimento.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(258, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 17);
            this.label14.TabIndex = 129;
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
            this.cbMetodoPagamento.Location = new System.Drawing.Point(261, 91);
            this.cbMetodoPagamento.Name = "cbMetodoPagamento";
            this.cbMetodoPagamento.Size = new System.Drawing.Size(201, 22);
            this.cbMetodoPagamento.TabIndex = 1;
            this.cbMetodoPagamento.SelectedIndexChanged += new System.EventHandler(this.CbMetodoPagamento_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 126;
            this.label11.Text = "VALOR TOTAL";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(354, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 118;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(385, 1);
            this.txtID.MaxLength = 50;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(77, 22);
            this.txtID.TabIndex = 117;
            this.txtID.Visible = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(176, 226);
            this.txtPreco.MaxLength = 50;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(201, 22);
            this.txtPreco.TabIndex = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 150;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // PaginaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(649, 481);
            this.ControlBox = false;
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlSub);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.txtPreco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Top.ResumeLayout(false);
            this.pnlSub.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlConta.ResumeLayout(false);
            this.pnlConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.ToolTip ttAlterarTamanho;
        private System.Windows.Forms.ToolTip ttVOLTAR;
        private System.Windows.Forms.ToolTip ttMinimizar;
        private System.Windows.Forms.ToolTip ttFechar;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.NumericUpDown numParcelas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMetodoPagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numValorPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCadastro;
        private System.Windows.Forms.ComboBox cbCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

