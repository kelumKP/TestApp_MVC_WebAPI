using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAppDataAccess;

namespace TestAppWebAPI.Controllers
{
    public class GameWebAPIController : ApiController
    {
        InterviewDatabaseEntities context = new InterviewDatabaseEntities();

        [HttpGet]
        public IEnumerable<GameTable> GetEmpDetails()
        {
            var gameRecords = context.GameTables.ToList();

            if (gameRecords == null || !gameRecords.Any())
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return gameRecords;

        }
    }
}
