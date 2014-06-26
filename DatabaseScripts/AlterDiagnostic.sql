alter table Diagnostics add Reason nvarchar(400);

alter table Diagnostics add Heart nvarchar(400);
alter table Diagnostics add Neuro nvarchar(400);
alter table Diagnostics add Endocrine nvarchar(400);
alter table Diagnostics add Stomach nvarchar(400);
alter table Diagnostics add Lungs nvarchar(400);
alter table Diagnostics add Infection nvarchar(400);
alter table Diagnostics add Alergic nvarchar(400);
alter table Diagnostics add Drugs nvarchar(400);
alter table Diagnostics add Industry nvarchar(400);
alter table Diagnostics add Pregnant nvarchar(400);
alter table Diagnostics add Other nvarchar(400);

alter table Diagnostics add IsHeart bit
alter table Diagnostics add IsNeuro bit
alter table Diagnostics add IsEndocrine bit
alter table Diagnostics add IsStomach bit
alter table Diagnostics add IsLungs bit
alter table Diagnostics add IsInfection bit
alter table Diagnostics add IsAlergic bit
alter table Diagnostics add IsDrugs bit
alter table Diagnostics add IsIndustry bit
alter table Diagnostics add IsPregnant bit
alter table Diagnostics add IsOther bit

alter table Diagnostics add Face nvarchar(400);
alter table Diagnostics add Skin nvarchar(400);
alter table Diagnostics add Limb nvarchar(400);
alter table Diagnostics add Bone nvarchar(400);