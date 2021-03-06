USE [master]
GO

/****** Object:  Database [Hotel]    Script Date: 07/05/2015 15:39:08 ******/
DROP DATABASE [Hotel]
GO

/****** Object:  Database [Hotel]    Script Date: 07/05/2015 15:39:08 ******/
CREATE DATABASE [Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Hotel.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Hotel_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Hotel_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Hotel] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Hotel] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Hotel] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Hotel] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Hotel] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Hotel] SET ARITHABORT OFF 
GO

ALTER DATABASE [Hotel] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Hotel] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Hotel] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Hotel] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Hotel] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Hotel] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Hotel] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Hotel] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Hotel] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Hotel] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Hotel] SET  MULTI_USER 
GO

ALTER DATABASE [Hotel] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Hotel] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Hotel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Hotel] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Hotel] SET  READ_WRITE 
GO

