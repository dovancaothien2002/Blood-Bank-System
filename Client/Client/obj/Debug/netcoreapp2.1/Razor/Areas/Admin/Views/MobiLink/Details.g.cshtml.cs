#pragma checksum "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74a21f3994d36a96f594cd4e24a5c47e75226586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MobiLink_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/MobiLink/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/MobiLink/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_MobiLink_Details))]
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
#line 1 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74a21f3994d36a96f594cd4e24a5c47e75226586", @"/Areas/Admin/Views/MobiLink/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MobiLink_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client.Models.MobiLinkRequestModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/Admin.cshtml";

#line default
#line hidden
            BeginContext(145, 153, true);
            WriteLiteral("\r\n<hr />\r\n<h4 style=\"text-align:center;\">Mobilink notification detail</h4>\r\n<hr />\r\n<div>\r\n\r\n\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(299, 41, false);
#line 16 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.mlrId));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(384, 37, false);
#line 19 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.mlrId));

#line default
#line hidden
            EndContext();
            BeginContext(421, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(465, 44, false);
#line 22 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(509, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(553, 40, false);
#line 25 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(637, 43, false);
#line 28 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(680, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(724, 39, false);
#line 31 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(763, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(807, 41, false);
#line 34 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(848, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(892, 37, false);
#line 37 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(973, 41, false);
#line 40 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1058, 37, false);
#line 43 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1139, 40, false);
#line 46 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1223, 36, false);
#line 49 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1303, 53, false);
#line 52 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.hospitaltreatment));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1400, 49, false);
#line 55 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.hospitaltreatment));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1493, 42, false);
#line 58 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1579, 38, false);
#line 61 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1661, 43, false);
#line 64 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.bloodId));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1748, 39, false);
#line 67 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.bloodId));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1831, 45, false);
#line 70 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.bloodName));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1920, 41, false);
#line 73 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.bloodName));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2005, 49, false);
#line 76 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2098, 45, false);
#line 79 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2187, 45, false);
#line 82 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.create_at));

#line default
#line hidden
            EndContext();
            BeginContext(2232, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2276, 41, false);
#line 85 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.create_at));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2361, 45, false);
#line 88 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.update_at));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2450, 41, false);
#line 91 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
       Write(Html.DisplayFor(model => model.update_at));

#line default
#line hidden
            EndContext();
            BeginContext(2491, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2538, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5daee6a8a6a4263b7f387dd22f3ccad", async() => {
                BeginContext(2644, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Details.cshtml"
                           WriteLiteral(Html.DisplayFor(model => model.mlrId));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2652, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2658, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e24448fc003b4f8e8965ead0bb7c24f8", async() => {
                BeginContext(2680, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2696, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client.Models.MobiLinkRequestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
