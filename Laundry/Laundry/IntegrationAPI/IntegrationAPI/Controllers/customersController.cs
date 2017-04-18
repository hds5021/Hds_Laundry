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
    public class customersController : ApiController
    {

        /// <summary>
        /// Created Date : 01/09/2016
        /// Below method use for get Customer details based on Customer Number and Customer Name.
        /// <param name="request">http://localhost:52761/GetCustomerDetail </param>
        /// In Header need to pass Key Value  
        /// Request :{ "CustomerNumber": 0 ,  "CustomerName": "Test Account Sigma"}
        /// <returns></returns>
        /// </summary>

        [Authorize]
        [Route("GetCustomerDetail")]
        [HttpPost]
        public HttpResponseMessage GetCustomerDetail([FromBody]customerRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer Name :" + request.CustomerName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customersService objComService = new customersService();
                var CustomerResponse = objComService.getCustomerDetail(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.CustomerID + " Customer Name :" + request.CustomerName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for requested Customer : " + request.CustomerName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Customer Detail " + request.CustomerName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetCustomerByID")]
        [HttpPost]
        public HttpResponseMessage GetCustomerByID([FromBody]customerRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customersService objComService = new customersService();
                var CustomerResponse = objComService.getCustomerById(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for requested Customer by ID : " + request.CustomerID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Customer Detail by ID " + request.CustomerID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetCustomerDetailByContact")]
        [HttpPost]
        public HttpResponseMessage GetCustomerDetailByContact([FromBody]customerRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customersService objComService = new customersService();
                var CustomerResponse = objComService.getCustomerByContact(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for requested Customer by ID : " + request.CustomerID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Customer Detail by ID " + request.CustomerID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertCustomer")]
        [HttpPost]
        public HttpResponseMessage InsertCustomer([FromBody]customerRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customersService objComService = new customersService();
                var CustomerResponse = objComService.InsertCustomer(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for requested Customer by ID : " + request.CustomerID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Customer Detail by ID " + request.CustomerID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateCustomer")]
        [HttpPost]
        public HttpResponseMessage UpdateCustomer([FromBody]customerRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                customersService objComService = new customersService();
                var CustomerResponse = objComService.UpdateCustomer(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for requested Customer by ID : " + request.CustomerID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Customer Detail by ID " + request.CustomerID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteCustomer")]
        [HttpPost]
        public HttpResponseMessage DeleteCustomer([FromBody]customerRequest request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {

                customersService objComService = new customersService();
                var CustomerResponse = objComService.DeleteCustomer(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.CustomerID + " Customer name :" + request.CustomerName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for requested Customer by ID : " + request.CustomerID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Customer Detail by ID " + request.CustomerID + ".");

            }
            return response;
        }

       


    }
}
