USE [NTH]
GO
/****** Object:  Table [dbo].[Diemsinhvien]    Script Date: 14/11/2019 8:40:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diemsinhvien](
	[id] [int] NOT NULL,
	[masinhvien] [varchar](12) NULL,
	[monhoc] [nvarchar](150) NULL,
	[dieml1] [int] NULL,
	[dieml2] [int] NULL,
	[dieml3] [int] NULL,
	[dieml4] [int] NULL,
	[kq] [nvarchar](50) NULL,
 CONSTRAINT [PK_Diemsinhvien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giaovien]    Script Date: 14/11/2019 8:40:04 SA ******/
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
/****** Object:  Table [dbo].[Nganh]    Script Date: 14/11/2019 8:40:04 SA ******/
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
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 14/11/2019 8:40:04 SA ******/
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
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 14/11/2019 8:40:04 SA ******/
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
/****** Object:  Table [dbo].[Tailieu]    Script Date: 14/11/2019 8:40:04 SA ******/
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
 CONSTRAINT [PK_Tailieu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thoikhoabieu]    Script Date: 14/11/2019 8:40:04 SA ******/
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
/****** Object:  Table [dbo].[Thongbao]    Script Date: 14/11/2019 8:40:04 SA ******/
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
/****** Object:  Table [dbo].[Thongbaotruong]    Script Date: 14/11/2019 8:40:04 SA ******/
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
/****** Object:  Table [dbo].[Tuyendung]    Script Date: 14/11/2019 8:40:04 SA ******/
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
INSERT [dbo].[Giaovien] ([magiaovien], [manganh], [tengiaovien], [pass]) VALUES (N'1', N'17607211', N'A B C 1', N'123')
INSERT [dbo].[Giaovien] ([magiaovien], [manganh], [tengiaovien], [pass]) VALUES (N'2', N'17607022', N'A B C 2', N'321')
INSERT [dbo].[Giaovien] ([magiaovien], [manganh], [tengiaovien], [pass]) VALUES (N'3', N'17607211', N'A B C 3', N'111')
INSERT [dbo].[Nganh] ([manganh], [tennganh], [khoahoc]) VALUES (N'17607022', N'quản trị mạng', N'2017-2020')
INSERT [dbo].[Nganh] ([manganh], [tennganh], [khoahoc]) VALUES (N'17607211', N'lập trình k17', N'2017-2020')
INSERT [dbo].[Nganh] ([manganh], [tennganh], [khoahoc]) VALUES (N'1860', N'mang', NULL)
INSERT [dbo].[Sinhvien] ([masinhvien], [manganh], [tensinhvien], [pass], [meta]) VALUES (N'17607021', N'17607022', N'Đức phúc', N'123', N'Phuc')
INSERT [dbo].[Sinhvien] ([masinhvien], [manganh], [tensinhvien], [pass], [meta]) VALUES (N'17607023', N'17607022', N'Quang đạt', N'admin', N'Dat')
INSERT [dbo].[Sinhvien] ([masinhvien], [manganh], [tensinhvien], [pass], [meta]) VALUES (N'17607028', N'17607211', N'Ngô Trường Hải', N'789', N'hai')
INSERT [dbo].[Taikhoan] ([tk], [pass]) VALUES (N'admin', N'123')
SET IDENTITY_INSERT [dbo].[Tailieu] ON 

INSERT [dbo].[Tailieu] ([id], [tentailieu], [text], [file], [magiaovien]) VALUES (1, N'ky thuật lập trình', N'hello ', N'dsolnf', N'1')
INSERT [dbo].[Tailieu] ([id], [tentailieu], [text], [file], [magiaovien]) VALUES (2, N'mạng căn bản', N'gell', N'no', N'2')
INSERT [dbo].[Tailieu] ([id], [tentailieu], [text], [file], [magiaovien]) VALUES (3, N'nhập môn lập trình', N'helloll', N'cefc', N'1')
INSERT [dbo].[Tailieu] ([id], [tentailieu], [text], [file], [magiaovien]) VALUES (4, N'Lập trình hướn đối tượng', NULL, NULL, N'1')
INSERT [dbo].[Tailieu] ([id], [tentailieu], [text], [file], [magiaovien]) VALUES (5, N'mạng nâng cao', NULL, NULL, N'2')
INSERT [dbo].[Tailieu] ([id], [tentailieu], [text], [file], [magiaovien]) VALUES (6, N'Cơ Sở Dữ liệu', NULL, NULL, N'3')
INSERT [dbo].[Tailieu] ([id], [tentailieu], [text], [file], [magiaovien]) VALUES (7, N'PHP và SQL', NULL, NULL, N'3')
SET IDENTITY_INSERT [dbo].[Tailieu] OFF
SET IDENTITY_INSERT [dbo].[Thoikhoabieu] ON 

INSERT [dbo].[Thoikhoabieu] ([id], [manganh], [monhoc], [thu], [phong], [naybatdau], [ngayketthuc], [giaoviengiangday]) VALUES (2, N'17607022', N'Chính trị', N'5 tuần', N'phòng 203', N'4/8/1999', N'5/6/1999', N'thầy a')
INSERT [dbo].[Thoikhoabieu] ([id], [manganh], [monhoc], [thu], [phong], [naybatdau], [ngayketthuc], [giaoviengiangday]) VALUES (3, N'17607211', N'Quốc phòng', N'6 tuàn', N'Cơ sở quận 7', N'5/5/2015', N'5/6/2015', N'thầy b')
INSERT [dbo].[Thoikhoabieu] ([id], [manganh], [monhoc], [thu], [phong], [naybatdau], [ngayketthuc], [giaoviengiangday]) VALUES (4, N'17607211', N'Toán rời rạc', N'7 tuần', N'phòng 301', N'9/9/2018', N'9/10/2018', N'thay c')
INSERT [dbo].[Thoikhoabieu] ([id], [manganh], [monhoc], [thu], [phong], [naybatdau], [ngayketthuc], [giaoviengiangday]) VALUES (5, N'17607022', N'mạng căn bản', N'3 tuần', N'phòng 201', N'15/10/2019', N'15/10/2020', N'thây a')
SET IDENTITY_INSERT [dbo].[Thoikhoabieu] OFF
SET IDENTITY_INSERT [dbo].[Thongbao] ON 

