USE [master]
GO

/****** Object:  Database [Музыкальный сборник]    Script Date: 11.12.2020 1:13:27 ******/
CREATE DATABASE [Музыкальный сборник]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Музыкальный сборник', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Музыкальный сборник.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Музыкальный сборник_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Музыкальный сборник_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Музыкальный сборник].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Музыкальный сборник] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET ARITHABORT OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Музыкальный сборник] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Музыкальный сборник] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Музыкальный сборник] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Музыкальный сборник] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Музыкальный сборник] SET  MULTI_USER 
GO

ALTER DATABASE [Музыкальный сборник] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Музыкальный сборник] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Музыкальный сборник] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Музыкальный сборник] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Музыкальный сборник] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Музыкальный сборник] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Музыкальный сборник] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Музыкальный сборник] SET  READ_WRITE 
GO


