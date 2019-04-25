using System.Web.Mvc;

namespace CustomHTMLHelpers.Models
{
    public enum BootstrapAlertType
    {
        Success,
        Info,
        Warning,
        Danger
    }

    public static class CustomHTMLHelpers
    {
        public static string MySpecialTextBox(this HtmlHelper html)
        {
            return "<input type='text' class='my-special-class'/>";
        }

        public static MvcHtmlString MySpecialTextBoxTwo(this HtmlHelper html)
        {
            return MvcHtmlString.Create(
                "<input type='text' class='my-special-class'/>");
        }

        public static MvcHtmlString BootstrapAlert(this HtmlHelper html, BootstrapAlertType type, string message)
        {
            var cssClass = type.ToString().ToLower();
            
            return MvcHtmlString.Create($@"<div class='alert alert-{cssClass} alert-dismissible' role='alert'>
                        <button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button>
                        <strong>Warning!</strong> {message}
                    </div>");
        }
    }

    public static class CustomHTMLHelpersStatic
    {
        public static string MySpecialTextBox()
        {
            return "<input type='text' class='my-special-class'/>";
        }

        public static MvcHtmlString MySpecialTextBoxTwo()
        {
            return MvcHtmlString.Create(
                "<input type='text' class='my-special-class'/>");
        }
    }


}