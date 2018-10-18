USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUserRoles_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT UserId, RoleId 
	  FROM dbo.AspNetUserRoles 
	 WHERE UserId = @value