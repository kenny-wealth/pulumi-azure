// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Bot
{
    /// <summary>
    /// Manages a Web App Bot.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/bot_web_app.html.markdown.
    /// </summary>
    public partial class WebApp : Pulumi.CustomResource
    {
        /// <summary>
        /// The Application Insights API Key to associate with the Web App Bot.
        /// </summary>
        [Output("developerAppInsightsApiKey")]
        public Output<string> DeveloperAppInsightsApiKey { get; private set; } = null!;

        /// <summary>
        /// The Application Insights Application ID to associate with the Web App Bot.
        /// </summary>
        [Output("developerAppInsightsApplicationId")]
        public Output<string> DeveloperAppInsightsApplicationId { get; private set; } = null!;

        /// <summary>
        /// The Application Insights Key to associate with the Web App Bot.
        /// </summary>
        [Output("developerAppInsightsKey")]
        public Output<string> DeveloperAppInsightsKey { get; private set; } = null!;

        /// <summary>
        /// The name of the Web App Bot will be displayed as. This defaults to `name` if not specified. 
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The Web App Bot endpoint.
        /// </summary>
        [Output("endpoint")]
        public Output<string?> Endpoint { get; private set; } = null!;

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// A list of LUIS App IDs to associate with the Web App Bot.
        /// </summary>
        [Output("luisAppIds")]
        public Output<ImmutableArray<string>> LuisAppIds { get; private set; } = null!;

        /// <summary>
        /// The LUIS key to associate with the Web App Bot.
        /// </summary>
        [Output("luisKey")]
        public Output<string?> LuisKey { get; private set; } = null!;

        /// <summary>
        /// The Microsoft Application ID for the Web App Bot. Changing this forces a new resource to be created.
        /// </summary>
        [Output("microsoftAppId")]
        public Output<string> MicrosoftAppId { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Web App Bot. Changing this forces a new resource to be created. Must be globally unique.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Web App Bot. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The SKU of the Web App Bot. Valid values include `F0` or `S1`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("sku")]
        public Output<string> Sku { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a WebApp resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebApp(string name, WebAppArgs args, CustomResourceOptions? options = null)
            : base("azure:bot/webApp:WebApp", name, args, MakeResourceOptions(options, ""))
        {
        }

        private WebApp(string name, Input<string> id, WebAppState? state = null, CustomResourceOptions? options = null)
            : base("azure:bot/webApp:WebApp", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing WebApp resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebApp Get(string name, Input<string> id, WebAppState? state = null, CustomResourceOptions? options = null)
        {
            return new WebApp(name, id, state, options);
        }
    }

    public sealed class WebAppArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Application Insights API Key to associate with the Web App Bot.
        /// </summary>
        [Input("developerAppInsightsApiKey")]
        public Input<string>? DeveloperAppInsightsApiKey { get; set; }

        /// <summary>
        /// The Application Insights Application ID to associate with the Web App Bot.
        /// </summary>
        [Input("developerAppInsightsApplicationId")]
        public Input<string>? DeveloperAppInsightsApplicationId { get; set; }

        /// <summary>
        /// The Application Insights Key to associate with the Web App Bot.
        /// </summary>
        [Input("developerAppInsightsKey")]
        public Input<string>? DeveloperAppInsightsKey { get; set; }

        /// <summary>
        /// The name of the Web App Bot will be displayed as. This defaults to `name` if not specified. 
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The Web App Bot endpoint.
        /// </summary>
        [Input("endpoint")]
        public Input<string>? Endpoint { get; set; }

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("luisAppIds")]
        private InputList<string>? _luisAppIds;

        /// <summary>
        /// A list of LUIS App IDs to associate with the Web App Bot.
        /// </summary>
        public InputList<string> LuisAppIds
        {
            get => _luisAppIds ?? (_luisAppIds = new InputList<string>());
            set => _luisAppIds = value;
        }

        /// <summary>
        /// The LUIS key to associate with the Web App Bot.
        /// </summary>
        [Input("luisKey")]
        public Input<string>? LuisKey { get; set; }

        /// <summary>
        /// The Microsoft Application ID for the Web App Bot. Changing this forces a new resource to be created.
        /// </summary>
        [Input("microsoftAppId", required: true)]
        public Input<string> MicrosoftAppId { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Web App Bot. Changing this forces a new resource to be created. Must be globally unique.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Web App Bot. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SKU of the Web App Bot. Valid values include `F0` or `S1`. Changing this forces a new resource to be created.
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

        public WebAppArgs()
        {
        }
    }

    public sealed class WebAppState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Application Insights API Key to associate with the Web App Bot.
        /// </summary>
        [Input("developerAppInsightsApiKey")]
        public Input<string>? DeveloperAppInsightsApiKey { get; set; }

        /// <summary>
        /// The Application Insights Application ID to associate with the Web App Bot.
        /// </summary>
        [Input("developerAppInsightsApplicationId")]
        public Input<string>? DeveloperAppInsightsApplicationId { get; set; }

        /// <summary>
        /// The Application Insights Key to associate with the Web App Bot.
        /// </summary>
        [Input("developerAppInsightsKey")]
        public Input<string>? DeveloperAppInsightsKey { get; set; }

        /// <summary>
        /// The name of the Web App Bot will be displayed as. This defaults to `name` if not specified. 
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The Web App Bot endpoint.
        /// </summary>
        [Input("endpoint")]
        public Input<string>? Endpoint { get; set; }

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("luisAppIds")]
        private InputList<string>? _luisAppIds;

        /// <summary>
        /// A list of LUIS App IDs to associate with the Web App Bot.
        /// </summary>
        public InputList<string> LuisAppIds
        {
            get => _luisAppIds ?? (_luisAppIds = new InputList<string>());
            set => _luisAppIds = value;
        }

        /// <summary>
        /// The LUIS key to associate with the Web App Bot.
        /// </summary>
        [Input("luisKey")]
        public Input<string>? LuisKey { get; set; }

        /// <summary>
        /// The Microsoft Application ID for the Web App Bot. Changing this forces a new resource to be created.
        /// </summary>
        [Input("microsoftAppId")]
        public Input<string>? MicrosoftAppId { get; set; }

        /// <summary>
        /// Specifies the name of the Web App Bot. Changing this forces a new resource to be created. Must be globally unique.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Web App Bot. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The SKU of the Web App Bot. Valid values include `F0` or `S1`. Changing this forces a new resource to be created.
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

        public WebAppState()
        {
        }
    }
}
