// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Lb
{
    /// <summary>
    /// Manages a Load Balancer NAT pool. 
    /// 
    /// &gt; **NOTE:** This resource cannot be used with with virtual machines, instead use the `azure.lb.NatRule` resource.
    /// 
    /// &gt; **NOTE** When using this resource, the Load Balancer needs to have a FrontEnd IP Configuration Attached
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/lb_nat_pool.html.markdown.
    /// </summary>
    public partial class NatPool : Pulumi.CustomResource
    {
        /// <summary>
        /// The port used for the internal endpoint. Possible values range between 1 and 65535, inclusive.
        /// </summary>
        [Output("backendPort")]
        public Output<int> BackendPort { get; private set; } = null!;

        [Output("frontendIpConfigurationId")]
        public Output<string> FrontendIpConfigurationId { get; private set; } = null!;

        /// <summary>
        /// The name of the frontend IP configuration exposing this rule.
        /// </summary>
        [Output("frontendIpConfigurationName")]
        public Output<string> FrontendIpConfigurationName { get; private set; } = null!;

        /// <summary>
        /// The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with this Load Balancer. Possible values range between 1 and 65534, inclusive.
        /// </summary>
        [Output("frontendPortEnd")]
        public Output<int> FrontendPortEnd { get; private set; } = null!;

        /// <summary>
        /// The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with this Load Balancer. Possible values range between 1 and 65534, inclusive.
        /// </summary>
        [Output("frontendPortStart")]
        public Output<int> FrontendPortStart { get; private set; } = null!;

        /// <summary>
        /// The ID of the Load Balancer in which to create the NAT pool.
        /// </summary>
        [Output("loadbalancerId")]
        public Output<string> LoadbalancerId { get; private set; } = null!;

        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the NAT pool.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The transport protocol for the external endpoint. Possible values are `Udp` or `Tcp`.
        /// </summary>
        [Output("protocol")]
        public Output<string> Protocol { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the resource.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;


        /// <summary>
        /// Create a NatPool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NatPool(string name, NatPoolArgs args, CustomResourceOptions? options = null)
            : base("azure:lb/natPool:NatPool", name, args, MakeResourceOptions(options, ""))
        {
        }

        private NatPool(string name, Input<string> id, NatPoolState? state = null, CustomResourceOptions? options = null)
            : base("azure:lb/natPool:NatPool", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NatPool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NatPool Get(string name, Input<string> id, NatPoolState? state = null, CustomResourceOptions? options = null)
        {
            return new NatPool(name, id, state, options);
        }
    }

    public sealed class NatPoolArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The port used for the internal endpoint. Possible values range between 1 and 65535, inclusive.
        /// </summary>
        [Input("backendPort", required: true)]
        public Input<int> BackendPort { get; set; } = null!;

        /// <summary>
        /// The name of the frontend IP configuration exposing this rule.
        /// </summary>
        [Input("frontendIpConfigurationName", required: true)]
        public Input<string> FrontendIpConfigurationName { get; set; } = null!;

        /// <summary>
        /// The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with this Load Balancer. Possible values range between 1 and 65534, inclusive.
        /// </summary>
        [Input("frontendPortEnd", required: true)]
        public Input<int> FrontendPortEnd { get; set; } = null!;

        /// <summary>
        /// The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with this Load Balancer. Possible values range between 1 and 65534, inclusive.
        /// </summary>
        [Input("frontendPortStart", required: true)]
        public Input<int> FrontendPortStart { get; set; } = null!;

        /// <summary>
        /// The ID of the Load Balancer in which to create the NAT pool.
        /// </summary>
        [Input("loadbalancerId", required: true)]
        public Input<string> LoadbalancerId { get; set; } = null!;

        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the NAT pool.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The transport protocol for the external endpoint. Possible values are `Udp` or `Tcp`.
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the resource.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public NatPoolArgs()
        {
        }
    }

    public sealed class NatPoolState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The port used for the internal endpoint. Possible values range between 1 and 65535, inclusive.
        /// </summary>
        [Input("backendPort")]
        public Input<int>? BackendPort { get; set; }

        [Input("frontendIpConfigurationId")]
        public Input<string>? FrontendIpConfigurationId { get; set; }

        /// <summary>
        /// The name of the frontend IP configuration exposing this rule.
        /// </summary>
        [Input("frontendIpConfigurationName")]
        public Input<string>? FrontendIpConfigurationName { get; set; }

        /// <summary>
        /// The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with this Load Balancer. Possible values range between 1 and 65534, inclusive.
        /// </summary>
        [Input("frontendPortEnd")]
        public Input<int>? FrontendPortEnd { get; set; }

        /// <summary>
        /// The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with this Load Balancer. Possible values range between 1 and 65534, inclusive.
        /// </summary>
        [Input("frontendPortStart")]
        public Input<int>? FrontendPortStart { get; set; }

        /// <summary>
        /// The ID of the Load Balancer in which to create the NAT pool.
        /// </summary>
        [Input("loadbalancerId")]
        public Input<string>? LoadbalancerId { get; set; }

        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the NAT pool.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The transport protocol for the external endpoint. Possible values are `Udp` or `Tcp`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the resource.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        public NatPoolState()
        {
        }
    }
}
