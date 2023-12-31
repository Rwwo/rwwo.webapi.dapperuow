# .NET Core API com Dapper, Repository e UnitOfWork

Essa aplica��o se concentra na cria��o de uma API da web usando Dapper, padr�o de reposit�rio e padr�o Unit of Work no .NET 6 para retornar uma lista de marcas.


## Tecnologias Utilizadas:
* Dapper
* PostgreSQL
* Visual Studio 2022

O **Dapper** � um micro-ORM (Object-Relational Mapper) para o .NET que simplifica a intera��o entre aplicativos e bancos de dados relacionais. 
Ele oferece uma maneira eficiente e de baixo impacto para mapear objetos de dom�nio para instru��es SQL e vice-versa.
O Dapper n�o introduz complexidades excessivas e mant�m um desempenho r�pido, sendo uma escolha popular para projetos que requerem controle direto 
sobre as consultas SQL enquanto proporcionam uma camada de abstra��o m�nima. Ele � especialmente �til em cen�rios onde a simplicidade e o desempenho
s�o fundamentais, como em projetos que utilizam o padr�o Repository.

O **Npgsql** � um provedor de acesso a dados para PostgreSQL em ambientes .NET. Ele funciona como uma implementa��o do ADO.NET 
(Active Data Objects .NET), permitindo que aplicativos .NET se conectem e interajam com bancos de dados PostgreSQL. 
O Npgsql oferece suporte a uma variedade de recursos do PostgreSQL, incluindo tipos de dados espec�ficos, fun��es armazenadas,
transa��es e consultas parametrizadas.



> [!NOTE]
> Esse projeto foi desenvolvido apenas para fins de aprendizado