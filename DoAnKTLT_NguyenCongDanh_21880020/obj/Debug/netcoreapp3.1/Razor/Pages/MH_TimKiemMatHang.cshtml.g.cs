#pragma checksum "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d14bbf92c83a61cab4f49839f4fda5f9e20bccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DoAnKTLT_NguyenCongDanh_21880020.Pages.Pages_MH_TimKiemMatHang), @"mvc.1.0.razor-page", @"/Pages/MH_TimKiemMatHang.cshtml")]
namespace DoAnKTLT_NguyenCongDanh_21880020.Pages
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
#line 1 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\_ViewImports.cshtml"
using DoAnKTLT_NguyenCongDanh_21880020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
using DoAnKTLT_NguyenCongDanh_21880020.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d14bbf92c83a61cab4f49839f4fda5f9e20bccd", @"/Pages/MH_TimKiemMatHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7a6e2c1f43198cf584b43f5dffe355602ca194", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_TimKiemMatHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d14bbf92c83a61cab4f49839f4fda5f9e20bccd3835", async() => {
                WriteLiteral("\r\n    <input name=\"noiDungTimKiem\" />\r\n    <button type=\"submit\">Tìm kiếm</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Mã MH</th>\r\n        <th>Tên</th>\r\n        <th>Hạn dùng</th>\r\n        <th>Công ty sản xuất</th>\r\n        <th>Ngày sản xuất</th>\r\n        <th>Loại</th>\r\n        <th>Giá</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
     for(int i=0;i<Model.lstMH.Count;i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
           Write(Model.lstMH[i].MaMH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
           Write(Model.lstMH[i].TenMH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
           Write(Model.lstMH[i].HanDungMH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
           Write(Model.lstMH[i].CongTySX);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
           Write(Model.lstMH[i].NgaySX);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
           Write(Model.lstTenLoai[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
           Write(Model.lstMH[i].Gia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 887, "\"", 932, 2);
            WriteAttributeValue("", 894, "/MH_SuaMatHang?id=", 894, 18, true);
#nullable restore
#line 30 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
WriteAttributeValue("", 912, Model.lstMH[i].MaMH, 912, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 961, "\"", 1006, 2);
            WriteAttributeValue("", 968, "/MH_XoaMatHang?id=", 968, 18, true);
#nullable restore
#line 31 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
WriteAttributeValue("", 986, Model.lstMH[i].MaMH, 986, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 36 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemMatHang.cshtml"
Write(Model.chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_TimKiemMatHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_TimKiemMatHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_TimKiemMatHangModel>)PageContext?.ViewData;
        public DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_TimKiemMatHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
