USE master
GO
CREATE DATABASE BancoDiarioEle
GO
USE BancoDiarioEle
GO
/*-----------------------------------------------------------------------
------------------------*/--1
CREATE TABLE Sexo
(
	Id int PRIMARY KEY IDENTITY(1,1)NOT NULL,
	SEXO VARCHAR (50) NULL
)
GO
/*-----------------------------------------------------------------------
------------------------*/--2
CREATE TABLE Cidade
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_UF int null,
	NomeCidade VARCHAR(50) NULL
)
GO
/*-----------------------------------------------------------------------
------------------------*/--3
CREATE TABLE Uf
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
	senha varchar(50)not null
)
GO
select * from Aluno
/*-----------------------------------------------------------------------ok
------------------------*/--5
CREATE TABLE Diario(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Disciplina int NULL,	
	Id_Professor int NULL,
	Id_Turma int NULL,
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
	Id_Diario int null,
	Faltas bit NULL,
	data_dia datetime NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--8
CREATE TABLE Nota(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Turma int NULL,
	Id_Diario int null,
	notaAluno FLOAT NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--9
CREATE TABLE Ocorrencia(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Diario int null,
	Descricao varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--10
CREATE TABLE PlanoDeAula(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_professor int NULL,
	Id_Diario int null,
	Conteudo varchar(100) NULL,
)
GO
/*-----------------------------------------------------------------------
------------------------*/--11
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
	senha varchar(50)not null
)
GO
/*-----------------------------------------------------------------------
------------------------*/--12
CREATE TABLE Turma(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Periodo varchar(100) NULL,
	Turno varchar(100)
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
/*TODOS OS SELECT DAS TABELAS */

/*##############################################################################################################################################################*/

SELECT*FROM AgentePedagogico
SELECT*FROM Aluno
SELECT*FROM Professor
SELECT*FROM CIDADE
SELECT*FROM Diario
SELECT*FROM Disciplina
SELECT*FROM Frequencia
SELECT*FROM Nota
SELECT*FROM Ocorrencia
SELECT*FROM PlanoDeAula
SELECT*FROM SEXO
SELECT*FROM Turma
SELECT*FROM UF
go

/*##############################################################################################################################################################*/

/*CRIAÇÃO DAS PROCEDURES DO BANCO */

/*##############################################################################################################################################################*/
CREATE PROCEDURE SP_InserirAgente
	@Id INT OUTPUT,
	@Senha VARCHAR(50),
	@NomeAgente VARCHAR(150)
AS
	INSERT INTO AgentePedagogico(Senha,NomeAgente)
	VALUES(@Senha,@NomeAgente)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO
 
 /*exec SP_InserirAgente 0,'ADM','DJ'
 GO*/


---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_BuscarAgente
	@filtro varchar(250) = ''
AS
	SELECT Id,Senha,NomeAgente from AgentePedagogico WHERE  Id like '' +@filtro + '' OR NomeAgente LIKE  '%' + @filtro + '%'
GO
/*EXEC SP_BuscarAgente ''
GO*/
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_AlterarAgente
	@Id int ,
	@Senha VARCHAR(50),
	@NomeAgente VARCHAR(150)
AS
  UPDATE AgentePedagogico SET
	senha = @Senha ,
	NomeAgente = @NomeAgente
	WHERE Id = @Id
GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ExcluirAgente
	@Id int
As
	DELETE FROM AgentePedagogico WHERE Id = @Id
GO

/*  exec SP_ExcluirAgente '1'  
go  */

/*##############################################################################################################################################################*/
CREATE PROCEDURE SP_InserirAluno
	@Id int OUTPUT,
	@NomeAluno varchar(100) ,
	@DataDeNascimento varchar(50),
	@TelefoneResponsavel varchar(50) ,
	@cpf varchar(100),
	@Email varchar(100) ,
	@NomeDoResponsavel varchar(100),
	@Id_Sexo int,
	@Id_Cidade int ,
	@EnderecoAluno varchar(100) ,
	@setor varchar(100),
	@numero INT ,
	@cep varchar(50),
	@senha varchar(50),
	@Id_Turma int
AS
	INSERT INTO Aluno(NomeAluno, DataDeNascimento,TelefoneResponsavel,cpf,Email,NomeDoResponsavel,Id_Sexo,Id_Cidade,EnderecoAluno,setor,numero,cep,senha,Id_Turma)
	Values(@NomeAluno,@DataDeNascimento,@TelefoneResponsavel,@cpf,@Email,@NomeDoResponsavel,@Id_Sexo,@Id_Cidade,@EnderecoAluno,@setor,@numero,@cep,@senha,@Id_Turma)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*EXEC SP_InserirAluno 0,'BRUNO',NULL,NULL,NULL,'BRUNO@EMAIL.COM',NULL,1,1,NULL,NULL,NULL,NULL,'BRUNO2003',NULL
GO*/
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

ALTER PROCEDURE SP_BuscarAluno /*buscando por nome, id, cpf */
	@filtro varchar(250) = ''
AS
	SELECT Id,NomeAluno, DataDeNascimento,TelefoneResponsavel,cpf,Email,NomeDoResponsavel,Id_Sexo,Id_Cidade,EnderecoAluno,setor,numero,cep,senha,Id_Turma from Aluno WHERE NomeAluno LIKE  @filtro + '%' or Id LIKE  @filtro + '' or NomeAluno LIKE ''+ @filtro + ''
GO 

-----------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_AlterarAluno /*alterando informações desejadas */
	@Id int OUTPUT,
	@NomeAluno varchar(100) ,
	@DataDeNascimento varchar(50),
	@TelefoneResponsavel varchar(50) ,
	@cpf varchar(100),
	@Email varchar(100) ,
	@NomeDoResponsavel varchar(100),
	@Id_Cidade int ,
	@Id_Sexo int,
	@EnderecoAluno varchar(100) ,
	@setor varchar(100),
	@numero INT ,
	@cep varchar(50),
	@senha varchar(50),
	@Id_Turma int
AS
	UPDATE Aluno SET
	NomeAluno = @NomeAluno  ,
	DataDeNascimento = @DataDeNascimento,
	TelefoneResponsavel =  @TelefoneResponsavel  ,
	cpf = @cpf ,
	Email = @Email  ,
	NomeDoResponsavel = @NomeDoResponsavel ,
	Id_Sexo = @Id_Sexo ,
	Id_Cidade = @Id_Cidade  ,
	EnderecoAluno = @EnderecoAluno ,
	setor = @setor ,
	numero = @numero,
	cep = @cep ,
	senha = @senha,
	Id_Turma = @Id_Turma
	WHERE Id = @Id
GO

/*EXEC SP_AlterarAluno 1,'BRUNO','21/03/2003','(63) 9 9216-6014','066.854.411-27','brunoalencarvilk13@gmail.com','Sidiclea batista Alencar Moreira',1,1,'Rua curitibanos guadra 01 lote 09','Setor Palmas',150,'77808-642','BRUNO2003',NULL
GO*/

-------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ExcluirAluno /*deletando por id*/
	@Id int
AS
	DELETE FROM Aluno WHERE Id = @Id
GO

/*exec SP_ExcluirAluno '2'
	go*/

/*##############################################################################################################################################################*/

CREATE PROCEDURE SP_InserirCidade 
	@Id int OUTPUT,
	@Id_UF int,
	@NomeCidade VARCHAR(50)
AS
INSERT INTO CIDADE(Id_UF,NomeCidade)
	VALUES(@Id_UF,@NomeCidade)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*EXEC SP_InserirCidade 0,1,'Porto Alegre'
GO*/

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_BuscarCidade
	@filtro varchar(250) = ''
AS
	SELECT Id,Id_UF,NomeCidade from CIDADE WHERE Id LIKE  @filtro + ''
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_AlterarCidade
	@Id int OUTPUT,
	@Id_UF int,
	@NomeCidade VARCHAR(50)
AS	
UPDATE CIDADE SET
	Id_UF = @Id_UF,
	NomeCidade = @NomeCidade
	WHERE Id = @Id
GO
 
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ExcluirCidade
	@Id int
AS
	DELETE FROM CIDADE WHERE Id = @Id
GO

/*##############################################################################################################################################################*/

CREATE PROCEDURE SP_InserirDiario
	@Id int OUTPUT,
	@Id_Disciplina INT,
	@Id_Professor int ,
	@Id_Turma int
AS
	INSERT INTO Diario(Id_Disciplina,Id_Professor,Id_Turma)
	VALUES(@Id_Disciplina,@Id_Professor,@Id_Turma)
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_BuscarDiario
@filtro varchar(250) = ''
AS
	SELECT Id,Id_Disciplina,Id_Professor,Id_Turma from Diario WHERE Id LIKE  @filtro + ''
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_AlterarDiario
	@Id int OUTPUT,
	@Id_Disciplina INT,
	@Id_Professor int ,
	@Id_Turma int
AS	
UPDATE Diario SET
	Id_Disciplina = @Id_Disciplina,
	Id_Professor = @Id_Professor,
	Id_Turma = @Id_Turma
	WHERE Id = @Id
GO

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ExcluirDiario
	@Id int
AS
	DELETE FROM Diario WHERE Id = @Id
GO


/*##############################################################################################################################################################*/

CREATE PROCEDURE SP_InserirDisciplina
	@Id int OUTPUT,
	@NomeDisciplina varchar(50)
AS
	INSERT INTO Disciplina(NomeDisciplina)
	VALUES(@NomeDisciplina)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_BuscarDisciplina
 @filtro varchar(250) = ''
AS
	SELECT Id,NomeDisciplina from Disciplina WHERE Id LIKE  @filtro + ''
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_AlterarDisciplina
    @Id int OUTPUT,
	@NomeDisciplina varchar(50)
AS	
UPDATE Disciplina SET
	NomeDisciplina = @NomeDisciplina	
	WHERE Id = @Id
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ExcluirDisciplina 
	@Id int
AS
	DELETE FROM Disciplina WHERE Id = @Id
GO


/*##############################################################################################################################################################*/

CREATE PROCEDURE SP_InserirFrequencia
	@Id int OUTPUT,
	@Id_Aluno int,
	@Id_Diario int,
	@Faltas bit,
	@data_dia datetime
AS
	INSERT INTO Frequencia(Id_Aluno,Id_Diario,Faltas,data_dia)
	VALUES(@Id_Aluno,@Id_Diario,@Faltas,@data_dia)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO
---------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_BuscarFrequencia
	@filtro varchar(250) = ''
AS
	SELECT Id,Id_Aluno,Id_Diario,Faltas,data_dia from Frequencia WHERE Id LIKE  @filtro + ''
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AlterarFrequencia
	@Id int OUTPUT,
	@Id_Aluno int,
	@Id_Diario int,
	@Faltas bit,
	@data_dia datetime
AS
UPDATE Frequencia SET
	Id_Aluno = @Id_Aluno,
	Id_Diario = @Id_Diario,
	Faltas = @Faltas,
	data_dia = @data_dia
	WHERE Id = @Id
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ExcluirFrequencia
	@Id int
AS
	DELETE FROM Frequencia WHERE Id = @Id
GO

/*##############################################################################################################################################################*/

CREATE PROC SP_InserirNota
	@Id int OUTPUT,
	@Id_Aluno int,
	@Id_Turma int,
	@Id_Diario int,
	@notaAluno float
AS
	INSERT INTO Nota(Id_Aluno,Id_Turma,Id_Diario,notaAluno)
	VALUES(@Id_Aluno,@Id_Turma,@Id_Diario,@notaAluno)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

-------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_BuscarNota
	@filtro varchar(250) = ''
AS
	SELECT Id,Id_Aluno,Id_Turma,Id_Diario,notaAluno from Nota WHERE Id LIKE  @filtro + ''
GO

----------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AlterarNota
	@Id int OUTPUT,
	@Id_Aluno int,
	@Id_Turma int,
	@Id_Diario int,
	@notaAluno float
AS
UPDATE Nota SET
	Id_Aluno = @Id_Aluno,
	Id_Diario = @Id_Diario,
	Id_Turma = @Id_Turma,
	notaAluno = @notaAluno
	WHERE Id = @Id
GO	

------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ExcluirNota
	@Id int
AS
	DELETE FROM Nota WHERE Id = @Id
GO

/*##############################################################################################################################################################*/

CREATE PROC SP_InserirOcorrencia
	@Id int OUTPUT,
	@Id_Aluno int,
	@Id_Diario int,
	@Descricao varchar(100)
AS
	INSERT INTO Ocorrencia(Id_Aluno,Id_Diario,Descricao)
	VALUES(@Id_Aluno,@Id_Diario,@Descricao)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_BuscarOcorrencia
	@filtro varchar(250) = ''
AS
	SELECT Id,Id_Aluno,Id_Diario,Descricao from Ocorrencia WHERE Id LIKE  @filtro + ''
GO	

------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AlterarOcorrencia
	@Id int OUTPUT,
	@Id_Aluno int,
	@Id_Diario int,
	@Descricao varchar(100)
AS
UPDATE Ocorrencia SET
	Id_Aluno = @Id_Aluno,
	Id_Diario = @Id_Diario,
	Descricao = @Descricao
	WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ExcluirOcorrencia
	@Id int
AS
	DELETE FROM Ocorrencia WHERE Id = @Id
GO
/*##############################################################################################################################################################*/

CREATE PROC SP_InserirPlanoDeAula 
	@Id int OUTPUT,
	@Id_professor int ,
	@Id_Diario int ,
	@Conteudo varchar(100)
AS
	INSERT INTO PlanoDeAula(Id_professor,Id_Diario,Conteudo)
	VALUES(@Id_professor,@Id_Diario,@Conteudo)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

----------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_BuscarPlanoDeAula
@filtro varchar(250) = ''
AS
	SELECT Id,Id_professor,Id_Diario,Conteudo from PlanoDeAula WHERE Id LIKE  @filtro + ''
GO	

-----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AlterarPlanoDeAula
	@Id int OUTPUT,
	@Id_professor int ,
	@Id_Diario int ,
	@Conteudo varchar(100)
AS
UPDATE PlanoDeAula SET
	Id_professor = @Id_professor,
	Id_Diario = @Id_Diario,
	@Conteudo = @Conteudo
	WHERE Id = @Id
GO

------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ExcluirPlanoDeAula 
	@Id int
AS
	DELETE FROM PlanoDeAula WHERE Id = @Id
GO

/*##############################################################################################################################################################*/

CREATE PROC SP_InserirProfessor
	@Id int OUTPUT,
	@Id_Sexo int,
	@Id_Cidade int,
	@NomeProfessor varchar(100),
	@CPF_Professor varchar(100),
	@Email varchar(100),
	@Telefone varchar(50),
	@DataDeNascimento varchar(100),
	@EnderecoProfessor varchar(100),
	@setor varchar(100),
	@cep varchar(50),
	@Senha varchar(50)
AS 
	INSERT INTO Professor(Id_Sexo,Id_Cidade,NomeProfessor,CPF_Professor,Email,Telefone,DataDeNascimento,EnderecoProfessor,setor,cep,Senha)
	VALUES(@Id_Sexo,@Id_Cidade,@NomeProfessor,@CPF_Professor,@Email,@Telefone,@DataDeNascimento,@EnderecoProfessor,@setor,@cep,@Senha)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_BuscarProfessor
 @filtro varchar(250) = ''
AS
	SELECT Id,Id_Sexo,Id_Cidade,NomeProfessor,CPF_Professor,Email,Telefone,DataDeNascimento,EnderecoProfessor,setor,cep,Senha from Professor WHERE Id LIKE  @filtro + ''
GO	

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC SP_AlterarProfessor
	@Id int OUTPUT,
	@Id_Sexo int,
	@Id_Cidade int,
	@NomeProfessor varchar(100),
	@CPF_Professor varchar(100),
	@Email varchar(100),
	@Telefone varchar(50),
	@DataDeNascimento varchar(100),
	@EnderecoProfessor varchar(100),
	@setor varchar(100),
	@cep varchar(50),
	@Senha varchar(50)
AS
UPDATE Professor SET
	Id_Sexo = @Id_Sexo,
	Id_Cidade = @Id_Cidade,
	NomeProfessor = @NomeProfessor,
	CPF_Professor =@CPF_Professor,
	Email = @Email,
	Telefone = @Telefone,
	DataDeNascimento = @DataDeNascimento,
	EnderecoProfessor = @EnderecoProfessor,
	setor = @setor,
	cep = @cep,
	Senha = @Senha
	WHERE Id = @Id
GO

-------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ExcluirProfessor
	@Id int
AS
	DELETE FROM PlanoDeAula WHERE Id = @Id
GO

/*##############################################################################################################################################################*/

CREATE PROC SP_InserirSexo 
	@Id int output,
	@Sexo varchar(50)
AS
	INSERT INTO Sexo(Sexo)
	VALUES(@Sexo)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*EXEC SP_InserirSexo 0,'Outros'
Go*/

---------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_BuscarSexo 
	@filtro varchar(250) = ''
AS
	SELECT Id,Sexo from Sexo WHERE Id LIKE  @filtro + ''
GO	

---------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AlterarSexo
	@Id int output,
	@Sexo varchar(50)
AS
UPDATE Sexo SET
	Sexo = @Sexo	
	WHERE Id = @Id
GO

------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ExcluirSexo
	@Id int
AS
	DELETE FROM Sexo WHERE Id = @Id
GO

/*##############################################################################################################################################################*/

CREATE PROC SP_InserirTurma
	@Id int OUTPUT ,
	@Periodo varchar(100),
	@Turno varchar(100)
As
	INSERT INTO Turma(Periodo,Turno)
	VALUES(@Periodo,@Turno)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_BuscarTurma
	@filtro varchar(250) = ''
AS
	SELECT Id,Periodo,Turno from Turma WHERE Id LIKE  @filtro + ''
GO	

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AlterarTurma
	@Id int OUTPUT ,
	@Periodo varchar(100),
	@Turno varchar(100)
AS
UPDATE Turma SET
	Periodo = @Periodo	
	WHERE Id = @Id
GO

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ExcluirTurma
	@Id int
AS
	DELETE FROM Turma WHERE Id = @Id
GO

/*##############################################################################################################################################################*/

CREATE PROC SP_InseirUF
	@Id int  OUTPUT,
	@NomeUF varchar(50)
AS
	INSERT INTO Uf(NomeUF)
	VALUES(@NomeUF)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*EXEC SP_InseirUF 0,'TO'
GO*/

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_BuscarUF
	@filtro varchar(250) = ''
AS
	SELECT Id,NomeUF from Uf WHERE Id LIKE  @filtro + ''
GO

------------------------------------------------------------------------------------------------------------------------------------------
 
CREATE PROC SP_AlterarUF
	@Id int  OUTPUT,
	@NomeUF varchar(50)
AS
UPDATE Uf SET
	NomeUF = @NomeUF	
	WHERE Id = @Id
GO

-----------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ExcluirUF
	@Id int
AS
	DELETE FROM Uf WHERE Id = @Id
GO

/*##############################################################################################################################################################*/


SELECT * FROM ALUNO