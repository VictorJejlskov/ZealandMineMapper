#pragma checksum "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a03387a64733c920c4a4e394dd624f450d95a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudentAccommodation_RazorPages.Pages.Leasings.Pages_Leasings_GetLeasings), @"mvc.1.0.razor-page", @"/Pages/Leasings/GetLeasings.cshtml")]
namespace StudentAccommodation_RazorPages.Pages.Leasings
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a03387a64733c920c4a4e394dd624f450d95a76", @"/Pages/Leasings/GetLeasings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1f8fcac06c98b259af2fc28c0437299775ad14b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Leasings_GetLeasings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>List of Leasings</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a03387a64733c920c4a4e394dd624f450d95a763368", async() => {
                WriteLiteral("\r\n    <p>\r\n        \r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h4>List of Leasings</h4>
<table class=""table"">
    <thead>
    <tr>
        <th>Id</th>
        <th>Student No.</th>
        <th>Dorm No.</th>
        <th>Room No.</th>
        <th>Date Start</th>
        <th>Date End</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
     if (Model.Leasings != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
         foreach (var lease in Model.Leasings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
               Write(lease.Leasing_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
               Write(lease.Student_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
               Write(lease.Dormitory_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
               Write(lease.Room_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
               Write(lease.Date_From);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
               Write(lease.Date_To);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\victo\Desktop\ZealandMapper\Databases\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Leasings\GetLeasings.cshtml"
         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentAccommodation_RazorPages.Pages.Leasings.GetLeasingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentAccommodation_RazorPages.Pages.Leasings.GetLeasingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentAccommodation_RazorPages.Pages.Leasings.GetLeasingsModel>)PageContext?.ViewData;
        public StudentAccommodation_RazorPages.Pages.Leasings.GetLeasingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591