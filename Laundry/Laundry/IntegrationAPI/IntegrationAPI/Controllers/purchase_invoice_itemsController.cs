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
    public class purchase_invoice_itemsController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetPurchaseInvoiceItemsDetail")]
        [HttpPost]
        public HttpResponseMessage GetPurchaseInvoiceItemsDetail([FromBody]clspurchaseInvoiceItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceItemID );
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoice_itemsService objComService = new purchase_invoice_itemsService();
                var objResponse = objComService.GetPurchaseInvoiceItemsDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceItemID );
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.InvoiceItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.InvoiceItemID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetPurchaseInvoiceItemsDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPurchaseInvoiceItemsDetailById([FromBody]clspurchaseInvoiceItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoice_itemsService objComService = new purchase_invoice_itemsService();
                var objResponse = objComService.GetPurchaseInvoiceItemsDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.InvoiceItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.InvoiceItemID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertPurchaseInvoiceItems")]
        [HttpPost]
        public HttpResponseMessage InsertPurchaseInvoiceItems([FromBody]clspurchaseInvoiceItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoice_itemsService objComService = new purchase_invoice_itemsService();
                var objResponse = objComService.InsertPurchaseInvoiceItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.InvoiceItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.InvoiceItemID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdatePurchaseInvoiceItems")]
        [HttpPost]
        public HttpResponseMessage UpdatePurchaseInvoiceItems([FromBody]clspurchaseInvoiceItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoice_itemsService objComService = new purchase_invoice_itemsService();
                var objResponse = objComService.UpdatePurchaseInvoiceItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.InvoiceItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.InvoiceItemID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeletePurchaseInvoiceItems")]
        [HttpPost]
        public HttpResponseMessage DeletePurchaseInvoiceItems([FromBody]clspurchaseInvoiceItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.InvoiceItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_invoice_itemsService objComService = new purchase_invoice_itemsService();
                var objResponse = objComService.DeletePurchaseInvoiceItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.InvoiceItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   ID : " + request.InvoiceItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  ID " + request.InvoiceItemID + ".");

            }
            return response;
        }


    }
}
