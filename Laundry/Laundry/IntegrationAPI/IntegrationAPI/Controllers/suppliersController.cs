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
    public class suppliersController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetSuppliersDetail")]
        [HttpPost]
        public HttpResponseMessage GetSuppliersDetail([FromBody]clssuppliers request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SupplierID + " Party name :" + request.SupplierName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                suppliersService objComService = new suppliersService();
                var objResponse = objComService.GetSuppliersDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SupplierID + "   Party name :" + request.SupplierName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.SupplierName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SupplierName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetSuppliersDetailBYId")]
        [HttpPost]
        public HttpResponseMessage GetSuppliersDetailBYId([FromBody]clssuppliers request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SupplierID + " Party name :" + request.SupplierName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                suppliersService objComService = new suppliersService();
                var objResponse = objComService.GetSuppliersDetailBYId(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SupplierID + "   Party name :" + request.SupplierName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.SupplierName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SupplierName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertSupplier")]
        [HttpPost]
        public HttpResponseMessage InsertSupplier([FromBody]clssuppliers request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SupplierID + " Party name :" + request.SupplierName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                suppliersService objComService = new suppliersService();
                var objResponse = objComService.InsertSupplier(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SupplierID + "   Party name :" + request.SupplierName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.SupplierName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SupplierName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateSupplier")]
        [HttpPost]
        public HttpResponseMessage UpdateSupplier([FromBody]clssuppliers request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SupplierID + " Party name :" + request.SupplierName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                suppliersService objComService = new suppliersService();
                var objResponse = objComService.UpdateSupplier(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SupplierID + "   Party name :" + request.SupplierName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.SupplierName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SupplierName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteSupplier")]
        [HttpPost]
        public HttpResponseMessage DeleteSupplier([FromBody]clssuppliers request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SupplierID + " Party name :" + request.SupplierName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                suppliersService objComService = new suppliersService();
                var objResponse = objComService.DeleteSupplier(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SupplierID + "   Party name :" + request.SupplierName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.SupplierName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.SupplierName + ".");

            }
            return response;
        }


    }
}
