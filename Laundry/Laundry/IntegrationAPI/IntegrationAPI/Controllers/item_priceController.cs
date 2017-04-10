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
    public class item_priceController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Instance_Setting 

        [Authorize]
        [Route("GetItemPriceDetail")]
        [HttpPost]
        public HttpResponseMessage GetItemPriceDetail([FromBody]clsitemPrice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemPriceID + "  Price :" + request.Price);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                item_priceService objComService = new item_priceService();
                var objResponse = objComService.GetItemPriceDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemPriceID + "  Price :" + request.Price);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Price : " + request.Price + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Price " + request.Price + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetItemPriceById")]
        [HttpPost]
        public HttpResponseMessage GetItemPriceById([FromBody]clsitemPrice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemPriceID + "  Price :" + request.Price);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                item_priceService objComService = new item_priceService();
                var objResponse = objComService.GetItemPriceById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemPriceID + "  Price :" + request.Price);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Price : " + request.Price + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Price " + request.Price + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertItemPrice")]
        [HttpPost]
        public HttpResponseMessage InsertItemPrice([FromBody]clsitemPrice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemPriceID + "  Price :" + request.Price);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                item_priceService objComService = new item_priceService();
                var objResponse = objComService.InsertItemPrice(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemPriceID + "  Price :" + request.Price);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Price : " + request.Price + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Price " + request.Price + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateItemPrice")]
        [HttpPost]
        public HttpResponseMessage UpdateItemPrice([FromBody]clsitemPrice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemPriceID + "  Price :" + request.Price);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                item_priceService objComService = new item_priceService();
                var objResponse = objComService.UpdateItemPrice(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemPriceID + "  Price :" + request.Price);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Price : " + request.Price + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Price " + request.Price + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteItemPrice")]
        [HttpPost]
        public HttpResponseMessage DeleteItemPrice([FromBody]clsitemPrice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemPriceID + "  Price :" + request.Price);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                item_priceService objComService = new item_priceService();
                var objResponse = objComService.DeleteItemPrice(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemPriceID + "  Price :" + request.Price);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Price : " + request.Price + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Price " + request.Price + ".");

            }
            return response;
        }

    }
}
