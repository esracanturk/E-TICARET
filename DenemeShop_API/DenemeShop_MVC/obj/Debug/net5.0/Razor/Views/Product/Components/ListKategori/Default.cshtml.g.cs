#pragma checksum "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Components\ListKategori\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669a3f316c3dc992c46d3f43622bd70f5de675d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Components_ListKategori_Default), @"mvc.1.0.view", @"/Views/Product/Components/ListKategori/Default.cshtml")]
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
#line 1 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\_ViewImports.cshtml"
using DenemeShop_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\_ViewImports.cshtml"
using DenemeShop_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"669a3f316c3dc992c46d3f43622bd70f5de675d0", @"/Views/Product/Components/ListKategori/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7d490e15064c7154ee75169ca4e926b71d6d46", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Components_ListKategori_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task<List<DenemeShop_MVC.Models.Kategori>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"collapse navbar-collapse\" id=\"bs-megadropdown-tabs\">\r\n    <ul class=\"nav navbar-nav nav_1\">\r\n");
#nullable restore
#line 5 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Components\ListKategori\Default.cshtml"
         foreach (var item in Model.Result)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 253, "\"", 296, 2);
            WriteAttributeValue("", 260, "/Home/KategoriDetay/", 260, 20, true);
#nullable restore
#line 7 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Components\ListKategori\Default.cshtml"
WriteAttributeValue("", 280, item.KategoriID, 280, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"KalemHref\"><i class=\"fas fa-chevron-right\"></i>");
#nullable restore
#line 7 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Components\ListKategori\Default.cshtml"
                                                                                                             Write(item.KategoriName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 8 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Components\ListKategori\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task<List<DenemeShop_MVC.Models.Kategori>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
