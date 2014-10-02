-- Drop data base command --
drop database [PatientCards];
go 

-- create and use database --
create database [PatientCards];
go

use [PatientCards];

-- tables --

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
	[Birthday] datetime,
	[Gender] nvarchar(20),
	[Address] nvarchar(400) not null,
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

create table [TreatmentOptions] (
	[Id] int identity(1,1) not null primary key,
	[Name] nvarchar(400) not null,
	[GroupNumber] int not null,
	[OrderNumber] int null,
	constraint uk_TreatmentOptions unique ([Name], [GroupNumber])
);

create table [TreatmentPlans] (
	[PatientId] int not null,
	[TreatmentOptionId] int not null,
	[Description] nvarchar(400) null,
	[Username] nvarchar(100) not null,
	[Created] datetime not null default GETDATE(),
	constraint pk_TreatmentPlans primary key ([PatientId], [TreatmentOptionId])
);

create table [Visits] (
	[Id] int identity(1,1) not null primary key,
	[PatientId] int not null,
	[Username] nvarchar(100) not null,
	[Description] nvarchar(400) null,
	[Created] datetime not null default GETDATE()
);

create table [DentistStatuses] (
	[Id] int identity(1,1) not null primary key,
	[PatientId] int not null,
	[Username] nvarchar(100) not null,
	[Created] datetime not null default GETDATE(),
	[Bite] nvarchar(400) null,
	[HardTissue] nvarchar(400) null,
	[Mucous] nvarchar(400) null,
	[XrayDiagnostics] nvarchar(400) null,
	[PreliminaryDiagnosis] nvarchar(400) null
);

create table [OhisStatuses] (
	[Id] int identity(1,1) not null primary key,
	[PatientId] int not null,
	[Username] nvarchar(100) not null,
	[Created] datetime not null default GETDATE(),
	[Cis1] int null,
	[Cis2] int null,
	[Cis3] int null,
	[Cis4] int null,
	[Cis5] int null,
	[Cis6] int null,
	[Dis1] int null,
	[Dis2] int null,
	[Dis3] int null,
	[Dis4] int null,
	[Dis5] int null,
	[Dis6] int null,
	[Ohis] float null
);

create table [DfmStatuses] (
	[Id] int identity(1,1) not null primary key,
	[PatientId] int not null,
	[Username] nvarchar(100) not null,
	[Created] datetime not null default GETDATE(),
	[UpperLeft1] nvarchar null,
	[UpperLeft2] nvarchar null,
	[UpperLeft3] nvarchar null,
	[UpperLeft4] nvarchar null,
	[UpperLeft5] nvarchar null,
	[UpperLeft6] nvarchar null,
	[UpperLeft7] nvarchar null,
	[UpperLeft8] nvarchar null,
	[UpperRight1] nvarchar null,
	[UpperRight2] nvarchar null,
	[UpperRight3] nvarchar null,
	[UpperRight4] nvarchar null,
	[UpperRight5] nvarchar null,
	[UpperRight6] nvarchar null,
	[UpperRight7] nvarchar null,
	[UpperRight8] nvarchar null,
	[LowerLeft1] nvarchar null,
	[LowerLeft2] nvarchar null,
	[LowerLeft3] nvarchar null,
	[LowerLeft4] nvarchar null,
	[LowerLeft5] nvarchar null,
	[LowerLeft6] nvarchar null,
	[LowerLeft7] nvarchar null,
	[LowerLeft8] nvarchar null,
	[LowerRight1] nvarchar null,
	[LowerRight2] nvarchar null,
	[LowerRight3] nvarchar null,
	[LowerRight4] nvarchar null,
	[LowerRight5] nvarchar null,
	[LowerRight6] nvarchar null,
	[LowerRight7] nvarchar null,
	[LowerRight8] nvarchar null,
	[Dfm] float null
);

create table [CpiStatuses] (
	[Id] int identity(1,1) not null primary key,
	[PatientId] int not null,
	[Username] nvarchar(100) not null,
	[Created] datetime not null default GETDATE(),
	[Value1] int null,
	[Value2] int null,
	[Value3] int null,
	[Value4] int null,
	[Value5] int null,
	[Value6] int null,
	[Cpi] float null
);


-- foreign keys --

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

alter table [TreatmentPlans]
add constraint fk_TreatmentPlansPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [TreatmentPlans]
add constraint fk_TreatmentPlansUsers foreign key ([Username]) references [Users] ( [Username] );

alter table [TreatmentPlans]
add constraint fk_TreatmentPlansOption foreign key ([TreatmentOptionId]) references [TreatmentOptions] ( [Id] );

