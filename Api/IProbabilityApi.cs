﻿using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
	public interface IProbabilityApi
	{
		Task<Probability> Save(Probability probability);
	}
}
