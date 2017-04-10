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
    public class UserRightsMasterController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetUserRightsMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetUserRightsMasterDetail([FromBody]clsUserRightsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Urid );
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserRightsMasterService objComService = new UserRightsMasterService();
                var objResponse = objComService.GetUserRightsMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Urid);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.Urid + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Id " + request.Urid + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetUserRightsMasterDetailByid")]
        [HttpPost]
        public HttpResponseMessage GetUserRightsMasterDetailByid([FromBody]clsUserRightsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Urid);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserRightsMasterService objComService = new UserRightsMasterService();
                var objResponse = objComService.GetUserRightsMasterDetailByid(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Urid);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.Urid + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Id " + request.Urid + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertUserRightsMaster")]
        [HttpPost]
        public HttpResponseMessage InsertUserRightsMaster([FromBody]clsUserRightsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Urid);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserRightsMasterService objComService = new UserRightsMasterService();
                var objResponse = objComService.InsertUserRightsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Urid);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.Urid + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Id " + request.Urid + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateUserRightsMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateUserRightsMaster([FromBody]clsUserRightsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Urid);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserRightsMasterService objComService = new UserRightsMasterService();
                var objResponse = objComService.UpdateUserRightsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Urid);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.Urid + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Id " + request.Urid + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteUserRightsMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteUserRightsMaster([FromBody]clsUserRightsMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Urid);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserRightsMasterService objComService = new UserRightsMasterService();
                var objResponse = objComService.DeleteUserRightsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Urid);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Id : " + request.Urid + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Id " + request.Urid + ".");

            }
            return response;
        }

    }
}
