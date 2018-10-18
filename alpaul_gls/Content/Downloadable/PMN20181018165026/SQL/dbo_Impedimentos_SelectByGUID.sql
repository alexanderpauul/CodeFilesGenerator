USE PMN
GO

CREATE PROCEDURE dbo.Impedimentos_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT ImpedimentoId, TImpedimentoId, DscImpedimento, Variable, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Impedimentos 
	 WHERE ImpedimentoId = @value