USE [ResVol]
GO

/****** Object:  Table [dbo].[CmdVols]    Script Date: 07/05/2015 15:27:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CmdVols](
	[mailClient] [nchar](50) NOT NULL,
	[idVol] [int] NOT NULL,
	[classe] [numeric](1, 0) NULL
) ON [PRIMARY]

GO

