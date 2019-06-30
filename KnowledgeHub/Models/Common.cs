using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace KnowledgeHub.Models
{
    public class Common
    {

        public enum Roles {
            Teacher = 2,
            Student = 1,
            Administrator =3
        }

        /// <summary>
        /// Returns the list of given Key. PreDefined keys: Months,Days,Years
        /// </summary>
        /// <returns>List<SelectListItem></returns>
        public static List<SelectListItem> GetList(string Key)
        {

            List<SelectListItem> list = new List<SelectListItem>();
            SelectListItem listItem;
            if (Key == "Months")
            {
                for (int i = 1; i <= 13; i++)
                {
                    if (i == 1)
                    {
                        listItem = new SelectListItem() { Text = "Months", Value = "0" };
                    }
                    else
                    {
                        listItem = new SelectListItem() { Text = (i - 1).ToString(), Value = (i - 1).ToString() };
                    }
                    list.Add(listItem);
                }
            }
            else if (Key == "Days")
            {
                for (int i = 1; i <= 32; i++)
                {
                    if (i == 1)
                    {
                        listItem = new SelectListItem() { Text = "Days", Value = "0" };
                    }
                    else
                    {
                        listItem = new SelectListItem() { Text = (i - 1).ToString(), Value = (i - 1).ToString() };
                    }
                    list.Add(listItem);
                }
            }
            else if (Key == "Years")
            {
                for (int i = 1970; i <= 2021; i++)
                {
                    if (i == 1970)
                    {
                        listItem = new SelectListItem() { Text = "Years", Value = "0" };
                    }
                    else
                    {
                        listItem = new SelectListItem() { Text = (i - 1).ToString(), Value = (i - 1).ToString() };
                    }
                    list.Add(listItem);
                }
            }
            return list;
        }
    }   
}