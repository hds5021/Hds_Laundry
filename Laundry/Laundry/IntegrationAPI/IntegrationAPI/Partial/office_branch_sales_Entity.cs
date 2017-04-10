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
    public class office_branch_sales_Entity
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///office_Branch_Sales
        /// </summary>
        /// 
        public virtual List<SP_office_branch_sales_SelectAllResult> GetOfficeBranchSalesDetail(clsofficeBanchSales obj)
        {
            ISingleResult<SP_office_branch_sales_SelectAllResult> objResult;
            List<SP_office_branch_sales_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_office_branch_sales_SelectAll();
                objResultList = new List<SP_office_branch_sales_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual List<SP_office_branch_sales_SelectOneResult> GetOfficeBranchSalesDetailById(clsofficeBanchSales obj)
        {
            ISingleResult<SP_office_branch_sales_SelectOneResult> objResult;
            List<SP_office_branch_sales_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_office_branch_sales_SelectOne(obj.BranchSalesID);
                objResultList = new List<SP_office_branch_sales_SelectOneResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertOfficeBranchSales(clsofficeBanchSales obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_office_branch_sales_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.OfficeBranchID, obj.Amount, obj.BillDate, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateOfficeBranchSales(clsofficeBanchSales obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_office_branch_sales_Update(obj.BranchSalesID, obj.InstanceID, obj.UserID, obj.OfficeBranchID, obj.Amount, obj.BillDate, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteOfficeBranchSales(clsofficeBanchSales obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_office_branch_sales_Delete(obj.BranchSalesID);
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