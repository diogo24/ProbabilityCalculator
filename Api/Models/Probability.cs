using Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
	public class Probability
	{
		public double Value1 { get; set; }
		public double Value2 { get; set; }
		public double Result { get; set; }

		public ProbabilityType Type { get; set; }

		public DateTime Created { get; set; }
	}
}