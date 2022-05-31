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
	NomeUsuario varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/
create table aluno_turma
(
id_aluno int,
id_turma int,
)
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
Select*from Secretaria
select*from AgentePedagogico
/*-----------------------------------------------------------------------------------------------*/
					/*area de altera as tablelas se for preciso*/
/*Alter table Secretaria
add Id_Diario int

Alter table Secretaria
drop column NomeUsurio*/

/*-----------------------------------------------------------------------------------------------*/
CREATE PROCEDURE SP_InserirAluno
	@Id int ,
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
	INSERT INTO Aluno(Id, NomeAluno, DataDeNascimento,TelefoneResponsavel,cpf,Email,NomeDoResponsavel,sexo,CidadeAluno,UF,EnderecoAluno,setor,numero,cep,senha)
	Values(@Id,@NomeAluno,@DataDeNascimento,@TelefoneResponsavel,@cpf,@Email,@NomeDoResponsavel,@sexo,@CidadeAluno,@UF,@EnderecoAluno,@setor,@numero,@cep,@senha)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

EXEC SP_InserirAluno 'bruno','21/03/2003','(63) 99104-6919','066.854.411-27',null,null,null,null,null,null,null,105,null,'Bruno2003'
go
/*-----------------------------------------------------------------------------------------------*/