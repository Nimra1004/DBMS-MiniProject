USE [master]
GO
/****** Object:  Database [ProjectA]    Script Date: 5/2/2019 3:26:36 PM ******/
CREATE DATABASE [ProjectA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ProjectA.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProjectA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ProjectA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProjectA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectA] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjectA] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProjectA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ProjectA]
GO
/****** Object:  Table [dbo].[Advisor]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advisor](
	[Id] [int] NOT NULL,
	[Salary] [decimal](18, 0) NULL,
	[Designation] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evaluation]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evaluation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[TotalMarks] [int] NOT NULL,
	[TotalWeightage] [int] NOT NULL,
 CONSTRAINT [PK_Evaluation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created_On] [date] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupEvaluation]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupEvaluation](
	[GroupId] [int] NOT NULL,
	[EvaluationId] [int] NOT NULL,
	[ObtainedMarks] [int] NOT NULL,
	[EvaluationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupEvaluation] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[EvaluationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupProject]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProject](
	[ProjectId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupProject] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupStudent]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupStudent](
	[GroupId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupStudent] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lookup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NULL,
	[Contact] [varchar](20) NULL,
	[Email] [varchar](30) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectAdvisor]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAdvisor](
	[AdvisorId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[AdvisorRole] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProjectAdvisor] PRIMARY KEY CLUSTERED 
(
	[AdvisorId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[RegistrationNo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Advisor_in_project]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Advisor_in_project] AS
SELECT P.Title AS Project, A.FirstName + A.LastName AS AdvisorName
  FROM [ProjectA].[dbo].[Project] P INNER JOIN [ProjectAdvisor] PA ON PA.ProjectId = P.Id INNER JOIN Person  A ON A.Id = PA.AdvisorId 

GO
/****** Object:  View [dbo].[Advisor_Not_in_project]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Advisor_Not_in_project] AS
SELECT L.Value AS Designation, P.FirstName + P.LastName AS Name
  FROM [ProjectA].[dbo].[Advisor] A INNER JOIN Person P ON P.Id = A.Id INNER JOIN Lookup L ON L.Id = A.Designation AND L.Category = 'DESIGNATION'
  WHERE A.[Id] NOT IN 
  (SELECT AdvisorId FROM [ProjectAdvisor]);
GO
/****** Object:  View [dbo].[Count_Of_project]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Count_Of_project] AS
 SELECT Count(PA.ProjectId) AS ProjectCount, PA.AdvisorId
  FROM [ProjectAdvisor] PA 
  GROUP BY PA.AdvisorId
GO
/****** Object:  View [dbo].[Students_supervised]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Students_supervised] AS
 SELECT  A.FirstName + A.LastName AS AdvisorName, S.RegistrationNo
 FROM [ProjectA].[dbo].[GroupProject] P INNER JOIN [ProjectAdvisor] PA ON PA.ProjectId = P.ProjectId INNER JOIN Person  A ON A.Id = PA.AdvisorId INNER JOIN GroupStudent GS ON GS.GroupId = P.GroupId INNER JOIN Student S ON S.Id = GS.StudentId 
 WHERE PA.AdvisorId IN 
(SELECT A.AdvisorId
  FROM [ProjectAdvisor] A
  GROUP BY A.AdvisorId
  )
GO
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (23, CAST(70000 AS Decimal(18, 0)), 7)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (24, CAST(600000 AS Decimal(18, 0)), 10)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (51, CAST(10000000 AS Decimal(18, 0)), 6)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (42, CAST(500000 AS Decimal(18, 0)), 6)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (43, CAST(250000 AS Decimal(18, 0)), 6)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (44, CAST(4500000 AS Decimal(18, 0)), 8)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (45, CAST(4552222 AS Decimal(18, 0)), 8)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (53, CAST(152013652 AS Decimal(18, 0)), 7)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (47, CAST(850000 AS Decimal(18, 0)), 8)
INSERT [dbo].[Advisor] ([Id], [Salary], [Designation]) VALUES (48, CAST(4500000 AS Decimal(18, 0)), 7)
SET IDENTITY_INSERT [dbo].[Evaluation] ON 

INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (1, N'Dbms', 100, 86)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (4, N'Data Minning', 100, 85)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (6, N'FTGF', 1000, 586)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (8, N'Electromegnetism', 100, 200)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (10, N'Final Term Presentation', 50, 30)
SET IDENTITY_INSERT [dbo].[Evaluation] OFF
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (1, CAST(N'2019-03-25' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (30, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (31, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (32, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (33, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (34, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (37, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (40, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (41, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (42, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (43, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (44, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (45, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (46, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (47, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (48, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (49, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (50, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (51, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (52, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (53, CAST(N'2019-03-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (54, CAST(N'2019-03-27' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (55, CAST(N'2019-03-27' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (56, CAST(N'2019-03-27' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (57, CAST(N'2019-03-27' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (60, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (61, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (62, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (63, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (64, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (65, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (66, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (67, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (68, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (69, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (70, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (71, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (72, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (73, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (74, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (75, CAST(N'2019-04-25' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (76, CAST(N'2019-04-25' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (77, CAST(N'2019-04-25' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (78, CAST(N'2019-04-25' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (79, CAST(N'2019-04-26' AS Date))
SET IDENTITY_INSERT [dbo].[Group] OFF
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (1, 1, 56, CAST(N'2019-03-27 04:39:26.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (1, 4, 50, CAST(N'2019-03-27 04:44:37.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (30, 1, 56, CAST(N'2019-03-27 03:16:36.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (30, 4, 45, CAST(N'2019-03-28 02:19:01.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (30, 8, 44, CAST(N'2019-03-28 02:21:13.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (31, 4, 45, CAST(N'2019-03-28 02:28:58.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (31, 6, 45, CAST(N'2019-03-06 02:22:01.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (33, 10, 40, CAST(N'2009-01-05 23:30:21.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (15, 1, CAST(N'2019-03-26 10:45:49.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (16, 30, CAST(N'2019-03-26 23:54:18.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (18, 32, CAST(N'2019-03-26 10:48:08.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1, 31, 4, CAST(N'2019-03-27 02:40:07.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1, 36, 3, CAST(N'2019-03-26 10:15:30.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1, 37, 3, CAST(N'2019-03-28 03:02:28.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (30, 30, 4, CAST(N'2019-03-27 02:42:09.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (30, 32, 3, CAST(N'2019-03-26 11:04:04.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (31, 33, 4, CAST(N'2019-03-26 11:04:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (31, 35, 3, CAST(N'2019-03-27 02:42:14.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (31, 41, 3, CAST(N'2019-04-25 23:49:49.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (32, 34, 3, CAST(N'2019-03-27 00:12:18.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (32, 52, 3, CAST(N'2019-04-26 00:53:26.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (75, 50, 3, CAST(N'2019-04-25 23:29:33.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Lookup] ON 

INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (1, N'Male', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (2, N'Female', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (3, N'Active', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (4, N'InActive', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (6, N'Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (7, N'Associate Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (8, N'Assisstant Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (9, N'Lecturer', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (10, N'Industry Professional', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (11, N'Main Advisor', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (12, N'Co-Advisror', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (14, N'Industry Advisor', N'ADVISOR_ROLE')
SET IDENTITY_INSERT [dbo].[Lookup] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (23, N'Mam Saher', N'Waqqar', N'03365894756', N'sahar.uet@gmail.com', CAST(N'1990-07-07 05:04:51.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (24, N'samyan', N'Qayyum', N'03365896147', N'sammyan.uet@gmail.com', CAST(N'2009-03-15 07:49:29.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (30, N'nimra', N'yaseenbg', N'03317652314', N'nimra2@gmail.com', CAST(N'2019-03-30 11:59:20.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (31, N'Aqsa', N'Zahid', N'03317685258', N'aqsa@gmail.com', CAST(N'1998-02-16 10:55:03.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (32, N'sadia', N'amjad', N'03325478596', N'sadia@gmail.com', CAST(N'1998-06-18 10:57:09.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (33, N'iqra', N'kanwal', N'03317479601', N'iqra@gmail.com', CAST(N'1998-06-23 11:02:09.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (34, N'Umar', N'farooq', N'03336216982', N'umar5498@gmail.com', CAST(N'2009-06-18 23:19:50.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (35, N'anum ', N'yaseen', N'03173719477', N'anumyaseen@gmail.com', CAST(N'2019-03-25 23:23:51.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (36, N'mahm', N'yaseen', N'03041576703', N'mahamyaseen@gmail.com', CAST(N'1996-03-25 23:27:16.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (37, N'Mehwish', N'Naseem', N'03365896258', N'mehwish@gmail.com', CAST(N'2013-01-01 07:04:07.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (39, N'Samra', N'Ismail', N'03317479601', N'samra@gmail.com', CAST(N'1998-10-28 05:21:02.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (40, N'Syeda Sania', N'Aziz', N'03365896123', N'sania@gmail.com', CAST(N'2019-03-31 05:24:12.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (41, N'Farah', N'Zahid', N'03365214589', N'Farah@gmail.com', CAST(N'2009-02-27 05:29:20.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (42, N'Mam Hina', N'Khalid', N'03317584758', N'Samra@gmail.com', CAST(N'1993-12-02 06:04:44.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (43, N'Samra', N'Akram', N'03362547896', N'samra@gmail.com', CAST(N'2010-02-10 06:07:15.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (44, N'hina', N'Khalid', N'03357415896', N'hina@gmail.com', CAST(N'2019-03-31 06:08:41.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (45, N' Zuha', N' khalid', N'03354891247', N'zuha@gmail.com', CAST(N'2008-12-29 06:14:33.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (47, N'shahida', N'yaseen', N'03365478978', N'shahida@gmail.com', CAST(N'2019-03-31 06:19:38.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (48, N'Fareeha', N'Qayyum', N'03354125369', N'Fareeha@gmail.com', CAST(N'2019-03-31 06:23:52.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (49, N'Maham', N'Yaseen', N'03041576703', N'mahamyaseen123@gmail.com', CAST(N'1998-10-11 12:06:04.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (50, N'Anum', N'Yaseen', N'03163719177', N'mahamyaseen123@gmail.com', CAST(N'1994-01-30 12:07:07.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (51, N'Hina', N'Khalid', N'03375484568', N'hina@gmail.com', CAST(N'1990-01-29 12:08:57.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (52, N'Animra', N'Yaseen', N'03317479601', N'nimrayaseen@gmail.com', CAST(N'1998-10-05 00:51:28.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (53, N'BAqsa', N'Zahid', N'03317653847', N'aqsa938@gmail.com', CAST(N'2008-12-29 00:52:18.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (15, N'FYP project', N'Automatic Home')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (16, N'Minning', N'Data ')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (18, N'Bgt', N'Gty')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (22, N'Migration Of data from SQl to non Sql', N'DataBase Conversion')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (23, N'ghjg
', N'ghjg')
SET IDENTITY_INSERT [dbo].[Project] OFF
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (23, 15, 12, CAST(N'2019-03-27 00:41:34.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (24, 16, 11, CAST(N'2019-03-27 00:46:18.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (42, 15, 12, CAST(N'2019-04-26 01:01:21.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (30, N'2016-CE-67')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (31, N'2016-CS-256')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (32, N'2016-CE-68')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (33, N'2016-ce-69')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (34, N'2016-cs-789')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (35, N'2016-Cs-456')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (36, N'2016-cS-248')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (37, N'2016-Cs-789')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (39, N'2016-CE-89')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (40, N'2016-CE-789')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (41, N'2016-CE_456')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (49, N'2015-CE-98')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (50, N'2014-CS-256')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (52, N'2016-CE-89')
ALTER TABLE [dbo].[Advisor]  WITH CHECK ADD  CONSTRAINT [FK__Advisor__PersonI__403A8C7D] FOREIGN KEY([Id])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Advisor] CHECK CONSTRAINT [FK__Advisor__PersonI__403A8C7D]
GO
ALTER TABLE [dbo].[Advisor]  WITH CHECK ADD  CONSTRAINT [FK_Advisor_Lookup] FOREIGN KEY([Designation])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Advisor] CHECK CONSTRAINT [FK_Advisor_Lookup]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Evaluation] FOREIGN KEY([EvaluationId])
REFERENCES [dbo].[Evaluation] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Evaluation]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Project]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_GroupStudents_Lookup] FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_GroupStudents_Lookup]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Group]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Student]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Lookup] FOREIGN KEY([Gender])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Lookup] FOREIGN KEY([AdvisorRole])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Project]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([Id])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
/****** Object:  StoredProcedure [dbo].[Mark_Evaluation]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mark_Evaluation] @GroupId int
  AS
  BEGIN
  SELECT E.Name, E.TotalMarks, GE.ObtainedMarks 
  FROM  GroupEvaluation GE
  INNER JOIN Evaluation E ON E.Id = GE.EvaluationId 
  WHERE GE.GroupId = @GroupId
  END
GO
/****** Object:  StoredProcedure [dbo].[Student_supervised_procedure]    Script Date: 5/2/2019 3:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Student_supervised_procedure] @AdvisorName nvarchar(30)
  AS
  BEGIN
  SELECT  O.FirstName + O.LastName AS Name, S.RegistrationNo, S.Id, GS.GroupId
 FROM [ProjectA].[dbo].[GroupProject] P INNER JOIN [ProjectAdvisor] PA ON PA.ProjectId = P.ProjectId INNER JOIN GroupStudent GS ON GS.GroupId = P.GroupId INNER JOIN Person G ON G.Id = PA.AdvisorId  INNER JOIN Student S ON S.Id = GS.StudentId INNER JOIN Person O ON O.Id = S.Id
 WHERE G.FirstName = @AdvisorName
 END
GO
USE [master]
GO
ALTER DATABASE [ProjectA] SET  READ_WRITE 
GO
