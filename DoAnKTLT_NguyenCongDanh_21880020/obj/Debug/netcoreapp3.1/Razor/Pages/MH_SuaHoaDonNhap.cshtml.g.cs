#pragma checksum "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "550f17e52d67fcbdb32148c00e08b8c6d934bca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DoAnKTLT_NguyenCongDanh_21880020.Pages.Pages_MH_SuaHoaDonNhap), @"mvc.1.0.razor-page", @"/Pages/MH_SuaHoaDonNhap.cshtml")]
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
#line 3 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
using DoAnKTLT_NguyenCongDanh_21880020.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"550f17e52d67fcbdb32148c00e08b8c6d934bca1", @"/Pages/MH_SuaHoaDonNhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7a6e2c1f43198cf584b43f5dffe355602ca194", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_SuaHoaDonNhap : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550f17e52d67fcbdb32148c00e08b8c6d934bca13961", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <label>Mã hóa đơn nhập</label>\r\n            <input name=\"maHD\" class=\"float-right\"");
                BeginWriteAttribute("value", " value=\"", 294, "\"", 323, 1);
#nullable restore
#line 8 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
WriteAttributeValue("", 302, Model.hdBanDau.MaHDN, 302, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/><br />\r\n            <label>Mặt hàng</label>\r\n            <select name=\"mhChon\" id=\"mhChon\" class=\"float-right\">\r\n");
#nullable restore
#line 11 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
                 foreach (MatHang mh in Model.lstMH)
                {
                    if (mh.MaMH == Model.hdBanDau.MatHangNhap)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550f17e52d67fcbdb32148c00e08b8c6d934bca15425", async() => {
#nullable restore
#line 15 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
                                                     Write(mh.TenMH);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
                           WriteLiteral(mh.MaMH);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 16 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550f17e52d67fcbdb32148c00e08b8c6d934bca18148", async() => {
#nullable restore
#line 19 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
                                            Write(mh.TenMH);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
                           WriteLiteral(mh.MaMH);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select><br />\r\n            <label>Số lượng</label>\r\n            <input name=\"soLuong\" type=\"number\" id=\"soLuong\" required min=\"0\" class=\"float-right\"");
                BeginWriteAttribute("value", " value=\"", 1023, "\"", 1058, 1);
#nullable restore
#line 24 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
WriteAttributeValue("", 1031, Model.hdBanDau.SoLuongNhap, 1031, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/><br />\r\n            <button type=\"submit\">Sửa</button><br />\r\n            <a href=\"/MH_TimKiemHoaDonNhap\">Quay lại</a>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonNhap.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_SuaHoaDonNhapModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_SuaHoaDonNhapModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_SuaHoaDonNhapModel>)PageContext?.ViewData;
        public DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_SuaHoaDonNhapModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591