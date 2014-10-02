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

			ohisStatus.Ohis = (float)cis.Sum() / cis.Count + (float)dis.Sum() / dis.Count;
		}

		public static void CalcDfm(DfmStatus dfmStatus)
		{
			var vals = new List<char?>
				{
					dfmStatus.UpperLeft1,
					dfmStatus.UpperLeft2,
					dfmStatus.UpperLeft3,
					dfmStatus.UpperLeft4,
					dfmStatus.UpperLeft5,
					dfmStatus.UpperLeft6,
					dfmStatus.UpperLeft7,
					dfmStatus.UpperLeft8,

					dfmStatus.UpperRight1,
					dfmStatus.UpperRight2,
					dfmStatus.UpperRight3,
					dfmStatus.UpperRight4,
					dfmStatus.UpperRight5,
					dfmStatus.UpperRight6,
					dfmStatus.UpperRight7,
					dfmStatus.UpperRight8,

					dfmStatus.LowerLeft1,
					dfmStatus.LowerLeft2,
					dfmStatus.LowerLeft3,
					dfmStatus.LowerLeft4,
					dfmStatus.LowerLeft5,
					dfmStatus.LowerLeft6,
					dfmStatus.LowerLeft7,
					dfmStatus.LowerLeft8,

					dfmStatus.LowerRight1,
					dfmStatus.LowerRight2,
					dfmStatus.LowerRight3,
					dfmStatus.LowerRight4,
					dfmStatus.LowerRight5,
					dfmStatus.LowerRight6,
					dfmStatus.LowerRight7,
					dfmStatus.LowerRight8,
				}.Where(n => n.HasValue &&
				             ((n.Value > '0' && n.Value < '8') || (n.Value > 'A' && n.Value < 'F')))
				 .Select(n => n.Value)
				 .ToList();

			dfmStatus.Dfm = vals.Count();
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

			cpiStatus.Cpi = (float)vals.Sum() / vals.Count;
		}

	}
}