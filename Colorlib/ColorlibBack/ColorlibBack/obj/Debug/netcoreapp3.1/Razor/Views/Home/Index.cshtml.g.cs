#pragma checksum "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a60885f920b8cc41d8ca443cae669642e37ab6e"
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
#line 1 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\_ViewImports.cshtml"
using ColorlibBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\_ViewImports.cshtml"
using ColorlibBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\_ViewImports.cshtml"
using ColorlibBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a60885f920b8cc41d8ca443cae669642e37ab6e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdbe3c084600b4f0cec0f5b055d7dd229acc0841", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container mt-5 bg-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main1"">
    <div class=""text-center pt-5"">
        <h1>Find your best food</h1>
        <p class=""textmuted"">Free Website Template For Restaurants Made by Colorlib</p>
    </div>
    <div class=""card-group container pt-5 "">
        <div class=""card"">
            <img src=""./image/salat1.jpg"" class=""card-img-top"" alt=""..."">

        </div>
        <div class=""card text-center pt-5 "">
            <div class=""card-body "">
                <h6 class=""card-title text-danger"">VEGIES</h6>
                <h5 class=""card-title"">BEEF EMPANADAS</h5>
                <p class=""card-text text-muted pt-4 "">Separated they live in <br> Bookmarksgrove right at the <br> coast of the Semantics, a large <br> language ocean.</p>
                <a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 835, 0);
            EndWriteAttribute();
            WriteLiteral(@">LEARN MORE <i class=""bi bi-arrow-right""></i></a>
            </div>
        </div>
        <div class=""card"">
            <img src=""./image/salat2.jpg"" class=""card-img-top"" alt=""..."">
        </div>
    </div>


    <div class=""card-group container "">
        <div class=""card text-center pt-5 "">
            <div class=""card-body "">
                <h6 class=""card-title text-danger"">VEGIES</h6>
                <h5 class=""card-title"">BEEF EMPANADAS</h5>
                <p class=""card-text text-muted pt-4 "">Separated they live in <br> Bookmarksgrove right at the <br> coast of the Semantics, a large <br> language ocean.</p>
                <a");
            BeginWriteAttribute("href", " href=\"", 1498, "\"", 1505, 0);
            EndWriteAttribute();
            WriteLiteral(@">LEARN MORE <i class=""bi bi-arrow-right""></i></a>
            </div>
        </div>



        <div class=""card"">
            <img src=""./image/salat2.jpg"" class=""card-img-top"" alt=""..."">
        </div>
        <div class=""card text-center pt-5 "">
            <div class=""card-body "">
                <h6 class=""card-title text-danger"">VEGIES</h6>
                <h5 class=""card-title"">BEEF EMPANADAS</h5>
                <p class=""card-text text-muted pt-4 "">Separated they live in <br> Bookmarksgrove right at the <br> coast of the Semantics, a large <br> language ocean.</p>
                <a");
            BeginWriteAttribute("href", " href=\"", 2117, "\"", 2124, 0);
            EndWriteAttribute();
            WriteLiteral(@">LEARN MORE <i class=""bi bi-arrow-right""></i></a>
            </div>
        </div>
    </div>
</section>
<section class=""main2"">
    <div class=""px-4 pt-5 my-5 text-center"">
        <h1 class=""display-5 fw-bold"">The Restaurant</h1>
        <div class=""col-lg-6 mx-auto"">
            <p class=""lead mb-4 text-muted"">Far far away, behind the word mountains, far from the countries Vokalia and  Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
            <p class=""lead mb-4 text-muted"">It is a paradisematic country, in which roasted parts of sentences fly into your mouth.</p>

        </div>
        <div>
            <div>
                <img src=""./image/dsfdsg.webp"" alt=""Example image"">
            </div>
        </div>
    </div>
</section>
<section class=""main3"">
    <div class=""container"">

        <div class=""row "">
            <div class=""col-lg-6 text-center"">
                <img src="".");
            WriteLiteral("/image/aspaz1.jfif\" width=\"140px\" height=\"140px\"");
            BeginWriteAttribute("alt", " alt=\"", 3197, "\"", 3203, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h2>Daniel Graham</h2>
                <h4 class=""text-muted"">MASTER CHEF</h4>
                <p class=""text-muted pt-4"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                <p class=""text-muted"">Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean. It is a paradisematic country.</p>
                <div class=""social"">
                    <i class=""bi bi-facebook""></i>
                    <i class=""bi bi-twitter""></i>
                    <i class=""bi bi-instagram""></i>
                </div>
            </div><!-- /.col-lg-4 -->
            <div class=""col-lg-6 text-center"">
                <img src=""./image/aspaz2.webp"" width=""140px"" height=""140px""");
            BeginWriteAttribute("alt", " alt=\"", 4121, "\"", 4127, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h2>Nick Browning</h2>
                <h4 class=""text-muted"">MASTER CHEF</h4>
                <p class=""text-muted pt-4"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                <p class=""text-muted"">Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean. It is a paradisematic country.</p>
                <div class=""social"">
                    <i class=""bi bi-facebook""></i>
                    <i class=""bi bi-twitter""></i>
                    <i class=""bi bi-instagram""></i>
                </div>
            </div><!-- /.col-lg-4 -->

        </div>
    </div>
</section>
<section class=""main4 "">
    <div class=""header-menu container pt-5"">
        <h2 class=""text-center"">Menu</h2>
        <p class=""text-center text-muted"">Free Website Template For Resta");
            WriteLiteral(@"urants Made by Colorlib</p>

        <div class=""tab"">
            <button class=""tablinks"" onclick=""openCity(event, 'BREAKFAST')"">BREAKFAST</button>
            <button class=""tablinks"" onclick=""openCity(event, 'BRUNCH')"">BRUNCH</button>
            <button class=""tablinks"" onclick=""openCity(event, 'DINNER')"">DINNER</button>
        </div>


        <div id=""BREAKFAST"" class="" mb-3 tabcontent"">
            <div class=""row "">
");
#nullable restore
#line 116 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                 foreach (var item in Model.Breakfasts)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5735, "\"", 5760, 2);
            WriteAttributeValue("", 5741, "./image/", 5741, 8, true);
#nullable restore
#line 120 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 5749, item.Image, 5749, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid \" width=\"140px\" height=\"140px\" alt=\"...\">\r\n                </div>\r\n                <div class=\"col-lg-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 124 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text text-muted\">");
#nullable restore
#line 125 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                                   Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text \"><small class=\"text-danger\">$");
#nullable restore
#line 126 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 129 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n\r\n        <div id=\"BRUNCH\" class=\" mb-3 tabcontent\">\r\n            \r\n\r\n            <div class=\"row \">\r\n");
#nullable restore
#line 138 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                 foreach (var item in Model.Brunches)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 6523, "\"", 6548, 2);
            WriteAttributeValue("", 6529, "./image/", 6529, 8, true);
#nullable restore
#line 141 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 6537, item.Image, 6537, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid \" width=\"140px\" height=\"140px\" alt=\"...\">\r\n                    </div>\r\n                    <div class=\"col-lg-8\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 145 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text text-muted\">");
#nullable restore
#line 146 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                                       Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text \"><small class=\"text-danger\">$");
#nullable restore
#line 147 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 150 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div id=\"DINNER\" class=\" mb-3 tabcontent\">\r\n            <div class=\"row \">\r\n");
#nullable restore
#line 157 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                 foreach (var item in Model.Dinners)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 7320, "\"", 7345, 2);
            WriteAttributeValue("", 7326, "./image/", 7326, 8, true);
#nullable restore
#line 161 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 7334, item.Image, 7334, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid \" width=\"140px\" height=\"140px\" alt=\"...\">\r\n                </div>\r\n                <div class=\"col-lg-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 165 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text text-muted\">");
#nullable restore
#line 166 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                                   Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text \"><small class=\"text-danger\">$");
#nullable restore
#line 167 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 170 "C:\Users\tu7hnsxs1\Desktop\Colorlib\ColorlibBack\ColorlibBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>


</section>
<section class=""main5 pt-5"">
    <div class=""text-center"">
        <h2>Other Services</h2>
        <p class="" text-muted"">Free Website Template For Restaurants Made by Colorlib</p>
    </div>
    <div class=""card-group container pt-5"">
        <div class="" col-lg-4 text-center"">
            <i class=""bi bi-brightness-high""></i>
            <div class=""card-body"">
                <h5 class=""card-title"">Quality Cuisine</h5>
                <p class=""card-text text-muted"">Far far away, behind the word <br> mountains, far from the countries <br> Vokalia and Consonantia, there live the <br> blind texts.</p>
            </div>
        </div>
        <div class="" col-lg-4 text-center"">
            <i class=""bi bi-brightness-high""></i>
            <div class=""card-body"">
                <h5 class=""card-title"">Quality Cuisine</h5>
                <p class=""card-text text-muted"">Far far away, behind the word <br> mountains, far from the co");
            WriteLiteral(@"untries <br> Vokalia and Consonantia, there live the <br> blind texts.</p>
            </div>
        </div>
        <div class="" col-lg-4 text-center"">
            <i class=""bi bi-brightness-high""></i>
            <div class=""card-body"">
                <h5 class=""card-title"">Quality Cuisine</h5>
                <p class=""card-text text-muted"">Far far away, behind the word <br> mountains, far from the countries <br> Vokalia and Consonantia, there live the <br> blind texts.</p>
            </div>
        </div>





        <div class="" col-lg-4 text-center"">
            <i class=""bi bi-brightness-high""></i>
            <div class=""card-body"">
                <h5 class=""card-title"">Quality Cuisine</h5>
                <p class=""card-text text-muted"">Far far away, behind the word <br> mountains, far from the countries <br> Vokalia and Consonantia, there live the <br> blind texts.</p>
            </div>
        </div>
        <div class="" col-lg-4 text-center"">
            <i class=""bi bi");
            WriteLiteral(@"-brightness-high""></i>
            <div class=""card-body"">
                <h5 class=""card-title"">Quality Cuisine</h5>
                <p class=""card-text text-muted"">Far far away, behind the word <br> mountains, far from the countries <br> Vokalia and Consonantia, there live the <br> blind texts.</p>
            </div>
        </div>
        <div class="" col-lg-4 text-center"">
            <i class=""bi bi-brightness-high""></i>
            <div class=""card-body"">
                <h5 class=""card-title"">Quality Cuisine</h5>
                <p class=""card-text text-muted"">Far far away, behind the word <br> mountains, far from the countries <br> Vokalia and Consonantia, there live the <br> blind texts.</p>
            </div>
        </div>
    </div>


</section>
<section class=""main6"">
    <div class=""text-center pt-5"">
        <h1>Reservation</h1>
        <p class=""text-muted"">Free Website Template For Restaurants Made by Colorlib</p>
    </div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a60885f920b8cc41d8ca443cae669642e37ab6e22149", async() => {
                WriteLiteral(@"
        <div class=""row mb-4"">
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label text-muted"" for=""form3Example1"">Name</label>
                    <input type=""text"" id=""form3Example1"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label text-muted"" for=""form3Example2"">Email</label>
                    <input type=""email"" id=""form3Example2"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label text-muted"" for=""form3Example2"">Phone</label>
                    <input type=""number"" id=""form3Example2"" class=""form-control"" />
                </div>
            </div>
        </div>
        <div class=""row mb-4"">
            <div class=""col"">
                <div class=");
                WriteLiteral("\"form-outline\">\r\n                    <label class=\"form-label text-muted\" for=\"form3Example1\">Number of Persons</label>\r\n                    <select class=\"form-select\" aria-label=\"Default select example\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a60885f920b8cc41d8ca443cae669642e37ab6e23759", async() => {
                    WriteLiteral("Person 1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a60885f920b8cc41d8ca443cae669642e37ab6e25123", async() => {
                    WriteLiteral("Person 2");
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a60885f920b8cc41d8ca443cae669642e37ab6e26373", async() => {
                    WriteLiteral("Person 3");
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a60885f920b8cc41d8ca443cae669642e37ab6e27623", async() => {
                    WriteLiteral("Person 4");
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a60885f920b8cc41d8ca443cae669642e37ab6e28873", async() => {
                    WriteLiteral("Person 5+");
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
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label text-muted"" for=""form3Example2"">Date</label>
                    <input type=""date"" id=""form3Example2"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label text-muted"" for=""form3Example2"">Time</label>
                    <input type=""time"" id=""form3Example2"" class=""form-control"" />
                </div>
            </div>
        </div>
        <div class=""text-center"">
            <button type=""button"" class=""btn btn-outline-danger"">Reverse Now</button>
        </div>



    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n<section class=\"main7\">\r\n    <div class=\"text-center pt-5\">\r\n        <h1>Get In Touch</h1>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a60885f920b8cc41d8ca443cae669642e37ab6e32148", async() => {
                WriteLiteral(@"
        <div class=""row mb-4"">
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label text-muted"" for=""form3Example1"">Name</label>
                    <input type=""text"" id=""form3Example1"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label text-muted"" for=""form3Example2"">Email</label>
                    <input type=""email"" id=""form3Example2"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label text-muted"" for=""form3Example2"">Phone</label>
                    <input type=""number"" id=""form3Example2"" class=""form-control"" />
                </div>
            </div>
        </div>
        <div class=""form-outline mb-4"">
            <label class=""form-label"" for=""form4E");
                WriteLiteral(@"xample3"">Message</label>
            <textarea class=""form-control"" id=""form4Example3"" rows=""4""></textarea>
        </div>
        <div class=""text-center"">
            <button type=""button"" class=""btn btn-outline-danger"">Send Message</button>
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
</section>
<section class=""main8 pt-5"">
    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d47725.37803183548!2d46.606750041503!3d41.616055205160436!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40464b3c2d85a753%3A0x9b64bff01e358777!2sZaqatala%2C%20Azerbaijan!5e0!3m2!1sen!2s!4v1655378851938!5m2!1sen!2s"" width=""100%"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 15087, "\"", 15105, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
