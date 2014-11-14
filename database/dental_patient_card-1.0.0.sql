-- Drop data base command --
drop database dental_patient_card;

-- create and use database --
create database dental_patient_card DEFAULT charset utf8;


use dental_patient_card;

-- tables --
SELECT 'USERS' as '';

CREATE TABLE users (
	username 		NVARCHAR(100) NOT NULL,
	password 		NVARCHAR(100) NOT NULL,
	first_name 		NVARCHAR(100) NULL,
	middle_name 	NVARCHAR(100) NULL,
	last_name 		NVARCHAR(100) NULL,
	email 			NVARCHAR(100) NULL,
	role 			NVARCHAR(100) NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	active 			BIT NOT NULL DEFAULT 0,
	address 		NVARCHAR(400),
	phone 			NVARCHAR(100),
	CONSTRAINT pk_users PRIMARY KEY (username)
);

SELECT 'ROLES' as '';

CREATE TABLE roles (
	name 			NVARCHAR(100) NOT NULL,
	description 	NVARCHAR(400) NULL,
	CONSTRAINT pk_jobs PRIMARY KEY (name)
);

SELECT 'FIRST SURVEYS' as '';

CREATE TABLE first_surveys (
	patient_id 		INT NOT NULL,
	reason 			NVARCHAR(400) NULL,
	face 			NVARCHAR(400) NULL,
	skin 			NVARCHAR(400) NULL,
	limbs 			NVARCHAR(400) NULL,
	bones 			NVARCHAR(400) NULL,
	CONSTRAINT pk_first_surveys PRIMARY KEY (patient_id)
);

SELECT 'FIRST SURVEY OPTIONS' as '';

CREATE TABLE first_survey_options (
	id 				INT NOT NULL AUTO_INCREMENT,
	name 			NVARCHAR(200) NOT NULL,
	CONSTRAINT pk_first_survey_options PRIMARY KEY (id),
	CONSTRAINT uc_first_survey_options UNIQUE (name)
);

SELECT 'FIRST_SURVEY_DETAILS' as '';

CREATE TABLE first_survey_details (
	patient_id 		INT NOT NULL,
	option_id 		INT NOT NULL,
	yes_no 			BIT NOT NULL DEFAULT 0,
	details			NVARCHAR(400),
	CONSTRAINT pk_first_survey_details PRIMARY KEY (patient_id, option_id)
);

SELECT 'PATIENTS' as '';

CREATE TABLE patients (
	id 				INT NOT NULL AUTO_INCREMENT,
	first_name 		NVARCHAR(100) NOT NULL,
	middle_name 	NVARCHAR(100) NOT NULL,
	last_name 		NVARCHAR(100) NOT NULL,
	birth_date 		DATETIME NOT NULL,
	gender 			NVARCHAR(20) NOT NULL,
	address 		NVARCHAR(400) NOT NULL,
	phone 			NVARCHAR(400) NULL,
	social_status 	NVARCHAR(400) NULL,
	job 			NVARCHAR(400) NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	CONSTRAINT pk_patients PRIMARY KEY (id)
);

SELECT 'SURVEYS' as '';

CREATE TABLE surveys (
	id 				INT NOT NULL AUTO_INCREMENT,
	patient_id 		INT NOT NULL,
	type_id			INT NULL,
	description 	NVARCHAR(1000) NULL,
	xray_dose 		FLOAT NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated 		TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	created_by		NVARCHAR(100) NOT NULL,
	updated_by		NVARCHAR(100) NULL,
	CONSTRAINT pk_surveys PRIMARY KEY (id)
);

SELECT 'SURVEY TYPES' as '';

CREATE TABLE survey_types (
	id 				INT NOT NULL AUTO_INCREMENT,
	name 			NVARCHAR(200) NOT NULL,
	CONSTRAINT pk_survey_types PRIMARY KEY (id),
	CONSTRAINT uc_survey_types UNIQUE (name)
);

SELECT 'TREATMENT OPTIONS' as '';

