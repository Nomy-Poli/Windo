#pragma checksum "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0e936ebf63fd00538dbcd5bcc170d62b61e801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CMS_CORE_NG.Areas.Admin.Views.SiteSettings.Areas_Admin_Views_SiteSettings_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SiteSettings/Index.cshtml")]
namespace CMS_CORE_NG.Areas.Admin.Views.SiteSettings
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0e936ebf63fd00538dbcd5bcc170d62b61e801", @"/Areas/Admin/Views/SiteSettings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ed1de5d780e00e7b0de232aaa23ac7cf849112", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aecc07a880dc522f0d7b106af9664f10e1adf68", @"/Areas/Admin/Views/SiteSettings/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_SiteSettings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelService.AdminBaseViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sitewideSettingsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/limonte-sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
  
    ViewData["Title"] = "Site Settings";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <section class=""sec-wrapper"">
        <a href=""https://analytics.google.com/analytics/web/#/a208851604p288083444/admin"" target=""_blank"">
            <button style=""{ border: 1px solid #373CF5;
    border-radius: .8rem;
    background-color: white;
    color: #373CF5;
    padding: .5rem .8rem;
}"">Google Analytics</button>
        </a>
        <fieldset class=""border p-4"">
            <legend class=""w-auto"">הגדרות האתר</legend>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e8016163", async() => {
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3 form-group\">\r\n                        <label for=\"websiteName\">שם האתר</label>\r\n                        <input class=\"form-control\" id=\"websiteName\" placeholder=\"eg: Windo.com\"");
                BeginWriteAttribute("value", " value=\"", 865, "\"", 907, 1);
