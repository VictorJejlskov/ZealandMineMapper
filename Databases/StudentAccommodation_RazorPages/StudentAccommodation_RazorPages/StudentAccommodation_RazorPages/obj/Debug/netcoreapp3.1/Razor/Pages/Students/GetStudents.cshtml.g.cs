#pragma checksum "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Students\GetStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e2bf80be365d56608d654d44edceb7373080db0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudentAccommodation_RazorPages.Pages.Students.Pages_Students_GetStudents), @"mvc.1.0.razor-page", @"/Pages/Students/GetStudents.cshtml")]
namespace StudentAccommodation_RazorPages.Pages.Students
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
#line 1 "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\_ViewImports.cshtml"
using StudentAccommodation_RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e2bf80be365d56608d654d44edceb7373080db0", @"/Pages/Students/GetStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1f8fcac06c98b259af2fc28c0437299775ad14b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_GetStudents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h1>List of Students</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e2bf80be365d56608d654d44edceb7373080db03322", async() => {
                WriteLiteral("\r\n    <p>\r\n\r\n    </p>\r\n");
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
            WriteLiteral("\r\n<h4>List of Students</h4>\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>Student no.</th>\r\n        <th>Name</th>\r\n        <th>Address</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Students\GetStudents.cshtml"
     if (Model.Students != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Students\GetStudents.cshtml"
         foreach (var stud in Model.Students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Students\GetStudents.cshtml"
               Write(stud.Student_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Students\GetStudents.cshtml"
               Write(stud.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Students\GetStudents.cshtml"
               Write(stud.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Students\GetStudents.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Victur\Desktop\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\StudentAccommodation_RazorPages\Pages\Students\GetStudents.cshtml"
         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentAccommodation_RazorPages.Pages.Students.GetStudentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentAccommodation_RazorPages.Pages.Students.GetStudentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentAccommodation_RazorPages.Pages.Students.GetStudentsModel>)PageContext?.ViewData;
        public StudentAccommodation_RazorPages.Pages.Students.GetStudentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
