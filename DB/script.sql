USE [master]
GO
/****** Object:  Database [FarmaciaGaleras]    Script Date: 10/10/2022 9:59:21 p. m. ******/
CREATE DATABASE [FarmaciaGaleras]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FarmaciaGaleras', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FarmaciaGaleras.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FarmaciaGaleras_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FarmaciaGaleras_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FarmaciaGaleras] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FarmaciaGaleras].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FarmaciaGaleras] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET ARITHABORT OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FarmaciaGaleras] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FarmaciaGaleras] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FarmaciaGaleras] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FarmaciaGaleras] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET RECOVERY FULL 
GO
ALTER DATABASE [FarmaciaGaleras] SET  MULTI_USER 
GO
ALTER DATABASE [FarmaciaGaleras] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FarmaciaGaleras] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FarmaciaGaleras] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FarmaciaGaleras] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FarmaciaGaleras] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FarmaciaGaleras] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FarmaciaGaleras', N'ON'
GO
ALTER DATABASE [FarmaciaGaleras] SET QUERY_STORE = OFF
GO
USE [FarmaciaGaleras]
GO
/****** Object:  Table [dbo].[InformacionDomicilio]    Script Date: 10/10/2022 9:59:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformacionDomicilio](
	[IdDomicilio] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[ValorTotal] [money] NOT NULL,
	[NombreDomiciliario] [text] NOT NULL,
 CONSTRAINT [PK_InformacionDomicilio] PRIMARY KEY CLUSTERED 
(
	[IdDomicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InformacionUsuario]    Script Date: 10/10/2022 9:59:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformacionUsuario](
	[IdUsuario] [int] NOT NULL,
	[IdentificacionUsuario] [varchar](50) NOT NULL,
	[DireccionCompleta] [varchar](50) NOT NULL,
	[Barrio] [text] NOT NULL,
	[NombreUsuario] [text] NOT NULL,
	[TelefonoContacto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_InformacionEntregaDomicilio] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 10/10/2022 9:59:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[IdInvetario] [int] NOT NULL,
	[FechaRealizacionInventario] [date] NOT NULL,
	[NumeroEstante] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[CantidadDisponible] [int] NOT NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[IdInvetario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presentacion]    Script Date: 10/10/2022 9:59:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presentacion](
	[IdPresentacion] [int] NOT NULL,
	[Presentacion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Presentacion] PRIMARY KEY CLUSTERED 
(
	[IdPresentacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 10/10/2022 9:59:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] NOT NULL,
	[CodigoProducto] [varchar](50) NOT NULL,
	[NombreProducto] [text] NOT NULL,
	[Concentracion] [varchar](50) NOT NULL,
	[IdPresentacion] [int] NOT NULL,
	[FechaVencimiento] [date] NOT NULL,
	[ValorUnitario] [money] NOT NULL,
 CONSTRAINT [PK_RequisitosAreaInventarios] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SugerenciasQuejas]    Script Date: 10/10/2022 9:59:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SugerenciasQuejas](
	[IdSugerenciaQueja] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdTipoRecurso] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[SituacionPresentada] [text] NOT NULL,
 CONSTRAINT [PK_SugerenciasQuejas] PRIMARY KEY CLUSTERED 
(
	[IdSugerenciaQueja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoRecurso]    Script Date: 10/10/2022 9:59:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoRecurso](
	[IdTipoRecurso] [int] NOT NULL,
	[Recurso] [text] NOT NULL,
 CONSTRAINT [PK_TipoRecurso] PRIMARY KEY CLUSTERED 
(
	[IdTipoRecurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Presentacion] ([IdPresentacion], [Presentacion]) VALUES (1, N'Cápsulas')
INSERT [dbo].[Presentacion] ([IdPresentacion], [Presentacion]) VALUES (2, N'Soluciones solubles')
INSERT [dbo].[Presentacion] ([IdPresentacion], [Presentacion]) VALUES (3, N'Comprimidos')
GO
INSERT [dbo].[TipoRecurso] ([IdTipoRecurso], [Recurso]) VALUES (1, N'Petición')
INSERT [dbo].[TipoRecurso] ([IdTipoRecurso], [Recurso]) VALUES (2, N'Queja')
INSERT [dbo].[TipoRecurso] ([IdTipoRecurso], [Recurso]) VALUES (3, N'Reclamo')
GO
ALTER TABLE [dbo].[InformacionDomicilio]  WITH CHECK ADD  CONSTRAINT [FK_InformacionDomicilio_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[InformacionDomicilio] CHECK CONSTRAINT [FK_InformacionDomicilio_Productos]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Productos]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Presentacion] FOREIGN KEY([IdPresentacion])
REFERENCES [dbo].[Presentacion] ([IdPresentacion])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Presentacion]
GO
ALTER TABLE [dbo].[SugerenciasQuejas]  WITH CHECK ADD  CONSTRAINT [FK_SugerenciasQuejas_InformacionUsuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[InformacionUsuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[SugerenciasQuejas] CHECK CONSTRAINT [FK_SugerenciasQuejas_InformacionUsuario]
GO
ALTER TABLE [dbo].[SugerenciasQuejas]  WITH CHECK ADD  CONSTRAINT [FK_SugerenciasQuejas_TipoRecurso] FOREIGN KEY([IdTipoRecurso])
REFERENCES [dbo].[TipoRecurso] ([IdTipoRecurso])
GO
ALTER TABLE [dbo].[SugerenciasQuejas] CHECK CONSTRAINT [FK_SugerenciasQuejas_TipoRecurso]
GO
USE [master]
GO
ALTER DATABASE [FarmaciaGaleras] SET  READ_WRITE 
GO
