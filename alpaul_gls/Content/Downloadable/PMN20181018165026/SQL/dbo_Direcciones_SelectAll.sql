USE PMN
GO

CREATE PROCEDURE dbo.Direcciones_GetAll
AS
	SELECT DireccionId, PersonaId, PaisId, ProvinciaId, MunicipioId, SectorId, DscDireccion, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Direcciones