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
    public class itemsService
    {
        ///<summary>
        ///items
        /// </summary>
        /// 

        public string GetItemDetail(clsitems obj)
        {
            string result = "";
            try
            {
                items_Entity objEntities = new items_Entity();
                List<SP_items_SelectAllResult> objResult = new List<SP_items_SelectAllResult>();
                objResult = objEntities.GetItemDetail(obj);
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
        public string GetItemDetailBySearch(string searchString)
        {
            string result = "";
            try
            {
                items_Entity objEntities = new items_Entity();
                List<SP_Items_SearchResult> objResult = new List<SP_Items_SearchResult>();
                objResult = objEntities.GetItemDetailBySearch(searchString);
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
        public string GetItemDetailById(clsitems obj)
        {
            string result = "";
            try
            {
                items_Entity objEntities = new items_Entity();
                List<SP_items_SelectOneResult> objResult = new List<SP_items_SelectOneResult>();
                objResult = objEntities.GetItemDetailById(obj);
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

        public string InsertItems(clsitems obj)
        {
            string result = "";
            try
            {
                items_Entity objEntities = new items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertItems(obj);
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

        public string UpdatetItems(clsitems obj)
        {
            string result = "";
            try
            {
                items_Entity objEntities = new items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatetItems(obj);
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

        public string DeleteItems(clsitems obj)
        {
            string result = "";
            try
            {
                items_Entity objEntities = new items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteItems(obj);
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