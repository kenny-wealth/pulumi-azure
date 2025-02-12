// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mediaservices

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Media Services Account.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/media_services_account.html.markdown.
type Account struct {
	s *pulumi.ResourceState
}

// NewAccount registers a new resource with the given unique name, arguments, and options.
func NewAccount(ctx *pulumi.Context,
	name string, args *AccountArgs, opts ...pulumi.ResourceOpt) (*Account, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.StorageAccounts == nil {
		return nil, errors.New("missing required argument 'StorageAccounts'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["storageAccounts"] = nil
	} else {
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["storageAccounts"] = args.StorageAccounts
	}
	s, err := ctx.RegisterResource("azure:mediaservices/account:Account", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Account{s: s}, nil
}

// GetAccount gets an existing Account resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAccount(ctx *pulumi.Context,
	name string, id pulumi.ID, state *AccountState, opts ...pulumi.ResourceOpt) (*Account, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["storageAccounts"] = state.StorageAccounts
	}
	s, err := ctx.ReadResource("azure:mediaservices/account:Account", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Account{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Account) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Account) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
func (r *Account) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
func (r *Account) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
func (r *Account) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// One or more `storageAccount` blocks as defined below.
func (r *Account) StorageAccounts() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["storageAccounts"])
}

// Input properties used for looking up and filtering Account resources.
type AccountState struct {
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
	Name interface{}
	// The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// One or more `storageAccount` blocks as defined below.
	StorageAccounts interface{}
}

// The set of arguments for constructing a Account resource.
type AccountArgs struct {
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
	Name interface{}
	// The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// One or more `storageAccount` blocks as defined below.
	StorageAccounts interface{}
}
