using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaundaryManagement.Models
{
    public class SearchParameterModel
    {

        [Display(Name = "Search By Terrritory")]
        public string Territory
        {
            get;

            set;
        }
        public string Format
        {
            get;

            set;
        }

    }



    public class WorldModel
    {

        private string m_Territory;
        private string m_Country;
        private string m_Year;
        private string m_Stats;


        public string Territory
        {
            get { return m_Territory; }

            set { value = m_Territory; }
        }

        public string Country
        {
            get { return m_Country; }

            set { value = m_Country; }
        }

        public string Year
        {
            get { return m_Year; }

            set { value = m_Year; }
        }

        public string Stats
        {
            get { return m_Stats; }

            set { value = m_Stats; }
        }
        public WorldModel() { }

        public WorldModel(string territory, string country, string year, string stats)
        {
            m_Territory = territory;
            m_Year = year;
            m_Country = country;
            m_Stats = stats;
        }
    }
}


