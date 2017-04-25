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
    public class pos_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///pos
        /// </summary>
        public virtual List<SP_pos_SelectAllResult> GetPosDetail(clspos obj)
        {
            ISingleResult<SP_pos_SelectAllResult> objResult;
            List<SP_pos_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_pos_SelectAll();
                objResultList = new List<SP_pos_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual SP_pos_SelectOneResult GetPosDetailById(clspos obj)
        {
            SP_pos_SelectOneResult objResult = new SP_pos_SelectOneResult();
            try
            {

                objResult = (SP_pos_SelectOneResult)db.SP_pos_items_SelectOne(obj.PosID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual List<SP_pos_Grid_SelectAllResult> GetItemGroupListByID(clsposItems obj)
        {

            ISingleResult<SP_pos_Grid_SelectAllResult> objResult;
            List<SP_pos_Grid_SelectAllResult> objResultList;
            try
            {

                objResult = db.SP_pos_Grid_SelectAll(obj.ItemID);
                objResultList = new List<SP_pos_Grid_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual long InsertPos(clspos obj)
        {
            long result = 0;
            long? resultID = 0;
            
            try
            {
                result = (long)db.SP_pos_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.BillNo, obj.CustomerID, obj.CustomerBranchID, obj.Type, obj.TotalQuantity, obj.TotalAmount, obj.Discount, obj.TotalPayable, obj.PaidAmount, obj.ReturnAmount, obj.IsPaid, obj.PaidBy, Convert.ToDateTime(obj.PaymentDateTime), obj.Status, obj.Comment, obj.HangerQuantity, obj.HangerRate, obj.HangerAmount, obj.IsClothCollected, obj.IsCarpetInvoice, obj.BillDate,obj.BillTime, obj.DeliveryDate,obj.DeliveryTime, obj.IsDeleted, Convert.ToDateTime(obj.DeletedDateTime), Convert.ToDateTime(obj.CreatedDate));
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdatePos(clspos obj)
        {
            int result = 0;
            
            try
            {
                result = (int)db.SP_pos_Update(obj.PosID, obj.InstanceID, obj.UserID, obj.BillNo, obj.CustomerID, obj.CustomerBranchID, obj.Type, obj.TotalQuantity, obj.TotalAmount, obj.Discount, obj.TotalPayable, obj.PaidAmount, obj.ReturnAmount, obj.IsPaid, obj.PaidBy, Convert.ToDateTime(obj.PaymentDateTime), obj.Status, obj.Comment, obj.HangerQuantity, obj.HangerRate, obj.HangerAmount, obj.IsClothCollected, obj.IsCarpetInvoice, obj.BillDate, obj.BillTime, obj.DeliveryDate, obj.DeliveryTime, obj.IsDeleted, Convert.ToDateTime(obj.DeletedDateTime), Convert.ToDateTime(obj.CreatedDate));
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeletePos(clspos obj)
        {
            int result = 0;

            try
            {
                result = (int)db.SP_pos_Delete(obj.PosID);
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