USE [master]
GO

/****** Object:  Database [victor_BD_Frota]    Script Date: 03/09/2019 09:59:44 ******/
CREATE DATABASE [victor_BD_Frota]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'victor_BD_Frota', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.I2KBATATA\MSSQL\DATA\victor_BD_Frota.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'victor_BD_Frota_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.I2KBATATA\MSSQL\DATA\victor_BD_Frota_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [victor_BD_Frota].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [victor_BD_Frota] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET ARITHABORT OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [victor_BD_Frota] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [victor_BD_Frota] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET  DISABLE_BROKER 
GO

ALTER DATABASE [victor_BD_Frota] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [victor_BD_Frota] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [victor_BD_Frota] SET  MULTI_USER 
GO

ALTER DATABASE [victor_BD_Frota] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [victor_BD_Frota] SET DB_CHAINING OFF 
GO

ALTER DATABASE [victor_BD_Frota] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [victor_BD_Frota] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [victor_BD_Frota] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [victor_BD_Frota] SET QUERY_STORE = OFF
GO

ALTER DATABASE [victor_BD_Frota] SET  READ_WRITE 
GO
