USE [GrupoMok]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER   PROCEDURE [dbo].[DeleteCliente]
@Id_Persona INT
AS
BEGIN	
	
	SET NOCOUNT ON;

		BEGIN
			Delete from Clientes Where Id_Persona = @Id_Persona
		END
	
END

GO
