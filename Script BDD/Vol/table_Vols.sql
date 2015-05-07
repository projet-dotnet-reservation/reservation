USE [Vol]
GO

/****** Object:  Table [dbo].[Vols]    Script Date: 07/05/2015 15:30:26 ******/
DROP TABLE [dbo].[Vols]
GO

/****** Object:  Table [dbo].[Vols]    Script Date: 07/05/2015 15:30:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vols](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[villeDepart] [nchar](50) NOT NULL,
	[villeArrivee] [nchar](50) NOT NULL,
	[dateDepart] [datetime] NOT NULL,
	[dateArrivee] [datetime] NOT NULL,
 CONSTRAINT [PK_Vols12] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

