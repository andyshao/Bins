#pragma checksum "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70a7c287a252a591fef9868252100fafb6667c77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Authors_Index), @"mvc.1.0.razor-page", @"/Pages/Authors/Index.cshtml")]
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
#line 2 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
using Acme.BookStore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
using Acme.BookStore.Permissions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
using Acme.BookStore.Web.Pages.Authors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70a7c287a252a591fef9868252100fafb6667c77", @"/Pages/Authors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25152d795852518cc499282e563bc297efeed2a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Authors_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/Pages/Authors/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("NewAuthorButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("icon", "plus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AuthorsTable"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpScriptTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card.AbpCardTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card.AbpCardHeaderTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardHeaderTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpRowTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpRowTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpColumnTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card.AbpCardTitleTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardTitleTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card.AbpCardBodyTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardBodyTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Table.AbpTableTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Table_AbpTableTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70a7c287a252a591fef9868252100fafb6667c777073", async() => {
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptTagHelper);
                __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a7c287a252a591fef9868252100fafb6667c778361", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-card-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a7c287a252a591fef9868252100fafb6667c778625", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a7c287a252a591fef9868252100fafb6667c778908", async() => {
                        WriteLiteral("\n            ");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a7c287a252a591fef9868252100fafb6667c779195", async() => {
                            WriteLiteral("\n                ");
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-card-title", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a7c287a252a591fef9868252100fafb6667c779497", async() => {
#nullable restore
#line 20 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
                           Write(L["Authors"]);

#line default
#line hidden
#nullable disable
                            }
                            );
                            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardTitleTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card.AbpCardTitleTagHelper>();
                            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardTitleTagHelper);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            WriteLiteral("\n            ");
                        }
                        );
                        __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpColumnTagHelper>();
                        __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper);
#nullable restore
#line 19 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper.SizeMd = global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.ColumnSize._6;

#line default
#line hidden
#nullable disable
                        __tagHelperExecutionContext.AddTagHelperAttribute("size-md", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper.SizeMd, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        WriteLiteral("\n            ");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a7c287a252a591fef9868252100fafb6667c7712471", async() => {
                            WriteLiteral("\n");
#nullable restore
#line 23 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
                 if (await AuthorizationService
                    .IsGrantedAsync(BookStorePermissions.Authors.Create))
                {

#line default
#line hidden
#nullable disable
                            WriteLiteral("                    ");
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70a7c287a252a591fef9868252100fafb6667c7713160", async() => {
                            }
                            );
                            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonTagHelper>();
                            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper);
                            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
                          WriteLiteral(L["NewAuthor"].Value);

#line default
#line hidden
#nullable disable
                            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper.Text = __tagHelperStringValueBuffer;
                            __tagHelperExecutionContext.AddTagHelperAttribute("text", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper.Text, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper.Icon = (string)__tagHelperAttribute_2.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 29 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper.ButtonType = global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonType.Primary;

#line default
#line hidden
#nullable disable
                            __tagHelperExecutionContext.AddTagHelperAttribute("button-type", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper.ButtonType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            WriteLiteral("\n");
#nullable restore
#line 30 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                            WriteLiteral("            ");
                        }
                        );
                        __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpColumnTagHelper>();
                        __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper);
#nullable restore
#line 22 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper.SizeMd = global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.ColumnSize._6;

#line default
#line hidden
#nullable disable
                        __tagHelperExecutionContext.AddTagHelperAttribute("size-md", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper.SizeMd, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        WriteLiteral("\n        ");
                    }
                    );
                    __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpRowTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpRowTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpRowTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n    ");
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardHeaderTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card.AbpCardHeaderTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardHeaderTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-card-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a7c287a252a591fef9868252100fafb6667c7719688", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-table", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a7c287a252a591fef9868252100fafb6667c7719970", async() => {
                    }
                    );
                    __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Table_AbpTableTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Table.AbpTableTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Table_AbpTableTagHelper);
#nullable restore
#line 35 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Table_AbpTableTagHelper.StripedRows = true;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("striped-rows", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Table_AbpTableTagHelper.StripedRows, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n    ");
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardBodyTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card.AbpCardBodyTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardBodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card.AbpCardTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Card_AbpCardTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<BookStoreResource> L { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591