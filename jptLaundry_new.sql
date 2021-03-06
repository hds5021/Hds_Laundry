USE [jptLaundry]
GO
/****** Object:  UserDefinedFunction [dbo].[fnTableHasPrimaryKey]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnTableHasPrimaryKey](@sTableName varchar(128))
RETURNS bit
AS
BEGIN
	DECLARE @nTableID int,
		@nIndexID int
	
	SET 	@nTableID = OBJECT_ID(@sTableName)
	
	SELECT 	@nIndexID = indid
	FROM 	sysindexes
	WHERE 	id = @nTableID
	 AND 	indid BETWEEN 1 And 254 
	 AND 	(status & 2048) = 2048
	
	IF @nIndexID IS NOT Null
		RETURN 1
	
	RETURN 0
END
GO
/****** Object:  Table [dbo].[SubMenuMaster]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubMenuMaster](
	[submenuid] [bigint] IDENTITY(1,1) NOT NULL,
	[submenuName] [varchar](50) NULL,
	[submenuDesc] [varchar](max) NULL,
	[menuid] [bigint] NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_subMenuMaster] PRIMARY KEY CLUSTERED 
(
	[submenuid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserMaster](
	[userid] [bigint] IDENTITY(1,1) NOT NULL,
	[umusername] [varchar](50) NULL,
	[umpassword] [varchar](50) NULL,
	[empid] [bigint] NULL,
	[rollid] [bigint] NULL,
	[rollLocation] [varchar](max) NULL,
	[createDateTime] [datetime] NULL,
	[isRetired] [bit] NULL,
	[isDeleted] [bit] NULL,
	[insertedBy] [varchar](50) NULL,
	[createdBy] [varchar](50) NULL,
	[deleteBy] [varchar](50) NULL,
	[viewedBy] [varchar](50) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_UserMaster] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserMaster] ON
INSERT [dbo].[UserMaster] ([userid], [umusername], [umpassword], [empid], [rollid], [rollLocation], [createDateTime], [isRetired], [isDeleted], [insertedBy], [createdBy], [deleteBy], [viewedBy], [status]) VALUES (1, N'admin', N'admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[UserMaster] OFF
/****** Object:  Table [dbo].[RollMaster]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RollMaster](
	[rollid] [bigint] IDENTITY(1,1) NOT NULL,
	[rollName] [varchar](50) NULL,
	[rollDesc] [varchar](max) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_rollMaster] PRIMARY KEY CLUSTERED 
(
	[rollid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[fnCleanDefaultValue]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnCleanDefaultValue](@sDefaultValue varchar(4000))
RETURNS varchar(4000)
AS
BEGIN
	RETURN SubString(@sDefaultValue, 2, DataLength(@sDefaultValue)-2)
END
GO
/****** Object:  UserDefinedFunction [dbo].[fnIsColumnPrimaryKey]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[fnIsColumnPrimaryKey](@sTableName varchar(128), @nColumnName varchar(128))
RETURNS bit
AS
BEGIN
	DECLARE @nTableID int,
		@nIndexID int,
		@i int
	
	SET 	@nTableID = OBJECT_ID(@sTableName)
	
	SELECT 	@nIndexID = indid
	FROM 	sysindexes
	WHERE 	id = @nTableID
	 AND 	indid BETWEEN 1 And 254 
	 AND 	(status & 2048) = 2048
	
	IF @nIndexID Is Null
		RETURN 0
	
	IF @nColumnName IN
		(SELECT sc.[name]
		FROM 	sysindexkeys sik
			INNER JOIN syscolumns sc ON sik.id = sc.id AND sik.colid = sc.colid
		WHERE 	sik.id = @nTableID
		 AND 	sik.indid = @nIndexID)
	 BEGIN
		RETURN 1
	 END


	RETURN 0
END
GO
/****** Object:  Table [dbo].[EmployeeMaster]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeMaster](
	[empid] [bigint] IDENTITY(1,1) NOT NULL,
	[empName] [varchar](50) NULL,
	[empAdd] [varchar](max) NULL,
	[empMobile] [varchar](15) NULL,
	[empPhoneno] [varchar](20) NULL,
	[empemailId] [varchar](50) NULL,
	[isRetired] [varchar](50) NULL,
	[isDeleted] [varchar](50) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_EmployeeMaster] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[instances]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[instances](
	[InstanceID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceName] [varchar](255) NOT NULL,
	[Telephone] [varchar](15) NULL,
	[MobileNo] [varchar](15) NULL,
	[Version] [varchar](20) NULL,
	[Logo] [varchar](35) NULL,
	[LastUpdateDateTime] [datetime] NULL,
	[LastBackupDate] [datetime] NULL,
	[LastRestoreDate] [datetime] NULL,
	[LastRestoreUpto] [datetime] NULL,
	[LastResetDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK__instance__5C51996F0A018AF2] PRIMARY KEY CLUSTERED 
(
	[InstanceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[instances] ON
INSERT [dbo].[instances] ([InstanceID], [InstanceName], [Telephone], [MobileNo], [Version], [Logo], [LastUpdateDateTime], [LastBackupDate], [LastRestoreDate], [LastRestoreUpto], [LastResetDate], [CreatedDate]) VALUES (1, N'ins1', N'97456', N'98745', N'1', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[instances] OFF
/****** Object:  Table [dbo].[instance_settings]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[instance_settings](
	[InstanceID] [bigint] IDENTITY(1,1) NOT NULL,
	[Tax1Name] [varchar](50) NULL,
	[Tax1Value] [decimal](10, 2) NOT NULL,
	[Tax2Name] [varchar](50) NULL,
	[Tax2Value] [decimal](10, 2) NOT NULL,
	[Tax3Name] [varchar](50) NULL,
	[Tax3Value] [decimal](10, 2) NOT NULL,
	[BillNoReset] [int] NOT NULL,
	[EmailFrom] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[InstanceLogo] [int] NOT NULL,
	[PosBillPrintLogo] [int] NOT NULL,
	[PosBillPrintHoliday] [varchar](150) NOT NULL,
	[PosDeliveryDays] [bigint] NOT NULL,
	[PosItemOrder] [int] NOT NULL,
	[PosItemLocalNameDisplay] [int] NOT NULL,
	[PosItemLocalNameBillPrint] [int] NOT NULL,
	[CountryCode] [varchar](10) NULL,
	[MobileNo] [varchar](12) NULL,
	[AccountSID] [varchar](50) NULL,
	[AuthToken] [varchar](255) NULL,
	[HangerRate] [decimal](10, 3) NOT NULL,
	[MessageEndOfBill] [varchar](255) NULL,
	[TnCEnglish] [varchar](255) NULL,
	[TnCLocalLanguage] [varchar](255) NULL,
	[ItemwiseReportLocalLanguage] [int] NOT NULL,
	[MaxDiscountPercentage] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK__instance__5C51996F11E19DA5] PRIMARY KEY CLUSTERED 
(
	[InstanceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ModuleMaster]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ModuleMaster](
	[moduleid] [bigint] IDENTITY(1,1) NOT NULL,
	[moduleName] [varchar](50) NULL,
	[moduleDesc] [varchar](max) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_ModuleMaster] PRIMARY KEY CLUSTERED 
(
	[moduleid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ModuleMaster] ON
INSERT [dbo].[ModuleMaster] ([moduleid], [moduleName], [moduleDesc], [status]) VALUES (1, N'module1', N'module', N'active')
INSERT [dbo].[ModuleMaster] ([moduleid], [moduleName], [moduleDesc], [status]) VALUES (2, N'module2', N'module', N'active')
SET IDENTITY_INSERT [dbo].[ModuleMaster] OFF
/****** Object:  Table [dbo].[MenuMaster]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MenuMaster](
	[menuid] [bigint] IDENTITY(1,1) NOT NULL,
	[menuName] [varchar](50) NULL,
	[menuDesc] [varchar](max) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_MenuMaster] PRIMARY KEY CLUSTERED 
(
	[menuid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[office_branch]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[office_branch](
	[OfficeBranchID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[BranchName] [varchar](150) NOT NULL,
	[CivilNumber] [varchar](20) NOT NULL,
	[Email] [varchar](150) NOT NULL,
	[Address] [varchar](255) NOT NULL,
	[Contact] [varchar](15) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__office_b__B0DB47406BBB079F] PRIMARY KEY CLUSTERED 
(
	[OfficeBranchID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[office_branch] ON
INSERT [dbo].[office_branch] ([OfficeBranchID], [InstanceID], [UserID], [BranchName], [CivilNumber], [Email], [Address], [Contact], [CreatedDate]) VALUES (1, 1, 1, N'offic1', N'89', N'office@gmail.com', N'Manipur', N'896325414', CAST(0x0000A73F00F3DF36 AS DateTime))
INSERT [dbo].[office_branch] ([OfficeBranchID], [InstanceID], [UserID], [BranchName], [CivilNumber], [Email], [Address], [Contact], [CreatedDate]) VALUES (3, 1, 1, N'office4', N'78', N'office4@gmail.com', N'Mithalal', N'9632541521', CAST(0x0000A74000E4671A AS DateTime))
SET IDENTITY_INSERT [dbo].[office_branch] OFF
/****** Object:  Table [dbo].[Party]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Party](
	[PartyID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[PartyName] [varchar](150) NOT NULL,
	[CivilNumber] [varchar](20) NOT NULL,
	[Email] [varchar](150) NOT NULL,
	[Address] [varchar](255) NOT NULL,
	[Contact] [varchar](15) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__Party__1640CD132FF0F441] PRIMARY KEY CLUSTERED 
(
	[PartyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PageMaster]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PageMaster](
	[pageid] [bigint] IDENTITY(1,1) NOT NULL,
	[pageName] [varchar](50) NULL,
	[pageDesc] [varchar](max) NULL,
	[moduleid] [bigint] NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_PageMaster] PRIMARY KEY CLUSTERED 
(
	[pageid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[groups]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[groups](
	[GroupID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[GroupName] [varchar](150) NOT NULL,
	[GroupCode] [varchar](10) NULL,
	[ColorCode] [varchar](10) NULL,
	[Status] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK__groups__149AF30AF2666DED] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[groups] ON
INSERT [dbo].[groups] ([GroupID], [InstanceID], [UserID], [GroupName], [GroupCode], [ColorCode], [Status], [CreatedDate]) VALUES (22, 1, 1, N'Dry Clean', N'DC', N'#0c68d0', 1, CAST(0x0000A75401705078 AS DateTime))
INSERT [dbo].[groups] ([GroupID], [InstanceID], [UserID], [GroupName], [GroupCode], [ColorCode], [Status], [CreatedDate]) VALUES (23, 1, 1, N'Ironing', N'IR', N'#3cd528', 1, CAST(0x0000A74001174DA5 AS DateTime))
INSERT [dbo].[groups] ([GroupID], [InstanceID], [UserID], [GroupName], [GroupCode], [ColorCode], [Status], [CreatedDate]) VALUES (24, 1, 1, N'IroningExp', N'IREx', N'#2918ef', 1, CAST(0x0000A7550016F3CB AS DateTime))
INSERT [dbo].[groups] ([GroupID], [InstanceID], [UserID], [GroupName], [GroupCode], [ColorCode], [Status], [CreatedDate]) VALUES (25, 1, 1, N'Washing', N'W', N'#f2a528', 1, CAST(0x0000A74001179D77 AS DateTime))
INSERT [dbo].[groups] ([GroupID], [InstanceID], [UserID], [GroupName], [GroupCode], [ColorCode], [Status], [CreatedDate]) VALUES (26, 1, 1, N'WashingExp', N'WEx', N'#190404', 1, CAST(0x0000A7400117C252 AS DateTime))
SET IDENTITY_INSERT [dbo].[groups] OFF
/****** Object:  Table [dbo].[customers]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customers](
	[CustomerID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[CustomerName] [varchar](150) NOT NULL,
	[CivilNumber] [varchar](20) NULL,
	[Email] [varchar](150) NULL,
	[Address] [varchar](255) NULL,
	[Balance] [decimal](10, 3) NULL,
	[Contact] [varchar](15) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__customer__A4AE64B86658E6A8] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[customers] ON
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (1, 1, 1, N'Chaitali', N'52', N'chaitali@gmail.com', N'Prahladnagar', CAST(2.000 AS Decimal(10, 3)), N'7896541232', 1, CAST(0x0000A73F00B6875B AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (2, 1, 1, N'Manan', N'600', N'manan@gmail.com', N'Science City Road', CAST(1000.000 AS Decimal(10, 3)), N'7896532145', 1, CAST(0x0000A74000CBE420 AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (3, 1, 1, N'Dharmik', N'56', N'dharmik@gmail.com', N'Science City', CAST(500.000 AS Decimal(10, 3)), N'7865321023', 2, CAST(0x0000A73F00B9AF4F AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (5, 1, 1, N'Rikul', N'89', N'rikul@gmail.com', N'Mithalal', CAST(1000.000 AS Decimal(10, 3)), N'7963254121', 1, CAST(0x0000A74100B32825 AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (6, 1, 1, N'Nirav', N'96', N'nirav@gmail.com', N'Science City Road', CAST(1000.000 AS Decimal(10, 3)), N'7896532145', 1, CAST(0x0000A74100D0465B AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (7, 1, 1, N'Meena', N'89', N'meena@gmail.com', N'Science City Road', CAST(1000.000 AS Decimal(10, 3)), N'7563214521', 1, CAST(0x0000A74100D1F52B AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (8, 1, 1, N'Harshil', NULL, NULL, NULL, CAST(0.000 AS Decimal(10, 3)), N'9537581281', 0, CAST(0x0000A75700D8AEDD AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (9, 1, 1, N'djs', NULL, NULL, NULL, CAST(0.000 AS Decimal(10, 3)), N'9409042895', 0, CAST(0x0000A75700E84C07 AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (10, 1, 1, N'', NULL, NULL, NULL, CAST(0.000 AS Decimal(10, 3)), N'9409042895', 0, CAST(0x0000A75700E86010 AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (11, 1, 1, N'jjj', NULL, NULL, NULL, CAST(0.000 AS Decimal(10, 3)), N'9409042895', 0, CAST(0x0000A75700E96406 AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (12, 1, 1, N'', NULL, NULL, NULL, CAST(0.000 AS Decimal(10, 3)), N'9537581281', 0, CAST(0x0000A7580179836E AS DateTime))
INSERT [dbo].[customers] ([CustomerID], [InstanceID], [UserID], [CustomerName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (13, 1, 1, N'hardik', NULL, NULL, NULL, CAST(0.000 AS Decimal(10, 3)), N'9724274482', 0, CAST(0x0000A7580179EB85 AS DateTime))
SET IDENTITY_INSERT [dbo].[customers] OFF
/****** Object:  UserDefinedFunction [dbo].[fnColumnDefault]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnColumnDefault](@sTableName varchar(128), @sColumnName varchar(128))
RETURNS varchar(4000)
AS
BEGIN
	DECLARE @sDefaultValue varchar(4000)

	SELECT	@sDefaultValue = dbo.fnCleanDefaultValue(COLUMN_DEFAULT)
	FROM	INFORMATION_SCHEMA.COLUMNS
	WHERE	TABLE_NAME = @sTableName
	 AND 	COLUMN_NAME = @sColumnName

	RETURN 	@sDefaultValue

END
GO
/****** Object:  Table [dbo].[Expense_Mst]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Expense_Mst](
	[ExpenseItemID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[ItemName] [varchar](255) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__Expense___E41A54D4E8612B97] PRIMARY KEY CLUSTERED 
(
	[ExpenseItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Expense_Mst] ON
INSERT [dbo].[Expense_Mst] ([ExpenseItemID], [InstanceID], [ItemName], [Status], [CreatedDate]) VALUES (1, 1, N'Expense1', 1, CAST(0x0000A73F00ED7DC9 AS DateTime))
INSERT [dbo].[Expense_Mst] ([ExpenseItemID], [InstanceID], [ItemName], [Status], [CreatedDate]) VALUES (3, 1, N'Expense4', 2, CAST(0x0000A74000DE2B90 AS DateTime))
SET IDENTITY_INSERT [dbo].[Expense_Mst] OFF
/****** Object:  StoredProcedure [dbo].[SP_ModuleMaster_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'ModuleMaster'
-- Gets: @moduleid bigint
-- Gets: @moduleName varchar(50)
-- Gets: @moduleDesc VARCHAR(500)
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_ModuleMaster_Update]
	@moduleid bigint,
	@moduleName varchar(50),
	@moduleDesc VARCHAR(500),
	@status varchar(50)
	--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[ModuleMaster]
SET 
	[moduleName] = @moduleName,
	[moduleDesc] = @moduleDesc,
	[status] = @status
WHERE
	[moduleid] = @moduleid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_ModuleMaster_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'ModuleMaster'
-- based on the Primary Key.
-- Gets: @moduleid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_ModuleMaster_SelectOne]
	@moduleid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[moduleid],
	[moduleName],
	[moduleDesc],
	[status]
FROM [dbo].[ModuleMaster]
WHERE
	[moduleid] = @moduleid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_ModuleMaster_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'ModuleMaster'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_ModuleMaster_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[moduleid],
	[moduleName],
	[moduleDesc],
	[status]
FROM [dbo].[ModuleMaster]
ORDER BY 
	[moduleid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_ModuleMaster_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'ModuleMaster'
-- Gets: @moduleName varchar(50)
-- Gets: @moduleDesc VARCHAR(500)
-- Gets: @status varchar(50)
-- Returns: @moduleid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_ModuleMaster_Insert]
	@moduleName varchar(50),
	@moduleDesc VARCHAR(500),
	@status varchar(50),
	@moduleid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[ModuleMaster]
(
	[moduleName],
	[moduleDesc],
	[status]
)
VALUES
(
	@moduleName,
	@moduleDesc,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @moduleid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_ModuleMaster_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'ModuleMaster'
-- using the Primary Key. 
-- Gets: @moduleid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_ModuleMaster_Delete]
	@moduleid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[ModuleMaster]
WHERE
	[moduleid] = @moduleid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_MenuMaster_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'MenuMaster'
-- Gets: @menuid bigint
-- Gets: @menuName varchar(50)
-- Gets: @menuDesc VARCHAR(500)
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_MenuMaster_Update]
	@menuid bigint,
	@menuName varchar(50),
	@menuDesc VARCHAR(500),
	@status varchar(50)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[MenuMaster]
SET 
	[menuName] = @menuName,
	[menuDesc] = @menuDesc,
	[status] = @status
WHERE
	[menuid] = @menuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_MenuMaster_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'MenuMaster'
-- based on the Primary Key.
-- Gets: @menuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_MenuMaster_SelectOne]
	@menuid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[menuid],
	[menuName],
	[menuDesc],
	[status]
FROM [dbo].[MenuMaster]
WHERE
	[menuid] = @menuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_MenuMaster_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'MenuMaster'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_MenuMaster_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[menuid],
	[menuName],
	[menuDesc],
	[status]
FROM [dbo].[MenuMaster]
ORDER BY 
	[menuid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_MenuMaster_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'MenuMaster'
-- Gets: @menuName varchar(50)
-- Gets: @menuDesc VARCHAR(500)
-- Gets: @status varchar(50)
-- Returns: @menuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_MenuMaster_Insert]
	@menuName varchar(50),
	@menuDesc VARCHAR(500),
	@status varchar(50),
	@menuid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[MenuMaster]
(
	[menuName],
	[menuDesc],
	[status]
)
VALUES
(
	@menuName,
	@menuDesc,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @menuid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_MenuMaster_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'MenuMaster'
-- using the Primary Key. 
-- Gets: @menuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_MenuMaster_Delete]
	@menuid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[MenuMaster]
WHERE
	[menuid] = @menuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_instances_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'instances'
-- Gets: @InstanceID bigint
-- Gets: @InstanceName varchar(255)
-- Gets: @Telephone varchar(15)
-- Gets: @MobileNo varchar(15)
-- Gets: @Version varchar(20)
-- Gets: @Logo varchar(35)
-- Gets: @LastUpdateDateTime datetime
-- Gets: @LastBackupDate datetime
-- Gets: @LastRestoreDate datetime
-- Gets: @LastRestoreUpto datetime
-- Gets: @LastResetDate datetime
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instances_Update]
	@InstanceID bigint,
	@InstanceName varchar(255),
	@Telephone varchar(15),
	@MobileNo varchar(15),
	@Version varchar(20),
	@Logo varchar(35),
	@LastUpdateDateTime datetime,
	@LastBackupDate datetime,
	@LastRestoreDate datetime,
	@LastRestoreUpto datetime,
	@LastResetDate datetime,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[instances]
SET 
	[InstanceName] = @InstanceName,
	[Telephone] = @Telephone,
	[MobileNo] = @MobileNo,
	[Version] = @Version,
	[Logo] = @Logo,
	[LastUpdateDateTime] = @LastUpdateDateTime,
	[LastBackupDate] = @LastBackupDate,
	[LastRestoreDate] = @LastRestoreDate,
	[LastRestoreUpto] = @LastRestoreUpto,
	[LastResetDate] = @LastResetDate,
	[CreatedDate] = @CreatedDate
WHERE
	[InstanceID] = @InstanceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_instances_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'instances'
-- based on the Primary Key.
-- Gets: @InstanceID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instances_SelectOne]
	@InstanceID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[InstanceID],
	[InstanceName],
	[Telephone],
	[MobileNo],
	[Version],
	[Logo],
	[LastUpdateDateTime],
	[LastBackupDate],
	[LastRestoreDate],
	[LastRestoreUpto],
	[LastResetDate],
	[CreatedDate]
FROM [dbo].[instances]
WHERE
	[InstanceID] = @InstanceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_instances_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'instances'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instances_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[InstanceID],
	[InstanceName],
	[Telephone],
	[MobileNo],
	[Version],
	[Logo],
	[LastUpdateDateTime],
	[LastBackupDate],
	[LastRestoreDate],
	[LastRestoreUpto],
	[LastResetDate],
	[CreatedDate]
FROM [dbo].[instances]
ORDER BY 
	[InstanceID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_instances_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'instances'
-- Gets: @InstanceID bigint
-- Gets: @InstanceName varchar(255)
-- Gets: @Telephone varchar(15)
-- Gets: @MobileNo varchar(15)
-- Gets: @Version varchar(20)
-- Gets: @Logo varchar(35)
-- Gets: @LastUpdateDateTime datetime
-- Gets: @LastBackupDate datetime
-- Gets: @LastRestoreDate datetime
-- Gets: @LastRestoreUpto datetime
-- Gets: @LastResetDate datetime
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instances_Insert]
	@InstanceID bigint output,
	@InstanceName varchar(255),
	@Telephone varchar(15),
	@MobileNo varchar(15),
	@Version varchar(20),
	@Logo varchar(35),
	@LastUpdateDateTime datetime,
	@LastBackupDate datetime,
	@LastRestoreDate datetime,
	@LastRestoreUpto datetime,
	@LastResetDate datetime,
	@CreatedDate datetime
	--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[instances]
(
--	[InstanceID],
	[InstanceName],
	[Telephone],
	[MobileNo],
	[Version],
	[Logo],
	[LastUpdateDateTime],
	[LastBackupDate],
	[LastRestoreDate],
	[LastRestoreUpto],
	[LastResetDate],
	[CreatedDate]
)
VALUES
(
--	@InstanceID,
	@InstanceName,
	@Telephone,
	@MobileNo,
	ISNULL(@Version, ('1')),
	@Logo,
	@LastUpdateDateTime,
	@LastBackupDate,
	@LastRestoreDate,
	@LastRestoreUpto,
	@LastResetDate,
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @InstanceID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_instances_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'instances'
-- using the Primary Key. 
-- Gets: @InstanceID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instances_Delete]
	@InstanceID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[instances]
WHERE
	[InstanceID] = @InstanceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_instance_settings_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'instance_settings'
-- Gets: @InstanceID bigint
-- Gets: @Tax1Name varchar(50)
-- Gets: @Tax1Value decimal(10, 2)
-- Gets: @Tax2Name varchar(50)
-- Gets: @Tax2Value decimal(10, 2)
-- Gets: @Tax3Name varchar(50)
-- Gets: @Tax3Value decimal(10, 2)
-- Gets: @BillNoReset int
-- Gets: @EmailFrom varchar(255)
-- Gets: @Password varchar(255)
-- Gets: @InstanceLogo int
-- Gets: @PosBillPrintLogo int
-- Gets: @PosBillPrintHoliday varchar(150)
-- Gets: @PosDeliveryDays bigint
-- Gets: @PosItemOrder int
-- Gets: @PosItemLocalNameDisplay int
-- Gets: @PosItemLocalNameBillPrint int
-- Gets: @CountryCode varchar(10)
-- Gets: @MobileNo varchar(12)
-- Gets: @AccountSID varchar(50)
-- Gets: @AuthToken varchar(255)
-- Gets: @HangerRate decimal(10, 3)
-- Gets: @MessageEndOfBill varchar(255)
-- Gets: @TnCEnglish varchar(255)
-- Gets: @TnCLocalLanguage varchar(255)
-- Gets: @ItemwiseReportLocalLanguage int
-- Gets: @MaxDiscountPercentage decimal(10, 2)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instance_settings_Update]
	@InstanceID bigint,
	@Tax1Name varchar(50),
	@Tax1Value decimal(10, 2),
	@Tax2Name varchar(50),
	@Tax2Value decimal(10, 2),
	@Tax3Name varchar(50),
	@Tax3Value decimal(10, 2),
	@BillNoReset int,
	@EmailFrom varchar(255),
	@Password varchar(255),
	@InstanceLogo int,
	@PosBillPrintLogo int,
	@PosBillPrintHoliday varchar(150),
	@PosDeliveryDays bigint,
	@PosItemOrder int,
	@PosItemLocalNameDisplay int,
	@PosItemLocalNameBillPrint int,
	@CountryCode varchar(10),
	@MobileNo varchar(12),
	@AccountSID varchar(50),
	@AuthToken varchar(255),
	@HangerRate decimal(10, 3),
	@MessageEndOfBill varchar(255),
	@TnCEnglish varchar(255),
	@TnCLocalLanguage varchar(255),
	@ItemwiseReportLocalLanguage int,
	@MaxDiscountPercentage decimal(10, 2)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[instance_settings]
SET 
	[Tax1Name] = @Tax1Name,
	[Tax1Value] = @Tax1Value,
	[Tax2Name] = @Tax2Name,
	[Tax2Value] = @Tax2Value,
	[Tax3Name] = @Tax3Name,
	[Tax3Value] = @Tax3Value,
	[BillNoReset] = @BillNoReset,
	[EmailFrom] = @EmailFrom,
	[Password] = @Password,
	[InstanceLogo] = @InstanceLogo,
	[PosBillPrintLogo] = @PosBillPrintLogo,
	[PosBillPrintHoliday] = @PosBillPrintHoliday,
	[PosDeliveryDays] = @PosDeliveryDays,
	[PosItemOrder] = @PosItemOrder,
	[PosItemLocalNameDisplay] = @PosItemLocalNameDisplay,
	[PosItemLocalNameBillPrint] = @PosItemLocalNameBillPrint,
	[CountryCode] = @CountryCode,
	[MobileNo] = @MobileNo,
	[AccountSID] = @AccountSID,
	[AuthToken] = @AuthToken,
	[HangerRate] = @HangerRate,
	[MessageEndOfBill] = @MessageEndOfBill,
	[TnCEnglish] = @TnCEnglish,
	[TnCLocalLanguage] = @TnCLocalLanguage,
	[ItemwiseReportLocalLanguage] = @ItemwiseReportLocalLanguage,
	[MaxDiscountPercentage] = @MaxDiscountPercentage
WHERE
	[InstanceID] = @InstanceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_instance_settings_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'instance_settings'
-- based on the Primary Key.
-- Gets: @InstanceID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instance_settings_SelectOne]
	@InstanceID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[InstanceID],
	[Tax1Name],
	[Tax1Value],
	[Tax2Name],
	[Tax2Value],
	[Tax3Name],
	[Tax3Value],
	[BillNoReset],
	[EmailFrom],
	[Password],
	[InstanceLogo],
	[PosBillPrintLogo],
	[PosBillPrintHoliday],
	[PosDeliveryDays],
	[PosItemOrder],
	[PosItemLocalNameDisplay],
	[PosItemLocalNameBillPrint],
	[CountryCode],
	[MobileNo],
	[AccountSID],
	[AuthToken],
	[HangerRate],
	[MessageEndOfBill],
	[TnCEnglish],
	[TnCLocalLanguage],
	[ItemwiseReportLocalLanguage],
	[MaxDiscountPercentage]
FROM [dbo].[instance_settings]
WHERE
	[InstanceID] = @InstanceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_instance_settings_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'instance_settings'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instance_settings_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[InstanceID],
	[Tax1Name],
	[Tax1Value],
	[Tax2Name],
	[Tax2Value],
	[Tax3Name],
	[Tax3Value],
	[BillNoReset],
	[EmailFrom],
	[Password],
	[InstanceLogo],
	[PosBillPrintLogo],
	[PosBillPrintHoliday],
	[PosDeliveryDays],
	[PosItemOrder],
	[PosItemLocalNameDisplay],
	[PosItemLocalNameBillPrint],
	[CountryCode],
	[MobileNo],
	[AccountSID],
	[AuthToken],
	[HangerRate],
	[MessageEndOfBill],
	[TnCEnglish],
	[TnCLocalLanguage],
	[ItemwiseReportLocalLanguage],
	[MaxDiscountPercentage]
FROM [dbo].[instance_settings]
ORDER BY 
	[InstanceID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_instance_settings_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'instance_settings'
-- Gets: @InstanceID bigint
-- Gets: @Tax1Name varchar(50)
-- Gets: @Tax1Value decimal(10, 2)
-- Gets: @Tax2Name varchar(50)
-- Gets: @Tax2Value decimal(10, 2)
-- Gets: @Tax3Name varchar(50)
-- Gets: @Tax3Value decimal(10, 2)
-- Gets: @BillNoReset int
-- Gets: @EmailFrom varchar(255)
-- Gets: @Password varchar(255)
-- Gets: @InstanceLogo int
-- Gets: @PosBillPrintLogo int
-- Gets: @PosBillPrintHoliday varchar(150)
-- Gets: @PosDeliveryDays bigint
-- Gets: @PosItemOrder int
-- Gets: @PosItemLocalNameDisplay int
-- Gets: @PosItemLocalNameBillPrint int
-- Gets: @CountryCode varchar(10)
-- Gets: @MobileNo varchar(12)
-- Gets: @AccountSID varchar(50)
-- Gets: @AuthToken varchar(255)
-- Gets: @HangerRate decimal(10, 3)
-- Gets: @MessageEndOfBill varchar(255)
-- Gets: @TnCEnglish varchar(255)
-- Gets: @TnCLocalLanguage varchar(255)
-- Gets: @ItemwiseReportLocalLanguage int
-- Gets: @MaxDiscountPercentage decimal(10, 2)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instance_settings_Insert]
	@InstanceID bigint output,
	@Tax1Name varchar(50),
	@Tax1Value decimal(10, 2),
	@Tax2Name varchar(50),
	@Tax2Value decimal(10, 2),
	@Tax3Name varchar(50),
	@Tax3Value decimal(10, 2),
	@BillNoReset int,
	@EmailFrom varchar(255),
	@Password varchar(255),
	@InstanceLogo int,
	@PosBillPrintLogo int,
	@PosBillPrintHoliday varchar(150),
	@PosDeliveryDays bigint,
	@PosItemOrder int,
	@PosItemLocalNameDisplay int,
	@PosItemLocalNameBillPrint int,
	@CountryCode varchar(10),
	@MobileNo varchar(12),
	@AccountSID varchar(50),
	@AuthToken varchar(255),
	@HangerRate decimal(10, 3),
	@MessageEndOfBill varchar(255),
	@TnCEnglish varchar(255),
	@TnCLocalLanguage varchar(255),
	@ItemwiseReportLocalLanguage int,
	@MaxDiscountPercentage decimal(10, 2)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[instance_settings]
(
--	[InstanceID],
	[Tax1Name],
	[Tax1Value],
	[Tax2Name],
	[Tax2Value],
	[Tax3Name],
	[Tax3Value],
	[BillNoReset],
	[EmailFrom],
	[Password],
	[InstanceLogo],
	[PosBillPrintLogo],
	[PosBillPrintHoliday],
	[PosDeliveryDays],
	[PosItemOrder],
	[PosItemLocalNameDisplay],
	[PosItemLocalNameBillPrint],
	[CountryCode],
	[MobileNo],
	[AccountSID],
	[AuthToken],
	[HangerRate],
	[MessageEndOfBill],
	[TnCEnglish],
	[TnCLocalLanguage],
	[ItemwiseReportLocalLanguage],
	[MaxDiscountPercentage]
)
VALUES
(
--	@InstanceID,
	@Tax1Name,
	ISNULL(@Tax1Value, ('0.00')),
	@Tax2Name,
	ISNULL(@Tax2Value, ('0.00')),
	@Tax3Name,
	ISNULL(@Tax3Value, ('0.00')),
	ISNULL(@BillNoReset, ((1))),
	@EmailFrom,
	@Password,
	ISNULL(@InstanceLogo, ((0))),
	ISNULL(@PosBillPrintLogo, ((0))),
	@PosBillPrintHoliday,
	ISNULL(@PosDeliveryDays, ((1))),
	ISNULL(@PosItemOrder, ((1))),
	ISNULL(@PosItemLocalNameDisplay, ((0))),
	ISNULL(@PosItemLocalNameBillPrint, ((0))),
	@CountryCode,
	@MobileNo,
	@AccountSID,
	@AuthToken,
	ISNULL(@HangerRate, ('0.000')),
	@MessageEndOfBill,
	@TnCEnglish,
	@TnCLocalLanguage,
	ISNULL(@ItemwiseReportLocalLanguage, ((0))),
	ISNULL(@MaxDiscountPercentage, ('0.00'))
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @InstanceID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_instance_settings_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'instance_settings'
-- using the Primary Key. 
-- Gets: @InstanceID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_instance_settings_Delete]
	@InstanceID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[instance_settings]
WHERE
	[InstanceID] = @InstanceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  Table [dbo].[PreSubMenu]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PreSubMenu](
	[presubmenuid] [bigint] IDENTITY(1,1) NOT NULL,
	[presubmenuName] [varchar](50) NULL,
	[presubmenuDesc] [varchar](max) NULL,
	[menuid] [bigint] NULL,
	[submenuid] [bigint] NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_PreSubMenu] PRIMARY KEY CLUSTERED 
(
	[presubmenuid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[posbillcount]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posbillcount](
	[PosBillCountID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[TotalBills] [bigint] NOT NULL,
	[BillDate] [date] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__posbillc__DF33D6FF446C6526] PRIMARY KEY CLUSTERED 
(
	[PosBillCountID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchase_items_master]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchase_items_master](
	[PurchaseItemID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[ItemName] [varchar](150) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__purchase__B48BB6A79C5C8BD0] PRIMARY KEY CLUSTERED 
(
	[PurchaseItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[purchase_items_master] ON
INSERT [dbo].[purchase_items_master] ([PurchaseItemID], [InstanceID], [UserID], [ItemName], [Status], [CreatedDate]) VALUES (1, 1, 1, N'Item1', 1, CAST(0x0000A73F00D3F605 AS DateTime))
INSERT [dbo].[purchase_items_master] ([PurchaseItemID], [InstanceID], [UserID], [ItemName], [Status], [CreatedDate]) VALUES (2, 1, 1, N'Item3', 1, CAST(0x0000A74000DAA1C5 AS DateTime))
SET IDENTITY_INSERT [dbo].[purchase_items_master] OFF
/****** Object:  StoredProcedure [dbo].[SP_EmployeeMaster_Update]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'EmployeeMaster'
-- Gets: @empid bigint
-- Gets: @empName varchar(50)
-- Gets: @empAdd VARCHAR(500)
-- Gets: @empMobile varchar(15)
-- Gets: @empPhoneno varchar(20)
-- Gets: @empemailId varchar(50)
-- Gets: @isRetired varchar(50)
-- Gets: @isDeleted varchar(50)
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_EmployeeMaster_Update]
	@empid bigint,
	@empName varchar(50),
	@empAdd varchar(300),
	@empMobile varchar(15),
	@empPhoneno varchar(20),
	@empemailId varchar(50),
	@isRetired varchar(50),
	@isDeleted varchar(50),
	@status varchar(50)
	--@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[EmployeeMaster]
SET 
	[empName] = @empName,
	[empAdd] = @empAdd,
	[empMobile] = @empMobile,
	[empPhoneno] = @empPhoneno,
	[empemailId] = @empemailId,
	[isRetired] = @isRetired,
	[isDeleted] = @isDeleted,
	[status] = @status
WHERE
	[empid] = @empid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeMaster_SelectOne]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'EmployeeMaster'
-- based on the Primary Key.
-- Gets: @empid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_EmployeeMaster_SelectOne]
	@empid bigint
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[empid],
	[empName],
	[empAdd],
	[empMobile],
	[empPhoneno],
	[empemailId],
	[isRetired],
	[isDeleted],
	[status]
FROM [dbo].[EmployeeMaster]
WHERE
	[empid] = @empid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeMaster_SelectAll]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'EmployeeMaster'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_EmployeeMaster_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[empid],
	[empName],
	[empAdd],
	[empMobile],
	[empPhoneno],
	[empemailId],
	[isRetired],
	[isDeleted],
	[status]
FROM [dbo].[EmployeeMaster]
ORDER BY 
	[empid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeMaster_Insert]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'EmployeeMaster'
-- Gets: @empName varchar(50)
-- Gets: @empAdd VARCHAR(500)
-- Gets: @empMobile varchar(15)
-- Gets: @empPhoneno varchar(20)
-- Gets: @empemailId varchar(50)
-- Gets: @isRetired varchar(50)
-- Gets: @isDeleted varchar(50)
-- Gets: @status varchar(50)
-- Returns: @empid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_EmployeeMaster_Insert]
	@empName varchar(50),
	@empAdd varchar(300),
	@empMobile varchar(15),
	@empPhoneno varchar(20),
	@empemailId varchar(50),
	@isRetired varchar(50),
	@isDeleted varchar(50),
	@status varchar(50),
	@empid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[EmployeeMaster]
(
	[empName],
	[empAdd],
	[empMobile],
	[empPhoneno],
	[empemailId],
	[isRetired],
	[isDeleted],
	[status]
)
VALUES
(
	@empName,
	@empAdd,
	@empMobile,
	@empPhoneno,
	@empemailId,
	@isRetired,
	@isDeleted,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @empid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeMaster_Delete]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'EmployeeMaster'
-- using the Primary Key. 
-- Gets: @empid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_EmployeeMaster_Delete]
	@empid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[EmployeeMaster]
WHERE
	[empid] = @empid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  Table [dbo].[sms_templates]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sms_templates](
	[SmsID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[TemplateName] [varchar](150) NOT NULL,
	[Details] [varchar](max) NOT NULL,
	[ismart_sms_language] [int] NOT NULL,
 CONSTRAINT [PK__sms_temp__A3EF293F05332078] PRIMARY KEY CLUSTERED 
(
	[SmsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[sms_templates] ON
INSERT [dbo].[sms_templates] ([SmsID], [InstanceID], [UserID], [TemplateName], [Details], [ismart_sms_language]) VALUES (4, 1, 1, N'Template45', N'Template Details', 2)
INSERT [dbo].[sms_templates] ([SmsID], [InstanceID], [UserID], [TemplateName], [Details], [ismart_sms_language]) VALUES (5, 1, 1, N'Template3', N'Template Details', 1)
SET IDENTITY_INSERT [dbo].[sms_templates] OFF
/****** Object:  Table [dbo].[suppliers]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[suppliers](
	[SupplierID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[SupplierName] [varchar](150) NOT NULL,
	[CivilNumber] [varchar](20) NOT NULL,
	[Email] [varchar](150) NOT NULL,
	[Address] [varchar](255) NOT NULL,
	[Balance] [decimal](10, 3) NOT NULL,
	[Contact] [varchar](15) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__supplier__4BE6669472AD6AE3] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[suppliers] ON
INSERT [dbo].[suppliers] ([SupplierID], [InstanceID], [UserID], [SupplierName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (1, 1, 1, N'Yukti', N'45', N'yukti@gmail.com', N'Maninagar', CAST(600.230 AS Decimal(10, 3)), N'6326541210', 1, CAST(0x0000A73F00CC556B AS DateTime))
INSERT [dbo].[suppliers] ([SupplierID], [InstanceID], [UserID], [SupplierName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (3, 1, 1, N'Meera', N'90', N'meera@gmail.com', N'Maninagar', CAST(1000.000 AS Decimal(10, 3)), N'8756321452', 2, CAST(0x0000A74000D37ED0 AS DateTime))
INSERT [dbo].[suppliers] ([SupplierID], [InstanceID], [UserID], [SupplierName], [CivilNumber], [Email], [Address], [Balance], [Contact], [Status], [CreatedDate]) VALUES (4, 1, 1, N'Maya', N'89', N'maya@gmail.com', N'GeetaMandir', CAST(900.000 AS Decimal(10, 3)), N'7563214521', 1, CAST(0x0000A73F00CDF06F AS DateTime))
SET IDENTITY_INSERT [dbo].[suppliers] OFF
/****** Object:  StoredProcedure [dbo].[SP_UserMaster_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'UserMaster'
-- Gets: @userid bigint
-- Gets: @umusername varchar(50)
-- Gets: @umpassword varchar(50)
-- Gets: @empid bigint
-- Gets: @rollid bigint
-- Gets: @rollLocation VARCHAR(500)
-- Gets: @createDateTime datetime
-- Gets: @isRetired bit
-- Gets: @isDeleted bit
-- Gets: @insertedBy varchar(50)
-- Gets: @createdBy varchar(50)
-- Gets: @deleteBy varchar(50)
-- Gets: @viewedBy varchar(50)
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserMaster_Update]
	@userid bigint,
	@umusername varchar(50),
	@umpassword varchar(50),
	@empid bigint,
	@rollid bigint,
	@rollLocation VARCHAR(500),
	@createDateTime datetime,
	@isRetired bit,
	@isDeleted bit,
	@insertedBy varchar(50),
	@createdBy varchar(50),
	@deleteBy varchar(50),
	@viewedBy varchar(50),
	@status varchar(50)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[UserMaster]
SET 
	[umusername] = @umusername,
	[umpassword] = @umpassword,
	[empid] = @empid,
	[rollid] = @rollid,
	[rollLocation] = @rollLocation,
	[createDateTime] = @createDateTime,
	[isRetired] = @isRetired,
	[isDeleted] = @isDeleted,
	[insertedBy] = @insertedBy,
	[createdBy] = @createdBy,
	[deleteBy] = @deleteBy,
	[viewedBy] = @viewedBy,
	[status] = @status
WHERE
	[userid] = @userid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_UserMaster_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'UserMaster'
-- based on the Primary Key.
-- Gets: @userid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserMaster_SelectOne]
	@userid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[userid],
	[umusername],
	[umpassword],
	[empid],
	[rollid],
	[rollLocation],
	[createDateTime],
	[isRetired],
	[isDeleted],
	[insertedBy],
	[createdBy],
	[deleteBy],
	[viewedBy],
	[status]
FROM [dbo].[UserMaster]
WHERE
	[userid] = @userid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_UserMaster_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'UserMaster'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserMaster_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[userid],
	[umusername],
	[umpassword],
	[empid],
	[rollid],
	[rollLocation],
	[createDateTime],
	[isRetired],
	[isDeleted],
	[insertedBy],
	[createdBy],
	[deleteBy],
	[viewedBy],
	[status]
FROM [dbo].[UserMaster]
ORDER BY 
	[userid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_UserMaster_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'UserMaster'
-- Gets: @umusername varchar(50)
-- Gets: @umpassword varchar(50)
-- Gets: @empid bigint
-- Gets: @rollid bigint
-- Gets: @rollLocation VARCHAR(500)
-- Gets: @createDateTime datetime
-- Gets: @isRetired bit
-- Gets: @isDeleted bit
-- Gets: @insertedBy varchar(50)
-- Gets: @createdBy varchar(50)
-- Gets: @deleteBy varchar(50)
-- Gets: @viewedBy varchar(50)
-- Gets: @status varchar(50)
-- Returns: @userid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserMaster_Insert]
	@umusername varchar(50),
	@umpassword varchar(50),
	@empid bigint,
	@rollid bigint,
	@rollLocation VARCHAR(500),
	@createDateTime datetime,
	@isRetired bit,
	@isDeleted bit,
	@insertedBy varchar(50),
	@createdBy varchar(50),
	@deleteBy varchar(50),
	@viewedBy varchar(50),
	@status varchar(50),
	@userid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[UserMaster]
(
	[umusername],
	[umpassword],
	[empid],
	[rollid],
	[rollLocation],
	[createDateTime],
	[isRetired],
	[isDeleted],
	[insertedBy],
	[createdBy],
	[deleteBy],
	[viewedBy],
	[status]
)
VALUES
(
	@umusername,
	@umpassword,
	@empid,
	@rollid,
	@rollLocation,
	@createDateTime,
	@isRetired,
	@isDeleted,
	@insertedBy,
	@createdBy,
	@deleteBy,
	@viewedBy,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @userid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_UserMaster_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'UserMaster'
-- using the Primary Key. 
-- Gets: @userid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserMaster_Delete]
	@userid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[UserMaster]
WHERE
	[userid] = @userid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_RollMaster_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'RollMaster'
-- Gets: @rollid bigint
-- Gets: @rollName varchar(50)
-- Gets: @rollDesc VARCHAR(500)
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_RollMaster_Update]
	@rollid bigint,
	@rollName varchar(50),
	@rollDesc VARCHAR(500),
	@status varchar(50)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[RollMaster]
SET 
	[rollName] = @rollName,
	[rollDesc] = @rollDesc,
	[status] = @status
WHERE
	[rollid] = @rollid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_RollMaster_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'RollMaster'
-- based on the Primary Key.
-- Gets: @rollid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_RollMaster_SelectOne]
	@rollid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[rollid],
	[rollName],
	[rollDesc],
	[status]
FROM [dbo].[RollMaster]
WHERE
	[rollid] = @rollid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_RollMaster_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'RollMaster'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_RollMaster_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[rollid],
	[rollName],
	[rollDesc],
	[status]
FROM [dbo].[RollMaster]
ORDER BY 
	[rollid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_RollMaster_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'RollMaster'
-- Gets: @rollName varchar(50)
-- Gets: @rollDesc VARCHAR(500)
-- Gets: @status varchar(50)
-- Returns: @rollid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_RollMaster_Insert]
	@rollName varchar(50),
	@rollDesc VARCHAR(500),
	@status varchar(50),
	@rollid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[RollMaster]
(
	[rollName],
	[rollDesc],
	[status]
)
VALUES
(
	@rollName,
	@rollDesc,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @rollid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_RollMaster_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'RollMaster'
-- using the Primary Key. 
-- Gets: @rollid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_RollMaster_Delete]
	@rollid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[RollMaster]
WHERE
	[rollid] = @rollid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_SubMenuMaster_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'SubMenuMaster'
-- Gets: @submenuid bigint
-- Gets: @submenuName varchar(50)
-- Gets: @submenuDesc VARCHAR(500)
-- Gets: @menuid bigint
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_SubMenuMaster_Update]
	@submenuid bigint,
	@submenuName varchar(50),
	@submenuDesc VARCHAR(500),
	@menuid bigint,
	@status varchar(50)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[SubMenuMaster]
SET 
	[submenuName] = @submenuName,
	[submenuDesc] = @submenuDesc,
	[menuid] = @menuid,
	[status] = @status
WHERE
	[submenuid] = @submenuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_SubMenuMaster_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'SubMenuMaster'
-- based on the Primary Key.
-- Gets: @submenuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_SubMenuMaster_SelectOne]
	@submenuid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[submenuid],
	[submenuName],
	[submenuDesc],
	[menuid],
	[status]
FROM [dbo].[SubMenuMaster]
WHERE
	[submenuid] = @submenuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_SubMenuMaster_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'SubMenuMaster'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_SubMenuMaster_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[submenuid],
	[submenuName],
	[submenuDesc],
	[menuid],
	[status]
FROM [dbo].[SubMenuMaster]
ORDER BY 
	[submenuid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_SubMenuMaster_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'SubMenuMaster'
-- Gets: @submenuName varchar(50)
-- Gets: @submenuDesc VARCHAR(500)
-- Gets: @menuid bigint
-- Gets: @status varchar(50)
-- Returns: @submenuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_SubMenuMaster_Insert]
	@submenuName varchar(50),
	@submenuDesc VARCHAR(500),
	@menuid bigint,
	@status varchar(50),
	@submenuid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[SubMenuMaster]
(
	[submenuName],
	[submenuDesc],
	[menuid],
	[status]
)
VALUES
(
	@submenuName,
	@submenuDesc,
	@menuid,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @submenuid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_SubMenuMaster_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'SubMenuMaster'
-- using the Primary Key. 
-- Gets: @submenuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_SubMenuMaster_Delete]
	@submenuid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[SubMenuMaster]
WHERE
	[submenuid] = @submenuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  Table [dbo].[UserRightsMaster]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserRightsMaster](
	[urid] [bigint] IDENTITY(1,1) NOT NULL,
	[userid] [bigint] NULL,
	[moduleid] [bigint] NULL,
	[rollid] [bigint] NULL,
	[pageid] [bigint] NULL,
	[empid] [bigint] NULL,
	[isDelete] [bit] NULL,
	[isView] [bit] NULL,
	[isEdit] [bit] NULL,
	[isSearch] [bit] NULL,
	[isAdd] [bit] NULL,
	[isReport] [bit] NULL,
	[createdDateTime] [datetime] NULL,
	[applyDate] [datetime] NULL,
	[createdBy] [varchar](50) NULL,
	[updatedby] [varchar](50) NULL,
	[deletedid] [varchar](50) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_UserRightsMaster] PRIMARY KEY CLUSTERED 
(
	[urid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'office_branch'
-- Gets: @OfficeBranchID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @BranchName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Contact varchar(15)
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_office_branch_Insert]
	@OfficeBranchID bigint output,
	@InstanceID bigint,
	@UserID bigint,
	@BranchName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Contact varchar(15),
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[office_branch]
(
--	[OfficeBranchID],
	[InstanceID],
	[UserID],
	[BranchName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[CreatedDate]
)
VALUES
(
--	@OfficeBranchID,
	@InstanceID,
	@UserID,
	@BranchName,
	@CivilNumber,
	@Email,
	@Address,
	@Contact,
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @OfficeBranchID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'office_branch'
-- using the Primary Key. 
-- Gets: @OfficeBranchID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_office_branch_Delete]
	@OfficeBranchID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[office_branch]
WHERE
	[OfficeBranchID] = @OfficeBranchID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  UserDefinedFunction [dbo].[fnTableColumnInfo]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE       FUNCTION [dbo].[fnTableColumnInfo](@sTableName varchar(128))
RETURNS TABLE
AS
	RETURN
	SELECT	c.name AS sColumnName,
		c.colid AS nColumnID,
		dbo.fnIsColumnPrimaryKey(@sTableName, c.name) AS bPrimaryKeyColumn,
		CASE 	WHEN t.name IN ('char', 'varchar', 'binary', 'varbinary', 'nchar', 'nvarchar') THEN 1
			WHEN t.name IN ('decimal', 'numeric') THEN 2
			ELSE 0
		END AS nAlternateType,
		c.length AS nColumnLength,
		c.prec AS nColumnPrecision,
		c.scale AS nColumnScale, 
		c.IsNullable, 
		SIGN(c.status & 128) AS IsIdentity,
		t.name as sTypeName,
		dbo.fnColumnDefault(@sTableName, c.name) AS sDefaultValue
	FROM	syscolumns c 
		INNER JOIN systypes t ON c.xtype = t.xtype and c.usertype = t.usertype
	WHERE	c.id = OBJECT_ID(@sTableName)
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_templates_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'sms_templates'
-- Gets: @SmsID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @TemplateName varchar(150)
-- Gets: @Details VARCHAR(500)
-- Gets: @ismart_sms_language int
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_templates_Update]
	@SmsID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@TemplateName varchar(150),
	@Details VARCHAR(500),
	@ismart_sms_language int
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[sms_templates]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[TemplateName] = @TemplateName,
	[Details] = @Details,
	[ismart_sms_language] = @ismart_sms_language
WHERE
	[SmsID] = @SmsID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_templates_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'sms_templates'
-- based on the Primary Key.
-- Gets: @SmsID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_templates_SelectOne]
	@SmsID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[SmsID],
	[InstanceID],
	[UserID],
	[TemplateName],
	[Details],
	[ismart_sms_language]
FROM [dbo].[sms_templates]
WHERE
	[SmsID] = @SmsID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_templates_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'sms_templates'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_templates_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[SmsID],
	[InstanceID],
	[UserID],
	[TemplateName],
	[Details],
	[ismart_sms_language]
FROM [dbo].[sms_templates]
ORDER BY 
	[SmsID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_templates_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'sms_templates'
-- Gets: @SmsID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @TemplateName varchar(150)
-- Gets: @Details VARCHAR(500)
-- Gets: @ismart_sms_language int
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_templates_Insert]
	@SmsID bigint output,
	@InstanceID bigint,
	@UserID bigint,
	@TemplateName varchar(150),
	@Details VARCHAR(500),
	@ismart_sms_language int
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[sms_templates]
(
---	[SmsID],
	[InstanceID],
	[UserID],
	[TemplateName],
	[Details],
	[ismart_sms_language]
)
VALUES
(
--	@SmsID,
	@InstanceID,
	@UserID,
	@TemplateName,
	@Details,
	ISNULL(@ismart_sms_language, ((0)))
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @SmsID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_templates_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'sms_templates'
-- using the Primary Key. 
-- Gets: @SmsID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_templates_Delete]
	@SmsID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[sms_templates]
WHERE
	[SmsID] = @SmsID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_items_master_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'purchase_items_master'
-- Gets: @PurchaseItemID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @ItemName varchar(150)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_items_master_Update]
	@PurchaseItemID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@ItemName varchar(150),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[purchase_items_master]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[ItemName] = @ItemName,
	[Status] = @Status,
	[CreatedDate] = @CreatedDate
WHERE
	[PurchaseItemID] = @PurchaseItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_items_master_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'purchase_items_master'
-- based on the Primary Key.
-- Gets: @PurchaseItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_items_master_SelectOne]
	@PurchaseItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[PurchaseItemID],
	[InstanceID],
	[UserID],
	[ItemName],
	[Status],
	[CreatedDate]
FROM [dbo].[purchase_items_master]
WHERE
	[PurchaseItemID] = @PurchaseItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_items_master_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'purchase_items_master'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_items_master_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[PurchaseItemID],
	[InstanceID],
	[UserID],
	[ItemName],
	[Status],
	[CreatedDate]
FROM [dbo].[purchase_items_master]
ORDER BY 
	[PurchaseItemID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_items_master_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'purchase_items_master'
-- Gets: @PurchaseItemID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @ItemName varchar(150)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_items_master_Insert]
	@PurchaseItemID bigint output,
	@InstanceID bigint,
	@UserID bigint,
	@ItemName varchar(150),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[purchase_items_master]
(
--	[PurchaseItemID],
	[InstanceID],
	[UserID],
	[ItemName],
	[Status],
	[CreatedDate]
)
VALUES
(
--	@PurchaseItemID,
	@InstanceID,
	@UserID,
	@ItemName,
	ISNULL(@Status, ((0))),
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @PurchaseItemID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_items_master_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'purchase_items_master'
-- using the Primary Key. 
-- Gets: @PurchaseItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_items_master_Delete]
	@PurchaseItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[purchase_items_master]
WHERE
	[PurchaseItemID] = @PurchaseItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_suppliers_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'suppliers'
-- Gets: @SupplierID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @SupplierName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Balance decimal(10, 3)
-- Gets: @Contact varchar(15)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_suppliers_Update]
	@SupplierID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@SupplierName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Balance decimal(10, 3),
	@Contact varchar(15),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[suppliers]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[SupplierName] = @SupplierName,
	[CivilNumber] = @CivilNumber,
	[Email] = @Email,
	[Address] = @Address,
	[Balance] = @Balance,
	[Contact] = @Contact,
	[Status] = @Status,
	[CreatedDate] = @CreatedDate
WHERE
	[SupplierID] = @SupplierID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_suppliers_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'suppliers'
-- based on the Primary Key.
-- Gets: @SupplierID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_suppliers_SelectOne]
	@SupplierID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[SupplierID],
	[InstanceID],
	[UserID],
	[SupplierName],
	[CivilNumber],
	[Email],
	[Address],
	[Balance],
	[Contact],
	[Status],
	[CreatedDate]
FROM [dbo].[suppliers]
WHERE
	[SupplierID] = @SupplierID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_suppliers_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'suppliers'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_suppliers_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[SupplierID],
	[InstanceID],
	[UserID],
	[SupplierName],
	[CivilNumber],
	[Email],
	[Address],
	[Balance],
	[Contact],
	[Status],
	[CreatedDate]
FROM [dbo].[suppliers]
ORDER BY 
	[SupplierID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_suppliers_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'suppliers'
-- Gets: @SupplierID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @SupplierName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Balance decimal(10, 3)
-- Gets: @Contact varchar(15)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_suppliers_Insert]
	@SupplierID bigint output,
	@InstanceID bigint,
	@UserID bigint,
	@SupplierName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Balance decimal(10, 3),
	@Contact varchar(15),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[suppliers]
(
--	[SupplierID],
	[InstanceID],
	[UserID],
	[SupplierName],
	[CivilNumber],
	[Email],
	[Address],
	[Balance],
	[Contact],
	[Status],
	[CreatedDate]
)
VALUES
(
--	@SupplierID,
	@InstanceID,
	@UserID,
	@SupplierName,
	@CivilNumber,
	@Email,
	@Address,
	ISNULL(@Balance, ('0.000')),
	@Contact,
	ISNULL(@Status, ((0))),
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @SupplierID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_suppliers_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'suppliers'
-- using the Primary Key. 
-- Gets: @SupplierID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_suppliers_Delete]
	@SupplierID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[suppliers]
WHERE
	[SupplierID] = @SupplierID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_Expense_Mst_Update]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'Expense_Mst'
-- Gets: @ExpenseItemID bigint
-- Gets: @InstanceID bigint
-- Gets: @ItemName varchar(255)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Expense_Mst_Update]
	@ExpenseItemID bigint,
	@InstanceID bigint,
	@ItemName varchar(255),
	@Status int,
	@CreatedDate datetime
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[Expense_Mst]
SET 
	[InstanceID] = @InstanceID,
	[ItemName] = @ItemName,
	[Status] = @Status,
	[CreatedDate] = @CreatedDate
WHERE
	[ExpenseItemID] = @ExpenseItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_Expense_Mst_SelectOne]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'Expense_Mst'
-- based on the Primary Key.
-- Gets: @ExpenseItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Expense_Mst_SelectOne]
	@ExpenseItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[ExpenseItemID],
	[InstanceID],
	[ItemName],
	[Status],
	[CreatedDate]
FROM [dbo].[Expense_Mst]
WHERE
	[ExpenseItemID] = @ExpenseItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_Expense_Mst_SelectAll]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'Expense_Mst'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Expense_Mst_SelectAll]
	--@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[ExpenseItemID],
	[InstanceID],
	[ItemName],
	[Status],
	[CreatedDate]
FROM [dbo].[Expense_Mst]
ORDER BY 
	[ExpenseItemID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_Expense_Mst_Insert]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'Expense_Mst'
-- Gets: @ExpenseItemID bigint
-- Gets: @InstanceID bigint
-- Gets: @ItemName varchar(255)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Expense_Mst_Insert]
	@ExpenseItemID bigint output,
	@InstanceID bigint,
	@ItemName varchar(255),
	@Status int,
	@CreatedDate datetime
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[Expense_Mst]
(
--	[ExpenseItemID],
	[InstanceID],
	[ItemName],
	[Status],
	[CreatedDate]
)
VALUES
(
--	@ExpenseItemID,
	@InstanceID,
	@ItemName,
	@Status,
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @ExpenseItemID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_Expense_Mst_Delete]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'Expense_Mst'
-- using the Primary Key. 
-- Gets: @ExpenseItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Expense_Mst_Delete]
	@ExpenseItemID bigint
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[Expense_Mst]
WHERE
	[ExpenseItemID] = @ExpenseItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  Table [dbo].[purchase_invoice]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchase_invoice](
	[InvoiceID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[OfficeBranchID] [bigint] NOT NULL,
	[BranchName] [varchar](150) NOT NULL,
	[SupplierID] [bigint] NOT NULL,
	[Contact] [varchar](15) NOT NULL,
	[TotalQuantity] [bigint] NOT NULL,
	[TotalAmount] [decimal](10, 3) NOT NULL,
	[Type] [varchar](10) NOT NULL,
	[Narration] [varchar](255) NOT NULL,
	[QuotationNo] [varchar](10) NOT NULL,
	[QuotationDate] [date] NOT NULL,
	[ReferenceNo] [varchar](10) NOT NULL,
	[InvoiceDate] [date] NOT NULL,
	[IsDeleted] [int] NOT NULL,
	[DeletedDateTime] [datetime] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__purchase__D796AAD5E404E592] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sms_logs]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sms_logs](
	[SmsLogID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[CustomerID] [bigint] NOT NULL,
	[SmsID] [bigint] NOT NULL,
	[TemplateName] [varchar](150) NOT NULL,
	[CountryCode] [varchar](10) NOT NULL,
	[FromNumber] [varchar](12) NOT NULL,
	[ToNumber] [varchar](12) NOT NULL,
	[Details] [varchar](max) NOT NULL,
	[Status] [varchar](2) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__sms_logs__7024EE15B001ECB4] PRIMARY KEY CLUSTERED 
(
	[SmsLogID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_Update]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'customers'
-- Gets: @CustomerID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @CustomerName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Balance decimal(10, 3)
-- Gets: @Contact varchar(15)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_Update]
	@CustomerID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@CustomerName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Balance decimal(10, 3),
	@Contact varchar(15),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[customers]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[CustomerName] = @CustomerName,
	[CivilNumber] = @CivilNumber,
	[Email] = @Email,
	[Address] = @Address,
	[Balance] = @Balance,
	[Contact] = @Contact,
	[Status] = @Status,
	[CreatedDate] = @CreatedDate
WHERE
	[CustomerID] = @CustomerID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_SelectOne_Contact]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'customers'based on contact
-- based on the Primary Key.
-- Gets: @CustomerID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_SelectOne_Contact]
	@Contact varchar(15)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[CustomerID],
	[InstanceID],
	[UserID],
	[CustomerName],
	[CivilNumber],
	[Email],
	[Address],
	[Balance],
	[Contact],
	[Status],
	[CreatedDate]
FROM [dbo].[customers]
WHERE
	[Contact] = @Contact
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_SelectOne]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'customers'
-- based on the Primary Key.
-- Gets: @CustomerID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_SelectOne]
	@CustomerID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[CustomerID],
	[InstanceID],
	[UserID],
	[CustomerName],
	[CivilNumber],
	[Email],
	[Address],
	[Balance],
	[Contact],
	[Status],
	[CreatedDate]
FROM [dbo].[customers]
WHERE
	[CustomerID] = @CustomerID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_SelectAll]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'customers'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[CustomerID],
	[InstanceID],
	[UserID],
	[CustomerName],
	[CivilNumber],
	[Email],
	[Address],
	[Balance],
	[Contact],
	[Status],
	[CreatedDate]
FROM [dbo].[customers]
ORDER BY 
	[CustomerID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_Insert]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'customers'
-- Gets: @CustomerID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @CustomerName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Balance decimal(10, 3)
-- Gets: @Contact varchar(15)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_Insert]
	
	@InstanceID bigint,
	@UserID bigint,
	@CustomerName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Balance decimal(10, 3),
	@Contact varchar(15),
	@Status int,
	@CreatedDate datetime,
	@CustomerID bigint output
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[customers]
(
--	[CustomerID],
	[InstanceID],
	[UserID],
	[CustomerName],
	[CivilNumber],
	[Email],
	[Address],
	[Balance],
	[Contact],
	[Status],
	[CreatedDate]
)
VALUES
(
--	@CustomerID,
	@InstanceID,
	@UserID,
	@CustomerName,
	@CivilNumber,
	@Email,
	@Address,
	ISNULL(@Balance, ('0.000')),
	@Contact,
	ISNULL(@Status, ((0))),
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @CustomerID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_Delete]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'customers'
-- using the Primary Key. 
-- Gets: @CustomerID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_Delete]
	@CustomerID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[customers]
WHERE
	[CustomerID] = @CustomerID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_groups_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'groups'
-- Gets: @GroupID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @GroupName varchar(150)
-- Gets: @GroupCode varchar(10)
-- Gets: @ColorCode varchar(10)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_groups_Update]
	@GroupID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@GroupName varchar(150),
	@GroupCode varchar(10),
	@ColorCode varchar(10),
	@Status int,
	@CreatedDate datetime
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[groups]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[GroupName] = @GroupName,
	[GroupCode] = @GroupCode,
	[ColorCode] = @ColorCode,
	[Status] = @Status,
	[CreatedDate] = @CreatedDate
WHERE
	[GroupID] = @GroupID
GO
/****** Object:  StoredProcedure [dbo].[SP_groups_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'groups'
-- based on the Primary Key.
-- Gets: @GroupID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_groups_SelectOne]
	@GroupID bigint
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[GroupID],
	[InstanceID],
	[UserID],
	[GroupName],
	[GroupCode],
	[ColorCode],
	[Status],
	[CreatedDate]
FROM [dbo].[groups]
WHERE
	[GroupID] = @GroupID
GO
/****** Object:  StoredProcedure [dbo].[SP_groups_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'groups'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_groups_SelectAll]
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[GroupID],
	[InstanceID],
	[UserID],
	[GroupName],
	[GroupCode],
	[ColorCode],
	[Status],
	[CreatedDate]
FROM [dbo].[groups]
--ORDER BY 
--	[GroupID] ASC
GO
/****** Object:  StoredProcedure [dbo].[SP_groups_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'groups'
-- Gets: @GroupID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @GroupName varchar(150)
-- Gets: @GroupCode varchar(10)
-- Gets: @ColorCode varchar(10)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_groups_Insert]
	@GroupID bigint output,
	@InstanceID bigint,
	@UserID bigint,
	@GroupName varchar(150),
	@GroupCode varchar(10),
	@ColorCode varchar(10),
	@Status int,
	@CreatedDate datetime
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[groups]
(
--	[GroupID],
	[InstanceID],
	[UserID],
	[GroupName],
	[GroupCode],
	[ColorCode],
	[Status],
	[CreatedDate]
)
VALUES
(
--@GroupID,
	@InstanceID,
	@UserID,
	@GroupName,
	@GroupCode,
	ISNULL(@ColorCode, ('#000000')),
	ISNULL(@Status, ((0))),
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @GroupID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_groups_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'groups'
-- using the Primary Key. 
-- Gets: @GroupID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_groups_Delete]
	@GroupID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[groups]
WHERE
	[GroupID] = @GroupID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_PreSubMenu_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'PreSubMenu'
-- Gets: @presubmenuid bigint
-- Gets: @presubmenuName varchar(50)
-- Gets: @presubmenuDesc VARCHAR(500)
-- Gets: @menuid bigint
-- Gets: @submenuid bigint
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PreSubMenu_Update]
	@presubmenuid bigint,
	@presubmenuName varchar(50),
	@presubmenuDesc VARCHAR(500),
	@menuid bigint,
	@submenuid bigint,
	@status varchar(50)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[PreSubMenu]
SET 
	[presubmenuName] = @presubmenuName,
	[presubmenuDesc] = @presubmenuDesc,
	[menuid] = @menuid,
	[submenuid] = @submenuid,
	[status] = @status
WHERE
	[presubmenuid] = @presubmenuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_PreSubMenu_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'PreSubMenu'
-- based on the Primary Key.
-- Gets: @presubmenuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PreSubMenu_SelectOne]
	@presubmenuid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[presubmenuid],
	[presubmenuName],
	[presubmenuDesc],
	[menuid],
	[submenuid],
	[status]
FROM [dbo].[PreSubMenu]
WHERE
	[presubmenuid] = @presubmenuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_PreSubMenu_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'PreSubMenu'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PreSubMenu_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[presubmenuid],
	[presubmenuName],
	[presubmenuDesc],
	[menuid],
	[submenuid],
	[status]
FROM [dbo].[PreSubMenu]
ORDER BY 
	[presubmenuid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_PreSubMenu_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'PreSubMenu'
-- Gets: @presubmenuName varchar(50)
-- Gets: @presubmenuDesc VARCHAR(500)
-- Gets: @menuid bigint
-- Gets: @submenuid bigint
-- Gets: @status varchar(50)
-- Returns: @presubmenuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PreSubMenu_Insert]
	@presubmenuName varchar(50),
	@presubmenuDesc VARCHAR(500),
	@menuid bigint,
	@submenuid bigint,
	@status varchar(50),
	@presubmenuid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[PreSubMenu]
(
	[presubmenuName],
	[presubmenuDesc],
	[menuid],
	[submenuid],
	[status]
)
VALUES
(
	@presubmenuName,
	@presubmenuDesc,
	@menuid,
	@submenuid,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @presubmenuid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_PreSubMenu_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'PreSubMenu'
-- using the Primary Key. 
-- Gets: @presubmenuid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PreSubMenu_Delete]
	@presubmenuid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[PreSubMenu]
WHERE
	[presubmenuid] = @presubmenuid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_posbillcount_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
[dbo].[SP_posbillcount_Update] @PosBillCountID  = 1,
                               @InstanceID      = 1,
                               @TotalBills      = 1,
                               @BillDate        = '2017-02-23',
                               @CreatedDate     = '2017-02-23'
*/

