#pragma checksum "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8096bc6b7a3dfb2aba65bfecb1f9b55bcda1567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Details), @"mvc.1.0.view", @"/Views/Cart/Details.cshtml")]
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
#line 1 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8096bc6b7a3dfb2aba65bfecb1f9b55bcda1567", @"/Views/Cart/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Models.ViewModels.DetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("512"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn head-font bs-successfull txt-light p-3 buybtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 1.2rem; letter-spacing: 1px; width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("heights"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
  
    ViewData["Title"] = Model.Product.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .heights {
        min-height: 100vh;
        max-width: calc(100vw - 2px);
        height: 100%;
    }

    .gapping {
        display: grid;
        gap: 2rem;
    }

    .dashed {
        border: 2px dashed white;
    }

    .asp {
        transition: .2s;
    }

        .asp:hover {
            text-decoration: none;
            background-color: white;
        }

            .asp:hover h4 {
                color: #323240;
            }

    .ssc {
        position: sticky;
        top: 80px;
    }

    .buybtn:hover {
        background-color: white;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8096bc6b7a3dfb2aba65bfecb1f9b55bcda15677125", async() => {
                WriteLiteral("\r\n    <div class=\"row heights bs-dark\">\r\n        <div class=\"col d-flex flex-column align-items-center\">\r\n            <div class=\"ssc bg-white rounded p-3\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f8096bc6b7a3dfb2aba65bfecb1f9b55bcda15677567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 946, "~/Images/Products/", 946, 18, true);
#nullable restore
#line 50 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
AddHtmlAttributeValue("", 964, Model.Product.Image, 964, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"d-flex flex-column align-items-center mt-5\">\r\n                    <h3 class=\"head-font txt-dark mb-3\">Category ");
#nullable restore
#line 52 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                                                            Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 53 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                     if (Model.Product.Category.ShowOrder > 10)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h4 class=\"text-success item-font m-0\"><i class=\"fas fa-dolly\"></i> Avaible</h4>\r\n");
#nullable restore
#line 56 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h4 class=\"text-danger item-font m-0\"><i class=\"fas fa-dolly\"></i> Ending</h4>\r\n");
#nullable restore
#line 60 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""col bs-dark"">
            <div class=""container pt-5 pl-0 gapping"">
                <a href=""#fulldetails"" class=""dashed asp rounded p-3 d-flex justify-content-center bs-dark"">
                    <h4 class=""head-font txt-light m-0"">");
#nullable restore
#line 67 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                                                   Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Details</h4>\r\n                </a>\r\n                <div class=\"card bs-dark-light1\">\r\n                    <div class=\"card-body\">\r\n                        <h2 class=\"head-font txt-blue\">");
#nullable restore
#line 71 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                                                  Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fas fa-hryvnia\"></i></h2>\r\n                    </div>\r\n                    <div class=\"card-footer d-flex\">\r\n");
#nullable restore
#line 74 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                         if (Model.Product.Category.ShowOrder > 20)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <h6 class=""text-success item-font m-0"">
                                <i class=""fas fa-dolly""></i>
                                Avaible
                                <i class=""fas fa-chevron-right ml-2 mr-2""></i>
                                Ordered
                                ");
#nullable restore
#line 81 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                           Write(Model.Product.Category.ShowOrder);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </h6>\r\n");
#nullable restore
#line 83 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <h6 class=""text-danger item-font m-0"">
                                <i class=""fas fa-dolly""></i>
                                Ending
                                <i class=""fas fa-chevron-right ml-2 mr-2""></i>
                                Ordered
                                ");
#nullable restore
#line 91 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                           Write(Model.Product.Category.ShowOrder);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </h6>\r\n");
#nullable restore
#line 93 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"card bs-dark-light1\" id=\"fulldetails\">\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"head-font txt-light\">");
#nullable restore
#line 98 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                                                   Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
                    </div>
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item bs-dark-light1"">
                            <h5 class=""head-font txt-info mb-3"">Short Description</h5>
                            <h6 class=""item-font txt-info"">");
#nullable restore
#line 103 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                                                      Write(Model.Product.ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </li>\r\n                        <li class=\"list-group-item bs-dark-light1\">\r\n                            <h5 class=\"head-font txt-info mb-4\">Full Description</h5>\r\n                            <h6 class=\"item-font txt-info\">");
#nullable restore
#line 107 "F:\source\repos\VS.ASP-NET\ASP.NET\Shop\Shop\Views\Cart\Details.cshtml"
                                                      Write(Html.Raw(Model.Product.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8096bc6b7a3dfb2aba65bfecb1f9b55bcda156715772", async() => {
                    WriteLiteral("\r\n                    Go to cart\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Models.ViewModels.DetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591