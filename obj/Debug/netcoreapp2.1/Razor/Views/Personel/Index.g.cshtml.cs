#pragma checksum "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccd0aea2d3b555fe54976f684e8d0995f412a212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Index), @"mvc.1.0.view", @"/Views/Personel/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personel/Index.cshtml", typeof(AspNetCore.Views_Personel_Index))]
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
#line 1 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\_ViewImports.cshtml"
using MixCRM;

#line default
#line hidden
#line 2 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\_ViewImports.cshtml"
using MixCRM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccd0aea2d3b555fe54976f684e8d0995f412a212", @"/Views/Personel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d003a1e69c72c5ad002022581ea7097e0e5d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Personel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(71, 202, true);
            WriteLiteral("<div>\r\n\r\n</div>\r\n<div class=\"m-4\">\r\n    <div class=\"bg-success text-white p-4\">\r\n        <h2>Personel Listesi</h2>\r\n    </div>\r\n    <div class=\"card my-2\">\r\n        <div class=\"card-body\">\r\n            ");
            EndContext();
            BeginContext(273, 339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d4917f91cb9417b845bdc67aedc4030", async() => {
                BeginContext(304, 130, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input name=\"name\" class=\"form-control\" placeholder=\"Personel Adı\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 434, "\"", 455, 1);
#line 16 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
WriteAttributeValue("", 442, ViewBag.name, 442, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(456, 149, true);
                WriteLiteral(" />\r\n                </div>\r\n                <button class=\"btn btn-primary\">\r\n                    Arama Yap\r\n                </button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(612, 448, true);
            WriteLiteral(@"
        </div>
    </div>
    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Ad</th>
                <th>Soyad</th>
                <th>Cinsiyet</th>
                <th>E-Mail</th>
                <th>Doğum Tarihi</th>
                <th>Fotoğraf</th>
                <th>Adres</th>
                <th>Departman</th>

            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 39 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1117, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1156, 7, false);
#line 42 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
               Write(item.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1191, 10, false);
#line 43 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
               Write(item.Soyad);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1229, 13, false);
#line 44 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
               Write(item.Cinsiyet);

#line default
#line hidden
            EndContext();
            BeginContext(1242, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1270, 10, false);
#line 45 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1308, 11, false);
#line 46 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
               Write(item.DTarih);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1347, 9, false);
#line 47 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
               Write(item.Foto);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1384, 10, false);
#line 48 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
               Write(item.Adres);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 50 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
                     foreach (var item2 in ViewBag.Departmanlar)
                    {
                        if (item2.Id == item.DepartmanId)
                        {
                            

#line default
#line hidden
            BeginContext(1627, 8, false);
#line 54 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
                       Write(item2.Ad);

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
                                     
                        }
                    }

#line default
#line hidden
            BeginContext(1687, 67, true);
            WriteLiteral("                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1754, 358, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c55903299184204a168c4ac8d49b4a0", async() => {
                BeginContext(1794, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1820, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82006acddded4e24a54c38b58f3fe090", async() => {
                    BeginContext(1896, 7, true);
                    WriteLiteral("Düzenle");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1907, 56, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1963, "\"", 1979, 1);
#line 62 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
WriteAttributeValue("", 1971, item.Id, 1971, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1980, 125, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-danger btn-sm btn-del\">Sil</button>\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2112, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 68 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Personel\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2171, 40, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n    ");
            EndContext();
            BeginContext(2211, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41866027265241d4bdb960b0f1c5a131", async() => {
                BeginContext(2258, 10, true);
                WriteLiteral("Yeni Kayıt");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2272, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
