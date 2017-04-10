using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntegrationAPI.Partial;
using IntegrationAPI.Models;
using IntegrationAPI.Helpers;
using Integration_Repository;
using System.Data;


namespace IntegrationAPI.Services
{
    public class expensesService
    {
        ///<summary>
        ///expenses
        /// </summary>
        /// 

        public string GetExpensesDetail(clsexpenses obj)
        {
            string result = "";
            try
            {
                expenses_Entity objEntities = new expenses_Entity();
                List<SP_expenses_SelectAllResult> objResult = new List<SP_expenses_SelectAllResult>();
                objResult = objEntities.GetExpensesDetail(obj);
                result = objResult.ToJSON();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }
        public string GetExpensesDetailById(clsexpenses obj)
        {
            string result = "";
            try
            {
                expenses_Entity objEntities = new expenses_Entity();
                List<SP_expenses_SelectOneResult> objResult = new List<SP_expenses_SelectOneResult>();
                objResult = objEntities.GetExpensesDetailById(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string InsertExpenses(clsexpenses obj)
        {
            string result = "";
            try
            {
                expenses_Entity objEntities = new expenses_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertExpenses(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string UpdateExpenses(clsexpenses obj)
        {
            string result = "";
            try
            {
                expenses_Entity objEntities = new expenses_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateExpenses(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string DeleteExpenses(clsexpenses obj)
        {
            string result = "";
            try
            {
                expenses_Entity objEntities = new expenses_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteExpenses(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

    }
}