CREATE PROCEDURE [dbo].[SP_posbillcount_Update]

		@PosBillCountID 		bigint,
		@InstanceID     		bigint,
		@TotalBills     		bigint = 0,
		@BillDate       		date,
		@CreatedDate    		datetime

AS

SET NOCOUNT ON;

UPDATE [posbillcount]
SET
		[InstanceID] = @InstanceID,
		[TotalBills] = @TotalBills,
		[BillDate] = @BillDate,
		[CreatedDate] = @CreatedDate
WHERE [posbillcount].[PosBillCountID] = @PosBillCountID
GO
/****** Object:  StoredProcedure [dbo].[SP_posbillcount_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_posbillcount_SelectOne] @PosBillCountID  = 1

CREATE PROCEDURE [dbo].[SP_posbillcount_SelectOne]

		@PosBillCountID 		bigint

AS

SET NOCOUNT ON;

SELECT  
		[posbillcount].[PosBillCountID],
		[posbillcount].[InstanceID],
		[posbillcount].[TotalBills],
		[posbillcount].[BillDate],
		[posbillcount].[CreatedDate]
FROM  [posbillcount]

WHERE [posbillcount].[PosBillCountID] = @PosBillCountID
GO
/****** Object:  StoredProcedure [dbo].[SP_posbillcount_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_posbillcount_SelectAll]

CREATE PROCEDURE [dbo].[SP_posbillcount_SelectAll]

AS

SET NOCOUNT ON;

SELECT  
		[posbillcount].[PosBillCountID],
		[posbillcount].[InstanceID],
		[posbillcount].[TotalBills],
		[posbillcount].[BillDate],
		[posbillcount].[CreatedDate]
FROM  [posbillcount]
GO
/****** Object:  StoredProcedure [dbo].[SP_posbillcount_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
[dbo].[SP_posbillcount_Insert] @PosBillCountID  = 1,
                               @InstanceID      = 1,
                               @TotalBills      = 1,
                               @BillDate        = '2017-02-23',
                               @CreatedDate     = '2017-02-23'
*/

