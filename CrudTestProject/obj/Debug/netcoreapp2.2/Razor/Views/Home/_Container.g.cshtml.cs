#pragma checksum "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96ee5002fe61f5044a159f22c677a24f51087158"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Container), @"mvc.1.0.view", @"/Views/Home/_Container.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_Container.cshtml", typeof(AspNetCore.Views_Home__Container))]
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
#line 1 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\_ViewImports.cshtml"
using CrudTestProject;

#line default
#line hidden
#line 2 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\_ViewImports.cshtml"
using CrudTestProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ee5002fe61f5044a159f22c677a24f51087158", @"/Views/Home/_Container.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f829453ccc76fa22ea1220a57b842a49eead5973", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Container : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrudTestProject.Models.CustomerVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 59, true);
            WriteLiteral("<div class=\"Container\">\r\n\r\n\t<div class=\"row\">\r\n\t\t<div>\r\n\t\t\t");
            EndContext();
            BeginContext(103, 37, false);
#line 6 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.DisplayNameFor(c => c.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(140, 24, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
            EndContext();
            BeginContext(165, 66, false);
#line 9 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.TextBoxFor(c => c.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(231, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(237, 87, false);
#line 10 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(324, 53, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<div>\r\n\t\t\t");
            EndContext();
            BeginContext(378, 36, false);
#line 15 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.DisplayNameFor(c => c.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(414, 24, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
            EndContext();
            BeginContext(439, 65, false);
#line 18 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.TextBoxFor(c => c.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(504, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(510, 86, false);
#line 19 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(596, 53, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<div>\r\n\t\t\t");
            EndContext();
            BeginContext(650, 33, false);
#line 24 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.DisplayNameFor(c => c.Email));

#line default
#line hidden
            EndContext();
            BeginContext(683, 105, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<input type=\"email\" id=\"Email\" name=\"Email\" class=\"form-control\" required />\r\n\t\t\t");
            EndContext();
            BeginContext(789, 83, false);
#line 28 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(872, 53, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<div>\r\n\t\t\t");
            EndContext();
            BeginContext(926, 39, false);
#line 33 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.DisplayNameFor(c => c.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(965, 116, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<input type=\"date\" id=\"DateOfBirth\" name=\"DateOfBirth\" class=\"form-control\" required />\r\n\t\t\t");
            EndContext();
            BeginContext(1082, 89, false);
#line 37 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 134, true);
            WriteLiteral("\r\n\t\t\t<span id=\"DOB-error-msg\" class=\"text-danger hide\">You are so old :|</span>\r\n\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<div>\r\n\t\t\t");
            EndContext();
            BeginContext(1306, 45, false);
#line 44 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.DisplayNameFor(c => c.BankAccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 128, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<input type=\"text\" id=\"BankAccountNumber\" name=\"BankAccountNumber\" class=\"form-control\" required />\r\n\t\t\t");
            EndContext();
            BeginContext(1480, 95, false);
#line 48 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.ValidationMessageFor(model => model.BankAccountNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 157, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<div>\r\n\t\t\tPhone Number\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<input type=\"tel\" name=\"PhoneNumber\" id=\"PhoneNumber\" required>\r\n\t\t\t");
            EndContext();
            BeginContext(1733, 89, false);
#line 57 "D:\Programming\Asp.net Core\Crud test project\CrudTestProject\CrudTestProject\Views\Home\_Container.cshtml"
       Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 173, true);
            WriteLiteral("\r\n\t\t\t<span id=\"phone-error-msg\" class=\"text-danger hide\">Phone Number is invalid</span>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<button type=\"submit\" id=\"cmdSubmit\">Submit</button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrudTestProject.Models.CustomerVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
