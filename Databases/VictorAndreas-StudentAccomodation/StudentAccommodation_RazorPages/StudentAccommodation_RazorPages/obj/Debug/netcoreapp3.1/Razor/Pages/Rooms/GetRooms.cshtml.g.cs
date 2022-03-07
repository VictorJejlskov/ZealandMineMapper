#pragma checksum "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0649e9ce562e41b232e31c3d71831d3edd4f9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudentAccommodation_RazorPages.Pages.Rooms.Pages_Rooms_GetRooms), @"mvc.1.0.razor-page", @"/Pages/Rooms/GetRooms.cshtml")]
namespace StudentAccommodation_RazorPages.Pages.Rooms
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
#line 1 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\_ViewImports.cshtml"
using StudentAccommodation_RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0649e9ce562e41b232e31c3d71831d3edd4f9c", @"/Pages/Rooms/GetRooms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1f8fcac06c98b259af2fc28c0437299775ad14b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rooms_GetRooms : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Leasings/GetStudentLeasings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LeasingsAndStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>List of Rooms</h1>\r\n<h3>Amount of Rooms ");
#nullable restore
#line 6 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
               Write(Model.Rooms.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<h4>List of Rooms</h4>
<table class=""table table-bordered table-striped"">
    <thead  class=""bg-primary"">
        <tr>
            <th>Room No.</th>
            <th>Dorm no.</th>
            <th>Type</th>
            <th>Price</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
         if (Model.Rooms != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
             foreach (var room in Model.Rooms)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
                   Write(room.Room_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
                   Write(room.Dormitory_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
                   Write(room.Types);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
                   Write(room.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab0649e9ce562e41b232e31c3d71831d3edd4f9c6967", async() => {
                WriteLiteral("Leases for this roon");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-did", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
                                                                                                             WriteLiteral(room.Dormitory_No);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["did"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-did", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["did"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
                                                                                                                                                WriteLiteral(room.Room_No);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-rid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Rooms\GetRooms.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentAccommodation_RazorPages.Pages.Rooms.GetRoomsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentAccommodation_RazorPages.Pages.Rooms.GetRoomsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentAccommodation_RazorPages.Pages.Rooms.GetRoomsModel>)PageContext?.ViewData;
        public StudentAccommodation_RazorPages.Pages.Rooms.GetRoomsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591