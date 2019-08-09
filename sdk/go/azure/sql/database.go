// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sql

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Allows you to manage an Azure SQL Database
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/sql_database.html.markdown.
type Database struct {
	s *pulumi.ResourceState
}

// NewDatabase registers a new resource with the given unique name, arguments, and options.
func NewDatabase(ctx *pulumi.Context,
	name string, args *DatabaseArgs, opts ...pulumi.ResourceOpt) (*Database, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["collation"] = nil
		inputs["createMode"] = nil
		inputs["edition"] = nil
		inputs["elasticPoolName"] = nil
		inputs["import"] = nil
		inputs["location"] = nil
		inputs["maxSizeBytes"] = nil
		inputs["name"] = nil
		inputs["readScale"] = nil
		inputs["requestedServiceObjectiveId"] = nil
		inputs["requestedServiceObjectiveName"] = nil
		inputs["resourceGroupName"] = nil
		inputs["restorePointInTime"] = nil
		inputs["serverName"] = nil
		inputs["sourceDatabaseDeletionDate"] = nil
		inputs["sourceDatabaseId"] = nil
		inputs["tags"] = nil
		inputs["threatDetectionPolicy"] = nil
	} else {
		inputs["collation"] = args.Collation
		inputs["createMode"] = args.CreateMode
		inputs["edition"] = args.Edition
		inputs["elasticPoolName"] = args.ElasticPoolName
		inputs["import"] = args.Import
		inputs["location"] = args.Location
		inputs["maxSizeBytes"] = args.MaxSizeBytes
		inputs["name"] = args.Name
		inputs["readScale"] = args.ReadScale
		inputs["requestedServiceObjectiveId"] = args.RequestedServiceObjectiveId
		inputs["requestedServiceObjectiveName"] = args.RequestedServiceObjectiveName
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["restorePointInTime"] = args.RestorePointInTime
		inputs["serverName"] = args.ServerName
		inputs["sourceDatabaseDeletionDate"] = args.SourceDatabaseDeletionDate
		inputs["sourceDatabaseId"] = args.SourceDatabaseId
		inputs["tags"] = args.Tags
		inputs["threatDetectionPolicy"] = args.ThreatDetectionPolicy
	}
	inputs["creationDate"] = nil
	inputs["defaultSecondaryLocation"] = nil
	inputs["encryption"] = nil
	s, err := ctx.RegisterResource("azure:sql/database:Database", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Database{s: s}, nil
}

// GetDatabase gets an existing Database resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabase(ctx *pulumi.Context,
	name string, id pulumi.ID, state *DatabaseState, opts ...pulumi.ResourceOpt) (*Database, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["collation"] = state.Collation
		inputs["createMode"] = state.CreateMode
		inputs["creationDate"] = state.CreationDate
		inputs["defaultSecondaryLocation"] = state.DefaultSecondaryLocation
		inputs["edition"] = state.Edition
		inputs["elasticPoolName"] = state.ElasticPoolName
		inputs["encryption"] = state.Encryption
		inputs["import"] = state.Import
		inputs["location"] = state.Location
		inputs["maxSizeBytes"] = state.MaxSizeBytes
		inputs["name"] = state.Name
		inputs["readScale"] = state.ReadScale
		inputs["requestedServiceObjectiveId"] = state.RequestedServiceObjectiveId
		inputs["requestedServiceObjectiveName"] = state.RequestedServiceObjectiveName
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["restorePointInTime"] = state.RestorePointInTime
		inputs["serverName"] = state.ServerName
		inputs["sourceDatabaseDeletionDate"] = state.SourceDatabaseDeletionDate
		inputs["sourceDatabaseId"] = state.SourceDatabaseId
		inputs["tags"] = state.Tags
		inputs["threatDetectionPolicy"] = state.ThreatDetectionPolicy
	}
	s, err := ctx.ReadResource("azure:sql/database:Database", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Database{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Database) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Database) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The name of the collation. Applies only if `createMode` is `Default`.  Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
func (r *Database) Collation() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["collation"])
}

