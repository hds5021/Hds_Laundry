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
    public class UserInfoController : ApiController
    {
        [Authorize]
        [Route("GetUserInfoDetail")]
        [HttpPost]
        public HttpResponseMessage GetUserInfoDetail([FromBody]clsUser_Info request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.UserID + " User Name :" + request.UserName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserService objComService = new UserService();
                var objResponse = objComService.GetUserInfoDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.UserID + "  User Name  :" + request.UserName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.UserName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.UserName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("GetUserInfoDetailById")]
        [HttpPost]
        public HttpResponseMessage GetUserInfoDetailById([FromBody]clsUser_Info request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.UserID + " User Name :" + request.UserName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserService objComService = new UserService();
                var objResponse = objComService.GetUserInfoDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.UserID + " Item Name :" + request.UserName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.UserName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.UserName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertUserInfo")]
        [HttpPost]
        public HttpResponseMessage InsertUserInfo([FromBody]clsUser_Info request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.UserID + " User Name :" + request.UserName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserService objComService = new UserService();
                var objResponse = objComService.InsertUserInfo(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.UserID + " User Name :" + request.UserName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.UserName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.UserName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateUserInfo")]
        [HttpPost]
        public HttpResponseMessage UpdateUserInfo([FromBody]clsUser_Info request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.UserID + " User Name :" + request.UserName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserService objComService = new UserService();
                var objResponse = objComService.UpdateUserInfo(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.UserID + " Item Name :" + request.UserName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.UserName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.UserName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteUserInfo")]
        [HttpPost]
        public HttpResponseMessage DeleteUserInfo([FromBody]clsUser_Info request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.UserID + " User Name :" + request.UserName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                UserService objComService = new UserService();
                var objResponse = objComService.DeleteUserInfo(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.UserID + " User Name :" + request.UserName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.UserName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.UserName + ".");

            }
            return response;
        }


    }
}
