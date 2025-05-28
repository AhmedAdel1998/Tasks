namespace ASPFirstProject.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open System.Diagnostics

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

open ASPFirstProject.Models

type HomeController (logger : ILogger<HomeController>) =
    inherit Controller()

     member this.Welcome () =
        this.View()

     member this.Appoinment () =
        this.View()

    [<ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)>]
    member this.Error () =
        let reqId = 
            if isNull Activity.Current then
                this.HttpContext.TraceIdentifier
            else
                Activity.Current.Id

        this.View({ RequestId = reqId })
