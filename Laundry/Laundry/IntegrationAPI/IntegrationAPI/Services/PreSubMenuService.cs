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
    public class PreSubMenuService
    {

        ///<summary>
        ///PreSubMenu
        /// </summary>
        /// 

        public string GetPreSubMenuDetail(clsPreSubMenu obj)
        {
            string result = "";
            try
            {
                PreSubMenu_Entity objEntities = new PreSubMenu_Entity();
                SP_PreSubMenu_SelectAllResult objResult = new SP_PreSubMenu_SelectAllResult();
                objResult = objEntities.GetPreSubMenuDetail(obj);
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
        public string GetPreSubMenuDetailById(clsPreSubMenu obj)
        {
            string result = "";
            try
            {
                PreSubMenu_Entity objEntities = new PreSubMenu_Entity();
                SP_PreSubMenu_SelectOneResult objResult = new SP_PreSubMenu_SelectOneResult();
                objResult = objEntities.GetPreSubMenuDetailById(obj);
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

        public string InsertPreSubMenu(clsPreSubMenu obj)
        {
            string result = "";
            try
            {
                PreSubMenu_Entity objEntities = new PreSubMenu_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertPreSubMenu(obj);
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

        public string UpdatePreSubMenu(clsPreSubMenu obj)
        {
            string result = "";
            try
            {
                PreSubMenu_Entity objEntities = new PreSubMenu_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatePreSubMenu(obj);
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

        public string DeletePreSubMenu(clsPreSubMenu obj)
        {
            string result = "";
            try
            {
                PreSubMenu_Entity objEntities = new PreSubMenu_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeletePreSubMenu(obj);
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