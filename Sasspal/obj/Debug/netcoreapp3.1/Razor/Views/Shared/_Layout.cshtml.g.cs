#pragma checksum "C:\Users\tu7bxfga8\source\repos\Sasspal\Sasspal\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54d2eb16c61e18d094d47d7c8fce875bc5e40413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\tu7bxfga8\source\repos\Sasspal\Sasspal\Views\_ViewImports.cshtml"
using Sasspal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu7bxfga8\source\repos\Sasspal\Sasspal\Views\_ViewImports.cshtml"
using Sasspal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tu7bxfga8\source\repos\Sasspal\Sasspal\Views\_ViewImports.cshtml"
using Sasspal.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54d2eb16c61e18d094d47d7c8fce875bc5e40413", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c77ab62e19055acab5d0eac14f1347f793d699", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54d2eb16c61e18d094d47d7c8fce875bc5e404133423", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <!-- CSS only -->
    <link rel=""stylesheet"" href=""assets/style.css"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54d2eb16c61e18d094d47d7c8fce875bc5e404135016", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light bg-purple"">
        <div class=""container-fluid"">
            <div class=""collapse navbar-collapse"" id=""navbarText"">
                <img style=""padding-left: 30vh;"" src=""https://preview.uideck.com/items/saaspal/assets/img/logo/logo.svg""");
                BeginWriteAttribute("alt", " alt=\"", 955, "\"", 961, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <span class=""navbar-text"" style=""padding-left: 90vh;"">

                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"" style=""color:white"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"" style=""color:white"">Features</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"" style=""color:white"">About</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"" style=""color:white"">Why</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"" style=""color:white"">Pricing</a>
                        </li>
                      ");
                WriteLiteral("  <li class=\"nav-item\">\r\n                            <a class=\"nav-link\" href=\"#\" style=\"color:white\">Clients</a>\r\n                        </li>\r\n                    </ul>\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    ");
#nullable restore
#line 44 "C:\Users\tu7bxfga8\source\repos\Sasspal\Sasspal\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <section class=""footer"">
        <footer class=""row row-cols-1 row-cols-sm-2 row-cols-md-5 py-5 my-5 border-top"">

            <div class=""col mb-3"">
                <h5>SaaSpal</h5>
                <p>Lorem ipsum dolor sit amet, <br> consetetur sadipscing elitr, sed <br> dinonumy eirmod tempor invidunt.</p>
                <a href=""https://www.facebook.com/campaign/landing.php?campaign_id""><i class=""bi bi-facebook""></i></a>
                <a href=""https://twitter.com/?lang=en""><i class=""bi bi-twitter""></i></a>
                <a href=""https://play.google.com/store/apps/details?id=com.instagram.android&hl=en&gl=US""><i class=""bi bi-instagram""></i></a>
                <a href=""https://github.com/""><i class=""bi bi-github""></i></a>
            </div>

            <div class=""col mb-3"">
                <h5>About Us</h5>
                <ul class=""nav flex-column"">
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Home</a></li>
                    <li c");
                WriteLiteral(@"lass=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Features</a></li>
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">About</a></li>
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Testimonials</a></li>
                </ul>
            </div>

            <div class=""col mb-3"">
                <h5>Features</h5>
                <ul class=""nav flex-column"">
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">How it works</a></li>
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Privacy policy</a></li>
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Terms of service</a></li>
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Refund policy</a></li>
                </ul>
            </div>
            <div class=""col mb-3"">
                <h5>O");
                WriteLiteral(@"ther Products</h5>
                <ul class=""nav flex-column"">
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Accounting Software</a></li>
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Billing Software</a></li>
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Booking System</a></li>
                    <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Tracking System</a></li>
                </ul>
            </div>
        </footer>
    </section>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
