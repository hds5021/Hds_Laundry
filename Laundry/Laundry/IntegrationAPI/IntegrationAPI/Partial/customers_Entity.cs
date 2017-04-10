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
    public class customers_Entity:DbContext
    {
        ///<summary>
        ///customers
        /// </summary>
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual List<SP_customers_SelectAllResult> GetCustomeryDetails(customerRequest obj)
        {
            ISingleResult<SP_customers_SelectAllResult> objResult;
            List<SP_customers_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_customers_SelectAll();
                objResultList = new List<SP_customers_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual List<SP_customers_SelectOneResult> GetCustomerById(customerRequest obj)
        {
            ISingleResult<SP_customers_SelectOneResult> objResult;
            List<SP_customers_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_customers_SelectOne(obj.CustomerID);
                objResultList = new List<SP_customers_SelectOneResult>(objResult).ToList();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertCustomer(customerRequest obj)
        {
            long? result = 0;
            long re = 0;
            try
            {
                re = (Int32)db.SP_customers_Insert(obj.InstanceID, obj.UserID, obj.CustomerName, obj.CivilNumber, obj.Email, obj.Address, obj.Balance, obj.Contact, obj.Status, obj.CreatedDate, ref result);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return re;
        }

        public virtual int UpdateCustomer(customerRequest obj)
        {
            int result;
            try
            {
                result = (int)db.SP_customers_Update(obj.CustomerID, obj.InstanceID, obj.UserID, obj.CustomerName, obj.CivilNumber, obj.Email, obj.Address, obj.Balance, obj.Contact, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteCustomer(customerRequest obj)
        {
            int result;
            try
            {
                result = (int)db.SP_customers_Delete(obj.CustomerID);
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