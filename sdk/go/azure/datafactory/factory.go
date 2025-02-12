// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datafactory

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an Azure Data Factory (Version 2).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/data_factory.html.markdown.
type Factory struct {
	s *pulumi.ResourceState
}

// NewFactory registers a new resource with the given unique name, arguments, and options.
func NewFactory(ctx *pulumi.Context,
	name string, args *FactoryArgs, opts ...pulumi.ResourceOpt) (*Factory, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["githubConfiguration"] = nil
		inputs["identity"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["tags"] = nil
		inputs["vstsConfiguration"] = nil
	} else {
		inputs["githubConfiguration"] = args.GithubConfiguration
		inputs["identity"] = args.Identity
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["tags"] = args.Tags
		inputs["vstsConfiguration"] = args.VstsConfiguration
	}
	s, err := ctx.RegisterResource("azure:datafactory/factory:Factory", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Factory{s: s}, nil
}

// GetFactory gets an existing Factory resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFactory(ctx *pulumi.Context,
	name string, id pulumi.ID, state *FactoryState, opts ...pulumi.ResourceOpt) (*Factory, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["githubConfiguration"] = state.GithubConfiguration
		inputs["identity"] = state.Identity
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["tags"] = state.Tags
		inputs["vstsConfiguration"] = state.VstsConfiguration
	}
	s, err := ctx.ReadResource("azure:datafactory/factory:Factory", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Factory{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Factory) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Factory) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A `githubConfiguration` block as defined below.
func (r *Factory) GithubConfiguration() *pulumi.Output {
	return r.s.State["githubConfiguration"]
}

// An `identity` block as defined below.
func (r *Factory) Identity() *pulumi.Output {
	return r.s.State["identity"]
}

// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
func (r *Factory) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// Specifies the name of the Data Factory. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
func (r *Factory) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The name of the resource group in which to create the Data Factory.
func (r *Factory) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// A mapping of tags to assign to the resource.
func (r *Factory) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// A `vstsConfiguration` block as defined below.
func (r *Factory) VstsConfiguration() *pulumi.Output {
	return r.s.State["vstsConfiguration"]
}

// Input properties used for looking up and filtering Factory resources.
type FactoryState struct {
	// A `githubConfiguration` block as defined below.
	GithubConfiguration interface{}
	// An `identity` block as defined below.
	Identity interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the Data Factory. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
	Name interface{}
	// The name of the resource group in which to create the Data Factory.
	ResourceGroupName interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// A `vstsConfiguration` block as defined below.
	VstsConfiguration interface{}
}

// The set of arguments for constructing a Factory resource.
type FactoryArgs struct {
	// A `githubConfiguration` block as defined below.
	GithubConfiguration interface{}
	// An `identity` block as defined below.
	Identity interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the Data Factory. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
	Name interface{}
	// The name of the resource group in which to create the Data Factory.
	ResourceGroupName interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// A `vstsConfiguration` block as defined below.
	VstsConfiguration interface{}
}
