#pragma checksum "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "099bd7b95077c0accf7479d39b6b1b2a9fa85763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MobiLink_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MobiLink/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/MobiLink/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_MobiLink_Index))]
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
#line 3 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"099bd7b95077c0accf7479d39b6b1b2a9fa85763", @"/Areas/Admin/Views/MobiLink/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MobiLink_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Client.Models.MobiLinkRequestModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MobiLink", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/Admin.cshtml";

#line default
#line hidden
            BeginContext(197, 73, true);
            WriteLiteral("\r\n<hr />\r\n<h4 class=\"text-center \">List MobiLink Notification</h4>\r\n<p>\r\n");
            EndContext();
            BeginContext(317, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(321, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07bd842a76cd4367847bffce3504e298", async() => {
                BeginContext(413, 7, true);
                WriteLiteral("Add new");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(424, 12, true);
            WriteLiteral("\r\n\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(436, 596, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c68dcd2ea65486a87855be235f49f0c", async() => {
                BeginContext(520, 366, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label class=""sr-only"" for="""">label</label>
        <input class=""form-control"" name=""name"" placeholder=""Search By Pateint Name..."">
    </div>
    <button type=""submit"" class=""btn btn-default mr-1""><i class=""fas fa-search""></i></button>
    <div class=""col-8"">
        <h4 class=""text-danger  text-center"">
            ");
                EndContext();
                BeginContext(887, 17, false);
#line 25 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
       Write(TempData["Error"]);

#line default
#line hidden
                EndContext();
                BeginContext(904, 77, true);
                WriteLiteral("\r\n        </h4>\r\n        <h4 class=\"text-success  text-center\">\r\n            ");
                EndContext();
                BeginContext(982, 14, false);
#line 28 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
       Write(TempData["Ok"]);

#line default
#line hidden
                EndContext();
                BeginContext(996, 29, true);
                WriteLiteral("\r\n        </h4>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1032, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1119, 58, false);
#line 36 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().mlrId));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1233, 61, false);
#line 39 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().fullname));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1352, 58, false);
#line 43 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().email));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1466, 58, false);
#line 46 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().phone));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1582, 59, false);
#line 50 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().status));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1699, 62, false);
#line 54 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().bloodName));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1817, 66, false);
#line 57 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 88, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2020, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2081, 40, false);
#line 68 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.mlrId));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2189, 43, false);
#line 71 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.fullname));

#line default
#line hidden
            EndContext();
            BeginContext(2232, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2302, 40, false);
#line 75 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
            EndContext();
            BeginContext(2342, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2410, 40, false);
#line 78 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 27, true);
            WriteLiteral("\r\n                </td>\r\n\r\n");
            EndContext();
#line 81 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
                 if (item.status == 1)
                {

#line default
#line hidden
            BeginContext(2536, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2587, 16, false);
#line 84 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
                   Write(Html.Raw("Hide"));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 86 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2692, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2743, 16, false);
#line 90 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
                   Write(Html.Raw("Show"));

#line default
#line hidden
            EndContext();
            BeginContext(2759, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 92 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2807, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2850, 44, false);
#line 94 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.bloodName));

#line default
#line hidden
            EndContext();
            BeginContext(2894, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2962, 48, false);
#line 97 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.expected_date));

#line default
#line hidden
            EndContext();
            BeginContext(3010, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3079, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6fd4fae4c4d4522a5b249416b5fe853", async() => {
                BeginContext(3201, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
                                           WriteLiteral(item.mlrId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3232, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3254, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6528d322c49844ddbe274203fed69d28", async() => {
                BeginContext(3376, 26, true);
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
                                              WriteLiteral(item.mlrId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3406, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3428, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efdc8bb48f9c4f59acd86db1ab3fdf7f", async() => {
                BeginContext(3593, 28, true);
                WriteLiteral("<i class=\"fas fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
                                             WriteLiteral(item.mlrId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3625, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 106 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3680, 95, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div style=\"text-align:center\">\r\n    <h2 class=\"text-danger\">\r\n        ");
            EndContext();
            BeginContext(3776, 16, false);
#line 111 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
   Write(TempData["errD"]);

#line default
#line hidden
            EndContext();
            BeginContext(3792, 51, true);
            WriteLiteral("\r\n    </h2>\r\n    <h2 class=\"text-danger\">\r\n        ");
            EndContext();
            BeginContext(3844, 15, false);
#line 114 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
   Write(TempData["err"]);

#line default
#line hidden
            EndContext();
            BeginContext(3859, 17, true);
            WriteLiteral("\r\n    </h2>\r\n    ");
            EndContext();
            BeginContext(3877, 273, false);
#line 116 "D:\C#\BloodBank_Group3\Blood Bank System\Client\Client\Areas\Admin\Views\MobiLink\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { name = @ViewBag.key,page = page    }),
       new PagedListRenderOptions
       {
           LiElementClasses = new string[] { "page-item" },
           PageClasses = new string[] { "page-link" }

       }));

#line default
#line hidden
            EndContext();
            BeginContext(4150, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Client.Models.MobiLinkRequestModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
