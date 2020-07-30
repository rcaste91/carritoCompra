CREATE TABLE [dbo].[PedidosCliente]
(
	[IdCliente] INT NOT NULL , 
    [IdPedido] INT NOT NULL, 
    CONSTRAINT [PK_PedidosCliente] PRIMARY KEY ([IdCliente], [IdPedido])
)
