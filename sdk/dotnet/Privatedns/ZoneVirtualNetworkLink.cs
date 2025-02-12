// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.PrivateDns
{
    /// <summary>
    /// Enables you to manage Private DNS zone Virtual Network Links. These Links enable DNS resolution and registration inside Azure Virtual Networks using Azure Private DNS.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/private_dns_zone_virtual_network_link.html.markdown.
    /// </summary>
    public partial class ZoneVirtualNetworkLink : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Private DNS Zone Virtual Network Link. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Private DNS zone (without a terminating dot). Changing this forces a new resource to be created.
        /// </summary>
        [Output("privateDnsZoneName")]
        public Output<string> PrivateDnsZoneName { get; private set; } = null!;

        /// <summary>
        /// Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled? Defaults to `false`.
        /// </summary>
        [Output("registrationEnabled")]
        public Output<bool?> RegistrationEnabled { get; private set; } = null!;

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// The Resource ID of the Virtual Network that should be linked to the DNS Zone. Changing this forces a new resource to be created.
        /// </summary>
        [Output("virtualNetworkId")]
        public Output<string> VirtualNetworkId { get; private set; } = null!;


        /// <summary>
        /// Create a ZoneVirtualNetworkLink resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ZoneVirtualNetworkLink(string name, ZoneVirtualNetworkLinkArgs args, CustomResourceOptions? options = null)
            : base("azure:privatedns/zoneVirtualNetworkLink:ZoneVirtualNetworkLink", name, args, MakeResourceOptions(options, ""))
        {
        }

        private ZoneVirtualNetworkLink(string name, Input<string> id, ZoneVirtualNetworkLinkState? state = null, CustomResourceOptions? options = null)
            : base("azure:privatedns/zoneVirtualNetworkLink:ZoneVirtualNetworkLink", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ZoneVirtualNetworkLink resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ZoneVirtualNetworkLink Get(string name, Input<string> id, ZoneVirtualNetworkLinkState? state = null, CustomResourceOptions? options = null)
        {
            return new ZoneVirtualNetworkLink(name, id, state, options);
        }
    }

    public sealed class ZoneVirtualNetworkLinkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Private DNS Zone Virtual Network Link. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Private DNS zone (without a terminating dot). Changing this forces a new resource to be created.
        /// </summary>
        [Input("privateDnsZoneName", required: true)]
        public Input<string> PrivateDnsZoneName { get; set; } = null!;

        /// <summary>
        /// Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled? Defaults to `false`.
        /// </summary>
        [Input("registrationEnabled")]
        public Input<bool>? RegistrationEnabled { get; set; }

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The Resource ID of the Virtual Network that should be linked to the DNS Zone. Changing this forces a new resource to be created.
        /// </summary>
        [Input("virtualNetworkId", required: true)]
        public Input<string> VirtualNetworkId { get; set; } = null!;

        public ZoneVirtualNetworkLinkArgs()
        {
        }
    }

    public sealed class ZoneVirtualNetworkLinkState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Private DNS Zone Virtual Network Link. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Private DNS zone (without a terminating dot). Changing this forces a new resource to be created.
        /// </summary>
        [Input("privateDnsZoneName")]
        public Input<string>? PrivateDnsZoneName { get; set; }

        /// <summary>
        /// Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled? Defaults to `false`.
        /// </summary>
        [Input("registrationEnabled")]
        public Input<bool>? RegistrationEnabled { get; set; }

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The Resource ID of the Virtual Network that should be linked to the DNS Zone. Changing this forces a new resource to be created.
        /// </summary>
        [Input("virtualNetworkId")]
        public Input<string>? VirtualNetworkId { get; set; }

        public ZoneVirtualNetworkLinkState()
        {
        }
    }
}
