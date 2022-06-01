USE [master]
GO

IF EXISTS(SELECT 1 FROM SYS.databases WHERE name = 'BancoDiarioEletronico')
	DROP DATABASE BancoDiarioEletronico
GO

/****** Object:  Database [BancoDiarioEletronico]    Script Date: 30/05/2022 21:23:31 ******/
CREATE DATABASE [BancoDiarioEletronico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BancoDiarioEletronico', FILENAME = N'C:\Users\Public\Documents\BancoDiarioEletronico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BancoDiarioEletronico_log', FILENAME = N'C:\Users\Public\Documents\BancoDiarioEletronico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BancoDiarioEletronico] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BancoDiarioEletronico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BancoDiarioEletronico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET ARITHABORT OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BancoDiarioEletronico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BancoDiarioEletronico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BancoDiarioEletronico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BancoDiarioEletronico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BancoDiarioEletronico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BancoDiarioEletronico] SET  MULTI_USER 
GO
ALTER DATABASE [BancoDiarioEletronico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BancoDiarioEletronico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BancoDiarioEletronico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BancoDiarioEletronico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BancoDiarioEletronico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BancoDiarioEletronico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BancoDiarioEletronico] SET QUERY_STORE = OFF
GO
USE [BancoDiarioEletronico]
GO
/****** Object:  Table [dbo].[AgentePedagogico]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgentePedagogico](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[NomeUsuario] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeAluno] [varchar](100) NULL,
	[DataDeNascimento] [varchar](50) NULL,
	[TelefoneResponsavel] [varchar](50) NULL,
	[cpf] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[NomeDoResponsavel] [varchar](100) NULL,
	[sexo] [varchar](50) NULL,
	[CidadeAluno] [varchar](100) NULL,
	[UF] [varchar](50) NULL,
	[EnderecoAluno] [varchar](100) NULL,
	[setor] [varchar](100) NULL,
	[numero] [int] NULL,
	[cep] [varchar](50) NULL,
	[Senha] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[aluno_turma]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aluno_turma](
	[id_aluno] [int] NOT NULL,
	[id_turma] [int] NOT NULL,
 CONSTRAINT [PK_aluno_turma] PRIMARY KEY CLUSTERED 
(
	[id_aluno] ASC,
	[id_turma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diario]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Disciplina] [int] NULL,
	[Id_Professor] [int] NULL,
	[Id_Aluno] [int] NULL,
	[Id_Plano_de_Aula] [int] NULL,
	[Id_Turma] [int] NULL,
	[Id_Nota] [int] NULL,
	[Id_Agente] [int] NULL,
 CONSTRAINT [PK__Diario__3214EC07CDEF6322] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disciplina]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeDisciplina] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Frequencia]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Frequencia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aluno] [int] NULL,
	[Apontamento] [bit] NULL,
	[Data] [datetime] NULL,
	[Id_diario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nota]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nota](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aluno] [int] NULL,
	[Id_Turma] [int] NULL,
	[notaAluno] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ocorrencia]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ocorrencia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aluno] [int] NULL,
	[Descricao] [varchar](100) NULL,
	[Id_Diario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanoDeAula]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanoDeAula](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_professor] [int] NULL,
	[Conteudo] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeProfessor] [varchar](100) NULL,
	[CPF_Professor] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Telefone] [varchar](50) NULL,
	[DataDeNascimento] [varchar](50) NULL,
	[sexo] [varchar](50) NULL,
	[CidadeProfessor] [varchar](100) NULL,
	[UF] [varchar](50) NULL,
	[EnderecoProfessor] [varchar](100) NULL,
	[setor] [varchar](100) NULL,
	[cep] [varchar](50) NULL,
	[Senha] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turma]    Script Date: 30/05/2022 21:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Periodo] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[aluno_turma]  WITH CHECK ADD  CONSTRAINT [FK_aluno_turma_Aluno] FOREIGN KEY([id_aluno])
REFERENCES [dbo].[Aluno] ([Id])
GO
ALTER TABLE [dbo].[aluno_turma] CHECK CONSTRAINT [FK_aluno_turma_Aluno]
GO
ALTER TABLE [dbo].[aluno_turma]  WITH CHECK ADD  CONSTRAINT [FK_aluno_turma_Turma] FOREIGN KEY([id_turma])
REFERENCES [dbo].[Turma] ([Id])
GO
ALTER TABLE [dbo].[aluno_turma] CHECK CONSTRAINT [FK_aluno_turma_Turma]
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD  CONSTRAINT [FK_Diario_AgentePedagogico] FOREIGN KEY([Id_Agente])
REFERENCES [dbo].[AgentePedagogico] ([Id])
GO
ALTER TABLE [dbo].[Diario] CHECK CONSTRAINT [FK_Diario_AgentePedagogico]
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD  CONSTRAINT [FK_Diario_Disciplina] FOREIGN KEY([Id_Disciplina])
REFERENCES [dbo].[Disciplina] ([Id])
GO
ALTER TABLE [dbo].[Diario] CHECK CONSTRAINT [FK_Diario_Disciplina]
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD  CONSTRAINT [FK_Diario_Nota] FOREIGN KEY([Id_Nota])
REFERENCES [dbo].[Nota] ([Id])
GO
ALTER TABLE [dbo].[Diario] CHECK CONSTRAINT [FK_Diario_Nota]
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD  CONSTRAINT [FK_Diario_PlanoDeAula] FOREIGN KEY([Id_Plano_de_Aula])
REFERENCES [dbo].[PlanoDeAula] ([Id])
GO
ALTER TABLE [dbo].[Diario] CHECK CONSTRAINT [FK_Diario_PlanoDeAula]
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD  CONSTRAINT [FK_Diario_Professor] FOREIGN KEY([Id_Professor])
REFERENCES [dbo].[Professor] ([Id])
GO
ALTER TABLE [dbo].[Diario] CHECK CONSTRAINT [FK_Diario_Professor]
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD  CONSTRAINT [FK_Diario_Turma] FOREIGN KEY([Id_Turma])
REFERENCES [dbo].[Turma] ([Id])
GO
ALTER TABLE [dbo].[Diario] CHECK CONSTRAINT [FK_Diario_Turma]
GO
ALTER TABLE [dbo].[Frequencia]  WITH CHECK ADD  CONSTRAINT [FK_Frequencia_Aluno] FOREIGN KEY([Id_Aluno])
REFERENCES [dbo].[Aluno] ([Id])
GO
ALTER TABLE [dbo].[Frequencia] CHECK CONSTRAINT [FK_Frequencia_Aluno]
GO
ALTER TABLE [dbo].[Frequencia]  WITH CHECK ADD  CONSTRAINT [FK_Frequencia_Diario] FOREIGN KEY([Id_diario])
REFERENCES [dbo].[Diario] ([Id])
GO
ALTER TABLE [dbo].[Frequencia] CHECK CONSTRAINT [FK_Frequencia_Diario]
GO
ALTER TABLE [dbo].[Nota]  WITH CHECK ADD  CONSTRAINT [FK_Nota_Aluno] FOREIGN KEY([Id_Aluno])
REFERENCES [dbo].[Aluno] ([Id])
GO
ALTER TABLE [dbo].[Nota] CHECK CONSTRAINT [FK_Nota_Aluno]
GO
ALTER TABLE [dbo].[Nota]  WITH CHECK ADD  CONSTRAINT [FK_Nota_Turma] FOREIGN KEY([Id_Turma])
REFERENCES [dbo].[Turma] ([Id])
GO
ALTER TABLE [dbo].[Nota] CHECK CONSTRAINT [FK_Nota_Turma]
GO
ALTER TABLE [dbo].[Ocorrencia]  WITH CHECK ADD  CONSTRAINT [FK_Ocorrencia_Diario] FOREIGN KEY([Id_Diario])
REFERENCES [dbo].[Diario] ([Id])
GO
ALTER TABLE [dbo].[Ocorrencia] CHECK CONSTRAINT [FK_Ocorrencia_Diario]
GO
ALTER TABLE [dbo].[PlanoDeAula]  WITH CHECK ADD  CONSTRAINT [FK_PlanoDeAula_Professor] FOREIGN KEY([Id_professor])
REFERENCES [dbo].[Professor] ([Id])
GO
ALTER TABLE [dbo].[PlanoDeAula] CHECK CONSTRAINT [FK_PlanoDeAula_Professor]
GO
USE [master]
GO
ALTER DATABASE [BancoDiarioEletronico] SET  READ_WRITE 
GO
