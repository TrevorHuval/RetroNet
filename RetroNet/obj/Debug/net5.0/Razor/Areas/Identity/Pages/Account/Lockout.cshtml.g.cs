#pragma checksum "/Users/sethrichard/Documents/GitHub/RetroNet/RetroNet/Areas/Identity/Pages/Account/Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc2ae3ac1ce0688cc1584e99ace3f182955a51e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Lockout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
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
#line 1 "/Users/sethrichard/Documents/GitHub/RetroNet/RetroNet/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sethrichard/Documents/GitHub/RetroNet/RetroNet/Areas/Identity/Pages/_ViewImports.cshtml"
using _90sTest.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sethrichard/Documents/GitHub/RetroNet/RetroNet/Areas/Identity/Pages/_ViewImports.cshtml"
using _90sTest.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sethrichard/Documents/GitHub/RetroNet/RetroNet/Areas/Identity/Pages/_ViewImports.cshtml"
using _90sTest.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/sethrichard/Documents/GitHub/RetroNet/RetroNet/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using _90sTest.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2ae3ac1ce0688cc1584e99ace3f182955a51e9", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d83f0152d5c88d85c452cc250f778a13a00a3a0", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5945dbe367218c61fd2babdfeb91b93f9622b121", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Lockout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/sethrichard/Documents/GitHub/RetroNet/RetroNet/Areas/Identity/Pages/Account/Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header>\n    <h1 class=\"text-danger\">");
#nullable restore
#line 8 "/Users/sethrichard/Documents/GitHub/RetroNet/RetroNet/Areas/Identity/Pages/Account/Lockout.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <p class=\"text-danger\">This account has been locked out, please try again later.</p>\n</header>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LockoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel>)PageContext?.ViewData;
        public LockoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
