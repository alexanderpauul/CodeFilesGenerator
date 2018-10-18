USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUserRoles_Add
(
       @UserId nvarchar, @RoleId nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.AspNetUserRoles
	            (
				 UserId, RoleId
				)
		 VALUES (
		         @UserId, @RoleId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH