#pragma checksum "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed44ac54ab5d16a82703727df8338bfc49f517d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DoAnKTLT_NguyenCongDanh_21880020.Pages.Pages_MH_TimKiemLoaiHang), @"mvc.1.0.razor-page", @"/Pages/MH_TimKiemLoaiHang.cshtml")]
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
#line 3 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml"
using DoAnKTLT_NguyenCongDanh_21880020.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed44ac54ab5d16a82703727df8338bfc49f517d0", @"/Pages/MH_TimKiemLoaiHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7a6e2c1f43198cf584b43f5dffe355602ca194", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_TimKiemLoaiHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed44ac54ab5d16a82703727df8338bfc49f517d03841", async() => {
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
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Mã LH</th>\r\n        <th>Tên</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml"
     foreach (LoaiHang lh in Model.lstLH)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml"
           Write(lh.MaLH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml"
           Write(lh.TenLH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 500, "\"", 534, 2);
            WriteAttributeValue("", 507, "/MH_SuaLoaiHang?id=", 507, 19, true);
#nullable restore
#line 20 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml"
WriteAttributeValue("", 526, lh.MaLH, 526, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 563, "\"", 597, 2);
            WriteAttributeValue("", 570, "/MH_XoaLoaiHang?id=", 570, 19, true);
#nullable restore
#line 21 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml"
WriteAttributeValue("", 589, lh.MaLH, 589, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 26 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_TimKiemLoaiHang.cshtml"
Write(Model.chuoi);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_TimKiemLoaiHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_TimKiemLoaiHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_TimKiemLoaiHangModel>)PageContext?.ViewData;
        public DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_TimKiemLoaiHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591