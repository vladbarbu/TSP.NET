#pragma checksum "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0e4bad7e74c5007908ae0bde17560e6fb2e612"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASP.NET_MVC_cu_EF_si_WCF.Pages.Properties.Pages_Properties_List), @"mvc.1.0.razor-page", @"/Pages/Properties/List.cshtml")]
namespace ASP.NET_MVC_cu_EF_si_WCF.Pages.Properties
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\_ViewImports.cshtml"
using ASP.NET_MVC_cu_EF_si_WCF;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0e4bad7e74c5007908ae0bde17560e6fb2e612", @"/Pages/Properties/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660e0159f094c9317499200cb186b00f62e92c39", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Properties_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Photos/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Properties for ");
#nullable restore
#line 7 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
              Write(ViewData["Photo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Props[0].Property_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Props[0].Property_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Props[0].Property_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
         foreach (var item in Model.Props)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Property_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Property_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Property_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n \r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\vladb\source\repos\ASP.NET_MVC_cu_EF_si_WCF\ASP.NET_MVC_cu_EF_si_WCF\Pages\Properties\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c0e4bad7e74c5007908ae0bde17560e6fb2e6126661", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NET_MVC_cu_EF_si_WCF.Pages.Properties.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ASP.NET_MVC_cu_EF_si_WCF.Pages.Properties.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ASP.NET_MVC_cu_EF_si_WCF.Pages.Properties.ListModel>)PageContext?.ViewData;
        public ASP.NET_MVC_cu_EF_si_WCF.Pages.Properties.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
