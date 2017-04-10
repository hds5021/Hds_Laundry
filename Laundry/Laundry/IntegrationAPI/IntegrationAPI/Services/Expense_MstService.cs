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
    public class Expense_MstService
    {
        ///<summary>
        ///Expense_Mst
        /// </summary>
        /// 
        public string GetExpenseMasterDetail(clsExpense_Mst obj)
        {
            string result = "";
            try
            {
                Expense_Mst_Entity objEntities = new Expense_Mst_Entity();
                List<SP_Expense_Mst_SelectAllResult> objResult = new List<SP_Expense_Mst_SelectAllResult>();
                objResult = objEntities.GetExpenseMasterDetail(obj);
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
        public string GetExpenseMasterDetailById(clsExpense_Mst obj)
        {
            string result = "";
            try
            {
                Expense_Mst_Entity objEntities = new Expense_Mst_Entity();
                List<SP_Expense_Mst_SelectOneResult> objResult = new List<SP_Expense_Mst_SelectOneResult>();
                objResult = objEntities.GetExpenseMasterDetailById(obj);
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

        public string InsertExpenseMaster(clsExpense_Mst obj)
        {
            string result = "";
            try
            {
                Expense_Mst_Entity objEntities = new Expense_Mst_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertExpenseMaster(obj);
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

        public string UpdateExpenseMaster(clsExpense_Mst obj)
        {
            string result = "";
            try
            {
                Expense_Mst_Entity objEntities = new Expense_Mst_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateExpenseMaster(obj);
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

        public string DeleteExpenseMaster(clsExpense_Mst obj)
        {
            string result = "";
            try
            {
                Expense_Mst_Entity objEntities = new Expense_Mst_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteExpenseMaster(obj);
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