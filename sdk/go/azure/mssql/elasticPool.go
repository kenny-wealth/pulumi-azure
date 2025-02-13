// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mssql

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Allows you to manage an Azure SQL Elastic Pool via the `2017-10-01-preview` API which allows for `vCore` and `DTU` based configurations.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/mssql_elasticpool.html.markdown.
type ElasticPool struct {
	s *pulumi.ResourceState
}

// NewElasticPool registers a new resource with the given unique name, arguments, and options.
func NewElasticPool(ctx *pulumi.Context,
	name string, args *ElasticPoolArgs, opts ...pulumi.ResourceOpt) (*ElasticPool, error) {
	if args == nil || args.PerDatabaseSettings == nil {
		return nil, errors.New("missing required argument 'PerDatabaseSettings'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	if args == nil || args.Sku == nil {
		return nil, errors.New("missing required argument 'Sku'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["location"] = nil
		inputs["maxSizeBytes"] = nil
		inputs["maxSizeGb"] = nil
		inputs["name"] = nil
		inputs["perDatabaseSettings"] = nil
		inputs["resourceGroupName"] = nil
		inputs["serverName"] = nil
		inputs["sku"] = nil
		inputs["tags"] = nil
		inputs["zoneRedundant"] = nil
	} else {
		inputs["location"] = args.Location
		inputs["maxSizeBytes"] = args.MaxSizeBytes
		inputs["maxSizeGb"] = args.MaxSizeGb
		inputs["name"] = args.Name
		inputs["perDatabaseSettings"] = args.PerDatabaseSettings
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["serverName"] = args.ServerName
		inputs["sku"] = args.Sku
		inputs["tags"] = args.Tags
		inputs["zoneRedundant"] = args.ZoneRedundant
	}
	inputs["elasticPoolProperties"] = nil
	s, err := ctx.RegisterResource("azure:mssql/elasticPool:ElasticPool", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ElasticPool{s: s}, nil
}

// GetElasticPool gets an existing ElasticPool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetElasticPool(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ElasticPoolState, opts ...pulumi.ResourceOpt) (*ElasticPool, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["elasticPoolProperties"] = state.ElasticPoolProperties
		inputs["location"] = state.Location
		inputs["maxSizeBytes"] = state.MaxSizeBytes
		inputs["maxSizeGb"] = state.MaxSizeGb
		inputs["name"] = state.Name
		inputs["perDatabaseSettings"] = state.PerDatabaseSettings
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["serverName"] = state.ServerName
		inputs["sku"] = state.Sku
		inputs["tags"] = state.Tags
		inputs["zoneRedundant"] = state.ZoneRedundant
	}
	s, err := ctx.ReadResource("azure:mssql/elasticPool:ElasticPool", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ElasticPool{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ElasticPool) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ElasticPool) ID() *pulumi.IDOutput {
	return r.s.ID()
}

func (r *ElasticPool) ElasticPoolProperties() *pulumi.Output {
	return r.s.State["elasticPoolProperties"]
}

// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
func (r *ElasticPool) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// The max data size of the elastic pool in bytes. Conflicts with `maxSizeGb`.
func (r *ElasticPool) MaxSizeBytes() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["maxSizeBytes"])
}

// The max data size of the elastic pool in gigabytes. Conflicts with `maxSizeBytes`. 
func (r *ElasticPool) MaxSizeGb() *pulumi.Float64Output {
	return (*pulumi.Float64Output)(r.s.State["maxSizeGb"])
}

// Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
func (r *ElasticPool) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// A `perDatabaseSettings` block as defined below.
func (r *ElasticPool) PerDatabaseSettings() *pulumi.Output {
	return r.s.State["perDatabaseSettings"]
}

// The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
func (r *ElasticPool) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
func (r *ElasticPool) ServerName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["serverName"])
}

// A `sku` block as defined below.
func (r *ElasticPool) Sku() *pulumi.Output {
	return r.s.State["sku"]
}

// A mapping of tags to assign to the resource.
func (r *ElasticPool) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
func (r *ElasticPool) ZoneRedundant() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["zoneRedundant"])
}

// Input properties used for looking up and filtering ElasticPool resources.
type ElasticPoolState struct {
	ElasticPoolProperties interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// The max data size of the elastic pool in bytes. Conflicts with `maxSizeGb`.
	MaxSizeBytes interface{}
	// The max data size of the elastic pool in gigabytes. Conflicts with `maxSizeBytes`. 
	MaxSizeGb interface{}
	// Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
	Name interface{}
	// A `perDatabaseSettings` block as defined below.
	PerDatabaseSettings interface{}
	// The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
	ResourceGroupName interface{}
	// The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
	ServerName interface{}
	// A `sku` block as defined below.
	Sku interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
	ZoneRedundant interface{}
}

// The set of arguments for constructing a ElasticPool resource.
type ElasticPoolArgs struct {
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// The max data size of the elastic pool in bytes. Conflicts with `maxSizeGb`.
	MaxSizeBytes interface{}
	// The max data size of the elastic pool in gigabytes. Conflicts with `maxSizeBytes`. 
	MaxSizeGb interface{}
	// Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
	Name interface{}
	// A `perDatabaseSettings` block as defined below.
	PerDatabaseSettings interface{}
	// The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
	ResourceGroupName interface{}
	// The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
	ServerName interface{}
	// A `sku` block as defined below.
	Sku interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
	ZoneRedundant interface{}
}
