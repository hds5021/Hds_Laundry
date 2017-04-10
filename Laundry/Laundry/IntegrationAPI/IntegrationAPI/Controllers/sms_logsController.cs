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
    public class sms_logsController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetSMSLogsDetail")]
        [HttpPost]
        public HttpResponseMessage GetSMSLogsDetail([FromBody]clssmslogs request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsLogID + " sms id :" + request.SmsID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_logsService objComService = new sms_logsService();
                var objResponse = objComService.GetSMSLogsDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsLogID + "   sms id  :" + request.SmsID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  sms id  : " + request.SmsID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting sms id " + request.SmsID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetSMSLogsDetailById")]
        [HttpPost]
        public HttpResponseMessage GetSMSLogsDetailById([FromBody]clssmslogs request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsLogID + " sms id :" + request.SmsID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_logsService objComService = new sms_logsService();
                var objResponse = objComService.GetSMSLogsDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsLogID + "   sms id  :" + request.SmsID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  sms id  : " + request.SmsID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting sms id " + request.SmsID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertSMSLogsMaster")]
        [HttpPost]
        public HttpResponseMessage InsertSMSLogsMaster([FromBody]clssmslogs request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsLogID + " sms id :" + request.SmsID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_logsService objComService = new sms_logsService();
                var objResponse = objComService.InsertSMSLogsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsLogID + "   sms id  :" + request.SmsID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  sms id  : " + request.SmsID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting sms id " + request.SmsID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateSMSLogsMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateSMSLogsMaster([FromBody]clssmslogs request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsLogID + " sms id :" + request.SmsID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_logsService objComService = new sms_logsService();
                var objResponse = objComService.UpdateSMSLogsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsLogID + "   sms id  :" + request.SmsID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  sms id  : " + request.SmsID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting sms id " + request.SmsID + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteSMSLogsMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteSMSLogsMaster([FromBody]clssmslogs request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsLogID + " sms id :" + request.SmsID);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_logsService objComService = new sms_logsService();
                var objResponse = objComService.DeleteSMSLogsMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsLogID + "   sms id  :" + request.SmsID);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for  sms id  : " + request.SmsID + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting sms id " + request.SmsID + ".");

            }
            return response;
        }

        
    }
}
