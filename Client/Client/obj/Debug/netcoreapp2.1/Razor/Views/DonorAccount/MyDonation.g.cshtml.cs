#pragma checksum "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e86bb8f39bd185c5a9e53cd7b6a396a6b64c7a21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonorAccount_MyDonation), @"mvc.1.0.view", @"/Views/DonorAccount/MyDonation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DonorAccount/MyDonation.cshtml", typeof(AspNetCore.Views_DonorAccount_MyDonation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86bb8f39bd185c5a9e53cd7b6a396a6b64c7a21", @"/Views/DonorAccount/MyDonation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_DonorAccount_MyDonation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Client.Models.DonationRequestModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
  
    ViewData["Title"] = "MyDonation";

#line default
#line hidden
            BeginContext(104, 472, true);
            WriteLiteral(@"
<section>
    <hr />
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h4 class=""text-center mb-3"">Donations History</h4>
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                No.
                            </th>
                            <th>
                                ");
            EndContext();
            BeginContext(577, 42, false);
#line 20 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayNameFor(model => model.bbName));

#line default
#line hidden
            EndContext();
            BeginContext(619, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(723, 42, false);
#line 23 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
            EndContext();
            BeginContext(765, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(869, 40, false);
#line 26 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayNameFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(909, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1013, 42, false);
#line 29 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1159, 49, false);
#line 32 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayNameFor(model => model.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1312, 45, false);
#line 35 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayNameFor(model => model.create_at));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1461, 45, false);
#line 38 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayNameFor(model => model.update_at));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 129, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 44 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                          int i = 1;

#line default
#line hidden
            BeginContext(1674, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 45 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1755, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1852, 1, false);
#line 49 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1853, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1957, 41, false);
#line 52 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayFor(modelItem => item.bbName));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 39, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n");
            EndContext();
#line 55 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                             if (item.status != 0)
                            {

#line default
#line hidden
            BeginContext(2120, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2195, 41, false);
#line 58 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                               Write(Html.DisplayFor(modelItem => item.amount));

#line default
#line hidden
            EndContext();
            BeginContext(2236, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 60 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2373, 114, true);
            WriteLiteral("                                <td style=\"color:#ffc107;font-weight:bold;\">\r\n                                    ");
            EndContext();
            BeginContext(2488, 23, false);
#line 64 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                               Write(Html.Raw("Unconfirmed"));

#line default
#line hidden
            EndContext();
            BeginContext(2511, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 66 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                            }

#line default
#line hidden
            BeginContext(2583, 70, true);
            WriteLiteral("\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2654, 39, false);
#line 70 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayFor(modelItem => item.note));

#line default
#line hidden
            EndContext();
            BeginContext(2693, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 72 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                             if (item.status == 1)
                            {

#line default
#line hidden
            BeginContext(2813, 114, true);
            WriteLiteral("                                <td style=\"color:#28a745;font-weight:bold;\">\r\n                                    ");
            EndContext();
            BeginContext(2928, 18, false);
#line 75 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                               Write(Html.Raw("Accept"));

#line default
#line hidden
            EndContext();
            BeginContext(2946, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 77 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                            }
                            else if (item.status == 2)
                            {

#line default
#line hidden
            BeginContext(3105, 114, true);
            WriteLiteral("                                <td style=\"color:#dc3545;font-weight:bold;\">\r\n                                    ");
            EndContext();
            BeginContext(3220, 16, false);
#line 81 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                               Write(Html.Raw("Deny"));

#line default
#line hidden
            EndContext();
            BeginContext(3236, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 83 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                            }
                            else if (item.status == 0)
                            {

#line default
#line hidden
            BeginContext(3395, 106, true);
            WriteLiteral("                            <td style=\"color:#ffc107;font-weight:bold;\">\r\n                                ");
            EndContext();
            BeginContext(3502, 23, false);
#line 87 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.Raw("Unconfirmed"));

#line default
#line hidden
            EndContext();
            BeginContext(3525, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 89 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                            }

#line default
#line hidden
            BeginContext(3593, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(3660, 48, false);
#line 91 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayFor(modelItem => item.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(3708, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3812, 44, false);
#line 94 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayFor(modelItem => item.create_at));

#line default
#line hidden
            EndContext();
            BeginContext(3856, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3960, 44, false);
#line 97 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                           Write(Html.DisplayFor(modelItem => item.update_at));

#line default
#line hidden
            EndContext();
            BeginContext(4004, 70, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 101 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\MyDonation.cshtml"
                            i++;
                        }

#line default
#line hidden
            BeginContext(4135, 133, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n           \r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Client.Models.DonationRequestModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
