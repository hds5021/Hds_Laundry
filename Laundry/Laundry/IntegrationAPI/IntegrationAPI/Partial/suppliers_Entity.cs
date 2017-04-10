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
    public class suppliers_Entity:DbContext
    {
        ///<summary>
        ///supplier
        /// </summary>
        /// 
        LaundryDBDataContext db = new LaundryDBDataContext();

        public virtual List<SP_suppliers_SelectAllResult> GetSuppliersDetail(clssuppliers obj)
        {
            ISingleResult<SP_suppliers_SelectAllResult> objResult;
            List<SP_suppliers_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_suppliers_SelectAll();
                objResultList = new List<SP_suppliers_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual List<SP_suppliers_SelectOneResult> GetSuppliersDetailBYId(clssuppliers obj)
        {
            ISingleResult<SP_suppliers_SelectOneResult> objResult;
            List<SP_suppliers_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_suppliers_SelectOne(obj.SupplierID);
                objResultList = new List<SP_suppliers_SelectOneResult>(objResult);
            }
            //SP_suppliers_SelectOneResult objResult = new SP_suppliers_SelectOneResult();
            //try
            //{

            //    objResult = (SP_suppliers_SelectOneResult)db.SP_suppliers_SelectOne(obj.SupplierID);
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual long InsertSupplier(clssuppliers obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_suppliers_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.SupplierName, obj.CivilNumber, obj.Email, obj.Address, obj.Balance, obj.Contact, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdateSupplier(clssuppliers obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_suppliers_Update(obj.SupplierID, obj.InstanceID, obj.UserID, obj.SupplierName, obj.CivilNumber, obj.Email, obj.Address, obj.Balance, obj.Contact, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeleteSupplier(clssuppliers obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_suppliers_Delete(obj.SupplierID);
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