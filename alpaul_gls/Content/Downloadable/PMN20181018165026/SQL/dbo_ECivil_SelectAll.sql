USE PMN
GO

CREATE PROCEDURE dbo.ECivil_GetAll
AS
	SELECT ECivilId, DscECivil, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.ECivil