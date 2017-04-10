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
    public class pos_itemsService
    {
        ///<summary>
        ///pos_items
        /// </summary>
        /// 

        public string GetPosItemsDetail(clsposItems obj)
        {
            string result = "";
            try
            {
                pos_items_Entity objEntities = new pos_items_Entity();
                SP_pos_items_SelectAllResult objResult = new SP_pos_items_SelectAllResult();
                objResult = objEntities.GetPosItemsDetail(obj);
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
        public string GetPosItemsDetailById(clsposItems obj)
        {
            string result = "";
            try
            {
                pos_items_Entity objEntities = new pos_items_Entity();
                SP_pos_items_SelectOneResult objResult = new SP_pos_items_SelectOneResult();
                objResult = objEntities.GetPosItemsDetailById(obj);
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

        public string InsertPosItems(clsposItems obj)
        {
            string result = "";
            try
            {
                pos_items_Entity objEntities = new pos_items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertPosItems(obj);
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

        public string UpdatePosItems(clsposItems obj)
        {
            string result = "";
            try
            {
                pos_items_Entity objEntities = new pos_items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatePosItems(obj);
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

        public string DeletePosItems(clsposItems obj)
        {
            string result = "";
            try
            {
                pos_items_Entity objEntities = new pos_items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeletePosItems(obj);
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