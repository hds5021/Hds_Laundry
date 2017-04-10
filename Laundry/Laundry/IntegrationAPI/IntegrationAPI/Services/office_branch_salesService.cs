using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntegrationAPI.Partial;
using IntegrationAPI.Models;
using IntegrationAPI.Helpers;
using Integration_Repository;
using System.Data;
using System.Web.Http.Results;

namespace IntegrationAPI.Services
{
    public class office_branch_salesService
    {
        ///<summary>
        ///office_branch_sales
        /// </summary>
        /// 

        public string GetOfficeBranchSalesDetail(clsofficeBanchSales obj)
        {
            string result = "";
            try
            {
                office_branch_sales_Entity objEntities = new office_branch_sales_Entity();
                List<SP_office_branch_sales_SelectAllResult> objResult = new List<SP_office_branch_sales_SelectAllResult>();
                objResult = objEntities.GetOfficeBranchSalesDetail(obj);
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
        public string GetOfficeBranchSalesDetailById(clsofficeBanchSales obj)
        {
            string result = "";
            try
            {
                office_branch_sales_Entity objEntities = new office_branch_sales_Entity();
                List<SP_office_branch_sales_SelectOneResult> objResult = new List<SP_office_branch_sales_SelectOneResult>();
                objResult = objEntities.GetOfficeBranchSalesDetailById(obj);
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

        public string InsertOfficeBranchSales(clsofficeBanchSales obj)
        {
            string result = "";
            try
            {
                office_branch_sales_Entity objEntities = new office_branch_sales_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertOfficeBranchSales(obj);
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

        public string UpdateOfficeBranchSales(clsofficeBanchSales obj)
        {
            string result = "";
            try
            {
                office_branch_sales_Entity objEntities = new office_branch_sales_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateOfficeBranchSales(obj);
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

        public string DeleteOfficeBranchSales(clsofficeBanchSales obj)
        {
            string result = "";
            try
            {
                office_branch_sales_Entity objEntities = new office_branch_sales_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteOfficeBranchSales(obj);
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