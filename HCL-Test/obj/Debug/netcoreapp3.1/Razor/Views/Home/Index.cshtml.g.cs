#pragma checksum "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4d13a5189faedaa4b89d108899bb682a8cfe54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\_ViewImports.cshtml"
using HCL_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\_ViewImports.cshtml"
using HCL_Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4d13a5189faedaa4b89d108899bb682a8cfe54", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af14724e89a1e9ed4eb3646b4e6c5b8105dd0811", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HCL_Test.Models.Series>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4d13a5189faedaa4b89d108899bb682a8cfe543409", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\Home\Index.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post, new { enctype = "multipart/formdata" }))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <h4>Dynamic Series</h4>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4d13a5189faedaa4b89d108899bb682a8cfe544046", async() => {
                    WriteLiteral("\r\n                <div class=\"form-group row\">\r\n                    <label for=\"NumberInSeries\" class=\"col-sm-3\">NumberInSeries</label>\r\n\r\n                    <div>\r\n                        ");
#nullable restore
#line 15 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\Home\Index.cshtml"
                   Write(Html.EditorFor(model => model.NumberInSeries, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group row\">\r\n                    <label for=\"Divisor\" class=\"col-sm-3\">Divisor</label>\r\n\r\n                    <div>\r\n                        ");
#nullable restore
#line 22 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\Home\Index.cshtml"
                   Write(Html.EditorFor(model => model.Divisor, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group row\">\r\n                    <label for=\"Number\" class=\"col-sm-3\">Number</label>\r\n\r\n                    <div>\r\n                        ");
#nullable restore
#line 29 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\Home\Index.cshtml"
                   Write(Html.EditorFor(model => model.Number, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <button type=\"submit\" class=\".btn btn-light\" value=\"Create\">Submit</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"form-group row\">\r\n        <label for=\"DynamicSeries\" class=\"col-sm-3\">DynamicSeries</label>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 41 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(model => model.DynamicSeries, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <label for=\"Output\" class=\"col-sm-3\">Output</label>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 48 "C:\Users\Lenovo\OneDrive\Desktop\HCL-TestProblem\HCL-Test\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(model => model.Output, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HCL_Test.Models.Series> Html { get; private set; }
    }
}
#pragma warning restore 1591