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
        [Route("GetPosItemsDetailByPOSId")]
        [HttpPost]
        public HttpResponseMessage GetPosItemsDetailByPOSId([FromBody]clsposItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosItemID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                pos_itemsService objComService = new pos_itemsService();
                var objResponse = objComService.GetPosItemsDetailByPOSId(request);
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
        [Route("InsertPosItemsList")]
        [HttpPost]
        public HttpResponseMessage InsertPosItemsList([FromBody]List<clsposItems> request)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                pos_itemsService objComService;
                if (request != null && request.Count > 0)
                {
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request[0].PosID);
                    objComService = new pos_itemsService();
                    var objResponse = objComService.DeletePosItemsByPosId(request[0]);

                }
                for (int i = 0; i < request.Count; i++)
                {
                    objComService = new pos_itemsService();
                    var objResponse = objComService.InsertPosItems(request[i]);
                    if (objResponse != null && objResponse.ToString() != "")
                    {
                        response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                        LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request[i].PosItemID);
                    }
                    else
                    {
                        response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  Price : " + request[i].PosID + ".");
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Pos ITEM Id " + request[0].PosID + ".");

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

        [Authorize]
        [Route("DeletePosItemsByPosId")]
        [HttpPost]
        public HttpResponseMessage DeletePosItemsByPosId([FromBody]clsposItems request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for POSId : " + request.PosID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                pos_itemsService objComService = new pos_itemsService();
                var objResponse = objComService.DeletePosItemsByPosId(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosItemID + "  POS ID:" + request.PosID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Pos ID : " + request.PosID + ".");
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
