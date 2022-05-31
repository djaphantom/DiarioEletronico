USE master
GO

IF EXISTS(SELECT 1 FROM SYS.databases WHERE name = 'BancoDiarioEletronico')
	DROP DATABASE BancoDiarioEletronico
GO

CREATE DATABASE BancoDiarioEletronico
GO

USE BancoDiarioEletronico
GO

/*-----------------------------------------------------------------------------------------------*/--
CREATE TABLE Aluno 
(
	Id int PRIMARY KEY IDENTITY (1,1)NOT NULL,
	NomeAluno varchar(100) NULL,
	DataDeNascimento varchar(50)NULL,
	TelefoneResponsavel varchar(50) NULL,
	cpf varchar(100)null,
	Email varchar(100) NULL,
	NomeDoResponsavel varchar(100)NULL,
	sexo varchar(50)NULL,
	CidadeAluno varchar(100) NULL,
	UF varchar(50)null,
	EnderecoAluno varchar(100) NULL,
	setor varchar(100)NULL,
	numero INT NULL,
	cep varchar(50),
	senha varchar(50)not null
 )
GO

/*-----------------------------------------------------------------------------------------------*/--
CREATE TABLE Diario(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Disciplina int NULL,
	Id_Professor int NULL,
	Id_Aluno int NULL,
	Id_Ocorrencia int NULL,
	Id_Frequencia int NULL,
	Id_Plano_de_Aula int NULL,
	Id_Turma int NULL,
	Id_Nota int NULL,
)
GO

/*-----------------------------------------------------------------------------------------------*/--

CREATE TABLE Disciplina(
	Id int PRIMARY KEY IDENTITY (1,1)  NOT NULL,
	NomeDisciplina varchar(50) NOT NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/--
CREATE TABLE Frequencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Apontamento [bit] NULL,
	Data datetime NULL,
)
GO