// Specifies how to create the database. Must be either `Default` to create a new database or `PointInTimeRestore` to restore from a snapshot. Defaults to `Default`.
func (r *Database) CreateMode() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["createMode"])
}

// The creation date of the SQL Database.
func (r *Database) CreationDate() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["creationDate"])
}

// The default secondary location of the SQL Database.
func (r *Database) DefaultSecondaryLocation() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["defaultSecondaryLocation"])
}

// The edition of the database to be created. Applies only if `createMode` is `Default`. Valid values are: `Basic`, `Standard`, `Premium`, `DataWarehouse`, `Business`, `BusinessCritical`, `Free`, `GeneralPurpose`, `Hyperscale`, `Premium`, `PremiumRS`, `Standard`, `Stretch`, `System`, `System2`, or `Web`. Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
func (r *Database) Edition() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["edition"])
}

// The name of the elastic database pool.
func (r *Database) ElasticPoolName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["elasticPoolName"])
}

func (r *Database) Encryption() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["encryption"])
}

// A Database Import block as documented below. `createMode` must be set to `Default`.
func (r *Database) Import() *pulumi.Output {
	return r.s.State["import"]
}

// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
func (r *Database) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// The maximum size that the database can grow to. Applies only if `createMode` is `Default`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
func (r *Database) MaxSizeBytes() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["maxSizeBytes"])
}

// The name of the database.
func (r *Database) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Read-only connections will be redirected to a high-available replica. Please see [Use read-only replicas to load-balance read-only query workloads](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-read-scale-out).
func (r *Database) ReadScale() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["readScale"])
}

// Use `requestedServiceObjectiveId` or `requestedServiceObjectiveName` to set the performance level for the database.
// Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
func (r *Database) RequestedServiceObjectiveId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["requestedServiceObjectiveId"])
}

// Use `requestedServiceObjectiveName` or `requestedServiceObjectiveId` to set the performance level for the database. Valid values are: `S0`, `S1`, `S2`, `S3`, `P1`, `P2`, `P4`, `P6`, `P11` and `ElasticPool`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
func (r *Database) RequestedServiceObjectiveName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["requestedServiceObjectiveName"])
}

// The name of the resource group in which to create the database.  This must be the same as Database Server resource group currently.
func (r *Database) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// The point in time for the restore. Only applies if `createMode` is `PointInTimeRestore` e.g. 2013-11-08T22:00:40Z
func (r *Database) RestorePointInTime() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["restorePointInTime"])
}

// The name of the SQL Server on which to create the database.
func (r *Database) ServerName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["serverName"])
}

// The deletion date time of the source database. Only applies to deleted databases where `createMode` is `PointInTimeRestore`.
func (r *Database) SourceDatabaseDeletionDate() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["sourceDatabaseDeletionDate"])
}

// The URI of the source database if `createMode` value is not `Default`.
func (r *Database) SourceDatabaseId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["sourceDatabaseId"])
}

// A mapping of tags to assign to the resource.
func (r *Database) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Threat detection policy configuration. The `threatDetectionPolicy` block supports fields documented below.
func (r *Database) ThreatDetectionPolicy() *pulumi.Output {
	return r.s.State["threatDetectionPolicy"]
}

