#pragma checksum "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c0101b24b0345b90812255b917c28ec47e9f16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comics_Index), @"mvc.1.0.view", @"/Views/Comics/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\_ViewImports.cshtml"
using Image;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\_ViewImports.cshtml"
using Image.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c0101b24b0345b90812255b917c28ec47e9f16", @"/Views/Comics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30f8b2d9594ef9142c88c238da71381ad71f1cd3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Image.Models.ComicGenreViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
  
    ViewData["Title"] = "Gi??? H??ng";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c0101b24b0345b90812255b917c28ec47e9f167023", async() => {
                WriteLiteral("\n<h1 style=\"color:white\">S???n ph???m ???? th??m</h1>\n\n    <p>      \n           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c0101b24b0345b90812255b917c28ec47e9f167356", async() => {
                    WriteLiteral("<input type=\"submit\" value=\"Create new\" class=\"btn btn-primary\" style=\"background-color:lightblue\" />");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </p>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c0101b24b0345b90812255b917c28ec47e9f168690", async() => {
                    WriteLiteral("\n<p style=\"font-weight:bolder; color:white\">\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c0101b24b0345b90812255b917c28ec47e9f169005", async() => {
                        WriteLiteral("\n");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c0101b24b0345b90812255b917c28ec47e9f169279", async() => {
                            WriteLiteral("T???t C???");
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 15 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ComicGenre);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Genres;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\nT??n Truy???n: <input type=\"text\" name=\"SearchString\" />\n<input type=\"submit\" value=\"T??m Ki???m\" />\n</p>\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <table class=\"table\" style=\"border:hidden;border-radius:20px;background-color:lightcyan;\">\n        <thead>\n            <tr style=\"border:hidden;border-radius:20px;background-color:#66b2ff\">\n                <th>\n                    ");
#nullable restore
#line 26 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Comics[0].TenTruyen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 29 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Comics[0].NgayPhatHanh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 32 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Comics[0].TheLoai));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 35 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Comics[0].Gia));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 38 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Comics[0].Rating));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 44 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
            foreach (var item in Model.Comics)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 48 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenTruyen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 51 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NgayPhatHanh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 54 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TheLoai));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 57 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gia));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 60 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                      \n                    <td>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c0101b24b0345b90812255b917c28ec47e9f1618979", async() => {
                    WriteLiteral("Ch???nh s???a");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c0101b24b0345b90812255b917c28ec47e9f1621315", async() => {
                    WriteLiteral("Th??ng tin");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
                                                  WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c0101b24b0345b90812255b917c28ec47e9f1623654", async() => {
                    WriteLiteral("X??a");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
                                                 WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 69 "C:\Users\Admin\Downloads\Compressed\DuAn.github.io-main\DuAn.github.io-main\DuAn.github.io-main\ImageM\Image\Views\Comics\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n    </table>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Image.Models.ComicGenreViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
