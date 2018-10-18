USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUserClaims_GetAll
AS
	SELECT Id, UserId, ClaimType, ClaimValue 
	  FROM dbo.AspNetUserClaims