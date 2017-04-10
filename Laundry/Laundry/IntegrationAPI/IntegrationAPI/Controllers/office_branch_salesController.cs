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
    public class office_branch_salesController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetOfficeBranchSalesDetail")]
        [HttpPost]
        public HttpResponseMessage GetOfficeBranchSalesDetail([FromBody]clsofficeBanchSales request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branch_salesService objComService = new office_branch_salesService();
                var objResponse = objComService.GetOfficeBranchSalesDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
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
        [Route("GetOfficeBranchSalesDetailById")]
        [HttpPost]
        public HttpResponseMessage GetOfficeBranchSalesDetailById([FromBody]clsofficeBanchSales request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branch_salesService objComService = new office_branch_salesService();
                var objResponse = objComService.GetOfficeBranchSalesDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
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
        [Route("InsertOfficeBranchSales")]
        [HttpPost]
        public HttpResponseMessage InsertOfficeBranchSales([FromBody]clsofficeBanchSales request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branch_salesService objComService = new office_branch_salesService();
                var objResponse = objComService.InsertOfficeBranchSales(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
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
        [Route("UpdateOfficeBranchSales")]
        [HttpPost]
        public HttpResponseMessage UpdateOfficeBranchSales([FromBody]clsofficeBanchSales request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branch_salesService objComService = new office_branch_salesService();
                var objResponse = objComService.UpdateOfficeBranchSales(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
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
        [Route("DeleteOfficeBranchSales")]
        [HttpPost]
        public HttpResponseMessage DeleteOfficeBranchSales([FromBody]clsofficeBanchSales request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                office_branch_salesService objComService = new office_branch_salesService();
                var objResponse = objComService.DeleteOfficeBranchSales(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.BranchSalesID + "  Office branch Id :" + request.OfficeBranchID);
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
