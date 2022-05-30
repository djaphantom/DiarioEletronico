USE master
GO

IF EXISTS(SELECT 1 FROM SYS.databases WHERE name = 'BancoDiarioEletronico')
	DROP DATABASE BancoDiarioEletronico
GO

CREATE DATABASE BancoDiarioEletronico
GO

USE BancoDiarioEletronico
GO

/*-----------------------------------------------------------------------------------------------*/
CREATE TABLE Aluno
(
	Id int PRIMARY KEY IDENTITY (1,1)NOT NULL,
	NomeAluno varchar(100) NULL,
	DataDeNascimento varchar(50)NULL,
	EnderecoAluno varchar(100) NULL,
	CidadeAluno varchar(100) NULL,
	TelefoneResponsavel varchar(50) NULL,
	Email varchar(100) NULL,
	Id_Turma int NOT NULL,
	NomeDoResponsavel varchar(100)NULL,
	sexo varchar(50)NULL,
	setor varchar(100)NULL,
	numero INT NULL,
	cep varchar(50)
 )
GO

/*-----------------------------------------------------------------------------------------------*/
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

/*-----------------------------------------------------------------------------------------------*/

CREATE TABLE Disciplina(
	Id int PRIMARY KEY IDENTITY (1,1)  NOT NULL,
	NomeDisciplina varchar(50) NOT NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/
CREATE TABLE Frequencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Apontamento [bit] NULL,
	Data datetime NULL,
)
GO

/*-----------------------------------------------------------------------------------------------*/
CREATE TABLE Nota(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Turma int NULL,
	Apontamento FLOAT NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/
CREATE TABLE Ocorrencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Descricao varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------------------------------*/
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
	EnderecoProfessor varchar(100) NULL,
	CidadeProfessor varchar(100) NULL,
	CPF_Professor varchar(100) NULL,
	Email varchar(100) NULL,
	Telefone varchar(50) NULL,
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
select*from Aluno
select*from Diario
select*from Disciplina
select*from Frequencia
select*from Nota
select*from Ocorrencia
select*from PlanoDeAula
select*from Professor
select*from Turma
/*-----------------------------------------------------------------------------------------------*/
					/*area de altera as tablelas se for preciso*/
/*Alter table Ocorrencia
add Descricao varchar(300)

Alter table Turma
drop column Id__Aluno*/

/*-----------------------------------------------------------------------------------------------*/
CREATE PROCEDURE SP_InserirUsuario
	@ID int OUTPUT,
	@NomeUsuario VARCHAR(150),
	@Senha VARCHAR(100),
	@Ativo BIT
AS
	INSERT INTO USUARIO(Ativo, NomeUsuario, Senha)
	Values(@Ativo, @NomeUsuario, @Senha)
	SET @ID = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO
/*-----------------------------------------------------------------------------------------------*/