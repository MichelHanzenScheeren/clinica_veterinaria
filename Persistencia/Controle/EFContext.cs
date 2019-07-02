using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Cadastros;
using Modelo.Servicos;
using System;

namespace Persistencia.Controle
{
    public class EFContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Internamento> Internamentos { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }
        public DbSet<Cirurgia> Cirurgias { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Caixa> Caixa { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ClinicaVeterinariaMichel2;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atendimento>().HasOne(e => e.Animal).WithMany(x => x.Atendimentos).Metadata.DeleteBehavior = DeleteBehavior.Restrict;
            modelBuilder.Entity<Atendimento>().HasOne(e => e.Veterinario).WithMany(x => x.Atendimentos).Metadata.DeleteBehavior = DeleteBehavior.Restrict;
            modelBuilder.Entity<Receita>().HasOne(e => e.Veterinario).WithMany(x => x.Receitas).Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);

            var endeco1 = new Endereco("85890-000", "Arthur Follmann", "228", "São Francisco", "Missal", "PR")
            {
                EnderecoID = 1
            };
            modelBuilder.Entity<Endereco>().HasData(endeco1);

            var cadastro1 = new Cliente("Michel Hanzen Scheeren", "Masculino", "122.719.329-72", "michelhanzenscheeren@gmail.com", "+55(45)99969-9760", new DateTime(2000, 03, 09), 1)
            {
                ID = 1,
                DataCadastro = DateTime.Parse("2019/06/15 08:58")
            };
            modelBuilder.Entity<Cliente>().HasData(cadastro1);

            var endeco2 = new Endereco("84895-000", "Teodoro Fonseca", "1247-B", "Conceição", "Medianeira", "PR")
            {
                EnderecoID = 2
            };
            modelBuilder.Entity<Endereco>().HasData(endeco2);

            var cadastro2 = new Cliente("Lúcia Maria Rodrigues", "Feminino", "120.245.789-72", "luciarodrigues@hotmail.com", "+55(45)98876-4567", new DateTime(1988, 07, 22), 2)
            {
                ID = 2,
                DataCadastro = DateTime.Parse("2019/06/15 09:22")
            };
            modelBuilder.Entity<Cliente>().HasData(cadastro2);

            var endeco3 = new Endereco("84895-000", "Almirante Tavares Neto", "117", "Lopes Morreira", "Santa Helena", "PR")
            {
                EnderecoID = 3
            };
            modelBuilder.Entity<Endereco>().HasData(endeco3);

            var cadastro3 = new Cliente("Maria Cândida", "Feminino", "119.314.785-52", "mariacandida@hotmail.com", "+55(45)98424-6895", new DateTime(1990, 07, 17), 3)
            {
                ID = 3,
                DataCadastro = DateTime.Parse("2019/06/17 11:24")
            };
            modelBuilder.Entity<Cliente>().HasData(cadastro3);

            var endeco4 = new Endereco("85890-000", "Santo André", "458", "Da Fé", "Itaipulândia", "PR")
            {
                EnderecoID = 4
            };
            modelBuilder.Entity<Endereco>().HasData(endeco4);

            var cadastro4 = new Cliente("João Antônio", "Masculino", "121.248.997-71", "joaoantonio@gmail.com", "+55(45)99987-1524", new DateTime(2001, 12, 03), 4)
            {
                ID = 4,
                DataCadastro = DateTime.Parse("2019/06/18 16:45")
            };
            modelBuilder.Entity<Cliente>().HasData(cadastro4);


            var endeco5 = new Endereco("84579-785", "Floreira Cruz", "1475", "Ambrósio", "Foz do Iguaçu", "PR")
            {
                EnderecoID = 5
            };
            modelBuilder.Entity<Endereco>().HasData(endeco5);

            var cAdastro5 = new Veterinario("Karine Moraes", "Feminino", "120.458.789-01", "karinemoraes18@gmail.com", "+55(45)98475-1425", new DateTime(1999, 08, 14), 5)
            {
                ID = 5,
                Crmv = "7457812",
                EstadoCrmv = "PR",
                AreaAtuacao = "Animais de pequeno porte",
                Especializacao = "Morfologia Canina",
                Graduacao = "Medicina Veterinária",
                Faculdade = "Universidade Dinâmica das Cataratas - UDC Foz do Iguaçu",
                Mestrado = "Procedimentos Cirúrgicos de Risco",
                Doutorado = "Exames LAboratoriais Gerais",
                DataCadastro = DateTime.Parse("2019/06/18 17:28")
            };
            modelBuilder.Entity<Veterinario>().HasData(cAdastro5);

            var endeco6 = new Endereco("85890-000", "Floriano Peixoto", "2190", "Jardim Gramado", "Missal", "PR")
            {
                EnderecoID = 6
            };
            modelBuilder.Entity<Endereco>().HasData(endeco6);

            var cAdastro6 = new Veterinario("Robson Cruzeiro", "MAsculino", "120.742.124-70", "robsoncruzeiro@gmail.com", "+55(45)99954-1245", new DateTime(1998, 04, 17), 6)
            {
                ID = 6,
                Crmv = "852014",
                EstadoCrmv = "PR",
                AreaAtuacao = "Animais de grande porte",
                Especializacao = "Anatomia Animal",
                Graduacao = "Medicina Veterinária",
                Faculdade = "Universidade Dinâmica das Cataratas - UDC Medianeira",
                Mestrado = "Doenças exóticas",
                Doutorado = "",
                DataCadastro = DateTime.Parse("2019/06/19 08:47")
            };
            modelBuilder.Entity<Veterinario>().HasData(cAdastro6);

            var endeco7 = new Endereco("89452-000", "Independência", "1479", "Jardim Madureira", "Medianeira", "PR")
            {
                EnderecoID = 7
            };
            modelBuilder.Entity<Endereco>().HasData(endeco7);

            var cadastro7 = new Funcionario("Marcia Schuper", "Feminino", "122.548.458-58", "marciashuper@gmail.com", "+55(45)98765-4567", new DateTime(1997, 11, 17), 7)
            {
                ID = 7,
                Cargo = "Secretária",
                JornadaDeTrabalho = 40,
                Salario = 2500,
                DataCadastro = DateTime.Parse("2019/06/20 15:10")
            };
            modelBuilder.Entity<Funcionario>().HasData(cadastro7);

            var endeco8 = new Endereco("89452-000", "Independência", "156", "Jardim Madureira", "Medianeira", "PR")
            {
                EnderecoID = 8
            };
            modelBuilder.Entity<Endereco>().HasData(endeco8);

            var cadastro8 = new Funcionario("Lúcia Schuper", "Feminino", "120.178.458-75", "Não Declarado", "+55(45)98845-1542", new DateTime(1985, 12, 15), 8)
            {
                ID = 8,
                Cargo = "Faxineira",
                JornadaDeTrabalho = 25,
                Salario = 1000,
                DataCadastro = DateTime.Parse("2019/06/21 11:30")
            };
            modelBuilder.Entity<Funcionario>().HasData(cadastro8);


            var animal1 = new Animal("Bob", "Canis Lupus Familiaris", "Labrador", "Macho", 3, 95, "Marrom", "Castrado", "8547247885", new DateTime(2014, 11, 12), 1)
            {
                AnimalID = 1,
                DataCadastro = DateTime.Parse("2019/06/15 09:28")
            };
            modelBuilder.Entity<Animal>().HasData(animal1);

            var animal2 = new Animal("Nina", "Canis Lupus Familiaris", "Chihuahua", "Fêmea", 1, 35, "Branco", "Fértil", "851425522", new DateTime(2018, 11, 12), 2)
            {
                AnimalID = 2,
                DataCadastro = DateTime.Parse("2019/06/18 17:45")
            };
            modelBuilder.Entity<Animal>().HasData(animal2);

            var animal3 = new Animal("Zico", "Canis Lupus Familiaris", "Buldogue", "Macho", 2.5, 55, "Preto", "Vasectomizado", "", new DateTime(2015, 04, 22), 3)
            {
                AnimalID = 3,
                DataCadastro = DateTime.Parse("2019/06/20 11:21")
            };
            modelBuilder.Entity<Animal>().HasData(animal3);

            var animal4 = new Animal("Chico", " Felis catus", "Siamês", "Macho", 1.8, 48, "Amarelo", "Fértil", "78125255", new DateTime(2019, 01, 02), 3)
            {
                AnimalID = 4,
                DataCadastro = DateTime.Parse("2019/06/24 07:58")
            };
            modelBuilder.Entity<Animal>().HasData(animal4);


            var cirurgia1 = new Cirurgia("Traqueotomia", "Preventiva", 200) { CirurgiaID = 1 };
            modelBuilder.Entity<Cirurgia>().HasData(cirurgia1);

            var cirurgia2 = new Cirurgia("Esofagotomia", "Preventiva", 250) { CirurgiaID = 2 };
            modelBuilder.Entity<Cirurgia>().HasData(cirurgia2);

            var cirurgia3 = new Cirurgia("Esplenectomia", "Preventiva", 150) { CirurgiaID = 3 };
            modelBuilder.Entity<Cirurgia>().HasData(cirurgia3);

            var cirurgia4 = new Cirurgia("Celiotomia", "Preventiva", 350) { CirurgiaID = 4 };
            modelBuilder.Entity<Cirurgia>().HasData(cirurgia4);

            var exame1 = new Exame("Hemograma", "Amostra de Sangue", 90) { ExameID = 1 };
            modelBuilder.Entity<Exame>().HasData(exame1);

            var exame2 = new Exame("Função hepática", "Amostra de Sangue", 95) { ExameID = 2 };
            modelBuilder.Entity<Exame>().HasData(exame2);

            var exame3 = new Exame("Ultrassonografia abdominal", "Ultrassom", 110) { ExameID = 3 };
            modelBuilder.Entity<Exame>().HasData(exame3);

            var exame4 = new Exame("urina", "Amostra de Urina", 45) { ExameID = 4 };
            modelBuilder.Entity<Exame>().HasData(exame4);

            var medicamento1 = new Medicamento("Previcox", "Comprimido", "Anti-Inflamatório") { MedicamentoID = 1 };
            modelBuilder.Entity<Medicamento>().HasData(medicamento1);

            var medicamento2 = new Medicamento("Baytril Flauvor", "Comprimido", "Antibiótico") { MedicamentoID = 2 };
            modelBuilder.Entity<Medicamento>().HasData(medicamento2);

            var medicamento3 = new Medicamento("Stomorgyl", "Comprimido", "Antibiótico") { MedicamentoID = 3 };
            modelBuilder.Entity<Medicamento>().HasData(medicamento3);

            var medicamento4 = new Medicamento("Ômega-3", "Comprimido", "Suplementação") { MedicamentoID = 4 };
            modelBuilder.Entity<Medicamento>().HasData(medicamento4);

            var medicamento5 = new Medicamento("Cortishamp Shampoo", "Líquido", "Higiene") { MedicamentoID = 5 };
            modelBuilder.Entity<Medicamento>().HasData(medicamento5);

            var vacina1 = new Vacina("Antirrábica", "Dose única após os três primeiros meses de vida", 70) { VacinaID = 1 };
            modelBuilder.Entity<Vacina>().HasData(vacina1);

            var vacina2 = new Vacina("V8", "Três aplicações, com intervalos de 21 a 30 dias", 30) { VacinaID = 2 };
            modelBuilder.Entity<Vacina>().HasData(vacina2);

            var vacina3 = new Vacina("Giárdia ", "Dose única", 25) { VacinaID = 3 };
            modelBuilder.Entity<Vacina>().HasData(vacina3);


            modelBuilder.Entity<Agendamento>().HasData
            (
                new Agendamento { AgendamentoID = 1, DataAtendimento = DateTime.Parse("20/06/2019 11:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:20:54"), Tipo = "Consulta", Status = "Concluído", Resumo = "Manchas estrnhas pelos pelos. Deseja saber a necessidade de exames", AnimalID = 1 },
                new Agendamento { AgendamentoID = 2, DataAtendimento = DateTime.Parse("20/06/2019 15:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:17:16"), Tipo = "Consulta", Status = "Concluído", Resumo = "Animal apresentando diaréia e comendo pouco", AnimalID = 2},
                new Agendamento { AgendamentoID = 3, DataAtendimento = DateTime.Parse("25/06/2019 09:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:18:48"), Tipo = "Consulta", Status = "Concluído", Resumo = "Rotina. Precaução", AnimalID = 3},
                new Agendamento { AgendamentoID = 4, DataAtendimento = DateTime.Parse("02/07/2019 15:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:20:54"), Tipo = "Consulta", Status = "Pendente", Resumo = "Respiração ofegante, caminhando com dificuldade.", AnimalID = 4},
                new Agendamento { AgendamentoID = 5, DataAtendimento = DateTime.Parse("26/06/2019 11:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:22:54"), Tipo = "Consulta", Status = "Concluído", Resumo = "Solicitados em consulta anterior", AnimalID = 1},
                new Agendamento { AgendamentoID = 6, DataAtendimento = DateTime.Parse("03/07/2019 14:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:25:06"), Tipo = "Exame", Status = "Pendente", Resumo = "Exames de Urgência", AnimalID = 3},
                new Agendamento { AgendamentoID = 7, DataAtendimento = DateTime.Parse("03/07/2019 10:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:27:35"), Tipo = "Exame", Status = "Pendente", Resumo = "Atrasadas", AnimalID = 3},
                new Agendamento { AgendamentoID = 8, DataAtendimento = DateTime.Parse("08/07/2019 10:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:28:32"), Tipo = "Vacina", Status = "Concluído", Resumo = "2ª Dose", AnimalID = 4},
                new Agendamento { AgendamentoID = 9, DataAtendimento = DateTime.Parse("28/06/2019 08:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:29:16"), Tipo = "Vacina", Status = "Pendente", Resumo = "1ª Dose", AnimalID = 1},
                new Agendamento { AgendamentoID = 10, DataAtendimento = DateTime.Parse("27/06/2019 10:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:30:23"), Tipo = "Cirurgia", Status = "Concluído", Resumo = "Cirurgia Preventiva", AnimalID = 4},
                new Agendamento { AgendamentoID = 11, DataAtendimento = DateTime.Parse("03/07/2019 10:00:00"), DataAgendamento = DateTime.Parse("28/06/2019 15:30:55"), Tipo = "Cirurgia", Status = "Pendente", Resumo = "Encaminhada em consulta anterior", AnimalID = 4}
            );

            modelBuilder.Entity<Conta>().HasData
            (
                new Conta { ContaID = 1, Tipo = "Entrada", Categoria = "Consulta", Data_Inicio = DateTime.Parse("21/06/2019 19:55:55"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 150, ValorPago = 150, Parcelas = 1, MetodoPagamento = "À Vista - Dinheiro", CadastroID = 1 },
                new Conta { ContaID = 2, Tipo = "Entrada", Categoria = "Consulta", Data_Inicio = DateTime.Parse("22/06/2019 19:58:43"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 250, ValorPago = 250, Parcelas = 4, MetodoPagamento = "A Prazo - Dinheiro", CadastroID = 3 },
                new Conta { ContaID = 3, Tipo = "Entrada", Categoria = "Consulta", Data_Inicio = DateTime.Parse("22/06/2019 20:02:16"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 180.5, ValorPago = 180.5, Parcelas = 1, MetodoPagamento = "À Vista - Dinheiro", CadastroID = 3 },
                new Conta { ContaID = 4, Tipo = "Entrada", Categoria = "Exame", Data_Inicio = DateTime.Parse("24/06/2019 20:03:53"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 90, ValorPago = 45, Parcelas = 3, MetodoPagamento = "A Prazo - Cartão", CadastroID = 2 },
                new Conta { ContaID = 5, Tipo = "Entrada", Categoria = "Exame", Data_Inicio = DateTime.Parse("24/06/2019 20:05:00"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 110, ValorPago = 110, Parcelas = 1, MetodoPagamento = "À Vista - Cartão", CadastroID = 3 },
                new Conta { ContaID = 6, Tipo = "Entrada", Categoria = "Exame", Data_Inicio = DateTime.Parse("24/06/2019 20:06:00"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 45, ValorPago = 0, Parcelas = 1, MetodoPagamento = "À Vista - Dinheiro", CadastroID = 3 },
                new Conta { ContaID = 7, Tipo = "Entrada", Categoria = "Vacina", Data_Inicio = DateTime.Parse("27/06/2019 20:06:54"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 70, ValorPago = 40, Parcelas = 1, MetodoPagamento = "À Vista - Cartão", CadastroID = 1 },
                new Conta { ContaID = 8, Tipo = "Entrada", Categoria = "Vacina", Data_Inicio = DateTime.Parse("28/06/2019 20:08:10"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 25, ValorPago = 25, Parcelas = 1, MetodoPagamento = "À Vista - Dinheiro", CadastroID = 3 },
                new Conta { ContaID = 9, Tipo = "Entrada", Categoria = "Vacina", Data_Inicio = DateTime.Parse("28/06/2019 20:08:45"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 30, ValorPago = 30, Parcelas = 4, MetodoPagamento = "A Prazo - Dinheiro", CadastroID = 3 },
                new Conta { ContaID = 10, Tipo = "Entrada", Categoria = "Cirurgia", Data_Inicio = DateTime.Parse("28/06/2019 20:10:06"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 200, ValorPago = 200, Parcelas = 1, MetodoPagamento = "À Vista - Dinheiro", CadastroID = 3 },
                new Conta { ContaID = 11, Tipo = "Entrada", Categoria = "Cirurgia", Data_Inicio = DateTime.Parse("29/06/2019 20:11:55"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 350, ValorPago = 200, Parcelas = 1, MetodoPagamento = "À Vista - Dinheiro", CadastroID = 2 },
                new Conta { ContaID = 12, Tipo = "Entrada", Categoria = "Cirurgia", Data_Inicio = DateTime.Parse("29/06/2019 20:12:50"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 350, ValorPago = 350, Parcelas = 4, MetodoPagamento = "A Prazo - Dinheiro", CadastroID = 1 },
                new Conta { ContaID = 13, Tipo = "Entrada", Categoria = "Internamento", Data_Inicio = DateTime.Parse("30/06/2019 20:19:45"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 850, ValorPago = 650, Parcelas = 1, MetodoPagamento = "À Vista - Dinheiro", CadastroID = 3},
                new Conta { ContaID = 14, Tipo = "Entrada", Categoria = "Internamento", Data_Inicio = DateTime.Parse("30/06/2019 20:21:32"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 700.5, ValorPago = 550, Parcelas = 3, MetodoPagamento = "A Prazo - Cartão", CadastroID = 3},
                new Conta { ContaID = 15, Tipo = "Saída", Categoria = "Salário", Data_Inicio = DateTime.Parse("02/06/2019 23:17:04"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 450, ValorPago = 450, Parcelas = 1, MetodoPagamento = "À Vista - Dinheiro", CadastroID = 7 },
                new Conta { ContaID = 16, Tipo = "Saída", Categoria = "Salário", Data_Inicio = DateTime.Parse("02/06/2019 23:18:01"), Data_Vencimento = DateTime.Parse("28/07/2019 00:00:00"), Total = 500, ValorPago = 500, Parcelas = 1, MetodoPagamento = "À Vista - Cartão", CadastroID = 8 }
            );

            modelBuilder.Entity<Atendimento>().HasData
            (
                new Atendimento { AtendimentoID = 1, Data = DateTime.Parse("28/06/2019 19:54:00"), Tipo = "Consulta", Resumo = "Vistoria preliminar normal", ClassificacaoAtendimento = "Rotina", Conclusoes = "Em perfeito estado, sem nenhuma alteração visível. Não há necessidade de retorno prévio", VeterinarioID = 5, AnimalID = 1, ContaID = 1 },
                new Atendimento { AtendimentoID = 2, Data = DateTime.Parse("26/06/2019 16:48:00"), Tipo = "Consulta", Resumo = "Apetite do paciente está alterado, pupilas bem dilatadas. Examinação prévia indicou agressividade, incomum no animal.", ClassificacaoAtendimento = "Geral", Conclusoes = "Exames devem ser encaminhados. Medicamento para o estômago serão receitados.", VeterinarioID = 5, AnimalID = 3, ContaID = 2 },
                new Atendimento { AtendimentoID = 3, Data = DateTime.Parse("30/06/2019 13:00:00"), Tipo = "Consulta", Resumo = "Patinha deslocada. Animal está com muita dor", ClassificacaoAtendimento = "Avaliação Cirúrgica", Conclusoes = "A cirurgia deve acontecer logo. Solicitarei um raio X.", VeterinarioID = 6, AnimalID = 4, ContaID = 3 },
                new Atendimento { AtendimentoID = 4, Data = DateTime.Parse("28/06/2019 17:03:00"), Tipo = "Exame", Resumo = "Exame de rotina", ClassificacaoAtendimento = "1 - Hemograma, Amostra de Sangue.  R$ 90", Conclusoes = "Nenhuma alteração detectada", VeterinarioID = 5, AnimalID = 2, ContaID = 4 },
                new Atendimento { AtendimentoID = 5, Data = DateTime.Parse("09/07/2019 17:03:00"), Tipo = "Exame", Resumo = "Verificação de possíveis problemas no estômago", ClassificacaoAtendimento = "3 - Ultrassonografia abdominal, Ultrassom.  R$ 110", Conclusoes = "Nada anormal detectado", VeterinarioID = 6, AnimalID = 3, ContaID = 5 },
                new Atendimento { AtendimentoID = 6, Data = DateTime.Parse("03/07/2019 20:05:00"), Tipo = "Exame", Resumo = "Exames anuais recomendados", ClassificacaoAtendimento = "4 - urina, Amostra de Urina.  R$ 45", Conclusoes = "acidez elevada.", VeterinarioID = 6, AnimalID = 4, ContaID = 6 },
                new Atendimento { AtendimentoID = 7, Data = DateTime.Parse("01/07/2019 15:10:00"), Tipo = "Vacina", Resumo = "1ª Dose", ClassificacaoAtendimento = "1 - Antirrábica. Dose única após os três primeiros meses de vida.  R$ 70", Conclusoes = "Procedimento sem complicações. Retorno em 1 mês para 2ª dose", VeterinarioID = 5, AnimalID = 1, ContaID = 7 },
                new Atendimento { AtendimentoID = 8, Data = DateTime.Parse("28/06/2019 20:07:00"), Tipo = "Vacina", Resumo = "2ª Dose", ClassificacaoAtendimento = "3 - Giárdia . Dose única.  R$ 25", Conclusoes = "retorno em 1 ano para nova dose", VeterinarioID = 6, AnimalID = 3, ContaID = 8 },
                new Atendimento { AtendimentoID = 9, Data = DateTime.Parse("26/06/2019 09:10:00"), Tipo = "Vacina", Resumo = "3ª dose do animal", ClassificacaoAtendimento = "2 - V8. Três aplicações, com intervalos de 21 a 30 dias.  R$ 30", Conclusoes = "última aplicação. ", VeterinarioID = 6, AnimalID = 3, ContaID = 9 },
                new Atendimento { AtendimentoID = 10, Data = DateTime.Parse("11/07/2019 15:08:00"), Tipo = "Cirurgia", Resumo = "Cirurgia preventiva.Pré operatório sem complicações", ClassificacaoAtendimento = "1 - Traqueotomia. Preventiva .  R$ 200", Conclusoes = "alteração incomum dos batimentos cardiacos durante a anestesia, mas tudo ocorreu bem", VeterinarioID = 5, AnimalID = 3, ContaID = 10 },
                new Atendimento { AtendimentoID = 11, Data = DateTime.Parse("26/06/2019 15:11:00"), Tipo = "Cirurgia", Resumo = "Pré operatório normal", ClassificacaoAtendimento = "4 - Celiotomia. Preventiva .  R$ 350", Conclusoes = "Procedimento sem complicações. Permanecerá internado por 3 dias", VeterinarioID = 5, AnimalID = 2, ContaID = 11 },
                new Atendimento { AtendimentoID = 12, Data = DateTime.Parse("04/07/2019 19:12:00"), Tipo = "Cirurgia", Resumo = "Pacinte de risco", ClassificacaoAtendimento = "4 - Celiotomia. Preventiva .  R$ 350", Conclusoes = "Procedimento ococrreu bem", VeterinarioID = 6, AnimalID = 1, ContaID = 12 }
            );

            modelBuilder.Entity<Internamento>().HasData
            (
                new Internamento { InternamentoID = 1, DataEntrada = DateTime.Parse("27/06/2019 17:16:57"), DataSaida = null, Resumo = "Desmaios frequentes", Conclusoes = "", NumeroQuarto = 2, AnimalID = 2, ContaID = null },
                new Internamento { InternamentoID = 2, DataEntrada = DateTime.Parse("29/06/2019 22:18:00"), DataSaida = null, Resumo = "Enjôo forte", Conclusoes = "", NumeroQuarto = 1, AnimalID = 1, ContaID = null },
                new Internamento { InternamentoID = 3, DataEntrada = DateTime.Parse("24/06/2019 15:22:00"), DataSaida = DateTime.Parse("29/06/2019 20:18:00"), Resumo = "Hospitalizado para realização de cirurgia", Conclusoes = "Paciente já está bem, andando e brincando", NumeroQuarto = 4, AnimalID = 4, ContaID = 13 },
                new Internamento { InternamentoID = 4, DataEntrada = DateTime.Parse("21/06/2019 22:20:00"), DataSaida = DateTime.Parse("28/06/2019 19:21:00"), Resumo = "Pré operatório", Conclusoes = "Tudo ocorreu bem", NumeroQuarto = 6, AnimalID = 3, ContaID = 14 }
            );

            modelBuilder.Entity<Receita>().HasData
            (
                new Receita { ReceitaID = 1, Dose = "1 comprimido", IntervaloDose = 4, TempoTratamento = 6, Data = DateTime.Parse("21/06/2019 20:14:12"), MedicamentoID = 2, AnimalID = 1, VeterinarioID = 5 },
                new Receita { ReceitaID = 2, Dose = "2 aplicações ao dia", IntervaloDose = 12, TempoTratamento = 30, Data = DateTime.Parse("23/06/2019 20:14:54"), MedicamentoID = 5, AnimalID = 2, VeterinarioID = 6 },
                new Receita { ReceitaID = 3, Dose = "Meio comprimido", IntervaloDose = 6, TempoTratamento = 5, Data = DateTime.Parse("24/06/2019 20:15:18"), MedicamentoID = 1, AnimalID = 3, VeterinarioID = 6 },
                new Receita { ReceitaID = 4, Dose = "1 comprimido", IntervaloDose = 8, TempoTratamento = 2, Data = DateTime.Parse("28/06/2019 20:15:54"), MedicamentoID = 3, AnimalID = 4, VeterinarioID = 5 }
            );

            modelBuilder.Entity<Caixa>().HasData
            (
                new Caixa { CaixaID = 1, Data = DateTime.Parse("21/06/2019 21:51:34"), Tipo = "Entrada", Categoria = "Consulta", Valor = 150, Saldo = 150, ContaID = 1},
                new Caixa { CaixaID = 2, Data = DateTime.Parse("22/06/2019 21:52:26"), Tipo = "Entrada", Categoria = "Consulta", Valor = 100, Saldo = 250, ContaID = 2},
                new Caixa { CaixaID = 3, Data = DateTime.Parse("22/06/2019 21:52:44"), Tipo = "Entrada", Categoria = "Consulta", Valor = 180.5, Saldo = 430.5, ContaID = 3},
                new Caixa { CaixaID = 4, Data = DateTime.Parse("24/06/2019 21:57:16"), Tipo = "Entrada", Categoria = "Exame", Valor = 45, Saldo = 475.5, ContaID = 4},
                new Caixa { CaixaID = 5, Data = DateTime.Parse("24/06/2019 21:57:28"), Tipo = "Entrada", Categoria = "Consulta", Valor = 150, Saldo = 625.5, ContaID = 2},
                new Caixa { CaixaID = 6, Data = DateTime.Parse("27/06/2019 21:57:43"), Tipo = "Entrada", Categoria = "Exame", Valor = 110, Saldo = 735.5, ContaID = 5},
                new Caixa { CaixaID = 7, Data = DateTime.Parse("28/06/2019 21:57:54"), Tipo = "Entrada", Categoria = "Vacina", Valor = 30, Saldo = 765.5, ContaID = 9},
                new Caixa { CaixaID = 8, Data = DateTime.Parse("28/06/2019 21:58:03"), Tipo = "Entrada", Categoria = "Vacina", Valor = 25, Saldo = 790.5, ContaID = 8},
                new Caixa { CaixaID = 9, Data = DateTime.Parse("28/06/2019 21:58:19"), Tipo = "Entrada", Categoria = "Vacina", Valor = 40, Saldo = 830.5, ContaID = 7},
                new Caixa { CaixaID = 10, Data = DateTime.Parse("29/06/2019 21:58:27"), Tipo = "Entrada", Categoria = "Cirurgia", Valor = 200, Saldo = 1030.5, ContaID = 10},
                new Caixa { CaixaID = 11, Data = DateTime.Parse("29/06/2019 21:58:27"), Tipo = "Entrada", Categoria = "Cirurgia", Valor = 350, Saldo = 1380.5, ContaID = 12},
                new Caixa { CaixaID = 12, Data = DateTime.Parse("29/06/2019 21:58:27"), Tipo = "Entrada", Categoria = "Internamento", Valor = 450, Saldo = 1830.5, ContaID = 13},
                new Caixa { CaixaID = 13, Data = DateTime.Parse("30/06/2019 21:58:52"), Tipo = "Entrada", Categoria = "Internamento", Valor = 350, Saldo = 2180.5, ContaID = 14},
                new Caixa { CaixaID = 14, Data = DateTime.Parse("30/06/2019 21:58:52"), Tipo = "Entrada", Categoria = "Internamento", Valor = 200, Saldo = 2380.5, ContaID = 14},
                new Caixa { CaixaID = 15, Data = DateTime.Parse("01/07/2019 21:59:32"), Tipo = "Entrada", Categoria = "Internamento", Valor = 200, Saldo = 2580.5, ContaID = 13},
                new Caixa { CaixaID = 16, Data = DateTime.Parse("02/07/2019 21:59:32"), Tipo = "Entrada", Categoria = "Cirurgia", Valor = 200, Saldo = 2780.5, ContaID = 11},
                new Caixa { CaixaID = 17, Data = DateTime.Parse("02/07/2019 23:17:04"), Tipo = "Saída", Categoria = "Salário", Valor = 450, Saldo = 2330.5, ContaID = 15 },
                new Caixa { CaixaID = 18, Data = DateTime.Parse("02/07/2019 23:18:01"), Tipo = "Saída", Categoria = "Salário", Valor = 500, Saldo = 1830.5, ContaID = 16 }
            );
            
        }
    }
    
}
