using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HallOfFame.Helpers
{
    public static class PhotoExtensions
    {
        public static IHtmlString Photo(this HtmlHelper helper,string content)
        {
            String returnString = String.Format("<div class='container'><div class='row'><div class='col-md-4' id='photo'></div><div class='col-md-8'>{0}</div></div></div>", content);
            return new HtmlString(returnString);
        }
    }
}

