#pragma checksum "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcf2c7bce02917c2a9d4b4b5f3d7e6dadba0a7a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Minesweeper_Index), @"mvc.1.0.view", @"/Views/Minesweeper/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcf2c7bce02917c2a9d4b4b5f3d7e6dadba0a7a0", @"/Views/Minesweeper/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a255fb2f383d899ed0c0ccf430bd8669ab94c67", @"/Views/_ViewImports.cshtml")]
    public class Views_Minesweeper_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\Index.cshtml"
  
    ViewData["Title"] = "index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div>\r\n");
#nullable restore
#line 10 "C:\Users\spart\Documents\GitHub\CST-247-DarwinianDuo\MinesweeperCLC\MinesweeperCLC\Views\Minesweeper\Index.cshtml"
       
        Html.RenderPartial("~/Views/Shared/_ViewMinesweeper.cshtml");
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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