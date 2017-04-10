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
    public class Party_Entity:DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///Party
        /// </summary>
        public virtual List<SP_Party_SelectAllResult> GetPartyDetail(clsParty obj)
        {
            ISingleResult<SP_Party_SelectAllResult> objResult;
            List<SP_Party_SelectAllResult> objResultList;
            //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_Party_SelectAll();
                objResultList = new List<SP_Party_SelectAllResult>(objResult);
            }

            //SP_Party_SelectAllResult objResult = new SP_Party_SelectAllResult();
            //try
            //{

            //    objResult = (SP_Party_SelectAllResult)db.SP_PageMaster_SelectAll();
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual List<SP_Party_SelectOneResult> GetPartyDetailById(clsParty obj)
        {
            ISingleResult<SP_Party_SelectOneResult> objResult;
            List<SP_Party_SelectOneResult> objResultList;
            //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_Party_SelectOne(obj.PartyID);
                objResultList = new List<SP_Party_SelectOneResult>(objResult);
            }

            //SP_Party_SelectOneResult objResult = new SP_Party_SelectOneResult();
            //try
            //{

            //    objResult = (SP_Party_SelectOneResult)db.SP_Party_SelectOne(obj.PartyID);
            //}
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual long InsertParty(clsParty obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_Party_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.PartyName, obj.CivilNumber, obj.Email, obj.Address, obj.Contact, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateParty(clsParty obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_Party_Update(obj.PartyID, obj.InstanceID, obj.UserID, obj.PartyName, obj.CivilNumber, obj.Email, obj.Address, obj.Contact, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteParty(clsParty obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_Party_Delete(obj.PartyID);
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