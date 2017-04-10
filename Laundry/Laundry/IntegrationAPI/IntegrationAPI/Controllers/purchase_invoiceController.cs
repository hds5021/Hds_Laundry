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
    public class purchase_invoiceController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetPurchaseInvoiceDetail")]
        [HttpPost]
        public HttpResponseMessage GetPurchaseInvoiceDetail([FromBody]clspurchaseInvoice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceID );
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoiceService objComService = new purchase_invoiceService();
                var objResponse = objComService.GetPurchaseInvoiceDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceID );
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.InvoiceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.InvoiceID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetPurchaseInvoiceDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPurchaseInvoiceDetailById([FromBody]clspurchaseInvoice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoiceService objComService = new purchase_invoiceService();
                var objResponse = objComService.GetPurchaseInvoiceDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.InvoiceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.InvoiceID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertPurchaseInvoice")]
        [HttpPost]
        public HttpResponseMessage InsertPurchaseInvoice([FromBody]clspurchaseInvoice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoiceService objComService = new purchase_invoiceService();
                var objResponse = objComService.InsertPurchaseInvoice(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.InvoiceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.InvoiceID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdatePurchaseInvoice")]
        [HttpPost]
        public HttpResponseMessage UpdatePurchaseInvoice([FromBody]clspurchaseInvoice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoiceService objComService = new purchase_invoiceService();
                var objResponse = objComService.UpdatePurchaseInvoice(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.InvoiceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.InvoiceID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeletePurchaseInvoice")]
        [HttpPost]
        public HttpResponseMessage DeletePurchaseInvoice([FromBody]clspurchaseInvoice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoiceService objComService = new purchase_invoiceService();
                var objResponse = objComService.DeletePurchaseInvoice(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.InvoiceID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.InvoiceID + ".");

            }
            return response;
        }


    }

}
