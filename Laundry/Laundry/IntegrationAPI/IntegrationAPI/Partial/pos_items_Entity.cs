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
    public class pos_items_Entity: DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///pos_items
        /// </summary>
        /// 
        public virtual SP_pos_items_SelectAllResult GetPosItemsDetail(clsposItems obj)
        {
            SP_pos_items_SelectAllResult objResult = new SP_pos_items_SelectAllResult();
            try
            {

                objResult = (SP_pos_items_SelectAllResult)db.SP_pos_items_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual SP_pos_items_SelectOneResult GetPosItemsDetailById(clsposItems obj)
        {
            SP_pos_items_SelectOneResult objResult = new SP_pos_items_SelectOneResult();
            try
            {

                objResult = (SP_pos_items_SelectOneResult)db.SP_pos_items_SelectOne(obj.PosItemID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual List<SP_pos_items_SelectByPOSIdResult> GetPosItemsDetailByPOSId(clsposItems obj)
        {
            ISingleResult<SP_pos_items_SelectByPOSIdResult> objResult;
            List<SP_pos_items_SelectByPOSIdResult> objResultList;
            //SP_pos_items_SelectByPOSIdResult objResult = new SP_pos_items_SelectByPOSIdResult();
            try
            {

                objResult = db.SP_pos_items_SelectByPOSId(obj.PosID);
                objResultList = new List<SP_pos_items_SelectByPOSIdResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertPosItems(clsposItems obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_pos_items_Insert(ref resultID, obj.PosID, obj.ItemID, obj.GroupID, obj.ItemWidth, obj.ItemLength, obj.PriceRate, obj.Price, obj.Quantity, obj.TotalPrice);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdatePosItems(clsposItems obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_pos_items_Update(obj.PosItemID, obj.PosID, obj.ItemID, obj.GroupID, obj.ItemWidth, obj.ItemLength, obj.PriceRate, obj.Price, obj.Quantity, obj.TotalPrice);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeletePosItems(clsposItems obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_pos_items_Delete(obj.PosItemID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeletePosItemsByPosId(int posId)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_pos_items_Delete_ByPosId(posId);
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