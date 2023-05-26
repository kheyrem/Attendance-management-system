USE [master]
GO

/****** Object:  Database [AttendancyDB]    Script Date: 1/27/2022 7:25:48 PM ******/
CREATE DATABASE [AttendancyDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AttendancyDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AttendancyDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AttendancyDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AttendancyDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AttendancyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AttendancyDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AttendancyDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AttendancyDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AttendancyDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AttendancyDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [AttendancyDB] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [AttendancyDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AttendancyDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AttendancyDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AttendancyDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AttendancyDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AttendancyDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AttendancyDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AttendancyDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AttendancyDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [AttendancyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AttendancyDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AttendancyDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AttendancyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AttendancyDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AttendancyDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AttendancyDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AttendancyDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [AttendancyDB] SET  MULTI_USER 
GO

ALTER DATABASE [AttendancyDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AttendancyDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AttendancyDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AttendancyDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [AttendancyDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AttendancyDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [AttendancyDB] SET  READ_WRITE 
GO

