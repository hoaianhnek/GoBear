#pragma checksum "C:\Users\hoaia\source\repos\GoBear\GoBear\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096662d9782973d8c22756fd813c1b340853c6e8"
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
#line 1 "C:\Users\hoaia\source\repos\GoBear\GoBear\Views\_ViewImports.cshtml"
using GoBear;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoaia\source\repos\GoBear\GoBear\Views\_ViewImports.cshtml"
using GoBear.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096662d9782973d8c22756fd813c1b340853c6e8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a090b529871a13fb1f77deb5bd714c799981c16c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bear_travel.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\hoaia\source\repos\GoBear\GoBear\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Bảo hiểm du lịch";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"list-products\">\r\n    <div class=\"content-product-wrap\">\r\n        <div class=\"row\" style=\"margin:0\">\r\n            <div class=\"col-2\" style=\"margin:auto\">\r\n                <div class=\"tilte-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "096662d9782973d8c22756fd813c1b340853c6e83851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-10 products-info"">
                <div class=""row""id=""content-listproduct"" style=""margin: 0;"">
                    <div class=""col-3"">
                        <div class=""name-product"">
                            <a href=""#"" class=""btn"">Thêm sản phẩm so sánh</a>
                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""name-product"">
                            <a href=""#"" class=""btn"">Thêm sản phẩm so sánh</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<div class=""compare-product"">
    <section class=""compare-dd"">
        <div>
            <div data-toggle=""collapse"" class=""product-hot"" data-target=""#product-hot"">So sánh các đặc điểm sản phẩm</div>
        </div>
        <div id=""product-hot"" class=""collapse show"">
            <div class=""row"" s");
            WriteLiteral(@"tyle=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
                    <span>Đánh giá chung</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
    <section class=""compare-information"">
        <div>
            <div data-toggle=""collapse"" class=""product-hot"" data-target=""#product-infomation"">Thông tin chung</div>
        </div>
        <div id=""product-infomation"" class=""collapse show"">
            <div class=""row payonline"" sty");
            WriteLiteral(@"le=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
                    <span>Có thể mua trực tuyến?</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row regula-age"" style=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
                    <span>Quy định độ tuổi người lớn</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
           ");
            WriteLiteral(@"             <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row define-family"" style=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
                    <span>Định nghĩa gia đình</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                           ");
            WriteLiteral(@"     -
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row children"" style=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
                    <span>Hồi hương trẻ em</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row hightlight"" style=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
    ");
            WriteLiteral(@"                <span>Điểm nổi bật</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""compare-accidents"">
        <div>
            <div data-toggle=""collapse"" class=""product-hot"" data-target=""#product-accidents"">Tai nạn cá nhân và thương tật</div>
        </div>
        <div id=""product-accidents"" class=""collapse show"">
            <div class=""row accident_myself"" style=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: righ");
            WriteLiteral(@"t;"">
                    <span>Tai nạn cá nhân</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row foreign_medical"" style=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
                    <span>Chi phí y tế nước ngoài</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                      ");
            WriteLiteral(@"          -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row patients_relative"" style=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
                    <span>Chi phí thân nhân thăm bệnh</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
   ");
            WriteLiteral(@"                 </div>
                </div>
            </div>
            <div class=""row subsidize"" style=""margin:0"">
                <div class=""col-2"" style=""margin:auto;text-align: right;"">
                    <span>Trợ cấp nằm viện ở nước ngoài</span>
                </div>
                <div class=""col-10 products-info"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div>
                                -
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>
<p>* Lãi suất được cung cấp bởi ngân hàng hoặc GoBear liên hệ trực tiếp ngân hàng và
    chỉ mang tính tham khảo. Ngân hàng sẽ xác nhận lại lãi suất chính xác khi ");
            WriteLiteral("duyệt khoản\r\n    vay. Lãi suất được cập nhật tháng 2/2019.\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591