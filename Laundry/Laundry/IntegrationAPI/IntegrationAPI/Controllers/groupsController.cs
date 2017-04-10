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
    
    public class groupsController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Expenses 

           

        [Authorize]
        [Route("GetgroupsDetail")]
        [HttpPost]
        public HttpResponseMessage GetgroupsDetail([FromBody]clsgroups request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.GroupID + " Group Name :" + request.GroupName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                groupsService objComService = new groupsService();
                var objResponse = objComService.GetgroupsDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.GroupID + " Group Name :" + request.GroupName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Group Name : " + request.GroupName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Group Name " + request.GroupName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetgroupsDetailById")]
        [HttpPost]
        public HttpResponseMessage GetgroupsDetailById([FromBody]clsgroups request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.GroupID + " Group Name :" + request.GroupName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                groupsService objComService = new groupsService();
                var objResponse = objComService.GetgroupsDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.GroupID + " Group Name :" + request.GroupName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Group Name : " + request.GroupName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Group Name " + request.GroupName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertGroups")]
        [HttpPost]
        public HttpResponseMessage InsertGroups([FromBody]clsgroups request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.GroupID + " Group Name :" + request.GroupName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                groupsService objComService = new groupsService();
                var objResponse = objComService.InsertGroups(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.GroupID + " Group Name :" + request.GroupName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Group Name : " + request.GroupName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Group Name " + request.GroupName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateGroups")]
        [HttpPost]
        public HttpResponseMessage UpdateGroups([FromBody]clsgroups request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.GroupID + " Group Name :" + request.GroupName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                groupsService objComService = new groupsService();
                var objResponse = objComService.UpdateGroups(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.GroupID + " Group Name :" + request.GroupName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Group Name : " + request.GroupName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Group Name " + request.GroupName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteGroups")]
        [HttpPost]
        public HttpResponseMessage DeleteGroups([FromBody]clsgroups request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.GroupID + " Group Name :" + request.GroupName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                groupsService objComService = new groupsService();
                var objResponse = objComService.DeleteGroups(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.GroupID + " Group Name :" + request.GroupName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Group Name : " + request.GroupName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Group Name " + request.GroupName + ".");

            }
            return response;
        }

        public void Post(List<string> val)//(Person obj )
        {
            try
            {
                //Person obj = new Person();
                //obj.Name = val[0];
                //obj.Address = val[1];
                //obj.DOB = Convert.ToDateTime(val[2]);
                //db.Persons.Add(obj);
                //db.SaveChanges();
            }
            catch (Exception) { }
        }

    }
}
