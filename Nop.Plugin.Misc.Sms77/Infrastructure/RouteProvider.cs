﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Misc.Sms77.Infrastructure {
    /// <summary>
    /// Represents plugin route provider
    /// </summary>
    public class RouteProvider : IRouteProvider {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route Builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder) {
            endpointRouteBuilder.MapControllerRoute(
                "Plugin.Misc.Sms77.BulkSms",
                "Admin/Plugins/Sms77/BulkSms",
                new {action = "Sms", area = AreaNames.Admin, controller = "Bulk"});
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 0;
    }
}