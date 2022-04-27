using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy.Standard;

using R5T.Costobocia.Default;


namespace R5T.Costobocia.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddOrganizationDirectoryNameProvider(this IServiceCollection services)
        {
            R5T.Costobocia.Default.IServiceCollectionExtensions.AddOrganizationDirectoryNameProvider(services);

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryNameProvider"/> service.
        /// </summary>
        public static ServiceAction<IOrganizationDirectoryNameProvider> AddOrganizationDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationDirectoryNameProvider>(() => services.AddOrganizationDirectoryNameProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationsStringlyTypedPathOperator"/> service.
        /// </summary>
        public static IServiceCollection AddOrganizationsStringlyTypedPathOperator(this IServiceCollection services)
        {
            services.AddOrganizationsStringlyTypedPathOperator_Old(
                services.AddStringlyTypedPathOperatorAction());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationsStringlyTypedPathOperator"/> service.
        /// </summary>
        public static IServiceAction<IOrganizationsStringlyTypedPathOperator> AddOrganizationsStringlyTypedPathOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationsStringlyTypedPathOperator>(() => services.AddOrganizationsStringlyTypedPathOperator());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationStringlyTypedPathOperator"/> service.
        /// </summary>
        public static IServiceCollection AddOrganizationStringlyTypedPathOperator(this IServiceCollection services)
        {
            R5T.Costobocia.Default.IServiceCollectionExtensions.AddOrganizationStringlyTypedPathOperator_Old(services,
                services.AddOrganizationDirectoryNameProviderAction(),
                services.AddOrganizationsStringlyTypedPathOperatorAction(),
                services.AddStringlyTypedPathOperatorAction());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationStringlyTypedPathOperator"/> service.
        /// </summary>
        public static ServiceAction<IOrganizationStringlyTypedPathOperator> AddOrganizationStringlyTypedPathOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationStringlyTypedPathOperator>(() => services.AddOrganizationStringlyTypedPathOperator());
            return serviceAction;
        }
    }
}
