#pragma checksum "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44d75477c289a47e65c6adcde67222d944aa5145a4743350c3db142629402b90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CheckOut), @"mvc.1.0.view", @"/Views/Customer/CheckOut.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\_ViewImports.cshtml"
using WebsiteVot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\_ViewImports.cshtml"
using WebsiteVot.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"44d75477c289a47e65c6adcde67222d944aa5145a4743350c3db142629402b90", @"/Views/Customer/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ab9b08a46025e2d281e12e2bad1d23982f31d4452f2a6d8675229d7c589333f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebsiteVot.Models.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateBill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
  
    ViewData["Title"] = "Thanh toán";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Vui lòng kiểm tra đầy đủ thông tin trước khi hoàn tất đơn hàng</p>\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <h4 class=\"text-info\">Thông tin khách hàng</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44d75477c289a47e65c6adcde67222d944aa5145a4743350c3db142629402b905003", async() => {
                WriteLiteral(@"
            <div class=""mb-3"">
                <label>Email</label>
                <input name=""email"" class=""form-control"" type=""text"" />
            </div>
            <div class=""mb-3"">
                <label>Họ tên</label>
                <input name=""hoten"" class=""form-control"" type=""text"" />
            </div>
            <div class=""mb-3"">
                <label>Điện thoại</label>
                <input name=""dienthoai"" class=""form-control"" type=""text"" />
            </div>
            <div class=""mb-3"">
                <label>Địa chỉ</label>
                <textarea name=""diachi"" class=""form-control""></textarea>
            </div>
            <div class=""mb-3"">
                <input type=""submit"" class=""btn btn-primary"" value=""Xác nhận đơn hàng"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"col\">\r\n        <h4 class=\"text-info\">Thông tin đơn hàng</h4>\r\n");
#nullable restore
#line 34 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
         if (Model.Count > 0)
        {
            int stt = 1;        // số thứ tự
            int thanhtien = 0;     // thành tiền
            int tongtien = 0;      // tổng tiền


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <tr class=""table-info"">
                    <th>STT</th>
                    <th>Sản phẩm</th>
                    <th>Giá</th>
                    <th>Số lượng</th>
                    <th>Thành tiền</th>

                </tr>
");
#nullable restore
#line 49 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
                 foreach (var i in Model)
                {
                    thanhtien = i.MatHang.GiaBan * i.SoLuong;
                    tongtien += thanhtien;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"align-middle\">\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
                        Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "44d75477c289a47e65c6adcde67222d944aa5145a4743350c3db142629402b908844", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2018, "~/images/", 2018, 9, true);
#nullable restore
#line 56 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
AddHtmlAttributeValue("", 2027, i.MatHang.HinhAnh, 2027, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
                        Write(i.MatHang.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 59 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
                        Write(i.MatHang.GiaBan.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n                        <td>");
#nullable restore
#line 60 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
                        Write(i.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 61 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
                        Write(thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 64 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"4\" class=\"text-end fw-bold\">Thành tiền</td>\r\n                    <td><strong class=\"text-danger\">");
#nullable restore
#line 67 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"
                                                Write(tongtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</strong></td>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 70 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CheckOut.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebsiteVot.Models.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
