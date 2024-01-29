USE [Porfolio]
GO

/****** Object:  Table [dbo].[Empresas]    Script Date: 29/01/2024 09:51:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Empresas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NomeDaEmpresa] [varchar](200) NOT NULL,
	[CNPJ] [varchar](14) NOT NULL,
 CONSTRAINT [PK_Empresas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