/*-----------------------------------------------------------------------------------------------*/--
CREATE TABLE Nota(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Turma int NULL,
	notaAluno FLOAT NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/--
CREATE TABLE Ocorrencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Descricao varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/--
CREATE TABLE PlanoDeAula(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_professor int NULL,
	Conteudo varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/
CREATE TABLE Professor(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	NomeProfessor varchar(100) NULL,
	CPF_Professor varchar(100) NULL,
	Email varchar(100) NULL,
	Telefone varchar(50) NULL,
	DataDeNascimento varchar(50)NULL,
	sexo varchar(50)NULL,
	CidadeProfessor varchar(100) NULL,
	UF varchar(50)null,
	EnderecoProfessor varchar(100) NULL,
	setor varchar(100)NULL,
	cep varchar(50)null,
	senha varchar(50)not null
)
GO
/*-----------------------------------------------------------------------------------------------*/
CREATE TABLE Turma(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NOT NULL,
	Periodo varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/
CREATE TABLE AgentePedagogico(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	senha varchar(50)not null,
	NomeAgente varchar(150) NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/
/*create table aluno_turma
(
id_aluno int,
id_turma int,
)*/
/*-----------------------------------------------------------------------------------------------*/
select*from Aluno
select*from Diario
select*from Disciplina
select*from Frequencia
select*from Nota
select*from Ocorrencia
select*from PlanoDeAula
select*from Professor
select*from Turma
select*from AgentePedagogico
go
/*-----------------------------------------------------------------------------------------------*/
					/*area de altera as tablelas se for preciso*/
/*Alter table AgentePedagogico
add NomeAgente varchar(150)

Alter table AgentePedagogico
drop column NomeUsuario*/

/*-----------------------------------------------------------------------------------------------*/
CREATE PROCEDURE SP_InserirAluno
	@Id int OUTPUT,
	@NomeAluno varchar(100) ,
	@DataDeNascimento varchar(50),
	@TelefoneResponsavel varchar(50) ,
	@cpf varchar(100),
	@Email varchar(100) ,
	@NomeDoResponsavel varchar(100),
	@sexo varchar(50),
	@CidadeAluno varchar(100) ,
	@UF varchar(50),
	@EnderecoAluno varchar(100) ,
	@setor varchar(100),
	@numero INT ,
	@cep varchar(50),
	@senha varchar(50)
AS
	INSERT INTO Aluno( NomeAluno, DataDeNascimento,TelefoneResponsavel,cpf,Email,NomeDoResponsavel,sexo,CidadeAluno,UF,EnderecoAluno,setor,numero,cep,senha)
	Values(@NomeAluno,@DataDeNascimento,@TelefoneResponsavel,@cpf,@Email,@NomeDoResponsavel,@sexo,@CidadeAluno,@UF,@EnderecoAluno,@setor,@numero,@cep,@senha)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*EXEC SP_InserirAluno 0,'Alencar','21/03/2003','(63) 99104-6919','066.854.411-27','bruno@gmail.com','sidiclea','M','Araguaina','TO','rua curitibano','Palmas',105,'77808-642','Bruno2003'
go*/
/*-----------------------------------------------------------------------------------------------*/
CREATE PROCEDURE SP_BuscarAluno
	@filtro varchar(250) = ''
as
	select Id,NomeAluno, DataDeNascimento,TelefoneResponsavel,cpf,Email,NomeDoResponsavel,sexo,CidadeAluno,UF,EnderecoAluno,setor,numero,cep,senha from Aluno WHERE NomeAluno LIKE  @filtro + '%' or Id LIKE  @filtro + '' or cpf LIKE ''+ @filtro + ''
	GO

/*	EXEC SP_BuscarAluno '066.854.411-27'
go*/
/*-----------------------------------------------------------------------------------------------*/
CREATE PROCEDURE SP_AlterarAluno
	@Id int OUTPUT,
	@NomeAluno varchar(100) ,
	@DataDeNascimento varchar(50),
	@TelefoneResponsavel varchar(50) ,
	@cpf varchar(100),
	@Email varchar(100) ,
	@NomeDoResponsavel varchar(100),
	@sexo varchar(50),
	@CidadeAluno varchar(100) ,
	@UF varchar(50),
	@EnderecoAluno varchar(100) ,
	@setor varchar(100),
	@numero INT ,
	@cep varchar(50),
	@senha varchar(50)
	AS
	UPDATE Aluno SET
	NomeAluno = @NomeAluno  ,
	DataDeNascimento = @DataDeNascimento,
	TelefoneResponsavel =  @TelefoneResponsavel  ,
	cpf = @cpf ,
	Email = @Email  ,
	NomeDoResponsavel = @NomeDoResponsavel ,
	sexo = @sexo ,
	CidadeAluno = @CidadeAluno  ,
	UF = @UF ,
	EnderecoAluno = @EnderecoAluno ,
	setor = @setor ,
	numero = @numero,
	cep = @cep ,
	senha = @senha 
	WHERE Id = @Id
	GO
/*-----------------------------------------------------------------------------------------------*/
CREATE PROCEDURE SP_ExcluirAluno
@Id int
As
	DELETE FROM Aluno WHERE Id = @Id

/*-----------------------------------------------------------------------------------------------*/

CREATE PROCEDURE SP_ExcluirProfessor
@Id int
As
	DELETE FROM Professor WHERE Id = @Id
/*-----------------------------------------------------------------------------------------------*/
CREATE PROCEDURE SP_InserirProfessor
	@Id int OUTPUT ,
	@NomeProfessor varchar(100) ,
	@CPF_Professor varchar(100) ,
	@Email varchar(100) ,
	@Telefone varchar(50) ,
	@DataDeNascimento varchar(50),
	@sexo varchar(50),
	@CidadeProfessor varchar(100),
	@UF varchar(50),
	@EnderecoProfessor varchar(100), 
	@setor varchar(100),
	@cep varchar(50),
	@senha varchar(50)
AS
	INSERT INTO Professor(NomeProfessor,CPF_Professor,Email,Telefone,DataDeNascimento,sexo,CidadeProfessor,UF,EnderecoProfessor,setor,cep,senha)
	Values(@NomeProfessor,@CPF_Professor,@Email,@Telefone,@DataDeNascimento,@sexo,@CidadeProfessor,@UF,@EnderecoProfessor,@setor,@cep,@senha)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

EXEC SP_InserirProfessor 0,'HERINQUE','905.609.112-27','bruno@gmail.com','(63) 9 9260-2004','01/01/1994','M','Araguaina','TO','RUA X','Y','77808-642','123456B'
go
/*-----------------------------------------------------------------------------------------------*/

CREATE PROCEDURE SP_BuscarProfessor
	@filtro varchar(250) = ''
as
	select Id,NomeProfessor,CPF_Professor,Email,Telefone,DataDeNascimento,sexo,CidadeProfessor,UF,EnderecoProfessor,setor,cep,senha from Professor WHERE NomeProfessor LIKE  @filtro + '%' or CPF_Professor  LIKE '%'+ @filtro +'%' or  Id LIKE '%'+ @filtro+'%'
	GO

	/*EXEC SP_BuscarProfessor '1'
go*/
/*-----------------------------------------------------------------------------------------------*/

CREATE PROCEDURE SP_AlterarProfessor
	@Id int OUTPUT ,
	@NomeProfessor varchar(100) ,
	@CPF_Professor varchar(100) ,
	@Email varchar(100) ,
	@Telefone varchar(50) ,
	@DataDeNascimento varchar(50),
	@sexo varchar(50),
	@CidadeProfessor varchar(100),
	@UF varchar(50),
	@EnderecoProfessor varchar(100), 
	@setor varchar(100),
	@cep varchar(50),
	@senha varchar(50)
	AS
	UPDATE Professor SET
	NomeProfessor = @NomeProfessor,
	CPF_Professor = @CPF_Professor,
	Email = @Email,
	Telefone = @Telefone,
	DataDeNascimento = @DataDeNascimento,
	sexo = @sexo ,
	CidadeProfessor = @CidadeProfessor ,
	UF = @UF ,
	EnderecoProfessor = @EnderecoProfessor , 
	setor = @setor ,
	cep = @cep,
	senha = @senha 
	WHERE Id = @Id
	GO

/*	EXEC SP_AlterarProfessor 1,'Henrique','905.609.112-27','henrique@gmail.com','(63) 9 9260-2004','01/01/1997','M','Araguaina','TO','RUA X','Y','77808-642','101001'
go
select*from Professor*/