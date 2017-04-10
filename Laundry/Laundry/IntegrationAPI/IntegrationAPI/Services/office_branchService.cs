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
    public class office_branchService
    {
        ///<summary>
        ///office_branch
        /// </summary>
        /// 

        public string GetOfficeBranchDetail(clsofficeBranch obj)
        {
            string result = "";
            try
            {
                office_branch_Entity objEntities = new office_branch_Entity();
                List<SP_office_branch_SelectAllResult> objResult = new List<SP_office_branch_SelectAllResult>();
                objResult = objEntities.GetOfficeBranchDetail(obj);
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
        public string GetOfficeBranchDetailById(clsofficeBranch obj)
        {
            string result = "";
            try
            {
                office_branch_Entity objEntities = new office_branch_Entity();
                List<SP_office_branch_SelectOneResult> objResult = new List<SP_office_branch_SelectOneResult>();
                objResult = objEntities.GetOfficeBranchDetailById(obj);
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

        public string InsertOfficeBranch(clsofficeBranch obj)
        {
            string result = "";
            try
            {
                office_branch_Entity objEntities = new office_branch_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertOfficeBranch(obj);
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

        public string UpdateOfficeBranch(clsofficeBranch obj)
        {
            string result = "";
            try
            {
                office_branch_Entity objEntities = new office_branch_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateOfficeBranch(obj);
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

        public string DeleteOfficeBranch(clsofficeBranch obj)
        {
            string result = "";
            try
            {
                office_branch_Entity objEntities = new office_branch_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteOfficeBranch(obj);
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