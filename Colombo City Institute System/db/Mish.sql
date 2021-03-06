USE [Mish]
GO
/****** Object:  Table [dbo].[AssignmentInfo]    Script Date: 3/19/2020 4:09:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssignmentInfo](
	[SID] [varchar](50) NULL,
	[Sname] [varchar](50) NULL,
	[Grade] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[AID] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentInfo]    Script Date: 3/19/2020 4:09:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInfo](
	[StudentID] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Date] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[NIC] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[ProgramName] [varchar](50) NULL,
	[BatchName] [varchar](50) NULL,
	[SubName] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 3/19/2020 4:09:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserID] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
	[UserType] [varchar](50) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
