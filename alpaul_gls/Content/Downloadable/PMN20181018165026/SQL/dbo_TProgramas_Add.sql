USE PMN
GO

CREATE PROCEDURE dbo.TProgramas_Add
(
       @TProgramaId int, @Codigo nvarchar, @DscTProgramaId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TProgramas
	            (
				 TProgramaId, Codigo, DscTProgramaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @TProgramaId, @Codigo, @DscTProgramaId, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH