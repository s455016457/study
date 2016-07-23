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

IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE ID=OBJECT_ID(N'[SysSample]') AND XTYPE='U')
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
UNION SELECT 'diaosi01','屌丝01',21,'1985-05-01','83766901','绰号死得快01',GETDATE()
UNION SELECT 'diaosi02','屌丝01',22,'1985-11-02','45767902','绰号飞毛腿02',GETDATE()
UNION SELECT 'diaosi03','屌丝03',21,'1985-05-03','83766901','绰号死得快03',GETDATE()
UNION SELECT 'diaosi04','屌丝04',22,'1985-11-04','45767902','绰号飞毛腿04',GETDATE()
UNION SELECT 'diaosi05','屌丝05',23,'1985-11-05','45767903','绰号飞毛腿05',GETDATE()
UNION SELECT 'diaosi06','屌丝06',24,'1985-11-06','45767904','绰号飞毛腿06',GETDATE()
UNION SELECT 'diaosi07','屌丝07',25,'1985-11-07','45767905','绰号飞毛腿07',GETDATE()
UNION SELECT 'diaosi08','屌丝08',26,'1985-11-08','45767906','绰号飞毛腿08',GETDATE()
UNION SELECT 'diaosi09','屌丝09',27,'1985-11-09','45767907','绰号飞毛腿09',GETDATE()
UNION SELECT 'diaosi10','屌丝10',28,'1985-11-10','45767908','绰号飞毛腿10',GETDATE()
UNION SELECT 'diaosi11','屌丝11',29,'1985-11-11','45767909','绰号飞毛腿11',GETDATE()
UNION SELECT 'diaosi12','屌丝12',30,'1985-11-12','457679012','绰号飞毛腿12',GETDATE()
UNION SELECT 'diaosi13','屌丝13',30,'1985-11-13','457679013','绰号飞毛腿13',GETDATE()
UNION SELECT 'diaosi14','屌丝14',30,'1985-11-14','457679014','绰号飞毛腿14',GETDATE()
UNION SELECT 'diaosi15','屌丝15',30,'1985-11-15','457679015','绰号飞毛腿15',GETDATE()
UNION SELECT 'diaosi16','屌丝16',30,'1985-11-16','457679016','绰号飞毛腿16',GETDATE()
UNION SELECT 'diaosi17','屌丝17',30,'1985-11-17','457679017','绰号飞毛腿17',GETDATE()
UNION SELECT 'diaosi18','屌丝18',30,'1985-11-18','457679018','绰号飞毛腿18',GETDATE()
UNION SELECT 'diaosi19','屌丝19',30,'1985-11-19','457679019','绰号飞毛腿19',GETDATE()
UNION SELECT 'diaosi20','屌丝20',30,'1985-11-20','457679020','绰号飞毛腿20',GETDATE()
****/
SELECT * FROM [SysSample]

