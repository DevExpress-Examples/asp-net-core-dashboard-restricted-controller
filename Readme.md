<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/398332436/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1023420)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Dashboard for ASP.NET Core - How to Create a Restricted Dashboard Controller

You can do one of the following to prevent inadvertent or unauthorized dashboard modifications and protect dashboards stored on a server:

- Handle the [DashboardConfigurator.VerifyClientTrustLevel](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.VerifyClientTrustLevel) event and set [e.ClientTrustLevel](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.VerifyClientTrustLevelEventArgs.ClientTrustLevel) to `Restricted` mode.
- Derive a custom dashboard controller from [RestrictedDashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.RestrictedDashboardController) instead of [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.DashboardController).

The example shows how to create a restricted dashboard controller for the [Web Dashboard](https://docs.devexpress.com/Dashboard/115163/web-dashboard/aspnet-core-dashboard-control) in an ASP.NET Core application.

## Example Description

Inherit the [RestrictedDashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.RestrictedDashboardController) class to create a custom dashboard controller. Add its name (without a `Controller` prefix) to the following places:
- The [EndpointRouteBuilderExtension.MapDashboardRoute](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.EndpointRouteBuilderExtension.MapDashboardRoute.overloads) method when you configure routing;
- The [DashboardBuilder.ControllerName](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.DashboardBuilder.ControllerName(System.String)) method when you configure a control on the page. 

In this example, the custom controller name is `DefaultDashboard`.

## Files to Review

* [Startup.cs](./CS/AspNetCoreCustomDashboardController/Startup.cs#L89)
* [DefaultDashboardController.cs](./CS/AspNetCoreCustomDashboardController/Controllers/DefaultDashboardController.cs)
* [Index.cshtml](./CS/AspNetCoreCustomDashboardController/Pages/Index.cshtml#L5)

## Documentation

- [RestrictedDashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardAspNetCore.RestrictedDashboardController)
- [Security Considerations in Web](https://docs.devexpress.com/Dashboard/118651/designer-and-viewer-applications/web-dashboard/security-considerations)

## More Examples

- [Dashboard for MVC - How to create a restricted dashboard controller](https://github.com/DevExpress-Examples/asp-net-mvc-dashboard-restricted-controller)
- [Dashboard for ASP.NET Core - How to implement authentication﻿](https://github.com/DevExpress-Examples/ASPNET-Core-Dashboard-Authentication)
- [Dashboard for ASP.NET Core - How to implement multi-tenant Dashboard architecture﻿](https://github.com/DevExpress-Examples/DashboardUserBasedAspNetCore)
- [Dashboard for ASP.NET Core - How to load different data based on the current user﻿](https://github.com/DevExpress-Examples/DashboardDifferentUserDataAspNetCore)
