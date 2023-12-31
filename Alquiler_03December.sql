USE [Alquiler]
GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 3/12/2023 23:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contratos](
	[ContratoID] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[MontoMensual] [decimal](10, 2) NOT NULL,
	[PropiedadID] [int] NULL,
	[InquilinoID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ContratoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inquilinos]    Script Date: 3/12/2023 23:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inquilinos](
	[InquilinoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](15) NULL,
	[Direccion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[InquilinoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mantenimiento]    Script Date: 3/12/2023 23:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mantenimiento](
	[MantenimientoID] [int] IDENTITY(1,1) NOT NULL,
	[FechaMantenimiento] [date] NOT NULL,
	[Descripcion] [varchar](250) NULL,
	[Costo] [decimal](10, 2) NULL,
	[PropiedadID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MantenimientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 3/12/2023 23:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[PagoID] [int] IDENTITY(1,1) NOT NULL,
	[FechaPago] [date] NOT NULL,
	[Monto] [decimal](10, 2) NOT NULL,
	[ContratoID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PagoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Propiedades]    Script Date: 3/12/2023 23:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propiedades](
	[PropiedadID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Direccion] [varchar](255) NOT NULL,
	[TipoPropiedad] [varchar](50) NOT NULL,
	[PrecioMensual] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PropiedadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/12/2023 23:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](20) NULL,
	[password] [varchar](100) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD FOREIGN KEY([InquilinoID])
REFERENCES [dbo].[Inquilinos] ([InquilinoID])
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD FOREIGN KEY([InquilinoID])
REFERENCES [dbo].[Inquilinos] ([InquilinoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD FOREIGN KEY([PropiedadID])
REFERENCES [dbo].[Propiedades] ([PropiedadID])
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD FOREIGN KEY([PropiedadID])
REFERENCES [dbo].[Propiedades] ([PropiedadID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mantenimiento]  WITH CHECK ADD FOREIGN KEY([PropiedadID])
REFERENCES [dbo].[Propiedades] ([PropiedadID])
GO
ALTER TABLE [dbo].[Mantenimiento]  WITH CHECK ADD FOREIGN KEY([PropiedadID])
REFERENCES [dbo].[Propiedades] ([PropiedadID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD FOREIGN KEY([ContratoID])
REFERENCES [dbo].[Contratos] ([ContratoID])
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD FOREIGN KEY([ContratoID])
REFERENCES [dbo].[Contratos] ([ContratoID])
ON DELETE CASCADE
GO
