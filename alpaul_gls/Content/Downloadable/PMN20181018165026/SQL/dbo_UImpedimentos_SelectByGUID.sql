USE PMN
GO

CREATE PROCEDURE dbo.UImpedimentos_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT Id, ImpedimentoId, UniversidadId, Referencia, Variable, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.UImpedimentos 
	 WHERE Id = @value