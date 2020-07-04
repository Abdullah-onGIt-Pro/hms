using Microsoft.AspNetCore.Razor.TagHelpers;

namespace hms.CustomTagHelpers
{
    public class hmsTextBox : TagHelper
    {
        public string name { get; set; }
        public string label { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetHtmlContent($"<label for=\"{name}\">{label}</label><input name=\"{name}\"/>");
        }
    }
}