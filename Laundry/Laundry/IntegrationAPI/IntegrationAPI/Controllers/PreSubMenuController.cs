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
    public class PreSubMenuController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetPreSubMenuDetail")]
        [HttpPost]
        public HttpResponseMessage GetPreSubMenuDetail([FromBody]clsPreSubMenu request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Presubmenuid + " Name :" + request.PresubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PreSubMenuService objComService = new PreSubMenuService();
                var objResponse = objComService.GetPreSubMenuDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Presubmenuid + "    name :" + request.PresubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for    name : " + request.PresubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting    name " + request.PresubmenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetPreSubMenuDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPreSubMenuDetailById([FromBody]clsPreSubMenu request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Presubmenuid + " Name :" + request.PresubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PreSubMenuService objComService = new PreSubMenuService();
                var objResponse = objComService.GetPreSubMenuDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Presubmenuid + "    name :" + request.PresubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for    name : " + request.PresubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting    name " + request.PresubmenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertPreSubMenu")]
        [HttpPost]
        public HttpResponseMessage InsertPreSubMenu([FromBody]clsPreSubMenu request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Presubmenuid + " Name :" + request.PresubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PreSubMenuService objComService = new PreSubMenuService();
                var objResponse = objComService.InsertPreSubMenu(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Presubmenuid + "    name :" + request.PresubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for    name : " + request.PresubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting    name " + request.PresubmenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdatePreSubMenu")]
        [HttpPost]
        public HttpResponseMessage UpdatePreSubMenu([FromBody]clsPreSubMenu request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Presubmenuid + " Name :" + request.PresubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PreSubMenuService objComService = new PreSubMenuService();
                var objResponse = objComService.UpdatePreSubMenu(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Presubmenuid + "    name :" + request.PresubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for    name : " + request.PresubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting    name " + request.PresubmenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeletePreSubMenu")]
        [HttpPost]
        public HttpResponseMessage DeletePreSubMenu([FromBody]clsPreSubMenu request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Presubmenuid + " Name :" + request.PresubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PreSubMenuService objComService = new PreSubMenuService();
                var objResponse = objComService.DeletePreSubMenu(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Presubmenuid + "    name :" + request.PresubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for    name : " + request.PresubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting    name " + request.PresubmenuName + ".");

            }
            return response;
        }

    }
}
