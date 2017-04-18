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
        [Route("GetItemPriceByItemId")]
        [HttpPost]
        public HttpResponseMessage GetItemPriceByItemId([FromBody]clsitemPrice request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for ItemId: " + request.ItemID + "  Price :" + request.Price);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                item_priceService objComService = new item_priceService();
                var objResponse = objComService.GetItemPriceByItemId(request);
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
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemPriceID + "  Price :" + request.Price);

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
        [Route("InsertItemPriceList")]
        [HttpPost]
        public HttpResponseMessage InsertItemPriceList([FromBody]List<clsitemPrice> request)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                item_priceService objComService;
                if (request.Count > 0)
                {
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request[0].ItemPriceID + "  Price :" + request[0].Price);
                    objComService = new item_priceService();
                    var objResponse = objComService.DeleteItemPriceByItemId(request[0]);
                }
                for (int i = 0; i < request.Count; i++)
                {
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request[i].ItemPriceID + "  Price :" + request[i].Price);
                    objComService = new item_priceService();
                    var objResponse = objComService.InsertItemPrice(request[i]);
                    if (objResponse != null && objResponse.ToString() != "")
                    {
                        response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                        LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request[i].ItemPriceID + "  Price :" + request[i].Price);
                    }
                    else
                    {
                        response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Price : " + request[i].Price + ".");
                    }
                }
            }

            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Price " + request[0].Price + ".");
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
