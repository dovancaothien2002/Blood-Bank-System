#pragma checksum "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c30bea1fedfd4ec0974068f31176e1902f805ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonorAccount_RequestHistory), @"mvc.1.0.view", @"/Views/DonorAccount/RequestHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DonorAccount/RequestHistory.cshtml", typeof(AspNetCore.Views_DonorAccount_RequestHistory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c30bea1fedfd4ec0974068f31176e1902f805ac", @"/Views/DonorAccount/RequestHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_DonorAccount_RequestHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Client.Models.RequestToDonorModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DonorAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
  
    ViewData["Title"] = "RequestHistory";

#line default
#line hidden
            BeginContext(107, 454, true);
            WriteLiteral(@"
<section>
    <hr />
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h4 class=""text-center mb-3"">Blood Requests</h4>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                No.
                            </th>
                            <th>
                                ");
            EndContext();
            BeginContext(562, 44, false);
#line 20 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                           Write(Html.DisplayNameFor(model => model.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(606, 105, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(712, 42, false);
#line 24 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                           Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(754, 105, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(860, 41, false);
#line 28 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(901, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1005, 41, false);
#line 31 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                           Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1150, 42, false);
#line 34 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                           Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 107, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1300, 42, false);
#line 39 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 105, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1448, 49, false);
#line 43 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                           Write(Html.DisplayNameFor(model => model.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 168, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 50 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                          int i = 1;

#line default
#line hidden
            BeginContext(1704, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 51 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1785, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1894, 1, false);
#line 55 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1895, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2011, 43, false);
#line 58 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                               Write(Html.DisplayFor(modelItem => item.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 43, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n");
            EndContext();
#line 61 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                 if (item.gender == true)
                                {

#line default
#line hidden
            BeginContext(2191, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2274, 16, false);
#line 64 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                   Write(Html.Raw("Male"));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 66 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2443, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2526, 18, false);
#line 70 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                   Write(Html.Raw("Female"));

#line default
#line hidden
            EndContext();
            BeginContext(2544, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 72 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                }

#line default
#line hidden
            BeginContext(2624, 76, true);
            WriteLiteral("\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2701, 40, false);
#line 75 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                               Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
            EndContext();
            BeginContext(2741, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2857, 40, false);
#line 78 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                               Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
            EndContext();
            BeginContext(2897, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3013, 41, false);
#line 81 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                               Write(Html.DisplayFor(modelItem => item.amount));

#line default
#line hidden
            EndContext();
            BeginContext(3054, 45, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n\r\n");
            EndContext();
#line 85 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                 if (item.status == 1)
                                {

#line default
#line hidden
            BeginContext(3190, 122, true);
            WriteLiteral("                                    <td style=\"color:#28a745;font-weight:bold;\">\r\n                                        ");
            EndContext();
            BeginContext(3313, 18, false);
#line 88 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                   Write(Html.Raw("Accept"));

#line default
#line hidden
            EndContext();
            BeginContext(3331, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 90 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                }
                                else if (item.status == 2)
                                {

#line default
#line hidden
            BeginContext(3506, 122, true);
            WriteLiteral("                                    <td style=\"color:#dc3545;font-weight:bold;\">\r\n                                        ");
            EndContext();
            BeginContext(3629, 16, false);
#line 94 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                   Write(Html.Raw("Deny"));

#line default
#line hidden
            EndContext();
            BeginContext(3645, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 96 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                }

#line default
#line hidden
            BeginContext(3725, 109, true);
            WriteLiteral("                               \r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3835, 64, false);
#line 100 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                               Write(Html.ValueFor(modelItem => item.expected_date, "{0:dd/MM/yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(3899, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4014, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63bed11b4e804ce98b29e61795a09e83", async() => {
                BeginContext(4150, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                                                                                                                       WriteLiteral(Html.ValueFor(modelItem => item.rtdId));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4161, 78, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 107 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Views\DonorAccount\RequestHistory.cshtml"
                            i++;
                        }

#line default
#line hidden
            BeginContext(4300, 120, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Client.Models.RequestToDonorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
