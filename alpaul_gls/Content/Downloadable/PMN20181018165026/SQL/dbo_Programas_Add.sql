USE PMN
GO

CREATE PROCEDURE dbo.Programas_Add
(
       @ProgramaId int, @TProgramaId int, @Codigo nvarchar, @DscPrograma nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Programas
	            (
				 ProgramaId, TProgramaId, Codigo, DscPrograma, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @ProgramaId, @TProgramaId, @Codigo, @DscPrograma, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH