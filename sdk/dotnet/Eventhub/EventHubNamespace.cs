// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.EventHub
{
    /// <summary>
    /// Manages an EventHub Namespace.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/eventhub_namespace.html.markdown.
    /// </summary>
    public partial class EventHubNamespace : Pulumi.CustomResource
    {
        /// <summary>
        /// Is Auto Inflate enabled for the EventHub Namespace?
        /// </summary>
        [Output("autoInflateEnabled")]
        public Output<bool?> AutoInflateEnabled { get; private set; } = null!;

        /// <summary>
        /// Specifies the Capacity / Throughput Units for a `Standard` SKU namespace. Valid values range from `1` - `20`.
        /// </summary>
        [Output("capacity")]
        public Output<int?> Capacity { get; private set; } = null!;

        /// <summary>
        /// The primary connection string for the authorization
        /// rule `RootManageSharedAccessKey`.
        /// </summary>
        [Output("defaultPrimaryConnectionString")]
        public Output<string> DefaultPrimaryConnectionString { get; private set; } = null!;

        /// <summary>
        /// The primary access key for the authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        [Output("defaultPrimaryKey")]
        public Output<string> DefaultPrimaryKey { get; private set; } = null!;

        /// <summary>
        /// The secondary connection string for the
        /// authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        [Output("defaultSecondaryConnectionString")]
        public Output<string> DefaultSecondaryConnectionString { get; private set; } = null!;

        /// <summary>
        /// The secondary access key for the authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        [Output("defaultSecondaryKey")]
        public Output<string> DefaultSecondaryKey { get; private set; } = null!;

        /// <summary>
        /// Is Kafka enabled for the EventHub Namespace? Defaults to `false`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("kafkaEnabled")]
        public Output<bool?> KafkaEnabled { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the maximum number of throughput units when Auto Inflate is Enabled. Valid values range from `1` - `20`.
        /// </summary>
        [Output("maximumThroughputUnits")]
        public Output<int> MaximumThroughputUnits { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the EventHub Namespace resource. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A `network_rulesets` block as defined below.
        /// </summary>
        [Output("networkRulesets")]
        public Output<Outputs.EventHubNamespaceNetworkRulesets> NetworkRulesets { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the namespace. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// Defines which tier to use. Valid options are `Basic` and `Standard`.
        /// </summary>
        [Output("sku")]
        public Output<string> Sku { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a EventHubNamespace resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EventHubNamespace(string name, EventHubNamespaceArgs args, CustomResourceOptions? options = null)
            : base("azure:eventhub/eventHubNamespace:EventHubNamespace", name, args, MakeResourceOptions(options, ""))
        {
        }

        private EventHubNamespace(string name, Input<string> id, EventHubNamespaceState? state = null, CustomResourceOptions? options = null)
            : base("azure:eventhub/eventHubNamespace:EventHubNamespace", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing EventHubNamespace resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EventHubNamespace Get(string name, Input<string> id, EventHubNamespaceState? state = null, CustomResourceOptions? options = null)
        {
            return new EventHubNamespace(name, id, state, options);
        }
    }

    public sealed class EventHubNamespaceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Is Auto Inflate enabled for the EventHub Namespace?
        /// </summary>
        [Input("autoInflateEnabled")]
        public Input<bool>? AutoInflateEnabled { get; set; }

        /// <summary>
        /// Specifies the Capacity / Throughput Units for a `Standard` SKU namespace. Valid values range from `1` - `20`.
        /// </summary>
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        /// <summary>
        /// Is Kafka enabled for the EventHub Namespace? Defaults to `false`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("kafkaEnabled")]
        public Input<bool>? KafkaEnabled { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the maximum number of throughput units when Auto Inflate is Enabled. Valid values range from `1` - `20`.
        /// </summary>
        [Input("maximumThroughputUnits")]
        public Input<int>? MaximumThroughputUnits { get; set; }

        /// <summary>
        /// Specifies the name of the EventHub Namespace resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A `network_rulesets` block as defined below.
        /// </summary>
        [Input("networkRulesets")]
        public Input<Inputs.EventHubNamespaceNetworkRulesetsArgs>? NetworkRulesets { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the namespace. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Defines which tier to use. Valid options are `Basic` and `Standard`.
        /// </summary>
        [Input("sku", required: true)]
        public Input<string> Sku { get; set; } = null!;

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

        public EventHubNamespaceArgs()
        {
        }
    }

    public sealed class EventHubNamespaceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Is Auto Inflate enabled for the EventHub Namespace?
        /// </summary>
        [Input("autoInflateEnabled")]
        public Input<bool>? AutoInflateEnabled { get; set; }

        /// <summary>
        /// Specifies the Capacity / Throughput Units for a `Standard` SKU namespace. Valid values range from `1` - `20`.
        /// </summary>
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        /// <summary>
        /// The primary connection string for the authorization
        /// rule `RootManageSharedAccessKey`.
        /// </summary>
        [Input("defaultPrimaryConnectionString")]
        public Input<string>? DefaultPrimaryConnectionString { get; set; }

        /// <summary>
        /// The primary access key for the authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        [Input("defaultPrimaryKey")]
        public Input<string>? DefaultPrimaryKey { get; set; }

        /// <summary>
        /// The secondary connection string for the
        /// authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        [Input("defaultSecondaryConnectionString")]
        public Input<string>? DefaultSecondaryConnectionString { get; set; }

        /// <summary>
        /// The secondary access key for the authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        [Input("defaultSecondaryKey")]
        public Input<string>? DefaultSecondaryKey { get; set; }

        /// <summary>
        /// Is Kafka enabled for the EventHub Namespace? Defaults to `false`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("kafkaEnabled")]
        public Input<bool>? KafkaEnabled { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the maximum number of throughput units when Auto Inflate is Enabled. Valid values range from `1` - `20`.
        /// </summary>
        [Input("maximumThroughputUnits")]
        public Input<int>? MaximumThroughputUnits { get; set; }

        /// <summary>
        /// Specifies the name of the EventHub Namespace resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A `network_rulesets` block as defined below.
        /// </summary>
        [Input("networkRulesets")]
        public Input<Inputs.EventHubNamespaceNetworkRulesetsGetArgs>? NetworkRulesets { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the namespace. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// Defines which tier to use. Valid options are `Basic` and `Standard`.
        /// </summary>
        [Input("sku")]
        public Input<string>? Sku { get; set; }

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

        public EventHubNamespaceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class EventHubNamespaceNetworkRulesetsArgs : Pulumi.ResourceArgs
    {
        [Input("defaultAction", required: true)]
        public Input<string> DefaultAction { get; set; } = null!;

        [Input("ipRule")]
        public Input<EventHubNamespaceNetworkRulesetsIpRuleArgs>? IpRule { get; set; }

        [Input("virtualNetworkRules")]
        private InputList<EventHubNamespaceNetworkRulesetsVirtualNetworkRulesArgs>? _virtualNetworkRules;
        public InputList<EventHubNamespaceNetworkRulesetsVirtualNetworkRulesArgs> VirtualNetworkRules
        {
            get => _virtualNetworkRules ?? (_virtualNetworkRules = new InputList<EventHubNamespaceNetworkRulesetsVirtualNetworkRulesArgs>());
            set => _virtualNetworkRules = value;
        }

        public EventHubNamespaceNetworkRulesetsArgs()
        {
        }
    }

    public sealed class EventHubNamespaceNetworkRulesetsGetArgs : Pulumi.ResourceArgs
    {
        [Input("defaultAction", required: true)]
        public Input<string> DefaultAction { get; set; } = null!;

        [Input("ipRule")]
        public Input<EventHubNamespaceNetworkRulesetsIpRuleGetArgs>? IpRule { get; set; }

        [Input("virtualNetworkRules")]
        private InputList<EventHubNamespaceNetworkRulesetsVirtualNetworkRulesGetArgs>? _virtualNetworkRules;
        public InputList<EventHubNamespaceNetworkRulesetsVirtualNetworkRulesGetArgs> VirtualNetworkRules
        {
            get => _virtualNetworkRules ?? (_virtualNetworkRules = new InputList<EventHubNamespaceNetworkRulesetsVirtualNetworkRulesGetArgs>());
            set => _virtualNetworkRules = value;
        }

        public EventHubNamespaceNetworkRulesetsGetArgs()
        {
        }
    }

    public sealed class EventHubNamespaceNetworkRulesetsIpRuleArgs : Pulumi.ResourceArgs
    {
        [Input("action")]
        public Input<string>? Action { get; set; }

        [Input("ipMask", required: true)]
        public Input<string> IpMask { get; set; } = null!;

        public EventHubNamespaceNetworkRulesetsIpRuleArgs()
        {
        }
    }

    public sealed class EventHubNamespaceNetworkRulesetsIpRuleGetArgs : Pulumi.ResourceArgs
    {
        [Input("action")]
        public Input<string>? Action { get; set; }

        [Input("ipMask", required: true)]
        public Input<string> IpMask { get; set; } = null!;

        public EventHubNamespaceNetworkRulesetsIpRuleGetArgs()
        {
        }
    }

    public sealed class EventHubNamespaceNetworkRulesetsVirtualNetworkRulesArgs : Pulumi.ResourceArgs
    {
        [Input("ignoreMissingVirtualNetworkServiceEndpoint")]
        public Input<bool>? IgnoreMissingVirtualNetworkServiceEndpoint { get; set; }

        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public EventHubNamespaceNetworkRulesetsVirtualNetworkRulesArgs()
        {
        }
    }

    public sealed class EventHubNamespaceNetworkRulesetsVirtualNetworkRulesGetArgs : Pulumi.ResourceArgs
    {
        [Input("ignoreMissingVirtualNetworkServiceEndpoint")]
        public Input<bool>? IgnoreMissingVirtualNetworkServiceEndpoint { get; set; }

        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public EventHubNamespaceNetworkRulesetsVirtualNetworkRulesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class EventHubNamespaceNetworkRulesets
    {
        public readonly string DefaultAction;
        public readonly EventHubNamespaceNetworkRulesetsIpRule? IpRule;
        public readonly ImmutableArray<EventHubNamespaceNetworkRulesetsVirtualNetworkRules> VirtualNetworkRules;

        [OutputConstructor]
        private EventHubNamespaceNetworkRulesets(
            string defaultAction,
            EventHubNamespaceNetworkRulesetsIpRule? ipRule,
            ImmutableArray<EventHubNamespaceNetworkRulesetsVirtualNetworkRules> virtualNetworkRules)
        {
            DefaultAction = defaultAction;
            IpRule = ipRule;
            VirtualNetworkRules = virtualNetworkRules;
        }
    }

    [OutputType]
    public sealed class EventHubNamespaceNetworkRulesetsIpRule
    {
        public readonly string? Action;
        public readonly string IpMask;

        [OutputConstructor]
        private EventHubNamespaceNetworkRulesetsIpRule(
            string? action,
            string ipMask)
        {
            Action = action;
            IpMask = ipMask;
        }
    }

    [OutputType]
    public sealed class EventHubNamespaceNetworkRulesetsVirtualNetworkRules
    {
        public readonly bool? IgnoreMissingVirtualNetworkServiceEndpoint;
        public readonly string SubnetId;

        [OutputConstructor]
        private EventHubNamespaceNetworkRulesetsVirtualNetworkRules(
            bool? ignoreMissingVirtualNetworkServiceEndpoint,
            string subnetId)
        {
            IgnoreMissingVirtualNetworkServiceEndpoint = ignoreMissingVirtualNetworkServiceEndpoint;
            SubnetId = subnetId;
        }
    }
    }
}
