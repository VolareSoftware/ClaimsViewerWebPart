using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;

namespace ClaimsViewerWebPart.ClaimsViewerWebPart
{
    [ToolboxItemAttribute(false)]
    public class ClaimsViewerWebPart : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/ClaimsViewerWebPart/ClaimsViewerWebPart/ClaimsViewerWebPartUserControl.ascx";

        protected override void CreateChildControls()
        {
            var control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }
    }
}