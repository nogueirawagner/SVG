using System.Collections.Generic;
using System.Web.WebPages.Html;



namespace SVG.Identity.Identity.Model
{
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public List<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}
