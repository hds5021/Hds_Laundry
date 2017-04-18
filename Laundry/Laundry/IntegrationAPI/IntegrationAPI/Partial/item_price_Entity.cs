using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntegrationAPI.Services;
using IntegrationAPI.Models;
using IntegrationAPI.Helpers;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using Integration_Repository;
using System.Data.SqlClient;
using System.Data;
using System.Data.Linq;

namespace IntegrationAPI.Partial
{
    public class item_price_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///item Price
        /// </summary>
        public virtual SP_item_price_SelectAllResult GetItemPriceDetail(clsitemPrice obj)
        {
            SP_item_price_SelectAllResult objResult = new SP_item_price_SelectAllResult();
            try
            {

                objResult = (SP_item_price_SelectAllResult)db.SP_item_price_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual SP_item_price_SelectOneResult GetItemPriceById(clsitemPrice obj)
        {
            SP_item_price_SelectOneResult objResult = new SP_item_price_SelectOneResult();
            try
            {
                objResult = (SP_item_price_SelectOneResult)db.SP_item_price_SelectOne(obj.ItemPriceID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual List<SP_item_price_SelectByItemIdResult> GetItemPriceByItemId(clsitemPrice obj)
        {
            ISingleResult<SP_item_price_SelectByItemIdResult> objResult;
            List<SP_item_price_SelectByItemIdResult> objResultList;
            try
            {
                objResult = db.SP_item_price_SelectByItemId(obj.ItemID);
                objResultList = new List<SP_item_price_SelectByItemIdResult>(objResult.ToList());
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual long InsertItemPrice(clsitemPrice obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_item_price_Insert(ref resultID, obj.ItemID, obj.GroupID, obj.Price);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateItemPrice(clsitemPrice obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_item_price_Update(obj.ItemPriceID, obj.ItemID, obj.GroupID, obj.Price);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteItemPrice(clsitemPrice obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_item_price_Delete(obj.ItemPriceID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteItemPriceByItemId(clsitemPrice obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_item_price_DeleteByItemId(obj.ItemID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }



    }
}