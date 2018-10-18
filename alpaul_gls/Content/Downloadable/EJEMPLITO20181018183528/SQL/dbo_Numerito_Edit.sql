USE EJEMPLITO
GO

CREATE PROCEDURE dbo.Numerito_Edit
(
       @NumeritoId int, @Numero nvarchar, @Fecha date, @Fecha2 datetime, @Identificador nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Numerito 
		   SET NumeritoId = @NumeritoId, Numero = @Numero, Fecha = @Fecha, Fecha2 = @Fecha2, Identificador = @Identificador
		 WHERE NumeritoId = @NumeritoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH