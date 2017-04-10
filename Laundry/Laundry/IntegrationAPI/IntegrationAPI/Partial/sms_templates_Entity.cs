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
    public class sms_templates_Entity:DbContext
    {
        ///<summary>
        ///sms_templates
        /// </summary>
        /// 
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual List<SP_sms_templates_SelectAllResult> GetSMSTemplatesDetail(clssmsTemplates obj)
        {
            ISingleResult<SP_sms_templates_SelectAllResult> objResult;
            List<SP_sms_templates_SelectAllResult> objResultList;
            //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_sms_templates_SelectAll();
                objResultList = new List<SP_sms_templates_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual List<SP_sms_templates_SelectOneResult> GetSMSTemplatesDetailById(clssmsTemplates obj)
        {
            ISingleResult<SP_sms_templates_SelectOneResult> objResult;
            List<SP_sms_templates_SelectOneResult> objResultList;
            //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_sms_templates_SelectOne(obj.SmsID);
                objResultList = new List<SP_sms_templates_SelectOneResult>(objResult);
            }
            //SP_sms_templates_SelectOneResult objResult = new SP_sms_templates_SelectOneResult();
            //try
            //{

            //    objResult = (SP_sms_templates_SelectOneResult)db.SP_sms_templates_SelectOne(obj.SmsID);
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual long InsertSMStemplates(clssmsTemplates obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_sms_templates_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.TemplateName, obj.Details, obj.Ismart_sms_language);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdateSMStemplates(clssmsTemplates obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_sms_templates_Update(obj.SmsID, obj.InstanceID, obj.UserID, obj.TemplateName, obj.Details, obj.Ismart_sms_language);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeleteSMStemplates(clssmsTemplates obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_sms_templates_Delete(obj.SmsID);
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