#pragma checksum "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3209c68561434875c59ec1a8e943427f6d7e93b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/Index.cshtml", typeof(AspNetCore.Views_ShoppingCart_Index))]
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
#line 1 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#line 2 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3209c68561434875c59ec1a8e943427f6d7e93b7", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5bc892ed7a70745a15da4006f10ab34c9177b07", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 538, true);
            WriteLiteral(@"
    <h2><font color=""white"">Your shopping cart</font></h2>
    <h4><font color=""white"">Here are the pies in your shopping cart.</font></h4>
    <table class=""table table-bordered table-striped WhiteText"">
        <thead>
            <tr>
                <th><font color=""white"">Selected amount</font></th>
                <th><font color=""white"">Pie</font></th>
                <th><font color=""white"">Price</font></th>
                <th><font color=""white"">Subtotal</font></th>
            </tr>
        </thead>
<tbody>
");
            EndContext();
#line 15 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
     foreach (var line in Model.ShoppingCart.ShoppingCartItems)
    {

#line default
#line hidden
            BeginContext(640, 59, true);
            WriteLiteral("    <div class=\"WhiteText\">\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(700, 11, false);
#line 19 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
           Write(line.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(711, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(735, 13, false);
#line 20 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
           Write(line.Pie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(748, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(772, 28, false);
#line 21 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
           Write(line.Pie.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(800, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(843, 44, false);
#line 23 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
            Write((line.Amount * line.Pie.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(888, 48, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </div>\r\n");
            EndContext();
#line 27 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(943, 195, true);
            WriteLiteral("</tbody>\r\n<tfoot>\r\n    <tr>\r\n        <td colspan=\"3\" class=\"text-right\"><font color=\"white\">Total:</font></td>\r\n        <td class=\"text-right\">\r\n            <font color=\"white\">\r\n                ");
            EndContext();
            BeginContext(1139, 37, false);
#line 34 "D:\!STUDIA\3.ASP_NET\ZALICZENIE\Projekt\BethanysPieShop\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
           Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 101, true);
            WriteLiteral("\r\n           </font>\r\n        </td>\r\n</tr>\r\n</tfoot>\r\n    </table>\r\n\r\n<div class=\"text-center\">\r\n    ");
            EndContext();
            BeginContext(1277, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "043ca29955684f76b522e9aa18589df3", async() => {
                BeginContext(1349, 14, true);
                WriteLiteral("Check out now!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
