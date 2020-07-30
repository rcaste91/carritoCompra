CREATE TABLE [dbo].[LogTransacciones]
(
	[IdLog] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdPedido] INT NOT NULL, 
    [FechaTransaccion] DATETIME NULL, 
    [Respuesta] NVARCHAR(MAX) NULL, 
    [CodigoRespuesta] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_LogTransacciones_Pedido] FOREIGN KEY ([IdPedido]) REFERENCES [Pedidos]([IdPedido])
)
