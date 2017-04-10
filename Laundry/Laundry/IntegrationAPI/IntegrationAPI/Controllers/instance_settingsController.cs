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
    public class instance_settingsController : ApiController
    {/// <summary>
     /// Created Date : 03/03/2017
     /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
     /// <returns></returns>
     /// </summary>

        /// Instance_Setting 

        [Authorize]
        [Route("GetInstanceSettingsDetail")]
        [HttpPost]
        public HttpResponseMessage GetInstanceSettingsDetail([FromBody]clsinstanceSettings request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.Tax1Name);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instance_settingsService objComService = new instance_settingsService();
                var objResponse = objComService.GetInstanceSettingsDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.Tax1Name);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetInstanceSettingsDetailById")]
        [HttpPost]
        public HttpResponseMessage GetInstanceSettingsDetailById([FromBody]clsinstanceSettings request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.Tax1Name);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instance_settingsService objComService = new instance_settingsService();
                var objResponse = objComService.GetInstanceSettingsDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.Tax1Name);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertInstanceSettings")]
        [HttpPost]
        public HttpResponseMessage InsertInstanceSettings([FromBody]clsinstanceSettings request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.Tax1Name);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instance_settingsService objComService = new instance_settingsService();
                var objResponse = objComService.InsertInstanceSettings(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.Tax1Name);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateInstanceSettings")]
        [HttpPost]
        public HttpResponseMessage UpdateInstanceSettings([FromBody]clsinstanceSettings request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.Tax1Name);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instance_settingsService objComService = new instance_settingsService();
                var objResponse = objComService.UpdateInstanceSettings(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.Tax1Name);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteInstanceSettings")]
        [HttpPost]
        public HttpResponseMessage DeleteInstanceSettings([FromBody]clsinstanceSettings request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.Tax1Name);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instance_settingsService objComService = new instance_settingsService();
                var objResponse = objComService.DeleteInstanceSettings(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.Tax1Name);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceID + ".");

            }
            return response;
        }

    }
}
