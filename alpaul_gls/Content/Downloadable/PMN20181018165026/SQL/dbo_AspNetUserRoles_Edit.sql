USE PMN
GO

CREATE PROCEDURE dbo.AspNetUserRoles_Edit
(
       @UserId nvarchar, @RoleId nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.AspNetUserRoles 
		   SET UserId = @UserId, RoleId = @RoleId
		 WHERE UserId = @UserId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH