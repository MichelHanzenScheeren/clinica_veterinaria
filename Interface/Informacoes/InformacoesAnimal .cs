using Interface.Controle;
using Modelo;
using Modelo.Excessoes;
using Servico.Geral;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class InformacoesAnimal : Form
    {
        private Animal _animal;
        private AnimalServico _animalServico;
        private AgendamentoServico _agendamentoServico;
        private InternamentoServico _internamentoServico;
        public InformacoesAnimal(Animal animal)
        {
            _animal = animal;
            InitializeComponent();
        }

        public void AtualizarInformacoes()
        {
            lblID.Text = "ANIMAL Nº " +   Convert.ToString(_animal.AnimalID);
            lblNome.Text = "NOME: " + _animal.Nome;
            lblSexo.Text = "SEXO: " + _animal.Sexo;
            lblNascimento.Text = "DATA DE NASCIMENTO: " + _animal.DataNascimento.ToShortDateString();
            lblRaca.Text = "RAÇA: " + _animal.Raca;
            lblEspecie.Text = "ESPÉCIE: " + _animal.Especie;
            lblCor.Text = "COR PREDOMINANTE: " + _animal.Cor;
            lblCadastro.Text = "DATA DO CADASTRO: " + _animal.DataCadastro.ToShortDateString();
            lblTamanho.Text = "TAMANHO: " + _animal.Tamanho + " cm";
            lblPeso.Text = "PESO: " + _animal.Peso + " kg";
            lblEsterilizacao.Text = "ESTERILIZAÇÃO: " + _animal.Esterilizacao;
            lblPedigree.Text = "Nº PEDIGREE: " + _animal.Pedigree;
            lblProprietario.Text = "PROPRIETÁRIO: " + _animal.Cadastro.ToString();
        }

        ////////////////////////////////////// NOVO AGENDAMENTO /////////////////////////////////////////////

        private void BtnNovoAgendamento_Click(object sender, EventArgs e)
        {
            PaginaAgendamento paginaAgendamento = new PaginaAgendamento(_animal.AnimalID);
            Controles.ManterTamanho(this, paginaAgendamento);
            Hide();
            paginaAgendamento.ShowDialog();
            Controles.ManterTamanho(paginaAgendamento, this);
            CenterToScreen();
            Show();
        }

        ////////////////////////////////////// EDITAR ANIMAL /////////////////////////////////////////////
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            PaginaAnimal paginaAnimal = new PaginaAnimal(_animal);
            _animalServico = new AnimalServico();
            Controles.ManterTamanho(this, paginaAnimal);
            Hide();
            paginaAnimal.ShowDialog();
            Controles.ManterTamanho(paginaAnimal, this);
            CenterToScreen();
            Show();
            _animal = _animalServico.Buscar(x => x.AnimalID == _animal.AnimalID, "Cadastro").FirstOrDefault();
            AtualizarInformacoes();
        }

        ////////////////////////////////////// APAGAR CADASTRO /////////////////////////////////////////////
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                _internamentoServico = new InternamentoServico();
                if(_internamentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.DataSaida == null).Count != 0)
                    throw new AcaoProibidaException("NÃO É POSSÍVEL EXCLUIR O REGISTRO DE UM ANIMAL  QUE ESTÁ INTERNADO!");
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nINFORMAÇÔES REFERENTES A CONSULTAS, EXAMES, RECEITAS E OUTROS TAMBÉM SERÃO APAGADOS!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    AtendimentoServico atendimentoServico = new AtendimentoServico();
                    foreach (var item in atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID))
                    {
                        atendimentoServico.Excluir(item);
                    }
                    InternamentoServico internamentoServico = new InternamentoServico();
                    foreach (var item in internamentoServico.Buscar(x => x.AnimalID == _animal.AnimalID))
                    {
                        internamentoServico.Excluir(item);
                    }
                    ReceitaServico receitaServico = new ReceitaServico();
                    foreach (var item in receitaServico.Buscar(x => x.AnimalID == _animal.AnimalID))
                    {
                        receitaServico.Excluir(item);
                    }
                    AgendamentoServico agendamentoServico = new AgendamentoServico();
                    foreach (var item in agendamentoServico.Buscar(x => x.AnimalID == _animal.AnimalID))
                    {
                        agendamentoServico.Excluir(item);
                    }

                    _animalServico = new AnimalServico();
                    _animalServico.Excluir(_animal);
                    MessageBox.Show("REGISTRO APAGADO!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Close();
                }
            }
            catch (AcaoProibidaException erro)
            {
                MessageBox.Show($"ATENÇÃO!\n\n{erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BrnInternamento_Click(object sender, EventArgs e)
        {
            PaginaInternamento paginaInternamento = new PaginaInternamento(_animal.AnimalID);
            Controles.ManterTamanho(this, paginaInternamento);
            Hide();
            paginaInternamento.ShowDialog();
            Controles.ManterTamanho(paginaInternamento, this);
            CenterToScreen();
            Show();
        }

        private void BtnReceita_Click(object sender, EventArgs e)
        {
            PaginaReceita paginaReceita = new PaginaReceita(_animal.AnimalID);
            Controles.ManterTamanho(this, paginaReceita);
            Hide();
            paginaReceita.ShowDialog();
            Controles.ManterTamanho(paginaReceita, this);
            CenterToScreen();
            Show();
        }

        private void BtnAtendimento_Click(object sender, EventArgs e)
        {
            PaginaAtendimentos paginaAtendimentos = new PaginaAtendimentos(_animal.AnimalID);
            Controles.ManterTamanho(this, paginaAtendimentos);
            Hide();
            paginaAtendimentos.ShowDialog();
            Controles.ManterTamanho(paginaAtendimentos, this);
            CenterToScreen();
            Show();
        }

        private void BtnProntuario_Click(object sender, EventArgs e)
        {
            ExibirProntuario exibirProntuario = new ExibirProntuario(_animal);
            Controles.ManterTamanho(this, exibirProntuario);
            Hide();
            exibirProntuario.ShowDialog();
            Controles.ManterTamanho(exibirProntuario, this);
            CenterToScreen();
            Show();
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
            AjustarInformacoes();
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void AjustarInformacoes()
        {
            PnlInformacoes.Left = (pnlTras.Width - PnlInformacoes.Width) / 2;
            PnlInformacoes.Top = (pnlTras.Height - PnlInformacoes.Height) / 2;
        }

        private void InformacoesAnimal_Resize(object sender, EventArgs e)
        {
            AjustarInformacoes();
        }
    }
}
