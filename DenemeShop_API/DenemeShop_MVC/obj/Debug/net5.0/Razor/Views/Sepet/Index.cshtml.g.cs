#pragma checksum "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dc36e0d9c703237b1c485a7580ca2a2b6033335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sepet_Index), @"mvc.1.0.view", @"/Views/Sepet/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
using DenemeShop_MVC.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dc36e0d9c703237b1c485a7580ca2a2b6033335", @"/Views/Sepet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7d490e15064c7154ee75169ca4e926b71d6d46", @"/Views/_ViewImports.cshtml")]
    public class Views_Sepet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DenemeShop_MVC.Models.SepetModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/font-awesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-content animate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dc36e0d9c703237b1c485a7580ca2a2b60333357619", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta name=""keywords"" content=""Grocery Store Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template,
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design"" />
    <script type=""application/x-javascript"">
        addEventListener(""load"", function() { setTimeout(hideURLbar, 0); }, false);
               function hideURLbar(){ window.scrollTo(0,1); } </script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4dc36e0d9c703237b1c485a7580ca2a2b60333358517", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4dc36e0d9c703237b1c485a7580ca2a2b60333359869", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4dc36e0d9c703237b1c485a7580ca2a2b603333511221", async() => {
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
                WriteLiteral(@"
    <link href='//fonts.googleapis.com/css?family=Ubuntu:400,300,300italic,400italic,500,500italic,700,700italic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic,800,800italic' rel='stylesheet' type='text/css'>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dc36e0d9c703237b1c485a7580ca2a2b603333512888", async() => {
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
    <style>

        form {
            border: 3px solid #f1f1f1;
        }

        input[type=text],
        input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        button {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

            button:hover {
                opacity: 0.8;
            }

        .cancelbtn {
            width: auto;
            padding: 10px 18px;
            background-color: #f44336;
        }

        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }

        img.avatar {
            width: 40%;
            border-radius: 50%;
        }

        .containe");
                WriteLiteral(@"r {
            padding: 4px;
            width: auto
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        /* Full-width input fields */
        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        /* Set a style for all buttons */
        button {
            background-color: #04AA6D;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

            button:hover {
                opacity: 0.8;
            }

        /* Extra styles for the cancel button */
        .cancelbtn {
            width: auto;
            padding");
                WriteLiteral(@": 10px 18px;
            background-color: #f44336;
        }

        /* Center the image and position the close button */
        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
            position: relative;
        }

        img.avatar {
            width: 40%;
            border-radius: 50%;
        }

        .container {
            padding: 16px;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        /* The Modal (background) */
        .modal {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Bla");
                WriteLiteral(@"ck w/ opacity */
            padding-top: 60px;
        }

        /* Modal Content/Box */
        .modal-content {
            background-color: #fefefe;
            margin: 5% auto 15% auto; /* 5% from the top, 15% from the bottom and centered */
            border: 1px solid #888;
            width: 80%; /* Could be more or less, depending on screen size */
        }

        /* The Close Button (x) */
        .close {
            position: absolute;
            right: 25px;
            top: 0;
            color: #000;
            font-size: 35px;
            font-weight: bold;
        }

            .close:hover,
            .close:focus {
                color: red;
                cursor: pointer;
            }
        .txt {
            line-height: 18px;
            /*padding: 0 4px 10px 4px;*/
            width: 50px !important;
            height: 32px;
            font-size: 14px;
            text-align: center;
            border: solid 1px #ccc;
            marg");
                WriteLiteral(@"in-left: -10px;
        }

        .arttir {
            display: block;
            cursor: pointer;
            background-color: orangered;
            position: fixed;
            left: 973px;
            /*top: initial;*/
            margin-right: auto;
        }

        .azalt {
            display: block;
            cursor: pointer;
            background-color: #84c639;
            position: fixed;
            left: 895px;
            /*margin-left: auto;*/
        }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dc36e0d9c703237b1c485a7580ca2a2b603333519446", async() => {
                WriteLiteral(@"
    <div class=""main-wrapper"">
        <div class=""page-wrapper"" style=""display: block;"">
            <div class=""container-fluid"">
                <div class=""row"" id=""controldiv"">
                    <div class=""col-md-9 col-lg-9"">
                        <div class=""card"">
                            <div class=""card-header "" style=""background-color: #84c639"">
                                <h5 class=""m-b-0 text-white""><i class=""fas fa-shopping-cart""></i> Sepetim - <span id=""sepetim-total""></span> Ürün</h5>
                            </div>
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table product-overview"">
                                        <thead>
                                            <tr>
                                                <th>Fotoğraf</th>
                                                <th>Adı</th>
                                        ");
                WriteLiteral("        <th>Fiyat</th>\r\n                                                <th>Adet</th>\r\n");
                WriteLiteral("                                                <th style=\"text-align:center\">İşlemler</th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 227 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr class=\"rem1\">\r\n");
                WriteLiteral("                                                    <td class=\"invert-image\"><a href=\"single.html\"><img");
                BeginWriteAttribute("src", " src=\"", 7880, "\"", 7903, 1);
#nullable restore
#line 231 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
WriteAttributeValue("", 7886, item.SepetImgUrl, 7886, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 7904, "\"", 7927, 1);
#nullable restore
#line 231 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
WriteAttributeValue("", 7910, item.SepetImgUrl, 7910, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 100px;\" class=\"img-responsive\"></a></td>\r\n                                                    <td class=\"invert\">");
#nullable restore
#line 232 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                                                  Write(item.SepetName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td class=\"invert\">");
#nullable restore
#line 233 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                                                  Write(item.SepetPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td class=\"invert\">\r\n                                                        <div class=\"quantity\">\r\n                                                            ");
#nullable restore
#line 236 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                                       Write(Html.ActionLink("-", "Azalt", new { id = @item.Id }, new { @class = "btn btn-secondary btn-sm azalt" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                                                        </div>\r\n                                                        ");
#nullable restore
#line 239 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                                   Write(Html.TextBoxFor(x => @item.SepetQuantity, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        <div class=\"quantity\">\r\n                                                            ");
#nullable restore
#line 241 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                                       Write(Html.ActionLink("+", "Arttir", new { id = @item.Id }, new { @class = "btn btn-secondary btn-sm arttir" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                                                        </div>\r\n                                                    </td>\r\n");
                WriteLiteral("                                                    <td class=\"invert\">\r\n                                                        <div class=\"rem\">\r\n");
                WriteLiteral("                                                            <a");
                BeginWriteAttribute("href", " href=\"", 9736, "\"", 9778, 2);
                WriteAttributeValue("", 9743, "/Sepet/DeleteSepet?SepetId=", 9743, 27, true);
#nullable restore
#line 249 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
WriteAttributeValue("", 9770, item.Id, 9770, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                                                        </div>\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 263 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                                                                                                                                                               
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n");
                WriteLiteral("                                    <div class=\"d-flex no-block align-items-center\">\r\n                                        <a class=\"btn-block\" href=\"urunler.htm\">\r\n");
                WriteLiteral(@"                                            <a href=""/Home/Index"" class=""btn btn-info"" style="" background-color:orangered""><i class=""fas fa-arrow-circle-left""></i> Ürünlere Geri Dön</a>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
                WriteLiteral("                    <div class=\"col-md-3 col-lg-3\"");
                BeginWriteAttribute("style", " style=\"", 13990, "\"", 13998, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""card"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Sepet Özeti</h5>
                                <hr>
                                <small>Toplam Fiyat</small>
                                <h2><span id=""sepettoplamfiyat"">");
#nullable restore
#line 298 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                                           Write(ViewBag.toplam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> TL</h2>\r\n");
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 302 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                 if (@ViewBag.emailconfirm == false)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <button onclick=""document.getElementById('id01').style.display='block'"" style=""width:auto;background-color: #84C639;color: white""><i class=""fas fa-check""></i> E-Mail Aktiflik Kontrolü</button>
                                    <div id=""id01"" class=""modal"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dc36e0d9c703237b1c485a7580ca2a2b603333528725", async() => {
                    WriteLiteral(@"
                                            <div class=""container"">
                                                <span onclick=""document.getElementById('id01').style.display='none'"" class=""close"" title=""Close Modal"">&times;</span>
                                                <label for=""email""><b>Doğrulanmamış E-Mail</b></label>
");
                    WriteLiteral(@"
                                            </div>

                                            <div class=""container"" style=""background-color:#f1f1f1"">
                                                <button type=""button"" onclick=""document.getElementById('id01').style.display='none'"" class=""cancelbtn"" id=""gonder""><i class=""fas fa-envelope""></i>Aktivasyon Mail'i Gönder</button>
                                            </div>

                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 320 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 321 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                 if (@ViewBag.emailconfirm == true)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 16215, "\"", 16281, 2);
                WriteAttributeValue("", 16222, "/Sepet/HepsiniAlUser?userId=", 16222, 28, true);
#nullable restore
#line 323 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
WriteAttributeValue("", 16250, Context.Session.GetInt32("Id"), 16250, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info\" style=\"background-color: #84C639\"><i class=\"fas fa-thumbs-up\"></i> Siparişi Tamamla</a>\r\n");
#nullable restore
#line 324 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                }

                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <hr>\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
                WriteLiteral(@"                </div>
            </div>
        </div>
    </div>

    

    <script>
        // Get the modal

        var modal = document.getElementById('id01');
        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }

        $(""#gonder"").click(function () {
            var email = $('#email').val();
            $.ajax({
                type: 'POST',
                url: '/Account/EmailConfirm',
                data: {
                    email: email
                },
            });
        });
    </script>
    <!--<script>
        $(document).ready(function() {
            debugger;
            $(""#Bas"").click(function() {-->
");
                WriteLiteral("    <!--$.ajax({\r\n                type: \'GET\',\r\n                url: \'/Sepet/HepsiniAl\',\r\n                data: { userId: ");
#nullable restore
#line 371 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                           Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(" },\r\n\r\n                success: function (data) {\r\n\r\n                    console.log(\'olduuuu\');\r\n                    window.location.href = \'");
#nullable restore
#line 376 "C:\Users\aa\source\repos\DenemeShop_API\DenemeShop_MVC\Views\Sepet\Index.cshtml"
                                       Write(Url.Action("Index","Sepet"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' ;\r\n                },\r\n                error: function (data) {\r\n                }\r\n            });\r\n\r\n        });\r\n    });\r\n    </script>-->\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DenemeShop_MVC.Models.SepetModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591