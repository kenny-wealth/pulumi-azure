// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Lb
{
    /// <summary>
    /// Manages a LoadBalancer Probe Resource.
    /// 
    /// &gt; **NOTE** When using this resource, the Load Balancer needs to have a FrontEnd IP Configuration Attached
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/lb_probe.html.markdown.
    /// </summary>
    public partial class Probe : Pulumi.CustomResource
    {
        /// <summary>
        /// The interval, in seconds between probes to the backend endpoint for health status. The default value is 15, the minimum value is 5.
        /// </summary>
        [Output("intervalInSeconds")]
        public Output<int?> IntervalInSeconds { get; private set; } = null!;

        [Output("loadBalancerRules")]
        public Output<ImmutableArray<string>> LoadBalancerRules { get; private set; } = null!;

        /// <summary>
        /// The ID of the LoadBalancer in which to create the NAT Rule.
        /// </summary>
        [Output("loadbalancerId")]
        public Output<string> LoadbalancerId { get; private set; } = null!;

        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Probe.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The number of failed probe attempts after which the backend endpoint is removed from rotation. The default value is 2. NumberOfProbes multiplied by intervalInSeconds value must be greater or equal to 10.Endpoints are returned to rotation when at least one probe is successful.
        /// </summary>
        [Output("numberOfProbes")]
        public Output<int?> NumberOfProbes { get; private set; } = null!;

        /// <summary>
        /// Port on which the Probe queries the backend endpoint. Possible values range from 1 to 65535, inclusive.
        /// </summary>
        [Output("port")]
        public Output<int> Port { get; private set; } = null!;

        /// <summary>
        /// Specifies the protocol of the end point. Possible values are `Http`, `Https` or `Tcp`. If Tcp is specified, a received ACK is required for the probe to be successful. If Http is specified, a 200 OK response from the specified URI is required for the probe to be successful.
        /// </summary>
        [Output("protocol")]
        public Output<string> Protocol { get; private set; } = null!;

        /// <summary>
        /// The URI used for requesting health status from the backend endpoint. Required if protocol is set to Http. Otherwise, it is not allowed.
        /// </summary>
        [Output("requestPath")]
        public Output<string?> RequestPath { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the resource.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;


        /// <summary>
        /// Create a Probe resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Probe(string name, ProbeArgs args, CustomResourceOptions? options = null)
            : base("azure:lb/probe:Probe", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Probe(string name, Input<string> id, ProbeState? state = null, CustomResourceOptions? options = null)
            : base("azure:lb/probe:Probe", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Probe resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Probe Get(string name, Input<string> id, ProbeState? state = null, CustomResourceOptions? options = null)
        {
            return new Probe(name, id, state, options);
        }
    }

    public sealed class ProbeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The interval, in seconds between probes to the backend endpoint for health status. The default value is 15, the minimum value is 5.
        /// </summary>
        [Input("intervalInSeconds")]
        public Input<int>? IntervalInSeconds { get; set; }

        /// <summary>
        /// The ID of the LoadBalancer in which to create the NAT Rule.
        /// </summary>
        [Input("loadbalancerId", required: true)]
        public Input<string> LoadbalancerId { get; set; } = null!;

        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Probe.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The number of failed probe attempts after which the backend endpoint is removed from rotation. The default value is 2. NumberOfProbes multiplied by intervalInSeconds value must be greater or equal to 10.Endpoints are returned to rotation when at least one probe is successful.
        /// </summary>
        [Input("numberOfProbes")]
        public Input<int>? NumberOfProbes { get; set; }

        /// <summary>
        /// Port on which the Probe queries the backend endpoint. Possible values range from 1 to 65535, inclusive.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// Specifies the protocol of the end point. Possible values are `Http`, `Https` or `Tcp`. If Tcp is specified, a received ACK is required for the probe to be successful. If Http is specified, a 200 OK response from the specified URI is required for the probe to be successful.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The URI used for requesting health status from the backend endpoint. Required if protocol is set to Http. Otherwise, it is not allowed.
        /// </summary>
        [Input("requestPath")]
        public Input<string>? RequestPath { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the resource.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ProbeArgs()
        {
        }
    }

    public sealed class ProbeState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The interval, in seconds between probes to the backend endpoint for health status. The default value is 15, the minimum value is 5.
        /// </summary>
        [Input("intervalInSeconds")]
        public Input<int>? IntervalInSeconds { get; set; }

        [Input("loadBalancerRules")]
        private InputList<string>? _loadBalancerRules;
        public InputList<string> LoadBalancerRules
        {
            get => _loadBalancerRules ?? (_loadBalancerRules = new InputList<string>());
            set => _loadBalancerRules = value;
        }

        /// <summary>
        /// The ID of the LoadBalancer in which to create the NAT Rule.
        /// </summary>
        [Input("loadbalancerId")]
        public Input<string>? LoadbalancerId { get; set; }

        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Probe.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The number of failed probe attempts after which the backend endpoint is removed from rotation. The default value is 2. NumberOfProbes multiplied by intervalInSeconds value must be greater or equal to 10.Endpoints are returned to rotation when at least one probe is successful.
        /// </summary>
        [Input("numberOfProbes")]
        public Input<int>? NumberOfProbes { get; set; }

        /// <summary>
        /// Port on which the Probe queries the backend endpoint. Possible values range from 1 to 65535, inclusive.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Specifies the protocol of the end point. Possible values are `Http`, `Https` or `Tcp`. If Tcp is specified, a received ACK is required for the probe to be successful. If Http is specified, a 200 OK response from the specified URI is required for the probe to be successful.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The URI used for requesting health status from the backend endpoint. Required if protocol is set to Http. Otherwise, it is not allowed.
        /// </summary>
        [Input("requestPath")]
        public Input<string>? RequestPath { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the resource.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        public ProbeState()
        {
        }
    }
}
