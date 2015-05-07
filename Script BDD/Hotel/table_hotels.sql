USE [Hotel]
GO

/****** Object:  Table [dbo].[Hotels]    Script Date: 07/05/2015 15:39:26 ******/
DROP TABLE [dbo].[Hotels]
GO

/****** Object:  Table [dbo].[Hotels]    Script Date: 07/05/2015 15:39:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Hotels](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nchar](50) NOT NULL,
	[ville] [nchar](50) NOT NULL,
	[debutDispo] [date] NULL,
	[finDispo] [date] NULL,
 CONSTRAINT [PK_Hotels] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

