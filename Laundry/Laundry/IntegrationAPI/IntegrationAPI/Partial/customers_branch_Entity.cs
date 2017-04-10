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
    public class customers_branch_Entity:DbContext
    {

        /// <summary>
        /// Customer Branch 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual List<SP_customers_branch_SelectAllResult> GetCustomerBranchDetail(customerBranchRequest obj)
        {
            ISingleResult<SP_customers_branch_SelectAllResult> objResult;
            List<SP_customers_branch_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_customers_branch_SelectAll();
                objResultList = new List<SP_customers_branch_SelectAllResult>(objResult);
            }
           
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual List<SP_customers_branch_SelectOneResult> GetCustomerBranchDetailById(customerBranchRequest obj)
        {
            ISingleResult<SP_customers_branch_SelectOneResult> objResult;
            List<SP_customers_branch_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_customers_branch_SelectOne(obj.CustomerBranchID);
                objResultList = new List<SP_customers_branch_SelectOneResult>(objResult);
            }

            //SP_customers_branch_SelectOneResult objResult = new SP_customers_branch_SelectOneResult();
            //try
            //{

            //    objResult = (SP_customers_branch_SelectOneResult)db.SP_customers_branch_SelectOne(obj.CustomerBranchID);
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertCustomerBranch(customerBranchRequest obj)
        {
            long? result = 0;
            //long restul1 = 0;
            long re = 0;
            try
            {
                re = (long)db.SP_customers_branch_Insert(obj.InstanceID, obj.UserID, obj.CustomerID, obj.BranchName, obj.CivilNumber, obj.Email, obj.Address, obj.Contact, obj.ContactPerson, obj.CreatedDate, ref result);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return re;
        }

        public virtual int UpdateCustomerBranch(customerBranchRequest obj)
        {
            int result;
            try
            {
                result = (int)db.SP_customers_branch_Update(obj.CustomerBranchID, obj.InstanceID, obj.UserID, obj.CustomerID, obj.BranchName, obj.CivilNumber, obj.Email, obj.Address, obj.Contact, obj.ContactPerson, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteCustomerBranch(customerBranchRequest obj)
        {
            int result;
            try
            {
                result = (int)db.SP_customers_branch_Delete(obj.CustomerBranchID);
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