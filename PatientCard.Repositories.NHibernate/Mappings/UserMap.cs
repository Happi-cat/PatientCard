using FluentNHibernate.Mapping;
using PatientCard.Core.Models;

namespace PatientCard.Repositories.NHibernate.Mappings
{
	public class UserMap : ClassMap<User>
	{
		public UserMap()
		{
			Table("Users");
			Id(e => e.Username).Length(100).GeneratedBy.Assigned();
			Map(e => e.Password).Not.Nullable().Length(100);
			Map(e => e.FirstName).Length(100);
			Map(e => e.MiddleName).Length(100);
			Map(e => e.LastName).Length(100);
			Map(e => e.Email).Length(100);
			Map(e => e.Job).Length(100);
			Map(e => e.Created);
			Map(e => e.Active);
			Map(e => e.Address).Length(400);
			Map(e => e.Phone).Length(100);
		}

	}

	public class FirstSurveyMap : ClassMap<FirstSurvey>
	{
		public FirstSurveyMap()
		{
			Table("FirstSurveys");
			Id(e => e.PatientId).GeneratedBy.Assigned();
			Map(e => e.Reason).Length(400);
			Map(e => e.Face).Length(400);
			Map(e => e.Skin).Length(400);
			Map(e => e.Limbs).Length(400);
			Map(e => e.Bones).Length(400);
		}
	}

