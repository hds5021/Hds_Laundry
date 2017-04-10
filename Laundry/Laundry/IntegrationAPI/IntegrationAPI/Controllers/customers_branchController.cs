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
    public class customers_branchController : ApiController
    {
        /// <summary>
        /// Created Date : 01/09/2016
        /// Below method use for get Customer Branch details based on Customer  and Customer Name.
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// In Header need to pass Key Value  
        /// Request :{ "CustomerNumber": 0 ,  "CustomerName": "Test Account Sigma"}
        /// <returns></returns>
        /// </summary>

        /// Customer Branch Detail

        [Authorize]
        [Route("GetCustomerBranchDetail")]
        [HttpPost]
        public HttpResponseMessage GetCustomerBranchDetail([FromBody]customerBranchRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customers_branchService objComService = new customers_branchService();
                var CustomerResponse = objComService.getCustomerBranchDetail(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Branch Name : " + request.BranchName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.BranchName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetCustomerBranchById")]
        [HttpPost]
        public HttpResponseMessage GetCustomerBranchById([FromBody]customerBranchRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customers_branchService objComService = new customers_branchService();
                var CustomerResponse = objComService.getCustomerBranchById(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Branch Name : " + request.BranchName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.BranchName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertCustomerBranch")]
        [HttpPost]
        public HttpResponseMessage InsertCustomerBranch([FromBody]customerBranchRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customers_branchService objComService = new customers_branchService();
                var CustomerResponse = objComService.InsertCustomerBranch(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Branch Name : " + request.BranchName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.BranchName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateCustomerBranch")]
        [HttpPost]
        public HttpResponseMessage UpdateCustomerBranch([FromBody]customerBranchRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customers_branchService objComService = new customers_branchService();
                var CustomerResponse = objComService.UpdateCustomerBranch(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Branch Name : " + request.BranchName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.BranchName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteCustomerBranch")]
        [HttpPost]
        public HttpResponseMessage DeleteCustomerBranch([FromBody]customerBranchRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customers_branchService objComService = new customers_branchService();
                var CustomerResponse = objComService.DeleteCustomerBranch(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.CustomerBranchID + " Branch Name :" + request.BranchName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Branch Name : " + request.BranchName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.BranchName + ".");

            }
            return response;
        }

    }
}
