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
    public class PreSubMenu_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///PreSubMenu
        /// </summary>
        /// 
        public virtual SP_PreSubMenu_SelectAllResult GetPreSubMenuDetail(clsPreSubMenu obj)
        {
            SP_PreSubMenu_SelectAllResult objResult = new SP_PreSubMenu_SelectAllResult();
            try
            {

                objResult = (SP_PreSubMenu_SelectAllResult)db.SP_PreSubMenu_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_PreSubMenu_SelectOneResult GetPreSubMenuDetailById(clsPreSubMenu obj)
        {
            SP_PreSubMenu_SelectOneResult objResult = new SP_PreSubMenu_SelectOneResult();
            try
            {

                objResult = (SP_PreSubMenu_SelectOneResult)db.SP_PreSubMenu_SelectOne(obj.Presubmenuid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertPreSubMenu(clsPreSubMenu obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_PreSubMenu_Insert(obj.PresubmenuName, obj.PresubmenuDesc, obj.Menuid, obj.Submenuid, obj.Status, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdatePreSubMenu(clsPreSubMenu obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_PreSubMenu_Update(obj.Presubmenuid, obj.PresubmenuName, obj.PresubmenuDesc, obj.Menuid, obj.Submenuid, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeletePreSubMenu(clsPreSubMenu obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_PreSubMenu_Delete(obj.Presubmenuid);
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