CREATE TABLE treatment_options (
	id 				INT NOT NULL AUTO_INCREMENT,
	name 			NVARCHAR(200) NOT NULL,
	is_fillable		BIT NOT NULL DEFAULT 1,
	group_number 	INT NOT NULL,
	order_number 	INT NULL,
	CONSTRAINT pk_treatment_options PRIMARY KEY (id),
	CONSTRAINT uc_treatment_options UNIQUE (name, group_number)
);

SELECT 'TREATMENT PLANS' as '';

CREATE TABLE treatment_plans (
	patient_id 		INT NOT NULL,
	option_id 		INT NOT NULL,
	description 	NVARCHAR(400) NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated 		TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	created_by		NVARCHAR(100) NOT NULL,
	updated_by		NVARCHAR(100) NULL,
	CONSTRAINT pk_treatment_plans PRIMARY KEY (patient_id, option_id)
);

SELECT 'VISITS' as '';

CREATE TABLE visits (
	id 				INT NOT NULL AUTO_INCREMENT,
	patient_id 		INT NOT NULL,
	description 	NVARCHAR(4000) NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated 		TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	created_by		NVARCHAR(100) NOT NULL,
	updated_by		NVARCHAR(100) NULL,
	CONSTRAINT pk_visits PRIMARY KEY (id)
);

SELECT 'DENTIST STATUSES' as '';

CREATE TABLE dentist_statuses (
	id 				INT NOT NULL AUTO_INCREMENT,
	patient_id 		INT NOT NULL,
	bite 			NVARCHAR(1000) NULL,
	hard_tissue 	NVARCHAR(1000) NULL,
	mucous 			NVARCHAR(1000) NULL,
	xray_diagnostics 	NVARCHAR(1000) NULL,
	preliminary_diagnosis 	NVARCHAR(1000) NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated 		TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	created_by		NVARCHAR(100) NOT NULL,
	updated_by		NVARCHAR(100) NULL,
	CONSTRAINT pk_dentist_statuses PRIMARY KEY (id)
);

SELECT 'OHIS STATUSES' as '';

CREATE TABLE ohis_statuses (
	id 				INT NOT NULL AUTO_INCREMENT,
	patient_id 		INT NOT NULL,
	cis1 			TINYINT NULL,
	cis2 			TINYINT NULL,
	cis3 			TINYINT NULL,
	cis4 			TINYINT NULL,
	cis5 			TINYINT NULL,
	cis6 			TINYINT NULL,
	dis1 			TINYINT NULL,
	dis2 			TINYINT NULL,
	dis3			TINYINT NULL,
	dis4 			TINYINT NULL,
	dis5 			TINYINT NULL,
	dis6 			TINYINT NULL,
	ohis 			FLOAT NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated 		TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	created_by		NVARCHAR(100) NOT NULL,
	updated_by		NVARCHAR(100) NULL,
	CONSTRAINT pk_ohis_statuses PRIMARY KEY (id)
);

SELECT 'DFM STATUSES' as '';

CREATE TABLE dfm_statuses (
	id 				INT NOT NULL AUTO_INCREMENT,
	patient_id 		INT NOT NULL,
	upper_left1 	NCHAR NULL,
	upper_left2 	NCHAR NULL,
	upper_left3		NCHAR NULL,
	upper_left4 	NCHAR NULL,
	upper_left5 	NCHAR NULL,
	upper_left6 	NCHAR NULL,
	upper_left7 	NCHAR NULL,
	upper_left8 	NCHAR NULL,
	upper_right1 	NCHAR NULL,
	upper_right2 	NCHAR NULL,
	upper_right3 	NCHAR NULL,
	upper_right4 	NCHAR NULL,
	upper_right5 	NCHAR NULL,
	upper_right6 	NCHAR NULL,
	upper_right7 	NCHAR NULL,
	upper_right8 	NCHAR NULL,
	lower_left1 	NCHAR NULL,
	lower_left2 	NCHAR NULL,
	lower_left3 	NCHAR NULL,
	lower_left4 	NCHAR NULL,
	lower_left5 	NCHAR NULL,
	lower_left6 	NCHAR NULL,
	lower_left7 	NCHAR NULL,
	lower_left8 	NCHAR NULL,
	lower_right1 	NCHAR NULL,
	lower_right2 	NCHAR NULL,
	lower_right3 	NCHAR NULL,
	lower_right4 	NCHAR NULL,
	lower_right5 	NCHAR NULL,
	lower_right6 	NCHAR NULL,
	lower_right7 	NCHAR NULL,
	lower_right8 	NCHAR NULL,
	dfm 			FLOAT NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated 		TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	created_by		NVARCHAR(100) NOT NULL,
	updated_by		NVARCHAR(100) NULL,
	CONSTRAINT pk_dfm_statuses PRIMARY KEY (id)
);

