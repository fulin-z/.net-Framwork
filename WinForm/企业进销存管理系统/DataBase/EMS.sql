USE [db_EMS]
GO
/****** Object:  Table [dbo].[tb_BuyStock]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_BuyStock](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillCode] [varchar](50) NULL,
	[BillDate] [varchar](50) NULL,
	[Handler] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Remark] [varchar](50) NULL,
	[FullPayment] [varchar](50) NULL,
	[Payment] [varchar](50) NULL,
 CONSTRAINT [PK_tb_BuyStock] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_BuyStockDetail]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_BuyStockDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillCode] [varchar](50) NULL,
	[GoodsCode] [varchar](50) NULL,
	[GoodsName] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[Num] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[Money] [varchar](50) NULL,
 CONSTRAINT [PK_tb_BuyStockDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Employee]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeCode] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[Sex] [varchar](50) NULL,
	[Dept] [varchar](50) NULL,
	[Tel] [varchar](50) NULL,
	[Remark] [varchar](50) NULL,
	[EditMan] [varchar](50) NULL,
	[EditTime] [datetime] NULL,
 CONSTRAINT [PK_tb_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Goods]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Goods](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GoodsCode] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Produce] [varchar](50) NULL,
	[EditMan] [varchar](50) NULL,
	[EditTime] [datetime] NULL,
 CONSTRAINT [PK_tb_Goods] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_SaleStock]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_SaleStock](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillCode] [varchar](50) NULL,
	[BillDate] [varchar](50) NULL,
	[Handler] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Remark] [varchar](50) NULL,
	[FullPayment] [varchar](50) NULL,
	[Payment] [varchar](50) NULL,
 CONSTRAINT [PK_tb_SaleStock] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_SaleStockDetail]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_SaleStockDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillCode] [varchar](50) NULL,
	[GoodsCode] [varchar](50) NULL,
	[GoodsName] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[Num] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[Money] [varchar](50) NULL,
 CONSTRAINT [PK_tb_SaleStockDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Stock]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Stock](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GoodsCode] [varchar](50) NULL,
	[GoodsName] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[Standard] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Produce] [varchar](50) NULL,
	[StockNum] [varchar](50) NULL,
	[BuyPrice] [varchar](50) NULL,
	[SalePrice] [varchar](50) NULL,
	[UpperLimit] [varchar](50) NULL,
	[LowerLimit] [varchar](50) NULL,
 CONSTRAINT [PK_tb_Stock] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Units]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Units](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UnitCode] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[Tax] [varchar](50) NULL,
	[Tel] [varchar](50) NULL,
	[LinkMan] [varchar](50) NULL,
	[Accounts] [varchar](50) NULL,
	[Adress] [varchar](50) NULL,
	[EditMan] [varchar](50) NULL,
	[EditTime] [datetime] NULL,
 CONSTRAINT [PK_tb_Units] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_User]    Script Date: 2020/3/13 18:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[UserPwd] [varchar](50) NULL,
	[UserRight] [varchar](50) NULL,
	[LoginTime] [datetime] NULL,
 CONSTRAINT [PK_tb_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_BuyStock] ON 

INSERT [dbo].[tb_BuyStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (1, N'20200311JH1000001', N'2020-03-11', N'admin', N'单位U1001', N'测试1', N'7500', N'0')
INSERT [dbo].[tb_BuyStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (2, N'20200311JH1000002', N'2020-03-11', N'admin', N'单位U1002', N'测试2', N'615', N'600')
INSERT [dbo].[tb_BuyStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (3, N'20200313TH1000001', N'2020-03-13', N'admin', N'单位U1001', N'测试4', N'1250', N'1250')
INSERT [dbo].[tb_BuyStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (4, N'20200313TH1000002', N'2020-03-13', N'admin', N'单位U1002', N'测试5', N'246', N'250')
INSERT [dbo].[tb_BuyStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (5, N'20200313JH1000003', N'2020-03-13', N'admin', N'单位U1001', N'测试6', N'1000', N'1000')
SET IDENTITY_INSERT [dbo].[tb_BuyStock] OFF
SET IDENTITY_INSERT [dbo].[tb_BuyStockDetail] ON 

INSERT [dbo].[tb_BuyStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (1, N'20200311JH1000001', N'G1001', N'商品G1001', N'L', N'100', N'50', N'5000')
INSERT [dbo].[tb_BuyStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (2, N'20200311JH1000001', N'G1003', N'商品G1003', N'G', N'100', N'25', N'2500')
INSERT [dbo].[tb_BuyStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (3, N'20200311JH1000002', N'G1002', N'商品G1002', N'ML', N'50', N'12.3', N'615')
INSERT [dbo].[tb_BuyStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (4, N'20200313TH1000001', N'G1001', N'商品G1001', N'L', N'20', N'50', N'1000')
INSERT [dbo].[tb_BuyStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (5, N'20200313TH1000001', N'G1003', N'商品G1003', N'G', N'10', N'25', N'250')
INSERT [dbo].[tb_BuyStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (6, N'20200313TH1000002', N'G1002', N'商品G1002', N'ML', N'20', N'12.3', N'246')
INSERT [dbo].[tb_BuyStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (7, N'20200313JH1000003', N'G1001', N'商品G1001', N'L', N'10', N'50', N'500')
INSERT [dbo].[tb_BuyStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (8, N'20200313JH1000003', N'G1003', N'商品G1003', N'G', N'20', N'25', N'500')
SET IDENTITY_INSERT [dbo].[tb_BuyStockDetail] OFF
SET IDENTITY_INSERT [dbo].[tb_Employee] ON 

INSERT [dbo].[tb_Employee] ([ID], [EmployeeCode], [FullName], [Sex], [Dept], [Tel], [Remark], [EditMan], [EditTime]) VALUES (1, N'E1001', N'张三', N'男性', N'进货部', N'111111111111', N'1111111111', N'admin', CAST(N'2020-03-10T19:25:57.000' AS DateTime))
INSERT [dbo].[tb_Employee] ([ID], [EmployeeCode], [FullName], [Sex], [Dept], [Tel], [Remark], [EditMan], [EditTime]) VALUES (3, N'E1002', N'李四', N'女性', N'销售部', N'11111111111', N'1', N'admin', CAST(N'2020-03-10T19:27:04.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_Employee] OFF
SET IDENTITY_INSERT [dbo].[tb_Goods] ON 

INSERT [dbo].[tb_Goods] ([ID], [GoodsCode], [FullName], [Type], [Standard], [Unit], [Produce], [EditMan], [EditTime]) VALUES (1, N'G1001', N'商品G1001', N'U1001', N'L', N'单位U1001', N'xxxxxxxx', N'admin', CAST(N'2020-03-10T18:36:13.000' AS DateTime))
INSERT [dbo].[tb_Goods] ([ID], [GoodsCode], [FullName], [Type], [Standard], [Unit], [Produce], [EditMan], [EditTime]) VALUES (3, N'G1002', N'商品G1002', N'U1002', N'ML', N'单位U1002', N'xxxxxxx', N'admin', CAST(N'2020-03-10T18:37:16.000' AS DateTime))
INSERT [dbo].[tb_Goods] ([ID], [GoodsCode], [FullName], [Type], [Standard], [Unit], [Produce], [EditMan], [EditTime]) VALUES (5, N'G1003', N'商品G1003', N'U1001', N'G', N'单位U1001', N'xxxxx', N'admin', CAST(N'2020-03-10T18:39:12.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_Goods] OFF
SET IDENTITY_INSERT [dbo].[tb_SaleStock] ON 

INSERT [dbo].[tb_SaleStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (6, N'20200312XS1000001', N'2020-03-12', N'admin', N'销售单位U1003', N'测试3', N'620', N'0')
INSERT [dbo].[tb_SaleStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (7, N'20200312XS1000002', N'2020-03-12', N'admin', N'销售单位U1004', N'测试4', N'100', N'95')
INSERT [dbo].[tb_SaleStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (8, N'20200313TH1000001', N'2020-03-13', N'admin', N'销售单位U1004', N'', N'20', N'20')
INSERT [dbo].[tb_SaleStock] ([ID], [BillCode], [BillDate], [Handler], [Unit], [Remark], [FullPayment], [Payment]) VALUES (9, N'20200313TH1000002', N'2020-03-13', N'admin', N'销售单位U1004', N'测试5', N'20', N'20')
SET IDENTITY_INSERT [dbo].[tb_SaleStock] OFF
SET IDENTITY_INSERT [dbo].[tb_SaleStockDetail] ON 

INSERT [dbo].[tb_SaleStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (7, N'20200312XS1000001', N'G1001', N'商品G1001', N'L', N'2', N'60', N'120')
INSERT [dbo].[tb_SaleStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (8, N'20200312XS1000001', N'G1002', N'商品G1002', N'ML', N'10', N'20', N'200')
INSERT [dbo].[tb_SaleStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (9, N'20200312XS1000001', N'G1003', N'商品G1003', N'G', N'10', N'30', N'300')
INSERT [dbo].[tb_SaleStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (10, N'20200312XS1000002', N'G1002', N'商品G1002', N'ML', N'5', N'20', N'100')
INSERT [dbo].[tb_SaleStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (11, N'20200313TH1000001', N'G1002', N'商品G1002', N'ML', N'1', N'20', N'20')
INSERT [dbo].[tb_SaleStockDetail] ([ID], [BillCode], [GoodsCode], [GoodsName], [Standard], [Num], [Price], [Money]) VALUES (12, N'20200313TH1000002', N'G1002', N'商品G1002', N'ML', N'1', N'20', N'20')
SET IDENTITY_INSERT [dbo].[tb_SaleStockDetail] OFF
SET IDENTITY_INSERT [dbo].[tb_Stock] ON 

INSERT [dbo].[tb_Stock] ([ID], [GoodsCode], [GoodsName], [Type], [Standard], [Unit], [Produce], [StockNum], [BuyPrice], [SalePrice], [UpperLimit], [LowerLimit]) VALUES (1, N'G1001', N'商品G1001', N'U1001', N'L', N'单位U1001', N'xxxxxxxx', N'66', N'50', N'60', N'70', N'10')
INSERT [dbo].[tb_Stock] ([ID], [GoodsCode], [GoodsName], [Type], [Standard], [Unit], [Produce], [StockNum], [BuyPrice], [SalePrice], [UpperLimit], [LowerLimit]) VALUES (2, N'G1003', N'商品G1003', N'U1001', N'G', N'单位U1001', N'xxxxx', N'100', N'25', N'30', N'90', N'10')
INSERT [dbo].[tb_Stock] ([ID], [GoodsCode], [GoodsName], [Type], [Standard], [Unit], [Produce], [StockNum], [BuyPrice], [SalePrice], [UpperLimit], [LowerLimit]) VALUES (3, N'G1002', N'商品G1002', N'U1002', N'ML', N'单位U1002', N'xxxxxxx', N'17', N'12.3', N'20', N'70', N'40')
SET IDENTITY_INSERT [dbo].[tb_Stock] OFF
SET IDENTITY_INSERT [dbo].[tb_Units] ON 

INSERT [dbo].[tb_Units] ([ID], [UnitCode], [FullName], [Tax], [Tel], [LinkMan], [Accounts], [Adress], [EditMan], [EditTime]) VALUES (1, N'U1001', N'单位U1001', N'123456789', N'12345678944', N'张三', N'5002351555032478544', N'江苏省苏州市', N'admin', CAST(N'2020-03-09T21:10:05.000' AS DateTime))
INSERT [dbo].[tb_Units] ([ID], [UnitCode], [FullName], [Tax], [Tel], [LinkMan], [Accounts], [Adress], [EditMan], [EditTime]) VALUES (6, N'U1002', N'单位U1002', N'11', N'111', N'111', N'11', N'111', N'admin', CAST(N'2020-03-09T21:29:13.000' AS DateTime))
INSERT [dbo].[tb_Units] ([ID], [UnitCode], [FullName], [Tax], [Tel], [LinkMan], [Accounts], [Adress], [EditMan], [EditTime]) VALUES (7, N'U1003', N'销售单位U1003', N'111111111111111111111111111', N'1111111111111', N'张某某', N'1111111111111111111111111', N'xxxxxxxxxxxxxxxxx', N'admin', CAST(N'2020-03-12T14:54:16.000' AS DateTime))
INSERT [dbo].[tb_Units] ([ID], [UnitCode], [FullName], [Tax], [Tel], [LinkMan], [Accounts], [Adress], [EditMan], [EditTime]) VALUES (8, N'U1004', N'销售单位U1004', N'1111', N'11', N'11', N'11', N'11', N'admin', CAST(N'2020-03-12T16:35:50.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_Units] OFF
SET IDENTITY_INSERT [dbo].[tb_User] ON 

INSERT [dbo].[tb_User] ([ID], [UserName], [UserPwd], [UserRight], [LoginTime]) VALUES (1, N'admin', N'123', N'管理员', CAST(N'2020-03-13T18:20:34.000' AS DateTime))
INSERT [dbo].[tb_User] ([ID], [UserName], [UserPwd], [UserRight], [LoginTime]) VALUES (2, N'wang', N'123', N'操作用户', CAST(N'2020-03-06T18:59:01.000' AS DateTime))
INSERT [dbo].[tb_User] ([ID], [UserName], [UserPwd], [UserRight], [LoginTime]) VALUES (1004, N'李四', N'123', N'操作用户', CAST(N'2020-03-10T19:41:47.000' AS DateTime))
INSERT [dbo].[tb_User] ([ID], [UserName], [UserPwd], [UserRight], [LoginTime]) VALUES (1007, N'张三', N'123', N'操作用户', CAST(N'2020-03-10T19:45:16.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_User] OFF
