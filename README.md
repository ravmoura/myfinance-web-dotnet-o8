# myfinance-web-dotnet-o8
Sistema de finanças pessoais em ASP NET Core

Descrição do Projeto:
O MYFINANCE WEB é uma aplicação web para registro de receitas e despesas com o objetivo de melhorar o planejamento financeiro. Esta aplicação permite que o usuário monte uma espécie de Plano de Contas para categorizar todas as Transações realizadas.

Arquitetura utilizada:
O projeto foi desenvolvido em ASP.NET Core versão 9.0.6 com páginas Razor implementando os conceitos do Domain Driven Design.

Tecnologias:
As principais tecnologias utilizadas foram C#, JavaScript, HTML e CSS com baco de dados SQL Server 2022.

Como configurar para startup do projeto:
1 - Baixar a pasta do projeto no GitHub -> https://github.com/ravmoura/myfinance-web-dotnet-o8
2 - Localizar o script de criação do banco de dados na pasta ..\myfinance-web-dotnet-o8\docs e executá-lo no SQL Server 2022.
3 - Abrir a pasta do projeto no Visual Studio Code
3 - Caso necessário, realizar ajustes na string de conexão com banco de dados no arquivo
..\src\myfinance-web-dotnet-o8\Infraestructure\MyFinanceDbContext.cs
4 - Executar a solução executando o comando **dotnet run**