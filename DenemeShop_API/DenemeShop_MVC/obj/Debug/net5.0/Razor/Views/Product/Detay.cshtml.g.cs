#pragma checksum "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a4fd5138c88ac04760b05243c58ff972656afd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detay), @"mvc.1.0.view", @"/Views/Product/Detay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a4fd5138c88ac04760b05243c58ff972656afd9", @"/Views/Product/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7d490e15064c7154ee75169ca4e926b71d6d46", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DenemeShop_MVC.Models.ProductWithStore>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/font-awesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a4fd5138c88ac04760b05243c58ff972656afd95937", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta name=""keywords"" content=""Grocery Store Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template,
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design"" />
    <script type=""application/x-javascript"">
        addEventListener(""load"", function() { setTimeout(hideURLbar, 0); }, false);
               function hideURLbar(){ window.scrollTo(0,1); } </script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a4fd5138c88ac04760b05243c58ff972656afd96835", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a4fd5138c88ac04760b05243c58ff972656afd98187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a4fd5138c88ac04760b05243c58ff972656afd99539", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a4fd5138c88ac04760b05243c58ff972656afd910891", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src='js/okzoom.js'></script>
    <script>
        $(function () {
            $('#example').okzoom({
                width: 150,
                height: 150,
                border: ""1px solid black"",
                shadow: ""0 0 5px #000""
            });
        });
    </script>
    <link href='//fonts.googleapis.com/css?family=Ubuntu:400,300,300italic,400italic,500,500italic,700,700italic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic,800,800italic' rel='stylesheet' type='text/css'>
    <script type=""text/javascript"" src=""js/move-top.js""></script>
    <script type=""text/javascript"" src=""js/easing.js""></script>
    <script type=""text/javascript"">
        jQuery(document).ready(function ($) {
            $("".scroll"").click(function (event) {
                event.preventDefault();
                $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
     ");
                WriteLiteral("       });\r\n        });\r\n    </script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a4fd5138c88ac04760b05243c58ff972656afd913813", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var navoffeset = $("".agileits_header"").offset().top;
            $(window).scroll(function () {
                var scrollpos = $(window).scrollTop();
                if (scrollpos >= navoffeset) {
                    $("".agileits_header"").addClass(""fixed"");
                } else {
                    $("".agileits_header"").removeClass(""fixed"");
                }
            });

        });
    </script>
    <div class=""logo_products"">
        <div class=""container"">
            <div class=""w3ls_logo_products_left"">
                <h1><a href=""/Home/Index""><span>Ajans</span> Store</a></h1>
            </div>
            <div class=""w3ls_logo_products_left1"">
                <ul class=""special_items"">
                </ul>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>

    <div class=""w3l_banner_nav_left"">
        ");
#nullable restore
#line 69 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
   Write(await Component.InvokeAsync("ListKategori"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("    </div>\r\n    <div class=\"col-md-4 agileinfo_single_left\">\r\n        <img id=\"example\" style=\"height: 300px;\"");
                BeginWriteAttribute("src", " src=\"", 3243, "\"", 3264, 1);
#nullable restore
#line 73 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
WriteAttributeValue("", 3249, Model.ImageUrl, 3249, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3265, "\"", 3286, 1);
#nullable restore
#line 73 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
WriteAttributeValue("", 3271, Model.ImageUrl, 3271, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"  />\r\n    </div>\r\n");
                WriteLiteral(@"    <div class=""rating1"">
        <span class=""starRating"">
            <input id=""rating5"" type=""radio"" name=""rating"" value=""5"">
            <label for=""rating5"">5</label>
            <input id=""rating4"" type=""radio"" name=""rating"" value=""4"">
            <label for=""rating4"">4</label>
            <input id=""rating3"" type=""radio"" name=""rating"" value=""3"" checked>
            <label for=""rating3"">3</label>
            <input id=""rating2"" type=""radio"" name=""rating"" value=""2"">
            <label for=""rating2"">2</label>
            <input id=""rating1"" type=""radio"" name=""rating"" value=""1"">
            <label for=""rating1"">1</label>
        </span>
        <br />
    </div>
");
                WriteLiteral("    <div>\r\n        <p><h4>??r??n Ad??:<i");
                BeginWriteAttribute("class", " class=\"", 4200, "\"", 4208, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"color: orangered\"> ");
#nullable restore
#line 93 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </i></h4></p><br />\r\n        <p><h4>??r??n Miktar??:<i class=\"item_quantity\" style=\"color: orangered\">");
#nullable restore
#line 94 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                                                         Write(Model.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" adet</i></h4></p><br />\r\n        <p><h4>??r??n F??yat??:<i class=\"item_price\" style=\"color: orangered\">");
#nullable restore
#line 95 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ???</i></h4></p><br />\r\n");
                WriteLiteral("        <p><h4>??r??n A????klamas??:<i class=\"item_description\" style=\"color: orangered\">");
#nullable restore
#line 97 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                                                               Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></h4></p><br />\r\n        <p><h4>??r??n Ma??aza Bilgisi:<i class=\"item_description\" style=\"color: orangered\">");
#nullable restore
#line 98 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                                                                   Write(Model.groupName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</i></h4></p><br />
        <button class=""btn btn-info"" id=""Satinbuttonn"" style=""background-color: #84C639""><i class=""fas fa-cart-plus""></i> Sepete Ekle</button>
    </div>
    <div class=""clearfix""> </div>
    <div class=""clearfix""></div>

    <script>
            $(document).ready(function () {
                debugger;
            //$(""#dropdown"").select2();
            $(""#Satinbuttonn"").click(function () {
                debugger;
                $.ajax({
                            type: 'POST',
                            url: '/Product/SepetBuy',
                            data: {
                                Id: ");
#nullable restore
#line 114 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                                Name: \'");
#nullable restore
#line 115 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                Quantity: ");
#nullable restore
#line 116 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                     Write(Model.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                                Price: ");
#nullable restore
#line 117 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                  Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                                ImageUrl: \'");
#nullable restore
#line 118 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                      Write(Model.ImageUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                Description: \'");
#nullable restore
#line 119 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                groupId: ");
#nullable restore
#line 120 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                    Write(Model.groupId);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                                groupName: \'");
#nullable restore
#line 121 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                       Write(Model.groupName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                            },
                            /*data: '{groupid:' + dropvalue + ' }',*/
                            success: function(data) {
                                debugger
                                console.log('olduuuu')
                                window.location.href = '");
#nullable restore
#line 127 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Product\Detay.cshtml"
                                                   Write(Url.Action("Index","Sepet"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                            },\r\n                            error: function(data) {\r\n                                debugger\r\n\r\n                            }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DenemeShop_MVC.Models.ProductWithStore> Html { get; private set; }
    }
}
#pragma warning restore 1591
