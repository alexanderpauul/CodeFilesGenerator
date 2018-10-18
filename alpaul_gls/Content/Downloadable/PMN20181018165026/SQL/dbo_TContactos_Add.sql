USE PMN
GO

CREATE PROCEDURE dbo.TContactos_Add
(
       @TContactoId int, @DscTContacto nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TContactos
	            (
				 TContactoId, DscTContacto, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @TContactoId, @DscTContacto, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH