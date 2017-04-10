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
    public class ModuleMasterController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetModuleMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetModuleMasterDetail([FromBody]clsModuleMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                ModuleMasterService objComService = new ModuleMasterService();
                var objResponse = objComService.GetModuleMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Module Name : " + request.ModuleName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Module Name " + request.ModuleName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetModuleMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetModuleMasterDetailById([FromBody]clsModuleMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                ModuleMasterService objComService = new ModuleMasterService();
                var objResponse = objComService.GetModuleMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Module Name : " + request.ModuleName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Module Name " + request.ModuleName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertModuleMaster")]
        [HttpPost]
        public HttpResponseMessage InsertModuleMaster([FromBody]clsModuleMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                ModuleMasterService objComService = new ModuleMasterService();
                var objResponse = objComService.InsertModuleMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Module Name : " + request.ModuleName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Module Name " + request.ModuleName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateModuleMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateModuleMaster([FromBody]clsModuleMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                ModuleMasterService objComService = new ModuleMasterService();
                var objResponse = objComService.UpdateModuleMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Module Name : " + request.ModuleName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Module Name " + request.ModuleName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteModuleMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteModuleMaster([FromBody]clsModuleMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                ModuleMasterService objComService = new ModuleMasterService();
                var objResponse = objComService.DeleteModuleMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Moduleid + "  Module Name :" + request.ModuleName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Module Name : " + request.ModuleName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Module Name " + request.ModuleName + ".");

            }
            return response;
        }

    }
}
