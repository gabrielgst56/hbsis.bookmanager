﻿using HBSIS.BookManager.Business.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HBSIS.BookManager.Controllers
{
    [RoutePrefix("author")]
    public class AuthorController : ApiController
    {
        
        [Route("list")]
        public HttpResponseMessage List()
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, new AuthorBusiness().List());

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
