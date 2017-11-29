using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cities.Infrastructure.TagHelpers
{
    //applying restrictions with this tag helper attribute so as to NARROW the scope of the tag helper
    //this attribute stopped the tag helper from blocking the btn-primary style applied to the reset btn
    //[HtmlTargetElement("button", Attributes = "bs-button-color", ParentTag = "form")]


    //applying restrictions with this tag helper attribute so as to WIDEN the scope of the tag helper
    //this attribute will enable the a tag to also be able to use the tag helper, not just buttons
    //[HtmlTargetElement(Attributes = "bs-button-color", ParentTag = "form")]


    //The most balanced approach:
    [HtmlTargetElement("button", Attributes = "bs-button-color", ParentTag = "form")]
    [HtmlTargetElement("a", Attributes = "bs-button-color", ParentTag = "form")]
    public class ButtonTagHelper : TagHelper
    {
        public string BsButtonColor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonColor}");
        }
    }
}
