#pragma checksum "C:\CodeGym\Practices\DapperMVC\DapperMVC\DapperMVC\Views\User\index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c21a8108d7709193bee464500a0368dc1d5d2c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_index3), @"mvc.1.0.view", @"/Views/User/index3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/index3.cshtml", typeof(AspNetCore.Views_User_index3))]
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
#line 1 "C:\CodeGym\Practices\DapperMVC\DapperMVC\DapperMVC\Views\_ViewImports.cshtml"
using DapperMVC;

#line default
#line hidden
#line 2 "C:\CodeGym\Practices\DapperMVC\DapperMVC\DapperMVC\Views\_ViewImports.cshtml"
using DapperMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c21a8108d7709193bee464500a0368dc1d5d2c5", @"/Views/User/index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28cc374985325cc8f7d1f779cbaca9500eece270", @"/Views/_ViewImports.cshtml")]
    public class Views_User_index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/user/user.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\CodeGym\Practices\DapperMVC\DapperMVC\DapperMVC\Views\User\index3.cshtml"
  
    ViewData["Title"] = "index";

#line default
#line hidden
            BeginContext(41, 1369, true);
            WriteLiteral(@"
<p>
    <a class=""btn btn-dark"" style=""color:white"" onClick=""user.showModal()"">Add User</a>
</p>
<table class=""table table-hover table-sm table-striped"">
    <thead class=""thead-dark"">
        <tr>
            <th>
                <lable class=""col-form-label"">User Name</lable>
            </th>
            <th>
                <lable class=""col-form-label"">DOB</lable>
            </th>
            <th>
                <lable class=""col-form-label"">User Mobile</lable>
            </th>
            <th>
                <lable class=""col-form-label"">User Email</lable>
            </th>
            <th>
                <lable class=""col-form-label"">Country Name</lable>
            </th>
            <th>
                <lable class=""col-form-label"">Job Name</lable>
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody id=""tbUser"">
    </tbody>
</table>

<div class=""modal"" id=""addEditModal"">
    <div class=""modal-dialog modal-lg"">
        <div class=""moda");
            WriteLiteral(@"l-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Add User</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(1410, 4776, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c21a8108d7709193bee464500a0368dc1d5d2c57581", async() => {
                BeginContext(1447, 4732, true);
                WriteLiteral(@"
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">User Name</label>
                        </div>
                        <div class=""col-sm-8"">
                            <input id=""UserName"" name=""UserName"" data-msg-required=""This field is required"" class=""form-control"" required />
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">User Mobile</label>
                        </div>
                        <div class=""col-sm-8"">
                            <input id=""UserMobile"" type=""tel"" data-msg-required=""This field is required"" class=""form-control"" required />
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
             ");
                WriteLiteral(@"               <label class=""control-label"">User Email</label>
                        </div>
                        <div class=""col-sm-8"">
                            <input id=""UserEmail"" type=""email"" data-msg-required=""This field is required"" name=""UserEmail"" class=""form-control"" required />
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">DOB</label>
                        </div>
                        <div class=""col-sm-8"">
                            <input id=""DOB"" type=""date"" data-msg-required=""This field is required"" class=""form-control"" required />
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">FaceBookUrl</label>
                        </div>
              ");
                WriteLiteral(@"          <div class=""col-sm-8"">
                            <input id=""FaceBookUrl"" type=""url"" data-msg-required=""This field is required"" name=""FaceBookUrl"" class=""form-control"" required />
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">Linkedin Url</label>
                        </div>
                        <div class=""col-sm-8"">
                            <input id=""LinkedInUrl"" type=""url"" data-msg-required=""This field is required"" name=""LinkedInUrl"" class=""form-control"" required />
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">Twitter Url</label>
                        </div>
                        <div class=""col-sm-8"">
                            <input id=""");
                WriteLiteral(@"TwitterUrl"" type=""url"" data-msg-required=""This field is required"" name=""TwitterUrl"" class=""form-control"" required />
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">Personal WebUrl</label>
                        </div>
                        <div class=""col-sm-8"">
                            <input id=""PersonalWebUrl"" type=""url"" data-msg-required=""This field is required"" name=""PersonalWebUrl"" class=""form-control"" required />
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">Job Name</label>
                        </div>
                        <div class=""col-sm-8"">
                            <select id=""JobId"" data-msg-required=""This field is required"" name=""JobId"" class");
                WriteLiteral(@"=""form-control"" required>
                            </select>
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-sm-4"">
                            <label class=""control-label"">Country</label>
                        </div>
                        <div class=""col-sm-8"">
                            <select id=""CountryId"" data-msg-required=""This field is required"" name=""CountryId"" class=""form-control"" required>
                            </select>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6186, 357, true);
            WriteLiteral(@"
            </div>

            <!-- Modal footer -->
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cancel</button>
                <a href=""javascript:void(0);"" class=""btn btn-info"" onclick=""user.save()"">Save</a>
            </div>

        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(6543, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c21a8108d7709193bee464500a0368dc1d5d2c514728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6594, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6596, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c21a8108d7709193bee464500a0368dc1d5d2c515908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6651, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6653, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c21a8108d7709193bee464500a0368dc1d5d2c517088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6724, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6726, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c21a8108d7709193bee464500a0368dc1d5d2c518268", async() => {
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
            EndContext();
            BeginContext(6801, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6803, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c21a8108d7709193bee464500a0368dc1d5d2c519448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
