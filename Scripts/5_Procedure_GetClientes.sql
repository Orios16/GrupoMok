USE [GrupoMok]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER   PROCEDURE [dbo].[GetClientes]
@NUMREGISTROS INT OUTPUT
AS
BEGIN	
	
	SET NOCOUNT ON;

	DECLARE @EXISTE INT

	SET @NUMREGISTROS = 0

	SET @EXISTE = ( SELECT COUNT(*) From Clientes INNER JOIN
				Bancos ON Clientes.Cod_Banco = Bancos.Cod_Banco 
					INNER JOIN
				Ciudades ON Clientes.Cod_Ciudad = Ciudades.Cod_Ciudad 
					INNER JOIN
				Productos ON Clientes.Cod_Producto = Productos.Cod_Producto)

	IF @EXISTE >= 1
		BEGIN
			SELECT @NUMREGISTROS=COUNT(*)
			From Clientes INNER JOIN
				Bancos ON Clientes.Cod_Banco = Bancos.Cod_Banco 
					INNER JOIN
				Ciudades ON Clientes.Cod_Ciudad = Ciudades.Cod_Ciudad 
					INNER JOIN
				Productos ON Clientes.Cod_Producto = Productos.Cod_Producto		

			Select Clientes.Id_Persona, Clientes.Nom_Persona, Ciudades.Nom_Ciudad, Productos.Nom_Producto, Bancos.Nom_Banco
			From Clientes INNER JOIN
				Bancos ON Clientes.Cod_Banco = Bancos.Cod_Banco 
					INNER JOIN
				Ciudades ON Clientes.Cod_Ciudad = Ciudades.Cod_Ciudad 
					INNER JOIN
				Productos ON Clientes.Cod_Producto = Productos.Cod_Producto		
			RETURN 1
		END
	ELSE	
		BEGIN
			RETURN 0
		END
	
END

GO
