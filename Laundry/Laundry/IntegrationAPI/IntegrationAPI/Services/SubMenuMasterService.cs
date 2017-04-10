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
    public class SubMenuMasterService
    {
        ///<summary>
        ///SubMenuMaster
        /// </summary>
        /// 

        public string GetSubMenuMasterDetail(clsSubMenuMaster obj)
        {
            string result = "";
            try
            {
                SubMenuMaster_Entity objEntities = new SubMenuMaster_Entity();
                SP_SubMenuMaster_SelectAllResult objResult = new SP_SubMenuMaster_SelectAllResult();
                objResult = objEntities.GetSubMenuMasterDetail(obj);
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
        public string GetSubMenuMasterDetailById(clsSubMenuMaster obj)
        {
            string result = "";
            try
            {
                SubMenuMaster_Entity objEntities = new SubMenuMaster_Entity();
                SP_SubMenuMaster_SelectOneResult objResult = new SP_SubMenuMaster_SelectOneResult();
                objResult = objEntities.GetSubMenuMasterDetailById(obj);
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

        public string InsertSubMenuMaster(clsSubMenuMaster obj)
        {
            string result = "";
            try
            {
                SubMenuMaster_Entity objEntities = new SubMenuMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertSubMenuMaster(obj);
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

        public string UpdateSubMenuMaster(clsSubMenuMaster obj)
        {
            string result = "";
            try
            {
                SubMenuMaster_Entity objEntities = new SubMenuMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateSubMenuMaster(obj);
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

        public string DeleteSubMenuMaster(clsSubMenuMaster obj)
        {
            string result = "";
            try
            {
                SubMenuMaster_Entity objEntities = new SubMenuMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteSubMenuMaster(obj);
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