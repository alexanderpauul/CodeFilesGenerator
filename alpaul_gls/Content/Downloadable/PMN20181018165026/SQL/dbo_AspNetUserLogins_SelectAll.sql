USE PMN
GO

CREATE PROCEDURE dbo.AspNetUserLogins_GetAll
AS
	SELECT LoginProvider, ProviderKey, UserId 
	  FROM dbo.AspNetUserLogins