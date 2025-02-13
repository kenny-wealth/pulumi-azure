// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appservice

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an App Service Plan component.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/app_service_plan.html.markdown.
type Plan struct {
	s *pulumi.ResourceState
}

// NewPlan registers a new resource with the given unique name, arguments, and options.
func NewPlan(ctx *pulumi.Context,
	name string, args *PlanArgs, opts ...pulumi.ResourceOpt) (*Plan, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Sku == nil {
		return nil, errors.New("missing required argument 'Sku'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["appServiceEnvironmentId"] = nil
		inputs["isXenon"] = nil
		inputs["kind"] = nil
		inputs["location"] = nil
		inputs["maximumElasticWorkerCount"] = nil
		inputs["name"] = nil
		inputs["perSiteScaling"] = nil
		inputs["properties"] = nil
		inputs["reserved"] = nil
		inputs["resourceGroupName"] = nil
		inputs["sku"] = nil
		inputs["tags"] = nil
	} else {
		inputs["appServiceEnvironmentId"] = args.AppServiceEnvironmentId
		inputs["isXenon"] = args.IsXenon
		inputs["kind"] = args.Kind
		inputs["location"] = args.Location
		inputs["maximumElasticWorkerCount"] = args.MaximumElasticWorkerCount
		inputs["name"] = args.Name
		inputs["perSiteScaling"] = args.PerSiteScaling
		inputs["properties"] = args.Properties
		inputs["reserved"] = args.Reserved
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["sku"] = args.Sku
		inputs["tags"] = args.Tags
	}
	inputs["maximumNumberOfWorkers"] = nil
	s, err := ctx.RegisterResource("azure:appservice/plan:Plan", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Plan{s: s}, nil
}

// GetPlan gets an existing Plan resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPlan(ctx *pulumi.Context,
	name string, id pulumi.ID, state *PlanState, opts ...pulumi.ResourceOpt) (*Plan, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["appServiceEnvironmentId"] = state.AppServiceEnvironmentId
		inputs["isXenon"] = state.IsXenon
		inputs["kind"] = state.Kind
		inputs["location"] = state.Location
		inputs["maximumElasticWorkerCount"] = state.MaximumElasticWorkerCount
		inputs["maximumNumberOfWorkers"] = state.MaximumNumberOfWorkers
		inputs["name"] = state.Name
		inputs["perSiteScaling"] = state.PerSiteScaling
		inputs["properties"] = state.Properties
		inputs["reserved"] = state.Reserved
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["sku"] = state.Sku
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:appservice/plan:Plan", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Plan{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Plan) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Plan) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The ID of the App Service Environment where the App Service Plan should be located. Changing forces a new resource to be created.
func (r *Plan) AppServiceEnvironmentId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["appServiceEnvironmentId"])
}

func (r *Plan) IsXenon() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["isXenon"])
}

// The kind of the App Service Plan to create. Possible values are `Windows` (also available as `App`), `Linux`, `elastic` (for Premium Consumption) and `FunctionApp` (for a Consumption Plan). Defaults to `Windows`. Changing this forces a new resource to be created.
func (r *Plan) Kind() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["kind"])
}

// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
func (r *Plan) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// The maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan.
func (r *Plan) MaximumElasticWorkerCount() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["maximumElasticWorkerCount"])
}

// The maximum number of workers supported with the App Service Plan's sku.
func (r *Plan) MaximumNumberOfWorkers() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["maximumNumberOfWorkers"])
}

// Specifies the name of the App Service Plan component. Changing this forces a new resource to be created.
func (r *Plan) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Can Apps assigned to this App Service Plan be scaled independently? If set to `false` apps assigned to this plan will scale to all instances of the plan.  Defaults to `false`.
func (r *Plan) PerSiteScaling() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["perSiteScaling"])
}

func (r *Plan) Properties() *pulumi.Output {
	return r.s.State["properties"]
}

// Is this App Service Plan `Reserved`. Defaults to `false`.
func (r *Plan) Reserved() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["reserved"])
}

// The name of the resource group in which to create the App Service Plan component.
func (r *Plan) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// A `sku` block as documented below.
func (r *Plan) Sku() *pulumi.Output {
	return r.s.State["sku"]
}

// A mapping of tags to assign to the resource.
func (r *Plan) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering Plan resources.
type PlanState struct {
	// The ID of the App Service Environment where the App Service Plan should be located. Changing forces a new resource to be created.
	AppServiceEnvironmentId interface{}
	IsXenon interface{}
	// The kind of the App Service Plan to create. Possible values are `Windows` (also available as `App`), `Linux`, `elastic` (for Premium Consumption) and `FunctionApp` (for a Consumption Plan). Defaults to `Windows`. Changing this forces a new resource to be created.
	Kind interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// The maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan.
	MaximumElasticWorkerCount interface{}
	// The maximum number of workers supported with the App Service Plan's sku.
	MaximumNumberOfWorkers interface{}
	// Specifies the name of the App Service Plan component. Changing this forces a new resource to be created.
	Name interface{}
	// Can Apps assigned to this App Service Plan be scaled independently? If set to `false` apps assigned to this plan will scale to all instances of the plan.  Defaults to `false`.
	PerSiteScaling interface{}
	Properties interface{}
	// Is this App Service Plan `Reserved`. Defaults to `false`.
	Reserved interface{}
	// The name of the resource group in which to create the App Service Plan component.
	ResourceGroupName interface{}
	// A `sku` block as documented below.
	Sku interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}

// The set of arguments for constructing a Plan resource.
type PlanArgs struct {
	// The ID of the App Service Environment where the App Service Plan should be located. Changing forces a new resource to be created.
	AppServiceEnvironmentId interface{}
	IsXenon interface{}
	// The kind of the App Service Plan to create. Possible values are `Windows` (also available as `App`), `Linux`, `elastic` (for Premium Consumption) and `FunctionApp` (for a Consumption Plan). Defaults to `Windows`. Changing this forces a new resource to be created.
	Kind interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// The maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan.
	MaximumElasticWorkerCount interface{}
	// Specifies the name of the App Service Plan component. Changing this forces a new resource to be created.
	Name interface{}
	// Can Apps assigned to this App Service Plan be scaled independently? If set to `false` apps assigned to this plan will scale to all instances of the plan.  Defaults to `false`.
	PerSiteScaling interface{}
	Properties interface{}
	// Is this App Service Plan `Reserved`. Defaults to `false`.
	Reserved interface{}
	// The name of the resource group in which to create the App Service Plan component.
	ResourceGroupName interface{}
	// A `sku` block as documented below.
	Sku interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}
