USE PMN
GO

CREATE PROCEDURE dbo.AspNetRoles_GetAll
AS
	SELECT Id, Name 
	  FROM dbo.AspNetRoles