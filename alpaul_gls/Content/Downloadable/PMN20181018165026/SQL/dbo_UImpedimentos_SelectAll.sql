USE PMN
GO

CREATE PROCEDURE dbo.UImpedimentos_GetAll
AS
	SELECT Id, ImpedimentoId, UniversidadId, Referencia, Variable, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.UImpedimentos