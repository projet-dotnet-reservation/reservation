USE [Vol]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByRoute]    Script Date: 07/05/2015 15:30:37 ******/
DROP PROCEDURE [dbo].[sp_findByRoute]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByRoute]    Script Date: 07/05/2015 15:30:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Adrian
-- Create date: 07/05/2015
-- Description:	Retourne une liste vols compatibles avec l'itinéraire.
-- =============================================
CREATE PROCEDURE [dbo].[sp_findByRoute]
	@departure nchar(50),
	@arrival nchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Vols WHERE villeDepart = @departure AND villeArrivee = @arrival;
END

GO

