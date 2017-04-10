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
    public class instance_settingsService
    {
        ///<summary>
        ///instance_settings
        /// </summary>
        /// 

        public string GetInstanceSettingsDetail(clsinstanceSettings obj)
        {
            string result = "";
            try
            {
                instance_settings_Entity objEntities = new instance_settings_Entity();
                SP_instance_settings_SelectAllResult objResult = new SP_instance_settings_SelectAllResult();
                objResult = objEntities.GetInstanceSettingsDetail(obj);
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
        public string GetInstanceSettingsDetailById(clsinstanceSettings obj)
        {
            string result = "";
            try
            {
                instance_settings_Entity objEntities = new instance_settings_Entity();
                SP_instance_settings_SelectOneResult objResult = new SP_instance_settings_SelectOneResult();
                objResult = objEntities.GetInstanceSettingsDetailById(obj);
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

        public string InsertInstanceSettings(clsinstanceSettings obj)
        {
            string result = "";
            try
            {
                instance_settings_Entity objEntities = new instance_settings_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertInstanceSettings(obj);
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

        public string UpdateInstanceSettings(clsinstanceSettings obj)
        {
            string result = "";
            try
            {
                instance_settings_Entity objEntities = new instance_settings_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateInstanceSettings(obj);
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

        public string DeleteInstanceSettings(clsinstanceSettings obj)
        {
            string result = "";
            try
            {
                instance_settings_Entity objEntities = new instance_settings_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteInstanceSettings(obj);
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