USE [Vol]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByRouteAndDeparture]    Script Date: 07/05/2015 15:34:19 ******/
DROP PROCEDURE [dbo].[sp_findByRouteAndDeparture]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByRouteAndDeparture]    Script Date: 07/05/2015 15:34:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Adrian Fraisse
-- Create date: 07/05/2015
-- Description:	Trouve un vol pour un itinéraire et une date donnés
-- =============================================
CREATE PROCEDURE [dbo].[sp_findByRouteAndDeparture]
	@departure nchar(50),
	@arrival nchar(50),
	@date date
AS
BEGIN
	SET NOCOUNT ON;

    SELECT * FROM Vols WHERE DATEDIFF(day, dateDepart, @date) = 0
		AND villeDepart = @departure AND villeArrivee = @arrival
END

GO

