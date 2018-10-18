USE PMN
GO

CREATE PROCEDURE dbo.TProgramas_Edit
(
       @TProgramaId int, @Codigo nvarchar, @DscTProgramaId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TProgramas 
		   SET TProgramaId = @TProgramaId, Codigo = @Codigo, DscTProgramaId = @DscTProgramaId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE TProgramaId = @TProgramaId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH