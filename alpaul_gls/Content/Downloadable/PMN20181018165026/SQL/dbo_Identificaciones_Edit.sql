USE PMN
GO

CREATE PROCEDURE dbo.Identificaciones_Edit
(
       @IdentificacionId int, @DscIdentificacion nvarchar, @TIdentificacionId int, @PersonaId int, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Identificaciones 
		   SET IdentificacionId = @IdentificacionId, DscIdentificacion = @DscIdentificacion, TIdentificacionId = @TIdentificacionId, PersonaId = @PersonaId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE IdentificacionId = @IdentificacionId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH