#pragma checksum "C:\Users\Алсу\Desktop\Semestrovka_univer\univer\Pages\Chats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eab042ddb39eee95faa14dda9708d59956666954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(univer.Pages.Pages_Chats), @"mvc.1.0.razor-page", @"/Pages/Chats.cshtml")]
namespace univer.Pages
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
#line 1 "C:\Users\Алсу\Desktop\Semestrovka_univer\univer\Pages\_ViewImports.cshtml"
using univer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Алсу\Desktop\Semestrovka_univer\univer\Pages\Chats.cshtml"
using univer.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab042ddb39eee95faa14dda9708d59956666954", @"/Pages/Chats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd132f7fc96ddbd5bb3da29232a532ee0de5d00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Chats : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Алсу\Desktop\Semestrovka_univer\univer\Pages\Chats.cshtml"
  
    ViewData["Title"] = "Чаты";
    var perPage = "5";
    if (Request.Query.ContainsKey("perPage"))
    {
        perPage = Request.Query["perPage"];
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div style='margin-top: 90px;' class='container'>
        <div class='row '>
            <div class=""col-10 offset-1 list-group"">
                <button type=""button"" class=""list-group-item list-group-item-action"">
                    <!-- <div class=""d-flex justify-content-between align-items-center""> -->
                    <div class='container justify-content-center align-items-center'>
                        <div class='row align-items-center'>
                            <div class='col-3 '>
                                <h5 class=""mb-1 "">Alsu</h5>
                            </div>
                            <div class='col-5'>
                                <p class=""mb-1"">ANSWER!! MEE!! WHERE ARE YOu???</p>
                            </div>
                            <div class='col-2 d-flex justify-content-center '>
                                <small>2d ago</small>
                            </div>
                            <div class='col-1 offset-1 d-flex justify");
            WriteLiteral(@"-content-center'>
                                <span class=""badge badge-primary badge-pill"">200</span>
                            </div>
                        </div>
                    </div>
                    <!-- </div> -->
                </button>

                <button type=""button"" class=""list-group-item list-group-item-action"">
                    <!-- <div class=""d-flex justify-content-between align-items-center""> -->
                    <div class='container justify-content-center align-items-center'>
                        <div class='row align-items-center'>
                            <div class='col-3 '>
                                <h5 class=""mb-1 "">David</h5>
                            </div>
                            <div class='col-5'>
                                <p class=""mb-1""></p>
                            </div>
                            <div class='col-2 d-flex justify-content-center '>
                                <small>5s ago</small>
  ");
            WriteLiteral(@"                          </div>
                            <div class='col-1 offset-1 d-flex justify-content-center'>
                                <span class=""badge badge-primary badge-pill"">1</span>
                            </div>
                        </div>
                    </div>
                    <!-- </div> -->
                </button>
                <button type=""button"" class=""list-group-item list-group-item-action"">
                    <!-- <div class=""d-flex justify-content-between align-items-center""> -->
                    <div class='container justify-content-center align-items-center'>
                        <div class='row align-items-center'>
                            <div class='col-3 '>
                                <h5 class=""mb-1"">Andruha</h5>
                            </div>
                            <div class='col-5'>
                                <p class=""mb-1""></p>
                            </div>
                            <div clas");
            WriteLiteral(@"s='col-2 d-flex justify-content-center '>
                                <small>2h ago</small>
                            </div>
                            <div class='col-1 offset-1 d-flex justify-content-center'>
                                <span class=""badge badge-primary badge-pill"">4</span>
                            </div>
                        </div>
                    </div>
                    <!-- </div> -->
                </button>
            </div>
        </div>
        <div class=""uk-container uk-margin"">
            <div class=""uk-card uk-card-default uk-card-body"">
                <ul class=""uk-pagination"" uk-margin>
");
#nullable restore
#line 84 "C:\Users\Алсу\Desktop\Semestrovka_univer\univer\Pages\Chats.cshtml"
                     for (var i = 0; i < Model.UserResponse.Total / int.Parse(perPage); i += 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 4134, "\"", 4141, 0);
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 86 "C:\Users\Алсу\Desktop\Semestrovka_univer\univer\Pages\Chats.cshtml"
                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 87 "C:\Users\Алсу\Desktop\Semestrovka_univer\univer\Pages\Chats.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<univer.Pages.ChatsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<univer.Pages.ChatsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<univer.Pages.ChatsModel>)PageContext?.ViewData;
        public univer.Pages.ChatsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
