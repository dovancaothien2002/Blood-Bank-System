#pragma checksum "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee11629f48b4d7e2761cc1d9b53b8b2d059f9b74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonorAccount_MobiLinkdetail), @"mvc.1.0.view", @"/Views/DonorAccount/MobiLinkdetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DonorAccount/MobiLinkdetail.cshtml", typeof(AspNetCore.Views_DonorAccount_MobiLinkdetail))]
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
#line 1 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee11629f48b4d7e2761cc1d9b53b8b2d059f9b74", @"/Views/DonorAccount/MobiLinkdetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_DonorAccount_MobiLinkdetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client.Models.MobiLinkRequestModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
  
    ViewData["Title"] = "MobiLinkdetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 182, true);
            WriteLiteral("\r\n<section>\r\n    <hr />\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <h4 class=\"text-center mb-0\"> Requests Detail ");
            EndContext();
            BeginContext(325, 13, false);
#line 14 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                                                         Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(338, 189, true);
            WriteLiteral("</h4>\r\n            </div>\r\n            <hr class=\"col-12\" />\r\n            <div class=\"col-6\">\r\n                <dl class=\"dl-horizontal\">\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(528, 44, false);
#line 20 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(572, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(652, 40, false);
#line 23 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayFor(model => model.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(692, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(772, 43, false);
#line 26 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(815, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(895, 39, false);
#line 29 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(934, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1014, 41, false);
#line 32 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1135, 37, false);
#line 35 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1252, 41, false);
#line 38 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1373, 37, false);
#line 41 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 222, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <dl class=\"dl-horizontal\">\r\n\r\n                   \r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1633, 40, false);
#line 50 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(1673, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1753, 36, false);
#line 53 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1869, 53, false);
#line 56 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.hospitaltreatment));

#line default
#line hidden
            EndContext();
            BeginContext(1922, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2002, 49, false);
#line 59 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayFor(model => model.hospitaltreatment));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 100, true);
            WriteLiteral("\r\n                    </dd>\r\n                   \r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2152, 45, false);
#line 63 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.bloodName));

#line default
#line hidden
            EndContext();
            BeginContext(2197, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2277, 41, false);
#line 66 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayFor(model => model.bloodName));

#line default
#line hidden
            EndContext();
            BeginContext(2318, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2398, 49, false);
#line 69 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(2447, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2527, 45, false);
#line 72 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MobiLinkdetail.cshtml"
                   Write(Html.DisplayFor(model => model.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(2572, 120, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                </dl>\r\n            </div>\r\n            </div>\r\n        </div></section>\r\n");
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
