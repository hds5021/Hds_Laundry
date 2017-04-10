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
        public virtual SP_pos_SelectAllResult GetPosDetail(clspos obj)
        {
            SP_pos_SelectAllResult objResult = new SP_pos_SelectAllResult();
            try
            {

                objResult = (SP_pos_SelectAllResult)db.SP_pos_items_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
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
        //public virtual long InsertPos(clspos obj)
        //{
        //    long result = 0;
        //    long? resultID = 0;
        //     try
        //    {
        //        result = (long)db.SP_pos_Insert(ref resultID,obj.InstanceID,obj.UserID,obj.BillNo,obj.CustomerID,obj.CustomerBranchID,obj.Type,obj.TotalQuantity,obj.TotalAmount,obj.Discount,obj.TotalPayable,obj.PaidAmount,obj.ReturnAmount,obj.IsPaid,obj.PaidBy,Convert.ToDateTime(obj.PaymentDateTime),obj.Status,obj.Comment,obj.HangerQuantity,obj.HangerRate,obj.HangerAmount,obj.IsClothCollected,obj.IsCarpetInvoice,obj.BillDate,obj.BillTime,obj.DeliveryDate,obj.DeliveryTime,obj.IsDeleted,Convert.ToDateTime(obj.DeletedDateTime),Convert.ToDateTime(obj.CreatedDate) );
        //     }
        //    catch (Exception ex)
        //    {
        //        LoggerFactory.LoggerInstance.LogException(ex);
        //        throw ex;
        //    }

        //    return result;
        //}

    }
}