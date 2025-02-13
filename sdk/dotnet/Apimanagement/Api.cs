// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ApiManagement
{
    /// <summary>
    /// Manages an API within an API Management Service.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/api_management_api.html.markdown.
    /// </summary>
    public partial class Api : Pulumi.CustomResource
    {
        /// <summary>
        /// The Name of the API Management Service where this API should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("apiManagementName")]
        public Output<string> ApiManagementName { get; private set; } = null!;

        /// <summary>
        /// A description of the API Management API, which may include HTML formatting tags.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The display name of the API.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// A `import` block as documented below.
        /// </summary>
        [Output("import")]
        public Output<Outputs.ApiImport?> Import { get; private set; } = null!;

        /// <summary>
        /// Is this the current API Revision?
        /// </summary>
        [Output("isCurrent")]
        public Output<bool> IsCurrent { get; private set; } = null!;

        /// <summary>
        /// Is this API Revision online/accessible via the Gateway?
        /// </summary>
        [Output("isOnline")]
        public Output<bool> IsOnline { get; private set; } = null!;

        /// <summary>
        /// The name of the API Management API. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of it's resource paths within the API Management Service.
        /// </summary>
        [Output("path")]
        public Output<string> Path { get; private set; } = null!;

        /// <summary>
        /// A list of protocols the operations in this API can be invoked. Possible values are `http` and `https`.
        /// </summary>
        [Output("protocols")]
        public Output<ImmutableArray<string>> Protocols { get; private set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where the API Management API exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The Revision which used for this API.
        /// </summary>
        [Output("revision")]
        public Output<string> Revision { get; private set; } = null!;

        /// <summary>
        /// Absolute URL of the backend service implementing this API.
        /// </summary>
        [Output("serviceUrl")]
        public Output<string> ServiceUrl { get; private set; } = null!;

        /// <summary>
        /// Should this API expose a SOAP frontend, rather than a HTTP frontend? Defaults to `false`.
        /// </summary>
        [Output("soapPassThrough")]
        public Output<bool?> SoapPassThrough { get; private set; } = null!;

        /// <summary>
        /// A `subscription_key_parameter_names` block as documented below.
        /// </summary>
        [Output("subscriptionKeyParameterNames")]
        public Output<Outputs.ApiSubscriptionKeyParameterNames> SubscriptionKeyParameterNames { get; private set; } = null!;

        /// <summary>
        /// The Version number of this API, if this API is versioned.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        /// <summary>
        /// The ID of the Version Set which this API is associated with.
        /// </summary>
        [Output("versionSetId")]
        public Output<string> VersionSetId { get; private set; } = null!;


        /// <summary>
        /// Create a Api resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Api(string name, ApiArgs args, CustomResourceOptions? options = null)
            : base("azure:apimanagement/api:Api", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Api(string name, Input<string> id, ApiState? state = null, CustomResourceOptions? options = null)
            : base("azure:apimanagement/api:Api", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Api resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Api Get(string name, Input<string> id, ApiState? state = null, CustomResourceOptions? options = null)
        {
            return new Api(name, id, state, options);
        }
    }

    public sealed class ApiArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Name of the API Management Service where this API should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("apiManagementName", required: true)]
        public Input<string> ApiManagementName { get; set; } = null!;

        /// <summary>
        /// A description of the API Management API, which may include HTML formatting tags.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of the API.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// A `import` block as documented below.
        /// </summary>
        [Input("import")]
        public Input<Inputs.ApiImportArgs>? Import { get; set; }

        /// <summary>
        /// The name of the API Management API. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of it's resource paths within the API Management Service.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("protocols", required: true)]
        private InputList<string>? _protocols;

        /// <summary>
        /// A list of protocols the operations in this API can be invoked. Possible values are `http` and `https`.
        /// </summary>
        public InputList<string> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<string>());
            set => _protocols = value;
        }

        /// <summary>
        /// The Name of the Resource Group where the API Management API exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Revision which used for this API.
        /// </summary>
        [Input("revision", required: true)]
        public Input<string> Revision { get; set; } = null!;

        /// <summary>
        /// Absolute URL of the backend service implementing this API.
        /// </summary>
        [Input("serviceUrl")]
        public Input<string>? ServiceUrl { get; set; }

        /// <summary>
        /// Should this API expose a SOAP frontend, rather than a HTTP frontend? Defaults to `false`.
        /// </summary>
        [Input("soapPassThrough")]
        public Input<bool>? SoapPassThrough { get; set; }

        /// <summary>
        /// A `subscription_key_parameter_names` block as documented below.
        /// </summary>
        [Input("subscriptionKeyParameterNames")]
        public Input<Inputs.ApiSubscriptionKeyParameterNamesArgs>? SubscriptionKeyParameterNames { get; set; }

        public ApiArgs()
        {
        }
    }

    public sealed class ApiState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Name of the API Management Service where this API should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("apiManagementName")]
        public Input<string>? ApiManagementName { get; set; }

        /// <summary>
        /// A description of the API Management API, which may include HTML formatting tags.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of the API.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// A `import` block as documented below.
        /// </summary>
        [Input("import")]
        public Input<Inputs.ApiImportGetArgs>? Import { get; set; }

        /// <summary>
        /// Is this the current API Revision?
        /// </summary>
        [Input("isCurrent")]
        public Input<bool>? IsCurrent { get; set; }

        /// <summary>
        /// Is this API Revision online/accessible via the Gateway?
        /// </summary>
        [Input("isOnline")]
        public Input<bool>? IsOnline { get; set; }

        /// <summary>
        /// The name of the API Management API. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of it's resource paths within the API Management Service.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("protocols")]
        private InputList<string>? _protocols;

        /// <summary>
        /// A list of protocols the operations in this API can be invoked. Possible values are `http` and `https`.
        /// </summary>
        public InputList<string> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<string>());
            set => _protocols = value;
        }

        /// <summary>
        /// The Name of the Resource Group where the API Management API exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The Revision which used for this API.
        /// </summary>
        [Input("revision")]
        public Input<string>? Revision { get; set; }

        /// <summary>
        /// Absolute URL of the backend service implementing this API.
        /// </summary>
        [Input("serviceUrl")]
        public Input<string>? ServiceUrl { get; set; }

        /// <summary>
        /// Should this API expose a SOAP frontend, rather than a HTTP frontend? Defaults to `false`.
        /// </summary>
        [Input("soapPassThrough")]
        public Input<bool>? SoapPassThrough { get; set; }

        /// <summary>
        /// A `subscription_key_parameter_names` block as documented below.
        /// </summary>
        [Input("subscriptionKeyParameterNames")]
        public Input<Inputs.ApiSubscriptionKeyParameterNamesGetArgs>? SubscriptionKeyParameterNames { get; set; }

        /// <summary>
        /// The Version number of this API, if this API is versioned.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        /// <summary>
        /// The ID of the Version Set which this API is associated with.
        /// </summary>
        [Input("versionSetId")]
        public Input<string>? VersionSetId { get; set; }

        public ApiState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ApiImportArgs : Pulumi.ResourceArgs
    {
        [Input("contentFormat", required: true)]
        public Input<string> ContentFormat { get; set; } = null!;

        [Input("contentValue", required: true)]
        public Input<string> ContentValue { get; set; } = null!;

        [Input("wsdlSelector")]
        public Input<ApiImportWsdlSelectorArgs>? WsdlSelector { get; set; }

        public ApiImportArgs()
        {
        }
    }

    public sealed class ApiImportGetArgs : Pulumi.ResourceArgs
    {
        [Input("contentFormat", required: true)]
        public Input<string> ContentFormat { get; set; } = null!;

        [Input("contentValue", required: true)]
        public Input<string> ContentValue { get; set; } = null!;

        [Input("wsdlSelector")]
        public Input<ApiImportWsdlSelectorGetArgs>? WsdlSelector { get; set; }

        public ApiImportGetArgs()
        {
        }
    }

    public sealed class ApiImportWsdlSelectorArgs : Pulumi.ResourceArgs
    {
        [Input("endpointName", required: true)]
        public Input<string> EndpointName { get; set; } = null!;

        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public ApiImportWsdlSelectorArgs()
        {
        }
    }

    public sealed class ApiImportWsdlSelectorGetArgs : Pulumi.ResourceArgs
    {
        [Input("endpointName", required: true)]
        public Input<string> EndpointName { get; set; } = null!;

        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public ApiImportWsdlSelectorGetArgs()
        {
        }
    }

    public sealed class ApiSubscriptionKeyParameterNamesArgs : Pulumi.ResourceArgs
    {
        [Input("header", required: true)]
        public Input<string> Header { get; set; } = null!;

        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public ApiSubscriptionKeyParameterNamesArgs()
        {
        }
    }

    public sealed class ApiSubscriptionKeyParameterNamesGetArgs : Pulumi.ResourceArgs
    {
        [Input("header", required: true)]
        public Input<string> Header { get; set; } = null!;

        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public ApiSubscriptionKeyParameterNamesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ApiImport
    {
        public readonly string ContentFormat;
        public readonly string ContentValue;
        public readonly ApiImportWsdlSelector? WsdlSelector;

        [OutputConstructor]
        private ApiImport(
            string contentFormat,
            string contentValue,
            ApiImportWsdlSelector? wsdlSelector)
        {
            ContentFormat = contentFormat;
            ContentValue = contentValue;
            WsdlSelector = wsdlSelector;
        }
    }

    [OutputType]
    public sealed class ApiImportWsdlSelector
    {
        public readonly string EndpointName;
        public readonly string ServiceName;

        [OutputConstructor]
        private ApiImportWsdlSelector(
            string endpointName,
            string serviceName)
        {
            EndpointName = endpointName;
            ServiceName = serviceName;
        }
    }

    [OutputType]
    public sealed class ApiSubscriptionKeyParameterNames
    {
        public readonly string Header;
        public readonly string Query;

        [OutputConstructor]
        private ApiSubscriptionKeyParameterNames(
            string header,
            string query)
        {
            Header = header;
            Query = query;
        }
    }
    }
}
