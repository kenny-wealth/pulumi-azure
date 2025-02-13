// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ContainerService
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Container Registry.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/container_registry.html.markdown.
        /// </summary>
        public static Task<GetRegistryResult> GetRegistry(GetRegistryArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRegistryResult>("azure:containerservice/getRegistry:getRegistry", args, options.WithVersion());
    }

    public sealed class GetRegistryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Container Registry.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where this Container Registry exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetRegistryArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetRegistryResult
    {
        /// <summary>
        /// Is the Administrator account enabled for this Container Registry.
        /// </summary>
        public readonly bool AdminEnabled;
        /// <summary>
        /// The Password associated with the Container Registry Admin account - if the admin account is enabled.
        /// </summary>
        public readonly string AdminPassword;
        /// <summary>
        /// The Username associated with the Container Registry Admin account - if the admin account is enabled.
        /// </summary>
        public readonly string AdminUsername;
        /// <summary>
        /// The Azure Region in which this Container Registry exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The URL that can be used to log into the container registry.
        /// </summary>
        public readonly string LoginServer;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The SKU of this Container Registry, such as `Basic`.
        /// </summary>
        public readonly string Sku;
        /// <summary>
        /// The ID of the Storage Account used for this Container Registry. This is only returned for `Classic` SKU's.
        /// </summary>
        public readonly string StorageAccountId;
        /// <summary>
        /// A map of tags assigned to the Container Registry.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetRegistryResult(
            bool adminEnabled,
            string adminPassword,
            string adminUsername,
            string location,
            string loginServer,
            string name,
            string resourceGroupName,
            string sku,
            string storageAccountId,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            AdminEnabled = adminEnabled;
            AdminPassword = adminPassword;
            AdminUsername = adminUsername;
            Location = location;
            LoginServer = loginServer;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Sku = sku;
            StorageAccountId = storageAccountId;
            Tags = tags;
            Id = id;
        }
    }
}
