// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Tarea_7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Tarea_7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Tarea_7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/VMarcas")]
    public partial class VMarcas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
      
    private List<IGrouping<int?, Pacientes>> vacunas = null;

    Vacunas vacuna1 = new Vacunas();
    
      



        protected override void OnInitialized(){
            vacunadosrdContext nc = new vacunadosrdContext();
            vacunas = nc.Pacientes.AsEnumerable().GroupBy(x => x.VacunaId).ToList();
           
        }

        List<Vacunas> GetVacunas(int? id){
    
    vacunadosrdContext context = new vacunadosrdContext();

    var vacunas = context.Vacunas.Where(x => x.Id == id).ToList();

    return vacunas;
    }
    List<Vacunas> GetVacunas2(){
    
    vacunadosrdContext context = new vacunadosrdContext();

    var vacunas = context.Vacunas.ToList();

    return vacunas;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
