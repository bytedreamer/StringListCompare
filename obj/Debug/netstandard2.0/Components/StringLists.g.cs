#pragma checksum "/Users/bytedreamer/Projects/StringListCompare/Components/StringLists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2fb18519e80710fa20d8686deaddd3cc7daa876"
// <auto-generated/>
#pragma warning disable 1591
namespace StringListCompare.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using StringListCompare;
    using StringListCompare.Shared;
    public class StringLists : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "container");
            builder.AddContent(2, "\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "row");
            builder.AddContent(5, "\n        ");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "col-sm align-content-center text-center");
            builder.AddContent(8, "\n            ");
            builder.OpenElement(9, "textarea");
            builder.AddAttribute(10, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(StringList1));
            builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => StringList1 = __value, StringList1));
            builder.CloseElement();
            builder.AddContent(12, "\n            ");
            builder.AddMarkupContent(13, "<h5>1st list of strings separated by EOL</h5>\n        ");
            builder.CloseElement();
            builder.AddContent(14, "\n        ");
            builder.OpenElement(15, "div");
            builder.AddAttribute(16, "class", "col-sm align-content-center text-center");
            builder.AddContent(17, "\n            ");
            builder.OpenElement(18, "textarea");
            builder.AddAttribute(19, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(StringList2));
            builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => StringList2 = __value, StringList2));
            builder.CloseElement();
            builder.AddContent(21, "\n            ");
            builder.AddMarkupContent(22, "<h5>2nd list of strings separated by EOL</h5>\n        ");
            builder.CloseElement();
            builder.AddContent(23, "\n    ");
            builder.CloseElement();
            builder.AddContent(24, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 14 "/Users/bytedreamer/Projects/StringListCompare/Components/StringLists.cshtml"
            
    [Parameter]
    private string StringList1 { get; set; }
    
    [Parameter]
    private Action<string> StringList1Changed { get; set; }

    [Parameter]
    private string StringList2 { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