	public class FirstSurveyOptionMap : ClassMap<FirstSurveyOption>
	{
		public FirstSurveyOptionMap()
		{
			Table("FirstSurveyOptions");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.Name).Unique().Not.Nullable().Length(400);
		}
	}

	public class FirstSurveyDetailMap : ClassMap<FirstSurveyDetail>
	{
		public FirstSurveyDetailMap()
		{
			Table("FirstSurveyDetails");
			CompositeId()
				.KeyProperty(e => e.PatientId)
				.KeyProperty(e => e.SurveyOptionId);
			Map(e => e.YesNo).Update().CustomType("Boolean").CustomSqlType("bit");
			Map(e => e.Detail).Update();
		}
	}

	public class JobMap : ClassMap<Job>
	{
		public JobMap()
		{
			Table("Jobs");
			Id(e => e.Name).Not.Nullable().Length(100).GeneratedBy.Assigned();
			Map(e => e.Description);
		}
	}

	public class PatientMap : ClassMap<Patient>
	{
		public PatientMap()
		{
			Table("Patients");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.FirstName).Not.Nullable().Length(100);
			Map(e => e.MiddleName).Not.Nullable().Length(100);
			Map(e => e.LastName).Not.Nullable().Length(100);
			Map(e => e.Birthday).Nullable();
			Map(e => e.Gender);
			Map(e => e.Address).Length(400);
			Map(e => e.Phone).Length(100);
			Map(e => e.SocialStatus).Length(400);
			Map(e => e.Job).Length(100);
			Map(e => e.Created).Not.Insert().Not.Update();
		}
	}

	public class SurveyMap : ClassMap<Survey>
	{
		public SurveyMap()
		{
			Table("Surveys");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.PatientId).Not.Nullable();
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.TypeId).Nullable();
			Map(e => e.Description).Length(400);
			Map(e => e.Created).Not.Insert().Not.Update();
			Map(e => e.Dose);
		}
	}

	public class SurveyTypeMap : ClassMap<SurveyType>
	{
		public SurveyTypeMap()
		{
			Table("SurveyTypes");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.Name).Unique().Not.Nullable().Length(400);
		}
	}

	public class TreatmentOptionMap : ClassMap<TreatmentOption>
	{
		public TreatmentOptionMap()
		{
			Table("TreatmentOptions");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.Name).UniqueKey("uk_TreatmentOptions").Not.Nullable().Length(400);
			Map(e => e.GroupNumber).UniqueKey("uk_TreatmentOptions").Not.Nullable();
			Map(e => e.OrderNumber);
		}
	}

	public class TreatmentPlanMap : ClassMap<TreatmentPlan>
	{
		public TreatmentPlanMap()
		{
			Table("TreatmentPlans");
			CompositeId()
				.KeyProperty(e => e.PatientId)
				.KeyProperty(e => e.TreatmentOptionId);
			Map(e => e.Description).Length(400);
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.Created).Not.Insert().Not.Update();
		}
	}

	public class VisitMap : ClassMap<Visit>
	{
		public VisitMap()
		{
			Table("Visits");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.PatientId).Not.Nullable();
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.Description).Length(400);
			Map(e => e.Created).Not.Insert().Not.Update();
		}
	}

	public class DentistStatusMap : ClassMap<DentistStatus>
	{
		public DentistStatusMap()
		{
			Table("DentistStatuses");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.PatientId).Not.Nullable();
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.Created).Not.Insert().Not.Update();
			Map(e => e.Bite).Nullable();
			Map(e => e.HardTissue).Nullable();
			Map(e => e.Mucous).Nullable();
			Map(e => e.XrayDiagnostics).Nullable();
			Map(e => e.PreliminaryDiagnosis).Nullable();
		}
	}

	public class CpiStatusMap : ClassMap<CpiStatus>
	{
		public CpiStatusMap()
		{
			Table("CpiStatuses");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.PatientId).Not.Nullable();
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.Created).Not.Insert().Not.Update();
			Map(e => e.Value1).Nullable();
			Map(e => e.Value2).Nullable();
			Map(e => e.Value3).Nullable();
			Map(e => e.Value4).Nullable();
			Map(e => e.Value5).Nullable();
			Map(e => e.Value6).Nullable();
			Map(e => e.Cpi);
		}
	}

	public class DfmStatustMap : ClassMap<DfmStatus>
	{
		public DfmStatustMap()
		{
			Table("DfmStatuses");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.PatientId).Not.Nullable();
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.Created).Not.Insert().Not.Update();
			Map(e => e.UpperLeft1).Nullable();
			Map(e => e.UpperLeft2).Nullable();
			Map(e => e.UpperLeft3).Nullable();
			Map(e => e.UpperLeft4).Nullable();
			Map(e => e.UpperLeft5).Nullable();
			Map(e => e.UpperLeft6).Nullable();
			Map(e => e.UpperLeft7).Nullable();
			Map(e => e.UpperLeft8).Nullable();
			Map(e => e.UpperRight1).Nullable();
			Map(e => e.UpperRight2).Nullable();
			Map(e => e.UpperRight3).Nullable();
			Map(e => e.UpperRight4).Nullable();
			Map(e => e.UpperRight5).Nullable();
			Map(e => e.UpperRight6).Nullable();
			Map(e => e.UpperRight7).Nullable();
			Map(e => e.UpperRight8).Nullable();
			Map(e => e.LowerLeft1).Nullable();
			Map(e => e.LowerLeft2).Nullable();
			Map(e => e.LowerLeft3).Nullable();
			Map(e => e.LowerLeft4).Nullable();
			Map(e => e.LowerLeft5).Nullable();
			Map(e => e.LowerLeft6).Nullable();
			Map(e => e.LowerLeft7).Nullable();
			Map(e => e.LowerLeft8).Nullable();
			Map(e => e.LowerRight1).Nullable();
			Map(e => e.LowerRight2).Nullable();
			Map(e => e.LowerRight3).Nullable();
			Map(e => e.LowerRight4).Nullable();
			Map(e => e.LowerRight5).Nullable();
			Map(e => e.LowerRight6).Nullable();
			Map(e => e.LowerRight7).Nullable();
			Map(e => e.LowerRight8).Nullable();
			Map(e => e.Dfm);
		}
	}

	public class OhisStatusMap : ClassMap<OhisStatus>
	{
		public OhisStatusMap()
		{
			Table("OhisStatuses");
			Id(e => e.Key, "Id").GeneratedBy.Native();
			Map(e => e.PatientId).Not.Nullable();
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.Created).Not.Insert().Not.Update();
			Map(e => e.Cis1).Nullable();
			Map(e => e.Cis2).Nullable();
			Map(e => e.Cis3).Nullable();
			Map(e => e.Cis4).Nullable();
			Map(e => e.Cis5).Nullable();
			Map(e => e.Cis6).Nullable();
			Map(e => e.Dis1).Nullable();
			Map(e => e.Dis2).Nullable();
			Map(e => e.Dis3).Nullable();
			Map(e => e.Dis4).Nullable();
			Map(e => e.Dis5).Nullable();
			Map(e => e.Dis6).Nullable();
			Map(e => e.Ohis);
		}
	}
}
