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
    public class sms_logsService
    {
        ///<summary>
        ///sms_logs
        /// </summary>
        /// 

        public string GetSMSLogsDetail(clssmslogs obj)
        {
            string result = "";
            try
            {
                sms_logs_Entity objEntities = new sms_logs_Entity();
                SP_sms_logs_SelectAllResult objResult = new SP_sms_logs_SelectAllResult();
                objResult = objEntities.GetSMSLogsDetail(obj);
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
        public string GetSMSLogsDetailById(clssmslogs obj)
        {
            string result = "";
            try
            {
                sms_logs_Entity objEntities = new sms_logs_Entity();
                SP_sms_logs_SelectOneResult objResult = new SP_sms_logs_SelectOneResult();
                objResult = objEntities.GetSMSLogsDetailById(obj);
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

        public string InsertSMSLogsMaster(clssmslogs obj)
        {
            string result = "";
            try
            {
                sms_logs_Entity objEntities = new sms_logs_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertSMSLogsMaster(obj);
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

        public string UpdateSMSLogsMaster(clssmslogs obj)
        {
            string result = "";
            try
            {
                sms_logs_Entity objEntities = new sms_logs_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateSMSLogsMaster(obj);
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

        public string DeleteSMSLogsMaster(clssmslogs obj)
        {
            string result = "";
            try
            {
                sms_logs_Entity objEntities = new sms_logs_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteSMSLogsMaster(obj);
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