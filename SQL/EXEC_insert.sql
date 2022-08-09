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
SELECT * FROM Aluno

EXEC SP_InserirAluno 0,'Bruno Alencar Moreira','21/03/2003','(63) 9 9104-6919','066.854.411-27','brunoalencarvilk13@gmail,com','Sidiclea Batista Alencar Moreira',1,1,'Rua curitibanos guadra 01 lote 09','setor Palmas',150,'77808-642','BRUNO',NULL
GO
------------------------------------------------------------------------------------------------
SELECT * FROM Turma

EXEC SP_InserirTurma 0,'1 A','vespertino'
GO
EXEC SP_InserirTurma 0,'1 B','vespertino'
GO
EXEC SP_InserirTurma 0,'1 C','vespertino'
GO
----------------------------------------------------------------------------------------------
SELECT*FROM Professor

EXEC SP_InserirProfessor 0,1,1,'Rafael Coelho Lima','123.456.789-10','rafael@gmail.com','(63) 9 9214-6050','20/05/1977','senai','setor central','12345-123',123321
GO
-----------------------------------------------------------------------------------------------
SELECT * FROM AgentePedagogico

EXEC SP_InserirAgente 0,'ADM','ADM'
GO
EXEC SP_InserirAgente 0,'ADM','BM'
GO
EXEC SP_InserirAgente 0,'ADM','BH'
GO
EXEC SP_InserirAgente 0,'ADM','DJ'
GO
EXEC SP_InserirAgente 0,'ADM','FRAN'
GO