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
    public class expensesController : ApiController
    {
        /// <summary>
        /// Created Date : 03/03/2017
        /// <param name="request">http://localhost:52761/GetCustomerBranchDetail </param>
        /// <returns></returns>
        /// </summary>

        /// Expenses 

        [Authorize]
        [Route("GetExpensesDetail")]
        [HttpPost]
        public HttpResponseMessage GetExpensesDetail([FromBody]clsexpenses request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseID + " Item ID :" + request.ItemId);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                expensesService objComService = new expensesService();
                var objResponse = objComService.GetExpensesDetail(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseID + " Item ID :" + request.ItemId);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item ID : " + request.ItemId + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemId + ".");

            }
            return response;
        }

        [Authorize]
        [Route("GetExpensesDetailById")]
        [HttpPost]
        public HttpResponseMessage GetExpensesDetailById([FromBody]clsexpenses request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseID + " Item ID :" + request.ItemId);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                expensesService objComService = new expensesService();
                var objResponse = objComService.GetExpensesDetailById(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseID + " Item ID :" + request.ItemId);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item ID : " + request.ItemId + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemId + ".");

            }
            return response;
        }

        [Authorize]
        [Route("InsertExpenses")]
        [HttpPost]
        public HttpResponseMessage InsertExpenses([FromBody]clsexpenses request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseID + " Item ID :" + request.ItemId);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                expensesService objComService = new expensesService();
                var objResponse = objComService.InsertExpenses(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseID + " Item ID :" + request.ItemId);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item ID : " + request.ItemId + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemId + ".");

            }
            return response;
        }

        [Authorize]
        [Route("UpdateExpenses")]
        [HttpPost]
        public HttpResponseMessage UpdateExpenses([FromBody]clsexpenses request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseID + " Item ID :" + request.ItemId);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                expensesService objComService = new expensesService();
                var objResponse = objComService.UpdateExpenses(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseID + " Item ID :" + request.ItemId);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item ID : " + request.ItemId + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemId + ".");

            }
            return response;
        }

        [Authorize]
        [Route("DeleteExpenses")]
        [HttpPost]
        public HttpResponseMessage DeleteExpenses([FromBody]clsexpenses request)
        {

            LoggerFactory.LoggerInstance.LogDebug("Request Started for : " + request.ExpenseID + " Item ID :" + request.ItemId);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                expensesService objComService = new expensesService();
                var objResponse = objComService.DeleteExpenses(request);
                if (objResponse != null && objResponse.ToString() != "")
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                    LoggerFactory.LoggerInstance.LogDebug("Request End for : " + request.ExpenseID + " Item ID :" + request.ItemId);
                }
                else
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "No detail found  for Item ID : " + request.ItemId + ".");
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured while getting Item Name " + request.ItemId + ".");

            }
            return response;
        }
    }
}
