USE [Portfolio]
GO

/****** Object:  Table [dbo].[AssociadosEmpresas]    Script Date: 29/01/2024 09:51:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AssociadosEmpresas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AssociadoID] [int] NOT NULL,
	[EmpresaID] [int] NOT NULL,
 CONSTRAINT [PK_AssociadosEmpresas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AssociadosEmpresas]  WITH CHECK ADD  CONSTRAINT [FK_AssociadosEmpresas_AssociadosEmpresas] FOREIGN KEY([ID])
REFERENCES [dbo].[AssociadosEmpresas] ([ID])
GO

ALTER TABLE [dbo].[AssociadosEmpresas] CHECK CONSTRAINT [FK_AssociadosEmpresas_AssociadosEmpresas]
GO


