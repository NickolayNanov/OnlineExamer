#pragma checksum "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\SchoolSubjects\SubjectsAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ed74e82958c0d27fca65a3ac72cab14d0ef28e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SchoolSubjects_SubjectsAll), @"mvc.1.0.view", @"/Views/SchoolSubjects/SubjectsAll.cshtml")]
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
#line 1 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\_ViewImports.cshtml"
using OnlineExamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\_ViewImports.cshtml"
using OnlineExamer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ed74e82958c0d27fca65a3ac72cab14d0ef28e", @"/Views/SchoolSubjects/SubjectsAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12fc8e7afd77bcdd267525f7f74e263ff4942ca2", @"/Views/_ViewImports.cshtml")]
    public class Views_SchoolSubjects_SubjectsAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineExamer.Models.SchoolSubjects.SchooolSubjectViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\SchoolSubjects\SubjectsAll.cshtml"
  
    ViewData["Title"] = "SubjectsAll";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\SchoolSubjects\SubjectsAll.cshtml"
    int index = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Училищни предмети</h1>\r\n<table class=\"table table-hover\">\r\n    <thead class=\"subject-table\">\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Име</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\SchoolSubjects\SubjectsAll.cshtml"
         foreach (var subject in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
#nullable restore
#line 20 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\SchoolSubjects\SubjectsAll.cshtml"
                            Write(index++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\SchoolSubjects\SubjectsAll.cshtml"
               Write(subject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\SchoolSubjects\SubjectsAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div>
    <h1 class=""text-center"">Всички предмети, които платформата поддържа</h1>
    <p>Това са най-често търсените предмети, но ако смятате, че някои предмет липсва се свържете с мен на е-поща: nickolaynanov17@gmail.com</p>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineExamer.Models.SchoolSubjects.SchooolSubjectViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591