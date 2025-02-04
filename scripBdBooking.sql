USE [BdBooking]
GO
/****** Object:  Table [dbo].[TAgency]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAgency](
	[IdAgency] [int] IDENTITY(1,1) NOT NULL,
	[AgencyName] [varchar](50) NULL,
	[AgencyCity] [varchar](50) NULL,
	[AgencyStatus] [bit] NULL,
 CONSTRAINT [PK_TAgency] PRIMARY KEY CLUSTERED 
(
	[IdAgency] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBooking]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBooking](
	[IdBooking] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[EmergencyPhone] [varchar](50) NULL,
	[EmergencyName] [varchar](50) NULL,
	[NumberPeople] [int] NULL,
	[IdRoomXHotel] [int] NULL,
	[GuestIdDocument] [int] NULL,
	[IdPayment] [int] NULL,
	[TotalBooking] [decimal](18, 0) NULL,
	[BookingStatus] [bit] NULL,
 CONSTRAINT [PK_TBooking] PRIMARY KEY CLUSTERED 
(
	[IdBooking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TDetailAgencyXHotel]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDetailAgencyXHotel](
	[IdDetailAgencyXHotel] [int] IDENTITY(1,1) NOT NULL,
	[IdAgency] [int] NULL,
	[IdHotel] [int] NULL,
	[Status] [nchar](10) NULL,
 CONSTRAINT [PK_TDetailAgencyXHotel] PRIMARY KEY CLUSTERED 
(
	[IdDetailAgencyXHotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TDetailBookingXGuest]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDetailBookingXGuest](
	[IdBooking] [int] NOT NULL,
	[GuestIdDocument] [int] NOT NULL,
	[DetailBookingXGuestStatus] [nchar](10) NULL,
 CONSTRAINT [PK_TDetailBookingXGuest] PRIMARY KEY CLUSTERED 
(
	[IdBooking] ASC,
	[GuestIdDocument] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TGuest]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TGuest](
	[GuestIdDocument] [int] NOT NULL,
	[TypeDocument] [varchar](50) NULL,
	[GuestName] [varchar](50) NULL,
	[BirthDate] [date] NULL,
	[Gender] [nchar](10) NULL,
	[GuestMail] [varchar](50) NULL,
	[GuestPhone] [varchar](50) NULL,
	[GuestStatus] [bit] NULL,
 CONSTRAINT [PK_TGuest] PRIMARY KEY CLUSTERED 
(
	[GuestIdDocument] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THotel]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THotel](
	[IdHotel] [int] IDENTITY(1,1) NOT NULL,
	[HotelCountry] [varchar](50) NULL,
	[HotelName] [varchar](50) NULL,
	[HotelPhone] [varchar](50) NULL,
	[Hoteladdress] [varchar](50) NULL,
	[HotelFavorite] [bit] NULL,
	[HotelStatus] [bit] NULL,
 CONSTRAINT [PK_THoteles] PRIMARY KEY CLUSTERED 
(
	[IdHotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRoomXHotel]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRoomXHotel](
	[IdRoomXHotel] [int] IDENTITY(1,1) NOT NULL,
	[IdHotel] [int] NULL,
	[IdTypeRoom] [int] NULL,
	[NumberPeople] [int] NULL,
	[BaseCosto] [decimal](10, 3) NULL,
	[Taxes] [decimal](10, 3) NULL,
	[location] [varchar](max) NULL,
	[RoomXHotelStatus] [bit] NULL,
 CONSTRAINT [PK_TRoomXHotel] PRIMARY KEY CLUSTERED 
(
	[IdRoomXHotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTypeRoom]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTypeRoom](
	[IdTypeRoom] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_TTypeRoom] PRIMARY KEY CLUSTERED 
(
	[IdTypeRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTypeUser]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTypeUser](
	[IdTypeUser] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_TTypeUser] PRIMARY KEY CLUSTERED 
(
	[IdTypeUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TUserAgency]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUserAgency](
	[IdDocumentUserAgency] [int] NOT NULL,
	[IdAgency] [int] NULL,
	[IdTypeUser] [int] NULL,
	[UserAgencyMail] [varchar](50) NULL,
	[UserAgencyPassword] [varchar](10) NULL,
	[UserAgencyName] [varchar](50) NULL,
	[UserAgencyPhone] [varchar](50) NULL,
	[UserAgencyStatus] [bit] NULL,
 CONSTRAINT [PK_TUserAgency] PRIMARY KEY CLUSTERED 
(
	[IdDocumentUserAgency] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TUserGuest]    Script Date: 04/02/2025 2:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUserGuest](
	[IdUserGuest] [int] IDENTITY(1,1) NOT NULL,
	[GuestIdDocument] [int] NULL,
	[UserGuestPassword] [varchar](50) NULL,
 CONSTRAINT [PK_TUserGuest] PRIMARY KEY CLUSTERED 
(
	[IdUserGuest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
