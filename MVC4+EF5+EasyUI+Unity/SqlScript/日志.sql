
/****** Object:  Table [dbo].[SysFunction]    Script Date: 2015-11-26 15:10:12 ******/
IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE ID=OBJECT_ID(N'[SysLog]') AND XTYPE='U')
DROP TABLE [SysLog]
GO

CREATE TABLE [dbo].[SysLog](
    [Id]            [varchar](50) NOT NULL,     --GUID
    [Operator]      [varchar](50) NULL,         --操作人
    [Message]       [varchar](500) NULL,        --操作信息
    [Result]        [varchar](20) NULL,         --结果
    [Type]          [varchar](20) NULL,         --操作类型
    [Module]        [varchar](20) NULL,         --操作模块
    [CreateTime]    [datetime] NULL,            --操作事件
 CONSTRAINT [PK_SysLog] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****
--测试数据
TRUNCATE TABLE [SysLog]
****/