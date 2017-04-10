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
    public class posbillcountService
    {
        ///<summary>
        ///posbillcount
        /// </summary>
        /// 

        public string GetPosBillCountDetail(clsposbillcount obj)
        {
            string result = "";
            try
            {
                posbillcount_Entity objEntities = new posbillcount_Entity();
                SP_posbillcount_SelectAllResult objResult = new SP_posbillcount_SelectAllResult();
                objResult = objEntities.GetPosBillCountDetail(obj);
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
        public string GetPosBillCountDetailById(clsposbillcount obj)
        {
            string result = "";
            try
            {
                posbillcount_Entity objEntities = new posbillcount_Entity();
                SP_posbillcount_SelectOneResult objResult = new SP_posbillcount_SelectOneResult();
                objResult = objEntities.GetPosBillCountDetailById(obj);
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

        public string InsertPosBillCount(clsposbillcount obj)
        {
            string result = "";
            try
            {
                posbillcount_Entity objEntities = new posbillcount_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertPosBillCount(obj);
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

        public string UpdatePosBillCount(clsposbillcount obj)
        {
            string result = "";
            try
            {
                posbillcount_Entity objEntities = new posbillcount_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatePosBillCount(obj);
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

        public string DeletePosBillCount(clsposbillcount obj)
        {
            string result = "";
            try
            {
                posbillcount_Entity objEntities = new posbillcount_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeletePosBillCount(obj);
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