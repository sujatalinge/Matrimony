using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDEMO1.Utility
{
    public static class CustomHtmlHelper
    {
        //extension method- button-HtmlHelperclass -MvcHtmlstring]

        public static MvcHtmlString Button(this HtmlHelper helper,
            string name, string type,string value)
        {
            TagBuilder button = new TagBuilder("input");
            button.Attributes.Add("type", type);
            button.Attributes.Add("value", value);
            button.Attributes.Add("id", name);
            button.Attributes.Add("name", name);

            return new MvcHtmlString(button.ToString());

        }

        public static MvcHtmlString Image(this HtmlHelper helper,
            string imageUrl, string alternateText)

        //img src = "~/Images/Shlok.jpg" alt= "My company logo"
        //  width= "25%" height= "10%" /> *@

        {
            TagBuilder image = new TagBuilder("img");
            image.Attributes.Add("src", imageUrl);
            image.Attributes.Add("alt", alternateText);

            return new MvcHtmlString(image.ToString());
        }
    }
}