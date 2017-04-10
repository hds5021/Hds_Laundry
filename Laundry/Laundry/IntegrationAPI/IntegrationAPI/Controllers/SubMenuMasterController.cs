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
    public class SubMenuMasterController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetSubMenuMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetSubMenuMasterDetail([FromBody]clsSubMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Submenuid + " SubMenu name :" + request.SubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                SubMenuMasterService objComService = new SubMenuMasterService();
                var objResponse = objComService.GetSubMenuMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Submenuid + "   SubMenu name :" + request.SubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   SubMenu name : " + request.SubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SubmenuName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetSubMenuMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetSubMenuMasterDetailById([FromBody]clsSubMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Submenuid + " SubMenu name :" + request.SubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                SubMenuMasterService objComService = new SubMenuMasterService();
                var objResponse = objComService.GetSubMenuMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Submenuid + "   SubMenu name :" + request.SubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   SubMenu name : " + request.SubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SubmenuName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertSubMenuMaster")]
        [HttpPost]
        public HttpResponseMessage InsertSubMenuMaster([FromBody]clsSubMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Submenuid + " SubMenu name :" + request.SubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                SubMenuMasterService objComService = new SubMenuMasterService();
                var objResponse = objComService.InsertSubMenuMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Submenuid + "   SubMenu name :" + request.SubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   SubMenu name : " + request.SubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SubmenuName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateSubMenuMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateSubMenuMaster([FromBody]clsSubMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Submenuid + " SubMenu name :" + request.SubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                SubMenuMasterService objComService = new SubMenuMasterService();
                var objResponse = objComService.UpdateSubMenuMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Submenuid + "   SubMenu name :" + request.SubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   SubMenu name : " + request.SubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SubmenuName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteSubMenuMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteSubMenuMaster([FromBody]clsSubMenuMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Submenuid + " SubMenu name :" + request.SubmenuName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                SubMenuMasterService objComService = new SubMenuMasterService();
                var objResponse = objComService.DeleteSubMenuMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Submenuid + "   SubMenu name :" + request.SubmenuName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   SubMenu name : " + request.SubmenuName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SubmenuName + ".");

            }
            return response;
        }

    }
}
