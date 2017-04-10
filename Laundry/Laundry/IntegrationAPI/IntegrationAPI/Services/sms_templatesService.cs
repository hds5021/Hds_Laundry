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
    public class sms_templatesService
    {
        ///<summary>
        ///sms_templates
        /// </summary>
        /// 

        public string GetSMSTemplatesDetail(clssmsTemplates obj)
        {
            string result = "";
            try
            {
                sms_templates_Entity objEntities = new sms_templates_Entity();
                List<SP_sms_templates_SelectAllResult> objResult = new List<SP_sms_templates_SelectAllResult>();
                objResult = objEntities.GetSMSTemplatesDetail(obj);
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
        public string GetSMSTemplatesDetailById(clssmsTemplates obj)
        {
            string result = "";
            try
            {
                sms_templates_Entity objEntities = new sms_templates_Entity();
                List<SP_sms_templates_SelectOneResult> objResult = new List<SP_sms_templates_SelectOneResult>();
                objResult = objEntities.GetSMSTemplatesDetailById(obj);
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

        public string InsertSMStemplates(clssmsTemplates obj)
        {
            string result = "";
            try
            {
                sms_templates_Entity objEntities = new sms_templates_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertSMStemplates(obj);
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

        public string UpdateSMStemplates(clssmsTemplates obj)
        {
            string result = "";
            try
            {
                sms_templates_Entity objEntities = new sms_templates_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateSMStemplates(obj);
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

        public string DeleteSMStemplates(clssmsTemplates obj)
        {
            string result = "";
            try
            {
                sms_templates_Entity objEntities = new sms_templates_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteSMStemplates(obj);
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