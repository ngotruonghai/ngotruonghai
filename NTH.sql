USE [NTH]
GO
/****** Object:  Table [dbo].[Diemsinhvien]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diemsinhvien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[masinhvien] [varchar](12) NULL,
	[monhoc] [nvarchar](150) NULL,
	[dieml1] [float] NULL,
	[dieml2] [float] NULL,
	[dieml3] [float] NULL,
	[dieml4] [float] NULL,
	[kq] [nvarchar](50) NULL,
 CONSTRAINT [PK_Diemsinhvien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giaovien]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giaovien](
	[magiaovien] [varchar](15) NOT NULL,
	[manganh] [varchar](10) NULL,
	[tengiaovien] [nvarchar](150) NULL,
	[pass] [nvarchar](15) NULL,
 CONSTRAINT [PK_Giaovien] PRIMARY KEY CLUSTERED 
(
	[magiaovien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganh](
	[manganh] [varchar](10) NOT NULL,
	[tennganh] [nvarchar](150) NULL,
	[khoahoc] [nvarchar](150) NULL,
 CONSTRAINT [PK_Nganh] PRIMARY KEY CLUSTERED 
(
	[manganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sinhvien](
	[masinhvien] [varchar](12) NOT NULL,
	[manganh] [varchar](10) NULL,
	[tensinhvien] [nvarchar](50) NULL,
	[pass] [nvarchar](20) NULL,
	[meta] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sinhvien] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[tk] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[tk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tailieu]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tailieu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tentailieu] [nvarchar](150) NULL,
	[text] [nvarchar](max) NULL,
	[file] [nvarchar](max) NULL,
	[magiaovien] [varchar](15) NULL,
	[hide] [bit] NULL,
 CONSTRAINT [PK_Tailieu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thoikhoabieu]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thoikhoabieu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[manganh] [varchar](10) NULL,
	[monhoc] [nvarchar](150) NULL,
	[thu] [nvarchar](20) NULL,
	[phong] [nvarchar](50) NULL,
	[naybatdau] [nvarchar](50) NULL,
	[ngayketthuc] [nvarchar](50) NULL,
	[giaoviengiangday] [nvarchar](150) NULL,
 CONSTRAINT [PK_Thoikhoabieu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thongbao]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thongbao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tieude] [nvarchar](150) NULL,
	[vanban] [nvarchar](max) NULL,
	[img] [nvarchar](150) NULL,
	[meta] [nvarchar](max) NULL,
	[gioithieu] [nvarchar](max) NULL,
	[ngay] [date] NULL,
	[hide] [bit] NULL,
 CONSTRAINT [PK_Thongbao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thongbaotruong]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thongbaotruong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[meta] [nvarchar](max) NULL,
	[tieude] [nvarchar](150) NULL,
	[vanban] [nvarchar](max) NULL,
	[ngay] [date] NULL,
	[hide] [bit] NULL,
 CONSTRAINT [PK_Thongbaotruong] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tuyendung]    Script Date: 06/12/2019 10:45:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tuyendung](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[img] [nvarchar](150) NULL,
	[tieude] [nvarchar](150) NULL,
	[vanban] [nvarchar](max) NULL,
	[meta] [nvarchar](150) NULL,
	[hide] [bit] NULL,
 CONSTRAINT [PK_Tuyendung] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Diemsinhvien]  WITH CHECK ADD  CONSTRAINT [FK_Diemsinhvien_Sinhvien] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[Sinhvien] ([masinhvien])
GO
ALTER TABLE [dbo].[Diemsinhvien] CHECK CONSTRAINT [FK_Diemsinhvien_Sinhvien]
GO
ALTER TABLE [dbo].[Giaovien]  WITH CHECK ADD  CONSTRAINT [FK_Giaovien_Nganh] FOREIGN KEY([manganh])
REFERENCES [dbo].[Nganh] ([manganh])
GO
ALTER TABLE [dbo].[Giaovien] CHECK CONSTRAINT [FK_Giaovien_Nganh]
GO
ALTER TABLE [dbo].[Sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_Sinhvien_Nganh] FOREIGN KEY([manganh])
REFERENCES [dbo].[Nganh] ([manganh])
GO
ALTER TABLE [dbo].[Sinhvien] CHECK CONSTRAINT [FK_Sinhvien_Nganh]
GO
ALTER TABLE [dbo].[Tailieu]  WITH CHECK ADD  CONSTRAINT [FK_Tailieu_Giaovien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[Giaovien] ([magiaovien])
GO
ALTER TABLE [dbo].[Tailieu] CHECK CONSTRAINT [FK_Tailieu_Giaovien]
GO
ALTER TABLE [dbo].[Thoikhoabieu]  WITH CHECK ADD  CONSTRAINT [FK_Thoikhoabieu_Nganh] FOREIGN KEY([manganh])
REFERENCES [dbo].[Nganh] ([manganh])
GO
ALTER TABLE [dbo].[Thoikhoabieu] CHECK CONSTRAINT [FK_Thoikhoabieu_Nganh]
GO
