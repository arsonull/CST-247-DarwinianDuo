#pragma checksum "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51cb45e00e991a9914fa4bd0bdcfe450e129de14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Minesweeper_PartialGame), @"mvc.1.0.view", @"/Views/Minesweeper/PartialGame.cshtml")]
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
#line 1 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\_ViewImports.cshtml"
using MinesweeperCLC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\_ViewImports.cshtml"
using MinesweeperCLC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51cb45e00e991a9914fa4bd0bdcfe450e129de14", @"/Views/Minesweeper/PartialGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a255fb2f383d899ed0c0ccf430bd8669ab94c67", @"/Views/_ViewImports.cshtml")]
    public class Views_Minesweeper_PartialGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameBoard>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("game-button-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("game-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("buttonNumber"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Minesweeper", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Click", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
  
    string[] images = { "0.png", "1.png", "2.png", "3.png", "4.png", "5.png", "6.png", "7.png", "8.png", "blank.png", "bomb.png", "flagged.png" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51cb45e00e991a9914fa4bd0bdcfe450e129de146367", async() => {
                WriteLiteral("\r\n    <div class=\"button-zone\">\r\n");
#nullable restore
#line 9 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
         for (int row = 0; row < Model.Size; row++)
        {
            //start a new line every five elements
            if (row % 5 == 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"line-break\"></div>\r\n");
#nullable restore
#line 15 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
            }
            for (int col = 0; col < Model.Size; col++)
            {
                var coord = row + "," + col;

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51cb45e00e991a9914fa4bd0bdcfe450e129de147493", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
                     if (Model.grid[row, col].visited)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51cb45e00e991a9914fa4bd0bdcfe450e129de148104", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 852, "~/img/", 852, 6, true);
#nullable restore
#line 22 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
AddHtmlAttributeValue("", 858, images[Model.grid[row, col].liveNeighbours], 858, 44, false);

#line default
#line hidden
#nullable disable
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        <div class=\"button-label\">");
#nullable restore
#line 23 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
                                             Write(Model.grid[row, col].liveNeighbours);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n");
#nullable restore
#line 24 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
                    }
                    else
                    {
                        if (Model.grid[row, col].flagged)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51cb45e00e991a9914fa4bd0bdcfe450e129de1410686", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 1224, "~/img/", 1224, 6, true);
#nullable restore
#line 29 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
AddHtmlAttributeValue("", 1230, images[11], 1230, 11, false);

#line default
#line hidden
#nullable disable
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            <div class=\"button-label\">Flagged</div>\r\n");
#nullable restore
#line 31 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51cb45e00e991a9914fa4bd0bdcfe450e129de1412847", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 1464, "~/img/", 1464, 6, true);
#nullable restore
#line 34 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
AddHtmlAttributeValue("", 1470, images[9], 1470, 10, false);

#line default
#line hidden
#nullable disable
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
AddHtmlAttributeValue("", 636, coord, 636, 6, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"line-break\"></div>\r\n");
#nullable restore
#line 40 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <div class=\"button-zone\">\r\n        ");
#nullable restore
#line 43 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\PartialGame.cshtml"
   Write(ViewBag.isDone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameBoard> Html { get; private set; }
    }
}
#pragma warning restore 1591