CREATE PROCEDURE [dbo].[SP_posbillcount_Insert]

		@PosBillCountID 		bigint OUTPUT,
		@InstanceID     		bigint,
		@TotalBills     		bigint = 0,
		@BillDate       		date,
		@CreatedDate    		datetime

AS

SET NOCOUNT ON;

INSERT [posbillcount]
(
		[InstanceID],
		[TotalBills],
		[BillDate],
		[CreatedDate]
)
VALUES
(
		@InstanceID,
		@TotalBills,
		@BillDate,
		@CreatedDate
)

SET @PosBillCountID = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_posbillcount_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_posbillcount_Delete] @PosBillCountID  = 1

CREATE PROCEDURE [dbo].[SP_posbillcount_Delete]

		@PosBillCountID 		bigint

AS

SET NOCOUNT ON;

DELETE FROM [posbillcount]
WHERE [posbillcount].[PosBillCountID] = @PosBillCountID
GO
/****** Object:  StoredProcedure [dbo].[SP_Party_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'Party'
-- Gets: @PartyID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @PartyName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Contact varchar(15)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Party_Update]
	@PartyID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@PartyName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Contact varchar(15),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[Party]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[PartyName] = @PartyName,
	[CivilNumber] = @CivilNumber,
	[Email] = @Email,
	[Address] = @Address,
	[Contact] = @Contact,
	[Status] = @Status,
	[CreatedDate] = @CreatedDate
WHERE
	[PartyID] = @PartyID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_Party_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'Party'
-- based on the Primary Key.
-- Gets: @PartyID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Party_SelectOne]
	@PartyID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[PartyID],
	[InstanceID],
	[UserID],
	[PartyName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[Status],
	[CreatedDate]
FROM [dbo].[Party]
WHERE
	[PartyID] = @PartyID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_Party_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'Party'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Party_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[PartyID],
	[InstanceID],
	[UserID],
	[PartyName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[Status],
	[CreatedDate]
FROM [dbo].[Party]
ORDER BY 
	[PartyID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_Party_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'Party'
-- Gets: @PartyID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @PartyName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Contact varchar(15)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Party_Insert]
	@PartyID bigint output,
	@InstanceID bigint,
	@UserID bigint,
	@PartyName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Contact varchar(15),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[Party]
(
--	[PartyID],
	[InstanceID],
	[UserID],
	[PartyName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[Status],
	[CreatedDate]
)
VALUES
(
--	@PartyID,
	@InstanceID,
	@UserID,
	@PartyName,
	@CivilNumber,
	@Email,
	@Address,
	@Contact,
	@Status,
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @PartyID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_Party_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'Party'
-- using the Primary Key. 
-- Gets: @PartyID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Party_Delete]
	@PartyID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[Party]
WHERE
	[PartyID] = @PartyID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_PageMaster_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'PageMaster'
-- Gets: @pageid bigint
-- Gets: @pageName varchar(50)
-- Gets: @pageDesc VARCHAR(500)
-- Gets: @moduleid bigint
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PageMaster_Update]
	@pageid bigint,
	@pageName varchar(50),
	@pageDesc VARCHAR(500),
	@moduleid bigint,
	@status varchar(50)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[PageMaster]
SET 
	[pageName] = @pageName,
	[pageDesc] = @pageDesc,
	[moduleid] = @moduleid,
	[status] = @status
WHERE
	[pageid] = @pageid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_PageMaster_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'PageMaster'
-- based on the Primary Key.
-- Gets: @pageid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PageMaster_SelectOne]
	@pageid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[pageid],
	[pageName],
	[pageDesc],
	[moduleid],
	[status]
FROM [dbo].[PageMaster]
WHERE
	[pageid] = @pageid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_PageMaster_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'PageMaster'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PageMaster_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[pageid],
	[pageName],
	[pageDesc],
	[moduleid],
	[status]
FROM [dbo].[PageMaster]
ORDER BY 
	[pageid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_PageMaster_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'PageMaster'
-- Gets: @pageName varchar(50)
-- Gets: @pageDesc VARCHAR(500)
-- Gets: @moduleid bigint
-- Gets: @status varchar(50)
-- Returns: @pageid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PageMaster_Insert]
	@pageName varchar(50),
	@pageDesc VARCHAR(500),
	@moduleid bigint,
	@status varchar(50),
	@pageid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[PageMaster]
(
	[pageName],
	[pageDesc],
	[moduleid],
	[status]
)
VALUES
(
	@pageName,
	@pageDesc,
	@moduleid,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @pageid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_PageMaster_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'PageMaster'
-- using the Primary Key. 
-- Gets: @pageid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_PageMaster_Delete]
	@pageid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[PageMaster]
WHERE
	[pageid] = @pageid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'office_branch'
-- Gets: @OfficeBranchID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @BranchName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Contact varchar(15)
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_office_branch_Update]
	@OfficeBranchID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@BranchName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Contact varchar(15),
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[office_branch]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[BranchName] = @BranchName,
	[CivilNumber] = @CivilNumber,
	[Email] = @Email,
	[Address] = @Address,
	[Contact] = @Contact,
	[CreatedDate] = @CreatedDate
WHERE
	[OfficeBranchID] = @OfficeBranchID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'office_branch'
-- based on the Primary Key.
-- Gets: @OfficeBranchID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_office_branch_SelectOne]
	@OfficeBranchID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[OfficeBranchID],
	[InstanceID],
	[UserID],
	[BranchName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[CreatedDate]
FROM [dbo].[office_branch]
WHERE
	[OfficeBranchID] = @OfficeBranchID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'office_branch'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_office_branch_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[OfficeBranchID],
	[InstanceID],
	[UserID],
	[BranchName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[CreatedDate]
FROM [dbo].[office_branch]
ORDER BY 
	[OfficeBranchID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  Table [dbo].[expenses]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[expenses](
	[ExpenseID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[OfficeBranchID] [bigint] NOT NULL,
	[ExpenseItemID] [bigint] NOT NULL,
	[ItemId] [int] NULL,
	[Amount] [decimal](10, 3) NOT NULL,
	[Details] [varchar](255) NOT NULL,
	[PaidBy] [int] NOT NULL,
	[PartyId] [int] NOT NULL,
	[BillDate] [date] NOT NULL,
	[IsDeleted] [int] NOT NULL,
	[DeletedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__expenses__1445CFF3F4D8A14C] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[customers_branch]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customers_branch](
	[CustomerBranchID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[CustomerID] [bigint] NOT NULL,
	[BranchName] [varchar](150) NOT NULL,
	[CivilNumber] [varchar](20) NOT NULL,
	[Email] [varchar](150) NOT NULL,
	[Address] [varchar](255) NOT NULL,
	[Contact] [varchar](15) NOT NULL,
	[ContactPerson] [varchar](50) NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__customer__6F555BDD912511E9] PRIMARY KEY CLUSTERED 
(
	[CustomerBranchID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[customers_branch] ON
INSERT [dbo].[customers_branch] ([CustomerBranchID], [InstanceID], [UserID], [CustomerID], [BranchName], [CivilNumber], [Email], [Address], [Contact], [ContactPerson], [CreatedDate]) VALUES (1, 1, 1, 1, N'chaitali', N'89', N'chaitali@gmail.com', N'kanyakumar', N'75632145', NULL, CAST(0x0000A7400100F155 AS DateTime))
INSERT [dbo].[customers_branch] ([CustomerBranchID], [InstanceID], [UserID], [CustomerID], [BranchName], [CivilNumber], [Email], [Address], [Contact], [ContactPerson], [CreatedDate]) VALUES (2, 1, 1, 2, N'manan ', N'89', N'manan@gmail.com', N'science city road', N'763215421', NULL, CAST(0x0000A74001013F1E AS DateTime))
INSERT [dbo].[customers_branch] ([CustomerBranchID], [InstanceID], [UserID], [CustomerID], [BranchName], [CivilNumber], [Email], [Address], [Contact], [ContactPerson], [CreatedDate]) VALUES (3, 1, 1, 3, N'dharmik', N'78', N'dharmik@gmail.com', N'Maninagar', N'763215412', NULL, CAST(0x0000A7400101F899 AS DateTime))
SET IDENTITY_INSERT [dbo].[customers_branch] OFF
/****** Object:  Table [dbo].[items]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[items](
	[ItemID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[CustomerID] [bigint] NOT NULL,
	[ItemName] [varchar](150) NOT NULL,
	[ItemLocalName] [varchar](150) NOT NULL,
	[PriceRate] [varchar](11) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__items__727E83EB5E502BBA] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[items] ON
INSERT [dbo].[items] ([ItemID], [InstanceID], [UserID], [CustomerID], [ItemName], [ItemLocalName], [PriceRate], [Status], [CreatedDate]) VALUES (3, 1, 1, 2, N'item 3', N'item 3', N'2', 1, CAST(0x0000A7500178C4FC AS DateTime))
INSERT [dbo].[items] ([ItemID], [InstanceID], [UserID], [CustomerID], [ItemName], [ItemLocalName], [PriceRate], [Status], [CreatedDate]) VALUES (5, 1, 1, 5, N'item 4', N'item4', N'2', 1, CAST(0x0000A750017CEB47 AS DateTime))
INSERT [dbo].[items] ([ItemID], [InstanceID], [UserID], [CustomerID], [ItemName], [ItemLocalName], [PriceRate], [Status], [CreatedDate]) VALUES (9, 1, 1, 7, N'item 6', N'item 6', N'2', 1, CAST(0x0000A750017DFFA8 AS DateTime))
INSERT [dbo].[items] ([ItemID], [InstanceID], [UserID], [CustomerID], [ItemName], [ItemLocalName], [PriceRate], [Status], [CreatedDate]) VALUES (10, 1, 1, 2, N'item7', N'item7', N'2', 1, CAST(0x0000A75100004D1C AS DateTime))
INSERT [dbo].[items] ([ItemID], [InstanceID], [UserID], [CustomerID], [ItemName], [ItemLocalName], [PriceRate], [Status], [CreatedDate]) VALUES (11, 1, 1, 3, N'item 8', N'item 8', N'2', 1, CAST(0x0000A751000456F3 AS DateTime))
INSERT [dbo].[items] ([ItemID], [InstanceID], [UserID], [CustomerID], [ItemName], [ItemLocalName], [PriceRate], [Status], [CreatedDate]) VALUES (13, 1, 1, 6, N'item 99', N'item 981', N'2', 2, CAST(0x0000A75901714A97 AS DateTime))
SET IDENTITY_INSERT [dbo].[items] OFF
/****** Object:  Table [dbo].[item_price]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_price](
	[ItemPriceID] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemID] [bigint] NOT NULL,
	[GroupID] [bigint] NOT NULL,
	[Price] [decimal](10, 3) NOT NULL,
 CONSTRAINT [PK__item_pri__7E70A20238E83280] PRIMARY KEY CLUSTERED 
(
	[ItemPriceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[item_price] ON
INSERT [dbo].[item_price] ([ItemPriceID], [ItemID], [GroupID], [Price]) VALUES (7, 13, 23, CAST(100.000 AS Decimal(10, 3)))
INSERT [dbo].[item_price] ([ItemPriceID], [ItemID], [GroupID], [Price]) VALUES (8, 13, 22, CAST(134.000 AS Decimal(10, 3)))
INSERT [dbo].[item_price] ([ItemPriceID], [ItemID], [GroupID], [Price]) VALUES (9, 13, 24, CAST(10.000 AS Decimal(10, 3)))
SET IDENTITY_INSERT [dbo].[item_price] OFF
/****** Object:  Table [dbo].[office_branch_sales]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[office_branch_sales](
	[BranchSalesID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[OfficeBranchID] [bigint] NOT NULL,
	[Amount] [decimal](10, 3) NOT NULL,
	[BillDate] [date] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__office_b__B2A8CBC46327FA67] PRIMARY KEY CLUSTERED 
(
	[BranchSalesID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pos](
	[PosID] [bigint] IDENTITY(1,1) NOT NULL,
	[InstanceID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[BillNo] [bigint] NOT NULL,
	[CustomerID] [bigint] NOT NULL,
	[CustomerBranchID] [bigint] NOT NULL,
	[Type] [varchar](15) NOT NULL,
	[TotalQuantity] [bigint] NOT NULL,
	[TotalAmount] [decimal](10, 3) NOT NULL,
	[Discount] [decimal](10, 3) NOT NULL,
	[TotalPayable] [decimal](10, 3) NOT NULL,
	[PaidAmount] [decimal](10, 3) NOT NULL,
	[ReturnAmount] [decimal](10, 3) NOT NULL,
	[IsPaid] [int] NOT NULL,
	[PaidBy] [int] NOT NULL,
	[PaymentDateTime] [datetime] NULL,
	[Status] [int] NOT NULL,
	[Comment] [varchar](255) NOT NULL,
	[HangerQuantity] [bigint] NOT NULL,
	[HangerRate] [decimal](10, 3) NOT NULL,
	[HangerAmount] [decimal](10, 3) NOT NULL,
	[IsClothCollected] [varchar](10) NOT NULL,
	[IsCarpetInvoice] [int] NOT NULL,
	[BillDate] [date] NOT NULL,
	[BillTime] [time](7) NOT NULL,
	[DeliveryDate] [date] NOT NULL,
	[DeliveryTime] [time](7) NOT NULL,
	[IsDeleted] [int] NOT NULL,
	[DeletedDateTime] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__pos__67572BB3DF246E44] PRIMARY KEY CLUSTERED 
(
	[PosID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_sales_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
[dbo].[SP_office_branch_sales_Update] @BranchSalesID   = 1,
                                      @InstanceID      = 1,
                                      @UserID          = 1,
                                      @OfficeBranchID  = 1,
                                      @Amount          = 1,
                                      @BillDate        = '2017-02-23',
                                      @CreatedDate     = '2017-02-23'
*/

