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
    public class purchase_items_masterController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetPurchaseItemsMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetPurchaseItemsMasterDetail([FromBody]clspurchaseItemsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PurchaseItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_items_masterService objComService = new purchase_items_masterService();
                var objResponse = objComService.GetPurchaseItemsMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PurchaseItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.PurchaseItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.PurchaseItemID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetPurchaseItemsMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPurchaseItemsMasterDetailById([FromBody]clspurchaseItemsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PurchaseItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_items_masterService objComService = new purchase_items_masterService();
                var objResponse = objComService.GetPurchaseItemsMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PurchaseItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.PurchaseItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.PurchaseItemID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertPurchaseItemsMaster")]
        [HttpPost]
        public HttpResponseMessage InsertPurchaseItemsMaster([FromBody]clspurchaseItemsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PurchaseItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_items_masterService objComService = new purchase_items_masterService();
                var objResponse = objComService.InsertPurchaseItemsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PurchaseItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.PurchaseItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.PurchaseItemID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdatePurchaseItemsMaster")]
        [HttpPost]
        public HttpResponseMessage UpdatePurchaseItemsMaster([FromBody]clspurchaseItemsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PurchaseItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_items_masterService objComService = new purchase_items_masterService();
                var objResponse = objComService.UpdatePurchaseItemsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PurchaseItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.PurchaseItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.PurchaseItemID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeletePurchaseItemsMaster")]
        [HttpPost]
        public HttpResponseMessage DeletePurchaseItemsMaster([FromBody]clspurchaseItemsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PurchaseItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                purchase_items_masterService objComService = new purchase_items_masterService();
                var objResponse = objComService.DeletePurchaseItemsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PurchaseItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.PurchaseItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Id " + request.PurchaseItemID + ".");

            }
            return response;
        }

    }
}
