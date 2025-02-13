// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package eventhub

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an EventGrid Topic
// 
// > **Note:** at this time EventGrid Topic's are only available in a limited number of regions.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/eventgrid_topic_legacy.html.markdown.
type EventGridTopic struct {
	s *pulumi.ResourceState
}

// NewEventGridTopic registers a new resource with the given unique name, arguments, and options.
func NewEventGridTopic(ctx *pulumi.Context,
	name string, args *EventGridTopicArgs, opts ...pulumi.ResourceOpt) (*EventGridTopic, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["tags"] = nil
	} else {
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["tags"] = args.Tags
	}
	inputs["endpoint"] = nil
	inputs["primaryAccessKey"] = nil
	inputs["secondaryAccessKey"] = nil
	s, err := ctx.RegisterResource("azure:eventhub/eventGridTopic:EventGridTopic", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &EventGridTopic{s: s}, nil
}

// GetEventGridTopic gets an existing EventGridTopic resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEventGridTopic(ctx *pulumi.Context,
	name string, id pulumi.ID, state *EventGridTopicState, opts ...pulumi.ResourceOpt) (*EventGridTopic, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["endpoint"] = state.Endpoint
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["primaryAccessKey"] = state.PrimaryAccessKey
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["secondaryAccessKey"] = state.SecondaryAccessKey
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:eventhub/eventGridTopic:EventGridTopic", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &EventGridTopic{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *EventGridTopic) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *EventGridTopic) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The Endpoint associated with the EventGrid Topic.
func (r *EventGridTopic) Endpoint() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["endpoint"])
}

// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
func (r *EventGridTopic) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// Specifies the name of the EventGrid Topic resource. Changing this forces a new resource to be created.
func (r *EventGridTopic) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The Primary Shared Access Key associated with the EventGrid Topic.
func (r *EventGridTopic) PrimaryAccessKey() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["primaryAccessKey"])
}

// The name of the resource group in which the EventGrid Topic exists. Changing this forces a new resource to be created.
func (r *EventGridTopic) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// The Secondary Shared Access Key associated with the EventGrid Topic.
func (r *EventGridTopic) SecondaryAccessKey() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["secondaryAccessKey"])
}

// A mapping of tags to assign to the resource.
func (r *EventGridTopic) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering EventGridTopic resources.
type EventGridTopicState struct {
	// The Endpoint associated with the EventGrid Topic.
	Endpoint interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the EventGrid Topic resource. Changing this forces a new resource to be created.
	Name interface{}
	// The Primary Shared Access Key associated with the EventGrid Topic.
	PrimaryAccessKey interface{}
	// The name of the resource group in which the EventGrid Topic exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// The Secondary Shared Access Key associated with the EventGrid Topic.
	SecondaryAccessKey interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}

// The set of arguments for constructing a EventGridTopic resource.
type EventGridTopicArgs struct {
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the EventGrid Topic resource. Changing this forces a new resource to be created.
	Name interface{}
	// The name of the resource group in which the EventGrid Topic exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}