alter table [Visits]
add constraint fk_VisitsPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [Visits]
add constraint fk_VisitsPlansUsers foreign key ([Username]) references [Users] ( [Username] );

alter table [DentistStatuses]
add constraint fk_DentistStatusesPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [DentistStatuses]
add constraint fk_DentistStatusesPlansUsers foreign key ([Username]) references [Users] ( [Username] );

alter table [OhisStatuses]
add constraint fk_OhisStatusesPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [OhisStatuses]
add constraint fk_OhisStatusesPlansUsers foreign key ([Username]) references [Users] ( [Username] );

alter table [DfmStatuses]
add constraint fk_DfmStatusesPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [DfmStatuses]
add constraint fk_DfmStatusesPlansUsers foreign key ([Username]) references [Users] ( [Username] );

alter table [CpiStatuses]
add constraint fk_CpiStatusesPatients foreign key ([PatientId]) references [Patients] ( [Id] );

alter table [CpiStatuses]
add constraint fk_CpiStatusesPlansUsers foreign key ([Username]) references [Users] ( [Username] );

-- default and test DB fill --
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


insert into [Jobs] ( [Name] ) values ( N'Administrator' );
insert into [Jobs] ( [Name] ) values ( N'Doctor' );
insert into [Jobs] ( [Name] ) values ( N'Nurse' );

insert into [SurveyTypes] ( [Name] ) values ( N'Разное' );
insert into [SurveyTypes] ( [Name] ) values ( N'Рентген' );

insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Оказание неотложной помощи', 1, 0 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Профилактические мероприятия (указать)', 2, 0 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'мотивация по факторам риска стоматологических заболеваний, обучение гигиене', 2, 1 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'профессиональная гигиена', 2, 2 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'другие', 2, 3 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Терапевтическое лечение (указать)', 3, 0 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'замена пломб', 3, 1 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'лечение кариеса и некариозных поражений', 3, 2 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'эндодонтическое лечение', 3, 3 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'периодонтологическое лечение', 3, 4 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'лечение заболеваний слизистой оболочки рта', 3, 5 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'другое', 3, 6 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Хирургическое лечение (указать)', 4, 0 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'удаление зубов, корней', 4, 1 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'амбулаторно-хирургические операции', 4, 2 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'      на мягких тканях', 4, 3 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'      на костях лицевого скелета', 4, 4 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Другое', 4, 5 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Ортопедическое лечение (указать)', 5, 0 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Ортодонтическое лечение (указать)', 6, 0 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Дополнительные диагностические мероприятия (указать)', 7, 0 );
insert into [TreatmentOptions] ( [Name], [GroupNumber], [OrderNumber] ) values ( N'Консультация других специалистов (указать)', 8, 0 );


insert into [Users] ( [Username], [Password], [LastName], [Job] ) values ( N'admin', N'admin', N'Администратор', N'Administrator' );
insert into [Users] ( [Username], [Password], [LastName], [Job] ) values ( N'nurse_test', N'test', N'Мед.Сестра (Тест)', N'Nurse' );
insert into [Users] ( [Username], [Password], [LastName], [Job] ) values ( N'doctor_test', N'test', N'Доктор (Тест)', N'Doctor' );

insert into [Patients] ( [FirstName], [MiddleName], [LastName], [Birthday], [Gender], [Address] ) values ( N'Иван', N'Михайлович', N'Пупкин', CONVERT(datetime, N'8/9/1960'), N'Male', N'Минск' );
insert into [Patients] ( [FirstName], [MiddleName], [LastName], [Birthday], [Gender], [Address] ) values ( N'Сергей', N'Иванович', N'Пупкин', CONVERT(datetime, N'12/11/1960'), N'Male', N'Минск' );
insert into [Patients] ( [FirstName], [MiddleName], [LastName], [Birthday], [Gender], [Address] ) values ( N'Николай', N'Николаевич', N'Петров', CONVERT(datetime, N'2/3/1960'), N'Male', N'Минск' );
insert into [Patients] ( [FirstName], [MiddleName], [LastName], [Birthday], [Gender], [Address] ) values ( N'Анна', N'Ивановна', N'Сидорова', CONVERT(datetime, N'3/5/1960'), N'Female', N'Смолевичи' );
insert into [Patients] ( [FirstName], [MiddleName], [LastName], [Birthday], [Gender], [Address] ) values ( N'Миша', N'Петрович', N'Сидоров', CONVERT(datetime, N'2/7/1960'), N'Male', N'Смолевичи' );
insert into [Patients] ( [FirstName], [MiddleName], [LastName], [Birthday], [Gender], [Address] ) values ( N'Иван', N'Иванович', N'Петров', CONVERT(datetime, N'1/1/1960'), N'Male', N'Боровляны' );
