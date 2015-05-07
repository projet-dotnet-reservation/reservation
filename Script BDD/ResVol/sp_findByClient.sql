USE [ResVol]
GO

DROP PROCEDURE [dbo].[sp_findByClient]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByClient]    Script Date: 07/05/2015 15:28:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Adrian Fraisse
-- Create date: 07/05/2015
-- Description:	Crée une reservation.
-- =============================================
CREATE PROCEDURE [dbo].[sp_findByClient]
	@mail nchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM CmdVols WHERE mailClient = @mail;
END

GO

