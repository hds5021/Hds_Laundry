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
   public class itemsController : ApiController
    {/// <summary>
     /// Created Date : 03/03/2017
     /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
     /// <returns></returns>
     /// </summary>

        /// Items

        [Authorize]
        [Route("GetItemDetail")]
        [HttpPost]
        public HttpResponseMessage GetItemDetail([FromBody]clsitems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemID + "  Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                itemsService objComService = new itemsService();
                var objResponse = objComService.GetItemDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemID + "  Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Item Name " + request.ItemName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetItemDetailById")]
        [HttpPost]
        public HttpResponseMessage GetItemDetailById([FromBody]clsitems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemID + "  Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                itemsService objComService = new itemsService();
                var objResponse = objComService.GetItemDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemID + "  Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Item Name " + request.ItemName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertItems")]
        [HttpPost]
        public HttpResponseMessage InsertItems([FromBody]clsitems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemID + "  Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                itemsService objComService = new itemsService();
                var objResponse = objComService.InsertItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemID + "  Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Item Name " + request.ItemName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdatetItems")]
        [HttpPost]
        public HttpResponseMessage UpdatetItems([FromBody]clsitems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemID + "  Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                itemsService objComService = new itemsService();
                var objResponse = objComService.UpdatetItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemID + "  Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Item Name " + request.ItemName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteItems")]
        [HttpPost]
        public HttpResponseMessage DeleteItems([FromBody]clsitems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemID + "  Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                itemsService objComService = new itemsService();
                var objResponse = objComService.DeleteItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ItemID + "  Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting  Item Name " + request.ItemName + ".");

            }
            return response;
        }

    }
}
