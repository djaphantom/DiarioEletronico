/*##############################################################################################################################################################*/

										/*TESTE DAS PRCEDURE DENTRO DO BANCO */ 

/*##############################################################################################################################################################*/
SELECT * FROM AgentePedagogico

exec SP_InserirAgente 0,'AGENTE PEDAGÓGICO','ADM','ADM'
GO--OK

/*EXEC SP_BuscarAgente ADM1
GO--OK

EXEC SP_AlterarAgente 2,'AGENTE PEDAGOGICO','ADM','ADM1'
GO--OK

EXEC SP_ExcluirAgente 
GO--OK*/
-----------------------------------------------------------------------------------------------
SELECT * FROM Aluno

/*EXEC SP_InserirAluno 0,'Bruno Alencar Moreira','21/03/2003','(63) 9 9104-6919','066.854.411-27','brunoalencarvilk13@gmail,com','Sidiclea Batista Alencar Moreira',NULL,NULL,'Rua curitibanos guadra 01 lote 09','setor Palmas',150,'77808-642','BRUNO',NULL,'BAM'
GO

EXEC SP_BuscarAluno BRUNO
GO

EXEC SP_AlterarAluno 1,'Bruno Alencar Moreira','21/03/2003','(63) 9 9104-6919','066.854.411-27','brunoalencarvilk13@gmail.com','Sidiclea Batista Alencar Moreira',NULL,NULL,'Rua curitibanos guadra 01 lote 09','setor Palmas',150,'77808-642','BRUNO',NULL,'BAM'
GO

EXEC SP_ExcluirAluno 1
GO*/

------------------------------------------------------------------------------------------------
SELECT * FROM Sexo

EXEC SP_InserirSexo 0,'Masculino'
Go
EXEC SP_InserirSexo 0,'Feminino'
Go
EXEC SP_InserirSexo 0,'Outros'
Go
------------------------------------------------------------------------------------------------------------
SELECT * FROM Uf

EXEC SP_InseirUF 0,'TO'
GO
------------------------------------------------------------------------------------------------------------
SELECT * FROM Cidade

EXEC SP_InserirCidade 0,1,'Araguaína'
GO
EXEC SP_InserirCidade 0,1,'Palmas'
GO

/*EXEC SP_BuscarCidade 2
GO

EXEC SP_AlterarCidade 1,1,'Araguaína'
GO

EXEC SP_ExcluirCidade 1
GO*/

------------------------------------------------------------------------------------------------------------
SELECT * FROM Disciplina

EXEC SP_InserirDisciplina 0,'Português'
GO
EXEC SP_InserirDisciplina 0,'Matemática'
GO
EXEC SP_InserirDisciplina 0,'Biologia'
GO
EXEC SP_InserirDisciplina 0,'Fisica'
GO
EXEC SP_InserirDisciplina 0,'Quimica'
GO
EXEC SP_InserirDisciplina 0,'Educação Fisica'
GO
EXEC SP_InserirDisciplina 0,'Geografia'
GO
EXEC SP_InserirDisciplina 0,'Inglês'
GO
EXEC SP_InserirDisciplina 0,'Redação'
GO
EXEC SP_InserirDisciplina 0,'Historia'
GO

------------------------------------------------------------------------------------------------
/*SELECT * FROM Turma

EXEC SP_InserirTurma 0,'1 A','vespertino'
GO
EXEC SP_InserirTurma 0,'1 B','vespertino'
GO
EXEC SP_InserirTurma 0,'1 C','vespertino'
GO*/
----------------------------------------------------------------------------------------------
/*SELECT*FROM Professor

EXEC SP_InserirProfessor 0,1,1,'Rafael Coelho Lima','123.456.789-10','rafael@gmail.com','(63) 9 9214-6050','20/05/1977','senai','setor central','12345-123',123321,'RCL'
GO*/
-----------------------------------------------------------------------------------------------
/*SELECT* FROM Frequencia

SP_InserirFrequencia 0,2,null,0,''
GO*/

exec SP_InserirDiario 0,1,2,1

SELECT ALUNO.Id,NomeAluno FROM Aluno INNER JOIN Turma AS T ON Aluno.Id_Turma = T.Id WHERE Serie =  '1 A' 

SELECT
 A.ID,
 A.NomeAluno,
 T.Serie
FROM 
ALUNO A,
TURMA T
WHERE 
 A.ID = T.Id AND
 T.Serie = '1 A'



SELECT*FROM Aluno
SELECT * FROM  Nota


