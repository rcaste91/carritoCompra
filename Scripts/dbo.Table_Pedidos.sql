CREATE TABLE [dbo].[Pedidos] (
    [IdPedido]        INT             IDENTITY (1, 1) NOT NULL,
    [FechaPedido]     DATETIME        NULL,
    [EstadoEntrega]   NVARCHAR (50)   NULL,
    [EstadoFacturado] NVARCHAR (50)   NULL,
    [FechaEntrega]    DATETIME        NULL,
    [Total]           NUMERIC (18, 2) NULL,
    [CodigoRespuesta] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([IdPedido] ASC)
);

