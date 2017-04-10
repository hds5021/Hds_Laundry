using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntegrationAPI.Services;
using IntegrationAPI.Models;
using IntegrationAPI.Helpers;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using Integration_Repository;
using System.Data.SqlClient;
using System.Data;
using System.Data.Linq;

namespace IntegrationAPI.Partial
{
    public class sms_logs_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();

        ///<summary>
        ///sms_logs
        /// </summary>
        /// 
        public virtual SP_sms_logs_SelectAllResult GetSMSLogsDetail(clssmslogs obj)
        {
            SP_sms_logs_SelectAllResult objResult = new SP_sms_logs_SelectAllResult();
            try
            {

                objResult = (SP_sms_logs_SelectAllResult)db.SP_sms_logs_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_sms_logs_SelectOneResult GetSMSLogsDetailById(clssmslogs obj)
        {
            SP_sms_logs_SelectOneResult objResult = new SP_sms_logs_SelectOneResult();
            try
            {

                objResult = (SP_sms_logs_SelectOneResult)db.SP_sms_logs_SelectOne(obj.SmsLogID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertSMSLogsMaster(clssmslogs obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_sms_logs_Insert(ref resultID, obj.UserID, obj.InstanceID, obj.CustomerID, obj.SmsID, obj.TemplateName, obj.CountryCode, obj.FromNumber, obj.ToNumber, obj.Details, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdateSMSLogsMaster(clssmslogs obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_sms_logs_Update(obj.SmsLogID, obj.UserID, obj.InstanceID, obj.CustomerID, obj.SmsID, obj.TemplateName, obj.CountryCode, obj.FromNumber, obj.ToNumber, obj.Details, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeleteSMSLogsMaster(clssmslogs obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_sms_logs_Delete(obj.SmsLogID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

    }
}