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
    public class SubMenuMaster_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///SubMenuMaster
        /// </summary>
        /// 
        public virtual SP_SubMenuMaster_SelectAllResult GetSubMenuMasterDetail(clsSubMenuMaster obj)
        {
            SP_SubMenuMaster_SelectAllResult objResult = new SP_SubMenuMaster_SelectAllResult();
            try
            {

                objResult = (SP_SubMenuMaster_SelectAllResult)db.SP_SubMenuMaster_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_SubMenuMaster_SelectOneResult GetSubMenuMasterDetailById(clsSubMenuMaster obj)
        {
            SP_SubMenuMaster_SelectOneResult objResult = new SP_SubMenuMaster_SelectOneResult();
            try
            {

                objResult = (SP_SubMenuMaster_SelectOneResult)db.SP_SubMenuMaster_SelectOne(obj.Submenuid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertSubMenuMaster(clsSubMenuMaster obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_SubMenuMaster_Insert(obj.SubmenuName, obj.SubmenuDesc, obj.Menuid, obj.Status, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdateSubMenuMaster(clsSubMenuMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_SubMenuMaster_Update(obj.Submenuid, obj.SubmenuName, obj.SubmenuDesc, obj.Menuid, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeleteSubMenuMaster(clsSubMenuMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_SubMenuMaster_Delete(obj.Submenuid);
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