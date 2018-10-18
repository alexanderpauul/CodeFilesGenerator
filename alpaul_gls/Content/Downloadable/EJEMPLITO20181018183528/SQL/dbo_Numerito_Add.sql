USE EJEMPLITO
GO

CREATE PROCEDURE dbo.Numerito_Add
(
       @NumeritoId int, @Numero nvarchar, @Fecha date, @Fecha2 datetime, @Identificador nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Numerito
	            (
				 NumeritoId, Numero, Fecha, Fecha2, Identificador
				)
		 VALUES (
		         @NumeritoId, @Numero, @Fecha, @Fecha2, @Identificador
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH