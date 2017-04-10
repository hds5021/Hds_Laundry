using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntegrationAPI.Partial;
using IntegrationAPI.Models;
using IntegrationAPI.Helpers;
using Integration_Repository;
using System.Data;

namespace IntegrationAPI.Services
{
    public class suppliersService
    {
        ///<summary>
        ///Suppliers
        /// </summary>
        /// 

        public string GetSuppliersDetail(clssuppliers obj)
        {
            string result = "";
            try
            {
                suppliers_Entity objEntities = new suppliers_Entity();
                List<SP_suppliers_SelectAllResult> objResult = new List<SP_suppliers_SelectAllResult>();
                objResult = objEntities.GetSuppliersDetail(obj);
                result = objResult.ToJSON();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }
        public string GetSuppliersDetailBYId(clssuppliers obj)
        {
            string result = "";
            try
            {
                suppliers_Entity objEntities = new suppliers_Entity();
                List<SP_suppliers_SelectOneResult> objResult = new List<SP_suppliers_SelectOneResult>();
                objResult = objEntities.GetSuppliersDetailBYId(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string InsertSupplier(clssuppliers obj)
        {
            string result = "";
            try
            {
                suppliers_Entity objEntities = new suppliers_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertSupplier(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string UpdateSupplier(clssuppliers obj)
        {
            string result = "";
            try
            {
                suppliers_Entity objEntities = new suppliers_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateSupplier(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string DeleteSupplier(clssuppliers obj)
        {
            string result = "";
            try
            {
                suppliers_Entity objEntities = new suppliers_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteSupplier(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }
    }
}