#pragma checksum "E:\Working\Nguyen\EasyWeb\EasyWeb\EasyWeb.Web\Areas\Administrator\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0f071c257df76315203d95308ae5b0622493d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Category/Index.cshtml")]
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
#line 5 "E:\Working\Nguyen\EasyWeb\EasyWeb\EasyWeb.Web\Areas\Administrator\Views\Category\Index.cshtml"
using EasyWeb.Web.Areas.Administrator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0f071c257df76315203d95308ae5b0622493d04", @"/Areas/Administrator/Views/Category/Index.cshtml")]
    public class Areas_Administrator_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/tabutalor/css/bootstrap/tabulator_bootstrap4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/tabutalor/js/tabulator.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Working\Nguyen\EasyWeb\EasyWeb\EasyWeb.Web\Areas\Administrator\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral(" \r\n    <style>\r\n        .tabulator .tabulator-footer .tabulator-page.active {\r\n            border-color: #01a9ac !important;\r\n            background-color: #01a9ac !important;\r\n            color: #fff;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<div class=\"main-body\">\r\n    <div class=\"page-wrapper\">\r\n        <!-- Page-header start -->\r\n");
            WriteLiteral(@"        <!-- Page-header end -->
        <!-- Page-body start -->
        <div class=""page-body"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <!-- Zero config.table start -->
                    <div class=""card"">
                        
                        <div class=""card-block"">
                            <div class=""row"">
                                <div class=""col-sm-8"">
                                    <button class=""btn btn-primary btn-sm"">Thêm danh mục</button>
                                </div>
                                <div class=""col-sm-4 ml-auto"">                                    
                                    <div class=""input-group input-group-sm"">
                                        <span class=""input-group-addon"">
                                            <i class=""icofont icofont-search""></i>
                                        </span>
                                        <input type=""t");
            WriteLiteral(@"ext"" class=""form-control"" placeholder=""input-group-primary"">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-12"">
                                    <div id=""example-table""></div>
                                </div>
                            </div>

                            <div class=""dt-responsive table-responsive"">



");
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Page-body end -->\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0f071c257df76315203d95308ae5b0622493d046749", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0f071c257df76315203d95308ae5b0622493d047927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var tabledata = [
            { id: 1, name: ""Oli Bob"", progress: 12, gender: ""male"", rating: 1, col: ""red"", dob: ""19/02/1984"", car: 1, lucky_no: 5, activity: [1, 20, 5, 3, 10, 13, 17, 15, 9, 11, 10, 12, 14, 16, 13, 9, 7, 11, 10, 13] },
            { id: 2, name: ""Mary May"", progress: 1, gender: ""female"", rating: 2, col: ""blue"", dob: ""14/05/1982"", car: true, lucky_no: 10, activity: [10, 12, 14, 16, 13, 9, 7, 11, 10, 13, 1, 2, 5, 4, 1, 16, 4, 2, 1, 3] },
            { id: 3, name: ""Christine Lobowski"", progress: 42, gender: ""female"", rating: 0, col: ""green"", dob: ""22/05/1982"", car: ""true"", lucky_no: 12, activity: [1, 2, 5, 4, 1, 16, 4, 2, 1, 3, 3, 7, 9, 1, 4, 8, 2, 6, 4, 2] },
            { id: 4, name: ""Brendon Philips"", progress: 100, gender: ""male"", rating: 1, col: ""orange"", dob: ""01/08/1980"", lucky_no: 18, activity: [3, 7, 9, 1, 4, 8, 2, 6, 4, 2, 1, 3, 1, 3, 3, 1, 1, 3, 1, 3] },
            { id: 5, name: ""Margret Marmajuke"", progress: 16, gender: ""female"", rating: 5, col: ""yel");
                WriteLiteral(@"low"", dob: ""31/01/1999"", lucky_no: 33, activity: [1, 3, 1, 3, 3, 1, 1, 3, 1, 3, 20, 17, 15, 11, 16, 9, 12, 14, 20, 12] },
            { id: 6, name: ""Frank Harbours"", progress: 38, gender: ""male"", rating: 4, col: ""red"", dob: ""12/05/1966"", car: 1, lucky_no: 2, activity: [20, 17, 15, 11, 16, 9, 12, 14, 20, 12, 11, 7, 6, 12, 14, 13, 11, 10, 9, 6] },
            { id: 7, name: ""Jamie Newhart"", progress: 23, gender: ""male"", rating: 3, col: ""green"", dob: ""14/05/1985"", car: true, lucky_no: 63, activity: [11, 7, 6, 12, 14, 13, 11, 10, 9, 6, 4, 17, 11, 12, 0, 5, 12, 14, 18, 11] },
            { id: 8, name: ""Gemma Jane"", progress: 60, gender: ""female"", rating: 0, col: ""red"", dob: ""22/05/1982"", car: ""true"", lucky_no: 72, activity: [4, 17, 11, 12, 0, 5, 12, 14, 18, 11, 11, 15, 19, 20, 17, 16, 16, 5, 3, 2] },
            { id: 9, name: ""Emily Sykes"", progress: 42, gender: ""female"", rating: 1, col: ""maroon"", dob: ""11/11/1970"", lucky_no: 44, activity: [11, 15, 19, 20, 17, 16, 16, 5, 3, 2, 1, 2, 3, 4, 5, 4, 2, 5, 9, 8] ");
                WriteLiteral(@"},
            { id: 10, name: ""James Newman"", progress: 73, gender: ""male"", rating: 5, col: ""red"", dob: ""22/03/1998"", lucky_no: 9, activity: [1, 20, 5, 3, 10, 13, 17, 15, 9, 11, 1, 2, 3, 4, 5, 4, 2, 5, 9, 8] },
            { id: 11, name: ""Martin Barryman"", progress: 20, gender: ""male"", rating: 5, col: ""violet"", dob: ""04/04/2001"", activity: [1, 2, 3, 4, 5, 4, 11, 7, 6, 12, 14, 13, 11, 10, 9, 6, 2, 5, 9, 8] },
            { id: 12, name: ""Jenny Green"", progress: 56, gender: ""female"", rating: 4, col: ""indigo"", dob: ""12/11/1998"", car: true, activity: [11, 15, 19, 20, 17, 15, 11, 16, 9, 12, 14, 20, 12, 20, 17, 16, 16, 5, 3, 2] },
            { id: 13, name: ""Alan Francis"", progress: 90, gender: ""male"", rating: 3, col: ""blue"", dob: ""07/08/1972"", car: true, activity: [4, 17, 11, 7, 6, 12, 14, 13, 11, 10, 9, 6, 11, 12, 0, 5, 12, 14, 18, 11] },
            { id: 14, name: ""John Phillips"", progress: 80, gender: ""male"", rating: 1, col: ""green"", dob: ""24/09/1950"", car: true, activity: [11, 7, 6, 12, 14, 1, 20, 5, ");
                WriteLiteral(@"3, 10, 13, 17, 15, 9, 1, 13, 11, 10, 9, 6] },
            { id: 15, name: ""Ed White"", progress: 70, gender: ""male"", rating: 0, col: ""yellow"", dob: ""19/06/1976"", activity: [20, 17, 15, 11, 16, 9, 4, 17, 11, 12, 0, 5, 12, 14, 18, 11, 12, 14, 20, 12] },
            { id: 16, name: ""Paul Branderson"", progress: 60, gender: ""male"", rating: 5, col: ""orange"", dob: ""01/01/1982"", activity: [1, 3, 1, 3, 3, 1, 11, 15, 19, 20, 17, 16, 16, 5, 3, 2, 1, 3, 1, 3] },
            { id: 18, name: ""Emma Netwon"", progress: 40, gender: ""female"", rating: 4, col: ""brown"", dob: ""07/10/1963"", car: true, activity: [3, 7, 9, 1, 4, 8, 3, 7, 9, 1, 4, 8, 2, 6, 4, 2, 2, 6, 4, 2] },
            { id: 19, name: ""Hannah Farnsworth"", progress: 30, gender: ""female"", rating: 1, col: ""pink"", dob: ""11/02/1991"", activity: [1, 2, 5, 4, 1, 16, 10, 12, 14, 16, 13, 9, 7, 11, 10, 13, 4, 2, 1, 3] },
            { id: 20, name: ""Victoria Bath"", progress: 20, gender: ""female"", rating: 2, col: ""purple"", dob: ""22/03/1986"", activity: [10, 12, 14, 16, 13, 9");
                WriteLiteral(@", 7, 1, 2, 3, 4, 5, 4, 2, 5, 9, 8, 11, 10, 13] },
        ];
        var table = new Tabulator(""#example-table"", {
            data: tabledata,           //load row data from array
            layout: ""fitColumns"",      //fit columns to width of table
            responsiveLayout: ""hide"",  //hide columns that dont fit on the table
            tooltips: true,            //show tool tips on cells
            addRowPos: ""top"",          //when adding a new row, add it to the top of the table
            history: true,             //allow undo and redo actions on the table
            pagination: ""local"",       //paginate the data
            paginationSize: 7,         //allow 7 rows per page of data
            movableColumns: true,      //allow column order to be changed
            resizableRows: true,       //allow row order to be changed
            initialSort: [             //set the initial sort order of the data
                { column: ""name"", dir: ""asc"" },
            ],
            col");
                WriteLiteral(@"umns: [                 //define the table columns
                { title: ""Name"", field: ""name"", editor: ""input"" },
                { title: ""Task Progress"", field: ""progress"", align: ""left"", formatter: ""progress"", editor: true },
                { title: ""Gender"", field: ""gender"", width: 95, editor: ""select"", editorParams: { values: [""male"", ""female""] } },
                { title: ""Rating"", field: ""rating"", formatter: ""star"", align: ""center"", width: 100, editor: true },
                { title: ""Color"", field: ""col"", width: 130, editor: ""input"" },
                { title: ""Date Of Birth"", field: ""dob"", width: 130, sorter: ""date"", align: ""center"" },
                { title: ""Driver"", field: ""car"", width: 90, align: ""center"", formatter: ""tickCross"", sorter: ""boolean"", editor: true },
            ],
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591