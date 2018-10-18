USE PHAO20180925
GO

CREATE PROCEDURE dbo.TOrganismos_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT TOrganismoId, DscTOrganismo, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.TOrganismos 
	 WHERE TOrganismoId = @valueUSE PHAO20180925
GO

CREATE PROCEDURE dbo.TOrganismos_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT TOrganismoId, DscTOrganismo, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.TOrganismos 
	 WHERE TOrganismoId = @value