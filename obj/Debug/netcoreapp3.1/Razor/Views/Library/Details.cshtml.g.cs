#pragma checksum "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df36faaac873c552f9d585aebe564aadd70f1902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_Details), @"mvc.1.0.view", @"/Views/Library/Details.cshtml")]
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
#line 1 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\_ViewImports.cshtml"
using List;

#line default
#line hidden
#line 2 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\_ViewImports.cshtml"
using List.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df36faaac873c552f9d585aebe564aadd70f1902", @"/Views/Library/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"498a1da91a7d2dd855b9d39412d4fb4a917cc161", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List.Models.student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 14 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 17 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 20 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Matricula));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 23 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayFor(model => model.Matricula));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 26 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Carrera));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 29 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayFor(model => model.Carrera));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 32 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Turno));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 35 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayFor(model => model.Turno));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 38 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Grado));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 41 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayFor(model => model.Grado));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 44 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Grupo));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 47 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
       Write(Html.DisplayFor(model => model.Grupo));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <!--<a asp-action=\"Edit\" asp-route-id=\"");
#line 52 "C:\Users\Nauhl\Desktop\list\Lista\List\Views\Library\Details.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
            WriteLiteral("\">Edit</a> |-->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df36faaac873c552f9d585aebe564aadd70f19027087", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List.Models.student> Html { get; private set; }
    }
}
#pragma warning restore 1591
