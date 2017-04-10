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
    public class Expense_Mst_Entity : DbContext
    {
        ///<summary>
        ///Expense_mst
        /// </summary>
        /// 
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual List<SP_Expense_Mst_SelectAllResult> GetExpenseMasterDetail(clsExpense_Mst obj)
        {
            ISingleResult<SP_Expense_Mst_SelectAllResult> objResult;
            List<SP_Expense_Mst_SelectAllResult> objResultList;
            //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_Expense_Mst_SelectAll();
                objResultList = new List<SP_Expense_Mst_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual List<SP_Expense_Mst_SelectOneResult> GetExpenseMasterDetailById(clsExpense_Mst obj)
        {
            ISingleResult<SP_Expense_Mst_SelectOneResult> objResult;
            List<SP_Expense_Mst_SelectOneResult> objResultList;
            try

            {
                objResult = db.SP_Expense_Mst_SelectOne(obj.ExpenseItemID);
                objResultList = new List<SP_Expense_Mst_SelectOneResult>(objResult);
            }
            //SP_Expense_Mst_SelectOneResult objResult = new SP_Expense_Mst_SelectOneResult();
            //try
            //{

            //    objResult = (SP_Expense_Mst_SelectOneResult)db.SP_Expense_Mst_SelectOne(obj.ExpenseItemID);
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertExpenseMaster(clsExpense_Mst obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_Expense_Mst_Insert(ref resultID, obj.InstanceID, obj.ItemName, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateExpenseMaster(clsExpense_Mst obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_Expense_Mst_Update(obj.ExpenseItemID, obj.InstanceID, obj.ItemName, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteExpenseMaster(clsExpense_Mst obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_Expense_Mst_Delete(obj.ExpenseItemID);
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