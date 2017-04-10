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
    public class Expense_MstController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Expense_Mst Master

        [Authorize]
        [Route("GetExpenseMasterDetail")]
        [HttpPost]
        public HttpResponseMessage GetExpenseMasterDetail([FromBody]clsExpense_Mst request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                Expense_MstService objComService = new Expense_MstService();
                var objResponse = objComService.GetExpenseMasterDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetExpenseMasterDetailById")]
        [HttpPost]
        public HttpResponseMessage GetExpenseMasterDetailById([FromBody]clsExpense_Mst request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                Expense_MstService objComService = new Expense_MstService();
                var objResponse = objComService.GetExpenseMasterDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemName + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertExpenseMaster")]
        [HttpPost]
        public HttpResponseMessage InsertExpenseMaster([FromBody]clsExpense_Mst request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                Expense_MstService objComService = new Expense_MstService();
                var objResponse = objComService.InsertExpenseMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("UpdateExpenseMaster")]
        [HttpPost]
        public HttpResponseMessage UpdateExpenseMaster([FromBody]clsExpense_Mst request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                Expense_MstService objComService = new Expense_MstService();
                var objResponse = objComService.UpdateExpenseMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemName + ".");

            }
            return response;
        }


        [Authorize]
        [Route("DeleteExpenseMaster")]
        [HttpPost]
        public HttpResponseMessage DeleteExpenseMaster([FromBody]clsExpense_Mst request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                Expense_MstService objComService = new Expense_MstService();
                var objResponse = objComService.DeleteExpenseMaster(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseItemID + " Item Name :" + request.ItemName);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item Name : " + request.ItemName + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemName + ".");

            }
            return response;
        }

    }
}
