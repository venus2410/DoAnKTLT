#pragma checksum "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaLoaiHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43959a234f8552325fc7efc16bf52cbc7d0d4505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DoAnKTLT_NguyenCongDanh_21880020.Pages.Pages_MH_SuaLoaiHang), @"mvc.1.0.razor-page", @"/Pages/MH_SuaLoaiHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43959a234f8552325fc7efc16bf52cbc7d0d4505", @"/Pages/MH_SuaLoaiHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7a6e2c1f43198cf584b43f5dffe355602ca194", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_SuaLoaiHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43959a234f8552325fc7efc16bf52cbc7d0d45053530", async() => {
                WriteLiteral("\r\n    <label for=\"Ma\">Mã: </label>");
#nullable restore
#line 6 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaLoaiHang.cshtml"
                           Write(Model.lh.MaLH);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n    <label for=\"Ten\">Tên:</label>\r\n    <input name=\"Ten\"");
                BeginWriteAttribute("value", " value=\"", 213, "\"", 236, 1);
#nullable restore
#line 8 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaLoaiHang.cshtml"
WriteAttributeValue("", 221, Model.lh.TenLH, 221, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    <input type=\"submit\" value=\"Tạo\" />\r\n");
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
#line 11 "D:\Hoc Tap\HK2 2021-2022\KTLT\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\DoAnKTLT_NguyenCongDanh_21880020\Pages\MH_SuaLoaiHang.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_SuaLoaiHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_SuaLoaiHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_SuaLoaiHangModel>)PageContext?.ViewData;
        public DoAnKTLT_NguyenCongDanh_21880020.Pages.MH_SuaLoaiHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
