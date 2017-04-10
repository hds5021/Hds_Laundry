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
    public class instancesController : ApiController
    {/// <summary>
     /// Created Date : 03/03/2017
     /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
     /// <returns></returns>
     /// </summary>

        /// Instance_Setting 

        [Authorize]
        [Route("GetInstancesDetail")]
        [HttpPost]
        public HttpResponseMessage GetInstancesDetail([FromBody]clsinstances request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.InstanceName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instancesService objComService = new instancesService();
                var objResponse = objComService.GetInstancesDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.InstanceName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetInstancesDetailById")]
        [HttpPost]
        public HttpResponseMessage GetInstancesDetailById([FromBody]clsinstances request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.InstanceName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instancesService objComService = new instancesService();
                var objResponse = objComService.GetInstancesDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.InstanceName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertInstances")]
        [HttpPost]
        public HttpResponseMessage InsertInstances([FromBody]clsinstances request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.InstanceName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instancesService objComService = new instancesService();
                var objResponse = objComService.InsertInstances(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.InstanceName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateInstances")]
        [HttpPost]
        public HttpResponseMessage UpdateInstances([FromBody]clsinstances request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.InstanceName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instancesService objComService = new instancesService();
                var objResponse = objComService.UpdateInstances(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.InstanceName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteInstances")]
        [HttpPost]
        public HttpResponseMessage DeleteInstances([FromBody]clsinstances request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InstanceID + "  Name :" + request.InstanceName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                instancesService objComService = new instancesService();
                var objResponse = objComService.DeleteInstances(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InstanceID + "  Name :" + request.InstanceName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Name : " + request.InstanceName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Name " + request.InstanceName + ".");

            }
            return response;
        }


    }
}
