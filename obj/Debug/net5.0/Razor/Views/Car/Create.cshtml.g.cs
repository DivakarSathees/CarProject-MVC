#pragma checksum "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92699e51549efd0bf303d45fbc1657ac9778dde5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Create), @"mvc.1.0.view", @"/Views/Car/Create.cshtml")]
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
#line 1 "/home/coder/project/workspace/CarProject/Views/_ViewImports.cshtml"
using CarProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/coder/project/workspace/CarProject/Views/_ViewImports.cshtml"
using CarProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92699e51549efd0bf303d45fbc1657ac9778dde5", @"/Views/Car/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778d5a39de8fc50f9737ce5f3aea178cea128dde", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Create New Car</h2>\n\n");
#nullable restore
#line 5 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 8 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.LabelFor(model => model.Car_Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 9 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.TextBoxFor(model => model.Car_Brand, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 12 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.LabelFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 13 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.TextBoxFor(model => model.Type, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 16 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.LabelFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 17 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.TextBoxFor(model => model.Color, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div> <!-- add a closing tag for the div element -->\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 21 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.LabelFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 22 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.TextBoxFor(model => model.Mileage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 26 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.LabelFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 27 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
   Write(Html.TextBoxFor(model => model.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\n");
#nullable restore
#line 30 "/home/coder/project/workspace/CarProject/Views/Car/Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591