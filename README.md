<h1 align="center"> New Devs C&A </h1>

<h2> Descrição do projeto </h2>
Aplicativo API para gerenciamento de uma tabela de produtos, salvando os dados em um banco de dados MySql.

Oferece recursos POST - PUT - GET - DELETE

<img src="https://github.com/davids182/ProjetoC-A_photos/blob/f3fd89f76f05d20f9ca6077d99ba17ccfa7fc71b/Fluxograma_do_Sistema_v2.png" alt="Diagrama de descrição do projeto">

<h2> Como usar </h2>

<p>
  Com o projeto do repositório aberto no Visual Studio 2019, vá até o arquivo 'appsettings.json' na linha 04 em "DefaultConnection" e insira/altere o password que corresponde ao seu usuário root do MySQL, essa alteração fará com que a API consiga se conectar com o seu MySQL.
  Após essa etapa é necessário atualizar o database para a aplicação realizar a ORM e definição dos models no banco de dados. <br>Acesse a opção no seu Visual Studio. Ferramentas  -> Gerenciador de Pacotes do Nuget -> Console do Gerenciador  de Pacotes, execute o seguinte comando: update-database.<br>
  <br>
  O resultado deverá ser a mensagem abaixo:<br>
  PM> update-database<br>
  Build started...<br>
  Build succeeded.<br>
  Done.<br>
 
 Pronto, agora execute a aplicação, e com isso a API estará conectada ao banco de dados e rodando.  
</p>

<h2> Tecnologias utilizadas para criar </h2>
<div align="start">
  <p> ▪️ C# (ASP.NET Core, EntityFramework, Pomelo) </p>
  <p> ▪️ MySQL </p>
</div>
