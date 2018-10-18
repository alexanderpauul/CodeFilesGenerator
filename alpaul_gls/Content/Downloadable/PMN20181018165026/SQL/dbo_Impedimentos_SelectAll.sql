USE PMN
GO

CREATE PROCEDURE dbo.Impedimentos_GetAll
AS
	SELECT ImpedimentoId, TImpedimentoId, DscImpedimento, Variable, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Impedimentos