// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService
{
    /// <summary>
    /// Manages a Hostname Binding within an App Service.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/app_service_custom_hostname_binding.html.markdown.
    /// </summary>
    public partial class CustomHostnameBinding : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the App Service in which to add the Custom Hostname Binding. Changing this forces a new resource to be created.
        /// </summary>
        [Output("appServiceName")]
        public Output<string> AppServiceName { get; private set; } = null!;

        /// <summary>
        /// Specifies the Custom Hostname to use for the App Service, example `www.example.com`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("hostname")]
        public Output<string> Hostname { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the App Service exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The SSL type. Possible values are `IpBasedEnabled` and `SniEnabled`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("sslState")]
        public Output<string?> SslState { get; private set; } = null!;

        /// <summary>
        /// The SSL certificate thumbprint. Changing this forces a new resource to be created.
        /// </summary>
        [Output("thumbprint")]
        public Output<string?> Thumbprint { get; private set; } = null!;

        /// <summary>
        /// The virtual IP address assigned to the hostname if IP based SSL is enabled.
        /// </summary>
        [Output("virtualIp")]
        public Output<string> VirtualIp { get; private set; } = null!;


        /// <summary>
        /// Create a CustomHostnameBinding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CustomHostnameBinding(string name, CustomHostnameBindingArgs args, CustomResourceOptions? options = null)
            : base("azure:appservice/customHostnameBinding:CustomHostnameBinding", name, args, MakeResourceOptions(options, ""))
        {
        }

        private CustomHostnameBinding(string name, Input<string> id, CustomHostnameBindingState? state = null, CustomResourceOptions? options = null)
            : base("azure:appservice/customHostnameBinding:CustomHostnameBinding", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CustomHostnameBinding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CustomHostnameBinding Get(string name, Input<string> id, CustomHostnameBindingState? state = null, CustomResourceOptions? options = null)
        {
            return new CustomHostnameBinding(name, id, state, options);
        }
    }

    public sealed class CustomHostnameBindingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the App Service in which to add the Custom Hostname Binding. Changing this forces a new resource to be created.
        /// </summary>
        [Input("appServiceName", required: true)]
        public Input<string> AppServiceName { get; set; } = null!;

        /// <summary>
        /// Specifies the Custom Hostname to use for the App Service, example `www.example.com`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("hostname", required: true)]
        public Input<string> Hostname { get; set; } = null!;

        /// <summary>
        /// The name of the resource group in which the App Service exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SSL type. Possible values are `IpBasedEnabled` and `SniEnabled`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("sslState")]
        public Input<string>? SslState { get; set; }

        /// <summary>
        /// The SSL certificate thumbprint. Changing this forces a new resource to be created.
        /// </summary>
        [Input("thumbprint")]
        public Input<string>? Thumbprint { get; set; }

        public CustomHostnameBindingArgs()
        {
        }
    }

    public sealed class CustomHostnameBindingState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the App Service in which to add the Custom Hostname Binding. Changing this forces a new resource to be created.
        /// </summary>
        [Input("appServiceName")]
        public Input<string>? AppServiceName { get; set; }

        /// <summary>
        /// Specifies the Custom Hostname to use for the App Service, example `www.example.com`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// The name of the resource group in which the App Service exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The SSL type. Possible values are `IpBasedEnabled` and `SniEnabled`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("sslState")]
        public Input<string>? SslState { get; set; }

        /// <summary>
        /// The SSL certificate thumbprint. Changing this forces a new resource to be created.
        /// </summary>
        [Input("thumbprint")]
        public Input<string>? Thumbprint { get; set; }

        /// <summary>
        /// The virtual IP address assigned to the hostname if IP based SSL is enabled.
        /// </summary>
        [Input("virtualIp")]
        public Input<string>? VirtualIp { get; set; }

        public CustomHostnameBindingState()
        {
        }
    }
}
