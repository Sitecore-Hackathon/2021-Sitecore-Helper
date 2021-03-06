using System;
using Sitecore.Security.Domains;

namespace SitecoreHelper2021.Feature.UserTracker.sitecore.admin
{
    public partial class UserTracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            BindData();
            ClearMessages();
        }

        //************************************************************************************************************************

        public void BindData()
        {
        }

        //************************************************************************************************************************


        //************************************************************************************************************************

        private void ClearMessages()
        {
        }

        protected void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        protected void btnDownloadReport_Click(object sender, EventArgs e)
        {

        }

        //************************************************************************************************************************

        //************************************************************************************************************************



    }
}