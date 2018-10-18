USE PMN
GO

CREATE PROCEDURE dbo.UImpedimentos_Edit
(
       @Id int, @ImpedimentoId int, @UniversidadId int, @Referencia nvarchar, @Variable nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.UImpedimentos 
		   SET Id = @Id, ImpedimentoId = @ImpedimentoId, UniversidadId = @UniversidadId, Referencia = @Referencia, Variable = @Variable, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE Id = @Id

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH