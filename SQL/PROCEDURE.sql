/*##############################################################################################################################################################*/

/*CRIAÇÃO DAS PROCEDURES DO BANCO */
/*LEMBRA DE ALTERAR O QTD DO VARCHAR DA SENHA DO ALUNO E PROFESSOR E AGENTE*/

/*##############################################################################################################################################################*/
CREATE PROCEDURE SP_InserirAgente
	@Id INT OUTPUT,
	@Senha VARCHAR(150),
	@NomeAgente VARCHAR(150)
AS
	INSERT INTO AgentePedagogico(Senha,NomeAgente)
	VALUES(@Senha,@NomeAgente)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_BuscarAgente
	@filtro varchar(250) = ''
AS
	SELECT Id,Senha,NomeAgente from AgentePedagogico WHERE  Id like '%' +@filtro + '%' OR NomeAgente LIKE  '%' + @filtro + '%'
GO

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
	@senha varchar(150),
	@Id_Turma int
AS
	INSERT INTO Aluno(NomeAluno, DataDeNascimento,TelefoneResponsavel,cpf,Email,NomeDoResponsavel,Id_Sexo,Id_Cidade,EnderecoAluno,setor,numero,cep,senha,Id_Turma)
	Values(@NomeAluno,@DataDeNascimento,@TelefoneResponsavel,@cpf,@Email,@NomeDoResponsavel,@Id_Sexo,@Id_Cidade,@EnderecoAluno,@setor,@numero,@cep,@senha,@Id_Turma)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_BuscarAluno /*buscando por nome, id, cpf */
	@filtro varchar(250) = ''
AS
	SELECT Id,NomeAluno, DataDeNascimento,TelefoneResponsavel,cpf,Email,NomeDoResponsavel,Id_Sexo,Id_Cidade,EnderecoAluno,setor,numero,cep,senha,Id_Turma 
	from Aluno WHERE Id LIKE '%'+ @filtro + '%' or NomeAluno LIKE '%'+ @filtro + '%'
GO 

/*MODIFICAR A PROCEDURE DE BUSCA PARA BUSCAR POR INICIAL DE NOME*/
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

-------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ExcluirAluno /*deletando por id*/
	@Id int
AS
	DELETE FROM Aluno WHERE Id = @Id
GO

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
	SELECT Id,NomeDisciplina from Disciplina WHERE Id LIKE '%'+ @filtro + '%'
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
	SELECT Id,Id_Aluno,Id_Diario,Faltas,data_dia from Frequencia WHERE Id LIKE  '%'+@filtro + '%'
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

ALTER PROC SP_BuscarNota
	@filtro varchar(250) = ''
AS
	SELECT Id,Id_Aluno,Id_Turma,Id_Diario,notaAluno from Nota WHERE Id LIKE  @filtro + '%' OR Id_Aluno LIKE '%' + @filtro+ '%'
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
	SELECT Id,Id_Aluno,Id_Diario,Descricao from Ocorrencia WHERE Id LIKE  '%'+@filtro +'%'
GO	

/*ADD A BUSCA POR ID DE ALUNO*/
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
	SELECT Id,Id_professor,Id_Diario,Conteudo from PlanoDeAula WHERE Id LIKE  @filtro + '%'
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
	@Senha varchar(150)
AS 
	INSERT INTO Professor(Id_Sexo,Id_Cidade,NomeProfessor,CPF_Professor,Email,Telefone,DataDeNascimento,EnderecoProfessor,setor,cep,Senha)
	VALUES(@Id_Sexo,@Id_Cidade,@NomeProfessor,@CPF_Professor,@Email,@Telefone,@DataDeNascimento,@EnderecoProfessor,@setor,@cep,@Senha)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

alter PROC SP_BuscarProfessor
 @filtro varchar(250) = ''
AS
	SELECT Id,Id_Sexo,Id_Cidade,NomeProfessor,CPF_Professor,Email,Telefone,DataDeNascimento,EnderecoProfessor,setor,cep,Senha from Professor WHERE Id LIKE  @filtro + '%' OR NomeProfessor like '%'+ @filtro+'%'
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
	@Senha varchar(150)
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
