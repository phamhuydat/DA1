USE [DA1]
GO
/****** Object:  Table [dbo].[AppBranch]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppBranch](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](500) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[IdMap] [nvarchar](500) NOT NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppBranch] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppDiscountCode]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppDiscountCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](100) NOT NULL,
	[DiscountPrice] [decimal](18, 2) NULL,
	[MinDiscountPrice] [decimal](18, 2) NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[UnApplyCategoryId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppDiscountCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppNews]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppNews](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Slug] [nvarchar](500) NOT NULL,
	[Summary] [nvarchar](500) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[Views] [bigint] NOT NULL,
	[Votes] [real] NOT NULL,
	[Published] [bit] NOT NULL,
	[PublishedAt] [datetime2](7) NULL,
	[CoverImgPath] [nvarchar](max) NOT NULL,
	[CoverImgThumbnailPath] [nvarchar](max) NOT NULL,
	[StampPath] [nvarchar](max) NOT NULL,
	[UserId] [int] NULL,
	[CategoryId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[SEOTitle] [nvarchar](200) NOT NULL,
	[SEODescription] [nvarchar](1000) NOT NULL,
	[SEOKeyword] [nvarchar](100) NOT NULL,
	[SEOImagePath] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_AppNews] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppNewsCategory]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppNewsCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](300) NOT NULL,
	[Slug] [nvarchar](300) NOT NULL,
	[Content] [nvarchar](max) NULL,
	[CoverImgPath] [nvarchar](max) NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppNewsCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppOrder]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CusName] [nvarchar](50) NOT NULL,
	[CusPhone] [nvarchar](20) NOT NULL,
	[CusEmail] [nvarchar](200) NOT NULL,
	[DeliveryAddress] [nvarchar](100) NOT NULL,
	[CusNote] [nvarchar](500) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[StatusId] [int] NULL,
	[EmployeeId] [int] NULL,
	[DiscountCodeId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppOrderDetail]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppOrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[ProductName] [nvarchar](500) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NULL,
	[ProductPrice] [decimal](18, 2) NOT NULL,
	[ImagePath] [nvarchar](1000) NOT NULL,
	[SizeId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppOrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppPolicy]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppPolicy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Slug] [nvarchar](200) NOT NULL,
	[CoverImgPath] [nvarchar](500) NOT NULL,
	[CoverImgThumbnailPath] [nvarchar](500) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[Like] [int] NOT NULL,
	[UserId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppPolicy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppProduct]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ProductCode] [nvarchar](300) NOT NULL,
	[CategoryId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppProductCategory]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppProductCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Slug] [nvarchar](200) NOT NULL,
	[CateLevel] [int] NOT NULL,
	[HasChild] [bit] NOT NULL,
	[Content] [nvarchar](1000) NULL,
	[CoverImgPath] [nvarchar](max) NULL,
	[StampPath] [nvarchar](max) NULL,
	[ParentCateId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppProductCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppProductDetail]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppProductDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[DiscountPrice] [decimal](18, 2) NULL,
	[DiscountFrom] [datetime2](7) NULL,
	[DiscountTo] [datetime2](7) NULL,
	[ProductId] [int] NULL,
	[ColorId] [int] NULL,
	[Ram] [nvarchar](max) NULL,
	[Rom] [nvarchar](max) NULL,
	[CPU] [nvarchar](max) NULL,
	[GPU] [nvarchar](max) NULL,
	[IsMain] [bit] NULL,
	[InStock] [int] NOT NULL,
	[Sold] [int] NOT NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppProductDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppProductImage]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppProductImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](1000) NOT NULL,
	[ProductId] [int] NULL,
	[IsMobile] [bit] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppProductImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppRole]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Desc] [nvarchar](100) NOT NULL,
	[CanDelete] [bit] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppRolePermission]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppRolePermission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AppRoleId] [int] NOT NULL,
	[MstPermissionId] [int] NOT NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppRolePermission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppSlider]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppSlider](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](500) NOT NULL,
	[FromDate] [datetime2](7) NULL,
	[ToDate] [datetime2](7) NULL,
	[Link] [nvarchar](1000) NOT NULL,
	[CategoryId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppSlider] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUser]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](200) NOT NULL,
	[PasswordHash] [varbinary](200) NOT NULL,
	[PasswordSalt] [varbinary](200) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [varchar](20) NOT NULL,
	[Email] [varchar](200) NOT NULL,
	[Address] [nvarchar](100) NULL,
	[Avatar] [nvarchar](250) NULL,
	[BlockedTo] [datetime2](7) NULL,
	[BlockedBy] [int] NULL,
	[AppRoleId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppVerifyCode]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppVerifyCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TokenString] [nvarchar](max) NOT NULL,
	[Expired] [datetime2](7) NOT NULL,
	[IsVerified] [bit] NOT NULL,
	[UserId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AppVerifyCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MstOrderStatus]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MstOrderStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[DisplayOrder] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_MstOrderStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MstPermission]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MstPermission](
	[Id] [int] NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Table] [varchar](50) NOT NULL,
	[GroupName] [nvarchar](50) NOT NULL,
	[Desc] [nvarchar](50) NOT NULL,
	[DisplayOrder] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_MstPermission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MstProductColor]    Script Date: 5/7/2024 1:30:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MstProductColor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](100) NOT NULL,
	[CssColor] [nvarchar](100) NOT NULL,
	[DisplayOrder] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_MstProductColor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AppNews] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [Views]
GO
ALTER TABLE [dbo].[AppNews] ADD  DEFAULT (CONVERT([real],(0))) FOR [Votes]
GO
ALTER TABLE [dbo].[AppNews] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Published]
GO
ALTER TABLE [dbo].[AppNews] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[AppNewsCategory] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[AppPolicy] ADD  DEFAULT ((0)) FOR [Like]
GO
ALTER TABLE [dbo].[AppProductCategory] ADD  DEFAULT ((1)) FOR [CateLevel]
GO
ALTER TABLE [dbo].[AppProductCategory] ADD  DEFAULT (CONVERT([bit],(0))) FOR [HasChild]
GO
ALTER TABLE [dbo].[AppVerifyCode] ADD  DEFAULT (getdate()) FOR [Expired]
GO
ALTER TABLE [dbo].[AppVerifyCode] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsVerified]
GO
ALTER TABLE [dbo].[AppVerifyCode] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[AppNews]  WITH CHECK ADD  CONSTRAINT [FK_AppNews_AppNewsCategory_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[AppNewsCategory] ([Id])
GO
ALTER TABLE [dbo].[AppNews] CHECK CONSTRAINT [FK_AppNews_AppNewsCategory_CategoryId]
GO
ALTER TABLE [dbo].[AppNews]  WITH CHECK ADD  CONSTRAINT [FK_AppNews_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
GO
ALTER TABLE [dbo].[AppNews] CHECK CONSTRAINT [FK_AppNews_AppUser_UserId]
GO
ALTER TABLE [dbo].[AppOrder]  WITH CHECK ADD  CONSTRAINT [FK_AppOrder_AppDiscountCode_DiscountCodeId] FOREIGN KEY([DiscountCodeId])
REFERENCES [dbo].[AppDiscountCode] ([Id])
GO
ALTER TABLE [dbo].[AppOrder] CHECK CONSTRAINT [FK_AppOrder_AppDiscountCode_DiscountCodeId]
GO
ALTER TABLE [dbo].[AppOrder]  WITH CHECK ADD  CONSTRAINT [FK_AppOrder_AppUser_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO
ALTER TABLE [dbo].[AppOrder] CHECK CONSTRAINT [FK_AppOrder_AppUser_CreatedBy]
GO
ALTER TABLE [dbo].[AppOrder]  WITH CHECK ADD  CONSTRAINT [FK_AppOrder_AppUser_EmployeeId] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[AppUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AppOrder] CHECK CONSTRAINT [FK_AppOrder_AppUser_EmployeeId]
GO
ALTER TABLE [dbo].[AppOrder]  WITH CHECK ADD  CONSTRAINT [FK_AppOrder_MstOrderStatus_StatusId] FOREIGN KEY([StatusId])
REFERENCES [dbo].[MstOrderStatus] ([Id])
GO
ALTER TABLE [dbo].[AppOrder] CHECK CONSTRAINT [FK_AppOrder_MstOrderStatus_StatusId]
GO
ALTER TABLE [dbo].[AppOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_AppOrderDetail_AppOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[AppOrder] ([Id])
GO
ALTER TABLE [dbo].[AppOrderDetail] CHECK CONSTRAINT [FK_AppOrderDetail_AppOrder_OrderId]
GO
ALTER TABLE [dbo].[AppOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_AppOrderDetail_AppProductDetail_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[AppProductDetail] ([Id])
GO
ALTER TABLE [dbo].[AppOrderDetail] CHECK CONSTRAINT [FK_AppOrderDetail_AppProductDetail_ProductId]
GO
ALTER TABLE [dbo].[AppPolicy]  WITH CHECK ADD  CONSTRAINT [FK_AppPolicy_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
GO
ALTER TABLE [dbo].[AppPolicy] CHECK CONSTRAINT [FK_AppPolicy_AppUser_UserId]
GO
ALTER TABLE [dbo].[AppProduct]  WITH CHECK ADD  CONSTRAINT [FK_AppProduct_AppProductCategory_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[AppProductCategory] ([Id])
GO
ALTER TABLE [dbo].[AppProduct] CHECK CONSTRAINT [FK_AppProduct_AppProductCategory_CategoryId]
GO
ALTER TABLE [dbo].[AppProductCategory]  WITH CHECK ADD  CONSTRAINT [FK_AppProductCategory_AppProductCategory_ParentCateId] FOREIGN KEY([ParentCateId])
REFERENCES [dbo].[AppProductCategory] ([Id])
GO
ALTER TABLE [dbo].[AppProductCategory] CHECK CONSTRAINT [FK_AppProductCategory_AppProductCategory_ParentCateId]
GO
ALTER TABLE [dbo].[AppProductDetail]  WITH CHECK ADD  CONSTRAINT [FK_AppProductDetail_AppProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[AppProduct] ([Id])
GO
ALTER TABLE [dbo].[AppProductDetail] CHECK CONSTRAINT [FK_AppProductDetail_AppProduct_ProductId]
GO
ALTER TABLE [dbo].[AppProductDetail]  WITH CHECK ADD  CONSTRAINT [FK_AppProductDetail_MstProductColor_ColorId] FOREIGN KEY([ColorId])
REFERENCES [dbo].[MstProductColor] ([Id])
GO
ALTER TABLE [dbo].[AppProductDetail] CHECK CONSTRAINT [FK_AppProductDetail_MstProductColor_ColorId]
GO
ALTER TABLE [dbo].[AppProductImage]  WITH CHECK ADD  CONSTRAINT [FK_AppProductImage_AppProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[AppProduct] ([Id])
GO
ALTER TABLE [dbo].[AppProductImage] CHECK CONSTRAINT [FK_AppProductImage_AppProduct_ProductId]
GO
ALTER TABLE [dbo].[AppRolePermission]  WITH CHECK ADD  CONSTRAINT [FK_AppRolePermission_AppRole_AppRoleId] FOREIGN KEY([AppRoleId])
REFERENCES [dbo].[AppRole] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AppRolePermission] CHECK CONSTRAINT [FK_AppRolePermission_AppRole_AppRoleId]
GO
ALTER TABLE [dbo].[AppRolePermission]  WITH CHECK ADD  CONSTRAINT [FK_AppRolePermission_MstPermission_MstPermissionId] FOREIGN KEY([MstPermissionId])
REFERENCES [dbo].[MstPermission] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AppRolePermission] CHECK CONSTRAINT [FK_AppRolePermission_MstPermission_MstPermissionId]
GO
ALTER TABLE [dbo].[AppSlider]  WITH CHECK ADD  CONSTRAINT [FK_AppSlider_AppProductCategory_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[AppProductCategory] ([Id])
GO
ALTER TABLE [dbo].[AppSlider] CHECK CONSTRAINT [FK_AppSlider_AppProductCategory_CategoryId]
GO
ALTER TABLE [dbo].[AppUser]  WITH CHECK ADD  CONSTRAINT [FK_AppUser_AppRole_AppRoleId] FOREIGN KEY([AppRoleId])
REFERENCES [dbo].[AppRole] ([Id])
GO
ALTER TABLE [dbo].[AppUser] CHECK CONSTRAINT [FK_AppUser_AppRole_AppRoleId]
GO
ALTER TABLE [dbo].[AppVerifyCode]  WITH CHECK ADD  CONSTRAINT [FK_AppVerifyCode_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
GO
ALTER TABLE [dbo].[AppVerifyCode] CHECK CONSTRAINT [FK_AppVerifyCode_AppUser_UserId]
GO
