#pragma checksum "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e153300632bdd8b7e6ff4c4f6eca09c98cf47829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComputerFirm.Pages.FilReq.Filter.Pages_FilReq_Filter_FilterOrders), @"mvc.1.0.razor-page", @"/Pages/FilReq/Filter/FilterOrders.cshtml")]
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
#line 1 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\_ViewImports.cshtml"
using ComputerFirm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e153300632bdd8b7e6ff4c4f6eca09c98cf47829", @"/Pages/FilReq/Filter/FilterOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dfa7fb9a903c8a3c7845c03ad127ea16456ec70", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FilReq_Filter_FilterOrders : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].OrderData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].DueData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].ShareofPrepayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].PaymentMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].ExecutionMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].GeneralWarranttyPeriod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
         foreach (var item in Model.Order)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.DueData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShareofPrepayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaymentMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExecutionMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.GeneralWarranttyPeriod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 69 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
               Write(Model.Customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\kolgn\Desktop\Программы\вечером клонирую 0912\ComputerFirm\Pages\FilReq\Filter\FilterOrders.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComputerFirm.Pages.FilReq.Filter.FilterOrdersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ComputerFirm.Pages.FilReq.Filter.FilterOrdersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ComputerFirm.Pages.FilReq.Filter.FilterOrdersModel>)PageContext?.ViewData;
        public ComputerFirm.Pages.FilReq.Filter.FilterOrdersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591