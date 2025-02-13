// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Automation
{
    /// <summary>
    /// Links an Automation Runbook and Schedule.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/automation_job_schedule.html.markdown.
    /// </summary>
    public partial class JobSchedule : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Automation Account in which the Job Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("automationAccountName")]
        public Output<string> AutomationAccountName { get; private set; } = null!;

        /// <summary>
        /// The UUID identifying the Automation Job Schedule.
        /// </summary>
        [Output("jobScheduleId")]
        public Output<string> JobScheduleId { get; private set; } = null!;

        /// <summary>
        /// A map of key/value pairs corresponding to the arguments that can be passed to the Runbook. Changing this forces a new resource to be created.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, string>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Job Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// Name of a Hybrid Worker Group the Runbook will be executed on. Changing this forces a new resource to be created.
        /// </summary>
        [Output("runOn")]
        public Output<string?> RunOn { get; private set; } = null!;

        /// <summary>
        /// The name of a Runbook to link to a Schedule. It needs to be in the same Automation Account as the Schedule and Job Schedule. Changing this forces a new resource to be created.
        /// </summary>
        [Output("runbookName")]
        public Output<string> RunbookName { get; private set; } = null!;

        [Output("scheduleName")]
        public Output<string> ScheduleName { get; private set; } = null!;


        /// <summary>
        /// Create a JobSchedule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public JobSchedule(string name, JobScheduleArgs args, CustomResourceOptions? options = null)
            : base("azure:automation/jobSchedule:JobSchedule", name, args, MakeResourceOptions(options, ""))
        {
        }

        private JobSchedule(string name, Input<string> id, JobScheduleState? state = null, CustomResourceOptions? options = null)
            : base("azure:automation/jobSchedule:JobSchedule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing JobSchedule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static JobSchedule Get(string name, Input<string> id, JobScheduleState? state = null, CustomResourceOptions? options = null)
        {
            return new JobSchedule(name, id, state, options);
        }
    }

    public sealed class JobScheduleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Automation Account in which the Job Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("automationAccountName", required: true)]
        public Input<string> AutomationAccountName { get; set; } = null!;

        /// <summary>
        /// The UUID identifying the Automation Job Schedule.
        /// </summary>
        [Input("jobScheduleId")]
        public Input<string>? JobScheduleId { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of key/value pairs corresponding to the arguments that can be passed to the Runbook. Changing this forces a new resource to be created.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which the Job Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of a Hybrid Worker Group the Runbook will be executed on. Changing this forces a new resource to be created.
        /// </summary>
        [Input("runOn")]
        public Input<string>? RunOn { get; set; }

        /// <summary>
        /// The name of a Runbook to link to a Schedule. It needs to be in the same Automation Account as the Schedule and Job Schedule. Changing this forces a new resource to be created.
        /// </summary>
        [Input("runbookName", required: true)]
        public Input<string> RunbookName { get; set; } = null!;

        [Input("scheduleName", required: true)]
        public Input<string> ScheduleName { get; set; } = null!;

        public JobScheduleArgs()
        {
        }
    }

    public sealed class JobScheduleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Automation Account in which the Job Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("automationAccountName")]
        public Input<string>? AutomationAccountName { get; set; }

        /// <summary>
        /// The UUID identifying the Automation Job Schedule.
        /// </summary>
        [Input("jobScheduleId")]
        public Input<string>? JobScheduleId { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of key/value pairs corresponding to the arguments that can be passed to the Runbook. Changing this forces a new resource to be created.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which the Job Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// Name of a Hybrid Worker Group the Runbook will be executed on. Changing this forces a new resource to be created.
        /// </summary>
        [Input("runOn")]
        public Input<string>? RunOn { get; set; }

        /// <summary>
        /// The name of a Runbook to link to a Schedule. It needs to be in the same Automation Account as the Schedule and Job Schedule. Changing this forces a new resource to be created.
        /// </summary>
        [Input("runbookName")]
        public Input<string>? RunbookName { get; set; }

        [Input("scheduleName")]
        public Input<string>? ScheduleName { get; set; }

        public JobScheduleState()
        {
        }
    }
}
