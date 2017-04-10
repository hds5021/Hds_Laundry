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
    public class office_branchController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetOfficeBranchDetail")]
        [HttpPost]
        public HttpResponseMessage GetOfficeBranchDetail([FromBody]clsofficeBranch request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branchService objComService = new office_branchService();
                var objResponse = objComService.GetOfficeBranchDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Office branch Id : " + request.OfficeBranchID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Office branch Id " + request.OfficeBranchID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetOfficeBranchDetailById")]
        [HttpPost]
        public HttpResponseMessage GetOfficeBranchDetailById([FromBody]clsofficeBranch request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branchService objComService = new office_branchService();
                var objResponse = objComService.GetOfficeBranchDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Office branch Id : " + request.OfficeBranchID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Office branch Id " + request.OfficeBranchID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertOfficeBranch")]
        [HttpPost]
        public HttpResponseMessage InsertOfficeBranch([FromBody]clsofficeBranch request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branchService objComService = new office_branchService();
                var objResponse = objComService.InsertOfficeBranch(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Office branch Id : " + request.OfficeBranchID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Office branch Id " + request.OfficeBranchID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateOfficeBranch")]
        [HttpPost]
        public HttpResponseMessage UpdateOfficeBranch([FromBody]clsofficeBranch request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branchService objComService = new office_branchService();
                var objResponse = objComService.UpdateOfficeBranch(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Office branch Id : " + request.OfficeBranchID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Office branch Id " + request.OfficeBranchID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteOfficeBranch")]
        [HttpPost]
        public HttpResponseMessage DeleteOfficeBranch([FromBody]clsofficeBranch request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branchService objComService = new office_branchService();
                var objResponse = objComService.DeleteOfficeBranch(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.OfficeBranchID + "  Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Office branch Id : " + request.OfficeBranchID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Office branch Id " + request.OfficeBranchID + ".");

            }
            return response;
        }



    }
}
