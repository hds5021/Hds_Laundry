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
    public class purchase_items_masterService
    {
        ///<summary>
        ///purchase_items_master
        /// </summary>
        /// 
        public string GetPurchaseItemsMasterDetail(clspurchaseItemsMaster obj)
        {
            string result = "";
            try
            {
                purchase_items_master_Entity objEntities = new purchase_items_master_Entity();
                List<SP_purchase_items_master_SelectAllResult> objResult = new List<SP_purchase_items_master_SelectAllResult>();
                objResult = objEntities.GetPurchaseItemsMasterDetail(obj);
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
        public string GetPurchaseItemsMasterDetailById(clspurchaseItemsMaster obj)
        {
            string result = "";
            try
            {
                purchase_items_master_Entity objEntities = new purchase_items_master_Entity();
                List<SP_purchase_items_master_SelectOneResult> objResult = new List<SP_purchase_items_master_SelectOneResult>();
                objResult = objEntities.GetPurchaseItemsMasterDetailById(obj);
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

        public string InsertPurchaseItemsMaster(clspurchaseItemsMaster obj)
        {
            string result = "";
            try
            {
                purchase_items_master_Entity objEntities = new purchase_items_master_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertPurchaseItemsMaster(obj);
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

        public string UpdatePurchaseItemsMaster(clspurchaseItemsMaster obj)
        {
            string result = "";
            try
            {
                purchase_items_master_Entity objEntities = new purchase_items_master_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatePurchaseItemsMaster(obj);
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

        public string DeletePurchaseItemsMaster(clspurchaseItemsMaster obj)
        {
            string result = "";
            try
            {
                purchase_items_master_Entity objEntities = new purchase_items_master_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeletePurchaseItemsMaster(obj);
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