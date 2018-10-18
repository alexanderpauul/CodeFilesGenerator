USE PMN
GO

CREATE PROCEDURE dbo.Universidades_GetAll
AS
	SELECT UniversidadId, DscUniversidad, Email, Telefono, Fax, SitioWeb, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Universidades