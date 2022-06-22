USE master
GO
CREATE DATABASE BancoDiarioEle
GO
USE BancoDiarioEle
GO
/*-----------------------------------------------------------------------
------------------------*/--1
CREATE TABLE SEXO
(
	Id int PRIMARY KEY IDENTITY(1,1)NOT NULL,
	SEXO VARCHAR (50) NULL
)
GO
/*-----------------------------------------------------------------------
------------------------*/--2
CREATE TABLE CIDADE
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	NomeCidade VARCHAR(50) NULL
)
GO
/*-----------------------------------------------------------------------
------------------------*/--3
CREATE TABLE UF
(
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	NomeUF VARCHAR(50)NULL
)
GO
/*-----------------------------------------------------------------------
------------------------*/--4
CREATE TABLE Aluno 
(
	Id int PRIMARY KEY IDENTITY (1,1)NOT NULL,
	Id_Sexo int NULL,
	Id_Cidade int NULL,
	Id_UF int NULL,
	NomeAluno varchar(100) NULL,
	DataDeNascimento varchar(50)NULL,
	TelefoneResponsavel varchar(50) NULL,
	cpf varchar(100)null,
	Email varchar(100) NULL,
	NomeDoResponsavel varchar(100)NULL,
	EnderecoAluno varchar(100) NULL,
	setor varchar(100)NULL,
	numero INT NULL,
	cep varchar(50),
	senha varchar(50)not null
)
GO
/*-----------------------------------------------------------------------
------------------------*/--5
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
/*-----------------------------------------------------------------------
------------------------*/--6
CREATE TABLE Disciplina(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	NomeDisciplina varchar(50) NOT NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--7
CREATE TABLE Frequencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Apontamento [bit] NULL,
Data datetime NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--8
CREATE TABLE Nota(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Turma int NULL,
	notaAluno FLOAT NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--9
CREATE TABLE Ocorrencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Descricao varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--10
CREATE TABLE PlanoDeAula(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_professor int NULL,
	Conteudo varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--11
CREATE TABLE Professor(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Sexo int NULL,
	Id_Cidade int NULL,
	Id_UF int NULL,
	NomeProfessor varchar(100) NULL,
	CPF_Professor varchar(100) NULL,
	Email varchar(100) NULL,
	Telefone varchar(50) NULL,
	DataDeNascimento varchar(50)NULL,
	EnderecoProfessor varchar(100) NULL,
	setor varchar(100)NULL,
	cep varchar(50)null,
	senha varchar(50)not null
)
GO
/*-----------------------------------------------------------------------
------------------------*/--12
CREATE TABLE Turma(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NOT NULL,
	Periodo varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--13
CREATE TABLE AgentePedagogico(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	senha varchar(50)not null,
	NomeAgente varchar(150) NULL,
)
GO

