CREATE TABLE [dbo].[DetallePedido]
(
	[IdDetallePedido] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdProducto] INT NOT NULL, 
    [Cantidad] INT NULL, 
    [PrecioUnitario] NUMERIC(18, 2) NULL, 
    [IdPedido] INT NOT NULL 
)
