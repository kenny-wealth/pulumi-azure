// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package monitoring

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a [Log Profile](https://docs.microsoft.com/en-us/azure/monitoring-and-diagnostics/monitoring-overview-activity-logs#export-the-activity-log-with-a-log-profile). A Log Profile configures how Activity Logs are exported.
// 
// > **NOTE:** It's only possible to configure one Log Profile per Subscription. If you are trying to create more than one Log Profile, an error with `StatusCode=409` will occur.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/monitor_log_profile.html.markdown.
type LogProfile struct {
	s *pulumi.ResourceState
}

// NewLogProfile registers a new resource with the given unique name, arguments, and options.
func NewLogProfile(ctx *pulumi.Context,
	name string, args *LogProfileArgs, opts ...pulumi.ResourceOpt) (*LogProfile, error) {
	if args == nil || args.Categories == nil {
		return nil, errors.New("missing required argument 'Categories'")
	}
	if args == nil || args.Locations == nil {
		return nil, errors.New("missing required argument 'Locations'")
	}
	if args == nil || args.RetentionPolicy == nil {
		return nil, errors.New("missing required argument 'RetentionPolicy'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["categories"] = nil
		inputs["locations"] = nil
		inputs["name"] = nil
		inputs["retentionPolicy"] = nil
		inputs["servicebusRuleId"] = nil
		inputs["storageAccountId"] = nil
	} else {
		inputs["categories"] = args.Categories
		inputs["locations"] = args.Locations
		inputs["name"] = args.Name
		inputs["retentionPolicy"] = args.RetentionPolicy
		inputs["servicebusRuleId"] = args.ServicebusRuleId
		inputs["storageAccountId"] = args.StorageAccountId
	}
	s, err := ctx.RegisterResource("azure:monitoring/logProfile:LogProfile", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &LogProfile{s: s}, nil
}

// GetLogProfile gets an existing LogProfile resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogProfile(ctx *pulumi.Context,
	name string, id pulumi.ID, state *LogProfileState, opts ...pulumi.ResourceOpt) (*LogProfile, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["categories"] = state.Categories
		inputs["locations"] = state.Locations
		inputs["name"] = state.Name
		inputs["retentionPolicy"] = state.RetentionPolicy
		inputs["servicebusRuleId"] = state.ServicebusRuleId
		inputs["storageAccountId"] = state.StorageAccountId
	}
	s, err := ctx.ReadResource("azure:monitoring/logProfile:LogProfile", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &LogProfile{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *LogProfile) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *LogProfile) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// List of categories of the logs.
func (r *LogProfile) Categories() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["categories"])
}

// List of regions for which Activity Log events are stored or streamed.
func (r *LogProfile) Locations() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["locations"])
}

// The name of the Log Profile. Changing this forces a
// new resource to be created.
func (r *LogProfile) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// A `retentionPolicy` block as documented below. A retention policy for how long Activity Logs are retained in the storage account.
func (r *LogProfile) RetentionPolicy() *pulumi.Output {
	return r.s.State["retentionPolicy"]
}

// The service bus (or event hub) rule ID of the service bus (or event hub) namespace in which the Activity Log is streamed to. At least one of `storageAccountId` or `servicebusRuleId` must be set.
func (r *LogProfile) ServicebusRuleId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["servicebusRuleId"])
}

// The resource ID of the storage account in which the Activity Log is stored. At least one of `storageAccountId` or `servicebusRuleId` must be set.
func (r *LogProfile) StorageAccountId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageAccountId"])
}

// Input properties used for looking up and filtering LogProfile resources.
type LogProfileState struct {
	// List of categories of the logs.
	Categories interface{}
	// List of regions for which Activity Log events are stored or streamed.
	Locations interface{}
	// The name of the Log Profile. Changing this forces a
	// new resource to be created.
	Name interface{}
	// A `retentionPolicy` block as documented below. A retention policy for how long Activity Logs are retained in the storage account.
	RetentionPolicy interface{}
	// The service bus (or event hub) rule ID of the service bus (or event hub) namespace in which the Activity Log is streamed to. At least one of `storageAccountId` or `servicebusRuleId` must be set.
	ServicebusRuleId interface{}
	// The resource ID of the storage account in which the Activity Log is stored. At least one of `storageAccountId` or `servicebusRuleId` must be set.
	StorageAccountId interface{}
}

// The set of arguments for constructing a LogProfile resource.
type LogProfileArgs struct {
	// List of categories of the logs.
	Categories interface{}
	// List of regions for which Activity Log events are stored or streamed.
	Locations interface{}
	// The name of the Log Profile. Changing this forces a
	// new resource to be created.
	Name interface{}
	// A `retentionPolicy` block as documented below. A retention policy for how long Activity Logs are retained in the storage account.
	RetentionPolicy interface{}
	// The service bus (or event hub) rule ID of the service bus (or event hub) namespace in which the Activity Log is streamed to. At least one of `storageAccountId` or `servicebusRuleId` must be set.
	ServicebusRuleId interface{}
	// The resource ID of the storage account in which the Activity Log is stored. At least one of `storageAccountId` or `servicebusRuleId` must be set.
	StorageAccountId interface{}
}
