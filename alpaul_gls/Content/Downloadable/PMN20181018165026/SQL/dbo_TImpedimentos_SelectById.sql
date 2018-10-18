USE PMN
GO

CREATE PROCEDURE dbo.TImpedimentos_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT TImpedimentoId, DscTImpedimento, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TImpedimentos 
	 WHERE TImpedimentoId = @value