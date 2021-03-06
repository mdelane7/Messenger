#pragma checksum "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1778e908dbdf248d85cf4d4ac97976b53ea960b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partials__JobsPartial), @"mvc.1.0.view", @"/Views/Home/Partials/_JobsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Partials/_JobsPartial.cshtml", typeof(AspNetCore.Views_Home_Partials__JobsPartial))]
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
#line 3 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
using HireMe.Services.Interfaces;

#line default
#line hidden
#line 4 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1778e908dbdf248d85cf4d4ac97976b53ea960b", @"/Views/Home/Partials/_JobsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682bcd9d83d74065f4b1dc0ce11e260e29aaaf2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Partials__JobsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HireMe.ViewModels.Favorites.FavoritesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Favorites", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToFavouite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon text-center d-flex justify-content-center align-items-center icon mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(296, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(337, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
  
    int jobPostsToShow = 12;
    int companiesToShow = 5;

    var posterId = UserManager.GetUserId(User);

#line default
#line hidden
            BeginContext(457, 515, true);
            WriteLiteral(@"

<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9 pr-lg-5"">

                <div class=""row justify-content-center pb-3"">
                    <div class=""col-md-12 heading-section ftco-animate"">
                        <span class=""subheading"">Recently Added Jobs</span>
                        <h2 class=""mb-4"">Last Added Jobs</h2>
                    </div>
                </div>

                <div class=""row"">

");
            EndContext();
#line 35 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                      

                        foreach (var item in JobsService.GetLastJobs(jobPostsToShow, null))
                        {

#line default
#line hidden
            BeginContext(1118, 334, true);
            WriteLiteral(@"                            <div class=""col-md-12 ftco-animate"">

                                                    <div class=""job-post-item p-4 d-block d-lg-flex align-items-center"">

                                                        <div class=""col-md-2"">
                                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1483, 2);
            WriteAttributeValue("", 1459, "../Jobs/Details/", 1459, 16, true);
#line 44 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
WriteAttributeValue("", 1475, item.Id, 1475, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1484, 67, true);
            WriteLiteral(">\r\n                                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1551, "\"", 1567, 1);
#line 45 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
WriteAttributeValue("", 1557, item.Logo, 1557, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1568, 499, true);
            WriteLiteral(@" alt=""Image"" width=""100"" height=""100"" class=""rounded mx-auto d-block"">
                                                            </a>
                                                        </div>

                                                        <div class=""one-third mb-4 mb-md-0"">
                                                            <div class=""job-post-item-header align-items-center"">
                                                                <span class=""subadge"">");
            EndContext();
            BeginContext(2068, 13, false);
#line 51 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                                 Write(item.WorkType);

#line default
#line hidden
            EndContext();
            BeginContext(2081, 104, true);
            WriteLiteral("</span>\r\n                                                                <h2 class=\"mr-3 text-black\"> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2185, "\"", 2216, 2);
            WriteAttributeValue("", 2192, "../Jobs/JobPost/", 2192, 16, true);
#line 52 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
WriteAttributeValue("", 2208, item.Id, 2208, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2217, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2219, 9, false);
#line 52 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                                                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2228, 103, true);
            WriteLiteral("</a></h2>\r\n                                                                <h4 class=\"mr-3 text-black\">");
            EndContext();
            BeginContext(2332, 10, false);
#line 53 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                                       Write(item.About);

#line default
#line hidden
            EndContext();
            BeginContext(2342, 314, true);
            WriteLiteral(@"</h4>
                                                            </div>
                                                            <div class=""job-post-item-body d-block d-md-flex"">
                                                                <div class=""mr-3""><span class=""icon-my_location""></span> <span>");
            EndContext();
            BeginContext(2657, 11, false);
#line 56 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                                                                          Write(item.Adress);

#line default
#line hidden
            EndContext();
            BeginContext(2668, 149, true);
            WriteLiteral("</span></div>\r\n                                                                <div class=\"mr-3\"><div><span class=\"icon-location_city\"></span> <span>");
            EndContext();
            BeginContext(2818, 13, false);
#line 57 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                                                                                 Write(item.Location);

#line default
#line hidden
            EndContext();
            BeginContext(2831, 147, true);
            WriteLiteral("</span></div></div>\r\n                                                                <div class=\"mr-3\"><div><span class=\"icon-money\"></span> <span>");
            EndContext();
            BeginContext(2979, 14, false);
#line 58 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                                                                         Write(item.MaxSalary);

#line default
#line hidden
            EndContext();
            BeginContext(2993, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2997, 14, false);
#line 58 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                                                                                           Write(item.MaxSalary);

#line default
#line hidden
            EndContext();
            BeginContext(3011, 440, true);
            WriteLiteral(@" EUR / per month</span></div></div>
                                                            </div>
                                                        </div>




                                                        <div class=""one-forth ml-auto d-flex align-items-center mt-4 md-md-0"">
                                                            <div>


                                                                ");
            EndContext();
            BeginContext(3451, 412, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1778e908dbdf248d85cf4d4ac97976b53ea960b13396", async() => {
                BeginContext(3619, 240, true);
                WriteLiteral("\r\n\r\n                                                                    <span class=\"icon-heart\">\r\n                                                                    </span>\r\n                                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-jobId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jobId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-jobId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jobId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3863, 132, true);
            WriteLiteral("\r\n                                                            </div>\r\n                                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3995, "\"", 4026, 2);
            WriteAttributeValue("", 4002, "../Jobs/Details/", 4002, 16, true);
#line 75 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
WriteAttributeValue("", 4018, item.Id, 4018, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4027, 217, true);
            WriteLiteral(" class=\"btn btn-primary py-2\">Apply Job</a>\r\n                                                        </div>\r\n                                                    </div>\r\n                            </div><!-- end -->\r\n");
            EndContext();
#line 79 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4294, 366, true);
            WriteLiteral(@"




                </div>
            </div>



            <div class=""col-lg-3 sidebar"">
                <div class=""row justify-content-center pb-3"">
                    <div class=""col-md-12 heading-section ftco-animate"">
                        <h2 class=""mb-4"">Top Companies By Rating</h2>
                    </div>
                </div>

");
            EndContext();
#line 98 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                  

                    foreach (var item in CompanyService.GetTopCompanies(companiesToShow))
                    {

#line default
#line hidden
            BeginContext(4796, 142, true);
            WriteLiteral("                        <div class=\"sidebar-box ftco-animate\">\r\n                            <div class=\"\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4938, "\"", 4974, 2);
            WriteAttributeValue("", 4945, "../Companies/Details/", 4945, 21, true);
#line 104 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
WriteAttributeValue("", 4966, item.Id, 4966, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4975, 60, true);
            WriteLiteral(" class=\"company-wrap\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5035, "\"", 5051, 1);
#line 105 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
WriteAttributeValue("", 5041, item.Logo, 5041, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5052, 164, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"\">\r\n                                </a>\r\n                                <div class=\"text p-3\">\r\n                                    <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5216, "\"", 5250, 2);
            WriteAttributeValue("", 5223, "../Company/Details/", 5223, 19, true);
#line 108 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
WriteAttributeValue("", 5242, item.Id, 5242, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5251, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5253, 10, false);
#line 108 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"
                                                                         Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(5263, 119, true);
            WriteLiteral("</a></h3>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 112 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Home\Partials\_JobsPartial.cshtml"

                    }
                

#line default
#line hidden
            BeginContext(5426, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IFavoritesService FavoritesService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICompanyService CompanyService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJobsService JobsService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICategoriesService CategoriesService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HireMe.ViewModels.Favorites.FavoritesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
