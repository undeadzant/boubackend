#pragma checksum "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033f1db486683c83292b3c516ae4e801832073e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Index), @"mvc.1.0.view", @"/Views/Vendors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Index.cshtml", typeof(AspNetCore.Views_Vendors_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033f1db486683c83292b3c516ae4e801832073e0", @"/Views/Vendors/Index.cshtml")]
    public class Views_Vendors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<boubackend.Data.Vendors>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(247, 46, false);
#line 16 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VendorName));

#line default
#line hidden
            EndContext();
            BeginContext(293, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(349, 45, false);
#line 19 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(394, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(450, 44, false);
#line 22 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(494, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(550, 43, false);
#line 25 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(593, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(649, 44, false);
#line 28 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNum));

#line default
#line hidden
            EndContext();
            BeginContext(693, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(749, 48, false);
#line 31 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(797, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(853, 46, false);
#line 34 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WebAddress));

#line default
#line hidden
            EndContext();
            BeginContext(899, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(955, 48, false);
#line 37 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FacebookPage));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1059, 49, false);
#line 40 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InstagramPage));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1164, 45, false);
#line 43 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VendorBio));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1265, 42, false);
#line 46 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsPaid));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1363, 46, false);
#line 49 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsApproved));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 55 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1527, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1576, 45, false);
#line 58 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VendorName));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1677, 44, false);
#line 61 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1777, 43, false);
#line 64 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1876, 42, false);
#line 67 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1974, 43, false);
#line 70 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNum));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2073, 47, false);
#line 73 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2176, 45, false);
#line 76 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WebAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2221, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2277, 47, false);
#line 79 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FacebookPage));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2380, 48, false);
#line 82 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InstagramPage));

#line default
#line hidden
            EndContext();
            BeginContext(2428, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2484, 44, false);
#line 85 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VendorBio));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2584, 41, false);
#line 88 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsPaid));

#line default
#line hidden
            EndContext();
            BeginContext(2625, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2681, 45, false);
#line 91 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsApproved));

#line default
#line hidden
            EndContext();
            BeginContext(2726, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2801, "\"", 2831, 1);
#line 94 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
WriteAttributeValue("", 2816, item.VendorsId, 2816, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2832, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2884, "\"", 2914, 1);
#line 95 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
WriteAttributeValue("", 2899, item.VendorsId, 2899, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2915, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2969, "\"", 2999, 1);
#line 96 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
WriteAttributeValue("", 2984, item.VendorsId, 2984, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3000, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 99 "C:\bouapp\boubackend\boubackend\Views\Vendors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3050, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<boubackend.Data.Vendors>> Html { get; private set; }
    }
}
#pragma warning restore 1591
