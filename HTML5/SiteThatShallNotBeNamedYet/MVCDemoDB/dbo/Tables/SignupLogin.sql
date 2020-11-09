CREATE TABLE [dbo].[SignupLogin]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [userid] INT NOT NULL, 
    [first_name] NVARCHAR(50) NOT NULL, 
    [last_name] NVARCHAR(50) NOT NULL, 
    [email_address] NVARCHAR(50) NOT NULL
)
