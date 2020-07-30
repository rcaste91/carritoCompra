CREATE TABLE [dbo].[Usuarios]
(
	[IdUsuario] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Rol] NVARCHAR(50) NULL, 
    [Estado] CHAR(1) NULL, 
    [Usuario] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL 
)
