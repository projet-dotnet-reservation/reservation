USE [ResHotel]
GO

DROP PROCEDURE [dbo].[sp_findByClient]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByClient]    Script Date: 07/05/2015 15:29:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Adrian Fraisse
-- Create date: 07/05/2015
-- Description:	Récupère toutes les résa
-- =============================================
CREATE PROCEDURE [dbo].[sp_findByClient]
	@mail nchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT * FROM CmdHotels WHERE mailClient = @mail;
END

GO

