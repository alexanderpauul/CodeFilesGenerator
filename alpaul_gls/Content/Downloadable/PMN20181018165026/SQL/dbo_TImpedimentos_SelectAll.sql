USE PMN
GO

CREATE PROCEDURE dbo.TImpedimentos_GetAll
AS
	SELECT TImpedimentoId, DscTImpedimento, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TImpedimentos