#pragma checksum "C:\Users\FAREED\Desktop\ReviewSystem\productreviewsystem\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce1d7ea0580b5d23f5b8590349e73554ff0243d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\FAREED\Desktop\ReviewSystem\productreviewsystem\Views\_ViewImports.cshtml"
using ProductReviewSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FAREED\Desktop\ReviewSystem\productreviewsystem\Views\_ViewImports.cshtml"
using ProductReviewSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1d7ea0580b5d23f5b8590349e73554ff0243d2", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae825031f6aa4679f129853dc45a5710302ed9a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FAREED\Desktop\ReviewSystem\productreviewsystem\Views\Product\Details.cshtml"
   
    ViewData["Title"] = "Product Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n   \r\n    <li>Name: ");
#nullable restore
#line 8 "C:\Users\FAREED\Desktop\ReviewSystem\productreviewsystem\Views\Product\Details.cshtml"
         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Cost Price: ");
#nullable restore
#line 9 "C:\Users\FAREED\Desktop\ReviewSystem\productreviewsystem\Views\Product\Details.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    <li>Selling Price: ");
#nullable restore
#line 10 "C:\Users\FAREED\Desktop\ReviewSystem\productreviewsystem\Views\Product\Details.cshtml"
                  Write(Model.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Created At: ");
#nullable restore
#line 11 "C:\Users\FAREED\Desktop\ReviewSystem\productreviewsystem\Views\Product\Details.cshtml"
               Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  \r\n</ul>\r\n  List<Review> Review  = new List<Review>();");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
