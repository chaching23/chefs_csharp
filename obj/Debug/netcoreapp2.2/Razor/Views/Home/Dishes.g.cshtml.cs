#pragma checksum "/Users/chachi/Desktop/C#/chefs/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25431b741c337de632877702a316ce0f1c3b82d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/chachi/Desktop/C#/chefs/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "/Users/chachi/Desktop/C#/chefs/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25431b741c337de632877702a316ce0f1c3b82d5", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewDish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(18, 76, true);
            WriteLiteral("\n<div class=\"row justify-content-center\">\n    <h1 class=\"text-center col-4\">");
            EndContext();
            BeginContext(94, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25431b741c337de632877702a316ce0f1c3b82d54037", async() => {
                BeginContext(138, 5, true);
                WriteLiteral("Chefs");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(147, 47, true);
            WriteLiteral(" | Dishes</h1>\n    <p class=\"text-right col-2\">");
            EndContext();
            BeginContext(194, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25431b741c337de632877702a316ce0f1c3b82d55634", async() => {
                BeginContext(240, 10, true);
                WriteLiteral("Add a Dish");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(254, 322, true);
            WriteLiteral(@"</p>
</div>
<h2>Look at all these hella good dishes!</h2>
<hr class=""my-4"">

<table class=""table table-sm"">
    <thead>
        <tr>
        <th scope=""col"">Name</th>
        <th scope=""col"">Chef</th>
        <th scope=""col"">Tastiness</th>
        <th scope=""col"">Calories</th>
        </tr>
    </thead>
    <tbody>     
");
            EndContext();
#line 20 "/Users/chachi/Desktop/C#/chefs/Views/Home/Dishes.cshtml"
     foreach(var dish in Model)
    {

#line default
#line hidden
            BeginContext(614, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(644, 9, false);
#line 23 "/Users/chachi/Desktop/C#/chefs/Views/Home/Dishes.cshtml"
           Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(653, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(676, 22, false);
#line 24 "/Users/chachi/Desktop/C#/chefs/Views/Home/Dishes.cshtml"
           Write(dish.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(698, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(700, 21, false);
#line 24 "/Users/chachi/Desktop/C#/chefs/Views/Home/Dishes.cshtml"
                                   Write(dish.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(721, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(744, 14, false);
#line 25 "/Users/chachi/Desktop/C#/chefs/Views/Home/Dishes.cshtml"
           Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(758, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(781, 13, false);
#line 26 "/Users/chachi/Desktop/C#/chefs/Views/Home/Dishes.cshtml"
           Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(794, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 28 "/Users/chachi/Desktop/C#/chefs/Views/Home/Dishes.cshtml"
    }

#line default
#line hidden
            BeginContext(820, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
