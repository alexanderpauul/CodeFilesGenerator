USE PMN
GO

CREATE PROCEDURE dbo.AspNetUserClaims_GetAll
AS
	SELECT Id, UserId, ClaimType, ClaimValue 
	  FROM dbo.AspNetUserClaims