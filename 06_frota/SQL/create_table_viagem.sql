USE [victor_BD_Frota]
GO

/****** Object:  Table [dbo].[viagem]    Script Date: 03/09/2019 10:12:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[viagem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[veiculo_id] [int] NOT NULL,
	[condutor_id] [int] NOT NULL,
	[distancia] [numeric](9, 1) NOT NULL,
	[data] [datetime] NOT NULL,
 CONSTRAINT [PK_viagem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[viagem]  WITH CHECK ADD  CONSTRAINT [FK_viagem_condutor] FOREIGN KEY([condutor_id])
REFERENCES [dbo].[condutor] ([id])
GO

ALTER TABLE [dbo].[viagem] CHECK CONSTRAINT [FK_viagem_condutor]
GO

ALTER TABLE [dbo].[viagem]  WITH CHECK ADD  CONSTRAINT [FK_viagem_veiculo] FOREIGN KEY([veiculo_id])
REFERENCES [dbo].[veiculo] ([id])
GO

ALTER TABLE [dbo].[viagem] CHECK CONSTRAINT [FK_viagem_veiculo]
GO