CREATE PROCEDURE [dbo].[SP_office_branch_sales_Update]

		@BranchSalesID  		bigint,
		@InstanceID     		bigint,
		@UserID         		bigint,
		@OfficeBranchID 		bigint,
		@Amount         		decimal (10, 3) = '0.000',
		@BillDate       		date,
		@CreatedDate    		datetime

AS

SET NOCOUNT ON;

UPDATE [office_branch_sales]
SET
		[InstanceID] = @InstanceID,
		[UserID] = @UserID,
		[OfficeBranchID] = @OfficeBranchID,
		[Amount] = @Amount,
		[BillDate] = @BillDate,
		[CreatedDate] = @CreatedDate
WHERE [office_branch_sales].[BranchSalesID] = @BranchSalesID
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_sales_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_office_branch_sales_SelectOne] @BranchSalesID  = 1

CREATE PROCEDURE [dbo].[SP_office_branch_sales_SelectOne]

		@BranchSalesID 		bigint

AS

SET NOCOUNT ON;

SELECT  
		[office_branch_sales].[BranchSalesID],
		[office_branch_sales].[InstanceID],
		[office_branch_sales].[UserID],
		[office_branch_sales].[OfficeBranchID],
		[office_branch_sales].[Amount],
		[office_branch_sales].[BillDate],
		[office_branch_sales].[CreatedDate]
FROM  [office_branch_sales]

WHERE [office_branch_sales].[BranchSalesID] = @BranchSalesID
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_sales_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_office_branch_sales_SelectAll]

CREATE PROCEDURE [dbo].[SP_office_branch_sales_SelectAll]

AS

SET NOCOUNT ON;

SELECT  
		[office_branch_sales].[BranchSalesID],
		[office_branch_sales].[InstanceID],
		[office_branch_sales].[UserID],
		[office_branch_sales].[OfficeBranchID],
		[office_branch_sales].[Amount],
		[office_branch_sales].[BillDate],
		[office_branch_sales].[CreatedDate]
FROM  [office_branch_sales]
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_sales_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
[dbo].[SP_office_branch_sales_Insert] @BranchSalesID   = 1,
                                      @InstanceID      = 1,
                                      @UserID          = 1,
                                      @OfficeBranchID  = 1,
                                      @Amount          = 1,
                                      @BillDate        = '2017-02-23',
                                      @CreatedDate     = '2017-02-23'
*/

CREATE PROCEDURE [dbo].[SP_office_branch_sales_Insert]

		@BranchSalesID  		bigint OUTPUT,
		@InstanceID     		bigint,
		@UserID         		bigint,
		@OfficeBranchID 		bigint,
		@Amount         		decimal (10, 3) = '0.000',
		@BillDate       		date,
		@CreatedDate    		datetime

AS

SET NOCOUNT ON;

INSERT [office_branch_sales]
(
		[InstanceID],
		[UserID],
		[OfficeBranchID],
		[Amount],
		[BillDate],
		[CreatedDate]
)
VALUES
(
		@InstanceID,
		@UserID,
		@OfficeBranchID,
		@Amount,
		@BillDate,
		@CreatedDate
)

SET @BranchSalesID = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_office_branch_sales_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_office_branch_sales_Delete] @BranchSalesID  = 1

CREATE PROCEDURE [dbo].[SP_office_branch_sales_Delete]

		@BranchSalesID 		bigint

AS

SET NOCOUNT ON;

DELETE FROM [office_branch_sales]
WHERE [office_branch_sales].[BranchSalesID] = @BranchSalesID
GO
/****** Object:  StoredProcedure [dbo].[SP_items_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'items'
-- Gets: @ItemID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @CustomerID bigint
-- Gets: @ItemName varchar(150)
-- Gets: @ItemLocalName varchar(150)
-- Gets: @PriceRate varchar(11)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_items_Update]
	@ItemID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@CustomerID bigint,
	@ItemName varchar(150),
	@ItemLocalName varchar(150),
	@PriceRate varchar(11),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[items]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[CustomerID] = @CustomerID,
	[ItemName] = @ItemName,
	[ItemLocalName] = @ItemLocalName,
	[PriceRate] = @PriceRate,
	[Status] = @Status,
	[CreatedDate] = @CreatedDate
WHERE
	[ItemID] = @ItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_items_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'items'
-- based on the Primary Key.
-- Gets: @ItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_items_SelectOne]
	@ItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[ItemID],
	[InstanceID],
	[UserID],
	[CustomerID],
	[ItemName],
	[ItemLocalName],
	[PriceRate],
	[Status],
	[CreatedDate]
FROM [dbo].[items]
WHERE
	[ItemID] = @ItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_items_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'items'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_items_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[ItemID],
	[InstanceID],
	[UserID],
	[CustomerID],
	[ItemName],
	[ItemLocalName],
	[PriceRate],
	[Status],
	[CreatedDate]
FROM [dbo].[items]
ORDER BY 
	[ItemID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_Items_Search]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an matching rows from the table 'items'
-- based on the Primary Key.
-- Gets: @ItemSearch VARCHAR(MAX)
-- Returns: Item Table data.
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_Items_Search]
	@ItemSearch VARCHAR(MAX)	
AS
SET NOCOUNT ON
SELECT
	[ItemID],
	[InstanceID],
	[UserID],
	[CustomerID],
	[ItemName],
	[ItemLocalName],
	[PriceRate],
	[Status],
	[CreatedDate]
FROM [dbo].[items] WITH(NOLOCK)
WHERE
	[ItemName] LIKE '%' + @ItemSearch + '%' 
	OR
	[ItemLocalName] LIKE '%' +@ItemSearch + '%'
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_items_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'items'
-- Gets: @ItemID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @CustomerID bigint
-- Gets: @ItemName varchar(150)
-- Gets: @ItemLocalName varchar(150)
-- Gets: @PriceRate varchar(11)
-- Gets: @Status int
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_items_Insert]
	@ItemID bigint output,
	@InstanceID bigint,
	@UserID bigint,
	@CustomerID bigint,
	@ItemName varchar(150),
	@ItemLocalName varchar(150),
	@PriceRate varchar(11),
	@Status int,
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[items]
(
--	[ItemID],
	[InstanceID],
	[UserID],
	[CustomerID],
	[ItemName],
	[ItemLocalName],
	[PriceRate],
	[Status],
	[CreatedDate]
)
VALUES
(
--	@ItemID,
	@InstanceID,
	@UserID,
	ISNULL(@CustomerID, ((0))),
	@ItemName,
	@ItemLocalName,
	ISNULL(@PriceRate, ('Fixed')),
	ISNULL(@Status, ((0))),
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @ItemID = SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_items_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'items'
-- using the Primary Key. 
-- Gets: @ItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_items_Delete]
	@ItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[items]
WHERE
	[ItemID] = @ItemID;

DELETE FROM [dbo].[item_price]
WHERE
	[ItemID] = @ItemID;
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_item_price_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'item_price'
-- Gets: @ItemPriceID bigint
-- Gets: @ItemID bigint
-- Gets: @GroupID bigint
-- Gets: @Price decimal(10, 3)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_item_price_Update]
	@ItemPriceID bigint,
	@ItemID bigint,
	@GroupID bigint,
	@Price decimal(10, 3)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[item_price]
SET 
	[ItemID] = @ItemID,
	[GroupID] = @GroupID,
	[Price] = @Price
WHERE
	[ItemPriceID] = @ItemPriceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_item_price_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'item_price'
-- based on the Primary Key.
-- Gets: @ItemPriceID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_item_price_SelectOne]
	@ItemPriceID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[ItemPriceID],
	[ItemID],
	[GroupID],
	[Price]
FROM [dbo].[item_price]
WHERE
	[ItemPriceID] = @ItemPriceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_item_price_SelectByItemId]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'item_price'
-- based on the Primary Key.
-- Gets: @ItemPriceID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_item_price_SelectByItemId]
	@ItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[ItemPriceID],
	[ItemID],
	[GroupID],
	[Price]
FROM [dbo].[item_price]
WHERE
	[ItemID] = @ItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_item_price_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'item_price'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_item_price_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[ItemPriceID],
	[ItemID],
	[GroupID],
	[Price]
FROM [dbo].[item_price]
ORDER BY 
	[ItemPriceID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_item_price_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'item_price'
-- Gets: @ItemPriceID bigint
-- Gets: @ItemID bigint
-- Gets: @GroupID bigint
-- Gets: @Price decimal(10, 3)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_item_price_Insert]
	@ItemPriceID bigint output,
	@ItemID bigint,
	@GroupID bigint,
	@Price decimal(10, 3)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[item_price]
(
--	[ItemPriceID],
	[ItemID],
	[GroupID],
	[Price]
)
VALUES
(
--	@ItemPriceID,
	@ItemID,
	@GroupID,
	ISNULL(@Price, ('0.000'))
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @ItemPriceID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_item_price_DeleteByItemId]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'item_price'
-- using the foreign Key. 
-- Gets: @ItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_item_price_DeleteByItemId]
	@ItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[item_price]
WHERE
[ItemID] = @ItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_item_price_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'item_price'
-- using the Primary Key. 
-- Gets: @ItemPriceID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_item_price_Delete]
	@ItemPriceID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[item_price]
WHERE
	[ItemPriceID] = @ItemPriceID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_expenses_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
[dbo].[SP_expenses_UpdateByPK] @ExpenseID       = 1,
                               @InstanceID      = 1,
                               @UserID          = 1,
                               @OfficeBranchID  = 1,
                               @ExpenseItemID   = 1,
                               @ItemId          = 1,
                               @Amount          = 1,
                               @Details         = 'Details',
                               @PaidBy          = 1,
                               @PartyId         = 1,
                               @BillDate        = '2017-02-23',
                               @IsDeleted       = 1,
                               @DeletedDate     = '2017-02-23',
                               @UpdatedDate     = '2017-02-23',
                               @CreatedDate     = '2017-02-23'
*/

CREATE PROCEDURE [dbo].[SP_expenses_Update]

		@ExpenseID      		bigint,
		@InstanceID     		bigint,
		@UserID         		bigint,
		@OfficeBranchID 		bigint = 0,
		@ExpenseItemID  		bigint,
		@ItemId         		int,
		@Amount         		decimal (10, 3) = '0.000',
		@Details        		varchar (255),
		@PaidBy         		int = 1,
		@PartyId        		int,
		@BillDate       		date,
		@IsDeleted      		int = 0,
		@DeletedDate    		datetime,
		@UpdatedDate    		datetime,
		@CreatedDate    		datetime

AS

SET NOCOUNT ON;

UPDATE [expenses]
SET
		[InstanceID] = @InstanceID,
		[UserID] = @UserID,
		[OfficeBranchID] = @OfficeBranchID,
		[ExpenseItemID] = @ExpenseItemID,
		[ItemId] = @ItemId,
		[Amount] = @Amount,
		[Details] = @Details,
		[PaidBy] = @PaidBy,
		[PartyId] = @PartyId,
		[BillDate] = @BillDate,
		[IsDeleted] = @IsDeleted,
		[DeletedDate] = @DeletedDate,
		[UpdatedDate] = @UpdatedDate,
		[CreatedDate] = @CreatedDate
WHERE [expenses].[ExpenseID] = @ExpenseID
GO
/****** Object:  StoredProcedure [dbo].[SP_expenses_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_expenses_SelectByPK] @ExpenseID  = 1

CREATE PROCEDURE [dbo].[SP_expenses_SelectOne]

		@ExpenseID 		bigint

AS

SET NOCOUNT ON;

SELECT  
		[expenses].[ExpenseID],
		[expenses].[InstanceID],
		[expenses].[UserID],
		[expenses].[OfficeBranchID],
		[expenses].[ExpenseItemID],
		[expenses].[ItemId],
		[expenses].[Amount],
		[expenses].[Details],
		[expenses].[PaidBy],
		[expenses].[PartyId],
		[expenses].[BillDate],
		[expenses].[IsDeleted],
		[expenses].[DeletedDate],
		[expenses].[UpdatedDate],
		[expenses].[CreatedDate]
FROM  [expenses]

WHERE [expenses].[ExpenseID] = @ExpenseID
GO
/****** Object:  StoredProcedure [dbo].[SP_expenses_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_expenses_SelectAll]

CREATE PROCEDURE [dbo].[SP_expenses_SelectAll]

AS

SET NOCOUNT ON;

SELECT  
		[expenses].[ExpenseID],
		[expenses].[InstanceID],
		[expenses].[UserID],
		[expenses].[OfficeBranchID],
		[expenses].[ExpenseItemID],
		[expenses].[ItemId],
		[expenses].[Amount],
		[expenses].[Details],
		[expenses].[PaidBy],
		[expenses].[PartyId],
		[expenses].[BillDate],
		[expenses].[IsDeleted],
		[expenses].[DeletedDate],
		[expenses].[UpdatedDate],
		[expenses].[CreatedDate]
FROM  [expenses]
GO
/****** Object:  StoredProcedure [dbo].[SP_expenses_Insert]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
[dbo].[SP_expenses_Insert] @ExpenseID       = 1,
                           @InstanceID      = 1,
                           @UserID          = 1,
                           @OfficeBranchID  = 1,
                           @ExpenseItemID   = 1,
                           @ItemId          = 1,
                           @Amount          = 1,
                           @Details         = 'Details',
                           @PaidBy          = 1,
                           @PartyId         = 1,
                           @BillDate        = '2017-02-23',
                           @IsDeleted       = 1,
                           @DeletedDate     = '2017-02-23',
                           @UpdatedDate     = '2017-02-23',
                           @CreatedDate     = '2017-02-23'
*/

CREATE PROCEDURE [dbo].[SP_expenses_Insert]

		@ExpenseID      		bigint OUTPUT,
		@InstanceID     		bigint,
		@UserID         		bigint,
		@OfficeBranchID 		bigint = 0,
		@ExpenseItemID  		bigint,
		@ItemId         		int,
		@Amount         		decimal (10, 3) = '0.000',
		@Details        		varchar (255),
		@PaidBy         		int = 1,
		@PartyId        		int,
		@BillDate       		date,
		@IsDeleted      		int = 0,
		@DeletedDate    		datetime,
		@UpdatedDate    		datetime,
		@CreatedDate    		datetime

AS

SET NOCOUNT ON;

INSERT [expenses]
(
		[InstanceID],
		[UserID],
		[OfficeBranchID],
		[ExpenseItemID],
		[ItemId],
		[Amount],
		[Details],
		[PaidBy],
		[PartyId],
		[BillDate],
		[IsDeleted],
		[DeletedDate],
		[UpdatedDate],
		[CreatedDate]
)
VALUES
(
		@InstanceID,
		@UserID,
		@OfficeBranchID,
		@ExpenseItemID,
		@ItemId,
		@Amount,
		@Details,
		@PaidBy,
		@PartyId,
		@BillDate,
		@IsDeleted,
		@DeletedDate,
		@UpdatedDate,
		@CreatedDate
)

SET @ExpenseID = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_expenses_Delete]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_expenses_DeleteByPK] @ExpenseID  = 1

CREATE PROCEDURE [dbo].[SP_expenses_Delete]

		@ExpenseID 		bigint

AS

SET NOCOUNT ON;

DELETE FROM [expenses]
WHERE [expenses].[ExpenseID] = @ExpenseID
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_branch_Update]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'customers_branch'
-- Gets: @CustomerBranchID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @CustomerID bigint
-- Gets: @BranchName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Contact varchar(15)
-- Gets: @ContactPerson varchar(50)
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_branch_Update]
	@CustomerBranchID bigint,
	@InstanceID bigint,
	@UserID bigint,
	@CustomerID bigint,
	@BranchName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Contact varchar(15),
	@ContactPerson varchar(50),
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[customers_branch]
SET 
	[InstanceID] = @InstanceID,
	[UserID] = @UserID,
	[CustomerID] = @CustomerID,
	[BranchName] = @BranchName,
	[CivilNumber] = @CivilNumber,
	[Email] = @Email,
	[Address] = @Address,
	[Contact] = @Contact,
	[ContactPerson] = @ContactPerson,
	[CreatedDate] = @CreatedDate
WHERE
	[CustomerBranchID] = @CustomerBranchID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_branch_SelectOne]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'customers_branch'
-- based on the Primary Key.
-- Gets: @CustomerBranchID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_branch_SelectOne]
	@CustomerBranchID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[CustomerBranchID],
	[InstanceID],
	[UserID],
	[CustomerID],
	[BranchName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[ContactPerson],
	[CreatedDate]
FROM [dbo].[customers_branch]
WHERE
	[CustomerBranchID] = @CustomerBranchID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_branch_SelectAll]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'customers_branch'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_branch_SelectAll]
	--@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[CustomerBranchID],
	[InstanceID],
	[UserID],
	[CustomerID],
	[BranchName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[ContactPerson],
	[CreatedDate]
FROM [dbo].[customers_branch]
ORDER BY 
	[CustomerBranchID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_branch_Insert]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'customers_branch'
-- Gets: @CustomerBranchID bigint
-- Gets: @InstanceID bigint
-- Gets: @UserID bigint
-- Gets: @CustomerID bigint
-- Gets: @BranchName varchar(150)
-- Gets: @CivilNumber varchar(20)
-- Gets: @Email varchar(150)
-- Gets: @Address varchar(255)
-- Gets: @Contact varchar(15)
-- Gets: @ContactPerson varchar(50)
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_branch_Insert]
	@InstanceID bigint,
	@UserID bigint,
	@CustomerID bigint,
	@BranchName varchar(150),
	@CivilNumber varchar(20),
	@Email varchar(150),
	@Address varchar(255),
	@Contact varchar(15),
	@ContactPerson varchar(50),
	@CreatedDate datetime,
	@CustomerBranchID bigint output
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[customers_branch]
(
--	[CustomerBranchID],
	[InstanceID],
	[UserID],
	[CustomerID],
	[BranchName],
	[CivilNumber],
	[Email],
	[Address],
	[Contact],
	[ContactPerson],
	[CreatedDate]
)
VALUES
(
--	@CustomerBranchID,
	@InstanceID,
	@UserID,
	@CustomerID,
	@BranchName,
	@CivilNumber,
	@Email,
	@Address,
	@Contact,
	@ContactPerson,
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @CustomerBranchID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_customers_branch_Delete]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'customers_branch'
-- using the Primary Key. 
-- Gets: @CustomerBranchID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_customers_branch_Delete]
	@CustomerBranchID bigint
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[customers_branch]
WHERE
	[CustomerBranchID] = @CustomerBranchID
GO
/****** Object:  Table [dbo].[purchase_invoice_items]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchase_invoice_items](
	[InvoiceItemID] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [bigint] NOT NULL,
	[PurchaseItemID] [bigint] NOT NULL,
	[Quantity] [bigint] NOT NULL,
	[Rate] [decimal](10, 3) NOT NULL,
	[Amount] [decimal](10, 3) NOT NULL,
	[Description] [varchar](255) NOT NULL,
 CONSTRAINT [PK__purchase__478FE0FC51A27542] PRIMARY KEY CLUSTERED 
(
	[InvoiceItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_UserRightsMaster_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'UserRightsMaster'
-- Gets: @urid bigint
-- Gets: @userid bigint
-- Gets: @moduleid bigint
-- Gets: @rollid bigint
-- Gets: @pageid bigint
-- Gets: @empid bigint
-- Gets: @isDelete bit
-- Gets: @isView bit
-- Gets: @isEdit bit
-- Gets: @isSearch bit
-- Gets: @isAdd bit
-- Gets: @isReport bit
-- Gets: @createdDateTime datetime
-- Gets: @applyDate datetime
-- Gets: @createdBy varchar(50)
-- Gets: @updatedby varchar(50)
-- Gets: @deletedid varchar(50)
-- Gets: @status varchar(50)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserRightsMaster_Update]
	@urid bigint,
	@userid bigint,
	@moduleid bigint,
	@rollid bigint,
	@pageid bigint,
	@empid bigint,
	@isDelete bit,
	@isView bit,
	@isEdit bit,
	@isSearch bit,
	@isAdd bit,
	@isReport bit,
	@createdDateTime datetime,
	@applyDate datetime,
	@createdBy varchar(50),
	@updatedby varchar(50),
	@deletedid varchar(50),
	@status varchar(50)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[UserRightsMaster]
SET 
	[userid] = @userid,
	[moduleid] = @moduleid,
	[rollid] = @rollid,
	[pageid] = @pageid,
	[empid] = @empid,
	[isDelete] = @isDelete,
	[isView] = @isView,
	[isEdit] = @isEdit,
	[isSearch] = @isSearch,
	[isAdd] = @isAdd,
	[isReport] = @isReport,
	[createdDateTime] = @createdDateTime,
	[applyDate] = @applyDate,
	[createdBy] = @createdBy,
	[updatedby] = @updatedby,
	[deletedid] = @deletedid,
	[status] = @status
WHERE
	[urid] = @urid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_UserRightsMaster_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'UserRightsMaster'
-- based on the Primary Key.
-- Gets: @urid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserRightsMaster_SelectOne]
	@urid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[urid],
	[userid],
	[moduleid],
	[rollid],
	[pageid],
	[empid],
	[isDelete],
	[isView],
	[isEdit],
	[isSearch],
	[isAdd],
	[isReport],
	[createdDateTime],
	[applyDate],
	[createdBy],
	[updatedby],
	[deletedid],
	[status]
FROM [dbo].[UserRightsMaster]
WHERE
	[urid] = @urid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_UserRightsMaster_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'UserRightsMaster'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserRightsMaster_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[urid],
	[userid],
	[moduleid],
	[rollid],
	[pageid],
	[empid],
	[isDelete],
	[isView],
	[isEdit],
	[isSearch],
	[isAdd],
	[isReport],
	[createdDateTime],
	[applyDate],
	[createdBy],
	[updatedby],
	[deletedid],
	[status]
FROM [dbo].[UserRightsMaster]
ORDER BY 
	[urid] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_UserRightsMaster_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'UserRightsMaster'
-- Gets: @userid bigint
-- Gets: @moduleid bigint
-- Gets: @rollid bigint
-- Gets: @pageid bigint
-- Gets: @empid bigint
-- Gets: @isDelete bit
-- Gets: @isView bit
-- Gets: @isEdit bit
-- Gets: @isSearch bit
-- Gets: @isAdd bit
-- Gets: @isReport bit
-- Gets: @createdDateTime datetime
-- Gets: @applyDate datetime
-- Gets: @createdBy varchar(50)
-- Gets: @updatedby varchar(50)
-- Gets: @deletedid varchar(50)
-- Gets: @status varchar(50)
-- Returns: @urid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserRightsMaster_Insert]
	@userid bigint,
	@moduleid bigint,
	@rollid bigint,
	@pageid bigint,
	@empid bigint,
	@isDelete bit,
	@isView bit,
	@isEdit bit,
	@isSearch bit,
	@isAdd bit,
	@isReport bit,
	@createdDateTime datetime,
	@applyDate datetime,
	@createdBy varchar(50),
	@updatedby varchar(50),
	@deletedid varchar(50),
	@status varchar(50),
	@urid bigint OUTPUT
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[UserRightsMaster]
(
	[userid],
	[moduleid],
	[rollid],
	[pageid],
	[empid],
	[isDelete],
	[isView],
	[isEdit],
	[isSearch],
	[isAdd],
	[isReport],
	[createdDateTime],
	[applyDate],
	[createdBy],
	[updatedby],
	[deletedid],
	[status]
)
VALUES
(
	@userid,
	@moduleid,
	@rollid,
	@pageid,
	@empid,
	@isDelete,
	@isView,
	@isEdit,
	@isSearch,
	@isAdd,
	@isReport,
	@createdDateTime,
	@applyDate,
	@createdBy,
	@updatedby,
	@deletedid,
	@status
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @urid=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_UserRightsMaster_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'UserRightsMaster'
-- using the Primary Key. 
-- Gets: @urid bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_UserRightsMaster_Delete]
	@urid bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[UserRightsMaster]
WHERE
	[urid] = @urid
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_purchase_invoice_UpdateByPK] @InvoiceID = 1, @InstanceID = 1, @UserID = 1, @OfficeBranchID = 1, @BranchName = 'BranchName', @SupplierID = 1, @Contact = 'Contact', @TotalQuantity = 1, @TotalAmount = 1, @Type = 'Type', @Narration = 'Narration', @QuotationNo = 'QuotationNo', @QuotationDate = '2017-02-23', @ReferenceNo = 'ReferenceNo', @InvoiceDate = '2017-02-23', @IsDeleted = 1, @DeletedDateTime = '2017-02-23', @CreatedDate = '2017-02-23'

CREATE PROCEDURE [dbo].[SP_purchase_invoice_Update]

		@InvoiceID       		bigint,
		@InstanceID      		bigint,
		@UserID          		bigint,
		@OfficeBranchID  		bigint = 0,
		@BranchName      		varchar (150) = 'Head Office',
		@SupplierID      		bigint,
		@Contact         		varchar (15),
		@TotalQuantity   		bigint,
		@TotalAmount     		decimal (10, 3) = '0.000',
		@Type            		varchar (10) = 1,
		@Narration       		varchar (255),
		@QuotationNo     		varchar (10),
		@QuotationDate   		date,
		@ReferenceNo     		varchar (10),
		@InvoiceDate     		date,
		@IsDeleted       		int = 0,
		@DeletedDateTime 		datetime,
		@CreatedDate     		datetime

AS

SET NOCOUNT ON;

UPDATE [purchase_invoice]
SET
		[InstanceID] = @InstanceID,
		[UserID] = @UserID,
		[OfficeBranchID] = @OfficeBranchID,
		[BranchName] = @BranchName,
		[SupplierID] = @SupplierID,
		[Contact] = @Contact,
		[TotalQuantity] = @TotalQuantity,
		[TotalAmount] = @TotalAmount,
		[Type] = @Type,
		[Narration] = @Narration,
		[QuotationNo] = @QuotationNo,
		[QuotationDate] = @QuotationDate,
		[ReferenceNo] = @ReferenceNo,
		[InvoiceDate] = @InvoiceDate,
		[IsDeleted] = @IsDeleted,
		[DeletedDateTime] = @DeletedDateTime,
		[CreatedDate] = @CreatedDate
WHERE [purchase_invoice].[InvoiceID] = @InvoiceID
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_purchase_invoice_SelectByPK] @InvoiceID = 1

CREATE PROCEDURE [dbo].[SP_purchase_invoice_SelectOne]

		@InvoiceID 		bigint

AS

SET NOCOUNT ON;

SELECT  
		[InvoiceID],
		[InstanceID],
		[UserID],
		[OfficeBranchID],
		[BranchName],
		[SupplierID],
		[Contact],
		[TotalQuantity],
		[TotalAmount],
		[Type],
		[Narration],
		[QuotationNo],
		[QuotationDate],
		[ReferenceNo],
		[InvoiceDate],
		[IsDeleted],
		[DeletedDateTime],
		[CreatedDate]
FROM  [purchase_invoice]

WHERE [InvoiceID] = @InvoiceID
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_purchase_invoice_SelectAll]

CREATE PROCEDURE [dbo].[SP_purchase_invoice_SelectAll]

AS

SET NOCOUNT ON;

SELECT  
		[purchase_invoice].[InvoiceID],
		[purchase_invoice].[InstanceID],
		[purchase_invoice].[UserID],
		[purchase_invoice].[OfficeBranchID],
		[purchase_invoice].[BranchName],
		[purchase_invoice].[SupplierID],
		[purchase_invoice].[Contact],
		[purchase_invoice].[TotalQuantity],
		[purchase_invoice].[TotalAmount],
		[purchase_invoice].[Type],
		[purchase_invoice].[Narration],
		[purchase_invoice].[QuotationNo],
		[purchase_invoice].[QuotationDate],
		[purchase_invoice].[ReferenceNo],
		[purchase_invoice].[InvoiceDate],
		[purchase_invoice].[IsDeleted],
		[purchase_invoice].[DeletedDateTime],
		[purchase_invoice].[CreatedDate]
FROM  [purchase_invoice]
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_logs_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'sms_logs'
-- Gets: @SmsLogID bigint
-- Gets: @UserID bigint
-- Gets: @InstanceID bigint
-- Gets: @CustomerID bigint
-- Gets: @SmsID bigint
-- Gets: @TemplateName varchar(150)
-- Gets: @CountryCode varchar(10)
-- Gets: @FromNumber varchar(12)
-- Gets: @ToNumber varchar(12)
-- Gets: @Details VARCHAR(500)
-- Gets: @Status varchar(2)
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_logs_Update]
	@SmsLogID bigint,
	@UserID bigint,
	@InstanceID bigint,
	@CustomerID bigint,
	@SmsID bigint,
	@TemplateName varchar(150),
	@CountryCode varchar(10),
	@FromNumber varchar(12),
	@ToNumber varchar(12),
	@Details VARCHAR(500),
	@Status varchar(2),
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[sms_logs]
SET 
	[UserID] = @UserID,
	[InstanceID] = @InstanceID,
	[CustomerID] = @CustomerID,
	[SmsID] = @SmsID,
	[TemplateName] = @TemplateName,
	[CountryCode] = @CountryCode,
	[FromNumber] = @FromNumber,
	[ToNumber] = @ToNumber,
	[Details] = @Details,
	[Status] = @Status,
	[CreatedDate] = @CreatedDate
WHERE
	[SmsLogID] = @SmsLogID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_logs_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'sms_logs'
-- based on the Primary Key.
-- Gets: @SmsLogID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_logs_SelectOne]
	@SmsLogID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[SmsLogID],
	[UserID],
	[InstanceID],
	[CustomerID],
	[SmsID],
	[TemplateName],
	[CountryCode],
	[FromNumber],
	[ToNumber],
	[Details],
	[Status],
	[CreatedDate]
FROM [dbo].[sms_logs]
WHERE
	[SmsLogID] = @SmsLogID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_logs_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'sms_logs'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_logs_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[SmsLogID],
	[UserID],
	[InstanceID],
	[CustomerID],
	[SmsID],
	[TemplateName],
	[CountryCode],
	[FromNumber],
	[ToNumber],
	[Details],
	[Status],
	[CreatedDate]
FROM [dbo].[sms_logs]
ORDER BY 
	[SmsLogID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_logs_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'sms_logs'
-- Gets: @SmsLogID bigint
-- Gets: @UserID bigint
-- Gets: @InstanceID bigint
-- Gets: @CustomerID bigint
-- Gets: @SmsID bigint
-- Gets: @TemplateName varchar(150)
-- Gets: @CountryCode varchar(10)
-- Gets: @FromNumber varchar(12)
-- Gets: @ToNumber varchar(12)
-- Gets: @Details VARCHAR(500)
-- Gets: @Status varchar(2)
-- Gets: @CreatedDate datetime
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_logs_Insert]
	@SmsLogID bigint output,
	@UserID bigint,
	@InstanceID bigint,
	@CustomerID bigint,
	@SmsID bigint,
	@TemplateName varchar(150),
	@CountryCode varchar(10),
	@FromNumber varchar(12),
	@ToNumber varchar(12),
	@Details VARCHAR(500),
	@Status varchar(2),
	@CreatedDate datetime
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[sms_logs]
(
--	[SmsLogID],
	[UserID],
	[InstanceID],
	[CustomerID],
	[SmsID],
	[TemplateName],
	[CountryCode],
	[FromNumber],
	[ToNumber],
	[Details],
	[Status],
	[CreatedDate]
)
VALUES
(
--	@SmsLogID,
	@UserID,
	@InstanceID,
	ISNULL(@CustomerID, ((0))),
	@SmsID,
	@TemplateName,
	@CountryCode,
	@FromNumber,
	@ToNumber,
	@Details,
	ISNULL(@Status, ((0))),
	@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @SmsLogID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_sms_logs_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'sms_logs'
-- using the Primary Key. 
-- Gets: @SmsLogID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_sms_logs_Delete]
	@SmsLogID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[sms_logs]
WHERE
	[SmsLogID] = @SmsLogID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_purchase_invoice_SelectAll]

CREATE PROCEDURE [dbo].[SP_purchase_invoice_Insert]

		@InvoiceID       		bigint OUTPUT,
		@InstanceID      		bigint,
		@UserID          		bigint,
		@OfficeBranchID  		bigint = 0,
		@BranchName      		varchar (150) = 'Head Office',
		@SupplierID      		bigint,
		@Contact         		varchar (15),
		@TotalQuantity   		bigint,
		@TotalAmount     		decimal (10, 3) = '0.000',
		@Type            		varchar (10) = 1,
		@Narration       		varchar (255),
		@QuotationNo     		varchar (10),
		@QuotationDate   		date,
		@ReferenceNo     		varchar (10),
		@InvoiceDate     		date,
		@IsDeleted       		int = 0,
		@DeletedDateTime 		datetime,
		@CreatedDate     		datetime

AS

SET NOCOUNT ON;

INSERT [purchase_invoice]
(
		[InstanceID],
		[UserID],
		[OfficeBranchID],
		[BranchName],
		[SupplierID],
		[Contact],
		[TotalQuantity],
		[TotalAmount],
		[Type],
		[Narration],
		[QuotationNo],
		[QuotationDate],
		[ReferenceNo],
		[InvoiceDate],
		[IsDeleted],
		[DeletedDateTime],
		[CreatedDate]
)
VALUES
(
		@InstanceID,
		@UserID,
		@OfficeBranchID,
		@BranchName,
		@SupplierID,
		@Contact,
		@TotalQuantity,
		@TotalAmount,
		@Type,
		@Narration,
		@QuotationNo,
		@QuotationDate,
		@ReferenceNo,
		@InvoiceDate,
		@IsDeleted,
		@DeletedDateTime,
		@CreatedDate
)

SET @InvoiceID = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   [dbo].[SP_purchase_invoice_DeleteByPK] @InvoiceID = 1

CREATE PROCEDURE [dbo].[SP_purchase_invoice_Delete]

		@InvoiceID 		bigint

AS

SET NOCOUNT ON;

DELETE FROM [purchase_invoice]
WHERE [purchase_invoice].[InvoiceID] = @InvoiceID
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_Grid_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- ============================================
CREATE PROCEDURE [dbo].[SP_pos_Grid_SelectAll] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	SET NOCOUNT ON;
	--select it.ItemName,gp.GroupName,gp.GroupCode,gp.ColorCode,ip.Price,gp.GroupID from groups gp
	--			cross Join items it 
	--			inner join item_price ip on ip.ItemID=it.ItemID

	select it.ItemName,gp.GroupName,gp.GroupCode,gp.ColorCode,ip.Price,gp.GroupID from groups gp
	left join item_price ip on ip.GroupID=gp.GroupID
	left Join items it on ip.ItemID=it.ItemID
--   DECLARE @cols AS NVARCHAR(MAX),
--    @query  AS NVARCHAR(MAX)
--	select @cols = STUFF((SELECT ',' + QUOTENAME(GR.GroupID) from item_price IP
--					inner join items IT on IP.ItemID = IT.ItemID
--					inner join groups GR on GR.GroupID=IP.GroupID
--					group by GR.GroupID
--            FOR XML PATH(''), TYPE
--            ).value('.', 'NVARCHAR(MAX)') 
--        ,1,1,'')
		
--		set @query = 'SELECT ItemName,' + @cols + ' from 
--             (
--                select ItemName,GR.GroupID from item_price IP
--				inner join items IT on IP.ItemID = IT.ItemID
--				inner join groups GR on GR.GroupID=IP.GroupID
--            ) x
--            pivot 
--            (
--                MIN(GroupID)
--                FOR GroupID IN  (' + @cols + ')
--            ) p '

--execute(@query);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_pos_Insert]
	@PosID	bigint	output,
	@InstanceID bigint,
	@UserID bigint,
	@BillNo bigint,
	@CustomerID bigint,
	@CustomerBranchID bigint,
	@Type varchar(15),
	@TotalQuantity bigint,
	@TotalAmount decimal,
	@Discount decimal,
	@TotalPayable decimal,
	@PaidAmount decimal,
	@ReturnAmount decimal,
	@IsPaid int,
	@PaidBy int,
	@PaymentDateTime datetime,
	@Status int,
	@Comment varchar(255),
	@HangerQuantity bigint,
	@HangerRate decimal,
	@HangerAmount decimal,
	@IsClothCollected varchar(10),
	@IsCarpetInvoice int,
	@BillDate date,
	@BillTime time,
	@DeliveryDate date,
	@DeliveryTime time,
	@IsDeleted int,
	@DeletedDateTime datetime,
	@CreatedDate datetime  
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[pos]
(
	InstanceID,
	UserID,
	BillNo,
	CustomerID,
	CustomerBranchID,
	[Type],
	TotalQuantity,
	TotalAmount,
	Discount,
	TotalPayable,
	PaidAmount,
	ReturnAmount,
	IsPaid,
	PaidBy,
	PaymentDateTime,
	[Status],
	[Comment],
	HangerQuantity,
	HangerRate,
	HangerAmount,
	IsClothCollected,
	IsCarpetInvoice,
	BillDate,
	BillTime,
	DeliveryDate,
	DeliveryTime,
	IsDeleted,
	DeletedDateTime,
	CreatedDate
)
VALUES
(
@InstanceID,@UserID,@BillNo,@CustomerID,@CustomerBranchID,@Type,@TotalQuantity,@TotalAmount,@Discount,@TotalPayable,@PaidAmount,@ReturnAmount,@IsPaid,@PaidBy,@PaymentDateTime,@Status,@Comment,@HangerQuantity,@HangerRate,@HangerAmount,@IsClothCollected,@IsCarpetInvoice,@BillDate,@BillTime,@DeliveryDate,@DeliveryTime,@IsDeleted,@DeletedDateTime,@CreatedDate
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @PosID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_pos_Delete]
	@PosID	bigint	
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
delete from pos where PosID=@PosID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @PosID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_items_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'purchase_invoice_items'
-- Gets: @InvoiceItemID bigint
-- Gets: @InvoiceID bigint
-- Gets: @PurchaseItemID bigint
-- Gets: @Quantity bigint
-- Gets: @Rate decimal(10, 3)
-- Gets: @Amount decimal(10, 3)
-- Gets: @Description varchar(255)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_invoice_items_Update]
	@InvoiceItemID bigint,
	@InvoiceID bigint,
	@PurchaseItemID bigint,
	@Quantity bigint,
	@Rate decimal(10, 3),
	@Amount decimal(10, 3),
	@Description varchar(255)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[purchase_invoice_items]
SET 
	[InvoiceID] = @InvoiceID,
	[PurchaseItemID] = @PurchaseItemID,
	[Quantity] = @Quantity,
	[Rate] = @Rate,
	[Amount] = @Amount,
	[Description] = @Description
WHERE
	[InvoiceItemID] = @InvoiceItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_items_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'purchase_invoice_items'
-- based on the Primary Key.
-- Gets: @InvoiceItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_invoice_items_SelectOne]
	@InvoiceItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[InvoiceItemID],
	[InvoiceID],
	[PurchaseItemID],
	[Quantity],
	[Rate],
	[Amount],
	[Description]
FROM [dbo].[purchase_invoice_items]
WHERE
	[InvoiceItemID] = @InvoiceItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_items_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'purchase_invoice_items'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_invoice_items_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[InvoiceItemID],
	[InvoiceID],
	[PurchaseItemID],
	[Quantity],
	[Rate],
	[Amount],
	[Description]
FROM [dbo].[purchase_invoice_items]
ORDER BY 
	[InvoiceItemID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_items_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'purchase_invoice_items'
-- Gets: @InvoiceItemID bigint
-- Gets: @InvoiceID bigint
-- Gets: @PurchaseItemID bigint
-- Gets: @Quantity bigint
-- Gets: @Rate decimal(10, 3)
-- Gets: @Amount decimal(10, 3)
-- Gets: @Description varchar(255)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_invoice_items_Insert]
	@InvoiceItemID bigint output,
	@InvoiceID bigint,
	@PurchaseItemID bigint,
	@Quantity bigint,
	@Rate decimal(10, 3),
	@Amount decimal(10, 3),
	@Description varchar(255)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[purchase_invoice_items]
(
--	[InvoiceItemID],
	[InvoiceID],
	[PurchaseItemID],
	[Quantity],
	[Rate],
	[Amount],
	[Description]
)
VALUES
(
--	@InvoiceItemID,
	@InvoiceID,
	@PurchaseItemID,
	ISNULL(@Quantity, ('1')),
	@Rate,
	ISNULL(@Amount, ('0.000')),
	@Description
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @InvoiceItemID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_purchase_invoice_items_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'purchase_invoice_items'
-- using the Primary Key. 
-- Gets: @InvoiceItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_purchase_invoice_items_Delete]
	@InvoiceItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[purchase_invoice_items]
WHERE
	[InvoiceItemID] = @InvoiceItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  Table [dbo].[pos_items]    Script Date: 04/19/2017 01:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pos_items](
	[PosItemID] [bigint] IDENTITY(1,1) NOT NULL,
	[PosID] [bigint] NOT NULL,
	[ItemID] [bigint] NOT NULL,
	[GroupID] [bigint] NOT NULL,
	[ItemWidth] [decimal](10, 3) NOT NULL,
	[ItemLength] [decimal](10, 3) NOT NULL,
	[PriceRate] [varchar](10) NOT NULL,
	[Price] [decimal](10, 3) NOT NULL,
	[Quantity] [bigint] NOT NULL,
	[TotalPrice] [decimal](10, 3) NOT NULL,
 CONSTRAINT [PK__pos_item__4D9F4D33C812D398] PRIMARY KEY CLUSTERED 
(
	[PosItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_pos]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insert_pos]
@InstanceID bigint,
@UserID bigint,
@BillNo bigint,
@CustomerID bigint,
@CustomerBranchID bigint,
@Type varchar(15),
@TotalQuantity bigint,
@TotalAmount decimal,
@Discount decimal,
@TotalPayable decimal,
@PaidAmount decimal,
@ReturnAmount decimal,
@IsPaid int,
@PaidBy int,
@PaymentDateTime datetime,
@Status int,
@Comment varchar(255),
@HangerQuantity bigint,
@HangerRate decimal,
@HangerAmount decimal,
@IsClothCollected varchar(10),
@IsCarpetInvoice int,
@BillDate date,
@BillTime time,
@DeliveryDate date,
@DeliveryTime time,
@IsDeleted int,
@DeletedDateTime datetime,
@CreatedDate datetime  
AS
BEGIN
	Insert into pos (InstanceID,UserID,BillNo,CustomerID,CustomerBranchID,[Type],TotalQuantity,TotalAmount,Discount,TotalPayable,PaidAmount,ReturnAmount,IsPaid,PaidBy,PaymentDateTime,[Status],[Comment],HangerQuantity,HangerRate,HangerAmount,IsClothCollected,IsCarpetInvoice,BillDate,BillTime,DeliveryDate,DeliveryTime,IsDeleted,DeletedDateTime,CreatedDate)
	values(@InstanceID,@UserID,@BillNo,@CustomerID,@CustomerBranchID,@Type,@TotalQuantity,@TotalAmount,@Discount,@TotalPayable,@PaidAmount,@ReturnAmount,@IsPaid,@PaidBy,@PaymentDateTime,@Status,@Comment,@HangerQuantity,@HangerRate,@HangerAmount,@IsClothCollected,@IsCarpetInvoice,@BillDate,@BillTime,@DeliveryDate,@DeliveryTime,@IsDeleted,@DeletedDateTime,@CreatedDate)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_pos_Update]
	@PosID	bigint	,
	@InstanceID bigint,
	@UserID bigint,
	@BillNo bigint,
	@CustomerID bigint,
	@CustomerBranchID bigint,
	@Type varchar(15),
	@TotalQuantity bigint,
	@TotalAmount decimal,
	@Discount decimal,
	@TotalPayable decimal,
	@PaidAmount decimal,
	@ReturnAmount decimal,
	@IsPaid int,
	@PaidBy int,
	@PaymentDateTime datetime,
	@Status int,
	@Comment varchar(255),
	@HangerQuantity bigint,
	@HangerRate decimal,
	@HangerAmount decimal,
	@IsClothCollected varchar(10),
	@IsCarpetInvoice int,
	@BillDate date,
	@BillTime time,
	@DeliveryDate date,
	@DeliveryTime time,
	@IsDeleted int,
	@DeletedDateTime datetime,
	@CreatedDate datetime  
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
UPDATE [dbo].pos 
	SET 
	InstanceID=@InstanceID,
	UserID=@UserID,
	BillNo=@BillNo,
	CustomerID=@CustomerID,
	CustomerBranchID=@CustomerBranchID,
	[Type]=@Type,
	TotalQuantity=@TotalQuantity,
	TotalAmount=@TotalAmount,
	Discount=@Discount,
	TotalPayable=@TotalPayable,
	PaidAmount=@PaidAmount,
	ReturnAmount=@ReturnAmount,
	IsPaid=@IsPaid,
	PaidBy=@PaidBy,
	PaymentDateTime=@PaymentDateTime,
	[Status]=@Status,
	[Comment]=@Comment,
	HangerQuantity=@HangerQuantity,
	HangerRate=@HangerRate,
	HangerAmount=@HangerAmount,
	IsClothCollected=@IsClothCollected,
	IsCarpetInvoice=@IsCarpetInvoice,
	BillDate=@BillDate,
	BillTime=@BillTime,
	DeliveryDate=@DeliveryDate,
	DeliveryTime=@DeliveryTime,
	IsDeleted=@IsDeleted,
	DeletedDateTime=@DeletedDateTime,
	CreatedDate=@CreatedDate 
	WHERE PosID=@PosID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @PosID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_pos_SelectOne]
	@PosID	bigint	
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
Select 
PosID,
InstanceID,
	UserID,
	BillNo,
	CustomerID,
	CustomerBranchID,
	[Type],
	TotalQuantity,
	TotalAmount,
	Discount,
	TotalPayable,
	PaidAmount,
	ReturnAmount,
	IsPaid,
	PaidBy,
	PaymentDateTime,
	[Status],
	[Comment],
	HangerQuantity,
	HangerRate,
	HangerAmount,
	IsClothCollected,
	IsCarpetInvoice,
	BillDate,
	BillTime,
	DeliveryDate,
	DeliveryTime,
	IsDeleted,
	DeletedDateTime,
	CreatedDate
from
[dbo].[pos]
where
PosID=@PosID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_pos_SelectAll]
		
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
Select 
PosID,
InstanceID,
	UserID,
	BillNo,
	CustomerID,
	CustomerBranchID,
	[Type],
	TotalQuantity,
	TotalAmount,
	Discount,
	TotalPayable,
	PaidAmount,
	ReturnAmount,
	IsPaid,
	PaidBy,
	PaymentDateTime,
	[Status],
	[Comment],
	HangerQuantity,
	HangerRate,
	HangerAmount,
	IsClothCollected,
	IsCarpetInvoice,
	BillDate,
	BillTime,
	DeliveryDate,
	DeliveryTime,
	IsDeleted,
	DeletedDateTime,
	CreatedDate
from
[dbo].[pos]

-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_items_Update]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will update an existing row in the table 'pos_items'
-- Gets: @PosItemID bigint
-- Gets: @PosID bigint
-- Gets: @ItemID bigint
-- Gets: @GroupID bigint
-- Gets: @ItemWidth decimal(10, 3)
-- Gets: @ItemLength decimal(10, 3)
-- Gets: @PriceRate varchar(10)
-- Gets: @Price decimal(10, 3)
-- Gets: @Quantity bigint
-- Gets: @TotalPrice decimal(10, 3)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_pos_items_Update]
	@PosItemID bigint,
	@PosID bigint,
	@ItemID bigint,
	@GroupID bigint,
	@ItemWidth decimal(10, 3),
	@ItemLength decimal(10, 3),
	@PriceRate varchar(10),
	@Price decimal(10, 3),
	@Quantity bigint,
	@TotalPrice decimal(10, 3)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- UPDATE an existing row in the table.
UPDATE [dbo].[pos_items]
SET 
	[PosID] = @PosID,
	[ItemID] = @ItemID,
	[GroupID] = @GroupID,
	[ItemWidth] = @ItemWidth,
	[ItemLength] = @ItemLength,
	[PriceRate] = @PriceRate,
	[Price] = @Price,
	[Quantity] = @Quantity,
	[TotalPrice] = @TotalPrice
WHERE
	[PosItemID] = @PosItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_items_SelectOne]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select an existing row from the table 'pos_items'
-- based on the Primary Key.
-- Gets: @PosItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_pos_items_SelectOne]
	@PosItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT an existing row from the table.
SELECT
	[PosItemID],
	[PosID],
	[ItemID],
	[GroupID],
	[ItemWidth],
	[ItemLength],
	[PriceRate],
	[Price],
	[Quantity],
	[TotalPrice]
FROM [dbo].[pos_items]
WHERE
	[PosItemID] = @PosItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_items_SelectAll]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will select all rows from the table 'pos_items'
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_pos_items_SelectAll]
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- SELECT all rows from the table.
SELECT
	[PosItemID],
	[PosID],
	[ItemID],
	[GroupID],
	[ItemWidth],
	[ItemLength],
	[PriceRate],
	[Price],
	[Quantity],
	[TotalPrice]
FROM [dbo].[pos_items]
ORDER BY 
	[PosItemID] ASC
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_items_Insert]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will insert 1 row in the table 'pos_items'
-- Gets: @PosItemID bigint
-- Gets: @PosID bigint
-- Gets: @ItemID bigint
-- Gets: @GroupID bigint
-- Gets: @ItemWidth decimal(10, 3)
-- Gets: @ItemLength decimal(10, 3)
-- Gets: @PriceRate varchar(10)
-- Gets: @Price decimal(10, 3)
-- Gets: @Quantity bigint
-- Gets: @TotalPrice decimal(10, 3)
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_pos_items_Insert]
	@PosItemID bigint output,
	@PosID bigint,
	@ItemID bigint,
	@GroupID bigint,
	@ItemWidth decimal(10, 3),
	@ItemLength decimal(10, 3),
	@PriceRate varchar(10),
	@Price decimal(10, 3),
	@Quantity bigint,
	@TotalPrice decimal(10, 3)
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- INSERT a new row in the table.
INSERT [dbo].[pos_items]
(
--	[PosItemID],
	[PosID],
	[ItemID],
	[GroupID],
	[ItemWidth],
	[ItemLength],
	[PriceRate],
	[Price],
	[Quantity],
	[TotalPrice]
)
VALUES
(
--	@PosItemID,
	@PosID,
	@ItemID,
	@GroupID,
	ISNULL(@ItemWidth, ('0.000')),
	ISNULL(@ItemLength, ('0.000')),
	ISNULL(@PriceRate, ('Fixed')),
	@Price,
	@Quantity,
	@TotalPrice
)
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
-- Get the IDENTITY value for the row just inserted.
SELECT @PosItemID=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[SP_pos_items_Delete]    Script Date: 04/19/2017 01:06:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------
-- Stored procedure that will delete an existing row from the table 'pos_items'
-- using the Primary Key. 
-- Gets: @PosItemID bigint
-- Returns: @ErrorCode int
---------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_pos_items_Delete]
	@PosItemID bigint
--	@ErrorCode int OUTPUT
AS
SET NOCOUNT ON
-- DELETE an existing row from the table.
DELETE FROM [dbo].[pos_items]
WHERE
	[PosItemID] = @PosItemID
-- Get the Error Code for the statement just executed.
--SELECT @ErrorCode=@@ERROR
GO
/****** Object:  Default [DF__customers__Balan__3F115E1A]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[customers] ADD  CONSTRAINT [DF__customers__Balan__3F115E1A]  DEFAULT ('0.000') FOR [Balance]
GO
/****** Object:  Default [DF__customers__Statu__40058253]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[customers] ADD  CONSTRAINT [DF__customers__Statu__40058253]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF__expenses__Office__40F9A68C]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[expenses] ADD  CONSTRAINT [DF__expenses__Office__40F9A68C]  DEFAULT ((0)) FOR [OfficeBranchID]
GO
/****** Object:  Default [DF__expenses__Amount__41EDCAC5]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[expenses] ADD  CONSTRAINT [DF__expenses__Amount__41EDCAC5]  DEFAULT ('0.000') FOR [Amount]
GO
/****** Object:  Default [DF__expenses__PaidBy__42E1EEFE]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[expenses] ADD  CONSTRAINT [DF__expenses__PaidBy__42E1EEFE]  DEFAULT ((1)) FOR [PaidBy]
GO
/****** Object:  Default [DF__expenses__IsDele__43D61337]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[expenses] ADD  CONSTRAINT [DF__expenses__IsDele__43D61337]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF__groups__ColorCod__44CA3770]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[groups] ADD  CONSTRAINT [DF__groups__ColorCod__44CA3770]  DEFAULT ('#000000') FOR [ColorCode]
GO
/****** Object:  Default [DF__groups__Status__45BE5BA9]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[groups] ADD  CONSTRAINT [DF__groups__Status__45BE5BA9]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF__instance___Tax1N__46B27FE2]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Tax1N__46B27FE2]  DEFAULT (NULL) FOR [Tax1Name]
GO
/****** Object:  Default [DF__instance___Tax1V__47A6A41B]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Tax1V__47A6A41B]  DEFAULT ('0.00') FOR [Tax1Value]
GO
/****** Object:  Default [DF__instance___Tax2N__489AC854]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Tax2N__489AC854]  DEFAULT (NULL) FOR [Tax2Name]
GO
/****** Object:  Default [DF__instance___Tax2V__498EEC8D]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Tax2V__498EEC8D]  DEFAULT ('0.00') FOR [Tax2Value]
GO
/****** Object:  Default [DF__instance___Tax3N__4A8310C6]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Tax3N__4A8310C6]  DEFAULT (NULL) FOR [Tax3Name]
GO
/****** Object:  Default [DF__instance___Tax3V__4B7734FF]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Tax3V__4B7734FF]  DEFAULT ('0.00') FOR [Tax3Value]
GO
/****** Object:  Default [DF__instance___BillN__4C6B5938]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___BillN__4C6B5938]  DEFAULT ((1)) FOR [BillNoReset]
GO
/****** Object:  Default [DF__instance___Email__4D5F7D71]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Email__4D5F7D71]  DEFAULT (NULL) FOR [EmailFrom]
GO
/****** Object:  Default [DF__instance___Passw__4E53A1AA]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Passw__4E53A1AA]  DEFAULT (NULL) FOR [Password]
GO
/****** Object:  Default [DF__instance___Insta__4F47C5E3]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Insta__4F47C5E3]  DEFAULT ((0)) FOR [InstanceLogo]
GO
/****** Object:  Default [DF__instance___PosBi__503BEA1C]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___PosBi__503BEA1C]  DEFAULT ((0)) FOR [PosBillPrintLogo]
GO
/****** Object:  Default [DF__instance___PosDe__51300E55]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___PosDe__51300E55]  DEFAULT ((1)) FOR [PosDeliveryDays]
GO
/****** Object:  Default [DF__instance___PosIt__5224328E]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___PosIt__5224328E]  DEFAULT ((1)) FOR [PosItemOrder]
GO
/****** Object:  Default [DF__instance___PosIt__531856C7]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___PosIt__531856C7]  DEFAULT ((0)) FOR [PosItemLocalNameDisplay]
GO
/****** Object:  Default [DF__instance___PosIt__540C7B00]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___PosIt__540C7B00]  DEFAULT ((0)) FOR [PosItemLocalNameBillPrint]
GO
/****** Object:  Default [DF__instance___Count__55009F39]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Count__55009F39]  DEFAULT (NULL) FOR [CountryCode]
GO
/****** Object:  Default [DF__instance___Mobil__55F4C372]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Mobil__55F4C372]  DEFAULT (NULL) FOR [MobileNo]
GO
/****** Object:  Default [DF__instance___Accou__56E8E7AB]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Accou__56E8E7AB]  DEFAULT (NULL) FOR [AccountSID]
GO
/****** Object:  Default [DF__instance___AuthT__57DD0BE4]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___AuthT__57DD0BE4]  DEFAULT (NULL) FOR [AuthToken]
GO
/****** Object:  Default [DF__instance___Hange__58D1301D]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Hange__58D1301D]  DEFAULT ('0.000') FOR [HangerRate]
GO
/****** Object:  Default [DF__instance___Messa__59C55456]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Messa__59C55456]  DEFAULT (NULL) FOR [MessageEndOfBill]
GO
/****** Object:  Default [DF__instance___TnCEn__5AB9788F]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___TnCEn__5AB9788F]  DEFAULT (NULL) FOR [TnCEnglish]
GO
/****** Object:  Default [DF__instance___TnCLo__5BAD9CC8]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___TnCLo__5BAD9CC8]  DEFAULT (NULL) FOR [TnCLocalLanguage]
GO
/****** Object:  Default [DF__instance___Itemw__5CA1C101]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___Itemw__5CA1C101]  DEFAULT ((0)) FOR [ItemwiseReportLocalLanguage]
GO
/****** Object:  Default [DF__instance___MaxDi__5D95E53A]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instance_settings] ADD  CONSTRAINT [DF__instance___MaxDi__5D95E53A]  DEFAULT ('0.00') FOR [MaxDiscountPercentage]
GO
/****** Object:  Default [DF__instances__Versi__5E8A0973]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[instances] ADD  CONSTRAINT [DF__instances__Versi__5E8A0973]  DEFAULT ('1') FOR [Version]
GO
/****** Object:  Default [DF__item_pric__Price__5F7E2DAC]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[item_price] ADD  CONSTRAINT [DF__item_pric__Price__5F7E2DAC]  DEFAULT ('0.000') FOR [Price]
GO
/****** Object:  Default [DF__items__CustomerI__607251E5]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[items] ADD  CONSTRAINT [DF__items__CustomerI__607251E5]  DEFAULT ((0)) FOR [CustomerID]
GO
/****** Object:  Default [DF__items__PriceRate__6166761E]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[items] ADD  CONSTRAINT [DF__items__PriceRate__6166761E]  DEFAULT ('Fixed') FOR [PriceRate]
GO
/****** Object:  Default [DF__items__Status__625A9A57]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[items] ADD  CONSTRAINT [DF__items__Status__625A9A57]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF__office_br__Amoun__634EBE90]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[office_branch_sales] ADD  CONSTRAINT [DF__office_br__Amoun__634EBE90]  DEFAULT ('0.000') FOR [Amount]
GO
/****** Object:  Default [DF__pos__CustomerBra__6442E2C9]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__CustomerBra__6442E2C9]  DEFAULT ((0)) FOR [CustomerBranchID]
GO
/****** Object:  Default [DF__pos__Type__65370702]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__Type__65370702]  DEFAULT ('Regular') FOR [Type]
GO
/****** Object:  Default [DF__pos__Discount__662B2B3B]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__Discount__662B2B3B]  DEFAULT ('0.000') FOR [Discount]
GO
/****** Object:  Default [DF__pos__ReturnAmoun__671F4F74]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__ReturnAmoun__671F4F74]  DEFAULT ('0.000') FOR [ReturnAmount]
GO
/****** Object:  Default [DF__pos__IsPaid__681373AD]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__IsPaid__681373AD]  DEFAULT ((0)) FOR [IsPaid]
GO
/****** Object:  Default [DF__pos__PaidBy__690797E6]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__PaidBy__690797E6]  DEFAULT ((1)) FOR [PaidBy]
GO
/****** Object:  Default [DF__pos__PaymentDate__69FBBC1F]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__PaymentDate__69FBBC1F]  DEFAULT (NULL) FOR [PaymentDateTime]
GO
/****** Object:  Default [DF__pos__Status__6AEFE058]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__Status__6AEFE058]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF__pos__HangerQuant__6BE40491]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__HangerQuant__6BE40491]  DEFAULT ((0)) FOR [HangerQuantity]
GO
/****** Object:  Default [DF__pos__HangerRate__6CD828CA]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__HangerRate__6CD828CA]  DEFAULT ('0.000') FOR [HangerRate]
GO
/****** Object:  Default [DF__pos__HangerAmoun__6DCC4D03]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__HangerAmoun__6DCC4D03]  DEFAULT ('0.000') FOR [HangerAmount]
GO
/****** Object:  Default [DF__pos__IsClothColl__6EC0713C]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__IsClothColl__6EC0713C]  DEFAULT ('No') FOR [IsClothCollected]
GO
/****** Object:  Default [DF__pos__IsCarpetInv__6FB49575]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__IsCarpetInv__6FB49575]  DEFAULT ((0)) FOR [IsCarpetInvoice]
GO
/****** Object:  Default [DF__pos__IsDeleted__70A8B9AE]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__IsDeleted__70A8B9AE]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF__pos__DeletedDate__719CDDE7]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos] ADD  CONSTRAINT [DF__pos__DeletedDate__719CDDE7]  DEFAULT (NULL) FOR [DeletedDateTime]
GO
/****** Object:  Default [DF__pos_items__ItemW__72910220]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos_items] ADD  CONSTRAINT [DF__pos_items__ItemW__72910220]  DEFAULT ('0.000') FOR [ItemWidth]
GO
/****** Object:  Default [DF__pos_items__ItemL__73852659]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos_items] ADD  CONSTRAINT [DF__pos_items__ItemL__73852659]  DEFAULT ('0.000') FOR [ItemLength]
GO
/****** Object:  Default [DF__pos_items__Price__74794A92]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos_items] ADD  CONSTRAINT [DF__pos_items__Price__74794A92]  DEFAULT ('Fixed') FOR [PriceRate]
GO
/****** Object:  Default [DF__posbillco__Total__756D6ECB]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[posbillcount] ADD  CONSTRAINT [DF__posbillco__Total__756D6ECB]  DEFAULT ((0)) FOR [TotalBills]
GO
/****** Object:  Default [DF__purchase___Offic__76619304]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice] ADD  CONSTRAINT [DF__purchase___Offic__76619304]  DEFAULT ((0)) FOR [OfficeBranchID]
GO
/****** Object:  Default [DF__purchase___Branc__7755B73D]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice] ADD  CONSTRAINT [DF__purchase___Branc__7755B73D]  DEFAULT ('Head Office') FOR [BranchName]
GO
/****** Object:  Default [DF__purchase___Total__7849DB76]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice] ADD  CONSTRAINT [DF__purchase___Total__7849DB76]  DEFAULT ('0.000') FOR [TotalAmount]
GO
/****** Object:  Default [DF__purchase_i__Type__793DFFAF]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice] ADD  CONSTRAINT [DF__purchase_i__Type__793DFFAF]  DEFAULT ((1)) FOR [Type]
GO
/****** Object:  Default [DF__purchase___IsDel__7A3223E8]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice] ADD  CONSTRAINT [DF__purchase___IsDel__7A3223E8]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF__purchase___Quant__7B264821]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice_items] ADD  CONSTRAINT [DF__purchase___Quant__7B264821]  DEFAULT ('1') FOR [Quantity]
GO
/****** Object:  Default [DF__purchase___Amoun__7C1A6C5A]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice_items] ADD  CONSTRAINT [DF__purchase___Amoun__7C1A6C5A]  DEFAULT ('0.000') FOR [Amount]
GO
/****** Object:  Default [DF__purchase___Statu__7D0E9093]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_items_master] ADD  CONSTRAINT [DF__purchase___Statu__7D0E9093]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF__sms_logs__Custom__7E02B4CC]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[sms_logs] ADD  CONSTRAINT [DF__sms_logs__Custom__7E02B4CC]  DEFAULT ((0)) FOR [CustomerID]
GO
/****** Object:  Default [DF__sms_logs__Status__7EF6D905]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[sms_logs] ADD  CONSTRAINT [DF__sms_logs__Status__7EF6D905]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF__sms_templ__ismar__7FEAFD3E]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[sms_templates] ADD  CONSTRAINT [DF__sms_templ__ismar__7FEAFD3E]  DEFAULT ((0)) FOR [ismart_sms_language]
GO
/****** Object:  Default [DF__suppliers__Balan__00DF2177]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF__suppliers__Balan__00DF2177]  DEFAULT ('0.000') FOR [Balance]
GO
/****** Object:  Default [DF__suppliers__Statu__01D345B0]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF__suppliers__Statu__01D345B0]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  ForeignKey [FK_customers_instances]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[customers]  WITH CHECK ADD  CONSTRAINT [FK_customers_instances] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[customers] CHECK CONSTRAINT [FK_customers_instances]
GO
/****** Object:  ForeignKey [FK_customers_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[customers]  WITH CHECK ADD  CONSTRAINT [FK_customers_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[customers] CHECK CONSTRAINT [FK_customers_UserID]
GO
/****** Object:  ForeignKey [FK_customers_branch_CustomerID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[customers_branch]  WITH CHECK ADD  CONSTRAINT [FK_customers_branch_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[customers] ([CustomerID])
GO
ALTER TABLE [dbo].[customers_branch] CHECK CONSTRAINT [FK_customers_branch_CustomerID]
GO
/****** Object:  ForeignKey [FK_customers_branch_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[customers_branch]  WITH CHECK ADD  CONSTRAINT [FK_customers_branch_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[customers_branch] CHECK CONSTRAINT [FK_customers_branch_InstanceID]
GO
/****** Object:  ForeignKey [FK_customers_branch_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[customers_branch]  WITH CHECK ADD  CONSTRAINT [FK_customers_branch_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[customers_branch] CHECK CONSTRAINT [FK_customers_branch_UserID]
GO
/****** Object:  ForeignKey [FK_Expense_Mst_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[Expense_Mst]  WITH CHECK ADD  CONSTRAINT [FK_Expense_Mst_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[Expense_Mst] CHECK CONSTRAINT [FK_Expense_Mst_InstanceID]
GO
/****** Object:  ForeignKey [FK_expenses_ExpenseItemID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[expenses]  WITH CHECK ADD  CONSTRAINT [FK_expenses_ExpenseItemID] FOREIGN KEY([ExpenseItemID])
REFERENCES [dbo].[Expense_Mst] ([ExpenseItemID])
GO
ALTER TABLE [dbo].[expenses] CHECK CONSTRAINT [FK_expenses_ExpenseItemID]
GO
/****** Object:  ForeignKey [FK_expenses_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[expenses]  WITH CHECK ADD  CONSTRAINT [FK_expenses_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[expenses] CHECK CONSTRAINT [FK_expenses_InstanceID]
GO
/****** Object:  ForeignKey [FK_expenses_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[expenses]  WITH CHECK ADD  CONSTRAINT [FK_expenses_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[expenses] CHECK CONSTRAINT [FK_expenses_UserID]
GO
/****** Object:  ForeignKey [FK_groups_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[groups]  WITH CHECK ADD  CONSTRAINT [FK_groups_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[groups] CHECK CONSTRAINT [FK_groups_InstanceID]
GO
/****** Object:  ForeignKey [FK_groups_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[groups]  WITH CHECK ADD  CONSTRAINT [FK_groups_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[groups] CHECK CONSTRAINT [FK_groups_UserID]
GO
/****** Object:  ForeignKey [FK_item_price_GroupID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[item_price]  WITH CHECK ADD  CONSTRAINT [FK_item_price_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[groups] ([GroupID])
GO
ALTER TABLE [dbo].[item_price] CHECK CONSTRAINT [FK_item_price_GroupID]
GO
/****** Object:  ForeignKey [FK_items_CustomerID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [FK_items_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[customers] ([CustomerID])
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [FK_items_CustomerID]
GO
/****** Object:  ForeignKey [FK_items_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [FK_items_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [FK_items_InstanceID]
GO
/****** Object:  ForeignKey [FK_items_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [FK_items_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [FK_items_UserID]
GO
/****** Object:  ForeignKey [FK_office_branch_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[office_branch]  WITH CHECK ADD  CONSTRAINT [FK_office_branch_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[office_branch] CHECK CONSTRAINT [FK_office_branch_InstanceID]
GO
/****** Object:  ForeignKey [FK_office_branch_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[office_branch]  WITH CHECK ADD  CONSTRAINT [FK_office_branch_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[office_branch] CHECK CONSTRAINT [FK_office_branch_UserID]
GO
/****** Object:  ForeignKey [FK_office_branch_sales_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[office_branch_sales]  WITH CHECK ADD  CONSTRAINT [FK_office_branch_sales_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[office_branch_sales] CHECK CONSTRAINT [FK_office_branch_sales_InstanceID]
GO
/****** Object:  ForeignKey [FK_office_branch_sales_office_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[office_branch_sales]  WITH CHECK ADD  CONSTRAINT [FK_office_branch_sales_office_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[office_branch_sales] CHECK CONSTRAINT [FK_office_branch_sales_office_UserID]
GO
/****** Object:  ForeignKey [FK_office_branch_sales_officeBranchID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[office_branch_sales]  WITH CHECK ADD  CONSTRAINT [FK_office_branch_sales_officeBranchID] FOREIGN KEY([OfficeBranchID])
REFERENCES [dbo].[office_branch] ([OfficeBranchID])
GO
ALTER TABLE [dbo].[office_branch_sales] CHECK CONSTRAINT [FK_office_branch_sales_officeBranchID]
GO
/****** Object:  ForeignKey [FK_PageMaster_moduleid]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[PageMaster]  WITH CHECK ADD  CONSTRAINT [FK_PageMaster_moduleid] FOREIGN KEY([moduleid])
REFERENCES [dbo].[ModuleMaster] ([moduleid])
GO
ALTER TABLE [dbo].[PageMaster] CHECK CONSTRAINT [FK_PageMaster_moduleid]
GO
/****** Object:  ForeignKey [FK_Party_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[Party]  WITH CHECK ADD  CONSTRAINT [FK_Party_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[Party] CHECK CONSTRAINT [FK_Party_InstanceID]
GO
/****** Object:  ForeignKey [FK_Party_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[Party]  WITH CHECK ADD  CONSTRAINT [FK_Party_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[Party] CHECK CONSTRAINT [FK_Party_UserID]
GO
/****** Object:  ForeignKey [FK_pos_CustomerBranchID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos]  WITH CHECK ADD  CONSTRAINT [FK_pos_CustomerBranchID] FOREIGN KEY([CustomerBranchID])
REFERENCES [dbo].[customers_branch] ([CustomerBranchID])
GO
ALTER TABLE [dbo].[pos] CHECK CONSTRAINT [FK_pos_CustomerBranchID]
GO
/****** Object:  ForeignKey [FK_pos_CustomerID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos]  WITH CHECK ADD  CONSTRAINT [FK_pos_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[customers] ([CustomerID])
GO
ALTER TABLE [dbo].[pos] CHECK CONSTRAINT [FK_pos_CustomerID]
GO
/****** Object:  ForeignKey [FK_pos_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos]  WITH CHECK ADD  CONSTRAINT [FK_pos_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[pos] CHECK CONSTRAINT [FK_pos_InstanceID]
GO
/****** Object:  ForeignKey [FK_pos_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos]  WITH CHECK ADD  CONSTRAINT [FK_pos_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[pos] CHECK CONSTRAINT [FK_pos_UserID]
GO
/****** Object:  ForeignKey [FK_pos_items_GroupID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos_items]  WITH CHECK ADD  CONSTRAINT [FK_pos_items_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[groups] ([GroupID])
GO
ALTER TABLE [dbo].[pos_items] CHECK CONSTRAINT [FK_pos_items_GroupID]
GO
/****** Object:  ForeignKey [FK_pos_items_ItemID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos_items]  WITH CHECK ADD  CONSTRAINT [FK_pos_items_ItemID] FOREIGN KEY([ItemID])
REFERENCES [dbo].[items] ([ItemID])
GO
ALTER TABLE [dbo].[pos_items] CHECK CONSTRAINT [FK_pos_items_ItemID]
GO
/****** Object:  ForeignKey [FK_pos_items_PosID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[pos_items]  WITH CHECK ADD  CONSTRAINT [FK_pos_items_PosID] FOREIGN KEY([PosID])
REFERENCES [dbo].[pos] ([PosID])
GO
ALTER TABLE [dbo].[pos_items] CHECK CONSTRAINT [FK_pos_items_PosID]
GO
/****** Object:  ForeignKey [FK_posbillcount_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[posbillcount]  WITH CHECK ADD  CONSTRAINT [FK_posbillcount_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[posbillcount] CHECK CONSTRAINT [FK_posbillcount_InstanceID]
GO
/****** Object:  ForeignKey [FK_PreSubMenu_meniid]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[PreSubMenu]  WITH CHECK ADD  CONSTRAINT [FK_PreSubMenu_meniid] FOREIGN KEY([menuid])
REFERENCES [dbo].[MenuMaster] ([menuid])
GO
ALTER TABLE [dbo].[PreSubMenu] CHECK CONSTRAINT [FK_PreSubMenu_meniid]
GO
/****** Object:  ForeignKey [FK_PreSubMenu_submenuid]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[PreSubMenu]  WITH CHECK ADD  CONSTRAINT [FK_PreSubMenu_submenuid] FOREIGN KEY([menuid])
REFERENCES [dbo].[MenuMaster] ([menuid])
GO
ALTER TABLE [dbo].[PreSubMenu] CHECK CONSTRAINT [FK_PreSubMenu_submenuid]
GO
/****** Object:  ForeignKey [FK_purchase_invoice_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice]  WITH CHECK ADD  CONSTRAINT [FK_purchase_invoice_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[purchase_invoice] CHECK CONSTRAINT [FK_purchase_invoice_InstanceID]
GO
/****** Object:  ForeignKey [FK_purchase_invoice_OfficeBranchID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice]  WITH CHECK ADD  CONSTRAINT [FK_purchase_invoice_OfficeBranchID] FOREIGN KEY([OfficeBranchID])
REFERENCES [dbo].[office_branch] ([OfficeBranchID])
GO
ALTER TABLE [dbo].[purchase_invoice] CHECK CONSTRAINT [FK_purchase_invoice_OfficeBranchID]
GO
/****** Object:  ForeignKey [FK_purchase_invoice_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice]  WITH CHECK ADD  CONSTRAINT [FK_purchase_invoice_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[purchase_invoice] CHECK CONSTRAINT [FK_purchase_invoice_UserID]
GO
/****** Object:  ForeignKey [FK_purchase_invoice_items_InvoiceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_invoice_items]  WITH CHECK ADD  CONSTRAINT [FK_purchase_invoice_items_InvoiceID] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[purchase_invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[purchase_invoice_items] CHECK CONSTRAINT [FK_purchase_invoice_items_InvoiceID]
GO
/****** Object:  ForeignKey [FK_purchase_items_master_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_items_master]  WITH CHECK ADD  CONSTRAINT [FK_purchase_items_master_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[purchase_items_master] CHECK CONSTRAINT [FK_purchase_items_master_InstanceID]
GO
/****** Object:  ForeignKey [FK_purchase_items_master_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[purchase_items_master]  WITH CHECK ADD  CONSTRAINT [FK_purchase_items_master_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[purchase_items_master] CHECK CONSTRAINT [FK_purchase_items_master_UserID]
GO
/****** Object:  ForeignKey [FK_sms_logs_CustomerID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[sms_logs]  WITH CHECK ADD  CONSTRAINT [FK_sms_logs_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[customers] ([CustomerID])
GO
ALTER TABLE [dbo].[sms_logs] CHECK CONSTRAINT [FK_sms_logs_CustomerID]
GO
/****** Object:  ForeignKey [FK_sms_logs_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[sms_logs]  WITH CHECK ADD  CONSTRAINT [FK_sms_logs_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[sms_logs] CHECK CONSTRAINT [FK_sms_logs_InstanceID]
GO
/****** Object:  ForeignKey [FK_sms_logs_IsnstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[sms_logs]  WITH CHECK ADD  CONSTRAINT [FK_sms_logs_IsnstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[sms_logs] CHECK CONSTRAINT [FK_sms_logs_IsnstanceID]
GO
/****** Object:  ForeignKey [FK_sms_logs_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[sms_logs]  WITH CHECK ADD  CONSTRAINT [FK_sms_logs_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[sms_logs] CHECK CONSTRAINT [FK_sms_logs_UserID]
GO
/****** Object:  ForeignKey [FK_sms_templates_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[sms_templates]  WITH CHECK ADD  CONSTRAINT [FK_sms_templates_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[sms_templates] CHECK CONSTRAINT [FK_sms_templates_UserID]
GO
/****** Object:  ForeignKey [FK_suppliers_InstanceID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[suppliers]  WITH CHECK ADD  CONSTRAINT [FK_suppliers_InstanceID] FOREIGN KEY([InstanceID])
REFERENCES [dbo].[instances] ([InstanceID])
GO
ALTER TABLE [dbo].[suppliers] CHECK CONSTRAINT [FK_suppliers_InstanceID]
GO
/****** Object:  ForeignKey [FK_suppliers_UserID]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[suppliers]  WITH CHECK ADD  CONSTRAINT [FK_suppliers_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[suppliers] CHECK CONSTRAINT [FK_suppliers_UserID]
GO
/****** Object:  ForeignKey [FK_UserRightsMaster_empid]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[UserRightsMaster]  WITH CHECK ADD  CONSTRAINT [FK_UserRightsMaster_empid] FOREIGN KEY([empid])
REFERENCES [dbo].[EmployeeMaster] ([empid])
GO
ALTER TABLE [dbo].[UserRightsMaster] CHECK CONSTRAINT [FK_UserRightsMaster_empid]
GO
/****** Object:  ForeignKey [FK_UserRightsMaster_moduleid]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[UserRightsMaster]  WITH CHECK ADD  CONSTRAINT [FK_UserRightsMaster_moduleid] FOREIGN KEY([moduleid])
REFERENCES [dbo].[ModuleMaster] ([moduleid])
GO
ALTER TABLE [dbo].[UserRightsMaster] CHECK CONSTRAINT [FK_UserRightsMaster_moduleid]
GO
/****** Object:  ForeignKey [FK_UserRightsMaster_pageid]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[UserRightsMaster]  WITH CHECK ADD  CONSTRAINT [FK_UserRightsMaster_pageid] FOREIGN KEY([pageid])
REFERENCES [dbo].[PageMaster] ([pageid])
GO
ALTER TABLE [dbo].[UserRightsMaster] CHECK CONSTRAINT [FK_UserRightsMaster_pageid]
GO
/****** Object:  ForeignKey [FK_UserRightsMaster_rollid]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[UserRightsMaster]  WITH CHECK ADD  CONSTRAINT [FK_UserRightsMaster_rollid] FOREIGN KEY([rollid])
REFERENCES [dbo].[RollMaster] ([rollid])
GO
ALTER TABLE [dbo].[UserRightsMaster] CHECK CONSTRAINT [FK_UserRightsMaster_rollid]
GO
/****** Object:  ForeignKey [FK_UserRightsMaster_userid]    Script Date: 04/19/2017 01:06:40 ******/
ALTER TABLE [dbo].[UserRightsMaster]  WITH CHECK ADD  CONSTRAINT [FK_UserRightsMaster_userid] FOREIGN KEY([userid])
REFERENCES [dbo].[UserMaster] ([userid])
GO
ALTER TABLE [dbo].[UserRightsMaster] CHECK CONSTRAINT [FK_UserRightsMaster_userid]
GO
