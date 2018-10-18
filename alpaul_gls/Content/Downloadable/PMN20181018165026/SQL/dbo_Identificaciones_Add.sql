USE PMN
GO

CREATE PROCEDURE dbo.Identificaciones_Add
(
       @IdentificacionId int, @DscIdentificacion nvarchar, @TIdentificacionId int, @PersonaId int, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Identificaciones
	            (
				 IdentificacionId, DscIdentificacion, TIdentificacionId, PersonaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @IdentificacionId, @DscIdentificacion, @TIdentificacionId, @PersonaId, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH