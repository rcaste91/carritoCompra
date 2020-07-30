CREATE TABLE [dbo].[Cliente] (
    [IdCliente] INT            NOT NULL IDENTITY,
    [Nombre]    NVARCHAR (100) NULL,
    [Apellido]  NVARCHAR (100) NULL,
    [Correo]    NVARCHAR (100) NULL,
    [Telefono]  INT            NULL,
    [Estado]    CHAR (1)       NULL,
    [IdUsuario] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([IdCliente] ASC), 
    CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([IdUsuario])
);

