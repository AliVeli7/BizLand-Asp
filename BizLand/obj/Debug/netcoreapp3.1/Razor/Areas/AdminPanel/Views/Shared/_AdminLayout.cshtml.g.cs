#pragma checksum "C:\Users\User\source\repos\BizLand\BizLand\Areas\AdminPanel\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1522d15ed2e37bf46e90112752e9abbdce4e2559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Shared/_AdminLayout.cshtml")]
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
#line 1 "C:\Users\User\source\repos\BizLand\BizLand\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BizLand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\BizLand\BizLand\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BizLand.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\BizLand\BizLand\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BizLand.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1522d15ed2e37bf46e90112752e9abbdce4e2559", @"/Areas/AdminPanel/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20fecfda4fff540d1ad33f34eade409bf388af5", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1522d15ed2e37bf46e90112752e9abbdce4e25595885", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Majestic Admin</title>
    <!-- plugins:css -->
    <link rel=""stylesheet"" href=""/admin/vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""/admin/vendors/base/vendor.bundle.base.css"">
    <!-- endinject -->
    <!-- plugin css for this page -->
    <link rel=""stylesheet"" href=""vendors/datatables.net-bs4/dataTables.bootstrap4.css"">
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <link rel=""stylesheet"" href=""/admin/css/style.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <!-- endinject -->
    <link rel=""shortcut icon"" href=""/admin/images/favicon.png"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1522d15ed2e37bf46e90112752e9abbdce4e25597888", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <div class=""row p-0 m-0 proBanner"" id=""proBanner"">
            <div class=""col-md-12 p-0 m-0"">
                <div class=""card-body card-body-padding d-flex align-items-center justify-content-between"">
                    <div class=""ps-lg-1"">
                        <div class=""d-flex align-items-center justify-content-between"">
                            <p class=""mb-0 font-weight-medium me-3 buy-now-text"">Free 24/7 customer support, updates, and more with this template!</p>
                            <a href=""https://www.bootstrapdash.com/product/majestic-admin-pro/?utm_source=organic&utm_medium=banner&utm_campaign=buynow_demo"" target=""_blank"" class=""btn me-2 buy-now-btn border-0"">Get Pro</a>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center justify-content-between"">
                        <a href=""https://www.bootstrapdash.com/product/majestic-admin-pro/""><i class=""mdi mdi-home me-3 text-whi");
                WriteLiteral(@"te""></i></a>
                        <button id=""bannerClose"" class=""btn border-0 p-0"">
                            <i class=""mdi mdi-close text-white me-0""></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
        <!-- partial:partials/_navbar.html -->
        <nav class=""navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
            <div class=""navbar-brand-wrapper d-flex justify-content-center"">
                <div class=""navbar-brand-inner-wrapper d-flex justify-content-between align-items-center w-100"">
                    <a class=""navbar-brand brand-logo"" href=""index.html""><img src=""images/logo.svg"" alt=""logo"" /></a>
                    <a class=""navbar-brand brand-logo-mini"" href=""index.html""><img src=""images/logo-mini.svg"" alt=""logo"" /></a>
                    <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
                        <span class=""mdi mdi-sort-variant""></sp");
                WriteLiteral(@"an>
                    </button>
                </div>
            </div>
            <div class=""navbar-menu-wrapper d-flex align-items-center justify-content-end"">
                <ul class=""navbar-nav mr-lg-4 w-100"">
                    <li class=""nav-item nav-search d-none d-lg-block w-100"">
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""search"">
                                    <i class=""mdi mdi-magnify""></i>
                                </span>
                            </div>
                            <input type=""text"" class=""form-control"" placeholder=""Search now"" aria-label=""search"" aria-describedby=""search"">
                        </div>
                    </li>
                </ul>
                <ul class=""navbar-nav navbar-nav-right"">
                    <li class=""nav-item dropdown me-1"">
                        <a class=""nav-link count-indicator dro");
                WriteLiteral(@"pdown-toggle d-flex justify-content-center align-items-center"" id=""messageDropdown"" href=""#"" data-bs-toggle=""dropdown"">
                            <i class=""mdi mdi-message-text mx-0""></i>
                            <span class=""count""></span>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""messageDropdown"">
                            <p class=""mb-0 font-weight-normal float-left dropdown-header"">Messages</p>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""/admin/images/faces/face4.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        David Grey
                                    </h6>
                     ");
                WriteLiteral(@"               <p class=""font-weight-light small-text text-muted mb-0"">
                                        The meeting is cancelled
                                    </p>
                                </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""/admin/images/faces/face2.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        Tim Cook
                                    </h6>
                                    <p class=""font-weight-light small-text text-muted mb-0"">
                                        New product launch
                                    </p>
                                </div>
                            </a>
        ");
                WriteLiteral(@"                    <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""images/faces/face3.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        Johnson
                                    </h6>
                                    <p class=""font-weight-light small-text text-muted mb-0"">
                                        Upcoming board meeting
                                    </p>
                                </div>
                            </a>
                        </div>
                    </li>
                    <li class=""nav-item dropdown me-4"">
                        <a class=""nav-link count-indicator dropdown-toggle d-flex align-items-center justify-content-center notification-dropdown"" id=""notifi");
                WriteLiteral(@"cationDropdown"" href=""#"" data-bs-toggle=""dropdown"">
                            <i class=""mdi mdi-bell mx-0""></i>
                            <span class=""count""></span>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""notificationDropdown"">
                            <p class=""mb-0 font-weight-normal float-left dropdown-header"">Notifications</p>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <div class=""item-icon bg-success"">
                                        <i class=""mdi mdi-information mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">Application Error</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">");
                WriteLiteral(@"
                                        Just now
                                    </p>
                                </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <div class=""item-icon bg-warning"">
                                        <i class=""mdi mdi-settings mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">Settings</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">
                                        Private message
                                    </p>
                                </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail""");
                WriteLiteral(@">
                                    <div class=""item-icon bg-info"">
                                        <i class=""mdi mdi-account-box mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">New user registration</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">
                                        2 days ago
                                    </p>
                                </div>
                            </a>
                        </div>
                    </li>
                    <li class=""nav-item nav-profile dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" data-bs-toggle=""dropdown"" id=""profileDropdown"">
                            <img src=""images/faces/face5.jpg"" alt=""profile"" />
                            <span class=""nav-profile-name"">Louis ");
                WriteLiteral(@"Barnett</span>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""profileDropdown"">
                            <a class=""dropdown-item"">
                                <i class=""mdi mdi-settings text-primary""></i>
                                Settings
                            </a>
                            <a class=""dropdown-item"">
                                <i class=""mdi mdi-logout text-primary""></i>
                                Logout
                            </a>
                        </div>
                    </li>
                </ul>
                <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
                    <span class=""mdi mdi-menu""></span>
                </button>
            </div>
        </nav>
        <!-- partial -->
        <div class=""container-fluid page-body-wrapper"">
            <!-- partial:partials/_sideb");
                WriteLiteral("ar.html -->\n            <nav class=\"sidebar sidebar-offcanvas\" id=\"sidebar\">\n                <ul class=\"nav\">\n                    <li class=\"nav-item\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1522d15ed2e37bf46e90112752e9abbdce4e255919190", async() => {
                    WriteLiteral("\n                            <i class=\"mdi mdi-home menu-icon\"></i>\n                            <span class=\"menu-title\">Dashboard</span>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#ui-basic"" aria-expanded=""false"" aria-controls=""ui-basic"">
                            <i class=""mdi mdi-circle-outline menu-icon""></i>
                            <span class=""menu-title"">UI Elements</span>
                            <i class=""menu-arrow""></i>
                        </a>
                        <div class=""collapse"" id=""ui-basic"">
                            <ul class=""nav flex-column sub-menu"">
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/ui-features/buttons.html"">Buttons</a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/ui-features/typography.html"">Typography</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1522d15ed2e37bf46e90112752e9abbdce4e255922102", async() => {
                    WriteLiteral("\n                            <i class=\"mdi mdi-view-headline menu-icon\"></i>\n                            <span class=\"menu-title\">Categories</span>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </li>\n                    <li class=\"nav-item\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1522d15ed2e37bf46e90112752e9abbdce4e255924098", async() => {
                    WriteLiteral("\n                            <i class=\"mdi mdi-chart-pie menu-icon\"></i>\n                            <span class=\"menu-title\">Sliders</span>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </li>\n                    <li class=\"nav-item\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1522d15ed2e37bf46e90112752e9abbdce4e255926087", async() => {
                    WriteLiteral("\n                            <i class=\"mdi mdi-grid-large menu-icon\"></i>\n                            <span class=\"menu-title\">Users</span>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/icons/mdi.html"">
                            <i class=""mdi mdi-emoticon menu-icon""></i>
                            <span class=""menu-title"">Icons</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#auth"" aria-expanded=""false"" aria-controls=""auth"">
                            <i class=""mdi mdi-account menu-icon""></i>
                            <span class=""menu-title"">AllPages</span>
                            <i class=""menu-arrow""></i>
                        </a>
                        <div class=""collapse"" id=""auth"">
                            <ul class=""nav flex-column sub-menu"">
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/login.html""> Login </a></li>
                                <li class=""nav-item""");
                WriteLiteral(@"> <a class=""nav-link"" href=""pages/samples/login-2.html""> Login 2 </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/register.html""> Register </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/register-2.html""> Register 2 </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/lock-screen.html""> Lockscreen </a></li>
                            </ul>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""documentation/documentation.html"">
                            <i class=""mdi mdi-file-document-box-outline menu-icon""></i>
                            <span class=""menu-title"">Documentation</span>
                        </a>
                    </li>
                </ul>
            </nav>
                    ");
#nullable restore
#line 257 "C:\Users\User\source\repos\BizLand\BizLand\Areas\AdminPanel\Views\Shared\_AdminLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <footer class=""footer"">
                    <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
                        <span class=""text-muted text-center text-sm-left d-block d-sm-inline-block"">
                            Copyright ?? <a href=""https://www.bootstrapdash.com/"" target=""_blank"">bootstrapdash.com </a>2021
                        </span>
                        <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center"">
                            Only the best <a href=""https://www.bootstrapdash.com/"" target=""_blank""> Bootstrap dashboard </a> templates
                        </span>
                    </div>
                </footer>
                <!-- partial -->
            </div>
            <!-- main-panel ends -->
        </div>
        <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src=""/admin/vendors/base/vendor.bundle.base.js""></script>
    <!-- endinject -->
    <!-- P");
                WriteLiteral(@"lugin js for this page-->
    <script src=""/admin/vendors/chart.js/Chart.min.js""></script>
    <script src=""vendors/datatables.net/jquery.dataTables.js""></script>
    <script src=""vendors/datatables.net-bs4/dataTables.bootstrap4.js""></script>
    <!-- End plugin js for this page-->
    <!-- inject:js -->
    <script src=""/admin/js/off-canvas.js""></script>
    <script src=""/admin/js/hoverable-collapse.js""></script>
    <script src=""/admin/js/template.js""></script>
    <!-- endinject -->
    <!-- Custom js for this page-->
    <script src=""/admin/js/dashboard.js""></script>
    <script src=""/admin/js/data-table.js""></script>
    <script src=""/admin/js/jquery.dataTables.js""></script>
    <script src=""/admin/js/dataTables.bootstrap4.js""></script>
    <!-- End custom js for this page-->

    <script src=""/js/jquery.cookie.js"" type=""text/javascript""></script>

    ");
#nullable restore
#line 297 "C:\Users\User\source\repos\BizLand\BizLand\Areas\AdminPanel\Views\Shared\_AdminLayout.cshtml"
Write(RenderSection("Script", false));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
