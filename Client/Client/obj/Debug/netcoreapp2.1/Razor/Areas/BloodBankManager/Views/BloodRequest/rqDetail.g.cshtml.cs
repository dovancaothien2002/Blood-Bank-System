#pragma checksum "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e7833dc16bb51a79d11e8e6211a9cc1c2202315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodBankManager_Views_BloodRequest_rqDetail), @"mvc.1.0.view", @"/Areas/BloodBankManager/Views/BloodRequest/rqDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BloodBankManager/Views/BloodRequest/rqDetail.cshtml", typeof(AspNetCore.Areas_BloodBankManager_Views_BloodRequest_rqDetail))]
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
#line 1 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e7833dc16bb51a79d11e8e6211a9cc1c2202315", @"/Areas/BloodBankManager/Views/BloodRequest/rqDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Areas/BloodBankManager/Views/_ViewImports.cshtml")]
    public class Areas_BloodBankManager_Views_BloodRequest_rqDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client.Models.RequestToBloodBankModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
  
    ViewData["Title"] = "rqDetail";
    Layout = "~/Areas/BloodBankManager/Views/Shared/Admin.cshtml";

#line default
#line hidden
            BeginContext(160, 251, true);
            WriteLiteral("\r\n<div class=\"row pt-2 m-0\">\r\n    <div class=\"col-12\">\r\n        <h3 class=\"text-center m-0\"> Request Detail </h3>\r\n    </div>\r\n    <hr class=\"col-12\" />\r\n    <div class=\"col-6\">\r\n        <dl class=\"dl-horizontal\">\r\n\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(412, 44, false);
#line 17 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(456, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(512, 40, false);
#line 20 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(552, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(608, 43, false);
#line 23 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(651, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(707, 39, false);
#line 26 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(746, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(802, 42, false);
#line 29 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(844, 21, true);
            WriteLiteral("\r\n            </dt>\r\n");
            EndContext();
#line 31 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
             if (Model.gender == true)
            {

#line default
#line hidden
            BeginContext(920, 71, true);
            WriteLiteral("                <dd>\r\n                    Male\r\n                </dd>\r\n");
            EndContext();
#line 36 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1039, 73, true);
            WriteLiteral("                <dd>\r\n                    Female\r\n                </dd>\r\n");
            EndContext();
#line 42 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
            }

#line default
#line hidden
            BeginContext(1127, 34, true);
            WriteLiteral("            <dt>\r\n                ");
            EndContext();
            BeginContext(1162, 44, false);
#line 44 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.birthday));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1262, 40, false);
#line 47 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.birthday));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1358, 41, false);
#line 50 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1455, 37, false);
#line 53 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1548, 41, false);
#line 56 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1645, 37, false);
#line 59 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1682, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1738, 42, false);
#line 62 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1836, 38, false);
#line 65 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.amount));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 145, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2020, 40, false);
#line 73 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2116, 36, false);
#line 76 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2208, 53, false);
#line 79 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.hospitaltreatment));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2317, 49, false);
#line 82 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.hospitaltreatment));

#line default
#line hidden
            EndContext();
            BeginContext(2366, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2422, 42, false);
#line 85 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(2464, 21, true);
            WriteLiteral("\r\n            </dt>\r\n");
            EndContext();
#line 87 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
             if (Model.status == 0)
            {

#line default
#line hidden
            BeginContext(2537, 117, true);
            WriteLiteral("                <dd style=\"color:yellow;font-weight:bold;\">\r\n                    Unconfirmed\r\n                </dd>\r\n");
            EndContext();
#line 92 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
            }
            else if (Model.status == 1)
            {

#line default
#line hidden
            BeginContext(2725, 110, true);
            WriteLiteral("                <dd style=\"color:green;font-weight:bold;\">\r\n                    Acept\r\n                </dd>\r\n");
            EndContext();
#line 98 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2883, 108, true);
            WriteLiteral("                <dd style=\"color:red;font-weight:bold;\">\r\n                    Denie\r\n                </dd>\r\n");
            EndContext();
#line 104 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
            }

#line default
#line hidden
            BeginContext(3006, 36, true);
            WriteLiteral("\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3043, 45, false);
#line 107 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.bloodName));

#line default
#line hidden
            EndContext();
            BeginContext(3088, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3144, 41, false);
#line 110 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.bloodName));

#line default
#line hidden
            EndContext();
            BeginContext(3185, 57, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3243, 49, false);
#line 114 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(3292, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3348, 45, false);
#line 117 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(3393, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3449, 45, false);
#line 120 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.create_at));

#line default
#line hidden
            EndContext();
            BeginContext(3494, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3550, 41, false);
#line 123 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.create_at));

#line default
#line hidden
            EndContext();
            BeginContext(3591, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3647, 45, false);
#line 126 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.update_at));

#line default
#line hidden
            EndContext();
            BeginContext(3692, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3748, 41, false);
#line 129 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\BloodRequest\rqDetail.cshtml"
           Write(Html.DisplayFor(model => model.update_at));

#line default
#line hidden
            EndContext();
            BeginContext(3789, 65, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n   \r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client.Models.RequestToBloodBankModel> Html { get; private set; }
    }
}
#pragma warning restore 1591