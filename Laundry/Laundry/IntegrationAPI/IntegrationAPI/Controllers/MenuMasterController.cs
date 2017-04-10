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
    public class MenuMasterController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetMenuMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetMenuMasterDetail([FromBody]clsMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Menuid + "  Menu Name :" + request.MenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                MenuMasterService objComService = new MenuMasterService();
                var objResponse = objComService.GetMenuMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Menuid + "  Menu Name :" + request.MenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Menu Name : " + request.MenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Menu Name " + request.MenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetMenuMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetMenuMasterDetailById([FromBody]clsMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Menuid + "  Menu Name :" + request.MenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                MenuMasterService objComService = new MenuMasterService();
                var objResponse = objComService.GetMenuMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Menuid + "  Menu Name :" + request.MenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Menu Name : " + request.MenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Menu Name " + request.MenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertMenuMaster")]
        [HttpPost]
        public HttpResponseMessage InsertMenuMaster([FromBody]clsMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Menuid + "  Menu Name :" + request.MenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                MenuMasterService objComService = new MenuMasterService();
                var objResponse = objComService.InsertMenuMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Menuid + "  Menu Name :" + request.MenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Menu Name : " + request.MenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Menu Name " + request.MenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateMenuMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateMenuMaster([FromBody]clsMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Menuid + "  Menu Name :" + request.MenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                MenuMasterService objComService = new MenuMasterService();
                var objResponse = objComService.UpdateMenuMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Menuid + "  Menu Name :" + request.MenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Menu Name : " + request.MenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Menu Name " + request.MenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteMenuMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteMenuMaster([FromBody]clsMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Menuid + "  Menu Name :" + request.MenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                MenuMasterService objComService = new MenuMasterService();
                var objResponse = objComService.DeleteMenuMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Menuid + "  Menu Name :" + request.MenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Menu Name : " + request.MenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Menu Name " + request.MenuName + ".");

            }
            return response;
        }

    }
}
