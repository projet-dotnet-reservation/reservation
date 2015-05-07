USE [ResHotel]
GO

DROP PROCEDURE [dbo].[sp_storeReservation]
GO

/****** Object:  StoredProcedure [dbo].[sp_storeReservation]    Script Date: 07/05/2015 15:29:44 ******/
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
	@hotelId int,
	@mail nchar(50),
	@startDate date,
	@endDate date
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO CmdHotels(mailClient, idHotel, dateDebut, dateFin) 
	VALUES (@mail, @hotelId, @startDate, @endDate);
END

GO

