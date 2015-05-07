USE [ResVol]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByRouteAndDeparture]    Script Date: 07/05/2015 15:34:19 ******/
DROP PROCEDURE [dbo].[sp_storeReservation]
GO

/****** Object:  StoredProcedure [dbo].[sp_storeReservation]    Script Date: 07/05/2015 15:28:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Adrian Fraisse
-- Create date: 07/05/2015
-- Description:	Crée une reservation.
-- =============================================
CREATE PROCEDURE [dbo].[sp_storeReservation]
	@mail nchar(50),
	@idVol int
AS
BEGIN
	INSERT INTO CmdVols(mailClient, idVol) VALUES (@mail, @idVol);
END

GO

