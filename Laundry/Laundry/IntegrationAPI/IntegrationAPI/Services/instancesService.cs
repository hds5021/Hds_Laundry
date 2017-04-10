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
    public class instancesService
    {


        ///<summary>
        ///instances
        /// </summary>
        /// 

        public string GetInstancesDetail(clsinstances obj)
        {
            string result = "";
            try
            {
                instances_Entity objEntities = new instances_Entity();
                SP_instances_SelectAllResult objResult = new SP_instances_SelectAllResult();
                objResult = objEntities.GetInstancesDetail(obj);
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
        public string GetInstancesDetailById(clsinstances obj)
        {
            string result = "";
            try
            {
                instances_Entity objEntities = new instances_Entity();
                SP_instances_SelectOneResult objResult = new SP_instances_SelectOneResult();
                objResult = objEntities.GetInstancesDetailById(obj);
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

        public string InsertInstances(clsinstances obj)
        {
            string result = "";
            try
            {
                instances_Entity objEntities = new instances_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertInstances(obj);
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

        public string UpdateInstances(clsinstances obj)
        {
            string result = "";
            try
            {
                instances_Entity objEntities = new instances_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateInstances(obj);
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

        public string DeleteInstances(clsinstances obj)
        {
            string result = "";
            try
            {
                instances_Entity objEntities = new instances_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteInstances(obj);
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