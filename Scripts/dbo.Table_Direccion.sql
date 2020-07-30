CREATE TABLE [dbo].[Direccion]
(
	[IdDireccion] INT NOT NULL PRIMARY KEY, 
    [Departamento] NVARCHAR(50) NULL, 
    [Municipio] NVARCHAR(50) NULL, 
    [Direccion] NVARCHAR(50) NULL, 
    [Estado] CHAR(10) NULL, 
    [IdCliente] INT NOT NULL, 
    CONSTRAINT [FK_Direccion_Cliente] FOREIGN KEY (IdCliente) REFERENCES [Cliente]([IdCliente])
)
