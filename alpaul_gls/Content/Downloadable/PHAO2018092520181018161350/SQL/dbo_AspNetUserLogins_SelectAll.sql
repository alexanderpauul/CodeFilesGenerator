USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUserLogins_GetAll
AS
	SELECT LoginProvider, ProviderKey, UserId 
	  FROM dbo.AspNetUserLogins