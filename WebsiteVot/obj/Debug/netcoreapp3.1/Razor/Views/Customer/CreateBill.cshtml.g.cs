#pragma checksum "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CreateBill.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "209a333a8809acd54f262b02591e49a89cbd77f7f6dbb0674f31cde5460ec093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CreateBill), @"mvc.1.0.view", @"/Views/Customer/CreateBill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"209a333a8809acd54f262b02591e49a89cbd77f7f6dbb0674f31cde5460ec093", @"/Views/Customer/CreateBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ab9b08a46025e2d281e12e2bad1d23982f31d4452f2a6d8675229d7c589333f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_CreateBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteVot.Models.Hoadon>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CreateBill.cshtml"
  
    ViewData["Title"] = "Đặt hàng thành công";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Đặt hàng thành công</h3>\r\n<p>Đơn hàng mã số ");
#nullable restore
#line 6 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CreateBill.cshtml"
             Write(Model.MaHd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" trị giá ");
#nullable restore
#line 6 "C:\Users\VAN VANG\Documents\GitHub\DoAnWeb\WebsiteVot\Views\Customer\CreateBill.cshtml"
                                  Write(((int)Model.TongTien).ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ đã được hệ thống ghi nhận. Chúng tôi sẽ sớm liên hệ bạn để xác nhận...</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteVot.Models.Hoadon> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
