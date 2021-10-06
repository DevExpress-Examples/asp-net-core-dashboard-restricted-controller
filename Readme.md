<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/398332436/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1023420)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Dashboard for ASP.NET Core - How to create a custom dashboard controller

The example shows how to create a custom dashboard controller for the [Web Dashboard](https://docs.devexpress.com/Dashboard/115163/web-dashboard/aspnet-core-dashboard-control) in an ASP.NET Core application.

Inherit the [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.DashboardController) class to create a custom dashboard controller. Pass its name to the [EndpointRouteBuilderExtension.MapDashboardRoute](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.EndpointRouteBuilderExtension.MapDashboardRoute(System.Object-System.String-System.String)) / [RouteBuilderExtension.MapDashboardRoute](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.RouteBuilderExtension.MapDashboardRoute(Microsoft.AspNetCore.Routing.IRouteBuilder-System.String-System.String-System.String--)?p=netframework) methods when you configure routing and to the [DashboardBuilder.ControllerName](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.DashboardBuilder.ControllerName(System.String)?p=netframework) method when you configure a control on the page. 

In this example, the custom controller name is `DefaultDashboard`.

<!-- default file list -->
## Files to Look at

* [Startup.cs](./CS/AspNetCoreCustomDashboardController/Startup.cs#L89)
* [DefaultDashboardController.cs](./CS/AspNetCoreCustomDashboardController/Controllers/DefaultDashboardController.cs)
* [Index.cshtml](./CS/AspNetCoreCustomDashboardController/Pages/Index.cshtml#L5)
<!-- default file list end -->

## Documentation

- [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.DashboardController)

## More Examples

- [Dashboard for MVC - How to create a custom dashboard controller](https://github.com/DevExpress-Examples/dashboard-for-mvc-custom-dashboard-controller)
- [Dashboard for ASP.NET Core - How to implement authentication﻿](https://github.com/DevExpress-Examples/ASPNET-Core-Dashboard-Authentication)
- [Dashboard for ASP.NET Core - How to implement multi-tenant Dashboard architecture﻿](https://github.com/DevExpress-Examples/DashboardUserBasedAspNetCore)
- [Dashboard for ASP.NET Core - How to load different data based on the current user﻿](https://github.com/DevExpress-Examples/DashboardDifferentUserDataAspNetCore)
