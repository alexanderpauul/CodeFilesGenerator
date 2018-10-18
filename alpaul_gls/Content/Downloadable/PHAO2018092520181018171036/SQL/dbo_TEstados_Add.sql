USE PHAO20180925
GO

CREATE PROCEDURE dbo.TEstados_Add
(
       @TEstadoId int, @DscTEstado nvarchar, @Habilitado bit, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TEstados
	            (
				 TEstadoId, DscTEstado, Habilitado, UserId, Registro, Modificacion, Identificador
				)
		 VALUES (
		         @TEstadoId, @DscTEstado, @Habilitado, @UserId, @Registro, @Modificacion, @Identificador
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH