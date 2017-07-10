/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     7/10/2017 2:13:20 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Log') and o.name = 'FK_LOG_REFERENCE_LEVEL')
alter table Log
   drop constraint FK_LOG_REFERENCE_LEVEL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Level')
            and   type = 'U')
   drop table Level
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Log')
            and   type = 'U')
   drop table Log
go

/*==============================================================*/
/* Table: Level                                                 */
/*==============================================================*/
create table Level (
   Id                   int                  identity,
   Name                 nvarchar(50)         null,
   constraint PK_LEVEL primary key (Id)
)
go

/*==============================================================*/
/* Table: Log                                                   */
/*==============================================================*/
create table Log (
   Id                   int                  identity,
   LevelId              int                  not null,
   Date                 datetime             null,
   Thread               nvarchar(10)         not null,
   Location             nvarchar(500)        not null,
   Message              nvarchar(2000)       not null,
   CreateTime           datetimeoffset       not null default SYSDATETIMEOFFSET(),
   constraint PK_LOG primary key (Id)
)
go

alter table Log
   add constraint FK_LOG_REFERENCE_LEVEL foreign key (LevelId)
      references Level (Id)
go


INSERT INTO Level (Name) Values ('INFO')
INSERT INTO Level (Name) Values ('WARN')
INSERT INTO Level (Name) Values ('ERROR')