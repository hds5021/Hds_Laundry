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
    public class MenuMaster_Entity:DbContext
    {
        ///<summary>
        ///Menu Master
        /// </summary>
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual List<SP_MenuMaster_SelectAllResult> GetMenuMasterDetail(clsMenuMaster obj)
        {
            ISingleResult<SP_MenuMaster_SelectAllResult> objResult;
            List<SP_MenuMaster_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_MenuMaster_SelectAll();
                objResultList = new List<SP_MenuMaster_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual SP_MenuMaster_SelectOneResult GetMenuMasterDetailById(clsMenuMaster obj)
        {
            SP_MenuMaster_SelectOneResult objResult = new SP_MenuMaster_SelectOneResult();
            try
            {

                objResult = (SP_MenuMaster_SelectOneResult)db.SP_MenuMaster_SelectOne(obj.Menuid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual long InsertMenuMaster(clsMenuMaster obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_MenuMaster_Insert(obj.MenuName, obj.MenuDesc, obj.Status, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateMenuMaster(clsMenuMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_MenuMaster_Update(obj.Menuid, obj.MenuName, obj.MenuDesc, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteMenuMaster(clsMenuMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_MenuMaster_Delete(obj.Menuid);
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