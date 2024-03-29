CREATE DATABASE [BDJvictordomingos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDJvictordomingos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.I2KBATATA\MSSQL\DATA\BDJvictordomingos.mdf' , SIZE = 5120KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'BDJvictordomingos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.I2KBATATA\MSSQL\DATA\BDJvictordomingos_log.ldf' , SIZE = 1024KB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDJvictordomingos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF)
GO
ALTER DATABASE [BDJvictordomingos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDJvictordomingos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDJvictordomingos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDJvictordomingos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDJvictordomingos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDJvictordomingos] SET  READ_WRITE 
GO
ALTER DATABASE [BDJvictordomingos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDJvictordomingos] SET  MULTI_USER 
GO
ALTER DATABASE [BDJvictordomingos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDJvictordomingos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BDJvictordomingos] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BDJvictordomingos]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = On;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = Primary;
GO
USE [BDJvictordomingos]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [BDJvictordomingos] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO

