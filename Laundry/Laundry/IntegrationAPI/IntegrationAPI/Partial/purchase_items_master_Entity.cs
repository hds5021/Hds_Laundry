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
    public class purchase_items_master_Entity : DbContext
    {
        ///<summary>
        ///purchase_items_master
        /// </summary>
        /// 
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual List<SP_purchase_items_master_SelectAllResult> GetPurchaseItemsMasterDetail(clspurchaseItemsMaster obj)
        {
            ISingleResult<SP_purchase_items_master_SelectAllResult> objResult;
            List<SP_purchase_items_master_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_purchase_items_master_SelectAll();
                objResultList = new List<SP_purchase_items_master_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual List<SP_purchase_items_master_SelectOneResult> GetPurchaseItemsMasterDetailById(clspurchaseItemsMaster obj)
        {
            ISingleResult<SP_purchase_items_master_SelectOneResult> objResult;
            List<SP_purchase_items_master_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_purchase_items_master_SelectOne(obj.PurchaseItemID);
                objResultList = new List<SP_purchase_items_master_SelectOneResult>(objResult);
            }
            //SP_purchase_items_master_SelectOneResult objResult = new SP_purchase_items_master_SelectOneResult();
            //try
            //{

            //    objResult = (SP_purchase_items_master_SelectOneResult)db.SP_purchase_items_master_SelectOne(obj.PurchaseItemID);
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual long InsertPurchaseItemsMaster(clspurchaseItemsMaster obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_purchase_items_master_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.ItemName, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdatePurchaseItemsMaster(clspurchaseItemsMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_purchase_items_master_Update(obj.PurchaseItemID, obj.InstanceID, obj.UserID, obj.ItemName, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeletePurchaseItemsMaster(clspurchaseItemsMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_purchase_items_master_Delete(obj.PurchaseItemID);
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