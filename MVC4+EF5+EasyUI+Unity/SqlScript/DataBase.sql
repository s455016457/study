USE master

IF EXISTS(SELECT 1 FROM SYSDATABASES WHERE NAME='DBStudy')
    DROP DATABASE DBStudy
GO

CREATE DATABASE DBStudy
ON PRIMARY  -- 默认就属于primary文件组,可省略
(
/*--数据文件的具体描述--*/
    NAME='DBStudy_data',  -- 主数据文件的逻辑名称
    FILENAME='E:\shipengfei\Data\DBStudy_data.mdf', -- 主数据文件的物理名称
    SIZE=5mb, --主数据文件的初始大小
    MAXSIZE=100mb, -- 主数据文件增长的最大值
    FILEGROWTH=15%--主数据文件的增长率
)
LOG ON
(
/*--日志文件的具体描述,各参数含义同上--*/
    NAME='DBStudy_log',
    FILENAME='E:\shipengfei\Data\DBStudy_log.ldf',
    SIZE=2mb,
    FILEGROWTH=1mb
)

GO

USE DBStudy
GO

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE ID=OBJECT_ID(N'[SysSample]') AND XTYPE='TT')
DROP TABLE [SysSample]
GO

CREATE TABLE [dbo].[SysSample](
    [Id] [varchar](50) NOT NULL,
    [Name] [varchar](50) NULL,
    [Age] [int] NULL,
    [Bir] [datetime] NULL,
    [Photo] [varchar](50) NULL,
    [Note] [text] NULL,
    [CreateTime] [datetime] NULL,
    CONSTRAINT [PK__SysSample] PRIMARY KEY CLUSTERED([Id])
)

GO

/****
--测试数据
TRUNCATE TABLE [SysSample]
INSERT INTO [SysSample](ID,NAME,AGE,BIR,PHOTO,NOTE,CREATETIME)
      SELECT 'zhansan','张三',20,'1987-04-29','83766298','绰号战三狼',GETDATE()
UNION SELECT 'lisi','李四',22,'1985-05-12','83766987','绰号死得快',GETDATE()
UNION SELECT 'wangwu','王五',22,'1985-11-21','45767987','绰号飞毛腿',GETDATE()
****/
SELECT * FROM [SysSample]

