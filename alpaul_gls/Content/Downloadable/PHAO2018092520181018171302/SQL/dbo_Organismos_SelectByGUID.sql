USE PHAO20180925
GO

CREATE PROCEDURE dbo.Organismos_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT OrganismoId, DscOrganismo, Sigla, URL, TOrganismoId, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.Organismos 
	 WHERE OrganismoId = @valueUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Organismos_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT OrganismoId, DscOrganismo, Sigla, URL, TOrganismoId, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.Organismos 
	 WHERE OrganismoId = @value