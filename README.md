# APLICATIVO VOLTADO A CLÍNICA VETERINÁRIA
Projeto produzido pelo aluno Michel Hanzen Scheeren na disciplina de Programação Orientada a Objetos no ano de 2019 - 1º Semestre do Curso de Ciência da Computação, da Universidade Tecnológica Federal do Paraná - UTFPR Medianeira e sob a orientação do professor Everton Coimbra de Araújo.

O aplicativo foi desenvolvido em C# utilizando o Visual Studio Community 2019 (v16.1.4). Para o banco de dados, foi utilizado o ORM (Mapeamento Objeto-Relacional) do Entity framework Core (v2.2.4), usando o SQL Server.

# Instalação do Visual Studio Community
* Acesse https://visualstudio.microsoft.com/pt-br/vs/community/, selecione a plataforma utilizada (Windows ou MacOS) e clique em "Baixar o visual Studio"
* Instale normalmente, conforme as instruções que seguirem

# Instalação da Aplicação
* Vá para https://github.com/MichelHanzenScheeren/ClinicaVeterinaria_ProjetoFinalPOO_2019-1;
* Clique em "Clone or download" e "Download ZIP";
* Descompacte o arquivo baixado e abra a pasta;
* O arquivo principal é o "ClinicaVeterinariaMichel.sln";

# Configuração e execução
* Com o Visual Studio Community e a aplicação baixados, Abra o arquivo "ClinicaVeterinariaMichel.sln", que está na pasta "ClinicaVeterinaria_ProjetoFinalPOO_2019-1-master"
* Basta clicar em "Iniciar" (ou F5 no teclado) para compilar e executar a aplicação.

# Conteúdo do repositório
O repositório contém as pastas:
* Interface: Projeto onde foi desenvolvida a interface gráfica do apicativo, utilizando Windows forms;
* Modelo: Contém as classes base utilizadas, desenvolvidas utilizando o padrão do Entity Framework Core (com ID's, foreign Keys e atributos de navegação);
* Persistencia: Projeto que cuida das configurações e faz a efetiva conexão da aplicação com o banco de dados (SQL Server);
* Servico: Projeto intermediário, que faz a ligação entre a interface a persistência;
* ClinicaVeterinariaMichel.sln: Solução da aplicação, usada para gerenciar os projetos.

# IMPORTANTE
* Não foram feitos testes da aplicação em um ambiente real, não havendo portando nenhuma garantia de sua estabilidade.

# Dúvidas ou Sugestões
* Michel Hanzen Scheeren - michelhanzenscheeren@gmail.com
