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
    public class expenses_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        /// expenses
        /// </summary>
        /// 
        public virtual List<SP_expenses_SelectAllResult> GetExpensesDetail(clsexpenses obj)
        {
            ISingleResult<SP_expenses_SelectAllResult> objResult;
            List<SP_expenses_SelectAllResult> objResultList;
            try

            {
                objResult = db.SP_expenses_SelectAll();
                objResultList = new List<SP_expenses_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual List<SP_expenses_SelectOneResult> GetExpensesDetailById(clsexpenses obj)
        {
            ISingleResult<SP_expenses_SelectOneResult> objResult;
            List<SP_expenses_SelectOneResult> objResultList;
            try

            {
                objResult = db.SP_expenses_SelectOne(obj.ExpenseID);
                objResultList = new List<SP_expenses_SelectOneResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertExpenses(clsexpenses obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_expenses_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.OfficeBranchID, obj.ExpenseItemID, obj.ItemId, obj.Amount, obj.Details, obj.PaidBy, obj.PartyId, obj.BillDate, obj.IsDeleted, obj.DeletedDate, obj.UpdatedDate, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateExpenses(clsexpenses obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_expenses_Update(obj.ExpenseID, obj.InstanceID, obj.UserID, obj.OfficeBranchID, obj.ExpenseItemID, obj.ItemId, obj.Amount, obj.Details, obj.PaidBy, obj.PartyId, obj.BillDate, obj.IsDeleted, obj.DeletedDate, obj.UpdatedDate, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteExpenses(clsexpenses obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_expenses_Delete(obj.ExpenseID);
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