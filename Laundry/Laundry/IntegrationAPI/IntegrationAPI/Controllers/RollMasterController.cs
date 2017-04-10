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
    public class RollMasterController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetRollMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetRollMasterDetail([FromBody]clsRollMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Rollid + " Roll name :" + request.RollName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                RollMasterService objComService = new RollMasterService();
                var objResponse = objComService.GetRollMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Rollid + "   Roll name :" + request.RollName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Roll name : " + request.RollName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Roll name " + request.RollName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetRollMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetRollMasterDetailById([FromBody]clsRollMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Rollid + " Roll name :" + request.RollName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                RollMasterService objComService = new RollMasterService();
                var objResponse = objComService.GetRollMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Rollid + "   Roll name :" + request.RollName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Roll name : " + request.RollName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Roll name " + request.RollName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertRollMaster")]
        [HttpPost]
        public HttpResponseMessage InsertRollMaster([FromBody]clsRollMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Rollid + " Roll name :" + request.RollName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                RollMasterService objComService = new RollMasterService();
                var objResponse = objComService.InsertRollMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Rollid + "   Roll name :" + request.RollName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Roll name : " + request.RollName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Roll name " + request.RollName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateRollMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateRollMaster([FromBody]clsRollMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Rollid + " Roll name :" + request.RollName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                RollMasterService objComService = new RollMasterService();
                var objResponse = objComService.UpdateRollMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Rollid + "   Roll name :" + request.RollName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Roll name : " + request.RollName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Roll name " + request.RollName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteRollMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteRollMaster([FromBody]clsRollMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Rollid + " Roll name :" + request.RollName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                RollMasterService objComService = new RollMasterService();
                var objResponse = objComService.DeleteRollMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Rollid + "   Roll name :" + request.RollName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Roll name : " + request.RollName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Roll name " + request.RollName + ".");

            }
            return response;
        }




    }
}
