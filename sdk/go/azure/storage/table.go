// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package storage

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Table within an Azure Storage Account.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/storage_table.html.markdown.
type Table struct {
	s *pulumi.ResourceState
}

// NewTable registers a new resource with the given unique name, arguments, and options.
func NewTable(ctx *pulumi.Context,
	name string, args *TableArgs, opts ...pulumi.ResourceOpt) (*Table, error) {
	if args == nil || args.StorageAccountName == nil {
		return nil, errors.New("missing required argument 'StorageAccountName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["acls"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["storageAccountName"] = nil
	} else {
		inputs["acls"] = args.Acls
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["storageAccountName"] = args.StorageAccountName
	}
	s, err := ctx.RegisterResource("azure:storage/table:Table", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Table{s: s}, nil
}

// GetTable gets an existing Table resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTable(ctx *pulumi.Context,
	name string, id pulumi.ID, state *TableState, opts ...pulumi.ResourceOpt) (*Table, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["acls"] = state.Acls
		inputs["name"] = state.Name
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["storageAccountName"] = state.StorageAccountName
	}
	s, err := ctx.ReadResource("azure:storage/table:Table", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Table{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Table) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Table) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// One or more `acl` blocks as defined below.
func (r *Table) Acls() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["acls"])
}

// The name of the storage table. Must be unique within the storage account the table is located.
func (r *Table) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The name of the resource group in which to create the storage table.
func (r *Table) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// Specifies the storage account in which to create the storage table.
// Changing this forces a new resource to be created.
func (r *Table) StorageAccountName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageAccountName"])
}

// Input properties used for looking up and filtering Table resources.
type TableState struct {
	// One or more `acl` blocks as defined below.
	Acls interface{}
	// The name of the storage table. Must be unique within the storage account the table is located.
	Name interface{}
	// The name of the resource group in which to create the storage table.
	ResourceGroupName interface{}
	// Specifies the storage account in which to create the storage table.
	// Changing this forces a new resource to be created.
	StorageAccountName interface{}
}

// The set of arguments for constructing a Table resource.
type TableArgs struct {
	// One or more `acl` blocks as defined below.
	Acls interface{}
	// The name of the storage table. Must be unique within the storage account the table is located.
	Name interface{}
	// The name of the resource group in which to create the storage table.
	ResourceGroupName interface{}
	// Specifies the storage account in which to create the storage table.
	// Changing this forces a new resource to be created.
	StorageAccountName interface{}
}
