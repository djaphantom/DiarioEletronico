USE [master]
GO
/****** Object:  Database [Controle_de_Tarefas]    Script Date: 03/06/2022 20:09:48 ******/
CREATE DATABASE [Controle_de_Tarefas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Controle_de_Tarefas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\Controle_de_Tarefas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Controle_de_Tarefas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\Controle_de_Tarefas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Controle_de_Tarefas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Controle_de_Tarefas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Controle_de_Tarefas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Controle_de_Tarefas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Controle_de_Tarefas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Controle_de_Tarefas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Controle_de_Tarefas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Controle_de_Tarefas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Controle_de_Tarefas] SET  MULTI_USER 
GO
ALTER DATABASE [Controle_de_Tarefas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Controle_de_Tarefas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Controle_de_Tarefas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Controle_de_Tarefas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Controle_de_Tarefas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Controle_de_Tarefas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Controle_de_Tarefas] SET QUERY_STORE = OFF
GO
USE [Controle_de_Tarefas]
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 03/06/2022 20:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentario](
	[Id] [int] NOT NULL,
	[Id_Usuario] [int] NULL,
	[Id_Tarefa] [int] NULL,
	[Descricao] [varchar](100) NULL,
 CONSTRAINT [PK_Comentario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarefa]    Script Date: 03/06/2022 20:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarefa](
	[Id] [int] NOT NULL,
	[Id_Ususario] [int] NULL,
	[Descricao] [varchar](100) NULL,
	[Estatus] [varchar](10) NULL,
 CONSTRAINT [PK_Tarefa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 03/06/2022 20:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] NOT NULL,
	[Nome] [varchar](100) NULL,
	[Senha] [varchar](15) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD  CONSTRAINT [FK_Comentario_Tarefa] FOREIGN KEY([Id_Tarefa])
REFERENCES [dbo].[Tarefa] ([Id])
GO
ALTER TABLE [dbo].[Comentario] CHECK CONSTRAINT [FK_Comentario_Tarefa]
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD  CONSTRAINT [FK_Comentario_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Comentario] CHECK CONSTRAINT [FK_Comentario_Usuario]
GO
ALTER TABLE [dbo].[Tarefa]  WITH CHECK ADD  CONSTRAINT [FK_Tarefa_Usuario] FOREIGN KEY([Id_Ususario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Tarefa] CHECK CONSTRAINT [FK_Tarefa_Usuario]
GO
USE [master]
GO
ALTER DATABASE [Controle_de_Tarefas] SET  READ_WRITE 
GO
-----------------------------------------------------------------------
CREATE PROC SP_InserirUsuario 
	@Id int output,
	@Nome varchar(100),
	@Senha Varchar(15)

AS
	INSERT INTO Usuario(Nome, Senha)
	Values(@Nome, @Senha)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@INDENTITY
GO

-----------------------------------------------------------------------
CREATE PROC SP_BuscarUsusario
	@filtro varchar(250) = ''

AS 
	select Id, Nome, Senha from Usuario WHERE Nome like '%'+ @filtro + '%' or Id like ''+@filtro+''
GO

-----------------------------------------------------------------------------
alter PROC SP_BuscarTarefa
	@filtro varchar(250) = ''

AS 
	select Id, Id_Usuario, DESCRICAO, ESTATUS from Tarefa WHERE Descricao like '%'+@filtro+'%' OR CONVERT(VARCHAR(50), Id) = @filtro
GO
SELECT        Id, Id_Usuario, Descricao, Estatus
FROM            Tarefa
---------------------------------------------------------------------
CREATE PROC SP_ExcluirTarefa
@id int

AS 
	delete from Tarefa WHERE Id = @Id
GO

-----------------------------------------------------------------------
create PROC SP_BuscarComentario
@Id int

AS 
	SELECT Id, Id_Usuario, Id_Tarefa, Descricao FROM Comentario WHERE Id_Tarefa = @Id
GO

-----------------------------------------------------------------------------

CREATE PROC SP_ExcluirComentario
@id int

AS 
	delete from Tarefa WHERE Id = @Id
GO

select * from comentario

-----------------------------------------------------------------------------
alter PROC SP_InserirComentario
	@Id int output,
	@Id_Usuario int,
	@Id_Tarefa int,
	@Descricao varchar(100)

AS 
	INSERT INTO Comentario(Id, Id_Usuario, Id_Tarefa, descricao)
	Values(@Id, @Id_Usuario, @Id_Tarefa, @Descricao)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@INDENTITY
GO

-----------------------------------------------------------------------------
alter PROC SP_InserirTarefa
	@Id int output,
	@Id_Usuario int,
	@Descricao Varchar(100),
	@Estatus Varchar(100)

AS
	INSERT INTO Tarefa(Id, Id_Usuario, Descricao, Estatus)
	Values(@Id, @Id_Usuario, @Descricao, @Estatus)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@INDENTITY
GO



------------------------------------------------------

CREATE PROC SP_BuscarTarefa
@Id int

AS 
	select Id from Tarefa WHERE Id = @Id
GO

select * from Usuario
select * from Tarefa
select * from Comentario


select * from usuario

insert into Usuario(Id, Nome, Senha)
values(0, 'Franksney', '1234')

update Usuario set Id = 1 where ID = 0



insert into tarefa(Id, Id_Usuario, Descricao, Estatus)
values(1, 1, 'Nada de nada', 'ativo')


exec SP_BuscarTarefa @filtro=''
exec SP_InserirTarefa @Id=2,@Id_Usuario=1,@Descricao='helo',@Estatus='a teste'


select max(id) from tarefa
select * from tarefa

select isnull(max(id), 0) +1 from tarefa