// Input properties used for looking up and filtering Database resources.
type DatabaseState struct {
	// The name of the collation. Applies only if `createMode` is `Default`.  Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
	Collation interface{}
	// Specifies how to create the database. Must be either `Default` to create a new database or `PointInTimeRestore` to restore from a snapshot. Defaults to `Default`.
	CreateMode interface{}
	// The creation date of the SQL Database.
	CreationDate interface{}
	// The default secondary location of the SQL Database.
	DefaultSecondaryLocation interface{}
	// The edition of the database to be created. Applies only if `createMode` is `Default`. Valid values are: `Basic`, `Standard`, `Premium`, `DataWarehouse`, `Business`, `BusinessCritical`, `Free`, `GeneralPurpose`, `Hyperscale`, `Premium`, `PremiumRS`, `Standard`, `Stretch`, `System`, `System2`, or `Web`. Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
	Edition interface{}
	// The name of the elastic database pool.
	ElasticPoolName interface{}
	Encryption interface{}
	// A Database Import block as documented below. `createMode` must be set to `Default`.
	Import interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// The maximum size that the database can grow to. Applies only if `createMode` is `Default`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
	MaxSizeBytes interface{}
	// The name of the database.
	Name interface{}
	// Read-only connections will be redirected to a high-available replica. Please see [Use read-only replicas to load-balance read-only query workloads](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-read-scale-out).
	ReadScale interface{}
	// Use `requestedServiceObjectiveId` or `requestedServiceObjectiveName` to set the performance level for the database.
	// Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
	RequestedServiceObjectiveId interface{}
	// Use `requestedServiceObjectiveName` or `requestedServiceObjectiveId` to set the performance level for the database. Valid values are: `S0`, `S1`, `S2`, `S3`, `P1`, `P2`, `P4`, `P6`, `P11` and `ElasticPool`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
	RequestedServiceObjectiveName interface{}
	// The name of the resource group in which to create the database.  This must be the same as Database Server resource group currently.
	ResourceGroupName interface{}
	// The point in time for the restore. Only applies if `createMode` is `PointInTimeRestore` e.g. 2013-11-08T22:00:40Z
	RestorePointInTime interface{}
	// The name of the SQL Server on which to create the database.
	ServerName interface{}
	// The deletion date time of the source database. Only applies to deleted databases where `createMode` is `PointInTimeRestore`.
	SourceDatabaseDeletionDate interface{}
	// The URI of the source database if `createMode` value is not `Default`.
	SourceDatabaseId interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// Threat detection policy configuration. The `threatDetectionPolicy` block supports fields documented below.
	ThreatDetectionPolicy interface{}
}

// The set of arguments for constructing a Database resource.
type DatabaseArgs struct {
	// The name of the collation. Applies only if `createMode` is `Default`.  Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
	Collation interface{}
	// Specifies how to create the database. Must be either `Default` to create a new database or `PointInTimeRestore` to restore from a snapshot. Defaults to `Default`.
	CreateMode interface{}
	// The edition of the database to be created. Applies only if `createMode` is `Default`. Valid values are: `Basic`, `Standard`, `Premium`, `DataWarehouse`, `Business`, `BusinessCritical`, `Free`, `GeneralPurpose`, `Hyperscale`, `Premium`, `PremiumRS`, `Standard`, `Stretch`, `System`, `System2`, or `Web`. Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
	Edition interface{}
	// The name of the elastic database pool.
	ElasticPoolName interface{}
	// A Database Import block as documented below. `createMode` must be set to `Default`.
	Import interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// The maximum size that the database can grow to. Applies only if `createMode` is `Default`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
	MaxSizeBytes interface{}
	// The name of the database.
	Name interface{}
	// Read-only connections will be redirected to a high-available replica. Please see [Use read-only replicas to load-balance read-only query workloads](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-read-scale-out).
	ReadScale interface{}
	// Use `requestedServiceObjectiveId` or `requestedServiceObjectiveName` to set the performance level for the database.
	// Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
	RequestedServiceObjectiveId interface{}
	// Use `requestedServiceObjectiveName` or `requestedServiceObjectiveId` to set the performance level for the database. Valid values are: `S0`, `S1`, `S2`, `S3`, `P1`, `P2`, `P4`, `P6`, `P11` and `ElasticPool`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
	RequestedServiceObjectiveName interface{}
	// The name of the resource group in which to create the database.  This must be the same as Database Server resource group currently.
	ResourceGroupName interface{}
	// The point in time for the restore. Only applies if `createMode` is `PointInTimeRestore` e.g. 2013-11-08T22:00:40Z
	RestorePointInTime interface{}
	// The name of the SQL Server on which to create the database.
	ServerName interface{}
	// The deletion date time of the source database. Only applies to deleted databases where `createMode` is `PointInTimeRestore`.
	SourceDatabaseDeletionDate interface{}
	// The URI of the source database if `createMode` value is not `Default`.
	SourceDatabaseId interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// Threat detection policy configuration. The `threatDetectionPolicy` block supports fields documented below.
	ThreatDetectionPolicy interface{}
}
