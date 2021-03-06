#pragma checksum "C:\Users\gita.sunuwar\source\repos\OLC\OLC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73316daf028c83200d906278290c25595306942b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73316daf028c83200d906278290c25595306942b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\gita.sunuwar\source\repos\OLC\OLC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Login Page";

#line default
#line hidden
            BeginContext(46, 2586, true);
            WriteLiteral(@"<!--Header Section-->
<h1 class=""pb-2 mt-4 mb-2 border-bottom"">Online Learning Center</h1>

<!--Info Section-->
<p>
    The Online Learning  Center (OLC) is available 24 hours a day, 7 days a week. From mandatory assignments to supplemental materials,
    the OLC offers students the opportunity to achieve their goal of English Language Proficiency
</p>

<!--Row Section-->
<div class=""row"">
    <!--Login Panel-->
    <div class=""col-md-4 col-xs-8"">
        <div class=""card"">
            <div class=""card-header"">
                <h4><i class=""fa fa-fw fa-sign-in""></i>OLC Login</h4>
            </div>
            <div class=""card-body"">
                <form method=""post"">
                    <!--Wrap labels and form controls in form-group class-->
                    <div class=""form-group"">
                        <label asp-for=""Username"">Username:</label>
                        <input asp-for=""Username"" placeholder=""Enter username"" class=""form-control"" name=""userName"" id=""userName"" />");
            WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <label asp-for=""Password"">Password:</label>
                        <input asp-for=""Password"" type=""password"" placeholder=""Enter password"" maxlength=""20"" class=""form-control"" name=""password"" id=""password"" />
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Login</button>
                </form>
            </div>
        </div>
    </div>
    <!--Useful links Panel-->
    <div class=""col-md-4 col-xs-8"">
        <div class=""card"">
            <div class=""card-header"">
                <h4><i class=""fa fa-fw fa-link""></i> USEFUL LINKS:</h4>
            </div>
            <div class=""card-body"">
                <i class=""fa fa-fw fa-link""></i>
                <a asp-area="""" asp-controller=""Home"" asp-action=""About"">AES Home</a>
                <a href=""allopen/esl_loader""> ESL Links</a>
                <div>
                    <i class=""fa fa-fw fa-link""");
            WriteLiteral(@"></i>
                    <a href=""allopen/sightseeing_loader""> Sightseeing Links</a>
                </div>
                <div>
                    <i class=""fa fa-newspaper-o""></i>
                    <a href=""allopen/mag_loader""> Military News &amp; Magazines</a>
                </div>
                <div>
                    <i class=""fa fa-fw fa-thumbs-up""></i>
                    <a href=""allopen/useful_loader""> Useful Information</a>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
