USE PMN
GO

CREATE PROCEDURE dbo.Universidades_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT UniversidadId, DscUniversidad, Email, Telefono, Fax, SitioWeb, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Universidades 
	 WHERE UniversidadId = @value