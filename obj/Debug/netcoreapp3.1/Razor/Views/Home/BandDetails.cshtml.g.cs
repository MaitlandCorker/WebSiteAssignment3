#pragma checksum "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\Home\BandDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed2cdb07f85207dce2eb1e3e045ac5876806e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BandDetails), @"mvc.1.0.view", @"/Views/Home/BandDetails.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\_ViewImports.cshtml"
using WebSiteAssignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\_ViewImports.cshtml"
using WebSiteAssignment2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed2cdb07f85207dce2eb1e3e045ac5876806e8b", @"/Views/Home/BandDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f4103d8c3b91a777ac3d589128a89cbe319dedf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BandDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSiteAssignment2.Models.Band>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\Home\BandDetails.cshtml"
  
    ViewData["Title"] = @Model.BandName;
    ViewData["PageHeading"] = Model.BandName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\r\n    <div class=\"mainImage\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ed2cdb07f85207dce2eb1e3e045ac5876806e8b4254", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 189, "~/Images/", 189, 9, true);
#nullable restore
#line 8 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\Home\BandDetails.cshtml"
AddHtmlAttributeValue("", 198, Model.BandImage, 198, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\Home\BandDetails.cshtml"
AddHtmlAttributeValue("", 221, Model.BandName, 221, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n    </div>\r\n\r\n    <div class=\"bandInfo\">\r\n        <h2>");
#nullable restore
#line 13 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\Home\BandDetails.cshtml"
       Write(Model.BandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>");
#nullable restore
#line 14 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\Home\BandDetails.cshtml"
      Write(Model.BandDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Genre: ");
#nullable restore
#line 15 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\Home\BandDetails.cshtml"
             Write(Model.BandGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Price: £");
#nullable restore
#line 16 "C:\Users\LabStudent-55-504266\source\repos\WebSiteAssignment2\WebSiteAssignment2\Views\Home\BandDetails.cshtml"
               Write((Model.TicketPrice).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Purchase Ticket</p>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSiteAssignment2.Models.Band> Html { get; private set; }
    }
}
#pragma warning restore 1591
