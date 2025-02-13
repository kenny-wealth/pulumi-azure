// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Monitoring
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about the Monitor Diagnostics Categories supported by an existing Resource.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/monitor_diagnostic_categories.html.markdown.
        /// </summary>
        public static Task<GetDiagnosticCategoriesResult> GetDiagnosticCategories(GetDiagnosticCategoriesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDiagnosticCategoriesResult>("azure:monitoring/getDiagnosticCategories:getDiagnosticCategories", args, options.WithVersion());
    }

    public sealed class GetDiagnosticCategoriesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of an existing Resource which Monitor Diagnostics Categories should be retrieved for.
        /// </summary>
        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        public GetDiagnosticCategoriesArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetDiagnosticCategoriesResult
    {
        /// <summary>
        /// A list of the Log Categories supported for this Resource.
        /// </summary>
        public readonly ImmutableArray<string> Logs;
        /// <summary>
        /// A list of the Metric Categories supported for this Resource.
        /// </summary>
        public readonly ImmutableArray<string> Metrics;
        public readonly string ResourceId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetDiagnosticCategoriesResult(
            ImmutableArray<string> logs,
            ImmutableArray<string> metrics,
            string resourceId,
            string id)
        {
            Logs = logs;
            Metrics = metrics;
            ResourceId = resourceId;
            Id = id;
        }
    }
}
