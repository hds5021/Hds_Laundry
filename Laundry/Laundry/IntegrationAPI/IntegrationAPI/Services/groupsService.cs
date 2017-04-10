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
    public class groupsService
    {
        ///<summary>
        ///groups
        /// </summary>
        /// 

        public string GetgroupsDetail(clsgroups obj)
        {
            string result = "";
            try
            {
                groups_Entity objEntities = new groups_Entity();
                List<SP_groups_SelectAllResult> objResult = new List<SP_groups_SelectAllResult>();
                objResult = objEntities.GetgroupsDetail(obj);
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
        public string GetgroupsDetailById(clsgroups obj)
        {
            string result = "";
            try
            {
                groups_Entity objEntities = new groups_Entity();
                //SP_groups_SelectOneResult objResult = new SP_groups_SelectOneResult();
                List<SP_groups_SelectOneResult> objResult = new List<SP_groups_SelectOneResult>();
                objResult = objEntities.GetgroupsDetailById(obj);
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

        public string InsertGroups(clsgroups obj)
        {
            string result = "";
            try
            {
                groups_Entity objEntities = new groups_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertGroups(obj);
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

        public string UpdateGroups(clsgroups obj)
        {
            string result = "";
            try
            {
                groups_Entity objEntities = new groups_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateGroups(obj);
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

        public string DeleteGroups(clsgroups obj)
        {
            string result = "";
            try
            {
                groups_Entity objEntities = new groups_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteGroups(obj);
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