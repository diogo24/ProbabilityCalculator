using Api;
using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication2.Controllers.API
{
	//[ProxyName("probabilityController")]  - to create javascript proxy
	//- https://github.com/stevegreatrex/ProxyApi
	//http://www.faniereynders.com/2014/01/introducing-webapiproxy-providing.html
    public class ProbabilityController : ApiController
    {
		private IProbabilityApi _probabilityApi;

		public ProbabilityController()
		{
			_probabilityApi = new ProbabilityApi();
		}

		// http://autofac.org/ for dependency injection
		//public ProbabilityController(IProbabilityApi probabilityApi)
		//{
		//	//add - throw exception if arguments null

		//	_probabilityApi = probabilityApi;
		//}

		[HttpPost]
		[ActionName("save")]
		public Task<Probability> PostSave([FromBody]Probability probability) 
		{
			if(probability == null) {
				throw new HttpRequestException("Probability was not defined");
			}

			return _probabilityApi.Save(probability);
		}
    }
}
