USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUserRoles_GetAll
AS
	SELECT UserId, RoleId 
	  FROM dbo.AspNetUserRoles