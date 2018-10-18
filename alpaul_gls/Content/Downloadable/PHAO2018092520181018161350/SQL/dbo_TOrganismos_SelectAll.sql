USE PHAO20180925
GO

CREATE PROCEDURE dbo.TOrganismos_GetAll
AS
	SELECT TOrganismoId, DscTOrganismo, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.TOrganismos