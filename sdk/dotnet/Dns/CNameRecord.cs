// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Dns
{
    /// <summary>
    /// Enables you to manage DNS CNAME Records within Azure DNS.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/dns_cname_record.html.markdown.
    /// </summary>
    public partial class CNameRecord : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the DNS CNAME Record.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The target of the CNAME.
        /// </summary>
        [Output("record")]
        public Output<string> Record { get; private set; } = null!;

        /// <summary>
        /// Specifies the resource group where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        [Output("ttl")]
        public Output<int> Ttl { get; private set; } = null!;

        /// <summary>
        /// Specifies the DNS Zone where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("zoneName")]
        public Output<string> ZoneName { get; private set; } = null!;


        /// <summary>
        /// Create a CNameRecord resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CNameRecord(string name, CNameRecordArgs args, CustomResourceOptions? options = null)
            : base("azure:dns/cNameRecord:CNameRecord", name, args, MakeResourceOptions(options, ""))
        {
        }

        private CNameRecord(string name, Input<string> id, CNameRecordState? state = null, CustomResourceOptions? options = null)
            : base("azure:dns/cNameRecord:CNameRecord", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CNameRecord resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CNameRecord Get(string name, Input<string> id, CNameRecordState? state = null, CustomResourceOptions? options = null)
        {
            return new CNameRecord(name, id, state, options);
        }
    }

    public sealed class CNameRecordArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the DNS CNAME Record.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The target of the CNAME.
        /// </summary>
        [Input("record", required: true)]
        public Input<string> Record { get; set; } = null!;

        /// <summary>
        /// Specifies the resource group where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
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

        [Input("ttl", required: true)]
        public Input<int> Ttl { get; set; } = null!;

        /// <summary>
        /// Specifies the DNS Zone where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("zoneName", required: true)]
        public Input<string> ZoneName { get; set; } = null!;

        public CNameRecordArgs()
        {
        }
    }

    public sealed class CNameRecordState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the DNS CNAME Record.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The target of the CNAME.
        /// </summary>
        [Input("record")]
        public Input<string>? Record { get; set; }

        /// <summary>
        /// Specifies the resource group where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
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

        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        /// <summary>
        /// Specifies the DNS Zone where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("zoneName")]
        public Input<string>? ZoneName { get; set; }

        public CNameRecordState()
        {
        }
    }
}
