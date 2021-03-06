#pragma checksum "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f7b91f5a4db802b97f053f46232406a7d2a289c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7b91f5a4db802b97f053f46232406a7d2a289c", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Home Page";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>


<div class=""text-center"">
    <p class=""display-3"">Seja Bem Vindo(a) ao Dashboard ECCE 5.0 by Escolha Virtual Developer</p>
    <p class=""display-3"">Soluções em tecnologia para sua empresa</p>
</div>

<div class=""col-md-6"">
<p><h4>Tamanho</h4></p>
<div id=""Column""></div>
</div>

<div class=""col-md-6"">
    <p><h4>Gráfico de V</h4></p>
    <div id=""Bar""></div>
</div>

<div class=""col-md-6"">
    <p><h4>Gráfico de Vendas por Gênero</h4></p>
    <div id=""Line""></div>
</div>

<div class=""col-md-6"">
    <p><h4>Gráfico de Vendas por Gênero</h4></p>
    <div id=""Pie""></div>
</div>

    <script type=""text/javascript"">
        google.charts.load('current', { packages: ['corechart'] })
        google.charts.setOnLoadCallback(drawChart)

        function drawChart() {
            const container = document.querySelector('#Column')
            const data = new google.visualization.arrayToDataTable([
");
            WriteLiteral(@"                ['Tamanho', 'Quantidade'],
                ['Goku', 10000],
                ['Vegeta', 9000],
                ['Gohan', 8000],
                ['Freeza', 5000],
                ['Piccolo', 2000]
            ])
            const options = {
                title: 'Tamanho',
                height: 400,
                width: 400
            }

            const chart = new google.visualization.ColumnChart(container)
            // const chart = new google.visualization.BarChart(container)
            // const chart = new google.visualization.LineChart(container)
            //const chart = new google.visualization.PieChart(container)
            chart.draw(data, options)
        }
    </script>

    <script type=""text/javascript"">
        google.charts.load('current', { packages: ['corechart'] })
        google.charts.setOnLoadCallback(drawChart)

        function drawChart() {
            const container = document.querySelector('#Bar')
            const data = new g");
            WriteLiteral(@"oogle.visualization.arrayToDataTable([
                ['Categoria', 'Ki', { role: 'style' }],
                ['Goku', 10000, 'silver'],
                ['Vegeta', 9000, 'gold'],
                ['Gohan', 8000, 'red'],
                ['Freeza', 5000, 'blue'],
                ['Piccolo', 2000, 'green']
            ])
            const options = {
                title: 'Dragon Ball Z - Characters Ki',
                height: 400,
                width: 400
            }

            //const chart = new google.visualization.ColumnChart(container)
            const chart = new google.visualization.BarChart(container)
            // const chart = new google.visualization.LineChart(container)
            //const chart = new google.visualization.PieChart(container)
            chart.draw(data, options)
        }
    </script>

    <script type=""text/javascript"">
        google.charts.load('current', { packages: ['corechart'] })
        google.charts.setOnLoadCallback(drawChart)

        ");
            WriteLiteral(@"function drawChart() {
            const container = document.querySelector('#Line')
            const data = new google.visualization.arrayToDataTable([
                ['Character', 'Ki'],
                ['Goku', 10000],
                ['Vegeta', 9000],
                ['Gohan', 8000],
                ['Freeza', 5000],
                ['Piccolo', 2000]
            ])
            const options = {
                title: 'Dragon Ball Z - Characters Ki',
                height: 400,
                width: 400
            }

            //const chart = new google.visualization.ColumnChart(container)
            //const chart = new google.visualization.BarChart(container)
            const chart = new google.visualization.LineChart(container)
            //const chart = new google.visualization.PieChart(container)
            chart.draw(data, options)
        }
    </script>

    <script type=""text/javascript"">
        google.charts.load('current', { packages: ['corechart'] })
       ");
            WriteLiteral(@" google.charts.setOnLoadCallback(drawChart)

        function drawChart() {
            const container = document.querySelector('#Pie')
            const data = new google.visualization.arrayToDataTable([
                ['Character', 'Ki'],
                ['Goku', 10000],
                ['Vegeta', 9000],
                ['Gohan', 8000],
                ['Freeza', 5000],
                ['Piccolo', 2000]
            ])
            const options = {
                title: 'Dragon Ball Z - Characters Ki',
                height: 400,
                width: 400
            }

            //const chart = new google.visualization.ColumnChart(container)
            // const chart = new google.visualization.BarChart(container)
            // const chart = new google.visualization.LineChart(container)
            const chart = new google.visualization.PieChart(container)
            chart.draw(data, options)
        }
    </script>



");
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
