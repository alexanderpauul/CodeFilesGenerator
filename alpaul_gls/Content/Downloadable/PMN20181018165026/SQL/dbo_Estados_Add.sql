USE PMN
GO

CREATE PROCEDURE dbo.Estados_Add
(
       @EstadoId int, @TEstadoId int, @DscEstado nvarchar, @Habilitado bit, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Estados
	            (
				 EstadoId, TEstadoId, DscEstado, Habilitado, Registro, Modificacion, Identificador, UsuarioId
				)
		 VALUES (
		         @EstadoId, @TEstadoId, @DscEstado, @Habilitado, @Registro, @Modificacion, @Identificador, @UsuarioId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH