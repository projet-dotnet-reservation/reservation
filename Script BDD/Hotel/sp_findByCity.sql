USE [Hotel]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByCity]    Script Date: 07/05/2015 15:39:41 ******/
DROP PROCEDURE [dbo].[sp_findByCity]
GO

/****** Object:  StoredProcedure [dbo].[sp_findByCity]    Script Date: 07/05/2015 15:39:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_findByCity]
	@city nchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Hotels where ville = @city;
END

GO

