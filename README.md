# .NET Core API com Dapper, Repository e UnitOfWork

Essa aplicação se concentra na criação de uma API da web usando Dapper, padrão de repositório e padrão Unit of Work no .NET 6 para retornar uma lista de marcas.


## Tecnologias Utilizadas:
* Dapper
* PostgreSQL
* Visual Studio 2022

O **Dapper** é um micro-ORM (Object-Relational Mapper) para o .NET que simplifica a interação entre aplicativos e bancos de dados relacionais. 
Ele oferece uma maneira eficiente e de baixo impacto para mapear objetos de domínio para instruções SQL e vice-versa.
O Dapper não introduz complexidades excessivas e mantém um desempenho rápido, sendo uma escolha popular para projetos que requerem controle direto 
sobre as consultas SQL enquanto proporcionam uma camada de abstração mínima. Ele é especialmente útil em cenários onde a simplicidade e o desempenho
são fundamentais, como em projetos que utilizam o padrão Repository.

O **Npgsql** é um provedor de acesso a dados para PostgreSQL em ambientes .NET. Ele funciona como uma implementação do ADO.NET 
(Active Data Objects .NET), permitindo que aplicativos .NET se conectem e interajam com bancos de dados PostgreSQL. 
O Npgsql oferece suporte a uma variedade de recursos do PostgreSQL, incluindo tipos de dados específicos, funções armazenadas,
transações e consultas parametrizadas.



> [!NOTE]
> Esse projeto foi desenvolvido apenas para fins de aprendizado