using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace detect_language
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = DropDownList1.SelectedValue;
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("" + option + "");
            Session["culture"] = option;
            Response.Redirect(Request.Url.LocalPath);
        }
        protected override void InitializeCulture()
        {
            if (Session["culture"] != null)
            {
                String selectedLanguage = Session["culture"].ToString();
                UICulture = selectedLanguage;
                Culture = selectedLanguage;

                Thread.CurrentThread.CurrentCulture =
                    CultureInfo.CreateSpecificCulture(selectedLanguage);
                Thread.CurrentThread.CurrentUICulture = new
                    CultureInfo(selectedLanguage);
            }
            base.InitializeCulture();
        }
    }
}