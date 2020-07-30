CREATE TABLE [dbo].[Inventario]
(
	[IdInventario] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdProducto] INT NOT NULL, 
    [CantAgregada] INT NULL, 
    [CantInicial] INT NULL, 
    [CantFinal] INT NULL, 
    [Fecha] DATETIME NULL, 
    [IdUsuario] INT NOT NULL, 
    CONSTRAINT [FK_Inventario_Producto] FOREIGN KEY ([IdProducto]) REFERENCES [Producto]([IdProducto]), 
    CONSTRAINT [FK_Inventario_Usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([IdUsuario])
)
