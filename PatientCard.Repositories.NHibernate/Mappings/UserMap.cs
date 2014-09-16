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
			Id(e => e.Key, "Id").GeneratedBy.Increment();
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
			Map(e => e.YesNo);
			Map(e => e.Detail);
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
			Id(e => e.Key, "Id").GeneratedBy.Increment();
			Map(e => e.FirstName).Not.Nullable().Length(100);
			Map(e => e.MiddleName).Not.Nullable().Length(100);
			Map(e => e.LastName).Not.Nullable().Length(100);
			Map(e => e.BirthDate);
			Map(e => e.Gender);
			Map(e => e.Address).Length(400);
			Map(e => e.Phone).Length(100);
			Map(e => e.SocialStatus).Length(400);
			Map(e => e.Job).Length(100);
			Map(e => e.Created);
		}
	}

	public class SurveyMap : ClassMap<Survey>
	{
		public SurveyMap()
		{
			Table("Surveys");
			Id(e => e.Key, "Id").GeneratedBy.Increment();
			Map(e => e.PatientId).Not.Nullable();
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.TypeId).Nullable();
			Map(e => e.Description).Length(400);
			Map(e => e.Created);
			Map(e => e.Dose);
		}
	}

	public class SurveyTypeMap : ClassMap<SurveyType>
	{
		public SurveyTypeMap()
		{
			Table("SurveyTypes");
			Id(e => e.Key, "Id").GeneratedBy.Increment();
			Map(e => e.Name).Unique().Not.Nullable().Length(400);
		}
	}

	public class ThreatmentOptionMap : ClassMap<ThreatmentOption>
	{
		public ThreatmentOptionMap()
		{
			Table("ThreatmentOptions");
			Id(e => e.Key, "Id").GeneratedBy.Increment();
			Map(e => e.Name).UniqueKey("uk_ThreatmentOptions").Not.Nullable().Length(400);
			Map(e => e.GroupNumber).UniqueKey("uk_ThreatmentOptions").Not.Nullable();
			Map(e => e.OrderNumber);
		}
	}

	public class ThreatmentPlanMap : ClassMap<ThreatmentPlan>
	{
		public ThreatmentPlanMap()
		{
			Table("ThreatmentPlans");
			CompositeId()
				.KeyProperty(e => e.PatientId)
				.KeyProperty(e => e.ThreatmentOptionId);
			Map(e => e.Description).Length(400);
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.Created);
		}
	}

	public class VisitDiaryMap : ClassMap<VisitDiary>
	{
		public VisitDiaryMap()
		{
			Table("VisitDiary");
			Id(e => e.Key, "Id").GeneratedBy.Increment();
			Map(e => e.PatientId).Not.Nullable();
			Map(e => e.Username).Not.Nullable().Length(100);
			Map(e => e.Description).Length(400);
		}
	}
}
