#pragma checksum "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0236a282e143aa7a031721f3869f2f46f337ab61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\_ViewImports.cshtml"
using Task25_01_2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\_ViewImports.cshtml"
using Task25_01_2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0236a282e143aa7a031721f3869f2f46f337ab61", @"/Areas/admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4271fa829f353e4e9f2af68d876aa68078d321", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Page Content -->
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-12 mb-4"">

                            <!-- Illustrations -->
                            <div class=""card shadow mb-4"">
                                <div class=""card-header py-3"">
                                    <h6 class=""m-0 font-weight-bold text-primary"">Illustrations</h6>
                                </div>
                                <div class=""card-body"">
                                    <p>
                                        Add some quality, svg illustrations to your project courtesy of <a target=""_blank"" rel=""nofollow"" href=""https://undraw.co/"">unDraw</a>, a
                                        constantly updated collection of beautiful svg images that you can use
                                        completely free and without attribution!
                                    </p>
                                </div");
            WriteLiteral(">\n                            </div>\n\n                            <!-- Approach -->\n\n                            \n                            <div class=\"row\">\n\n");
#nullable restore
#line 31 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\Home\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-3"">
                                        <div class=""card shadow mb-4"">
                                            <div class=""card-header d-flex justify-content-between py-3"">
                                                <h6 class=""m-0 font-weight-bold text-primary"">");
#nullable restore
#line 36 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\Home\Index.cshtml"
                                                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                                                <h6 class=\"m-0 font-weight-bold text-primary\">");
#nullable restore
#line 37 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\Home\Index.cshtml"
                                                                                         Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                            </div>
                                            <div class=""card-body"">
                                                <div style=""margin: 18px 0px""><i style=""font-size: 45px; color:#4e73df !important;""");
            BeginWriteAttribute("class", " class=\"", 2107, "\"", 2125, 1);
#nullable restore
#line 40 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 2115, item.Icon, 2115, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\n                                                <p>\n                                                    ");
#nullable restore
#line 42 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\Home\Index.cshtml"
                                               Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </p>\n                                            </div>\n                                        </div>\n                                    </div>\n");
#nullable restore
#line 47 "C:\Users\tu201806127\Desktop\Task25_01_2022-master\Back_end\Task25_01_2022\Task25_01_2022\Areas\admin\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                </div>\n                <!-- /.container-fluid -->\n\n            </div>\n            <!-- End of Main Content -->\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
