// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Automation
{
    /// <summary>
    /// Manages a Automation Schedule.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/automation_schedule.html.markdown.
    /// </summary>
    public partial class Schedule : Pulumi.CustomResource
    {
        [Output("accountName")]
        public Output<string> AccountName { get; private set; } = null!;

        /// <summary>
        /// The name of the automation account in which the Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("automationAccountName")]
        public Output<string> AutomationAccountName { get; private set; } = null!;

        /// <summary>
        /// A description for this Schedule.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The end time of the schedule.
        /// </summary>
        [Output("expiryTime")]
        public Output<string> ExpiryTime { get; private set; } = null!;

        /// <summary>
        /// The frequency of the schedule. - can be either `OneTime`, `Day`, `Hour`, `Week`, or `Month`.
        /// </summary>
        [Output("frequency")]
        public Output<string> Frequency { get; private set; } = null!;

        /// <summary>
        /// The number of `frequency`s between runs. Only valid when frequency is `Day`, `Hour`, `Week`, or `Month` and defaults to `1`.
        /// </summary>
        [Output("interval")]
        public Output<int> Interval { get; private set; } = null!;

        /// <summary>
        /// List of days of the month that the job should execute on. Must be between `1` and `31`. `-1` for last day of the month. Only valid when frequency is `Month`.
        /// </summary>
        [Output("monthDays")]
        public Output<ImmutableArray<int>> MonthDays { get; private set; } = null!;

        /// <summary>
        /// List of occurrences of days within a month. Only valid when frequency is `Month`. The `monthly_occurrence` block supports fields documented below.
        /// </summary>
        [Output("monthlyOccurrences")]
        public Output<ImmutableArray<Outputs.ScheduleMonthlyOccurrences>> MonthlyOccurrences { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Schedule. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// Start time of the schedule. Must be at least five minutes in the future. Defaults to seven minutes in the future from the time the resource is created.
        /// </summary>
        [Output("startTime")]
        public Output<string> StartTime { get; private set; } = null!;

        /// <summary>
        /// The timezone of the start time. Defaults to `UTC`. For possible values see: https://msdn.microsoft.com/en-us/library/ms912391(v=winembedded.11).aspx
        /// </summary>
        [Output("timezone")]
        public Output<string?> Timezone { get; private set; } = null!;

        /// <summary>
        /// List of days of the week that the job should execute on. Only valid when frequency is `Week`.
        /// </summary>
        [Output("weekDays")]
        public Output<ImmutableArray<string>> WeekDays { get; private set; } = null!;


        /// <summary>
        /// Create a Schedule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Schedule(string name, ScheduleArgs args, CustomResourceOptions? options = null)
            : base("azure:automation/schedule:Schedule", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Schedule(string name, Input<string> id, ScheduleState? state = null, CustomResourceOptions? options = null)
            : base("azure:automation/schedule:Schedule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Schedule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Schedule Get(string name, Input<string> id, ScheduleState? state = null, CustomResourceOptions? options = null)
        {
            return new Schedule(name, id, state, options);
        }
    }

    public sealed class ScheduleArgs : Pulumi.ResourceArgs
    {
        [Input("accountName")]
        public Input<string>? AccountName { get; set; }

        /// <summary>
        /// The name of the automation account in which the Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("automationAccountName")]
        public Input<string>? AutomationAccountName { get; set; }

        /// <summary>
        /// A description for this Schedule.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The end time of the schedule.
        /// </summary>
        [Input("expiryTime")]
        public Input<string>? ExpiryTime { get; set; }

        /// <summary>
        /// The frequency of the schedule. - can be either `OneTime`, `Day`, `Hour`, `Week`, or `Month`.
        /// </summary>
        [Input("frequency", required: true)]
        public Input<string> Frequency { get; set; } = null!;

        /// <summary>
        /// The number of `frequency`s between runs. Only valid when frequency is `Day`, `Hour`, `Week`, or `Month` and defaults to `1`.
        /// </summary>
        [Input("interval")]
        public Input<int>? Interval { get; set; }

        [Input("monthDays")]
        private InputList<int>? _monthDays;

        /// <summary>
        /// List of days of the month that the job should execute on. Must be between `1` and `31`. `-1` for last day of the month. Only valid when frequency is `Month`.
        /// </summary>
        public InputList<int> MonthDays
        {
            get => _monthDays ?? (_monthDays = new InputList<int>());
            set => _monthDays = value;
        }

        [Input("monthlyOccurrences")]
        private InputList<Inputs.ScheduleMonthlyOccurrencesArgs>? _monthlyOccurrences;

        /// <summary>
        /// List of occurrences of days within a month. Only valid when frequency is `Month`. The `monthly_occurrence` block supports fields documented below.
        /// </summary>
        public InputList<Inputs.ScheduleMonthlyOccurrencesArgs> MonthlyOccurrences
        {
            get => _monthlyOccurrences ?? (_monthlyOccurrences = new InputList<Inputs.ScheduleMonthlyOccurrencesArgs>());
            set => _monthlyOccurrences = value;
        }

        /// <summary>
        /// Specifies the name of the Schedule. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Start time of the schedule. Must be at least five minutes in the future. Defaults to seven minutes in the future from the time the resource is created.
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        /// <summary>
        /// The timezone of the start time. Defaults to `UTC`. For possible values see: https://msdn.microsoft.com/en-us/library/ms912391(v=winembedded.11).aspx
        /// </summary>
        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        [Input("weekDays")]
        private InputList<string>? _weekDays;

        /// <summary>
        /// List of days of the week that the job should execute on. Only valid when frequency is `Week`.
        /// </summary>
        public InputList<string> WeekDays
        {
            get => _weekDays ?? (_weekDays = new InputList<string>());
            set => _weekDays = value;
        }

        public ScheduleArgs()
        {
        }
    }

    public sealed class ScheduleState : Pulumi.ResourceArgs
    {
        [Input("accountName")]
        public Input<string>? AccountName { get; set; }

        /// <summary>
        /// The name of the automation account in which the Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("automationAccountName")]
        public Input<string>? AutomationAccountName { get; set; }

        /// <summary>
        /// A description for this Schedule.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The end time of the schedule.
        /// </summary>
        [Input("expiryTime")]
        public Input<string>? ExpiryTime { get; set; }

        /// <summary>
        /// The frequency of the schedule. - can be either `OneTime`, `Day`, `Hour`, `Week`, or `Month`.
        /// </summary>
        [Input("frequency")]
        public Input<string>? Frequency { get; set; }

        /// <summary>
        /// The number of `frequency`s between runs. Only valid when frequency is `Day`, `Hour`, `Week`, or `Month` and defaults to `1`.
        /// </summary>
        [Input("interval")]
        public Input<int>? Interval { get; set; }

        [Input("monthDays")]
        private InputList<int>? _monthDays;

        /// <summary>
        /// List of days of the month that the job should execute on. Must be between `1` and `31`. `-1` for last day of the month. Only valid when frequency is `Month`.
        /// </summary>
        public InputList<int> MonthDays
        {
            get => _monthDays ?? (_monthDays = new InputList<int>());
            set => _monthDays = value;
        }

        [Input("monthlyOccurrences")]
        private InputList<Inputs.ScheduleMonthlyOccurrencesGetArgs>? _monthlyOccurrences;

        /// <summary>
        /// List of occurrences of days within a month. Only valid when frequency is `Month`. The `monthly_occurrence` block supports fields documented below.
        /// </summary>
        public InputList<Inputs.ScheduleMonthlyOccurrencesGetArgs> MonthlyOccurrences
        {
            get => _monthlyOccurrences ?? (_monthlyOccurrences = new InputList<Inputs.ScheduleMonthlyOccurrencesGetArgs>());
            set => _monthlyOccurrences = value;
        }

        /// <summary>
        /// Specifies the name of the Schedule. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the Schedule is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// Start time of the schedule. Must be at least five minutes in the future. Defaults to seven minutes in the future from the time the resource is created.
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        /// <summary>
        /// The timezone of the start time. Defaults to `UTC`. For possible values see: https://msdn.microsoft.com/en-us/library/ms912391(v=winembedded.11).aspx
        /// </summary>
        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        [Input("weekDays")]
        private InputList<string>? _weekDays;

        /// <summary>
        /// List of days of the week that the job should execute on. Only valid when frequency is `Week`.
        /// </summary>
        public InputList<string> WeekDays
        {
            get => _weekDays ?? (_weekDays = new InputList<string>());
            set => _weekDays = value;
        }

        public ScheduleState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ScheduleMonthlyOccurrencesArgs : Pulumi.ResourceArgs
    {
        [Input("day", required: true)]
        public Input<string> Day { get; set; } = null!;

        [Input("occurrence", required: true)]
        public Input<int> Occurrence { get; set; } = null!;

        public ScheduleMonthlyOccurrencesArgs()
        {
        }
    }

    public sealed class ScheduleMonthlyOccurrencesGetArgs : Pulumi.ResourceArgs
    {
        [Input("day", required: true)]
        public Input<string> Day { get; set; } = null!;

        [Input("occurrence", required: true)]
        public Input<int> Occurrence { get; set; } = null!;

        public ScheduleMonthlyOccurrencesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ScheduleMonthlyOccurrences
    {
        public readonly string Day;
        public readonly int Occurrence;

        [OutputConstructor]
        private ScheduleMonthlyOccurrences(
            string day,
            int occurrence)
        {
            Day = day;
            Occurrence = occurrence;
        }
    }
    }
}
