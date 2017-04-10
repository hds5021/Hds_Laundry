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
    public class pos_itemsController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetPosItemsDetail")]
        [HttpPost]
        public HttpResponseMessage GetPosItemsDetail([FromBody]clsposItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosItemID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                pos_itemsService objComService = new pos_itemsService();
                var objResponse = objComService.GetPosItemsDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosItemID + "  POS ID:" + request.PosID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Pos Item ID : " + request.PosID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Pos ITEM Id " + request.PosID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetPosItemsDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPosItemsDetailById([FromBody]clsposItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosItemID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                pos_itemsService objComService = new pos_itemsService();
                var objResponse = objComService.GetPosItemsDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosItemID + "  POS ID:" + request.PosID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Pos Item ID : " + request.PosID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Pos ITEM Id " + request.PosID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertPosItems")]
        [HttpPost]
        public HttpResponseMessage InsertPosItems([FromBody]clsposItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosItemID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                pos_itemsService objComService = new pos_itemsService();
                var objResponse = objComService.InsertPosItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosItemID + "  POS ID:" + request.PosID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Pos Item ID : " + request.PosID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Pos ITEM Id " + request.PosID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdatePosItems")]
        [HttpPost]
        public HttpResponseMessage UpdatePosItems([FromBody]clsposItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosItemID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                pos_itemsService objComService = new pos_itemsService();
                var objResponse = objComService.UpdatePosItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosItemID + "  POS ID:" + request.PosID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Pos Item ID : " + request.PosID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Pos ITEM Id " + request.PosID + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeletePosItems")]
        [HttpPost]
        public HttpResponseMessage DeletePosItems([FromBody]clsposItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosItemID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                pos_itemsService objComService = new pos_itemsService();
                var objResponse = objComService.DeletePosItems(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosItemID + "  POS ID:" + request.PosID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Pos Item ID : " + request.PosID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Pos ITEM Id " + request.PosID + ".");

            }
            return response;
        }


    }
}
