USE PMN
GO

CREATE PROCEDURE dbo.UImpedimentos_Add
(
       @Id int, @ImpedimentoId int, @UniversidadId int, @Referencia nvarchar, @Variable nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.UImpedimentos
	            (
				 Id, ImpedimentoId, UniversidadId, Referencia, Variable, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @Id, @ImpedimentoId, @UniversidadId, @Referencia, @Variable, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH