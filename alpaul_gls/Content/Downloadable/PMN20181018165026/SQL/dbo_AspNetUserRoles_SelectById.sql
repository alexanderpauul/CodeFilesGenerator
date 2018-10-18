USE PMN
GO

CREATE PROCEDURE dbo.AspNetUserRoles_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT UserId, RoleId 
	  FROM dbo.AspNetUserRoles 
	 WHERE UserId = @value