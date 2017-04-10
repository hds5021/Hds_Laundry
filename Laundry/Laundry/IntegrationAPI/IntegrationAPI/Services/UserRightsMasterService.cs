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
    public class UserRightsMasterService
    {

        ///<summary>
        ///UserRightsMaster
        /// </summary>
        /// 
        public string GetUserRightsMasterDetail(clsUserRightsMaster obj)
        {
            string result = "";
            try
            {
                UserRightsMaster_Entity objEntities = new UserRightsMaster_Entity();
                SP_UserRightsMaster_SelectAllResult objResult = new SP_UserRightsMaster_SelectAllResult();
                objResult = objEntities.GetUserRightsMasterDetail(obj);
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
        public string GetUserRightsMasterDetailByid(clsUserRightsMaster obj)
        {
            string result = "";
            try
            {
                UserRightsMaster_Entity objEntities = new UserRightsMaster_Entity();
                SP_UserRightsMaster_SelectOneResult objResult = new SP_UserRightsMaster_SelectOneResult();
                objResult = objEntities.GetUserRightsMasterDetailByid(obj);
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

        public string InsertUserRightsMaster(clsUserRightsMaster obj)
        {
            string result = "";
            try
            {
                UserRightsMaster_Entity objEntities = new UserRightsMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertUserRightsMaster(obj);
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

        public string UpdateUserRightsMaster(clsUserRightsMaster obj)
        {
            string result = "";
            try
            {
                UserRightsMaster_Entity objEntities = new UserRightsMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateUserRightsMaster(obj);
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

        public string DeleteUserRightsMaster(clsUserRightsMaster obj)
        {
            string result = "";
            try
            {
                UserRightsMaster_Entity objEntities = new UserRightsMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteUserRightsMaster(obj);
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