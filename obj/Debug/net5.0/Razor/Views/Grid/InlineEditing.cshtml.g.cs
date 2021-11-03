#pragma checksum "D:\repos\Test_AdminPanel\Views\Grid\InlineEditing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e46f29023ffe8b8ddeaed0baa3c1ae4b8f2d02e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grid_InlineEditing), @"mvc.1.0.view", @"/Views/Grid/InlineEditing.cshtml")]
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
#line 1 "D:\repos\Test_AdminPanel\Views\_ViewImports.cshtml"
using Test_AdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\Test_AdminPanel\Views\_ViewImports.cshtml"
using Test_AdminPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e46f29023ffe8b8ddeaed0baa3c1ae4b8f2d02e", @"/Views/Grid/InlineEditing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10c7711f376dd0ba32ea94d9a38a651d915dcb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Grid_InlineEditing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("ControlsSection", async() => {
                WriteLiteral("\r\n    <div class=\"col-lg-9 control-section\">\r\n        <ejs-grid id=\"Grid\" dataSource=\"ViewBag.dataSource\"");
                BeginWriteAttribute("toolbar", " toolbar=\"", 130, "\"", 209, 1);
#nullable restore
#line 3 "D:\repos\Test_AdminPanel\Views\Grid\InlineEditing.cshtml"
WriteAttributeValue("", 140, new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }, 140, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" allowPaging=""true"" actionBegin=""actionBegin"">
            <e-grid-editSettings allowAdding=""true"" allowDeleting=""true"" allowEditing=""true"" newRowPosition=""Top""></e-grid-editSettings>
            <e-grid-pagesettings pageCount=""5""></e-grid-pagesettings>
            <e-grid-columns>
                <e-grid-column field=""OrderID"" headerText=""Order ID"" isPrimaryKey=""true""");
                BeginWriteAttribute("validationRules", " validationRules=\"", 585, "\"", 639, 1);
#nullable restore
#line 7 "D:\repos\Test_AdminPanel\Views\Grid\InlineEditing.cshtml"
WriteAttributeValue("", 603, new { required=true, number=true}, 603, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"140\"></e-grid-column>\r\n                <e-grid-column field=\"CustomerID\" headerText=\"Customer Name\"");
                BeginWriteAttribute("validationRules", " validationRules=\"", 747, "\"", 788, 1);
#nullable restore
#line 8 "D:\repos\Test_AdminPanel\Views\Grid\InlineEditing.cshtml"
WriteAttributeValue("", 765, new { required=true}, 765, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"150\"></e-grid-column>\r\n                <e-grid-column field=\"Freight\" headerText=\"Freight\"");
                BeginWriteAttribute("validationRules", " validationRules=\"", 887, "\"", 928, 1);
#nullable restore
#line 9 "D:\repos\Test_AdminPanel\Views\Grid\InlineEditing.cshtml"
WriteAttributeValue("", 905, new { required=true}, 905, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" textAlign=\"Right\" editType=\"numericedit\" format=\"C2\" width=\"140\"></e-grid-column>\r\n                <e-grid-column field=\"OrderDate\" headerText=\"Order Date\" editType=\"datetimepickeredit\"");
                BeginWriteAttribute("customFormat", " customFormat=\"", 1115, "\"", 1183, 1);
#nullable restore
#line 10 "D:\repos\Test_AdminPanel\Views\Grid\InlineEditing.cshtml"
WriteAttributeValue("", 1130, new {type = "datetime", format = "M/d/y hh:mm a" }, 1130, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" width=""160""></e-grid-column>
                <e-grid-column field=""ShipCountry"" headerText=""Ship Country"" editType=""dropdownedit"" width=""150""></e-grid-column>
                <e-grid-column field=""Verified"" headerText=""Verified"" editType=""booleanedit"" displayAsCheckBox=""true"" type=""boolean"" width=""100""></e-grid-column>
            </e-grid-columns>
        </ejs-grid>
    </div>

    <div class=""col-lg-3 property-section"">
        <table id=""property"" title=""Properties"" style=""width: 100%"">
            <tr>
                <td style=""width: 100%"">
                    <div style=""padding-top: 7px"">Add New Row Position</div>
                </td>
                <td style=""width: 50%;padding-right: 10px"">
                    <div id='typeddl'>
                        <ejs-dropdownlist id=""newRowPosition""");
                BeginWriteAttribute("dataSource", " dataSource=\"", 2013, "\"", 2047, 1);
#nullable restore
#line 25 "D:\repos\Test_AdminPanel\Views\Grid\InlineEditing.cshtml"
WriteAttributeValue("", 2026, ViewBag.ddDataSource, 2026, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2048, "\"", 2064, 1);
#nullable restore
#line 25 "D:\repos\Test_AdminPanel\Views\Grid\InlineEditing.cshtml"
WriteAttributeValue("", 2056, "Top", 2056, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" change=""rowPositionChange"" popupHeight=""220px""></ejs-dropdownlist>
                    </div>
                </td>
            </tr>
        </table>
    </div>

    <script>

       function rowPositionChange(args) {
           var grid = document.getElementById(""Grid"").ej2_instances[0];
           grid.editSettings.newRowPosition = this.value;
       }

       function actionBegin(args) {
            var grid = document.getElementById(""Grid"").ej2_instances[0];
            if (args.requestType === 'save') {
                if (grid.pageSettings.currentPage !== 1 && grid.editSettings.newRowPosition === 'Top') {
                    args.index = (grid.pageSettings.currentPage * grid.pageSettings.pageSize) - grid.pageSettings.pageSize;
                } else if (grid.editSettings.newRowPosition === 'Bottom') {
                    args.index = (grid.pageSettings.currentPage * grid.pageSettings.pageSize) - 1;
                }
            }
       }

    </script>

    <style>
       ");
                WriteLiteral(" #typeddl {\r\n            min-width: 100px;\r\n        }\r\n    </style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
