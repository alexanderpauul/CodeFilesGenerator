USE PMN
GO

CREATE PROCEDURE dbo.Estados_Edit
(
       @EstadoId int, @TEstadoId int, @DscEstado nvarchar, @Habilitado bit, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Estados 
		   SET EstadoId = @EstadoId, TEstadoId = @TEstadoId, DscEstado = @DscEstado, Habilitado = @Habilitado, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId
		 WHERE EstadoId = @EstadoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH