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
    public class PageMasterService
    {
        ///<summary>
        ///PageMaster
        /// </summary>
        /// 

        public string GetPageMasterDetail(clsPageMaster obj)
        {
            string result = "";
            try
            {
                PageMaster_Entity objEntities = new PageMaster_Entity();
                SP_PageMaster_SelectAllResult objResult = new SP_PageMaster_SelectAllResult();
                objResult = objEntities.GetPageMasterDetail(obj);
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
        public string GetPageMasterDetailById(clsPageMaster obj)
        {
            string result = "";
            try
            {
                PageMaster_Entity objEntities = new PageMaster_Entity();
                SP_PageMaster_SelectOneResult objResult = new SP_PageMaster_SelectOneResult();
                objResult = objEntities.GetPageMasterDetailById(obj);
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

        public string InsertPageMaster(clsPageMaster obj)
        {
            string result = "";
            try
            {
                PageMaster_Entity objEntities = new PageMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertPageMaster(obj);
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

        public string UpdatePageMaster(clsPageMaster obj)
        {
            string result = "";
            try
            {
                PageMaster_Entity objEntities = new PageMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatePageMaster(obj);
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

        public string DeletePageMaster(clsPageMaster obj)
        {
            string result = "";
            try
            {
                PageMaster_Entity objEntities = new PageMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeletePageMaster(obj);
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