#pragma checksum "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cf9e7032d71ac065230a4f10122a56fa277718c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComputerFirm.Pages.FilReq.Filter.Pages_FilReq_Filter_FilterPosition), @"mvc.1.0.razor-page", @"/Pages/FilReq/Filter/FilterPosition.cshtml")]
namespace ComputerFirm.Pages.FilReq.Filter
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
#line 1 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\_ViewImports.cshtml"
using ComputerFirm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cf9e7032d71ac065230a4f10122a56fa277718c", @"/Pages/FilReq/Filter/FilterPosition.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dfa7fb9a903c8a3c7845c03ad127ea16456ec70", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FilReq_Filter_FilterPosition : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-hover\" >\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff[0].ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff[0].FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff[0].Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff[0].Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff[0].Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff[0].PassportData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff[0].Position_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
         foreach (var item in Model.Staff)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
               Write(Html.DisplayFor(model => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
               Write(Html.DisplayFor(modelItem => item.PassportData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
                       Write(Model.Position.NamePosition);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n      </tr>\r\n");
#nullable restore
#line 65 "C:\Users\kolgn\Desktop\Программы\clone\ComputerFirm\Pages\FilReq\Filter\FilterPosition.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComputerFirm.Pages.FilReq.Filter.FilterPositionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ComputerFirm.Pages.FilReq.Filter.FilterPositionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ComputerFirm.Pages.FilReq.Filter.FilterPositionModel>)PageContext?.ViewData;
        public ComputerFirm.Pages.FilReq.Filter.FilterPositionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591