#pragma checksum "C:\Users\Nasser\source\repos\MyWebSite\MyWebSite\Views\Home\Skills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2c2b20d27e5984e04fd9b9d5cb29d06f325942b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Skills), @"mvc.1.0.view", @"/Views/Home/Skills.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Skills.cshtml", typeof(AspNetCore.Views_Home_Skills))]
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
#line 1 "C:\Users\Nasser\source\repos\MyWebSite\MyWebSite\Views\_ViewImports.cshtml"
using MyWebSite;

#line default
#line hidden
#line 2 "C:\Users\Nasser\source\repos\MyWebSite\MyWebSite\Views\_ViewImports.cshtml"
using MyWebSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c2b20d27e5984e04fd9b9d5cb29d06f325942b", @"/Views/Home/Skills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0915b4a45873913d1dacfe45d55d4f713bad4fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Skills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 45, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" dir=\"ltr\">\r\n");
            EndContext();
            BeginContext(45, 594, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2c2b20d27e5984e04fd9b9d5cb29d06f325942b3354", async() => {
                BeginContext(51, 581, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title></title>
    <link rel=""stylesheet"" href=""style.css"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.ripples/0.5.3/jquery.ripples.min.js""></script>
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.2/css/all.css"">
    <link rel=""stylesheet"" href=""../css/animate.css"">
    <link rel=""stylesheet"" href=""../css/Skills.css"">

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
            BeginContext(639, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(641, 5303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2c2b20d27e5984e04fd9b9d5cb29d06f325942b5141", async() => {
                BeginContext(647, 5290, true);
                WriteLiteral(@"
    <div class=""services-section"">
        <div class=""inner-width"">
            <div class=""title"">

                <h1 class=""section-title"">Skills</h1>
                <div class=""border""></div>
            </div>

            <div class=""container"">
                <h1>Coding Skills</h1>
                <p>These are the main skills that aquire and seeking to improve everyday and learning more and more.</p>
                <div class=""skills zoomInRight animated"">
                    <div class=""skills-label"">
                        <h3>Html</h3>
                        <span class=""percent"">90%</span>
                        <div style=""clear:both""></div>
                    </div>
                    <div class=""bar"">
                        <div class=""progress"" style=""width: 90%;""></div>
                    </div>
                </div>
                <div class=""skills zoomInRight animated"">
                    <div class=""skills-label"">
                        <h3>CSS</h3>");
                WriteLiteral(@"
                        <span class=""percent"">87%</span>
                        <div style=""clear:both""></div>
                    </div>
                    <div class=""bar"">
                        <div class=""progress"" style=""width: 87%;""></div>
                    </div>
                </div>

                <div class=""skills zoomInLeft animated delay-1s"">
                    <div class=""skills-label"">
                        <h3>Java/Javafx</h3>
                        <span class=""percent"">90%</span>
                        <div style=""clear:both""></div>
                    </div>
                    <div class=""bar"">
                        <div class=""progress"" style=""width: 90%;""></div>
                    </div>
                </div>
                <div class=""skills zoomInLeft animated delay-1s"">
                    <div class=""skills-label"">
                        <h3>SQL Server</h3>
                        <span class=""percent"">90%</span>
                        <di");
                WriteLiteral(@"v style=""clear:both""></div>
                    </div>
                    <div class=""bar"">
                        <div class=""progress"" style=""width: 90%;""></div>
                    </div>
                </div>
                <div class=""skills zoomInRight animated delay-2s"">
                    <div class=""skills-label"">
                        <h3>ASP.Net[+C#]</h3>
                        <span class=""percent"">90%</span>
                        <div style=""clear:both""></div>
                    </div>
                    <div class=""bar"">
                        <div class=""progress"" style=""width: 90%;""></div>
                    </div>
                </div>
                <div class=""skills zoomInRight animated delay-2s"">
                    <div class=""skills-label"">
                        <h3>PHP/PHPMYADMIN</h3>
                        <span class=""percent"">60%</span>
                        <div style=""clear:both""></div>
                    </div>
                    <div ");
                WriteLiteral(@"class=""bar"">
                        <div class=""progress"" style=""width: 60%;""></div>
                    </div>
                </div>
                <div class=""skills zoomInLeft animated delay-3s"">
                    <div class=""skills-label"">
                        <h3>Android Studio</h3>
                        <span class=""percent"">65%</span>
                        <div style=""clear:both""></div>
                    </div>
                    <div class=""bar"">
                        <div class=""progress"" style=""width: 65%;""></div>
                    </div>
                </div>
                <div class=""skills zoomInLeft animated delay-3s"">
                    <div class=""skills-label"">
                        <h3>C Language</h3>
                        <span class=""percent"">70%</span>
                        <div style=""clear:both""></div>
                    </div>
                    <div class=""bar"">
                        <div class=""progress"" style=""width: 80%;""></div>");
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""skills zoomInRight animated delay-4s"">
                    <div class=""skills-label"">
                        <h3>javascript</h3>
                        <span class=""percent"">60%</span>
                        <div style=""clear:both""></div>
                    </div>

                    <div class=""bar"">
                        <div class=""progress"" style=""width: 60%;""></div>
                    </div>
                </div>
                <div class=""skills zoomInRight animated delay-4s"">
                    <div class=""skills-label"">
                        <h3>jQuery</h3>
                        <span class=""percent"">50%</span>
                        <div style=""clear:both""></div>
                    </div>
                    <div class=""bar"">
                        <div class=""progress"" style=""width: 50%;""></div>
                    </div>
                </div>
            </div>
        </div>
");
                WriteLiteral("    </div>\r\n\r\n    <script type=\"text/javascript\">\r\n      $(\".services-section\").ripples({\r\n        resolution:400,\r\n        perturbance:0.003,\r\n      });\r\n    </script>\r\n");
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
            BeginContext(5944, 11, true);
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