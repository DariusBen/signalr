#pragma checksum "C:\Users\maxje\source\SignalRUnlam\signalr\tpsignalr\Views\Chat\SalaChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d15bf112c916c872a006d357df7d61b16c3922bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_SalaChat), @"mvc.1.0.view", @"/Views/Chat/SalaChat.cshtml")]
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
#line 1 "C:\Users\maxje\source\SignalRUnlam\signalr\tpsignalr\Views\_ViewImports.cshtml"
using tpsignalr.aplicacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15bf112c916c872a006d357df7d61b16c3922bb", @"/Views/Chat/SalaChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95ab73d0e817166e5391e3e95c02d920b59f72d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Chat_SalaChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\maxje\source\SignalRUnlam\signalr\tpsignalr\Views\Chat\SalaChat.cshtml"
  
    Layout = "_LayoutChat";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-3\"></div>\r\n    <div class=\"col-6 ingreso\">\r\n        <div class=\"card card-bordered\">\r\n            <div class=\"card-header\">\r\n                <h4 class=\"card-title\"><strong>Sala: ");
#nullable restore
#line 12 "C:\Users\maxje\source\SignalRUnlam\signalr\tpsignalr\Views\Chat\SalaChat.cshtml"
                                                Write(Model.Salas[Model.SalaSeleccionada - 1].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong></h4>
            </div>

            <div class=""ps-container ps-theme-default ps-active-y"" id=""chat-content"" style=""overflow-y: scroll !important; height:400px !important;"">

                <div class=""media media-chat media-chat-reverse"">
                    <div id=""chats"" class=""media-body"">
                    </div>
                </div>

                <div class=""ps-scrollbar-x-rail"" style=""left: 0px; bottom: 0px;""><div class=""ps-scrollbar-x"" tabindex=""0"" style=""left: 0px; width: 0px;""></div></div><div class=""ps-scrollbar-y-rail"" style=""top: 0px; height: 0px; right: 2px;""><div class=""ps-scrollbar-y"" tabindex=""0"" style=""top: 0px; height: 2px;""></div></div>
            </div>

            <div class=""publisher bt-1 border-light"">
                <input id=""message"" class=""publisher-input"" type=""text"" placeholder=""Mensaje"">
                <button id=""btnSend"" class=""btn"">Enviar</button>
            </div>

        </div>
    </div>
    <div class=""col-3""></div>
</div>");
            WriteLiteral("\n<div class=\"row\">\r\n    <div class=\"col-3\"></div>\r\n    <div class=\"col-6 ingreso\">\r\n        <div id=\"noticias\" class=\"media-body\">\r\n        </div>\r\n    </div>\r\n    <div class=\"col-3\"></div>\r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15bf112c916c872a006d357df7d61b16c3922bb5467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n      var connection = new signalR.HubConnectionBuilder().withUrl(\"/chathub\").build();\r\n\r\n     connection.start().then(() =>\r\n     {\r\n            connection.invoke(\"AddToGroup\", \"");
#nullable restore
#line 51 "C:\Users\maxje\source\SignalRUnlam\signalr\tpsignalr\Views\Chat\SalaChat.cshtml"
                                        Write(Model.SalaSeleccionada);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 51 "C:\Users\maxje\source\SignalRUnlam\signalr\tpsignalr\Views\Chat\SalaChat.cshtml"
                                                                   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\")\r\n\r\n            }).catch((e) => console.error(e));\r\n\r\n            document.getElementById(\"btnSend\").addEventListener(\"click\", (event) => {\r\n\r\n            let room = \"");
#nullable restore
#line 57 "C:\Users\maxje\source\SignalRUnlam\signalr\tpsignalr\Views\Chat\SalaChat.cshtml"
                   Write(Model.SalaSeleccionada);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            let user = \"");
#nullable restore
#line 58 "C:\Users\maxje\source\SignalRUnlam\signalr\tpsignalr\Views\Chat\SalaChat.cshtml"
                   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
            let message = document.getElementById(""message"").value;

            connection.invoke(""SendMessage"", room, user, message).catch((err) => console.error(err.toString()));

            document.getElementById(""message"").value = """";
            document.getElementById(""message"").focus();

            event.preventDefault();

    })

    connection.on(""ReceiveMessage"", (user, message) => {

        var texto = document.createElement(""p"");
        var newContent = document.createTextNode(user + "":"" + message);
        texto.appendChild(newContent);

        document.getElementById(""chats"").appendChild(texto);

    })

    connection.on(""ReceiveNews"", (message) => {

        var texto = document.createElement(""p"");
        var newContent = document.createTextNode(message);
        texto.appendChild(newContent);

        document.getElementById(""noticias"").appendChild(texto);

    })

    connection.on(""ShowWho"", (message) => {

        var texto = document.createElem");
            WriteLiteral("ent(\"p\");\r\n        var newContent = document.createTextNode(message);\r\n        texto.appendChild(newContent);\r\n\r\n        document.getElementById(\"chats\").appendChild(texto);\r\n\r\n    })\r\n\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
