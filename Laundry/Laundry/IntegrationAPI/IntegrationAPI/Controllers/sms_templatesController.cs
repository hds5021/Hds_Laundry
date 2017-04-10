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
    public class sms_templatesController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Menu Master

        [Authorize]
        [Route("GetSMSTemplatesDetail")]
        [HttpPost]
        public HttpResponseMessage GetSMSTemplatesDetail([FromBody]clssmsTemplates request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsID + " Template name :" + request.TemplateName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_templatesService objComService = new sms_templatesService();
                var objResponse = objComService.GetSMSTemplatesDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsID + "   Template name :" + request.TemplateName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Template name : " + request.TemplateName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Template name " + request.TemplateName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetSMSTemplatesDetailById")]
        [HttpPost]
        public HttpResponseMessage GetSMSTemplatesDetailById([FromBody]clssmsTemplates request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsID + " Template name :" + request.TemplateName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_templatesService objComService = new sms_templatesService();
                var objResponse = objComService.GetSMSTemplatesDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsID + "   Template name :" + request.TemplateName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Template name : " + request.TemplateName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Template name " + request.TemplateName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("InsertSMStemplates")]
        [HttpPost]
        public HttpResponseMessage InsertSMStemplates([FromBody]clssmsTemplates request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsID + " Template name :" + request.TemplateName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_templatesService objComService = new sms_templatesService();
                var objResponse = objComService.InsertSMStemplates(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsID + "   Template name :" + request.TemplateName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Template name : " + request.TemplateName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Template name " + request.TemplateName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateSMStemplates")]
        [HttpPost]
        public HttpResponseMessage UpdateSMStemplates([FromBody]clssmsTemplates request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsID + " Template name :" + request.TemplateName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_templatesService objComService = new sms_templatesService();
                var objResponse = objComService.UpdateSMStemplates(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsID + "   Template name :" + request.TemplateName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Template name : " + request.TemplateName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Template name " + request.TemplateName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteSMStemplates")]
        [HttpPost]
        public HttpResponseMessage DeleteSMStemplates([FromBody]clssmsTemplates request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.SmsID + " Template name :" + request.TemplateName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                sms_templatesService objComService = new sms_templatesService();
                var objResponse = objComService.DeleteSMStemplates(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.SmsID + "   Template name :" + request.TemplateName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for   Template name : " + request.TemplateName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting   Template name " + request.TemplateName + ".");

            }
            return response;
        }


    }
}
