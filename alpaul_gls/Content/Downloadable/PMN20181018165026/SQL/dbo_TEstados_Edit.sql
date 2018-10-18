USE PMN
GO

CREATE PROCEDURE dbo.TEstados_Edit
(
       @TEstadoId int, @DscTEstado nvarchar, @Habilitado bit, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TEstados 
		   SET TEstadoId = @TEstadoId, DscTEstado = @DscTEstado, Habilitado = @Habilitado, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId
		 WHERE TEstadoId = @TEstadoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH