using System;
using System.Web.UI;
using Microsoft.IdentityModel.Claims;

namespace ClaimsViewerWebPart.ClaimsViewerWebPart
{
    public partial class ClaimsViewerWebPartUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var claimsPrincipal = (IClaimsPrincipal) Page.User;
            var claimsIdentity = (IClaimsIdentity) claimsPrincipal.Identity;

            claimsGrid.DataSource = claimsIdentity.Claims;
            Page.DataBind();
        }
    }
}