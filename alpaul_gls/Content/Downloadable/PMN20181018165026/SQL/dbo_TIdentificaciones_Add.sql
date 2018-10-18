USE PMN
GO

CREATE PROCEDURE dbo.TIdentificaciones_Add
(
       @TIdentificacionId int, @DscTIdentificacion nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TIdentificaciones
	            (
				 TIdentificacionId, DscTIdentificacion, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @TIdentificacionId, @DscTIdentificacion, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH