#pragma checksum "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\Home\_TeacherTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf7399ede5c63147e24b5b4ec444cb4c21023a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__TeacherTable), @"mvc.1.0.view", @"/Views/Home/_TeacherTable.cshtml")]
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
#line 2 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.Models.DotNetNote;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.Data.Repositorys.DotNetNote;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.Data.Repositorys.DashBoard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\_ViewImports.cshtml"
using CommonLibrary;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf7399ede5c63147e24b5b4ec444cb4c21023a2", @"/Views/Home/_TeacherTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2fe39bff9f5e668ac8c0ca6fb5a3eadc74d34e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__TeacherTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentTeacherViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Our Teachers</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Class</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
         foreach (var teacher in Model.Teachers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 15 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
               Write(teacher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
               Write(teacher.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 18 "C:\Users\wlstn\Desktop\portFolio\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentTeacherViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
