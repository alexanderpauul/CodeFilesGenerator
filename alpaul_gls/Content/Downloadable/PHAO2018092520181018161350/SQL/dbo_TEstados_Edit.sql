USE PHAO20180925
GO

CREATE PROCEDURE dbo.TEstados_Edit
(
       @TEstadoId int, @DscTEstado nvarchar, @Habilitado bit, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TEstados 
		   SET TEstadoId = @TEstadoId, DscTEstado = @DscTEstado, Habilitado = @Habilitado, UserId = @UserId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador
		 WHERE TEstadoId = @TEstadoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH