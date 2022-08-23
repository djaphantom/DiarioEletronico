USE master
GO
CREATE DATABASE BancoDiarioEle
GO
USE BancoDiarioEle
GO
/*-----------------------------------------------------------------------
------------------------*/--1 ADD DE NOVA COLUNA

CREATE TABLE AgentePedagogico(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	NomeAgente varchar(150) NULL,
	senha varchar(150)not null,
	NomeUsuario varchar(100) not null
)
GO

/*-----------------------------------------------------------------------
------------------------*/--2 ADD DE NOVA COLUNA

CREATE TABLE Aluno 
(
	Id int PRIMARY KEY IDENTITY (1,1)NOT NULL,
	Id_Sexo int NULL,
	Id_Cidade int NULL,
	Id_Turma int null,
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
	senha varchar(150)not null,
	NomeUsuario varchar(100)not null
)
GO

/*-----------------------------------------------------------------------
------------------------*/--3

CREATE TABLE Cidade
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_UF int null,
	NomeCidade VARCHAR(50) NULL
)
GO

/*-----------------------------------------------------------------------
------------------------*/--4

CREATE TABLE Diario(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Disciplina int NULL,	
	Id_Professor int NULL,
	Id_Turma int NULL,
)
GO

/*-----------------------------------------------------------------------
------------------------*/--5

CREATE TABLE Disciplina(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	NomeDisciplina varchar(50) NOT NULL,
)
GO

/*-----------------------------------------------------------------------ok
------------------------*/--6 MODIFICA��O DO NOME DA COLUNA

CREATE TABLE Frequencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Diario int null,
	Faltas bit NULL,
	data_ datetime NULL,
)
GO

/*-----------------------------------------------------------------------
------------------------*/--7

CREATE TABLE Nota(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Turma int NULL,
	Id_Diario int null,
	notaAluno FLOAT NULL,
)
GO

/*-----------------------------------------------------------------------
------------------------*/--8

CREATE TABLE Ocorrencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Diario int null,
	Descricao varchar(100) NULL,
)
GO

/*-----------------------------------------------------------------------
------------------------*/--9

CREATE TABLE PlanoDeAula(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_professor int NULL,
	Id_Diario int null,
	Conteudo varchar(100) NULL,
)
GO

/*-----------------------------------------------------------------------
------------------------*/--10 ADD DE NOVA COLUNA

CREATE TABLE Professor(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Sexo int NULL,
	Id_Cidade int NULL,
	NomeProfessor varchar(100) NULL,
	CPF_Professor varchar(100) NULL,
	Email varchar(100) NULL,
	Telefone varchar(50) NULL,
	DataDeNascimento varchar(50)NULL,
	EnderecoProfessor varchar(100) NULL,
	setor varchar(100)NULL,
	cep varchar(50)null,
	senha varchar(150)not null,
	NomeUsuario varchar(100)not null
)
GO


/*-----------------------------------------------------------------------
------------------------*/--11

CREATE TABLE Sexo
(
	Id int PRIMARY KEY IDENTITY(1,1)NOT NULL,
	SEXO VARCHAR (50) NULL
)
GO

/*-----------------------------------------------------------------------
------------------------*/--12 MODIFICA��O DO NOME DA COLUNA

CREATE TABLE Turma(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Serie varchar(100) NULL,
	Turno varchar(100)
)
GO

/*-----------------------------------------------------------------------
------------------------*/--13

CREATE TABLE UF
(
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	NomeUF VARCHAR(50)NULL
)
/*-----------------------------------------------------------------------
------------------------*/--14
	
CREATE TABLE Bimestre
(
Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Bimestre varchar(100)null
)
go
/*-----------------------------------------------------------------------
------------------------*/--15
CREATE TABLE Boletim
(
Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Id_Bimestre int null,
Id_Disciplina int null,
Id_Aluno int NULL,
Nota float null,
faltas int null,
Media float null,
Resultado varchar(50)
)
go
/*-----------------------------------------------------------------------
------------------------*/--16
/*TODOS OS SELECT DAS TABELAS */

/*##############################################################################################################################################################*/

SELECT*FROM AgentePedagogico
SELECT*FROM Aluno
SELECT*FROM CIDADE
SELECT*FROM Diario
SELECT*FROM Disciplina
SELECT*FROM Frequencia
SELECT*FROM Nota
SELECT*FROM Ocorrencia
SELECT*FROM PlanoDeAula
SELECT*FROM Professor
SELECT*FROM SEXO
SELECT*FROM Turma
SELECT*FROM UF

go

/*##############################################################################################################################################################*/

/*CRIA��O DAS PROCEDURES DO BANCO */

/*##############################################################################################################################################################