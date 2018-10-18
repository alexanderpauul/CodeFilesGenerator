USE PMN
GO

CREATE PROCEDURE dbo.Programas_Edit
(
       @ProgramaId int, @TProgramaId int, @Codigo nvarchar, @DscPrograma nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Programas 
		   SET ProgramaId = @ProgramaId, TProgramaId = @TProgramaId, Codigo = @Codigo, DscPrograma = @DscPrograma, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE ProgramaId = @ProgramaId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH