
/****** Object:  Table [dbo].[SysFunction]    Script Date: 2015-11-26 15:10:12 ******/
IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE ID=OBJECT_ID(N'[SysFunction]') AND XTYPE='U')
DROP TABLE [SysFunction]
GO
CREATE TABLE [dbo].[SysFunction](
	[SysFunction_Id] [varchar](50) NOT NULL,--功能模块ID
	[Name] [varchar](50) NOT NULL,          --功能模块名称
	[EnglishName] [varchar](50) NOT NULL,   --英文名称
	[Iconic] [varchar](50) NULL,            --图标
    [Sort] [int] NULL,                      --排序
    [Remark] [varchar](4000) NULL,          --说明
    [State] [bit] NULL,                     --状态
    [CreatePerson] [varchar](200) NULL,     --创建人
    [CreateTime] [datetime] NULL,           --创建时间
    [Version] [varchar](50) NULL,             --版本
 CONSTRAINT [PK_SysFunction] PRIMARY KEY CLUSTERED 
(
	[SysFunction_Id] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[MenuGroup]    Script Date: 2015-11-26 15:10:12 ******/
IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE ID=OBJECT_ID(N'[MenuGroup]') AND XTYPE='U')
DROP TABLE [MenuGroup]
GO
CREATE TABLE [dbo].[MenuGroup](
	[MenuGroup_Id] [varchar](50) NOT NULL,  --管理模块ID
	[SysFunction_Id] [varchar](50) NOT NULL,--功能模块ID
	[Name] [varchar](50) NOT NULL,          --管理模块名称
	[EnglishName] [varchar](50) NOT NULL,   --英文名称
	[Iconic] [varchar](50) NULL,            --图标
    [Sort] [int] NULL,                      --排序
    [Remark] [varchar](4000) NULL,          --说明
    [State] [bit] NULL,                     --状态
    [CreatePerson] [varchar](200) NULL,     --创建人
    [CreateTime] [datetime] NULL,           --创建时间
    [Version] [varchar](50) NULL,           --版本
 CONSTRAINT [PK_MenuGroup] PRIMARY KEY CLUSTERED 
(
	[MenuGroup_Id] ASC
)WITH FILLFACTOR = 90 ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[Menu]    Script Date: 2015-11-26 15:10:12 ******/
IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE ID=OBJECT_ID(N'[Menu]') AND XTYPE='U')
DROP TABLE [Menu]
GO
CREATE TABLE [dbo].[Menu](
    [Menu_Id] [varchar](50) NOT NULL,       --菜单ID
	[MenuGroup_Id] [varchar](50) NOT NULL,  --管理模块ID
    [ModelId] [varchar](50) NOT NULL,       --模组ID
    [Name] [varchar](200) NOT NULL,         --模块名称
    [EnglishName] [varchar](200) NULL,      --英文名称（防止将来国际化）
    [Url] [varchar](200) NULL,              --链接
    [Iconic] [varchar](200) NULL,           --图标，用于链接图标，或tab页图标
    [Sort] [int] NULL,                      --排序
    [Remark] [varchar](4000) NULL,          --说明
    [State] [bit] NULL,                     --状态
    [CreatePerson] [varchar](200) NULL,     --创建人
    [CreateTime] [datetime] NULL,           --创建事件
    [Version] [varchar](50) NULL,           --版本
 CONSTRAINT [PK__Menu__2B3F6F97] PRIMARY KEY CLUSTERED 
(
	[Menu_Id] ASC
)WITH FILLFACTOR = 90 ON [PRIMARY]
) ON [PRIMARY]


/****
--测试数据
TRUNCATE TABLE [SysFunction]
INSERT INTO [SysFunction](SysFunction_Id,Name,EnglishName,Iconic,Sort,Remark,State,CreatePerson,CreateTime,Version)
      SELECT 'MyJob','我的工作','MyJob','ioc-menu-myjob',10,'管理我的工作',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'FAccount','财务会计','FAccount','ioc-menu-faccount',20,'管理财务会计',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MAccount','管理会计','MAccount','ioc-menu-maccount',30,'管理管理会计',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'SupplyChain','供应链','SupplyChain','ioc-menu-supplychain',40,'管理供应链',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'Production','生产管理','Production','ioc-menu-production',50,'管理生产',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'OA','公文管理','OA','ioc-menu-oa',60,'管理公文',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'Costing','成本管理','Costing','ioc-menu-costing',70,'管理成本',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'System','系统设置','System','ioc-menu-setting',80,'管理系统设置',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'Reports','报表','Reports','ioc-menu-report',90,'查看报表',1,'ADMIN',GETDATE(),'0001'

TRUNCATE TABLE [MenuGroup]
INSERT INTO [MenuGroup](MenuGroup_Id,SysFunction_Id,Name,EnglishName,Iconic,Sort,Remark,State,CreatePerson,CreateTime,Version)
      SELECT '00','Costing','初始化数据','','',10,'初始化数据',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '01','Costing','存货核算','','',20,'存货核算',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '02','Costing','实际成本','','',30,'实际成本',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '03','Costing','成本分析','','',40,'成本分析',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '04','Costing','作业成本管理','','',50,'作业成本管理',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '05','MyJob','我的工作','','ioc-menu-myjob',10,'我的工作',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '06','MyJob','我的邮件','','ioc-menu-email',20,'我的邮件',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '07','MyJob','我的审核','','ioc-menu-approve',30,'我的审核',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '08','MyJob','我的办公室','','',40,'我的办公室',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '09','SupplyChain','采购管理','','',10,'采购管理',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '10','SupplyChain','销售管理','','',20,'销售管理',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '11','SupplyChain','客户管理','','',30,'客户管理',1,'ADMIN',GETDATE(),'0001'
UNION SELECT '12','SupplyChain','委外加工管理','','',40,'委外加工管理',1,'ADMIN',GETDATE(),'0001'

TRUNCATE TABLE [Menu]
INSERT INTO [Menu]([Menu_Id],MenuGroup_Id,[ModelId],Name,EnglishName,Url,Iconic,Sort,Remark,State,CreatePerson,CreateTime,Version)
      SELECT 'ItemsCost','02','ItemsCost','物料标准成本','','Costing/ItemsCost','ioc-menu-document',10,'物料标准成本',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'BOMCosting','02','BOMCosting','BOM成本','','Costing/BOMCost','ioc-menu-document',20,'BOM成本',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'BOMSchemeCost','02','BOMSchemeCost','BOM方案成本','ioc-menu-document','Costing/BOMSchemeCost','',20,'BOM方案成本',1,'ADMIN',GETDATE(),'0001'

UNION SELECT 'CostSubcontractAdjust','01','CostSubcontractAdjust','委外加工金额调整','','Costing/CostSubcontractAdjust','',10,'委外加工金额调整',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'CostBackFlushAdjust','01','CostBackFlushAdjust','倒冲物料调整','','Costing/CostBackFlushAdjust','',20,'倒冲物料调整',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'CostMaterialAdjust','01','CostMaterialAdjust','物料金额调整','','Costing/CostMaterialAdjust','',30,'物料金额调整',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MaterialStatement','01','MaterialStatement','原材料明细账','','Costing/MaterialStatement','',40,'原材料明细账',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MaterialStatementByType','01','MaterialStatementByType','原材料明细账(类别)','','Costing/MaterialStatementByType','',50,'原材料明细账(类别)',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'FixedAssetsStatement','01','MaterialStatementByType','固定资产明细账','','Costing/FixedAssetsStatement','',60,'固定资产明细账',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'ProductStatement','01','ProductStatement','成品明细帐(品种法)','','Costing/ProductStatement','',70,'成品明细帐(品种法)',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'ProductStatement2','01','ProductStatement2','成品明细帐(批次法)','','Costing/ProductStatement2','',80,'成品明细帐(批次法)',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'PurchaseCollection','01','PurchaseCollection','供应商购入汇总表','','Costing/PurchaseCollection','',90,'供应商购入汇总表',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MaterialOutCollection','01','MaterialOutCollection','原材料领用汇总表','','Costing/MaterialOutCollection','',100,'原材料领用汇总表',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'ProductSalesCollection','01','ProductSalesCollection','成品销售汇总表(品种法)','','Costing/ProductSalesCollection','',110,'成品销售汇总表',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'ProductSalesCollection2','01','ProductSalesCollection2','成品销售汇总表(批次法)','','Costing/ProductSalesCollection2','',120,'成品销售汇总表',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'ProductOutCollection','01','ProductOutCollection','成品领用汇总表(品种法)','','Costing/ProductOutCollection','',130,'成品领用汇总表',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'ProductOutCollection2','01','ProductOutCollection2','成品领用汇总表(批次法)','','Costing/ProductOutCollection2','',140,'成品领用汇总表',1,'ADMIN',GETDATE(),'0001'

UNION SELECT 'InitMatCost','00','InitMatCost','原材料初始化','','Costing/InitMatCost','',10,'原材料初始化',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'InitFixedAssetsCost','00','InitFixedAssetsCost','固定资产初始化','','Costing/InitFixedAssetsCost','',20,'固定资产初始化',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'InitWipCost','00','InitWipCost','在制品初始化(品种法)','','Costing/InitWipCost','',30,'在制品初始化(品种法)',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'InitWipCost2','00','InitWipCost2','在制品初始化(批次法)','','Costing/InitWipCost2','',40,'在制品初始化(批次法)',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'InitSubcontractCost','00','InitSubcontractCost','委外物料初始化(品种法)','','Costing/InitSubcontractCost','',50,'委外物料初始化(品种法)',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'InitSubcontractCost2','00','InitSubcontractCost2','委外物料初始化(批次法)','','Costing/InitSubcontractCost2','',60,'委外物料初始化(批次法)',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'InitProductCost','00','InitProductCost','成品初始化(品种法)','','Costing/InitProductCost','',70,'成品初始化(品种法)',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'InitProductCost2','00','InitProductCost2','成品初始化(批次法)','','Costing/InitProductCost2','',80,'成品初始化(批次法)',1,'ADMIN',GETDATE(),'0001'

UNION SELECT 'MyJob','05','MyJob','设置我的工作','','Setting/MyJob','ioc-menu-setting',10,'设置我的工作',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MailList','06','MailList','收件箱','','Notes/ShowFolder','ioc-menu-email',20,'收件箱',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'SendMail','06','SendMail','写新邮件','','Notes/Send','ioc-menu-email_edit',30,'写新邮件',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MyApproveRequest','07','MyApproveRequest','我的审核申请','','Workflow/MyApproveRequest','',40,'我的审核申请',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MyApproved','07','MyApproved','我的批阅','','Workflow/MyApproved','',50,'我的批阅',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MyRequestDocument','07','MyRequestDocument','我的申请单据','','Workflow/MyRequestDocument','',60,'我的申请单据',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'MyAgent','07','MyAgent','我的代理人','','Workflow/MyAgent','',70,'我的代理人',1,'ADMIN',GETDATE(),'0001'

UNION SELECT 'PurchaseRequest','09','PurchaseRequest','采购申请单','','PurchaseRequest/Index','ioc-menu-document',10,'采购申请单',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'PurchaseInquirySheet','09','PurchaseInquirySheet','采购询价单','','PurchaseInquirySheet/Index','ioc-menu-document',20,'采购询价单',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'PurchaseOrder','09','PurchaseOrder','采购订单','','PurchaseOrder/Index','ioc-menu-document',30,'采购订单',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'PurchaseGRN','09','PurchaseGRN','采购收货单','','PurchaseGRN/Index','ioc-menu-document',40,'采购收货单',1,'ADMIN',GETDATE(),'0001'
UNION SELECT 'PurchaseReturn','09','PurchaseReturn','采购退货单','','PurchaseReturn/Index','ioc-menu-document',50,'采购退货单',1,'ADMIN',GETDATE(),'0001'

SELECT * FROM [SysFunction]
SELECT * FROM [MenuGroup]
SELECT * FROM [Menu]
****/