INSERT [dbo].[Thongbao] ([id], [tieude], [vanban], [img], [meta], [gioithieu], [ngay], [hide]) VALUES (8, N'Cảm nhận của Sinh viên ngành Tin học khóa 176 về đợt “Học phần tại Doanh nghiệp”', N'<p>Ngo&agrave;i c&aacute;c phong tr&agrave;o hoạt động ngoại kh&oacute;a, văn h&oacute;a, văn nghệ. Hoạt động hiến m&aacute;u t&igrave;nh nguyện nhằm tạo điều kiện để sinh vi&ecirc;n thể hiện tinh thần v&igrave; cộng đồng v&igrave; tập thể; thực hiện tinh thần &ldquo;một giọt m&aacute;u cho đi, một cuộc đời ở lại&rdquo;, s&aacute;ng ng&agrave;y 21/12/2018, hơn 120 Sinh vi&ecirc;n bậc Cao đẳng Trường đại học T&ocirc;n Đức Thắng đ&atilde; hiến m&aacute;u cứu người. Đ&acirc;y l&agrave; một hoạt động thường ni&ecirc;n của Trường. Với tấm l&ograve;ng tương th&acirc;n, tương &aacute;i, chia sẻ, gi&uacute;p đỡ v&igrave; cuộc sống của người bệnh v&agrave; sức khỏe của cộng đồng, những năm gần đ&acirc;y, sinh vi&ecirc;n v&agrave; c&aacute;n bộ vi&ecirc;n chức tại cơ sở 98 Ng&ocirc; Tất Tố lu&ocirc;n nhiệt t&igrave;nh hưởng ứng v&agrave; tham gia phong tr&agrave;o hiến m&aacute;u t&igrave;nh nguyện, trong phong tr&agrave;o hiến m&aacute;u t&igrave;nh nguyện của Phường 19, Quận B&igrave;nh Thạnh. Hiến m&aacute;u t&igrave;nh nguyện l&agrave; một nghĩa cử cao đẹp, n&eacute;t đẹp văn h&oacute;a thể hiện sự hiểu biết, l&ograve;ng nh&acirc;n &aacute;i v&agrave; tr&aacute;ch nhiệm của mỗi c&aacute; nh&acirc;n đối với cộng đồng. Đ&acirc;y l&agrave; một trong những phong tr&agrave;o lớn hiện nay của to&agrave;n x&atilde; hội, l&agrave; một hoạt động đầy &yacute; nghĩa v&agrave; mang đậm t&iacute;nh văn h&oacute;a, nh&acirc;n văn, thể hiện s&acirc;u sắc đạo l&yacute; &lsquo;&lsquo;Thương người như thể thương th&acirc;n&rsquo;&rsquo; của d&acirc;n tộc ta. Từ đ&acirc;y, nhiều bệnh nh&acirc;n đ&atilde; được cứu sống nhờ những giọt m&aacute;u nghĩa t&igrave;nh.Một số h&igrave;nh ảnh sự kiện</p>', N'IMT-3.jpg', N'camnhancuasinhviennganhtinhockhoa176vedot“hocphantaidoanhnghiep”', N'Em, một cậu sinh viên IT đang học năm 2 được nhà trường giới thiệu đến Cty IMT trong chương trình hợp tác giữa nhà trường và Cty về việc đào tạo Sinh viên tại Doanh nghiệp. Từng ngày thực tập tại đây, em dần hoàn thiện hơn kiến thức của mình, có khả năng làm việc theo nhóm, có tinh thần trách nhiệm và tư duy tốt hơn. Qua đó đã cho em rất nhiều kinh nghiệm thực tế quý giá, các dự án IT được tổ chức cụ thể cho từng thành viên do đó chúng em có kế hoạch định hướng công việc rõ ràng.', CAST(N'2019-12-25' AS Date), 1)
INSERT [dbo].[Thongbao] ([id], [tieude], [vanban], [img], [meta], [gioithieu], [ngay], [hide]) VALUES (10, N'Chuyên đề Iot (Internet of Things) và trải nghiệm hệ thống nhà thông minh SmartZ', N'Ngoài các phong trào hoạt động ngoại khóa, văn hóa, văn nghệ. Hoạt động hiến máu tình nguyện nhằm tạo điều kiện để sinh viên thể hiện tinh thần vì cộng đồng vì tập thể; thực hiện tinh thần “một giọt máu cho đi, một cuộc đời ở lại”, sáng ngày 21/12/2018, hơn 120 Sinh viên bậc Cao đẳng Trường đại học Tôn Đức Thắng đã hiến máu cứu người. Đây là một hoạt động thường niên của Trường. 

      Với tấm lòng tương thân, tương ái, chia sẻ, giúp đỡ vì cuộc sống của người bệnh và sức khỏe của cộng đồng, những năm gần đây, sinh viên và cán bộ viên chức tại cơ sở 98 Ngô Tất Tố luôn nhiệt tình hưởng ứng và tham gia phong trào hiến máu tình nguyện, trong phong trào hiến máu tình nguyện của Phường 19, Quận Bình Thạnh.

      Hiến máu tình nguyện là một nghĩa cử cao đẹp, nét đẹp văn hóa thể hiện sự hiểu biết, lòng nhân ái và trách nhiệm của mỗi cá nhân đối với cộng đồng. Đây là một trong những phong trào lớn hiện nay của toàn xã hội, là một hoạt động đầy ý nghĩa và mang đậm tính văn hóa, nhân văn, thể hiện sâu sắc đạo lý ‘‘Thương người như thể thương thân’’ của dân tộc ta. Từ đây, nhiều bệnh nhân đã được cứu sống nhờ những giọt máu nghĩa tình.

Một số hình ảnh sự kiện', N'HV-7.jpg', N'chuyen-de-iot-internet-things-va-trai-nghiem-he-thong-nha-thong-minh-smartz', N'Tham dự buổi chuyên đề có Ông Lê Minh Đức – Giám đốc Công ty CP Huyền Vũ và các chuyên viên kỹ thuật của Cty. Về phía nhà trường có TS. Nguyễn Hữu Khánh Nhân – Phó HT Trường TCCN TĐT, thầy Nguyễn Việt Hùng – chủ nhiệm ngành Tin học, thầy Lê Viết Thanh – giảng viên IT.

     Buổi báo cáo chuyên đề cũng nhằm định hướng cho sinh viên chuyên ngành Tin học và Điện tử viễn thông chuẩn bị các kiến thức cẩn thiết để xây dựng hệ thống điều khiển thiết bị trên nền tảng IoT và sinh viên rất hứng khởi được trải nghiệm điều khiển mô hình toà nhà thông minh thực tế.

Một vài hình ảnh tại buổi chuyên đề', CAST(N'1019-10-24' AS Date), 1)
INSERT [dbo].[Thongbao] ([id], [tieude], [vanban], [img], [meta], [gioithieu], [ngay], [hide]) VALUES (11, N'Ký kế hợp tác với Cty IMT Solutions và Cty cổ phần hệ thống thông tin FPT', N'Ngoài các phong trào hoạt động ngoại khóa, văn hóa, văn nghệ. Hoạt động hiến máu tình nguyện nhằm tạo điều kiện để sinh viên thể hiện tinh thần vì cộng đồng vì tập thể; thực hiện tinh thần “một giọt máu cho đi, một cuộc đời ở lại”, sáng ngày 21/12/2018, hơn 120 Sinh viên bậc Cao đẳng Trường đại học Tôn Đức Thắng đã hiến máu cứu người. Đây là một hoạt động thường niên của Trường. 

      Với tấm lòng tương thân, tương ái, chia sẻ, giúp đỡ vì cuộc sống của người bệnh và sức khỏe của cộng đồng, những năm gần đây, sinh viên và cán bộ viên chức tại cơ sở 98 Ngô Tất Tố luôn nhiệt tình hưởng ứng và tham gia phong trào hiến máu tình nguyện, trong phong trào hiến máu tình nguyện của Phường 19, Quận Bình Thạnh.

      Hiến máu tình nguyện là một nghĩa cử cao đẹp, nét đẹp văn hóa thể hiện sự hiểu biết, lòng nhân ái và trách nhiệm của mỗi cá nhân đối với cộng đồng. Đây là một trong những phong trào lớn hiện nay của toàn xã hội, là một hoạt động đầy ý nghĩa và mang đậm tính văn hóa, nhân văn, thể hiện sâu sắc đạo lý ‘‘Thương người như thể thương thân’’ của dân tộc ta. Từ đây, nhiều bệnh nhân đã được cứu sống nhờ những giọt máu nghĩa tình.

Một số hình ảnh sự kiện', N'Tin-hoc-18-6-9.jpg', N'ky-ke-hop-tac-voi-cty-imt-solutions-va-cty-co-phan-he-thong-thong-tin-fpt', N'Chiều ngày 18/06/19, Ban Cao đẳng – TDTU phối hợp với Cty IMT Solutions và Cty cổ phần hệ thống thông tin FPT HCM (FIS) cùng tổ chức chuyên đề “Database Migration In Software Development”. ', CAST(N'2019-12-30' AS Date), 1)
INSERT [dbo].[Thongbao] ([id], [tieude], [vanban], [img], [meta], [gioithieu], [ngay], [hide]) VALUES (12, N'Sinh viên cao đẳng ngành Tin Học tham quan kiến tập thực tế tại Cty FPT Software khu công nghệ cao TP.HCM', N'Ngoài các phong trào hoạt động ngoại khóa, văn hóa, văn nghệ. Hoạt động hiến máu tình nguyện nhằm tạo điều kiện để sinh viên thể hiện tinh thần vì cộng đồng vì tập thể; thực hiện tinh thần “một giọt máu cho đi, một cuộc đời ở lại”, sáng ngày 21/12/2018, hơn 120 Sinh viên bậc Cao đẳng Trường đại học Tôn Đức Thắng đã hiến máu cứu người. Đây là một hoạt động thường niên của Trường. 

      Với tấm lòng tương thân, tương ái, chia sẻ, giúp đỡ vì cuộc sống của người bệnh và sức khỏe của cộng đồng, những năm gần đây, sinh viên và cán bộ viên chức tại cơ sở 98 Ngô Tất Tố luôn nhiệt tình hưởng ứng và tham gia phong trào hiến máu tình nguyện, trong phong trào hiến máu tình nguyện của Phường 19, Quận Bình Thạnh.

      Hiến máu tình nguyện là một nghĩa cử cao đẹp, nét đẹp văn hóa thể hiện sự hiểu biết, lòng nhân ái và trách nhiệm của mỗi cá nhân đối với cộng đồng. Đây là một trong những phong trào lớn hiện nay của toàn xã hội, là một hoạt động đầy ý nghĩa và mang đậm tính văn hóa, nhân văn, thể hiện sâu sắc đạo lý ‘‘Thương người như thể thương thân’’ của dân tộc ta. Từ đây, nhiều bệnh nhân đã được cứu sống nhờ những giọt máu nghĩa tình.

Một số hình ảnh sự kiện', N'2019-Tin-hoc-FSoft-7.jpg', N'sinh-vien-cao-dang-nganh-tin-hoc-tham-quan-kien-tap-thuc-te-tai-cty-fpt-software-khu', N'Tham gia chương trình tham quan thực tế có TS. Nguyễn Hữu Khánh Nhân – Phụ trách ban Cao đẳng – ĐH Tôn Đức Thắng, các giảng viên Nguyễn Việt Hùng, Lê Viết Thanh, Dzoãn Thanh của ngành Tin học và đặc biệt là 100 sinh viên Khoá 186, 187 đã không quản ngại thời tiết nắng nóng tới tham dự chương trình trải nghiệm.', CAST(N'2019-12-02' AS Date), 1)
INSERT [dbo].[Thongbao] ([id], [tieude], [vanban], [img], [meta], [gioithieu], [ngay], [hide]) VALUES (13, N'Chuyên đề "mô hình mạng Gpon FPT" và trải nghiệm "Phỏng vấn thử - Thành công thật"', N'Ngoài các phong trào hoạt động ngoại khóa, văn hóa, văn nghệ. Hoạt động hiến máu tình nguyện nhằm tạo điều kiện để sinh viên thể hiện tinh thần vì cộng đồng vì tập thể; thực hiện tinh thần “một giọt máu cho đi, một cuộc đời ở lại”, sáng ngày 21/12/2018, hơn 120 Sinh viên bậc Cao đẳng Trường đại học Tôn Đức Thắng đã hiến máu cứu người. Đây là một hoạt động thường niên của Trường. 

      Với tấm lòng tương thân, tương ái, chia sẻ, giúp đỡ vì cuộc sống của người bệnh và sức khỏe của cộng đồng, những năm gần đây, sinh viên và cán bộ viên chức tại cơ sở 98 Ngô Tất Tố luôn nhiệt tình hưởng ứng và tham gia phong trào hiến máu tình nguyện, trong phong trào hiến máu tình nguyện của Phường 19, Quận Bình Thạnh.

      Hiến máu tình nguyện là một nghĩa cử cao đẹp, nét đẹp văn hóa thể hiện sự hiểu biết, lòng nhân ái và trách nhiệm của mỗi cá nhân đối với cộng đồng. Đây là một trong những phong trào lớn hiện nay của toàn xã hội, là một hoạt động đầy ý nghĩa và mang đậm tính văn hóa, nhân văn, thể hiện sâu sắc đạo lý ‘‘Thương người như thể thương thân’’ của dân tộc ta. Từ đây, nhiều bệnh nhân đã được cứu sống nhờ những giọt máu nghĩa tình.

Một số hình ảnh sự kiện', N'2019-Tin-hoc-PNC-4.jpg', N'chuyen-de-mo-hinh-mang-gpon-fpt-va-trai-nghiem-phong-van-thu-thanh-cong', N'Em, một cậu sinh viên IT đang học năm 2 được nhà trường giới thiệu đến Cty IMT trong chương trình hợp tác giữa nhà trường và Cty về việc đào tạo Sinh viên tại Doanh nghiệp. Từng ngày thực tập tại đây, em dần hoàn thiện hơn kiến thức của mình, có khả năng làm việc theo nhóm, có tinh thần trách nhiệm và tư duy tốt hơn. Qua đó đã cho em rất nhiều kinh nghiệm thực tế quý giá, các dự án IT được tổ chức cụ thể cho từng thành viên do đó chúng em có kế hoạch định hướng công việc rõ ràng.', CAST(N'2019-03-02' AS Date), 1)
INSERT [dbo].[Thongbao] ([id], [tieude], [vanban], [img], [meta], [gioithieu], [ngay], [hide]) VALUES (14, N'Khai giảng lớp Trung cấp ngành “Kỹ thuật mạng ngoại vi và thiết bị đầu cuối”', N'<p>Ngo&agrave;i c&aacute;c phong tr&agrave;o hoạt động ngoại kh&oacute;a, văn h&oacute;a, văn nghệ. Hoạt động hiến m&aacute;u t&igrave;nh nguyện nhằm tạo điều kiện để sinh vi&ecirc;n thể hiện tinh thần v&igrave; cộng đồng v&igrave; tập thể; thực hiện tinh thần &ldquo;một giọt m&aacute;u cho đi, một cuộc đời ở lại&rdquo;, s&aacute;ng ng&agrave;y 21/12/2018, hơn 120 Sinh vi&ecirc;n bậc Cao đẳng Trường đại học T&ocirc;n Đức Thắng đ&atilde; hiến m&aacute;u cứu người. Đ&acirc;y l&agrave; một hoạt động thường ni&ecirc;n của Trường. Với tấm l&ograve;ng tương th&acirc;n, tương &aacute;i, chia sẻ, gi&uacute;p đỡ v&igrave; cuộc sống của người bệnh v&agrave; sức khỏe của cộng đồng, những năm gần đ&acirc;y, sinh vi&ecirc;n v&agrave; c&aacute;n bộ vi&ecirc;n chức tại cơ sở 98 Ng&ocirc; Tất Tố lu&ocirc;n nhiệt t&igrave;nh hưởng ứng v&agrave; tham gia phong tr&agrave;o hiến m&aacute;u t&igrave;nh nguyện, trong phong tr&agrave;o hiến m&aacute;u t&igrave;nh nguyện của Phường 19, Quận B&igrave;nh Thạnh. Hiến m&aacute;u t&igrave;nh nguyện l&agrave; một nghĩa cử cao đẹp, n&eacute;t đẹp văn h&oacute;a thể hiện sự hiểu biết, l&ograve;ng nh&acirc;n &aacute;i v&agrave; tr&aacute;ch nhiệm của mỗi c&aacute; nh&acirc;n đối với cộng đồng. Đ&acirc;y l&agrave; một trong những phong tr&agrave;o lớn hiện nay của to&agrave;n x&atilde; hội, l&agrave; một hoạt động đầy &yacute; nghĩa v&agrave; mang đậm t&iacute;nh văn h&oacute;a, nh&acirc;n văn, thể hiện s&acirc;u sắc đạo l&yacute; &lsquo;&lsquo;Thương người như thể thương th&acirc;n&rsquo;&rsquo; của d&acirc;n tộc ta. Từ đ&acirc;y, nhiều bệnh nh&acirc;n đ&atilde; được cứu sống nhờ những giọt m&aacute;u nghĩa t&igrave;nh. Một số h&igrave;nh ảnh sự kiện</p>
', N'act-6.jpg', N'khaigiangloptrungcapnganh“kythuatmangngoaivivathietbidaucuoi”', N'Sau lễ khai giảng, Phòng đào tạo và công tác HSSV của Trường TCCN Tôn Đức Thắng sinh hoạt các nội quy, quy định của nhà trường với 67 học viên. Tham quan trung tâm dữ liệu, phòng Lab của trung tâm 3 và văn phòng trụ sở chính công ty ACT.

', CAST(N'1019-05-24' AS Date), 1)
INSERT [dbo].[Thongbao] ([id], [tieude], [vanban], [img], [meta], [gioithieu], [ngay], [hide]) VALUES (36, N'Chọn đại', N'<p><img alt="" src="/Content/upload/img/thongbao/act-3.jpg" style="height:750px; width:1000px" /></p>
', N'13-11-19-09-10-47-wp3807542.jpg', N'chondai', N'không có gì', CAST(N'2019-11-13' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Thongbao] OFF
SET IDENTITY_INSERT [dbo].[Thongbaotruong] ON 

INSERT [dbo].[Thongbaotruong] ([id], [meta], [tieude], [vanban], [ngay], [hide]) VALUES (1, N'cd-thoi-khoa-bieu-hoc-tra-no-mon-o-hoc-ky-phu-12019-2020-dot-thang-112019', N'[CĐ] Thời khóa biểu học trả nợ môn ở học kỳ phụ 1/2019-2020 - Đợt tháng 11/2019', N'<div property="schema:text" class="field field--name-body field--type-text-with-summary field--label-hidden field__item"><p>&nbsp;</p>

<p><strong>1/ Tuần 10:&nbsp;&nbsp;&nbsp;bắt đầu từ ngày 04/11/2019&nbsp;&nbsp; &nbsp;</strong><br><strong>2/ Tiết bắt đầu: Tiết 1: 7h15; Tiết 7: 12h30&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</strong><br><strong>3/ Hình thức khảo thí đối với các môn học (ngoại trừ môn Kế toán hành chính sự nghiệp và môn Tiếng Anh 2, Tiếng Anh 3):&nbsp;<br>
&nbsp;&nbsp;&nbsp;+ HSSV vắng học 1 buổi sẽ bị cấm thi&nbsp;&nbsp; &nbsp;<br>
&nbsp;&nbsp;&nbsp;+ HSSV làm 01 bài kiểm tra lấy điểm tối đa là 5.0 điểm&nbsp;&nbsp;&nbsp; &nbsp;<br>
&nbsp;&nbsp;&nbsp;+ HSSV được tổ chức thi kết thúc môn 1 lần duy nhất, lấy điểm tối đa là 5.0 điểm</strong><br><strong>4/ Môn Kế toán hành chính sự nghiệp và môn Tiếng Anh 2, Tiếng Anh 3: tổ chức học lại đủ số tiết; thang điểm đánh giá là thang điểm 10</strong><br><strong>5/ Thời khóa biểu xem chi tiết ở file đính kèm&nbsp;&nbsp; &nbsp;</strong><br><strong>6/ Danh sách lớp học Tiếng Anh 2, Tiếng 3: xem chi tiết ở file đính kèm&nbsp;&nbsp;</strong></p>
</div>', CAST(N'2019-12-24' AS Date), 1)
INSERT [dbo].[Thongbaotruong] ([id], [meta], [tieude], [vanban], [ngay], [hide]) VALUES (3, N'cd-khoi-lop-176186-thong-bao-dang-ky-thi-chung-chi-ung-dung-cong-nghe-thong-tin-co-0', N'[CĐ] Khối lớp 176;186 - Thông báo đăng ký thi chứng chỉ ứng dụng công nghệ thông tin cơ bản - Đợt tháng 11/2019', N'<div property="schema:text" class="field field--name-body field--type-text-with-summary field--label-hidden field__item"><p><strong>1/ Thời gian đăng ký:</strong></p>

<ul><li>Thời gian đăng ký: từ ngày ra thông báo&nbsp;<strong>đến ngày 28/10/2019</strong>&nbsp;tại phòng tuyển sinh (Cô Mai) (Sáng: từ 8h00 đến 11h00, &nbsp;Chiều: từ 13h00&nbsp; đến 16h00 )</li>
	<li>Lệ phí:&nbsp;<strong>500.000đ/học viên</strong></li>
</ul><p><strong>2/ Nội dung ôn tập:</strong></p>

<ul><li>Ôn tập các kiến thức IU01, IU02, IU03, IU04, IU05, IU06 của thông tư 03-BTTTT để thi lấy chứng chỉ ứng dụng CNTT cơ bản (16 tiết)&nbsp;</li>
	<li>Kế hoạch ôn tập&nbsp;<a href="https://college.tdtu.edu.vn/sites/caodang/files/caodang/articles/Student/Bieu-mau/KehoachLopOnCNTTCB.pdf"><em>(tải tại đây)</em></a></li>
</ul><p><strong>3/ Lịch ôn tập và lịch thi:</strong></p>

<ul><li>Lịch ôn tập:&nbsp;<strong>Sáng + Chiều thứ 7 (Ngày 02/11/2019) và Sáng CN (Ngày 03/11/2019) - 16 tiết - Phòng A702</strong></li>
	<li>Lịch thi: <strong>Chiều CN - Ngày 03/11/2019 - Phòng A702 và A704</strong></li>
	<li>Địa điểm ôn và&nbsp;thi:&nbsp;Trường ĐH Tôn Đức Thắng- cơ sở Tân Phong, Số 19, Nguyễn Hữu Thọ, Phường Tân Phong, Quận 7, TP. Hồ Chí Minh.</li>
</ul><p><strong>4/ Hồ sơ dự thi:</strong>&nbsp;nộp khi đăng ký dự thi&nbsp;</p>

<ul><li>2 tấm ảnh 4x6</li>
	<li>1 bản sao CMND</li>
	<li>Đơn đăng ký theo mẫu (nhận tại phòng tuyển sinh - cô Mai)</li>
</ul></div>', CAST(N'2019-12-25' AS Date), 1)
INSERT [dbo].[Thongbaotruong] ([id], [meta], [tieude], [vanban], [ngay], [hide]) VALUES (5, N'cd-khoi-lop-176-186-lich-tap-lich-thi-cua-ky-thi-chung-chi-ung-dung-cong-nghe-thong', N'[CĐ] Khối lớp 176, 186 - Lịch ôn tập + Lịch thi của kỳ thi chứng chỉ ứng dụng công nghệ thông tin cơ bản - Đợt thi ngày 13.10.2019', N'1/ Thời gian đăng ký:

Thời gian đăng ký: từ ngày ra thông báo đến ngày 28/10/2019 tại phòng tuyển sinh (Cô Mai) (Sáng: từ 8h00 đến 11h00,  Chiều: từ 13h00  đến 16h00 )
Lệ phí: 500.000đ/học viên
2/ Nội dung ôn tập:

Ôn tập các kiến thức IU01, IU02, IU03, IU04, IU05, IU06 của thông tư 03-BTTTT để thi lấy chứng chỉ ứng dụng CNTT cơ bản (16 tiết) 
Kế hoạch ôn tập (tải tại đây)
3/ Lịch ôn tập và lịch thi:

Lịch ôn tập: Sáng + Chiều thứ 7 (Ngày 02/11/2019) và Sáng CN (Ngày 03/11/2019) - 16 tiết - Phòng A702
Lịch thi: Chiều CN - Ngày 03/11/2019 - Phòng A702 và A704
Địa điểm ôn và thi: Trường ĐH Tôn Đức Thắng- cơ sở Tân Phong, Số 19, Nguyễn Hữu Thọ, Phường Tân Phong, Quận 7, TP. Hồ Chí Minh.
4/ Hồ sơ dự thi: nộp khi đăng ký dự thi 

2 tấm ảnh 4x6
1 bản sao CMND
Đơn đăng ký theo mẫu (nhận tại phòng tuyển sinh - cô Mai)', CAST(N'2019-05-03' AS Date), 1)
INSERT [dbo].[Thongbaotruong] ([id], [meta], [tieude], [vanban], [ngay], [hide]) VALUES (11, N'cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019', N'[CĐ,TC] Khoá cũ - Thông báo đăng ký học trả nợ môn ở học kỳ phụ - Đợt tháng 9/2019', N'<div class="post-content">
      
         <h1 class="post-title"><span property="schema:name">[CĐ,TC] Khoá cũ - Thông báo đăng ký học trả nợ môn ở học kỳ phụ - Đợt tháng 9/2019</span>
</h1>
        <span property="schema:name" content="[CĐ,TC] Khoá cũ - Thông báo đăng ký học trả nợ môn ở học kỳ phụ - Đợt tháng 9/2019" class="hidden"></span>
  <span property="schema:interactionCount" content="UserComments:0" class="hidden"></span>
         
      <div class="post-meta">
        <span class="post-created">TDTU, 29/08/2019 | 11:11, GMT+7 </span> 
      </div>
      
              <div class="node__meta hidden">
          <article typeof="schema:Person" about="/en/user/8">
  </article>

          <span>
            Submitted by <span rel="schema:author"><span lang="" about="/user/8" typeof="schema:Person" property="schema:name" datatype="">caodang.editor</span></span>
 on 29 August 2019          </span>
            <span property="schema:dateCreated" content="2019-08-29T04:11:26+00:00" class="hidden"></span>

        </div>
      
      <div class="node__content article-page clearfix">
        
            <div class="field field--name-field-socialmediashare field--type-social-media field--label-hidden field__item"><div class="block block-social-media block-social-sharing-block no-title">
  
    
      <div class="content block-content">
      

<div class="social-media-sharing">
  <ul class="">
                    <li>
        <a target="_blank" class="facebook-share share" href="http://www.facebook.com/share.php?u=https://college.tdtu.edu.vn/tin-tuc/2019/cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019&amp;title=[CĐ,TC] Khoá cũ - Thông báo đăng ký học trả nợ môn ở học kỳ phụ - Đợt tháng 9/2019" title="Facebook">
                      <img alt="Facebook" src="https://college.tdtu.edu.vn/modules/social_media/icons/facebook_share.svg">
                  </a>

      </li>
                <li>
        <a target="_blank" class="linkedin share" href="http://www.linkedin.com/shareArticle?mini=true&amp;url=https://college.tdtu.edu.vn/tin-tuc/2019/cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019&amp;title=[CĐ,TC] Khoá cũ - Thông báo đăng ký học trả nợ môn ở học kỳ phụ - Đợt tháng 9/2019&amp;source=https://college.tdtu.edu.vn/tin-tuc/2019/cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019" title="Linkedin">
                      <img alt="Linkedin" src="https://college.tdtu.edu.vn/modules/social_media/icons/linkedin.svg">
                  </a>

      </li>
                <li>
        <a target="_blank" class="twitter share" href="https://twitter.com/intent/tweet?url=https://college.tdtu.edu.vn/tin-tuc/2019/cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019&amp;status=[CĐ,TC] Khoá cũ - Thông báo đăng ký học trả nợ môn ở học kỳ phụ - Đợt tháng 9/2019+https://college.tdtu.edu.vn/tin-tuc/2019/cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019" title="Twitter">
                      <img alt="Twitter" src="https://college.tdtu.edu.vn/modules/social_media/icons/twitter.svg">
                  </a>

      </li>
                <li>
        <a target="_blank" class="google-plus share" href="https://plus.google.com/share?url=https://college.tdtu.edu.vn/tin-tuc/2019/cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019" title="Google Plus">
                      <img alt="Google Plus" src="https://college.tdtu.edu.vn/modules/social_media/icons/google_plus.svg">
                  </a>

      </li>
                <li>
        <a class="email share" href="mailto:?subject=[CĐ,TC] Khoá cũ - Thông báo đăng ký học trả nợ môn ở học kỳ phụ - Đợt tháng 9/2019&amp;body=Check out this site https://college.tdtu.edu.vn/tin-tuc/2019/cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019" title="Email">
                      <img alt="Email" src="https://college.tdtu.edu.vn/modules/social_media/icons/email.svg">
                  </a>

      </li>
      </ul>
</div>


    </div>
  </div>
</div>
      
            <div property="schema:text" class="field field--name-body field--type-text-with-summary field--label-hidden field__item"><p><strong>- Đối tượng đăng ký:</strong>&nbsp;HSSV <strong>đã tham gia quá trình học </strong><em>(có điểm kiểm tra hệ số 2)</em> nhưng kết quả học là <strong>"Không đạt"</strong> <em>(điểm trung bình môn dưới 5.0). </em>HSSV không đạt môn do không có điểm quá trình học (cột điểm hệ số 2), bắt buộc phải đăng ký học trả nợ môn với lớp chính khoá; không được đăng ký lớp học ở học kỳ phụ này.</p>

<p><strong>- Thời gian đăng ký:</strong>&nbsp;từ ngày ra thông báo đến hết ngày <strong>13/09/2019&nbsp;</strong></p>

<p><strong>- Đăng ký học: </strong>tại đường link&nbsp;<a href="https://docs.google.com/forms/d/1alZaFemT1Xvgrc7FDNeQCo-2Ye2dtBho50HxPKhsYDI/viewform?edit_requested=true">https://docs.google.com/forms/d/1alZaFemT1Xvgrc7FDNeQCo-2Ye2dtBho50HxPKhsYDI/viewform?edit_requested=true</a>.&nbsp;Các trường hợp đăng ký trễ hạn sẽ không được giải quyết. HSSV đăng nhập mục tra cứu điểm để kiểm tra mã môn học, tên môn học cho chính xác khi đăng ký học trả nợ.&nbsp;</p>

<p><strong>- Thời gian đóng tiền:&nbsp;từ ngày 23/9&nbsp;đến hết ngày 27/9/2019</strong> tại Phòng tuyển sinh trước cổng Trường (gặp cô Mai). Hết thời hạn đóng tiền, Phòng đào tạo sẽ hủy dữ liệu đăng ký.&nbsp;</p>

<p><strong>- Học phí học trả nợ môn:</strong>&nbsp;tùy thuộc vào số lượng đăng ký; sau khi hết thời hạn đóng tiền căn cứ vào số lượng thực tế đóng phòng đào tạo sẽ tổ chức lớp/hủy lớp học.</p>

<p><strong>- Hình thức khảo thí:&nbsp;</strong><br>
&nbsp; &nbsp;+ HSSV vắng học 1 buổi sẽ bị cấm thi<br>
&nbsp; &nbsp;+ HSSV làm 01 bài kiểm tra lấy điểm tối đa là 5.0 điểm&nbsp;<br>
&nbsp; &nbsp;+ HSSV được tổ chức thi kết thúc môn 1 lần duy nhất, lấy điểm tối đa là 5.0 điểm</p>

<p><strong>- Thời gian học:</strong>&nbsp;dự kiến từ ngày <strong>14/10/2019; lớp học sẽ tổ chức vào buổi tối (học từ 17h45 đến 21h00)</strong></p>
</div>
      <ul class="links inline"><li class="comment-forbidden"><a href="/user/login?destination=/tin-tuc/2019/cdtc-khoa-cu-thong-bao-dang-ky-hoc-tra-no-mon-o-hoc-ky-phu-dot-thang-92019%23comment-form">Log in</a> to post comments</li></ul>
      </div>
       </div>', CAST(N'2109-10-28' AS Date), 1)
INSERT [dbo].[Thongbaotruong] ([id], [meta], [tieude], [vanban], [ngay], [hide]) VALUES (12, N'cd-khoi-lop-176-186-thoi-khoa-bieu-va-danh-sach-chia-nhom-hoc-hoc-ky-12019-2020', N'[CĐ] Khối lớp 176; 186 - Thời khoá biểu và danh sách chia nhóm học - Học kỳ 1/2019-2020', N'Lưu ý:</strong></p>

<p>1. Tuần 2: bắt đầu từ ngày 09/09/2019; <strong>học tại cơ sở 98 Ngô Tất Tố, Phường 19, Quận Bình Thạnh, TP.HCM</strong></p>

<p>2. Tiết bắt đầu:</p>

<p>&nbsp;<strong> &nbsp;- Tiết 1: bắt đầu học từ 7h15&nbsp;</strong></p>

<p><strong>&nbsp; &nbsp;- Tiết 7: bắt đầu học từ 12h30</strong></p>

<p>3. Thời gian học 1 buổi: 5 tiết/buổi học ban ngày; 4 tiết/buổi tối&nbsp;</p>

<p>&nbsp;<strong>&nbsp; - Buối sáng: học từ 7h15 đến 11h20</strong></p>

<p><strong>&nbsp;&nbsp; - Buổi chiều: học từ 12h30 đến 16h35</strong></p>

<p><strong>&nbsp; &nbsp;- Buổi tối: học từ 17h45 đến 21h00</strong></p>

<p>4. Các ngày nghỉ trong năm không xếp thời khoá biểu</p>

<p>&nbsp; <strong>&nbsp;- Ngày thành lập Trường: 24/9/2019 (thứ 3)</strong></p>

<p><strong>&nbsp; &nbsp;- Ngày Tết dương lịch: 01/01/2020 (thứ 4)</strong></p>

<p><strong>&nbsp; &nbsp;- Ngày Tết âm lịch: 18/01 đến 02/02/2020</strong></p>

<p><strong>&nbsp; &nbsp;- Ngày Giỗ tổ Hùng Vương: 02/04/2020 (thứ 5)</strong></p>

<p><strong>&nbsp; &nbsp;- Ngày Giải phóng Miền Nam: 30/04/2020 (thứ 5)</strong></p>

<p><strong>&nbsp; &nbsp;- Ngày Quốc tế Lao động: 01/05/2020 (thứ 6)</strong></p>

<p><strong>&nbsp; &nbsp;- Ngày thi tốt nghiệp PTTH quốc gia: 24/6 đến 27/06/2020</strong></p>

<p>5. Danh sách <strong>chia nhóm/chia tổ</strong> học: xem chi tiết ở file đính kèm&nbsp;(clik vào dòng chữ màu đỏ để tải file)</p>

<p>6. Thời khoá biểu học: xem chi tiết ở file đính kèm (clik vào dòng chữ màu đỏ để tải file)</p>
</div>
      <ul class="links inline"><li class="comment-forbidden"><a href="/user/login?destination=/tin-tuc/2019/cd-khoi-lop-176-186-thoi-khoa-bieu-va-danh-sach-chia-nhom-hoc-hoc-ky-12019-2020%23comment-form">Log in</a> to post comments</li></ul>
      </div>
       </div>', CAST(N'2019-02-28' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Thongbaotruong] OFF
SET IDENTITY_INSERT [dbo].[Tuyendung] ON 

INSERT [dbo].[Tuyendung] ([id], [img], [tieude], [vanban], [meta], [hide]) VALUES (1, N'td_1.png', N'Thông tin tuyển dụng của Khách sạn Kim Đô', N'Khách sạn Kim Đô hiện cần tuyển bổ sung các vị trí: 

Nhân viên phục vụ bàn (Nam/Nữ - Ưu tiên Nam)
Nhân viên phục vụ phòng (Nam/Nữ)
Nhân viên vệ sinh (Nam/ Nữ - Ưu tiên Nam)
Nhân viên phụ bếp (Nam/Nữ)
Mức lương:

Nhân viên phụ bếp                              : 5.357.000 đồng – 6.000.000 đồng
Nhân viên phục vụ bàn                       : 5.085.000 đồng – 5.400.000 đồng
Nhân viên phục vụ phòng                   : 5.085.000 đồng – 5.400.000 đồng
Nhân viên vệ sinh                               : 4.500.000 đồng – 4.800.000 đồng
Quyền lợi được hưởng:

Thưởng Lễ, Tết và các chế độ khác theo quy định của Khách sạn và Nhà nước
Được nghỉ 1 ngày/ 1 tuần
Môi trường làm việc chuyên nghiệp, đào tạo lâu dài, có cơ hội phát triển …
Đầy đủ các chế độ dành cho người lao động theo như quy định pháp luật hiện hành (BHYT, BHXH, BHTN…), Bảo hiểm chăm sóc sức khỏe…
Tham quan nghỉ mát 1 năm 1 lần,…
Được cấp phát đồng phục lao động
Một số quyền lợi khác sẽ trao đổi thêm khi phỏng vấn.
YÊU CẦU CÔNG VIỆC:

Vị trí Phục vụ bàn: 
Sức khỏe tốt, có khả năng đi đứng lâu trong ca làm việc.
Phong cách năng động, vui vẻ
Ngoại hình ưa nhìn
Tiếng Anh giao tiếp cơ bản.
Ưu tiên cho ứng viên có kinh nghiệm và có bằng cấp/chứng chỉ về nghiệp vụ nhà hàng.
Độ tuổi: 18-27 tuổi
Ngoại hình dễ nhìn
Vị trí Phục vụ phòng:
Sức khỏe tốt, có tinh thần trách nhiệm cao, chịu được áp lực trong công việc,
Tiếng Anh giao tiếp căn bản.
Ưu tiên có kinh nghiệm hoặc kiến thức tương đương.
Độ tuổi: 18-35 tuổi
Ngoại hình dễ nhìn
Vị trí Vệ sinh:
Sức khỏe tốt, nhiệt tình trong công việc.
Phong cách năng động, vui vẻ.
Độ tuổi 30- 40 tuổi
Vị trí Phụ bếp:
Sức khỏe tốt. Phong cách năng động, vui vẻ.
Có bằng cấp/chứng chỉ về nghiệp vụ Bếp.
Ưu tiên cho ứng viên có kinh nghiệm.
Độ tuổi: 20-30 tuổi
Chế độ làm việc: 6 ngày/tuần

Theo ca: 8 giờ/ngày, (từ 6h đến 14h, từ 14h đến 22h, từ 22h đến 06h00)
Theo giờ hành chính: từ 07h30 đến 16h30
Yêu cầu hồ sơ Gửi hồ sơ xin việc có công chứng  gồm: Đơn xin việc, Sơ yếu lý lịch, CV chi tiết về bản thân, CMND,Giấy khám sức khỏe, Hộ khẩu, Giấy khai sinh, Bằng cấp (nếu có). Tất cả đều sao y công chứng, để lại số điện thoại di động kèm theo ảnh (ghi rõ vị trí ứng tuyển).', N'Thông tin tuyển dụng của Khách sạn Kim Đô', NULL)
INSERT [dbo].[Tuyendung] ([id], [img], [tieude], [vanban], [meta], [hide]) VALUES (2, N'tb_2.jpg', N'Thông tin tuyển dụng của Cty Thiết bị PCCC Việt Trung', N'Vị trí: 2 Nhân viên kỹ thuật và 2 nhân viên sales

Công ty chúng tôi đang cần gấp 2 nhân viên kỹ thuật và 2 nhân viên sales cho sản phẩm thiết bị báo cháy. Xin tham khảo thông tin đính kèm và liên hệ cô Dương Quý Hiền sđt 0913612163 (zalo: Cat Cantho) ', N'Thông tin tuyển dụng của Cty Thiết bị PCCC Việt Trung', NULL)
INSERT [dbo].[Tuyendung] ([id], [img], [tieude], [vanban], [meta], [hide]) VALUES (3, N'tb_4.png', N'Thông tin tuyển dụng của Cty TMDV Nguyễn Nhân', N'Do nhu cầu phát triển thị trường, công ty TNHH TM DV NGUYỄN NHÂN cần tuyển:

1. Chuyên ngành, số lượng tuyển dụng

+ Nhân viên kỹ thuật                                         :  03 người

 2. Yêu cầu chung

- Phẩm chất đạo đức tốt, không có tiền án tiền sự, có sức khỏe tốt.

- Có kinh nghiệm nạp mực, thay thế vật tư linh kiện máy in, sửa chữa máy in (cơ bản)

- Tốt nghiệp trung cấp trở lên.

 3. Địa điểm làm việc:

Tại ĐĐKD công ty TNHH TM DV NGUYỄN NHÂN

64/31P Hoà Bình, Phường 5, Quận 11, TPHCM

 4. Quyền lợi của người lao động:

- Chế độ quyền lợi BHXH: Người lao động làm việc theo HĐLĐ dài hạn được đóng BHXH, BHYT,… theo quy định của Nhà nước.

- Mức thu nhập: 5.000.000 vnd - 10.000.000 vnd/người/tháng (mức lương được hưởng cụ thể theo năng lực)

 5. Hồ sơ xin việc:

- Đơn xin việc.

- Sơ yếu lý lịch có xác nhận của chính quyền địa phương trong vòng 3 tháng.

- CMT, các bằng cấp có liên quan (phô tô công chứng).

 

Mọi chi tiết vui lòng xin liên hệ :

ĐỊA ĐIỂM KINH DOANH CÔNG TY TNHH TM DV NGUYỄN NHÂN

Địa chỉ: 64/31P Hoà Bình, P.5  Q.11, Tp.HCM

ĐT: 028 3975 6541 / 0919 038 301 (Ms. Nga)', N'Thông tin tuyển dụng của Cty TMDV Nguyễn Nhân', NULL)
SET IDENTITY_INSERT [dbo].[Tuyendung] OFF
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
