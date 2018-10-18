USE PMN
GO

CREATE PROCEDURE dbo.TEstados_Add
(
       @TEstadoId int, @DscTEstado nvarchar, @Habilitado bit, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TEstados
	            (
				 TEstadoId, DscTEstado, Habilitado, Registro, Modificacion, Identificador, UsuarioId
				)
		 VALUES (
		         @TEstadoId, @DscTEstado, @Habilitado, @Registro, @Modificacion, @Identificador, @UsuarioId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH