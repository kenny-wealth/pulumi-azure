// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.DataLake
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Data Lake Store.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/data_lake_store.html.markdown.
        /// </summary>
        public static Task<GetStoreResult> GetStore(GetStoreArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStoreResult>("azure:datalake/getStore:getStore", args, options.WithVersion());
    }

    public sealed class GetStoreArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Data Lake Store.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where the Data Lake Store exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetStoreArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetStoreResult
    {
        /// <summary>
        /// the Encryption State of this Data Lake Store Account, such as `Enabled` or `Disabled`.
        /// </summary>
        public readonly string EncryptionState;
        /// <summary>
        /// the Encryption Type used for this Data Lake Store Account.
        /// </summary>
        public readonly string EncryptionType;
        /// <summary>
        /// are Azure Service IP's allowed through the firewall?
        /// </summary>
        public readonly string FirewallAllowAzureIps;
        /// <summary>
        /// the state of the firewall, such as `Enabled` or `Disabled`.
        /// </summary>
        public readonly string FirewallState;
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// A mapping of tags to assign to the Data Lake Store.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// Current monthly commitment tier for the account.
        /// </summary>
        public readonly string Tier;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetStoreResult(
            string encryptionState,
            string encryptionType,
            string firewallAllowAzureIps,
            string firewallState,
            string location,
            string name,
            string resourceGroupName,
            ImmutableDictionary<string, string> tags,
            string tier,
            string id)
        {
            EncryptionState = encryptionState;
            EncryptionType = encryptionType;
            FirewallAllowAzureIps = firewallAllowAzureIps;
            FirewallState = firewallState;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
            Tier = tier;
            Id = id;
        }
    }
}
