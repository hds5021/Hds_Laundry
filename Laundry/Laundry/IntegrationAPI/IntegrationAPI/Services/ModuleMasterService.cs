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
    public class ModuleMasterService
    {
        ///<summary>
        ///ModuleMaster
        /// </summary>
        /// 

        public string GetModuleMasterDetail(clsModuleMaster obj)
        {
            string result = "";
            try
            {
                ModuleMaster_Entity objEntities = new ModuleMaster_Entity();
                SP_ModuleMaster_SelectAllResult objResult = new SP_ModuleMaster_SelectAllResult();
                objResult = objEntities.GetModuleMasterDetail(obj);
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
        public string GetModuleMasterDetailById(clsModuleMaster obj)
        {
            string result = "";
            try
            {
                ModuleMaster_Entity objEntities = new ModuleMaster_Entity();
                SP_ModuleMaster_SelectOneResult objResult = new SP_ModuleMaster_SelectOneResult();
                objResult = objEntities.GetModuleMasterDetailById(obj);
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

        public string InsertModuleMaster(clsModuleMaster obj)
        {
            string result = "";
            try
            {
                ModuleMaster_Entity objEntities = new ModuleMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertModuleMaster(obj);
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

        public string UpdateModuleMaster(clsModuleMaster obj)
        {
            string result = "";
            try
            {
                ModuleMaster_Entity objEntities = new ModuleMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateModuleMaster(obj);
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

        public string DeleteModuleMaster(clsModuleMaster obj)
        {
            string result = "";
            try
            {
                ModuleMaster_Entity objEntities = new ModuleMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteModuleMaster(obj);
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