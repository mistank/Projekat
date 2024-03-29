USE [master]
GO
/****** Object:  Database [ProjekatBaza]    Script Date: 2/18/2024 12:49:45 PM ******/
CREATE DATABASE [ProjekatBaza]
begin
EXEC [ProjekatBaza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjekatBaza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjekatBaza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjekatBaza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjekatBaza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjekatBaza] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjekatBaza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjekatBaza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjekatBaza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjekatBaza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjekatBaza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjekatBaza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjekatBaza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjekatBaza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjekatBaza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjekatBaza] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjekatBaza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjekatBaza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjekatBaza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjekatBaza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjekatBaza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjekatBaza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjekatBaza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjekatBaza] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjekatBaza] SET  MULTI_USER 
GO
ALTER DATABASE [ProjekatBaza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjekatBaza] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjekatBaza] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjekatBaza] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProjekatBaza] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjekatBaza] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjekatBaza', N'ON'
GO
ALTER DATABASE [ProjekatBaza] SET QUERY_STORE = ON
GO
ALTER DATABASE [ProjekatBaza] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ProjekatBaza]
GO
/****** Object:  Table [dbo].[Destination]    Script Date: 2/18/2024 12:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destination](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DestinationName] [varchar](50) NOT NULL,
	[State] [int] NOT NULL,
 CONSTRAINT [PK_Destination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 2/18/2024 12:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trip]    Script Date: 2/18/2024 12:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trip](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartureDate] [date] NOT NULL,
	[ArrivalDate] [date] NOT NULL,
	[Price] [int] NOT NULL,
	[Destination] [int] NOT NULL,
 CONSTRAINT [PK_Trip] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[tripView]    Script Date: 2/18/2024 12:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[tripView] as select destination.Id as d_id, state.id as s_id  from trip t join destination on (destination.Id = t.Destination) join state on (state.Id = destination.State)
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 2/18/2024 12:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[JMBG] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Passenger] PRIMARY KEY CLUSTERED 
(
	[JMBG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 2/18/2024 12:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservationDate] [date] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Passenger] [varchar](50) NOT NULL,
	[Trip] [int] NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2/18/2024 12:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Destination] ON 

INSERT [dbo].[Destination] ([Id], [DestinationName], [State]) VALUES (1, N'Hurgada', 1)
INSERT [dbo].[Destination] ([Id], [DestinationName], [State]) VALUES (2, N'Paralia', 4)
INSERT [dbo].[Destination] ([Id], [DestinationName], [State]) VALUES (3, N'Zakintos', 4)
INSERT [dbo].[Destination] ([Id], [DestinationName], [State]) VALUES (4, N'Halkidiki', 4)
INSERT [dbo].[Destination] ([Id], [DestinationName], [State]) VALUES (5, N'Rimini', 3)
SET IDENTITY_INSERT [dbo].[Destination] OFF
GO
INSERT [dbo].[Passenger] ([JMBG], [FirstName], [LastName], [Phone]) VALUES (N'1231231231231', N'Nikola', N'Pavic', N'0656700449')
INSERT [dbo].[Passenger] ([JMBG], [FirstName], [LastName], [Phone]) VALUES (N'1234567890123', N'Milan', N'Stankovic', N'1234567890')
INSERT [dbo].[Passenger] ([JMBG], [FirstName], [LastName], [Phone]) VALUES (N'1702002750013', N'Milan', N'Stankovic', N'0600202683')
INSERT [dbo].[Passenger] ([JMBG], [FirstName], [LastName], [Phone]) VALUES (N'1702002750014', N'Milan', N'Aksentijevic', N'060453220')
GO
SET IDENTITY_INSERT [dbo].[Reservation] ON 

INSERT [dbo].[Reservation] ([Id], [ReservationDate], [Status], [Passenger], [Trip]) VALUES (8, CAST(N'2024-02-15' AS Date), N'Confirmed', N'1234567890123', 19)
SET IDENTITY_INSERT [dbo].[Reservation] OFF
GO
SET IDENTITY_INSERT [dbo].[State] ON 

INSERT [dbo].[State] ([Id], [StateName]) VALUES (1, N'Egypt')
INSERT [dbo].[State] ([Id], [StateName]) VALUES (2, N'Hawaii')
INSERT [dbo].[State] ([Id], [StateName]) VALUES (3, N'Italy')
INSERT [dbo].[State] ([Id], [StateName]) VALUES (4, N'Greece')
INSERT [dbo].[State] ([Id], [StateName]) VALUES (5, N'Turkey')
SET IDENTITY_INSERT [dbo].[State] OFF
GO
SET IDENTITY_INSERT [dbo].[Trip] ON 

INSERT [dbo].[Trip] ([Id], [DepartureDate], [ArrivalDate], [Price], [Destination]) VALUES (9, CAST(N'2024-02-13' AS Date), CAST(N'2024-02-13' AS Date), 123, 5)
INSERT [dbo].[Trip] ([Id], [DepartureDate], [ArrivalDate], [Price], [Destination]) VALUES (12, CAST(N'2024-02-08' AS Date), CAST(N'2024-02-12' AS Date), 221, 3)
INSERT [dbo].[Trip] ([Id], [DepartureDate], [ArrivalDate], [Price], [Destination]) VALUES (19, CAST(N'2024-02-14' AS Date), CAST(N'2024-02-28' AS Date), 122, 1)
SET IDENTITY_INSERT [dbo].[Trip] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Username], [Password], [FirstName], [LastName]) VALUES (1, N'milan', N'milan', N'Milan', N'Stankovic')
INSERT [dbo].[User] ([Id], [Username], [Password], [FirstName], [LastName]) VALUES (2, N'stefan', N'stefan', N'Stefan', N'Sedlarevic')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Destination]  WITH CHECK ADD  CONSTRAINT [FK_Destination_State] FOREIGN KEY([State])
REFERENCES [dbo].[State] ([Id])
GO
ALTER TABLE [dbo].[Destination] CHECK CONSTRAINT [FK_Destination_State]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Passenger] FOREIGN KEY([Passenger])
REFERENCES [dbo].[Passenger] ([JMBG])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Passenger]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Trip] FOREIGN KEY([Trip])
REFERENCES [dbo].[Trip] ([Id])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Trip]
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD  CONSTRAINT [FK_Trip_Destination] FOREIGN KEY([Destination])
REFERENCES [dbo].[Destination] ([Id])
GO
ALTER TABLE [dbo].[Trip] CHECK CONSTRAINT [FK_Trip_Destination]
GO
USE [master]
GO
ALTER DATABASE [ProjekatBaza] SET  READ_WRITE 
GO
