using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.DataProtection;

namespace AspNetCoreCustomDashboardController {
    public class DefaultDashboardController : RestrictedDashboardController {
        public DefaultDashboardController(DashboardConfigurator configurator, IDataProtectionProvider dataProtectionProvider = null) : base(configurator, dataProtectionProvider) {
        }
    }
}