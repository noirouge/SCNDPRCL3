#pragma checksum "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\Pages\Mapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b062bf1e153888e394ce8e05947c66c50159b1d2"
// <auto-generated/>
#pragma warning disable 1591
namespace Segundo_Parcial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Segundo_Parcial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\_Imports.razor"
using Segundo_Parcial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\Pages\Mapa.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mapa")]
    public partial class Mapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container mt-3 text-center\"><h1>Mapa de Robos</h1>\r\n        <div class=\"form-group\"><div id=\"map\"></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\Tareas\5to Cuatrimestre\PROG 3\Xdxdxdxd\Segundo Parcial\Pages\Mapa.razor"
      

DBRobosContext context = new DBRobosContext();

    protected override async Task OnAfterRenderAsync(bool firstRender)
        {

           var datos = (
             from xa in context.Robos
             select new {
                 ID = Convert.ToString(xa.Id) ,
                 lat = xa.Lat,
                 lng = xa.Lgn
             }


           );




            if(firstRender){
          await JS.InvokeVoidAsync("showMapa", datos);
            }
        }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591