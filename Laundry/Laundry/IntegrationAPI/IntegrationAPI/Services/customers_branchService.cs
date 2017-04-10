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
    public class customers_branchService
    {

        /// <summary>
        /// Table Customer Branch Detail Methods implements here
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string getCustomerBranchDetail(customerBranchRequest obj)
        {
            string result = "";
            try
            {
                customers_branch_Entity objEntities = new customers_branch_Entity();
                List<SP_customers_branch_SelectAllResult> CustomerBranchData = new List<SP_customers_branch_SelectAllResult>();
                CustomerBranchData = objEntities.GetCustomerBranchDetail(obj);
                result = CustomerBranchData.ToJSON();


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

        public string getCustomerBranchById(customerBranchRequest obj)
        {
            string result = "";
            try
            {
                customers_branch_Entity objEntities = new customers_branch_Entity();
                List<SP_customers_branch_SelectOneResult> CustomerBranchData = new List<SP_customers_branch_SelectOneResult>();
                CustomerBranchData = objEntities.GetCustomerBranchDetailById(obj);
                result = CustomerBranchData.ToJSON();

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

        public string InsertCustomerBranch(customerBranchRequest obj)
        {
            string result = "";
            try
            {
                customers_branch_Entity objEntities = new customers_branch_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long CustomerData;
                CustomerData = objEntities.InsertCustomerBranch(obj);
                result = CustomerData.ToJSON();

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

        public string UpdateCustomerBranch(customerBranchRequest obj)
        {
            string result = "";
            try
            {
                customers_branch_Entity objEntities = new customers_branch_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int CustomerData;
                CustomerData = objEntities.UpdateCustomerBranch(obj);
                result = CustomerData.ToJSON();

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

        public string DeleteCustomerBranch(customerBranchRequest obj)
        {
            string result = "";
            try
            {
                customers_branch_Entity objEntities = new customers_branch_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int CustomerData;
                CustomerData = objEntities.DeleteCustomerBranch(obj);
                result = CustomerData.ToJSON();

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