CREATE TABLE [dbo].[Producto]
(
	[IdProducto] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Descripcion] NVARCHAR(100) NULL, 
    [Precio] NUMERIC(18, 2) NULL, 
    [CantMaxima] INT NULL, 
    [IdCategoria] INT NOT NULL, 
    [Estado] CHAR(1) NULL, 
    [Existencia] INT NULL, 
    CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY ([IdCategoria]) REFERENCES [Categoria]([IdCategoria])
)
