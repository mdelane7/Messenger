#pragma checksum "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Company\_LayoutAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "893de126ed1d9037e75cb950b11bfcf7529f7e22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company__LayoutAccount), @"mvc.1.0.view", @"/Views/Company/_LayoutAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/_LayoutAccount.cshtml", typeof(AspNetCore.Views_Company__LayoutAccount))]
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
#line 1 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe;

#line default
#line hidden
#line 2 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe.Models;

#line default
#line hidden
#line 3 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe.Services;

#line default
#line hidden
#line 4 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe.Data;

#line default
#line hidden
#line 5 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"893de126ed1d9037e75cb950b11bfcf7529f7e22", @"/Views/Company/_LayoutAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682bcd9d83d74065f4b1dc0ce11e260e29aaaf2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Company__LayoutAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1006, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "893de126ed1d9037e75cb950b11bfcf7529f7e223847", async() => {
                BeginContext(31, 115, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\" />\r\n\r\n    <title>");
                EndContext();
                BeginContext(147, 17, false);
#line 7 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Company\_LayoutAccount.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(164, 860, true);
                WriteLiteral(@" - HireMe</title>

    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name=""viewport"" content=""width=device-width"" />

    <!--     Fonts and icons     -->
    <link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css"" />

    <!-- CSS Files -->
    <link href=""../account_panel/assets/css/bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""../account_panel/assets/css/material-bootstrap-wizard.css"" rel=""stylesheet"" />

    <!-- CSS Just for demo purpose, don't include it in your project -->
    <link href=""../account_panel/assets/css/demo.css"" rel=""stylesheet"" />

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1031, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1033, 846, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "893de126ed1d9037e75cb950b11bfcf7529f7e226398", async() => {
                BeginContext(1039, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1046, 12, false);
#line 25 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Company\_LayoutAccount.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1058, 768, true);
                WriteLiteral(@"


    <script src=""https://cdn.tiny.cloud/1/5686hr5wxm6w1y166bl2p3ehoq73ru6uqqyq59vl2htfmy3o/tinymce/5/tinymce.min.js""></script>


    <script>
    tinymce.init({
        selector: '#mytextarea',
        icons: 'material',
        height: 700,
        width: 850
    });
    </script>


    <script src=""../account_panel/assets/js/jquery-2.2.4.min.js"" type=""text/javascript""></script>
    <script src=""../account_panel/assets/js/bootstrap.min.js"" type=""text/javascript""></script>
    <script src=""../account_panel/assets/js/jquery.bootstrap.js"" type=""text/javascript""></script>
    <script src=""../account_panel/assets/js/material-bootstrap-wizard.js""></script>
    <script src=""../account_panel/assets/js/jquery.validate.min.js""></script>

    ");
                EndContext();
                BeginContext(1827, 41, false);
#line 47 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Company\_LayoutAccount.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1868, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1879, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
