USE [ResHotel]
GO

/****** Object:  Table [dbo].[CmdHotels]    Script Date: 07/05/2015 15:29:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CmdHotels](
	[mailClient] [nchar](50) NOT NULL,
	[idHotel] [int] NOT NULL,
	[dateDebut] [date] NOT NULL,
	[dateFin] [date] NOT NULL
) ON [PRIMARY]

GO

