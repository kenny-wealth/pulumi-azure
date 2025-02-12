// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ContainerService
{
    /// <summary>
    /// Manages an Azure Container Registry.
    /// 
    /// &gt; **Note:** All arguments including the access key will be stored in the raw state as plain-text.
    /// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/container_registry.html.markdown.
    /// </summary>
    public partial class Registry : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies whether the admin user is enabled. Defaults to `false`.
        /// </summary>
        [Output("adminEnabled")]
        public Output<bool?> AdminEnabled { get; private set; } = null!;

        /// <summary>
        /// The Password associated with the Container Registry Admin account - if the admin account is enabled.
        /// </summary>
        [Output("adminPassword")]
        public Output<string> AdminPassword { get; private set; } = null!;

        /// <summary>
        /// The Username associated with the Container Registry Admin account - if the admin account is enabled.
        /// </summary>
        [Output("adminUsername")]
        public Output<string> AdminUsername { get; private set; } = null!;

        /// <summary>
        /// A list of Azure locations where the container registry should be geo-replicated.
        /// </summary>
        [Output("georeplicationLocations")]
        public Output<ImmutableArray<string>> GeoreplicationLocations { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The URL that can be used to log into the container registry.
        /// </summary>
        [Output("loginServer")]
        public Output<string> LoginServer { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A `network_rule_set` block as documented below.
        /// </summary>
        [Output("networkRuleSet")]
        public Output<Outputs.RegistryNetworkRuleSet> NetworkRuleSet { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The SKU name of the the container registry. Possible values are `Classic` (which was previously `Basic`), `Basic`, `Standard` and `Premium`.
        /// </summary>
        [Output("sku")]
        public Output<string?> Sku { get; private set; } = null!;

        [Output("storageAccount")]
        public Output<Outputs.RegistryStorageAccount?> StorageAccount { get; private set; } = null!;

        /// <summary>
        /// The ID of a Storage Account which must be located in the same Azure Region as the Container Registry.
        /// </summary>
        [Output("storageAccountId")]
        public Output<string?> StorageAccountId { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Registry resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Registry(string name, RegistryArgs args, CustomResourceOptions? options = null)
            : base("azure:containerservice/registry:Registry", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Registry(string name, Input<string> id, RegistryState? state = null, CustomResourceOptions? options = null)
            : base("azure:containerservice/registry:Registry", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Registry resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Registry Get(string name, Input<string> id, RegistryState? state = null, CustomResourceOptions? options = null)
        {
            return new Registry(name, id, state, options);
        }
    }

    public sealed class RegistryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether the admin user is enabled. Defaults to `false`.
        /// </summary>
        [Input("adminEnabled")]
        public Input<bool>? AdminEnabled { get; set; }

        [Input("georeplicationLocations")]
        private InputList<string>? _georeplicationLocations;

        /// <summary>
        /// A list of Azure locations where the container registry should be geo-replicated.
        /// </summary>
        public InputList<string> GeoreplicationLocations
        {
            get => _georeplicationLocations ?? (_georeplicationLocations = new InputList<string>());
            set => _georeplicationLocations = value;
        }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A `network_rule_set` block as documented below.
        /// </summary>
        [Input("networkRuleSet")]
        public Input<Inputs.RegistryNetworkRuleSetArgs>? NetworkRuleSet { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SKU name of the the container registry. Possible values are `Classic` (which was previously `Basic`), `Basic`, `Standard` and `Premium`.
        /// </summary>
        [Input("sku")]
        public Input<string>? Sku { get; set; }

        [Input("storageAccount")]
        public Input<Inputs.RegistryStorageAccountArgs>? StorageAccount { get; set; }

        /// <summary>
        /// The ID of a Storage Account which must be located in the same Azure Region as the Container Registry.
        /// </summary>
        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

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

        public RegistryArgs()
        {
        }
    }

    public sealed class RegistryState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether the admin user is enabled. Defaults to `false`.
        /// </summary>
        [Input("adminEnabled")]
        public Input<bool>? AdminEnabled { get; set; }

        /// <summary>
        /// The Password associated with the Container Registry Admin account - if the admin account is enabled.
        /// </summary>
        [Input("adminPassword")]
        public Input<string>? AdminPassword { get; set; }

        /// <summary>
        /// The Username associated with the Container Registry Admin account - if the admin account is enabled.
        /// </summary>
        [Input("adminUsername")]
        public Input<string>? AdminUsername { get; set; }

        [Input("georeplicationLocations")]
        private InputList<string>? _georeplicationLocations;

        /// <summary>
        /// A list of Azure locations where the container registry should be geo-replicated.
        /// </summary>
        public InputList<string> GeoreplicationLocations
        {
            get => _georeplicationLocations ?? (_georeplicationLocations = new InputList<string>());
            set => _georeplicationLocations = value;
        }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The URL that can be used to log into the container registry.
        /// </summary>
        [Input("loginServer")]
        public Input<string>? LoginServer { get; set; }

        /// <summary>
        /// Specifies the name of the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A `network_rule_set` block as documented below.
        /// </summary>
        [Input("networkRuleSet")]
        public Input<Inputs.RegistryNetworkRuleSetGetArgs>? NetworkRuleSet { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The SKU name of the the container registry. Possible values are `Classic` (which was previously `Basic`), `Basic`, `Standard` and `Premium`.
        /// </summary>
        [Input("sku")]
        public Input<string>? Sku { get; set; }

        [Input("storageAccount")]
        public Input<Inputs.RegistryStorageAccountGetArgs>? StorageAccount { get; set; }

        /// <summary>
        /// The ID of a Storage Account which must be located in the same Azure Region as the Container Registry.
        /// </summary>
        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

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

        public RegistryState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class RegistryNetworkRuleSetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The behaviour for requests matching no rules. Either `Allow` or `Deny`. Defaults to `Allow`
        /// </summary>
        [Input("defaultAction")]
        public Input<string>? DefaultAction { get; set; }

        [Input("ipRules")]
        private InputList<RegistryNetworkRuleSetIpRulesArgs>? _ipRules;

        /// <summary>
        /// One or more `ip_rule` blocks as defined below.
        /// </summary>
        public InputList<RegistryNetworkRuleSetIpRulesArgs> IpRules
        {
            get => _ipRules ?? (_ipRules = new InputList<RegistryNetworkRuleSetIpRulesArgs>());
            set => _ipRules = value;
        }

        [Input("virtualNetworks")]
        private InputList<RegistryNetworkRuleSetVirtualNetworksArgs>? _virtualNetworks;

        /// <summary>
        /// One or more `virtual_network` blocks as defined below.
        /// </summary>
        public InputList<RegistryNetworkRuleSetVirtualNetworksArgs> VirtualNetworks
        {
            get => _virtualNetworks ?? (_virtualNetworks = new InputList<RegistryNetworkRuleSetVirtualNetworksArgs>());
            set => _virtualNetworks = value;
        }

        public RegistryNetworkRuleSetArgs()
        {
        }
    }

    public sealed class RegistryNetworkRuleSetGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The behaviour for requests matching no rules. Either `Allow` or `Deny`. Defaults to `Allow`
        /// </summary>
        [Input("defaultAction")]
        public Input<string>? DefaultAction { get; set; }

        [Input("ipRules")]
        private InputList<RegistryNetworkRuleSetIpRulesGetArgs>? _ipRules;

        /// <summary>
        /// One or more `ip_rule` blocks as defined below.
        /// </summary>
        public InputList<RegistryNetworkRuleSetIpRulesGetArgs> IpRules
        {
            get => _ipRules ?? (_ipRules = new InputList<RegistryNetworkRuleSetIpRulesGetArgs>());
            set => _ipRules = value;
        }

        [Input("virtualNetworks")]
        private InputList<RegistryNetworkRuleSetVirtualNetworksGetArgs>? _virtualNetworks;

        /// <summary>
        /// One or more `virtual_network` blocks as defined below.
        /// </summary>
        public InputList<RegistryNetworkRuleSetVirtualNetworksGetArgs> VirtualNetworks
        {
            get => _virtualNetworks ?? (_virtualNetworks = new InputList<RegistryNetworkRuleSetVirtualNetworksGetArgs>());
            set => _virtualNetworks = value;
        }

        public RegistryNetworkRuleSetGetArgs()
        {
        }
    }

    public sealed class RegistryNetworkRuleSetIpRulesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The behaviour for requests matching this rule. At this time the only supported value is `Allow`
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// The CIDR block from which requests will match the rule.
        /// </summary>
        [Input("ipRange", required: true)]
        public Input<string> IpRange { get; set; } = null!;

        public RegistryNetworkRuleSetIpRulesArgs()
        {
        }
    }

    public sealed class RegistryNetworkRuleSetIpRulesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The behaviour for requests matching this rule. At this time the only supported value is `Allow`
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// The CIDR block from which requests will match the rule.
        /// </summary>
        [Input("ipRange", required: true)]
        public Input<string> IpRange { get; set; } = null!;

        public RegistryNetworkRuleSetIpRulesGetArgs()
        {
        }
    }

    public sealed class RegistryNetworkRuleSetVirtualNetworksArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The behaviour for requests matching this rule. At this time the only supported value is `Allow`
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// The subnet id from which requests will match the rule.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public RegistryNetworkRuleSetVirtualNetworksArgs()
        {
        }
    }

    public sealed class RegistryNetworkRuleSetVirtualNetworksGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The behaviour for requests matching this rule. At this time the only supported value is `Allow`
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// The subnet id from which requests will match the rule.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public RegistryNetworkRuleSetVirtualNetworksGetArgs()
        {
        }
    }

    public sealed class RegistryStorageAccountArgs : Pulumi.ResourceArgs
    {
        [Input("accessKey", required: true)]
        public Input<string> AccessKey { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public RegistryStorageAccountArgs()
        {
        }
    }

    public sealed class RegistryStorageAccountGetArgs : Pulumi.ResourceArgs
    {
        [Input("accessKey", required: true)]
        public Input<string> AccessKey { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public RegistryStorageAccountGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class RegistryNetworkRuleSet
    {
        /// <summary>
        /// The behaviour for requests matching no rules. Either `Allow` or `Deny`. Defaults to `Allow`
        /// </summary>
        public readonly string? DefaultAction;
        /// <summary>
        /// One or more `ip_rule` blocks as defined below.
        /// </summary>
        public readonly ImmutableArray<RegistryNetworkRuleSetIpRules> IpRules;
        /// <summary>
        /// One or more `virtual_network` blocks as defined below.
        /// </summary>
        public readonly ImmutableArray<RegistryNetworkRuleSetVirtualNetworks> VirtualNetworks;

        [OutputConstructor]
        private RegistryNetworkRuleSet(
            string? defaultAction,
            ImmutableArray<RegistryNetworkRuleSetIpRules> ipRules,
            ImmutableArray<RegistryNetworkRuleSetVirtualNetworks> virtualNetworks)
        {
            DefaultAction = defaultAction;
            IpRules = ipRules;
            VirtualNetworks = virtualNetworks;
        }
    }

    [OutputType]
    public sealed class RegistryNetworkRuleSetIpRules
    {
        /// <summary>
        /// The behaviour for requests matching this rule. At this time the only supported value is `Allow`
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// The CIDR block from which requests will match the rule.
        /// </summary>
        public readonly string IpRange;

        [OutputConstructor]
        private RegistryNetworkRuleSetIpRules(
            string action,
            string ipRange)
        {
            Action = action;
            IpRange = ipRange;
        }
    }

    [OutputType]
    public sealed class RegistryNetworkRuleSetVirtualNetworks
    {
        /// <summary>
        /// The behaviour for requests matching this rule. At this time the only supported value is `Allow`
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// The subnet id from which requests will match the rule.
        /// </summary>
        public readonly string SubnetId;

        [OutputConstructor]
        private RegistryNetworkRuleSetVirtualNetworks(
            string action,
            string subnetId)
        {
            Action = action;
            SubnetId = subnetId;
        }
    }

    [OutputType]
    public sealed class RegistryStorageAccount
    {
        public readonly string AccessKey;
        /// <summary>
        /// Specifies the name of the Container Registry. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private RegistryStorageAccount(
            string accessKey,
            string name)
        {
            AccessKey = accessKey;
            Name = name;
        }
    }
    }
}
