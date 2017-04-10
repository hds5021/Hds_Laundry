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
    public class PageMasterController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetPageMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetPageMasterDetail([FromBody]clsPageMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Pageid + "  Page Name :" + request.PageName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PageMasterService objComService = new PageMasterService();
                var objResponse = objComService.GetPageMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Pageid + "  Page Name :" + request.PageName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Page Name : " + request.PageName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Page Name " + request.PageName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetPageMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPageMasterDetailById([FromBody]clsPageMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Pageid + "  Page Name :" + request.PageName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PageMasterService objComService = new PageMasterService();
                var objResponse = objComService.GetPageMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Pageid + "  Page Name :" + request.PageName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Page Name : " + request.PageName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Page Name " + request.PageName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertPageMaster")]
        [HttpPost]
        public HttpResponseMessage InsertPageMaster([FromBody]clsPageMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Pageid + "  Page Name :" + request.PageName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PageMasterService objComService = new PageMasterService();
                var objResponse = objComService.InsertPageMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Pageid + "  Page Name :" + request.PageName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Page Name : " + request.PageName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Page Name " + request.PageName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdatePageMaster")]
        [HttpPost]
        public HttpResponseMessage UpdatePageMaster([FromBody]clsPageMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Pageid + "  Page Name :" + request.PageName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PageMasterService objComService = new PageMasterService();
                var objResponse = objComService.UpdatePageMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Pageid + "  Page Name :" + request.PageName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Page Name : " + request.PageName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Page Name " + request.PageName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeletePageMaster")]
        [HttpPost]
        public HttpResponseMessage DeletePageMaster([FromBody]clsPageMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Pageid + "  Page Name :" + request.PageName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PageMasterService objComService = new PageMasterService();
                var objResponse = objComService.DeletePageMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Pageid + "  Page Name :" + request.PageName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Page Name : " + request.PageName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Page Name " + request.PageName + ".");

            }
            return response;
        }


    }
}
