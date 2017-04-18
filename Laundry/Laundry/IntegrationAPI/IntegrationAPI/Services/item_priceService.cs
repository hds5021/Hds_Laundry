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
    public class item_priceService
    {

        ///<summary>
        ///item_price
        /// </summary>
        /// 

        public string GetItemPriceDetail(clsitemPrice obj)
        {
            string result = "";
            try
            {
                item_price_Entity objEntities = new item_price_Entity();
                SP_item_price_SelectAllResult objResult = new SP_item_price_SelectAllResult();
                objResult = objEntities.GetItemPriceDetail(obj);
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
        public string GetItemPriceById(clsitemPrice obj)
        {
            string result = "";
            try
            {
                item_price_Entity objEntities = new item_price_Entity();
                SP_item_price_SelectOneResult objResult = new SP_item_price_SelectOneResult();
                objResult = objEntities.GetItemPriceById(obj);
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
        public string GetItemPriceByItemId(clsitemPrice obj)
        {
            string result = "";
            try
            {
                item_price_Entity objEntities = new item_price_Entity();
                List<SP_item_price_SelectByItemIdResult> objResult = new List<SP_item_price_SelectByItemIdResult>();
                objResult = objEntities.GetItemPriceByItemId(obj);
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

        public string InsertItemPrice  (clsitemPrice obj)
        {
            string result = "";
            try
            {
                item_price_Entity objEntities = new item_price_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertItemPrice(obj);
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

        public string UpdateItemPrice(clsitemPrice obj)
        {
            string result = "";
            try
            {
                item_price_Entity objEntities = new item_price_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateItemPrice(obj);
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

        public string DeleteItemPrice(clsitemPrice obj)
        {
            string result = "";
            try
            {
                item_price_Entity objEntities = new item_price_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteItemPrice(obj);
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

        public string DeleteItemPriceByItemId(clsitemPrice obj)
        {
            string result = "";
            try
            {
                item_price_Entity objEntities = new item_price_Entity();
                long objdeleteResult;
                objdeleteResult = objEntities.DeleteItemPriceByItemId(obj);
                result = objdeleteResult.ToJSON();

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