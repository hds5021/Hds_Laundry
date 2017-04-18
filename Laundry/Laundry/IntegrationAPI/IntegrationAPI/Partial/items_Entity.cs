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
    public class items_Entity : DbContext
    {
        ///<summary>
        ///items
        /// </summary>
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual List<SP_items_SelectAllResult> GetItemDetail(clsitems obj)
        {
            ISingleResult<SP_items_SelectAllResult> objResult;
            List<SP_items_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_items_SelectAll();
                objResultList = new List<SP_items_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual List<SP_Items_SearchResult> GetItemDetailBySearch(string searchString)
        {
            ISingleResult<SP_Items_SearchResult> objResult;
            List<SP_Items_SearchResult> objResultList;
            try
            {
                objResult = db.SP_Items_Search(searchString);
                objResultList = new List<SP_Items_SearchResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual List<SP_items_SelectOneResult> GetItemDetailById(clsitems obj)
        {
            ISingleResult<SP_items_SelectOneResult> objResult;
            List<SP_items_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_items_SelectOne(obj.ItemID);
                objResultList = new List<SP_items_SelectOneResult>(objResult);
            }
            //SP_items_SelectOneResult objResult = new SP_items_SelectOneResult();
            //try
            //{

            //    objResult = (SP_items_SelectOneResult)db.SP_items_SelectOne(obj.ItemID);
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertItems(clsitems obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_items_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.CustomerID, obj.ItemName, obj.ItemLocalName, obj.PriceRate, obj.Status, obj.CreatedDate);
                result = Convert.ToInt32(resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdatetItems(clsitems obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_items_Update(obj.ItemID, obj.InstanceID, obj.UserID, obj.CustomerID, obj.ItemName, obj.ItemLocalName, obj.PriceRate, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteItems(clsitems obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_items_Delete(obj.ItemID);
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