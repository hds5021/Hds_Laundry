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
    public class MenuMasterService
    {
        ///<summary>
        ///MenuMaster
        /// </summary>
        /// 

        public string GetMenuMasterDetail(clsMenuMaster obj)
        {
            string result = "";
            try
            {
                MenuMaster_Entity objEntities = new MenuMaster_Entity();
                List<SP_MenuMaster_SelectAllResult> objResult = new List<SP_MenuMaster_SelectAllResult>();
                objResult = objEntities.GetMenuMasterDetail(obj);
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
        public string GetMenuMasterDetailById(clsMenuMaster obj)
        {
            string result = "";
            try
            {
                MenuMaster_Entity objEntities = new MenuMaster_Entity();
                SP_MenuMaster_SelectOneResult objResult = new SP_MenuMaster_SelectOneResult();
                objResult = objEntities.GetMenuMasterDetailById(obj);
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

        public string InsertMenuMaster(clsMenuMaster obj)
        {
            string result = "";
            try
            {
                MenuMaster_Entity objEntities = new MenuMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertMenuMaster(obj);
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

        public string UpdateMenuMaster(clsMenuMaster obj)
        {
            string result = "";
            try
            {
                MenuMaster_Entity objEntities = new MenuMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateMenuMaster(obj);
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

        public string DeleteMenuMaster(clsMenuMaster obj)
        {
            string result = "";
            try
            {
                MenuMaster_Entity objEntities = new MenuMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteMenuMaster(obj);
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