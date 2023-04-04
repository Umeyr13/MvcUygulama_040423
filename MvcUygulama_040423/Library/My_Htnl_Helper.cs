using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUygulama_040423.Library
{
    public static class My_Htnl_Helper
    {
        public static MvcHtmlString Alert(this HtmlHelper helper, string id="alert1",string renk="success", string text="")
        {

            TagBuilder tag = new TagBuilder("div");
            tag.AddCssClass("alert alert-"+renk);
            tag.GenerateId(id);
            tag.Attributes.Add(new KeyValuePair<string,string>("role", "alert1"));
            tag.SetInnerText(text);
            return MvcHtmlString.Create(tag.ToString());    

        }

    }
}