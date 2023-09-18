USE [GrupoMok]
GO

ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [FK_Clientes_Bancos]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type in (N'U'))
DROP TABLE [dbo].[Clientes]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Id_Persona] [nvarchar](50) NOT NULL,
	[Nom_Persona] [nvarchar](100) NULL,
	[Cod_Ciudad] [nvarchar](3) NULL,
	[Cod_Producto] [int] NULL,
	[Cod_Banco] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Bancos] FOREIGN KEY([Cod_Banco])
REFERENCES [dbo].[Bancos] ([Cod_Banco])
GO

ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Bancos]
GO


