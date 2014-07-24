create table Users
(
	[Username] nvarchar(100) not null primary key,
	[Password] nvarchar(100) not null,
	[LastName]	nvarchar(40) not null,
	[FirstName] nvarchar(40) not null,
	[MiddleName]	nvarchar(40) not null,
	[BirthDate] datetime not null,
	[Gender] nvarchar(1) not null default 'M'
);

create table PatientCards 
(
	[CardId] int not null primary key IDENTITY(1,1),
	[LastName]	nvarchar(40) not null,
	[FirstName] nvarchar(40) not null,
	[MiddleName]	nvarchar(40) not null,
	[BirthDate] datetime not null,
	[Gender] nvarchar(1) not null default 'M',
	[Address] nvarchar(400),
	[Phone] nvarchar(20),
	[SocialStatus] nvarchar(400),
	[Work] nvarchar(400),
	[Created] datetime not null default GETDATE()
);

create table Diagnostics
(
	[DiagnosticId] int not null primary key IDENTITY(1,1),
	[CardId] int not null,
	[Created] datetime not null default GETDATE(),
	constraint fk_DiagnosticPatientCard foreign key ([CardId]) references PatientCards([CardId])
);

create table Researchs
(
	[ResearchId] int not null primary key IDENTITY(1,1),
	[CardId] int not null,
	[Created] datetime not null default GETDATE(),
	constraint fk_ResearchPatientCard foreign key ([CardId]) references PatientCards([CardId])
);


create table CurePlans
(
	[PlanId] int not null primary key IDENTITY(1,1),
	[CardId] int not null,
	[Created] datetime not null default GETDATE(),
	constraint fk_PlanPatientCard foreign key ([CardId]) references PatientCards([CardId])
);