// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package notificationhub

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Notification Hub within a Notification Hub Namespace.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/notification_hub.html.markdown.
type Hub struct {
	s *pulumi.ResourceState
}

// NewHub registers a new resource with the given unique name, arguments, and options.
func NewHub(ctx *pulumi.Context,
	name string, args *HubArgs, opts ...pulumi.ResourceOpt) (*Hub, error) {
	if args == nil || args.NamespaceName == nil {
		return nil, errors.New("missing required argument 'NamespaceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["apnsCredential"] = nil
		inputs["gcmCredential"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["namespaceName"] = nil
		inputs["resourceGroupName"] = nil
	} else {
		inputs["apnsCredential"] = args.ApnsCredential
		inputs["gcmCredential"] = args.GcmCredential
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["namespaceName"] = args.NamespaceName
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	s, err := ctx.RegisterResource("azure:notificationhub/hub:Hub", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Hub{s: s}, nil
}

// GetHub gets an existing Hub resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHub(ctx *pulumi.Context,
	name string, id pulumi.ID, state *HubState, opts ...pulumi.ResourceOpt) (*Hub, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["apnsCredential"] = state.ApnsCredential
		inputs["gcmCredential"] = state.GcmCredential
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["namespaceName"] = state.NamespaceName
		inputs["resourceGroupName"] = state.ResourceGroupName
	}
	s, err := ctx.ReadResource("azure:notificationhub/hub:Hub", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Hub{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Hub) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Hub) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A `apnsCredential` block as defined below.
func (r *Hub) ApnsCredential() *pulumi.Output {
	return r.s.State["apnsCredential"]
}

// A `gcmCredential` block as defined below.
func (r *Hub) GcmCredential() *pulumi.Output {
	return r.s.State["gcmCredential"]
}

// The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.
func (r *Hub) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// The name to use for this Notification Hub. Changing this forces a new resource to be created.
func (r *Hub) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The name of the Notification Hub Namespace in which to create this Notification Hub. Changing this forces a new resource to be created.
func (r *Hub) NamespaceName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["namespaceName"])
}

// The name of the Resource Group in which the Notification Hub Namespace exists. Changing this forces a new resource to be created.
func (r *Hub) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// Input properties used for looking up and filtering Hub resources.
type HubState struct {
	// A `apnsCredential` block as defined below.
	ApnsCredential interface{}
	// A `gcmCredential` block as defined below.
	GcmCredential interface{}
	// The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.
	Location interface{}
	// The name to use for this Notification Hub. Changing this forces a new resource to be created.
	Name interface{}
	// The name of the Notification Hub Namespace in which to create this Notification Hub. Changing this forces a new resource to be created.
	NamespaceName interface{}
	// The name of the Resource Group in which the Notification Hub Namespace exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
}

// The set of arguments for constructing a Hub resource.
type HubArgs struct {
	// A `apnsCredential` block as defined below.
	ApnsCredential interface{}
	// A `gcmCredential` block as defined below.
	GcmCredential interface{}
	// The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.
	Location interface{}
	// The name to use for this Notification Hub. Changing this forces a new resource to be created.
	Name interface{}
	// The name of the Notification Hub Namespace in which to create this Notification Hub. Changing this forces a new resource to be created.
	NamespaceName interface{}
	// The name of the Resource Group in which the Notification Hub Namespace exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
}
