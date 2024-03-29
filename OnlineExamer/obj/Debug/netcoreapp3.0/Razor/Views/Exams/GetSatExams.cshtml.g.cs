#pragma checksum "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6950449ab3004e3343162fff8cfbf64d5ed6800a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exams_GetSatExams), @"mvc.1.0.view", @"/Views/Exams/GetSatExams.cshtml")]
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
#line 1 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\_ViewImports.cshtml"
using OnlineExamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\_ViewImports.cshtml"
using OnlineExamer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6950449ab3004e3343162fff8cfbf64d5ed6800a", @"/Views/Exams/GetSatExams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfbb7bcc60d76efe3a901e374715a7a20d1ff74", @"/Views/_ViewImports.cshtml")]
    public class Views_Exams_GetSatExams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineExamer.Models.Exams.MyExamViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
  
    ViewData["Title"] = "GetSatExams";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
 if (this.Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-center mb-3\">Моите изпити</h1>\r\n");
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
             foreach (var exam in this.Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table col-xl-12"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th class=""text-center"" scope=""col"">Предмет на изпита</th>
                            <th class=""text-center"" scope=""col"">Година</th>
                            <th class=""text-center"" scope=""col"">Изкарани точки</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
");
#nullable restore
#line 25 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
                             if (exam.ExamType.Equals("БългарскиEзик"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th class=\"text-center\" scope=\"row\">Български език</th>\r\n");
#nullable restore
#line 28 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
                            }
                            else if (exam.ExamType.Equals("АнглийскиЕзик"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th class=\"text-center\" scope=\"row\">Английски език</th>\r\n");
#nullable restore
#line 32 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th class=\"text-center\" scope=\"row\">");
#nullable restore
#line 35 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
                                                               Write(exam.ExamType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 36 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th class=\"text-center\" scope=\"row\">");
#nullable restore
#line 37 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
                                                           Write(exam.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th class=\"text-center\" scope=\"row\">");
#nullable restore
#line 38 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
                                                           Write(exam.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 42 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 45 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-center text-danger mb-3\">Все още не сте решил(а) нито една матура! Мисля, че е време да са захващаш за работа!</h1>\r\n");
#nullable restore
#line 49 "D:\OnlineExamer\OnlineExamer\OnlineExamer\OnlineExamer\Views\Exams\GetSatExams.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineExamer.Models.Exams.MyExamViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
