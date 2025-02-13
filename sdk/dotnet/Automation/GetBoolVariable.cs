// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Automation
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Automation Bool Variable.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/automation_variable_bool.html.markdown.
        /// </summary>
        public static Task<GetBoolVariableResult> GetBoolVariable(GetBoolVariableArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBoolVariableResult>("azure:automation/getBoolVariable:getBoolVariable", args, options.WithVersion());
    }

    public sealed class GetBoolVariableArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the automation account in which the Automation Variable exists.
        /// </summary>
        [Input("automationAccountName", required: true)]
        public Input<string> AutomationAccountName { get; set; } = null!;

        /// <summary>
        /// The name of the Automation Variable.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where the automation account exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetBoolVariableArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetBoolVariableResult
    {
        public readonly string AutomationAccountName;
        /// <summary>
        /// The description of the Automation Variable.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Specifies if the Automation Variable is encrypted. Defaults to `false`.
        /// </summary>
        public readonly bool Encrypted;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The value of the Automation Variable as a `boolean`.
        /// </summary>
        public readonly bool Value;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetBoolVariableResult(
            string automationAccountName,
            string description,
            bool encrypted,
            string name,
            string resourceGroupName,
            bool value,
            string id)
        {
            AutomationAccountName = automationAccountName;
            Description = description;
            Encrypted = encrypted;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Value = value;
            Id = id;
        }
    }
}
