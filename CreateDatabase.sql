create database [PatientCards];
go

use [PatientCards];

create table [Users] (
	[Username] nvarchar(100) not null primary key,
	[Password] nvarchar(100) not null,
	[FirstName] nvarchar(100),
	[MiddleName] nvarchar(100),
	[LastName] nvarchar(100),
	[Email] nvarchar(100),
	[Job] nvarchar(100),
	[Created] datetime not null default GETDATE(),
	[Active] bit not null default 0,
	[Address] nvarchar(400),
	[Phone] nvarchar(100)
);

create table [FirstSurveys] (
	[PatientId] int not null primary key,
	[Reason] nvarchar(400),
	[Face] nvarchar(400),
	[Skin] nvarchar(400),
	[Limbs] nvarchar(400),
	[Bones] nvarchar(400)
);

create table [FirstSurveyOptions] (
	[Id] int identity(1,1) not null primary key,
	[Name] nvarchar(400) not null unique
);

create table [FirstSurveyDetails] (
	[PatientId] int not null,
	[SurveyOptionId] int not null,
	[YesNo] bit not null default 0,
	[Detail] nvarchar(400),
	constraint pk_FirstSurveyDetails primary key ([PatientId], [SurveyOptionId])
);

create table [Jobs] (
	[Name] nvarchar(100) not null primary key,
	[Description] nvarchar(400)
);

create table [Patients] (
	[Id] int identity(1,1) not null primary key,
	[FirstName] nvarchar(100) not null,
	[MiddleName] nvarchar(100) not null,
	[LastName] nvarchar(100) not null,
	[BirthDate] datetime,
	[Gender] nvarchar(20),
	[Address] nvarchar(400),
	[Phone] nvarchar(100),
	[SocialStatus] nvarchar(400),
	[Job] nvarchar(100),
	[Created] datetime not null default GETDATE()
);

create table [Surveys] (
	[Id] int identity(1,1) not null primary key,
	[PatientId] int not null,
	[Username] nvarchar(100) not null,
	[TypeId] int null,
	[Description] nvarchar(400) null,
	[Created] datetime not null default GETDATE(),
	[Dose] int null
);

create table [SurveyTypes] (
	[Id] int identity(1,1) not null primary key,
	[Name] nvarchar(400) not null unique
);

create table [ThreatmentOptions] (
	[Id] int identity(1,1) not null primary key,
	[Name] nvarchar(400) not null,
	[GroupNumber] int not null,
	[OrderNumber] int null,
	constraint uk_ThreatmentOptions unique ([Name], [GroupNumber])
);

create table [ThreatmentPlans] (
	[PatientId] int not null,
	[ThreatmentOptionId] int not null,
	[Description] nvarchar(400) null,
	[Username] nvarchar(100) not null,
	[Created] datetime not null default GETDATE(),
	constraint pk_ThreatmentPlans primary key ([PatientId], [ThreatmentOptionId])
);

create table [VisitDiary] (
	[Id] int identity(1,1) not null primary key,
	[PatientId] int not null,
	[Username] nvarchar(100) not null,
	[Description] nvarchar(400) null,
);

alter table [Users] 
add constraint fk_UsersJobs foreign key ([Job]) References [Jobs]( [Name] );

alter table [FirstSurveys]
add constraint fk_FirstSurveysPatiens foreign key ([PatientId]) references [Patients]( [Id] );

alter table [FirstSurveyDetails]
add constraint fk_FirstSurveyDetailsOptions foreign key ([SurveyOptionId]) references [FirstSurveyOptions] ( [Id] );

alter table [FirstSurveyDetails]
add constraint fk_FirstSurveyDetailsPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [Surveys]
add constraint fk_SurveysPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [Surveys]
add constraint fk_SurveysUsers foreign key ([Username]) references [Users] ( [Username] );

alter table [Surveys]
add constraint fk_SurveysTypes foreign key ([TypeId]) references [SurveyTypes] ( [Id] );

alter table [ThreatmentPlans]
add constraint fk_ThreatmentPlansPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [ThreatmentPlans]
add constraint fk_ThreatmentPlansUsers foreign key ([Username]) references [Users] ( [Username] );

alter table [ThreatmentPlans]
add constraint fk_ThreatmentPlansOption foreign key ([ThreatmentOptionId]) references [ThreatmentOptions] ( [Id] );

alter table [VisitDiary]
add constraint fk_VisitDiaryPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [VisitDiary]
add constraint fk_VisitDiaryPlansUsers foreign key ([Username]) references [Users] ( [Username] );


insert into [FirstSurveyOptions] ( [Name] ) values ( N'Заболевания сердечно-сосудистой системы' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Заболевания нервной системы' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Заболевания эндокринной системы' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Заболевания органов пищеварения' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Заболевания органов дыхания' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Инфекционные заболевания (вирусный гепатит, туберкулез, ВИЧ-инфекции, СПИД и т.д.)' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Аллергические реакции' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Постоянное применение лекарственных средств' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Вредные факторы производственной среды' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Беременность, послеродовый период' );
insert into [FirstSurveyOptions] ( [Name] ) values ( N'Другое' );


insert into [Jobs] ( [Name] ) values ( N'Администратор' );
insert into [Jobs] ( [Name] ) values ( N'Программист' );
insert into [Jobs] ( [Name] ) values ( N'Доктор' );
insert into [Jobs] ( [Name] ) values ( N'Зав. отделением' );
insert into [Jobs] ( [Name] ) values ( N'Медсестра' );

insert into [SurveyTypes] ( [Name] ) values ( N'Разное' );
insert into [SurveyTypes] ( [Name] ) values ( N'Рентген' );

insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Оказание неотложной помощи', 1, 0 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Профилактические мероприятия (указать)', 2, 0 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'мотивация по факторам риска стоматологических заболеваний, обучение гигиене', 2, 1 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'профессиональная гигиена', 2, 2 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'другие', 2, 3 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Терапевтическое лечение (указать)', 3, 0 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'замена пломб', 3, 1 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'лечение кариеса и некариозных поражений', 3, 2 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'эндодонтическое лечение', 3, 3 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'периодонтологическое лечение', 3, 4 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'лечение заболеваний слизистой оболочки рта', 3, 5 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'другое', 3, 6 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Хирургическое лечение (указать)', 4, 0 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'удаление зубов, корней', 4, 1 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'амбулаторно-хирургические операции', 4, 2 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'      на мягких тканях', 4, 3 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'      на костях лицевого скелета', 4, 4 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Другое', 4, 5 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Ортопедическое лечение (указать)', 5, 0 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Ортодонтическое лечение (указать)', 6, 0 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Дополнительные диагностические мероприятия (указать)', 7, 0 );
insert into [ThreatmentOptions] ( [Name], [Group], [Order] ) values ( N'Консультация других специалистов (указать)', 8, 0 );

insert into [Users] ( [Username], [Password] ) values ( N'admin', N'admin' );
insert into [Users] ( [Username], [Password] ) values ( N'test', N'test' );