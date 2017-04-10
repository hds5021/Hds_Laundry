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
    public class UserMasterService
    {
        ///<summary>
        ///UserMaster
        /// </summary>
        /// 

        public string GetUserMasterDetail(clsUserMaster obj)
        {
            string result = "";
            try
            {
                UserMaster_Entity objEntities = new UserMaster_Entity();
                SP_UserMaster_SelectAllResult objResult = new SP_UserMaster_SelectAllResult();
                objResult = objEntities.GetUserMasterDetail(obj);
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
        public string GetUserMasterDetailById(clsUserMaster obj)
        {
            string result = "";
            try
            {
                UserMaster_Entity objEntities = new UserMaster_Entity();
                SP_UserMaster_SelectOneResult objResult = new SP_UserMaster_SelectOneResult();
                objResult = objEntities.GetUserMasterDetailById(obj);
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

        public string InsertUserMaster(clsUserMaster obj)
        {
            string result = "";
            try
            {
                UserMaster_Entity objEntities = new UserMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertUserMaster(obj);
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

        public string UpdateUserMaster(clsUserMaster obj)
        {
            string result = "";
            try
            {
                UserMaster_Entity objEntities = new UserMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateUserMaster(obj);
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

        public string DeleteUserMaster(clsUserMaster obj)
        {
            string result = "";
            try
            {
                UserMaster_Entity objEntities = new UserMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteUserMaster(obj);
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