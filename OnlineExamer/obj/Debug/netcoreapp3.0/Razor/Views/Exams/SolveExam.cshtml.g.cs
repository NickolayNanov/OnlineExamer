#pragma checksum "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48d47e5735b4722d5dde4bb40ce700da5b0218a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exams_SolveExam), @"mvc.1.0.view", @"/Views/Exams/SolveExam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48d47e5735b4722d5dde4bb40ce700da5b0218a7", @"/Views/Exams/SolveExam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfbb7bcc60d76efe3a901e374715a7a20d1ff74", @"/Views/_ViewImports.cshtml")]
    public class Views_Exams_SolveExam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineExamer.Models.Exams.FinalExamQuestions>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
  
    ViewData["Title"] = "SolveExam";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
    int counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center mb-3\">");
#nullable restore
#line 8 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
                        Write(Model.StartingMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" по ");
#nullable restore
#line 8 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
                                                  Write(Model.ExamType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n");
#nullable restore
#line 13 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
             foreach (var question in Model.Questions.ToList())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 15 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
                  Write(counter++);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 15 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
                                Write(question.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 16 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"

                if (!question.IsOpenAnswer)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <ul>\r\n");
#nullable restore
#line 21 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
                             foreach (var answer in question.Answers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li>
                                    <label for=""defaultRadio"" class=""si si-radio"">
                                        <input type=""radio"" id=""defaultRadio"" name=""radioGroup"" />
                                        <span class=""si-label"">");
#nullable restore
#line 26 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
                                                          Write(answer.Contnent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </label>\r\n                                </li>\r\n");
#nullable restore
#line 29 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 32 "D:\Projects\OnlineExamer2.0\OnlineExamer\OnlineExamer\Views\Exams\SolveExam.cshtml"
                }
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineExamer.Models.Exams.FinalExamQuestions> Html { get; private set; }
    }
}
#pragma warning restore 1591
