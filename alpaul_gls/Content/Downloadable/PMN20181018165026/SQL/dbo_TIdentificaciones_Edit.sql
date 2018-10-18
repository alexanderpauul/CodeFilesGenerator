USE PMN
GO

CREATE PROCEDURE dbo.TIdentificaciones_Edit
(
       @TIdentificacionId int, @DscTIdentificacion nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TIdentificaciones 
		   SET TIdentificacionId = @TIdentificacionId, DscTIdentificacion = @DscTIdentificacion, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE TIdentificacionId = @TIdentificacionId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH