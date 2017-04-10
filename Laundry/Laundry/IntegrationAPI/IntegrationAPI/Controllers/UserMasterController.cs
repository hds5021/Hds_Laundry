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
    public class UserMasterController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetUserMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetUserMasterDetail([FromBody]clsUserMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Userid + " Party name :" + request.Umusername);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserMasterService objComService = new UserMasterService();
                var objResponse = objComService.GetUserMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Userid + "   Party name :" + request.Umusername);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.Umusername + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.Umusername + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetUserMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetUserMasterDetailById([FromBody]clsUserMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Userid + " Party name :" + request.Umusername);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserMasterService objComService = new UserMasterService();
                var objResponse = objComService.GetUserMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Userid + "   Party name :" + request.Umusername);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.Umusername + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.Umusername + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertUserMaster")]
        [HttpPost]
        public HttpResponseMessage InsertUserMaster([FromBody]clsUserMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Userid + " Party name :" + request.Umusername);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserMasterService objComService = new UserMasterService();
                var objResponse = objComService.InsertUserMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Userid + "   Party name :" + request.Umusername);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.Umusername + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.Umusername + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateUserMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateUserMaster([FromBody]clsUserMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Userid + " Party name :" + request.Umusername);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserMasterService objComService = new UserMasterService();
                var objResponse = objComService.UpdateUserMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Userid + "   Party name :" + request.Umusername);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.Umusername + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.Umusername + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteUserMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteUserMaster([FromBody]clsUserMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Empid + " Party name :" + request.Umusername);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserMasterService objComService = new UserMasterService();
                var objResponse = objComService.DeleteUserMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Empid + "   Party name :" + request.Umusername);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Party name : " + request.Umusername + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Party name " + request.Umusername + ".");

            }
            return response;
        }



    }
}
