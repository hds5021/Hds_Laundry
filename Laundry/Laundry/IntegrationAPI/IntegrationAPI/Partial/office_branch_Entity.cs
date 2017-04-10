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
    public class office_branch_Entity : DbContext
    {
        ///<summary>
        ///office_Branch
        /// </summary>
        /// 
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual List<SP_office_branch_SelectAllResult> GetOfficeBranchDetail(clsofficeBranch obj)
        {
            ISingleResult<SP_office_branch_SelectAllResult> objResult;
            List<SP_office_branch_SelectAllResult> objResultList;
            //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_office_branch_SelectAll();
                objResultList = new List<SP_office_branch_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual List<SP_office_branch_SelectOneResult> GetOfficeBranchDetailById(clsofficeBranch obj)
        {
            ISingleResult<SP_office_branch_SelectOneResult> objResult;
            List<SP_office_branch_SelectOneResult> objResultList;
            //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_office_branch_SelectOne(obj.OfficeBranchID);
                objResultList = new List<SP_office_branch_SelectOneResult>(objResult);
            }
            //SP_office_branch_SelectOneResult objResult = new SP_office_branch_SelectOneResult();
            //try
            //{

            //    objResult = (SP_office_branch_SelectOneResult)db.SP_office_branch_SelectOne(obj.OfficeBranchID);
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertOfficeBranch(clsofficeBranch obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_office_branch_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.BranchName, obj.CivilNumber, obj.Email, obj.Address, obj.Contact, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateOfficeBranch(clsofficeBranch obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_office_branch_Update(obj.OfficeBranchID, obj.InstanceID, obj.UserID, obj.BranchName, obj.CivilNumber, obj.Email, obj.Address, obj.Contact, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteOfficeBranch(clsofficeBranch obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_office_branch_Delete(obj.OfficeBranchID);
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