#pragma checksum "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64fc09989ad0bcfa3680e4ec2fda78fbff876fc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Kenan.AdvertisementApp.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Kenan.AdvertisementApp.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64fc09989ad0bcfa3680e4ec2fda78fbff876fc8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f005fae4cab2ef9a9423c22d1bac998bfd44235", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProvidedServiceListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\Home\Index.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Header-->
<header class=""masthead text-center text-white"">
    <div class=""masthead-content"">
        <div class=""container px-5"">
            <h1 class=""masthead-heading mb-0"">Udemy Bilişim</h1>
            <h2 class=""masthead-subheading mb-0"">Masaüstü, Web ve Mobil Uygulamalar</h2>
            <a class=""btn btn-primary btn-xl rounded-pill mt-5"" href=""#scroll"">Learn More</a>
        </div>
    </div>
    <div class=""bg-circle-1 bg-circle""></div>
    <div class=""bg-circle-2 bg-circle""></div>
    <div class=""bg-circle-3 bg-circle""></div>
    <div class=""bg-circle-4 bg-circle""></div>
</header>

");
#nullable restore
#line 20 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\Home\Index.cshtml"
 for (int i = 0; i < Model?.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<section id=\"scroll\">\n    <div class=\"container px-5\">\n        <div class=\"row gx-5 align-items-center\">\n            <div");
            BeginWriteAttribute("class", " class=\"", 831, "\"", 874, 2);
            WriteAttributeValue("", 839, "col-lg-6", 839, 8, true);
#nullable restore
#line 25 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 847, i%2==0? "order-lg-2":"", 848, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"p-5\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64fc09989ad0bcfa3680e4ec2fda78fbff876fc85358", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 953, "~/Images/", 953, 9, true);
#nullable restore
#line 26 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 962, Model[i].ImagePath, 962, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 981, "", 982, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\n            </div>\n            <div");
            BeginWriteAttribute("class", " class=\"", 1028, "\"", 1071, 2);
            WriteAttributeValue("", 1036, "col-lg-6", 1036, 8, true);
#nullable restore
#line 28 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1044, i%2==0? "order-lg-1":"", 1045, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"p-5\">\n                    <h2 class=\"display-4\">");
#nullable restore
#line 30 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\Home\Index.cshtml"
                                     Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quod aliquid, mollitia odio veniam sit iste esse assumenda amet aperiam exercitationem, ea animi blanditiis recusandae! Ratione voluptatum molestiae adipisci, beatae obcaecati.</p>
                </div>
            </div>
        </div>
    </div>
</section>  ");
#nullable restore
#line 36 "C:\Users\kenan\OneDrive\Masaüstü\sdf\Protera\AdvertisementApp\Kenan.AdvertisementApp.UI\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProvidedServiceListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
