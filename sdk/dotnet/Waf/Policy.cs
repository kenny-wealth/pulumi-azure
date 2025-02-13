// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Waf
{
    /// <summary>
    /// Manages a Azure Web Application Firewall Policy instance.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/web_application_firewall_policy.html.markdown.
    /// </summary>
    public partial class Policy : Pulumi.CustomResource
    {
        /// <summary>
        /// One or more `custom_rule` blocks as defined below.
        /// </summary>
        [Output("customRules")]
        public Output<ImmutableArray<Outputs.PolicyCustomRules>> CustomRules { get; private set; } = null!;

        /// <summary>
        /// Resource location. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the policy. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A `policy_setting` block as defined below.
        /// </summary>
        [Output("policySettings")]
        public Output<Outputs.PolicyPolicySettings?> PolicySettings { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the Web Application Firewall Policy.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Policy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Policy(string name, PolicyArgs args, CustomResourceOptions? options = null)
            : base("azure:waf/policy:Policy", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Policy(string name, Input<string> id, PolicyState? state = null, CustomResourceOptions? options = null)
            : base("azure:waf/policy:Policy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Policy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Policy Get(string name, Input<string> id, PolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new Policy(name, id, state, options);
        }
    }

    public sealed class PolicyArgs : Pulumi.ResourceArgs
    {
        [Input("customRules")]
        private InputList<Inputs.PolicyCustomRulesArgs>? _customRules;

        /// <summary>
        /// One or more `custom_rule` blocks as defined below.
        /// </summary>
        public InputList<Inputs.PolicyCustomRulesArgs> CustomRules
        {
            get => _customRules ?? (_customRules = new InputList<Inputs.PolicyCustomRulesArgs>());
            set => _customRules = value;
        }

        /// <summary>
        /// Resource location. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the policy. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A `policy_setting` block as defined below.
        /// </summary>
        [Input("policySettings")]
        public Input<Inputs.PolicyPolicySettingsArgs>? PolicySettings { get; set; }

        /// <summary>
        /// The name of the resource group. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the Web Application Firewall Policy.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public PolicyArgs()
        {
        }
    }

    public sealed class PolicyState : Pulumi.ResourceArgs
    {
        [Input("customRules")]
        private InputList<Inputs.PolicyCustomRulesGetArgs>? _customRules;

        /// <summary>
        /// One or more `custom_rule` blocks as defined below.
        /// </summary>
        public InputList<Inputs.PolicyCustomRulesGetArgs> CustomRules
        {
            get => _customRules ?? (_customRules = new InputList<Inputs.PolicyCustomRulesGetArgs>());
            set => _customRules = value;
        }

        /// <summary>
        /// Resource location. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the policy. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A `policy_setting` block as defined below.
        /// </summary>
        [Input("policySettings")]
        public Input<Inputs.PolicyPolicySettingsGetArgs>? PolicySettings { get; set; }

        /// <summary>
        /// The name of the resource group. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the Web Application Firewall Policy.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public PolicyState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class PolicyCustomRulesArgs : Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("matchConditions", required: true)]
        private InputList<PolicyCustomRulesMatchConditionsArgs>? _matchConditions;
        public InputList<PolicyCustomRulesMatchConditionsArgs> MatchConditions
        {
            get => _matchConditions ?? (_matchConditions = new InputList<PolicyCustomRulesMatchConditionsArgs>());
            set => _matchConditions = value;
        }

        /// <summary>
        /// The name of the policy. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        [Input("ruleType", required: true)]
        public Input<string> RuleType { get; set; } = null!;

        public PolicyCustomRulesArgs()
        {
        }
    }

    public sealed class PolicyCustomRulesGetArgs : Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("matchConditions", required: true)]
        private InputList<PolicyCustomRulesMatchConditionsGetArgs>? _matchConditions;
        public InputList<PolicyCustomRulesMatchConditionsGetArgs> MatchConditions
        {
            get => _matchConditions ?? (_matchConditions = new InputList<PolicyCustomRulesMatchConditionsGetArgs>());
            set => _matchConditions = value;
        }

        /// <summary>
        /// The name of the policy. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        [Input("ruleType", required: true)]
        public Input<string> RuleType { get; set; } = null!;

        public PolicyCustomRulesGetArgs()
        {
        }
    }

    public sealed class PolicyCustomRulesMatchConditionsArgs : Pulumi.ResourceArgs
    {
        [Input("matchValues", required: true)]
        private InputList<string>? _matchValues;
        public InputList<string> MatchValues
        {
            get => _matchValues ?? (_matchValues = new InputList<string>());
            set => _matchValues = value;
        }

        [Input("matchVariables", required: true)]
        private InputList<PolicyCustomRulesMatchConditionsMatchVariablesArgs>? _matchVariables;
        public InputList<PolicyCustomRulesMatchConditionsMatchVariablesArgs> MatchVariables
        {
            get => _matchVariables ?? (_matchVariables = new InputList<PolicyCustomRulesMatchConditionsMatchVariablesArgs>());
            set => _matchVariables = value;
        }

        [Input("negationCondition")]
        public Input<bool>? NegationCondition { get; set; }

        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        public PolicyCustomRulesMatchConditionsArgs()
        {
        }
    }

    public sealed class PolicyCustomRulesMatchConditionsGetArgs : Pulumi.ResourceArgs
    {
        [Input("matchValues", required: true)]
        private InputList<string>? _matchValues;
        public InputList<string> MatchValues
        {
            get => _matchValues ?? (_matchValues = new InputList<string>());
            set => _matchValues = value;
        }

        [Input("matchVariables", required: true)]
        private InputList<PolicyCustomRulesMatchConditionsMatchVariablesGetArgs>? _matchVariables;
        public InputList<PolicyCustomRulesMatchConditionsMatchVariablesGetArgs> MatchVariables
        {
            get => _matchVariables ?? (_matchVariables = new InputList<PolicyCustomRulesMatchConditionsMatchVariablesGetArgs>());
            set => _matchVariables = value;
        }

        [Input("negationCondition")]
        public Input<bool>? NegationCondition { get; set; }

        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        public PolicyCustomRulesMatchConditionsGetArgs()
        {
        }
    }

    public sealed class PolicyCustomRulesMatchConditionsMatchVariablesArgs : Pulumi.ResourceArgs
    {
        [Input("selector")]
        public Input<string>? Selector { get; set; }

        [Input("variableName", required: true)]
        public Input<string> VariableName { get; set; } = null!;

        public PolicyCustomRulesMatchConditionsMatchVariablesArgs()
        {
        }
    }

    public sealed class PolicyCustomRulesMatchConditionsMatchVariablesGetArgs : Pulumi.ResourceArgs
    {
        [Input("selector")]
        public Input<string>? Selector { get; set; }

        [Input("variableName", required: true)]
        public Input<string> VariableName { get; set; } = null!;

        public PolicyCustomRulesMatchConditionsMatchVariablesGetArgs()
        {
        }
    }

    public sealed class PolicyPolicySettingsArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public PolicyPolicySettingsArgs()
        {
        }
    }

    public sealed class PolicyPolicySettingsGetArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public PolicyPolicySettingsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class PolicyCustomRules
    {
        public readonly string Action;
        public readonly ImmutableArray<PolicyCustomRulesMatchConditions> MatchConditions;
        /// <summary>
        /// The name of the policy. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string? Name;
        public readonly int Priority;
        public readonly string RuleType;

        [OutputConstructor]
        private PolicyCustomRules(
            string action,
            ImmutableArray<PolicyCustomRulesMatchConditions> matchConditions,
            string? name,
            int priority,
            string ruleType)
        {
            Action = action;
            MatchConditions = matchConditions;
            Name = name;
            Priority = priority;
            RuleType = ruleType;
        }
    }

    [OutputType]
    public sealed class PolicyCustomRulesMatchConditions
    {
        public readonly ImmutableArray<string> MatchValues;
        public readonly ImmutableArray<PolicyCustomRulesMatchConditionsMatchVariables> MatchVariables;
        public readonly bool? NegationCondition;
        public readonly string Operator;

        [OutputConstructor]
        private PolicyCustomRulesMatchConditions(
            ImmutableArray<string> matchValues,
            ImmutableArray<PolicyCustomRulesMatchConditionsMatchVariables> matchVariables,
            bool? negationCondition,
            string @operator)
        {
            MatchValues = matchValues;
            MatchVariables = matchVariables;
            NegationCondition = negationCondition;
            Operator = @operator;
        }
    }

    [OutputType]
    public sealed class PolicyCustomRulesMatchConditionsMatchVariables
    {
        public readonly string? Selector;
        public readonly string VariableName;

        [OutputConstructor]
        private PolicyCustomRulesMatchConditionsMatchVariables(
            string? selector,
            string variableName)
        {
            Selector = selector;
            VariableName = variableName;
        }
    }

    [OutputType]
    public sealed class PolicyPolicySettings
    {
        public readonly bool? Enabled;
        public readonly string? Mode;

        [OutputConstructor]
        private PolicyPolicySettings(
            bool? enabled,
            string? mode)
        {
            Enabled = enabled;
            Mode = mode;
        }
    }
    }
}
