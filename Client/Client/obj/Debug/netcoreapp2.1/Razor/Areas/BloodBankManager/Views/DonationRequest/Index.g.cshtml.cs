#pragma checksum "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "107660a104953ed1fdabee8034e15b61bf0f1b02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodBankManager_Views_DonationRequest_Index), @"mvc.1.0.view", @"/Areas/BloodBankManager/Views/DonationRequest/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BloodBankManager/Views/DonationRequest/Index.cshtml", typeof(AspNetCore.Areas_BloodBankManager_Views_DonationRequest_Index))]
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
#line 3 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107660a104953ed1fdabee8034e15b61bf0f1b02", @"/Areas/BloodBankManager/Views/DonationRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Areas/BloodBankManager/Views/_ViewImports.cshtml")]
    public class Areas_BloodBankManager_Views_DonationRequest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Client.Models.DonationRequestModelB>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "rqDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DonationRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/BloodBankManager/Views/Shared/Admin.cshtml";

#line default
#line hidden
            BeginContext(209, 127, true);
            WriteLiteral("<div class=\"row pt-2\">\r\n    <div class=\"col-12\">\r\n        <h3 class=\"text-center\">List Donation Request </h3>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(336, 393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab41b30caff24d8f9b7fb7ee83bc742b", async() => {
                BeginContext(416, 306, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""sr-only"" for="""">label</label>
            <input class=""form-control"" name=""name"" placeholder=""Search By Pateint Name..."">
        </div>
        <button type=""submit"" class=""btn btn-default mr-1""><i class=""fas fa-search""></i></button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(729, 90, true);
            WriteLiteral("\r\n    <hr />\r\n    <div class=\"col-12\">\r\n        <h5 class=\"text-center\" style=\"color:red\">");
            EndContext();
            BeginContext(820, 13, false);
#line 21 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                                             Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(833, 196, true);
            WriteLiteral(" </h5>\r\n    </div>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    No.\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1030, 62, false);
#line 31 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().donorName));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 69, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1162, 63, false);
#line 35 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().donorEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1293, 63, false);
#line 38 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().donorPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1424, 67, false);
#line 41 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().donorBloodName));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1559, 64, false);
#line 44 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().donorStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1691, 59, false);
#line 47 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().amount));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1818, 59, false);
#line 50 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().status));

#line default
#line hidden
            EndContext();
            BeginContext(1877, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1945, 66, false);
#line 53 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 110, true);
            WriteLiteral("\r\n                </th>\r\n\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 61 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
              int i = 1;

#line default
#line hidden
            BeginContext(2148, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 62 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2205, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2278, 1, false);
#line 66 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2279, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2359, 44, false);
#line 69 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donorName));

#line default
#line hidden
            EndContext();
            BeginContext(2403, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2483, 45, false);
#line 72 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donorEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2608, 45, false);
#line 75 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donorPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2653, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2735, 49, false);
#line 79 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donorBloodName));

#line default
#line hidden
            EndContext();
            BeginContext(2784, 31, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n");
            EndContext();
#line 82 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                     if (item.donorStatus == true)
                    {

#line default
#line hidden
            BeginContext(2890, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2949, 16, false);
#line 85 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                       Write(Html.Raw("Male"));

#line default
#line hidden
            EndContext();
            BeginContext(2965, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 87 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3070, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(3129, 18, false);
#line 91 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                       Write(Html.Raw("Female"));

#line default
#line hidden
            EndContext();
            BeginContext(3147, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 93 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3203, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(3254, 41, false);
#line 95 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.amount));

#line default
#line hidden
            EndContext();
            BeginContext(3295, 107, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3402, "\"", 3561, 5);
            WriteAttributeValue("", 3409, "/BloodBankManager/DonationRequest/Confirm/?rqId=", 3409, 48, true);
#line 99 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
WriteAttributeValue("", 3457, Html.DisplayFor(modelItem => item.drId), 3457, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 3497, "&bloodId=", 3497, 9, true);
#line 99 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
WriteAttributeValue("", 3506, Html.DisplayFor(modelItem => item.donorBloodId), 3506, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 3554, "&type=1", 3554, 7, true);
            EndWriteAttribute();
            BeginContext(3562, 83, true);
            WriteLiteral(" style=\"color:white;\">Accept</a>\r\n                        <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3645, "\"", 3804, 5);
            WriteAttributeValue("", 3652, "/BloodBankManager/DonationRequest/Confirm/?rqId=", 3652, 48, true);
#line 100 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
WriteAttributeValue("", 3700, Html.DisplayFor(modelItem => item.drId), 3700, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 3740, "&bloodId=", 3740, 9, true);
#line 100 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
WriteAttributeValue("", 3749, Html.DisplayFor(modelItem => item.donorBloodId), 3749, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 3797, "&type=2", 3797, 7, true);
            EndWriteAttribute();
            BeginContext(3805, 110, true);
            WriteLiteral(" style=\"color:white;\">Denie</a>\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3916, 48, false);
#line 103 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(3964, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4045, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ed651a403d4b74a98fab94d3558f11", async() => {
                BeginContext(4157, 26, true);
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                                                                                    WriteLiteral(item.drId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4187, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 110 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
                i++;
            }

#line default
#line hidden
            BeginContext(4276, 115, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div style=\"text-align:center\">\r\n        <h2 class=\"text-danger\">\r\n            ");
            EndContext();
            BeginContext(4392, 16, false);
#line 116 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
       Write(TempData["errD"]);

#line default
#line hidden
            EndContext();
            BeginContext(4408, 63, true);
            WriteLiteral("\r\n        </h2>\r\n        <h2 class=\"text-danger\">\r\n            ");
            EndContext();
            BeginContext(4472, 15, false);
#line 119 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
       Write(TempData["err"]);

#line default
#line hidden
            EndContext();
            BeginContext(4487, 25, true);
            WriteLiteral("\r\n        </h2>\r\n        ");
            EndContext();
            BeginContext(4513, 293, false);
#line 121 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\BloodBankManager\Views\DonationRequest\Index.cshtml"
   Write(Html.PagedListPager(Model, page => Url.Action("Index", new { name = @ViewBag.key,page = page    }),
           new PagedListRenderOptions
           {
               LiElementClasses = new string[] { "page-item" },
               PageClasses = new string[] { "page-link" }

           }));

#line default
#line hidden
            EndContext();
            BeginContext(4806, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Client.Models.DonationRequestModelB>> Html { get; private set; }
    }
}
#pragma warning restore 1591
