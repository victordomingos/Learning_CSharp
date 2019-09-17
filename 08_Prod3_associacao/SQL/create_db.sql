USE [master]
GO

/****** Object:  Database [Xvictor]    Script Date: 17/09/2019 09:41:46 ******/
CREATE DATABASE [Xvictor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Xvictor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.I2KBATATA\MSSQL\DATA\Xvictor.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Xvictor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.I2KBATATA\MSSQL\DATA\Xvictor_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Xvictor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Xvictor] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Xvictor] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Xvictor] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Xvictor] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Xvictor] SET ARITHABORT OFF 
GO

ALTER DATABASE [Xvictor] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Xvictor] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Xvictor] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Xvictor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Xvictor] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Xvictor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Xvictor] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Xvictor] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Xvictor] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Xvictor] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Xvictor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Xvictor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Xvictor] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Xvictor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Xvictor] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Xvictor] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Xvictor] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Xvictor] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Xvictor] SET  MULTI_USER 
GO

ALTER DATABASE [Xvictor] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Xvictor] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Xvictor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Xvictor] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Xvictor] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Xvictor] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Xvictor] SET  READ_WRITE 
GO

