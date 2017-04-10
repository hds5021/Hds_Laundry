using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IntegrationAPI.Services;
using IntegrationAPI.Helpers;
namespace IntegrationAPI.Controllers
{
    public class PartyController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetPartyDetail")]
        [HttpPost]
        public HttpResponseMessage GetPartyDetail([FromBody]clsParty request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PartyID + " Party name :" + request.PartyName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PartyService objComService = new PartyService();
                var objResponse = objComService.GetPartyDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PartyID + "   Party name :" + request.PartyName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.PartyName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.PartyName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetPartyDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPartyDetailById([FromBody]clsParty request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PartyID + " Party name :" + request.PartyName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PartyService objComService = new PartyService();
                var objResponse = objComService.GetPartyDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PartyID + "   Party name :" + request.PartyName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.PartyName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.PartyName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertParty")]
        [HttpPost]
        public HttpResponseMessage InsertParty([FromBody]clsParty request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PartyID + " Party name :" + request.PartyName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PartyService objComService = new PartyService();
                var objResponse = objComService.InsertParty(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PartyID + "   Party name :" + request.PartyName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.PartyName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.PartyName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateParty")]
        [HttpPost]
        public HttpResponseMessage UpdateParty([FromBody]clsParty request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PartyID + " Party name :" + request.PartyName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PartyService objComService = new PartyService();
                var objResponse = objComService.UpdateParty(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PartyID + "   Party name :" + request.PartyName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.PartyName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.PartyName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteParty")]
        [HttpPost]
        public HttpResponseMessage DeleteParty([FromBody]clsParty request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PartyID + " Party name :" + request.PartyName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PartyService objComService = new PartyService();
                var objResponse = objComService.DeleteParty(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PartyID + "   Party name :" + request.PartyName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.PartyName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.PartyName + ".");

            }
            return response;
        }

    }
}
