using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProgramsExplained
{
	public enum Importance
	{
		HIGH,
		MEDIUM,
		LOW
	}

	public enum PerformanceImpact
	{
		HIGH,
		MEDIUM,
		LOW
	}

	public struct ApplicationData
	{
		public string displayName;
		public Importance importance;
		public PerformanceImpact performanceImpact;
		public string shortDescription;
		public string fullDescription;
		public string developer;
		public string developerRating;
	}
}
