// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package storage

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an Azure Storage Account Management Policy.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/storage_management_policy.html.markdown.
type ManagementPolicy struct {
	s *pulumi.ResourceState
}

// NewManagementPolicy registers a new resource with the given unique name, arguments, and options.
func NewManagementPolicy(ctx *pulumi.Context,
	name string, args *ManagementPolicyArgs, opts ...pulumi.ResourceOpt) (*ManagementPolicy, error) {
	if args == nil || args.StorageAccountId == nil {
		return nil, errors.New("missing required argument 'StorageAccountId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["rules"] = nil
		inputs["storageAccountId"] = nil
	} else {
		inputs["rules"] = args.Rules
		inputs["storageAccountId"] = args.StorageAccountId
	}
	s, err := ctx.RegisterResource("azure:storage/managementPolicy:ManagementPolicy", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ManagementPolicy{s: s}, nil
}

// GetManagementPolicy gets an existing ManagementPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagementPolicy(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ManagementPolicyState, opts ...pulumi.ResourceOpt) (*ManagementPolicy, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["rules"] = state.Rules
		inputs["storageAccountId"] = state.StorageAccountId
	}
	s, err := ctx.ReadResource("azure:storage/managementPolicy:ManagementPolicy", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ManagementPolicy{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ManagementPolicy) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ManagementPolicy) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A `rule` block as documented below.
func (r *ManagementPolicy) Rules() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["rules"])
}

// Specifies the id of the storage account to apply the management policy to.
func (r *ManagementPolicy) StorageAccountId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageAccountId"])
}

// Input properties used for looking up and filtering ManagementPolicy resources.
type ManagementPolicyState struct {
	// A `rule` block as documented below.
	Rules interface{}
	// Specifies the id of the storage account to apply the management policy to.
	StorageAccountId interface{}
}

// The set of arguments for constructing a ManagementPolicy resource.
type ManagementPolicyArgs struct {
	// A `rule` block as documented below.
	Rules interface{}
	// Specifies the id of the storage account to apply the management policy to.
	StorageAccountId interface{}
}
