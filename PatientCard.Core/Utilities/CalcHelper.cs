using System.Collections.Generic;
using System.Linq;
using PatientCard.Core.Models;

namespace PatientCard.Core.Utilities
{
	public static class CalcHelper
	{
		 public static void CalcOhis(OhisStatus ohisStatus)
		 {
			 var cis = new List<int?>
				           {
					           ohisStatus.Cis1,
					           ohisStatus.Cis2,
					           ohisStatus.Cis3,
					           ohisStatus.Cis4,
					           ohisStatus.Cis5,
					           ohisStatus.Cis6,
				           }.Where(n => n.HasValue)
							 .Select(n => n.Value)
							 .ToList();
			 var dis = new List<int?>
				           {
					           ohisStatus.Dis1,
					           ohisStatus.Dis2,
					           ohisStatus.Dis3,
					           ohisStatus.Dis4,
					           ohisStatus.Dis5,
					           ohisStatus.Dis6,
				           }.Where(n => n.HasValue)
							 .Select(n => n.Value)
							 .ToList();

			 ohisStatus.Ohis = (float)cis.Sum()/cis.Count + (float)dis.Sum()/dis.Count;
		 }

		 public static void CalcDfm(DfmStatus dfmStatus)
		 {
			 // todo complete calculation
		 }

		 public static void CalcCpi(CpiStatus cpiStatus)
		 {
			 var vals = new List<int?>
				            {
					            cpiStatus.Value1,
					            cpiStatus.Value2,
					            cpiStatus.Value3,
					            cpiStatus.Value4,
					            cpiStatus.Value5,
					            cpiStatus.Value6,
				            }.Where(n => n.HasValue)
				             .Select(n => n.Value)
				             .ToList();

			 cpiStatus.Cpi = (float)vals.Sum()/vals.Count;
		 }

	}
}