// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Scheduler
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Scheduler Job Collection.
        /// 
        /// &gt; **NOTE:** Support for Scheduler Job Collections has been deprecated by Microsoft in favour of Logic Apps ([more information can be found at this link](https://docs.microsoft.com/en-us/azure/scheduler/migrate-from-scheduler-to-logic-apps)) - as such we plan to remove support for this data source as a part of version 2.0 of the AzureRM Provider.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/scheduler_job_collection.html.markdown.
        /// </summary>
        public static Task<GetJobCollectionResult> GetJobCollection(GetJobCollectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetJobCollectionResult>("azure:scheduler/getJobCollection:getJobCollection", args, options.WithVersion());
    }

    public sealed class GetJobCollectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Scheduler Job Collection.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the resource group in which the Scheduler Job Collection resides.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetJobCollectionArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetJobCollectionResult
    {
        /// <summary>
        /// The Azure location where the resource exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        /// <summary>
        /// The Job collection quotas as documented in the `quota` block below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetJobCollectionQuotasResult> Quotas;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The Job Collection's pricing level's SKU.
        /// </summary>
        public readonly string Sku;
        /// <summary>
        /// The Job Collection's state.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// A mapping of tags assigned to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetJobCollectionResult(
            string location,
            string name,
            ImmutableArray<Outputs.GetJobCollectionQuotasResult> quotas,
            string resourceGroupName,
            string sku,
            string state,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            Location = location;
            Name = name;
            Quotas = quotas;
            ResourceGroupName = resourceGroupName;
            Sku = sku;
            State = state;
            Tags = tags;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetJobCollectionQuotasResult
    {
        /// <summary>
        /// Sets the maximum number of jobs in the collection.
        /// </summary>
        public readonly int MaxJobCount;
        /// <summary>
        /// The maximum frequency of recurrence.
        /// </summary>
        public readonly string MaxRecurrenceFrequency;
        public readonly int MaxRecurrenceInterval;
        /// <summary>
        /// The maximum interval between retries.
        /// </summary>
        public readonly int MaxRetryInterval;

        [OutputConstructor]
        private GetJobCollectionQuotasResult(
            int maxJobCount,
            string maxRecurrenceFrequency,
            int maxRecurrenceInterval,
            int maxRetryInterval)
        {
            MaxJobCount = maxJobCount;
            MaxRecurrenceFrequency = maxRecurrenceFrequency;
            MaxRecurrenceInterval = maxRecurrenceInterval;
            MaxRetryInterval = maxRetryInterval;
        }
    }
    }
}
