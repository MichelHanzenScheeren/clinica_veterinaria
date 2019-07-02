using Interface.Controle;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class ExibirAgendamento : Form
    {
        private AgendamentoServico _agendamentoServico;

        public ExibirAgendamento()
        {
            InitializeComponent();
            PesquisaInicial();
        }

        private void PesquisaInicial()
        {
            cbTipo.SelectedItem = "Consulta";
            cbStatus.SelectedItem = "Todos";
            dtPesquisa.Text = DateTime.Now.ToShortDateString();
            BuscarData();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            PaginaAgendamento paginaAgendamento = new PaginaAgendamento();
            Controles.ManterTamanho(this, paginaAgendamento);
            Hide();
            paginaAgendamento.ShowDialog();
            Controles.ManterTamanho(paginaAgendamento, this);
            CenterToScreen();
            Show();
            BuscarData();
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
           if(cbStatus.Text == "Todos")
                PreencherDataGrid(_agendamentoServico.Buscar(x => x.Tipo == cbTipo.Text));
            else
                PreencherDataGrid(_agendamentoServico.Buscar(x => x.Tipo == cbTipo.Text && x.Status == cbStatus.Text));
        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void BuscarData()
        {
            _agendamentoServico = new AgendamentoServico();
            if (cbStatus.Text == "Todos")
                PreencherDataGrid(_agendamentoServico.Buscar(x => x.DataAtendimento.Date == dtPesquisa.Value.Date && x.Tipo == cbTipo.Text));
            else
                PreencherDataGrid(_agendamentoServico.Buscar(x => x.DataAtendimento.Date == dtPesquisa.Value.Date && x.Tipo == cbTipo.Text && x.Status == cbStatus.Text));
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCriterio.Text == "" || cbPesquisa.Text == "")
                    MessageBox.Show("Um ou mais campos da pesquisa estão incompletos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    _agendamentoServico = new AgendamentoServico();
                    if(cbStatus.Text == "Todos")
                    {
                        if (cbCriterio.Text == "ID")
                            PreencherDataGrid(_agendamentoServico.Buscar(x => x.AgendamentoID == Convert.ToInt32(cbPesquisa.Text) && x.Tipo == cbTipo.Text));
                        else if (cbCriterio.Text == "Paciente")
                            PreencherDataGrid(_agendamentoServico.Buscar(x => x.Animal.Nome.Contains(cbPesquisa.Text) && x.Tipo == cbTipo.Text));
                        else
                            PreencherDataGrid(_agendamentoServico.Buscar(x => x.Animal.Cadastro.Nome.Contains(cbPesquisa.Text) && x.Tipo == cbTipo.Text));
                    }
                    else
                    {
                        if (cbCriterio.Text == "ID")
                            PreencherDataGrid(_agendamentoServico.Buscar(x => x.AgendamentoID == Convert.ToInt32(cbPesquisa.Text) && x.Tipo == cbTipo.Text &&  x.Status == cbStatus.Text));
                        else if (cbCriterio.Text == "Paciente")
                            PreencherDataGrid(_agendamentoServico.Buscar(x => x.Animal.Nome.Contains(cbPesquisa.Text) && x.Tipo == cbTipo.Text && x.Status == cbStatus.Text));
                        else
                            PreencherDataGrid(_agendamentoServico.Buscar(x => x.Animal.Cadastro.Nome.Contains(cbPesquisa.Text) && x.Tipo == cbTipo.Text && x.Status == cbStatus.Text));
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("O conteúdo inserido não é válido para a pesquisa!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PreencherDataGrid(List<Agendamento> agendamentos)
        {
            dgvRegistros.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            agendamentos = agendamentos.OrderBy(x => x.DataAtendimento).ToList();
            foreach (var item in agendamentos)
            {
                contLinha = dgvRegistros.Rows.Add();
                dgvRegistros.Rows[contLinha].Cells[0].Value = item.AgendamentoID;
                dgvRegistros.Rows[contLinha].Cells[1].Value = item.DataAtendimento.ToShortDateString() + " " + item.DataAtendimento.ToShortTimeString();
                dgvRegistros.Rows[contLinha].Cells[2].Value = item.Tipo;
                dgvRegistros.Rows[contLinha].Cells[3].Value = item.Animal.AnimalID + " - " + item.Animal.Nome + ". " + item.Animal.Raca + ", " + item.Animal.Especie;
                dgvRegistros.Rows[contLinha].Cells[4].Value = item.Animal.Cadastro.ID + " - " + item.Animal.Cadastro.Nome + ". CPF: " + item.Animal.Cadastro.Cpf;
                dgvRegistros.Rows[contLinha].Cells[5].Value = item.Status;
                numResultados++;
            }
            if(numResultados == 0)
                dgvRegistros.Rows[0].Cells[0].Value = "NENHUM REGISTRO ENCONTRADO... VERIFIQUE OS FILTROS APLICADOS OU A PESQUISA FEITA!";

            dgvRegistros.AutoResizeColumns();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = AgendamentoSelecionado();
            if (agendamento != null)
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nDADOS ASSOCIADOS TAMBÉM SERÃO APAGADOS!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _agendamentoServico = new AgendamentoServico();
                    _agendamentoServico.Excluir(agendamento);
                    dgvRegistros.Rows.Clear();
                }
            }
        }

        private Agendamento AgendamentoSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(dgvRegistros.CurrentRow.Cells[0].Value.ToString());
                _agendamentoServico = new AgendamentoServico();
                return _agendamentoServico.Buscar(x => x.AgendamentoID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cadastro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void BtnInformacoes_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = AgendamentoSelecionado();
            if(agendamento != null)
            {
                PaginaAgendamento paginaAgendamento = new PaginaAgendamento(agendamento);
                Controles.ManterTamanho(this, paginaAgendamento);
                Hide();
                paginaAgendamento.ShowDialog();
                Controles.ManterTamanho(paginaAgendamento, this);
                CenterToScreen();
                Show();
                dgvRegistros.Rows.Clear();
            }
        }

        //////////////////////////////// Botões de Controle ///////////////////////////////////////////
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            ConfirmacaoFecharPrograma fechar = new ConfirmacaoFecharPrograma();
            fechar.ShowDialog();
            if (fechar.Resultado == "OK")
                throw new FecharException();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Controles.Redimensionar(this);
            CenterToScreen();
            dgvRegistros.AutoResizeColumns();
        }
        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
