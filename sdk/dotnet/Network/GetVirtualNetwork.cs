// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Virtual Network.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/virtual_network.html.markdown.
        /// </summary>
        public static Task<GetVirtualNetworkResult> GetVirtualNetwork(GetVirtualNetworkArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkResult>("azure:network/getVirtualNetwork:getVirtualNetwork", args, options.WithVersion());
    }

    public sealed class GetVirtualNetworkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Virtual Network.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the resource group the Virtual Network is located in.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetVirtualNetworkArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetVirtualNetworkResult
    {
        /// <summary>
        /// The list of address spaces used by the virtual network.
        /// </summary>
        public readonly ImmutableArray<string> AddressSpaces;
        public readonly ImmutableArray<string> AddressSpacesCollection;
        /// <summary>
        /// The list of DNS servers used by the virtual network.
        /// </summary>
        public readonly ImmutableArray<string> DnsServers;
        /// <summary>
        /// Location of the virtual network.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The list of name of the subnets that are attached to this virtual network.
        /// </summary>
        public readonly ImmutableArray<string> Subnets;
        /// <summary>
        /// A mapping of name - virtual network id of the virtual network peerings.
        /// </summary>
        public readonly ImmutableDictionary<string, string> VnetPeerings;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetVirtualNetworkResult(
            ImmutableArray<string> addressSpaces,
            ImmutableArray<string> addressSpacesCollection,
            ImmutableArray<string> dnsServers,
            string location,
            string name,
            string resourceGroupName,
            ImmutableArray<string> subnets,
            ImmutableDictionary<string, string> vnetPeerings,
            string id)
        {
            AddressSpaces = addressSpaces;
            AddressSpacesCollection = addressSpacesCollection;
            DnsServers = dnsServers;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Subnets = subnets;
            VnetPeerings = vnetPeerings;
            Id = id;
        }
    }
}
