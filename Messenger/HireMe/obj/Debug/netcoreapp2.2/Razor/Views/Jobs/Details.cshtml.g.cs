#pragma checksum "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e8adf4a8a1e545f5776e3e7b235ad5483112dc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jobs_Details), @"mvc.1.0.view", @"/Views/Jobs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jobs/Details.cshtml", typeof(AspNetCore.Views_Jobs_Details))]
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
#line 3 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
using HireMe.Services.Interfaces;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e8adf4a8a1e545f5776e3e7b235ad5483112dc1", @"/Views/Jobs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682bcd9d83d74065f4b1dc0ce11e260e29aaaf2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Jobs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HireMe.ViewModels.Jobs.JobsViewModel2>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Partials/_NavMenuPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-5 bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Partials/_FooterPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "../Home/_Layout.cshtml";

#line default
#line hidden
            BeginContext(236, 27, true);
            WriteLiteral("}\r\n\r\n\r\n<!-- menu Area -->\r\n");
            EndContext();
            BeginContext(263, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e8adf4a8a1e545f5776e3e7b235ad5483112dc16598", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(314, 274, true);
            WriteLiteral(@"


<section class=""ftco-section ftco-degree-bg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 ftco-animate"">

                <div class=""col d-flex justify-content-center"">
                    <p>
                        ");
            EndContext();
            BeginContext(588, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1e8adf4a8a1e545f5776e3e7b235ad5483112dc18135", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 616, "~/", 616, 2, true);
#line 24 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
AddHtmlAttributeValue("", 618, Model.Logo, 618, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 636, "~/", 636, 2, true);
#line 24 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
AddHtmlAttributeValue("", 638, Model.Logo, 638, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(651, 249, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <hr>\r\n                <div class=\"one-third mb-4 mb-md-0\">\r\n                    <div class=\"job-post-item-header align-items-center\">\r\n                        <span class=\"subadge\">");
            EndContext();
            BeginContext(901, 14, false);
#line 30 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
                                         Write(Model.WorkType);

#line default
#line hidden
            EndContext();
            BeginContext(915, 196, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"job-post-item-body d-block d-md-flex\">\r\n                        <div class=\"mr-3\"><span class=\"icon-my_location\"></span> <span>");
            EndContext();
            BeginContext(1112, 12, false);
#line 33 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
                                                                                  Write(Model.Adress);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 109, true);
            WriteLiteral("</span></div>\r\n                        <div class=\"mr-3\"><div><span class=\"icon-location_city\"></span> <span>");
            EndContext();
            BeginContext(1234, 14, false);
#line 34 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
                                                                                         Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(1248, 107, true);
            WriteLiteral("</span></div></div>\r\n                        <div class=\"mr-3\"><div><span class=\"icon-money\"></span> <span>");
            EndContext();
            BeginContext(1356, 15, false);
#line 35 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
                                                                                 Write(Model.MaxSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1371, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1375, 15, false);
#line 35 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
                                                                                                    Write(Model.MaxSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1390, 127, true);
            WriteLiteral(" EUR / per month</span></div></div>\r\n                    </div>\r\n                </div>\r\n                <h2 class=\"mb-3 mt-5\">");
            EndContext();
            BeginContext(1518, 10, false);
#line 38 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1528, 26, true);
            WriteLiteral("</h2>\r\n                <p>");
            EndContext();
            BeginContext(1555, 11, false);
#line 39 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
              Write(Model.About);

#line default
#line hidden
            EndContext();
            BeginContext(1566, 47, true);
            WriteLiteral("</p>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(1614, 28, false);
#line 41 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Jobs\Details.cshtml"
               Write(Html.Raw(@Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 7093, true);
            WriteLiteral(@"
                </p>
                <div class=""tag-widget post-tag-container mb-5 mt-5"">
                    <div class=""tagcloud"">

                     <a href=""#"" class=""tag-cloud-link"">Life</a>
                    </div>
                </div>
                <hr>
                <div class=""about-author d-flex p-4 bg-light"">
                    <div class=""bio mr-5"">
                        <img src=""images/person_1.jpg"" alt=""Image placeholder"" class=""img-fluid mb-4"">
                    </div>
                    <div class=""desc"">
                        <h3>George Washington</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                    </div>
                </div>


                <div class=""pt-5 mt-5"">
                    <h3 class=""mb-5"">6 Comments</");
            WriteLiteral(@"h3>
                    <ul class=""comment-list"">
                        <li class=""comment"">
                            <div class=""vcard bio"">
                                <img src=""images/person_1.jpg"" alt=""Image placeholder"">
                            </div>
                            <div class=""comment-body"">
                                <h3>John Doe</h3>
                                <div class=""meta"">October 03, 2018 at 2:21pm</div>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur quidem laborum necessitatibus, ipsam impedit vitae autem, eum officia, fugiat saepe enim sapiente iste iure! Quam voluptas earum impedit necessitatibus, nihil?</p>
                                <p><a href=""#"" class=""reply"">Reply</a></p>
                            </div>
                        </li>

                        <li class=""comment"">
                            <div class=""vcard bio"">
                                <img src=""imag");
            WriteLiteral(@"es/person_1.jpg"" alt=""Image placeholder"">
                            </div>
                            <div class=""comment-body"">
                                <h3>John Doe</h3>
                                <div class=""meta"">October 03, 2018 at 2:21pm</div>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur quidem laborum necessitatibus, ipsam impedit vitae autem, eum officia, fugiat saepe enim sapiente iste iure! Quam voluptas earum impedit necessitatibus, nihil?</p>
                                <p><a href=""#"" class=""reply"">Reply</a></p>
                            </div>

                            <ul class=""children"">
                                <li class=""comment"">
                                    <div class=""vcard bio"">
                                        <img src=""images/person_1.jpg"" alt=""Image placeholder"">
                                    </div>
                                    <div class=""comment-body"">
  ");
            WriteLiteral(@"                                      <h3>John Doe</h3>
                                        <div class=""meta"">October 03, 2018 at 2:21pm</div>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur quidem laborum necessitatibus, ipsam impedit vitae autem, eum officia, fugiat saepe enim sapiente iste iure! Quam voluptas earum impedit necessitatibus, nihil?</p>
                                        <p><a href=""#"" class=""reply"">Reply</a></p>
                                    </div>


                                    <ul class=""children"">
                                        <li class=""comment"">
                                            <div class=""vcard bio"">
                                                <img src=""images/person_1.jpg"" alt=""Image placeholder"">
                                            </div>
                                            <div class=""comment-body"">
                                                <");
            WriteLiteral(@"h3>John Doe</h3>
                                                <div class=""meta"">October 03, 2018 at 2:21pm</div>
                                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur quidem laborum necessitatibus, ipsam impedit vitae autem, eum officia, fugiat saepe enim sapiente iste iure! Quam voluptas earum impedit necessitatibus, nihil?</p>
                                                <p><a href=""#"" class=""reply"">Reply</a></p>
                                            </div>

                                            <ul class=""children"">
                                                <li class=""comment"">
                                                    <div class=""vcard bio"">
                                                        <img src=""images/person_1.jpg"" alt=""Image placeholder"">
                                                    </div>
                                                    <div class=""comment-body"">
          ");
            WriteLiteral(@"                                              <h3>John Doe</h3>
                                                        <div class=""meta"">October 03, 2018 at 2:21pm</div>
                                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur quidem laborum necessitatibus, ipsam impedit vitae autem, eum officia, fugiat saepe enim sapiente iste iure! Quam voluptas earum impedit necessitatibus, nihil?</p>
                                                        <p><a href=""#"" class=""reply"">Reply</a></p>
                                                    </div>
                                                </li>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                        </li>

                        <li class=""comment"">
                            <div class=""vcard bio"">");
            WriteLiteral(@"
                                <img src=""images/person_1.jpg"" alt=""Image placeholder"">
                            </div>
                            <div class=""comment-body"">
                                <h3>John Doe</h3>
                                <div class=""meta"">October 03, 2018 at 2:21pm</div>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur quidem laborum necessitatibus, ipsam impedit vitae autem, eum officia, fugiat saepe enim sapiente iste iure! Quam voluptas earum impedit necessitatibus, nihil?</p>
                                <p><a href=""#"" class=""reply"">Reply</a></p>
                            </div>
                        </li>
                    </ul>
                    <!-- END comment-list -->

                    <div class=""comment-form-wrap pt-5"">
                        <h3 class=""mb-5"">Leave a comment</h3>
                        ");
            EndContext();
            BeginContext(8735, 1282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e8adf4a8a1e545f5776e3e7b235ad5483112dc121616", async() => {
                BeginContext(8773, 1237, true);
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label for=""name"">Name *</label>
                                <input type=""text"" class=""form-control"" id=""name"">
                            </div>
                            <div class=""form-group"">
                                <label for=""email"">Email *</label>
                                <input type=""email"" class=""form-control"" id=""email"">
                            </div>
                            <div class=""form-group"">
                                <label for=""website"">Website</label>
                                <input type=""url"" class=""form-control"" id=""website"">
                            </div>

                            <div class=""form-group"">
                                <label for=""message"">Message</label>
                                <textarea name="""" id=""message"" cols=""30"" rows=""10"" class=""form-control""></textarea>
                            </div>
             ");
                WriteLiteral("               <div class=\"form-group\">\r\n                                <input type=\"submit\" value=\"Post Comment\" class=\"btn py-3 px-4 btn-primary\">\r\n                            </div>\r\n\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(10017, 223, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div> <!-- .col-md-8 -->\r\n            <div class=\"col-md-4 pl-md-5 sidebar ftco-animate\">\r\n                <div class=\"sidebar-box\">\r\n                    ");
            EndContext();
            BeginContext(10240, 329, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e8adf4a8a1e545f5776e3e7b235ad5483112dc124805", async() => {
                BeginContext(10277, 285, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <span class=""icon icon-search""></span>
                            <input type=""text"" class=""form-control"" placeholder=""Type a keyword and hit enter"">
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10569, 4527, true);
            WriteLiteral(@"
                </div>
                <div class=""sidebar-box ftco-animate"">
                    <div class=""categories"">
                        <h3 class=""heading-3"">Jobs</h3>
                        <li><a href=""#"">Graphic Designer <span>(12)</span></a></li>
                        <li><a href=""#"">Visual Assistant <span>(22)</span></a></li>
                        <li><a href=""#"">Programing <span>(37)</span></a></li>
                        <li><a href=""#"">Office Admin <span>(42)</span></a></li>
                        <li><a href=""#"">Web Designer <span>(14)</span></a></li>
                        <li><a href=""#"">Language <span>(140)</span></a></li>
                    </div>
                </div>

                <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading-3"">Recent Blog</h3>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_1.jpg);""></a>
                  ");
            WriteLiteral(@"      <div class=""text"">
                            <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> July 12, 2018</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_2.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                   ");
            WriteLiteral(@"             <div><a href=""#""><span class=""icon-calendar""></span> July 12, 2018</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_3.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> July 12, 2018</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a ");
            WriteLiteral(@"href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading-3"">Tag Cloud</h3>
                    <div class=""tagcloud"">
                        <a href=""#"" class=""tag-cloud-link"">dish</a>
                        <a href=""#"" class=""tag-cloud-link"">menu</a>
                        <a href=""#"" class=""tag-cloud-link"">food</a>
                        <a href=""#"" class=""tag-cloud-link"">sweet</a>
                        <a href=""#"" class=""tag-cloud-link"">tasty</a>
                        <a href=""#"" class=""tag-cloud-link"">delicious</a>
                        <a href=""#"" class=""tag-cloud-link"">desserts</a>
                        <a href=""#"" class=""tag-cloud-link"">drinks</a>
                    </div>
                </div>

                <div class=""sidebar-box ftco-animate"">
              ");
            WriteLiteral(@"      <h3 class=""heading-3"">Paragraph</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                </div>
            </div>

        </div>
    </div>
</section> <!-- .section -->
<!-- Footer Area -->
");
            EndContext();
            BeginContext(15096, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e8adf4a8a1e545f5776e3e7b235ad5483112dc131514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(15146, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJobsService JobsService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICompanyService CompanyService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HireMe.ViewModels.Jobs.JobsViewModel2> Html { get; private set; }
    }
}
#pragma warning restore 1591
