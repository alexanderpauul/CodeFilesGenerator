USE PMN
GO

CREATE PROCEDURE dbo.Direcciones_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT DireccionId, PersonaId, PaisId, ProvinciaId, MunicipioId, SectorId, DscDireccion, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Direcciones 
	 WHERE DireccionId = @value