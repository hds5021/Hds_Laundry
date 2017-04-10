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
    public class RollMasterService
    {
        ///<summary>
        ///RollMaster
        /// </summary>
        /// 

        public string GetRollMasterDetail(clsRollMaster obj)
        {
            string result = "";
            try
            {
                RollMaster_Entity objEntities = new RollMaster_Entity();
                SP_RollMaster_SelectAllResult objResult = new SP_RollMaster_SelectAllResult();
                objResult = objEntities.GetRollMasterDetail(obj);
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
        public string GetRollMasterDetailById(clsRollMaster obj)
        {
            string result = "";
            try
            {
                RollMaster_Entity objEntities = new RollMaster_Entity();
                SP_RollMaster_SelectOneResult objResult = new SP_RollMaster_SelectOneResult();
                objResult = objEntities.GetRollMasterDetailById(obj);
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

        public string InsertRollMaster(clsRollMaster obj)
        {
            string result = "";
            try
            {
                RollMaster_Entity objEntities = new RollMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertRollMaster(obj);
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

        public string UpdateRollMaster(clsRollMaster obj)
        {
            string result = "";
            try
            {
                RollMaster_Entity objEntities = new RollMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateRollMaster(obj);
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

        public string DeleteRollMaster(clsRollMaster obj)
        {
            string result = "";
            try
            {
                RollMaster_Entity objEntities = new RollMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteRollMaster(obj);
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