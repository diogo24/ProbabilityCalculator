using Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
	public class ProbabilityApi : IProbabilityApi
    {
		private string directory = "\\ProbabilityCalculator";
		private string _logFileName = "\\ProbabilityCalculatorLog.json";
		private string _logPath;

		public async Task<Probability> Save(Probability probability)
		{
			InitializeLog();

			using (StreamWriter fs = new StreamWriter(File.Open(_logPath, FileMode.Append)))
			{
				var serielazedProbability = JsonConvert.SerializeObject(probability);
				await fs.WriteLineAsync(serielazedProbability);
			}

			return probability;
		}

		private void InitializeLog()
		{
			// storing data in user app data local
			var localDataPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
			_logPath = string.Format("{0}{1}", localDataPath, directory);

			if (!Directory.Exists(_logPath))
			{
				Directory.CreateDirectory(_logPath);
			}

			// add file to the path
			_logPath = string.Format("{0}{1}", _logPath, directory);

			if (!File.Exists(_logPath))
			{
				File.Open(_logPath, FileMode.Create).Close();
			}	
		}
	}
}
