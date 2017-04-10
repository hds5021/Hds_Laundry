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
    public class instance_settings_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        /// instance_setting
        /// </summary>
        /// 
        public virtual SP_instance_settings_SelectAllResult GetInstanceSettingsDetail(clsinstanceSettings obj)
        {
            SP_instance_settings_SelectAllResult objResult = new SP_instance_settings_SelectAllResult();
            try
            {

                objResult = (SP_instance_settings_SelectAllResult)db.SP_instance_settings_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual SP_instance_settings_SelectOneResult GetInstanceSettingsDetailById(clsinstanceSettings obj)
        {
            SP_instance_settings_SelectOneResult objResult = new SP_instance_settings_SelectOneResult();
            try
            {

                objResult = (SP_instance_settings_SelectOneResult)db.SP_instance_settings_SelectOne(obj.InstanceID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual long InsertInstanceSettings(clsinstanceSettings obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_instance_settings_Insert(ref resultID, obj.Tax1Name, obj.Tax1Value, obj.Tax2Name, obj.Tax2Value, obj.Tax3Name, obj.Tax3Value, obj.BillNoReset, obj.EmailFrom, obj.Password, obj.InstanceLogo, obj.PosBillPrintLogo, obj.PosBillPrintHoliday, obj.PosDeliveryDays, obj.PosItemOrder, obj.PosItemLocalNameDisplay, obj.PosItemLocalNameBillPrint, obj.CountryCode, obj.MobileNo, obj.AccountSID, obj.AuthToken, obj.HangerRate, obj.MessageEndOfBill, obj.TnCEnglish, obj.TnCLocalLanguage, obj.ItemwiseReportLocalLanguage, obj.MaxDiscountPercentage);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateInstanceSettings(clsinstanceSettings obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_instance_settings_Update(obj.InstanceID, obj.Tax1Name, obj.Tax1Value, obj.Tax2Name, obj.Tax2Value, obj.Tax3Name, obj.Tax3Value, obj.BillNoReset, obj.EmailFrom, obj.Password, obj.InstanceLogo, obj.PosBillPrintLogo, obj.PosBillPrintHoliday, obj.PosDeliveryDays, obj.PosItemOrder, obj.PosItemLocalNameDisplay, obj.PosItemLocalNameBillPrint, obj.CountryCode, obj.MobileNo, obj.AccountSID, obj.AuthToken, obj.HangerRate, obj.MessageEndOfBill, obj.TnCEnglish, obj.TnCLocalLanguage, obj.ItemwiseReportLocalLanguage, obj.MaxDiscountPercentage);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteInstanceSettings(clsinstanceSettings obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_instance_settings_Delete(obj.InstanceID);
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