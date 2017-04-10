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
    public class posbillcountController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetPosBillCountDetail")]
        [HttpPost]
        public HttpResponseMessage GetPosBillCountDetail([FromBody]clsposbillcount request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosBillCountID );
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                posbillcountService objComService = new posbillcountService();
                var objResponse = objComService.GetPosBillCountDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosBillCountID );
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.PosBillCountID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.PosBillCountID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetPosBillCountDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPosBillCountDetailById([FromBody]clsposbillcount request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosBillCountID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                posbillcountService objComService = new posbillcountService();
                var objResponse = objComService.GetPosBillCountDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosBillCountID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.PosBillCountID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.PosBillCountID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertPosBillCount")]
        [HttpPost]
        public HttpResponseMessage InsertPosBillCount([FromBody]clsposbillcount request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosBillCountID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                posbillcountService objComService = new posbillcountService();
                var objResponse = objComService.InsertPosBillCount(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosBillCountID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.PosBillCountID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.PosBillCountID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdatePosBillCount")]
        [HttpPost]
        public HttpResponseMessage UpdatePosBillCount([FromBody]clsposbillcount request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosBillCountID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                posbillcountService objComService = new posbillcountService();
                var objResponse = objComService.UpdatePosBillCount(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosBillCountID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.PosBillCountID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.PosBillCountID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeletePosBillCount")]
        [HttpPost]
        public HttpResponseMessage DeletePosBillCount([FromBody]clsposbillcount request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosBillCountID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                posbillcountService objComService = new posbillcountService();
                var objResponse = objComService.DeletePosBillCount(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosBillCountID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.PosBillCountID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.PosBillCountID + ".");

            }
            return response;
        }


    }
}
