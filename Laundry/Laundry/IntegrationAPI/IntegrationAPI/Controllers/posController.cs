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
    public class posController : ApiController
    {
        ///<summary>
        ///Pos
        /// </summary>
        /// 

        [Authorize]
        [Route("GetPosDetail")]
        [HttpPost]
        public HttpResponseMessage GetPosDetail([FromBody]clspos request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for :POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PosService objComService = new PosService();
                var objResponse = objComService.GetPosDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : POS ID:" + request.PosID);
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
        [Route("GetPosDetailByCustomer")]
        [HttpPost]
        public HttpResponseMessage GetPosDetailByCustomer()
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for :GetPosDetailByCustomer");
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PosService objComService = new PosService();
                var objResponse = objComService.GetPosDetailByCustomer();
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for :GetPosDetailByCustomer");
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   GetPosDetailByCustomer.");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting call GetPosDetailByCustomer");

            }
            return response;
        }

        [Authorize]
        [Route("GetPosDetailById")]
        [HttpPost]
        public HttpResponseMessage GetPosItemsDetailById([FromBody]clspos request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PosService objComService = new PosService();
                var objResponse = objComService.GetPosDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosID + "  POS ID:" + request.PosID);
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
        [Route("InsertPos")]
        [HttpPost]
        public HttpResponseMessage InsertPosItems([FromBody]clspos request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PosService objComService = new PosService();
                var objResponse = objComService.InsertPos(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosID + "  POS ID:" + request.PosID);
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
        [Route("UpdatePos")]
        [HttpPost]
        public HttpResponseMessage UpdatePosItems([FromBody]clspos request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PosService objComService = new PosService();
                var objResponse = objComService.UpdatePos(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosID + "  POS ID:" + request.PosID);
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
        [Route("DeletePos")]
        [HttpPost]
        public HttpResponseMessage DeletePosItems([FromBody]clspos request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.PosID + "POS ID :" + request.PosID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PosService objComService = new PosService();
                var objResponse = objComService.DeletePos(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.PosID + "  POS ID:" + request.PosID);
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
        [Route("GetItemGroupListByID")]
        [HttpPost]
        public HttpResponseMessage GetItemGroupListByID([FromBody]clsposItems request)
        {
            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                PosService objComService = new PosService();
                var CustomerResponse = objComService.GetItemGroupListByID(request);
                if (CustomerResponse != null && CustomerResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, CustomerResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ItemID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for requested Customer by ID : " + request.ItemID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Customer Detail by ID " + request.ItemID + ".");

            }
            return response;
        }

    }
}
