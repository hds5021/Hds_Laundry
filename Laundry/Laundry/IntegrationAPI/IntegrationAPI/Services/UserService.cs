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
    public class UserService
    {
        public string GetUserInfoDetail(clsUser_Info obj)
        {
            string result = "";
            try
            {
                User_Entity objEntities = new User_Entity();
                List<SP_UserInfo_SelectAllResult> objResult = new List<SP_UserInfo_SelectAllResult>();
                objResult = objEntities.GetUserInfoDetail(obj);
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
        public string GetUserInfoDetailById(clsUser_Info obj)
        {
            string result = "";
            try
            {
                User_Entity objEntities = new User_Entity();
                List<SP_UserInfo_SelectOneResult> objResult = new List<SP_UserInfo_SelectOneResult>();
                objResult = objEntities.GetUserInfoDetailById(obj);
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
        public string InsertUserInfo(clsUser_Info obj)
        {
            string result = "";
            try
            {
                User_Entity objEntities = new User_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertUserInfo(obj);
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

        public string UpdateUserInfo(clsUser_Info obj)
        {
            string result = "";
            try
            {
                User_Entity objEntities = new User_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateUserInfo(obj);
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
        public string DeleteUserInfo(clsUser_Info obj)
        {
            string result = "";
            try
            {
                User_Entity objEntities = new User_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteUserInfo(obj);
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