#nullable restore
#line 22 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
WriteAttributeValue("", 873, Model.SiteWideSetting.WebsiteName, 873, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                    </div>
                    <div class=""col-md-3 form-group"">
                        <label for=""websiteAuthor"">מנהל האתר</label>
                        <input class=""form-control"" id=""websiteAuthor"" placeholder=""eg: Lyoid Lopes""");
                BeginWriteAttribute("value", " value=\"", 1176, "\"", 1220, 1);
#nullable restore
#line 26 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
WriteAttributeValue("", 1184, Model.SiteWideSetting.WebsiteAuthor, 1184, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\">\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        <label for=\"websiteTitle\">כותרת האתר (עד 50 אותיות)</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1455, "\"", 1498, 1);
#nullable restore
#line 30 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
WriteAttributeValue("", 1463, Model.SiteWideSetting.WebsiteTitle, 1463, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""websiteTitle"" placeholder=""eg: Learn To Code With Windo | Take Your Future to Next Level"" type=""text"">
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-12 form-group"">
                        <label for=""websiteDescription"">תאור האתר (עד 50 אותיות)</label>
                        <textarea class=""form-control"" id=""websiteDescription"" placeholder=""eg: Join Our Community Of 80,000 Students. Whatever Your Goal - We'll Get You There. Try It Free"">");
#nullable restore
#line 36 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
                                                                                                                                                                                         Write(Model.SiteWideSetting.WebsiteDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-12 form-group"">
                        <label for=""websiteKeywords"">מילות מפתח (מקסימום 5 מילות מפתח - פסיק (,) מופרד)</label>
                        <input class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2392, "\"", 2438, 1);
#nullable restore
#line 42 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
WriteAttributeValue("", 2400, Model.SiteWideSetting.WebsiteKeywords, 2400, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""websiteKeywords"" placeholder=""eg: Windo tutorials, learn asp.net core, learn asp.net mvc, learn asp.net web api, learn angular"" type=""text"">
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-12 form-group"">
                        <label for=""websiteFooter"">כותרת תחתונה לאתר (מקסימום 50 אותיות)</label>
                        <input class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2878, "\"", 2922, 1);
#nullable restore
#line 48 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
WriteAttributeValue("", 2886, Model.SiteWideSetting.WebsiteFooter, 2886, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""websiteFooter"" placeholder=""eg: CMS Core Angular Admin Panel Windo©2020"" type=""text"">
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 form-group"">
                        <label for=""websiteStatus"">סטטוס האתר</label>
                        <select class=""form-control custom-select"" id=""websiteStatus"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80111425", async() => {
#nullable restore
#line 55 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
                                                 Write(Model.SiteWideSetting.WebsiteStatus);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80113324", async() => {
                    WriteLiteral("פעיל");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80114574", async() => {
                    WriteLiteral("מושבת");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80115825", async() => {
                    WriteLiteral("מתוחזק");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80117077", async() => {
                    WriteLiteral("בקרוב יופעל");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""col-md-4 form-group"">
                        <label for=""registrationStatus"">הרשמה</label>
                        <select class=""form-control custom-select"" id=""registrationStatus"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80118623", async() => {
#nullable restore
#line 65 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
                                                  Write(Model.SiteWideSetting.WebsiteRegistration == false ? "Disabled" : "Active");

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80120562", async() => {
                    WriteLiteral("פעיל");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80121812", async() => {
                    WriteLiteral("מושבת");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""col-md-4 form-group"">
                        <label for=""ageVerification"">אימות גיל</label>
                        <select class=""form-control custom-select"" id=""ageVerification"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80123350", async() => {
#nullable restore
#line 73 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
                                                  Write(Model.SiteWideSetting.AgeVerification == false ? "Disabled" : "Active");

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80125285", async() => {
                    WriteLiteral("פעיל");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80126535", async() => {
                    WriteLiteral("מושבת");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""row text-right"">
                    <div class=""col"">
                        <button class=""btn btn-primary btn-md mt-3 d-none d-md-inline-block d-sm-none"" id=""btnMdUpdateSiteWideSettings"">
                            <span class=""btn-text""><i class=""fas fa-pen mr-2 pl-2""></i>עדכון</span>
                        </button>
                        <!-- Only visible on small Screen -->
                        <button class=""btn btn-primary btn-md mt-3 btn-block d-block  d-md-none"" id=""btnSmUpdateSiteWideSettings"">
                            <span class=""btn-text""><i class=""fas fa-pen mr-2 pl-2""></i>עדכון</span>
                        </button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </fieldset>
    </section>
</div>

<div class=""modal"" id=""updateSuccessModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal Heading</h4>
");
            WriteLiteral(@"            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                העלה מחדש את הדף כדי לראות שינויים
            </div>

            <!-- Modal footer -->
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"" id=""reloadPageBtn"">העלאה מחדש</button>
            </div>

        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0e936ebf63fd00538dbcd5bcc170d62b61e80130547", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>

        $(function() {
           $('#btnMdUpdateSiteWideSettings').click(function(e) {
               e.preventDefault();
               UpdateSiteWideSettings();
           });

           $('#btnSmUpdateSiteWideSettings').click(function(e) {
                    e.preventDefault();
                   UpdateSiteWideSettings();
           });


           $('#reloadPageBtn').click(function(e) {
                e.preventDefault();
                window.location.reload();
           });
        });


        function UpdateSiteWideSettings() {

          let websiteName = $(""#websiteName"").val();
          let websiteTitle = $(""#websiteTitle"").val();
          let websiteDescription = $(""#websiteDescription"").val();
          let websiteAuthor = $(""#websiteAuthor"").val();
          let websiteKeywords = $(""#websiteKeywords"").val();
          let websiteFooter = $(""#websiteFooter"").val();
          let websiteStatus = $('#websiteStatus :selected').text();
          ");
                WriteLiteral(@"let registrationStatus = ($('#registrationStatus :selected').text() === ""Active"");
          let ageVerification =  ($('#ageVerification :selected').text() === ""Active"");

          const siteWideSettings =
          {
              ""WebsiteName"" : websiteName,
              ""WebsiteTitle"" : websiteTitle,
              ""WebsiteDescription"" : websiteDescription,
              ""WebsiteKeywords"" : websiteKeywords,
              ""WebsiteAuthor"" : websiteAuthor,
              ""WebsiteFooter"" : websiteFooter,
              ""WebsiteStatus"" : websiteStatus,
              ""WebsiteRegistration"" : registrationStatus,
              ""AgeVerification"" : ageVerification
          };

          console.log(siteWideSettings);

          $.ajax({
              type: 'POST',
              url: """);
#nullable restore
#line 173 "C:\TFS\WINDO\busoftBase\CMS_CORE_NG\Areas\Admin\Views\SiteSettings\Index.cshtml"
               Write(Url.Action("UpdateSettings", "SiteSettings"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
              contentType: ""application/json; charset=utf-8"",
              dataType: ""json"",
              data: JSON.stringify(siteWideSettings),
              headers: {
                  'X-XSRF-TOKEN': getCookie(""XSRF-TOKEN""),
              },
              success: function (result) {
                  console.log(result);
                  if (result)
                  {
                      console.log(""עבר בהצלחה"");
                      $("".container-fluid"").css({ opacity: 0.5 });
                      $(""#updateSuccessModal .modal-title"").text(""ההגדרות של כל האתר עודכנו"")
                      $(""#updateSuccessModal"").show();
                  }
              },
              error: function() {
                alert(""שגיאה: הבקשה יכולה להיות באמצע עיבוד, נסה שוב מאוחר יותר"");
              }
          });
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelService.AdminBaseViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
