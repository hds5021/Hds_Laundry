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
    public class EmployeeMasterController : ApiController
    {
        
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Employee Master

        [Authorize]
        [Route("GetEmployeeMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetEmployeeMasterDetail([FromBody]clsEmployeeMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Empid + " Employee Name :" + request.firstname);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                EmployeeMasterService objComService = new EmployeeMasterService();
                var objResponse = objComService.GetEmployeeMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Empid + " Employee Name :" + request.firstname);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Employee Name : " + request.firstname + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.firstname + ".");

            }
            return response;
        }


        [Authorize]
        [Route("GetEmployeeMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetEmployeeMasterDetailById([FromBody]clsEmployeeMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Empid + " Employee Name :" + request.firstname);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                EmployeeMasterService objComService = new EmployeeMasterService();
                var objResponse = objComService.GetEmployeeMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Empid + " Employee Name :" + request.firstname);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Employee Name : " + request.firstname + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.firstname + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetEmployeeUserMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetEmployeeUserMasterDetailById([FromBody]clsEmployee_UserMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Empid + " Employee Name :" + request.firstname);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                EmployeeMasterService objComService = new EmployeeMasterService();
                var objResponse = objComService.GetEmployeeUserMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Empid + " Employee Name :" + request.firstname);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Employee Name : " + request.firstname + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.firstname + ".");

            }
            return response;
        }



        //[Authorize]
        //[Route("GetUserMasterDetailById")]
        //[HttpPost]
        //public HttpResponseMessage GetUserMasterDetailById([FromBody]clsEmployee_UserMaster request)
        //{

        //    LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Empid + " Employee Name :" + request.firstname);
        //    HttpResponseMessage response = new HttpResponseMessage();
        //    try
        //    {
        //        EmployeeMasterService objComService = new EmployeeMasterService();
        //        var objResponse = objComService.GetUserMasterDetailById(request);
        //        if (objResponse != null && objResponse.ToString() != "")
        //        {
        //            response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
        //            LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Empid + " Employee Name :" + request.firstname);
        //        }
        //        else
        //        {
        //            response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Employee Name : " + request.firstname + ".");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggerFactory.LoggerInstance.LogException(ex);
        //        response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.firstname + ".");

        //    }
        //    return response;
        //}



        [Authorize]
        [Route("InsertEmployeeMaster")]
        [HttpPost]
        public HttpResponseMessage InsertEmployeeMaster([FromBody]clsEmployeeMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Empid + " Employee Name :" + request.firstname);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                EmployeeMasterService objComService = new EmployeeMasterService();
                var objResponse = objComService.InsertEmployeeMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Empid + " Employee Name :" + request.firstname);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Employee Name : " + request.firstname + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.firstname + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateEmployeeMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateEmployeeMaster([FromBody]clsEmployeeMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Empid + " Employee Name :" + request.firstname);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                EmployeeMasterService objComService = new EmployeeMasterService();
                var objResponse = objComService.UpdateEmployeeMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Empid + " Employee Name :" + request.firstname);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Employee Name : " + request.firstname + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.firstname + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteEmployeeMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteEmployeeMaster([FromBody]clsEmployeeMaster request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.Empid + " Employee Name :" + request.firstname);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                EmployeeMasterService objComService = new EmployeeMasterService();
                var objResponse = objComService.DeleteEmployeeMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.Empid + " Employee Name :" + request.firstname);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Employee Name : " + request.firstname + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Branch Name " + request.firstname + ".");

            }
            return response;
        }

    }
}