SELECT 'CPI STATUSES' as '';

CREATE TABLE cpi_statuses (
	id 				INT NOT NULL AUTO_INCREMENT,
	patient_id 		INT NOT NULL,
	value1 			TINYINT NULL,
	value2 			TINYINT NULL,
	value3 			TINYINT NULL,
	value4 			TINYINT NULL,
	value5 			TINYINT NULL,
	value6 			TINYINT NULL,
	cpi 			FLOAT NULL,
	created 		TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated 		TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	created_by		NVARCHAR(100) NOT NULL,
	updated_by		NVARCHAR(100) NULL,
	CONSTRAINT pk_cpi_statuses PRIMARY KEY (id)
);


-- foreign keys --

SELECT 'FOREIGN KEYS' AS '';

ALTER TABLE users 	
	ADD CONSTRAINT fk_users_roles FOREIGN KEY (role) REFERENCES roles( name );

ALTER TABLE first_surveys 
	ADD CONSTRAINT fk_first_surveys_patiens FOREIGN KEY (patient_id) REFERENCES patients( id ) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE first_survey_details 
	ADD CONSTRAINT fk_first_survey_details_options 	FOREIGN KEY (option_id) REFERENCES first_survey_options ( id ),
	ADD CONSTRAINT fk_first_survey_details_patients FOREIGN KEY (patient_id) REFERENCES patients ( id ) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE surveys
	ADD CONSTRAINT fk_surveys_patients FOREIGN KEY (patient_id) REFERENCES patients ( id ) ON DELETE CASCADE ON UPDATE CASCADE,
	ADD CONSTRAINT fk_surveys_authors FOREIGN KEY (created_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_surveys_editors FOREIGN KEY (updated_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_surveys_types FOREIGN KEY (type_id) REFERENCES survey_types ( id );

ALTER TABLE treatment_plans
	ADD CONSTRAINT fk_treatment_plans_patients FOREIGN KEY (patient_id) REFERENCES patients ( id ) ON DELETE CASCADE ON UPDATE CASCADE,
	ADD CONSTRAINT fk_treatment_plans_authors FOREIGN KEY (created_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_treatment_plans_editors FOREIGN KEY (updated_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_treatment_plans_options FOREIGN KEY (option_id) REFERENCES treatment_options ( id );

ALTER TABLE visits
	ADD CONSTRAINT fk_visits_patients FOREIGN KEY (patient_id) REFERENCES patients ( id ) ON DELETE CASCADE ON UPDATE CASCADE,
	ADD CONSTRAINT fk_visits_authors FOREIGN KEY (created_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_visits_editors FOREIGN KEY (updated_by) REFERENCES users ( username );

ALTER TABLE dentist_statuses
	ADD CONSTRAINT fk_dentist_statuses_patients FOREIGN KEY (patient_id) REFERENCES patients ( id ) ON DELETE CASCADE ON UPDATE CASCADE,
	ADD CONSTRAINT fk_dentist_statuses_authors FOREIGN KEY (created_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_dentist_statuses_editors FOREIGN KEY (updated_by) REFERENCES users ( username );

ALTER TABLE ohis_statuses
	ADD CONSTRAINT fk_ohis_statuses_patients FOREIGN KEY (patient_id) REFERENCES patients ( id ) ON DELETE CASCADE ON UPDATE CASCADE,
	ADD CONSTRAINT fk_ohis_statuses_authors FOREIGN KEY (created_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_ohis_statuses_editors FOREIGN KEY (updated_by) REFERENCES users ( username );

ALTER TABLE dfm_statuses
	ADD CONSTRAINT fk_dfm_statuses_patients FOREIGN KEY (patient_id) REFERENCES patients ( id ) ON DELETE CASCADE ON UPDATE CASCADE,
	ADD CONSTRAINT fk_dfm_statuses_authors FOREIGN KEY (created_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_dfm_statuses_editors FOREIGN KEY (updated_by) REFERENCES users ( username );

ALTER TABLE cpi_statuses
	ADD CONSTRAINT fk_cpi_statuses_patients FOREIGN KEY (patient_id) REFERENCES patients ( id ) ON DELETE CASCADE ON UPDATE CASCADE,
	ADD CONSTRAINT fk_cpi_statuses_authors FOREIGN KEY (created_by) REFERENCES users ( username ),
	ADD CONSTRAINT fk_cpi_statuses_editors FOREIGN KEY (updated_by) REFERENCES users ( username );


-- DEFAULT and test DB fill --

SELECT 'DEFAULT VALUES' AS '';

insert INTO first_survey_options ( id, name ) values ( 1, N'Заболевания сердечно-сосудистой системы' );
insert INTO first_survey_options ( id, name ) values ( 2, N'Заболевания нервной системы' );
insert INTO first_survey_options ( id, name ) values ( 3, N'Заболевания эндокринной системы' );
insert INTO first_survey_options ( id, name ) values ( 4, N'Заболевания органов пищеварения' );
insert INTO first_survey_options ( id, name ) values ( 5, N'Заболевания органов дыхания' );
insert INTO first_survey_options ( id, name ) values ( 6, N'Инфекционные заболевания (вирусный гепатит, туберкулез, ВИЧ-инфекции, СПИД и т.д.)' );
insert INTO first_survey_options ( id, name ) values ( 7, N'Аллергические реакции' );
insert INTO first_survey_options ( id, name ) values ( 8, N'Постоянное применение лекарственных средств' );
insert INTO first_survey_options ( id, name ) values ( 9, N'Вредные факторы производственной среды' );
insert INTO first_survey_options ( id, name ) values ( 10, N'Беременность, послеродовый период' );
insert INTO first_survey_options ( id, name ) values ( 11, N'Другое' );


insert INTO roles ( name ) values ( N'administrator' );
insert INTO roles ( name ) values ( N'doctor' );
insert INTO roles ( name ) values ( N'nurse' );

insert INTO survey_types ( id, name ) values ( 1, N'Разное' );
insert INTO survey_types ( id, name ) values ( 2, N'Рентгенограмма' );

insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 1, N'Оказание неотложной помощи', 1, 0, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 2, N'Профилактические мероприятия (указать)', 2, 0, 0 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 3, N'мотивация по факторам риска стоматологических заболеваний, обучение гигиене', 2, 1, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 4, N'профессиональная гигиена', 2, 2, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 5, N'другие', 2, 3, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 6, N'Терапевтическое лечение (указать)', 3, 0, 0 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 7, N'замена пломб', 3, 1, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 8, N'лечение кариеса и некариозных поражений', 3, 2, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 9, N'эндодонтическое лечение', 3, 3, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 10, N'периодонтологическое лечение', 3, 4, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 11, N'лечение заболеваний слизистой оболочки рта', 3, 5, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 12, N'другое', 3, 6, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 13, N'Хирургическое лечение (указать)', 4, 0, 0 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 14, N'удаление зубов, корней', 4, 1, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 15, N'амбулаторно-хирургические операции', 4, 2, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 16, N'      на мягких тканях', 4, 3, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 17, N'      на костях лицевого скелета', 4, 4, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 18, N'Другое', 4, 5, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 19, N'Ортопедическое лечение (указать)', 5, 0, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 20, N'Ортодонтическое лечение (указать)', 6, 0, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 21, N'Дополнительные диагностические мероприятия (указать)', 7, 0, 1 );
insert INTO treatment_options ( id, name, group_number, order_number, is_fillable ) values ( 22, N'Консультация других специалистов (указать)', 8, 0, 1 );


insert INTO users ( username, password, last_name, role ) values ( N'admin', N'admin', N'Администратор', N'administrator' );
insert INTO users ( username, password, last_name, role ) values ( N'nurse', N'test', N'Мед.Сестра (Тест)', N'nurse' );
insert INTO users ( username, password, last_name, role ) values ( N'doctor', N'test', N'Доктор (Тест)', N'doctor' );