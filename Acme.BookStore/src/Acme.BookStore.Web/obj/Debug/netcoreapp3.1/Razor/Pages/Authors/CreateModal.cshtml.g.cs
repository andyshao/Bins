#pragma checksum "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f19c395ba16e66e0a21f0ae459d63bcb856a3262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Authors_CreateModal), @"mvc.1.0.razor-page", @"/Pages/Authors/CreateModal.cshtml")]
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
#line 2 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
using Acme.BookStore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
using Acme.BookStore.Web.Pages.Authors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19c395ba16e66e0a21f0ae459d63bcb856a3262", @"/Pages/Authors/CreateModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25152d795852518cc499282e563bc297efeed2a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Authors_CreateModal : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Authors/CreateModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal.AbpModalTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal.AbpModalHeaderTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalHeaderTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal.AbpModalBodyTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalBodyTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form.AbpInputTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal.AbpModalFooterTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalFooterTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f19c395ba16e66e0a21f0ae459d63bcb856a32625292", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f19c395ba16e66e0a21f0ae459d63bcb856a32625552", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-modal-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f19c395ba16e66e0a21f0ae459d63bcb856a32625829", async() => {
                    }
                    );
                    __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalHeaderTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal.AbpModalHeaderTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalHeaderTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
                     WriteLiteral(L["NewAuthor"].Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalHeaderTagHelper.Title = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("title", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalHeaderTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-modal-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f19c395ba16e66e0a21f0ae459d63bcb856a32627729", async() => {
                        WriteLiteral("\n            ");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f19c395ba16e66e0a21f0ae459d63bcb856a32628023", async() => {
                        }
                        );
                        __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form.AbpInputTagHelper>();
                        __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper);
#nullable restore
#line 15 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper.AspFor = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Author.Name);

#line default
#line hidden
#nullable disable
                        __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper.AspFor, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        WriteLiteral("\n            ");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f19c395ba16e66e0a21f0ae459d63bcb856a32629785", async() => {
                        }
                        );
                        __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form.AbpInputTagHelper>();
                        __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper);
#nullable restore
#line 16 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper.AspFor = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Author.BirthDate);

#line default
#line hidden
#nullable disable
                        __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper.AspFor, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        WriteLiteral("\n            ");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f19c395ba16e66e0a21f0ae459d63bcb856a326211552", async() => {
                        }
                        );
                        __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form.AbpInputTagHelper>();
                        __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper);
#nullable restore
#line 17 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper.AspFor = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Author.ShortBio);

#line default
#line hidden
#nullable disable
                        __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Form_AbpInputTagHelper.AspFor, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                    __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalBodyTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal.AbpModalBodyTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalBodyTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-modal-footer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f19c395ba16e66e0a21f0ae459d63bcb856a326214185", async() => {
                    }
                    );
                    __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalFooterTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal.AbpModalFooterTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalFooterTagHelper);
#nullable restore
#line 19 "E:\WorkSpace\CSharp\abp\abp-samples-master\BookStore-Mvc-EfCore\src\Acme.BookStore.Web\Pages\Authors\CreateModal.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalFooterTagHelper.Buttons = (AbpModalButtons.Cancel|AbpModalButtons.Save);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("buttons", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalFooterTagHelper.Buttons, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal.AbpModalTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Modal_AbpModalTagHelper);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
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
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateModalModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CreateModalModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CreateModalModel>)PageContext?.ViewData;
        public CreateModalModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591