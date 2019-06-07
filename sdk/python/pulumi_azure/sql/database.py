# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Database(pulumi.CustomResource):
    collation: pulumi.Output[str]
    """
    The name of the collation. Applies only if `create_mode` is `Default`.  Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
    """
    create_mode: pulumi.Output[str]
    """
    Specifies how to create the database. Must be either `Default` to create a new database or `PointInTimeRestore` to restore from a snapshot. Defaults to `Default`.
    """
    creation_date: pulumi.Output[str]
    """
    The creation date of the SQL Database.
    """
    default_secondary_location: pulumi.Output[str]
    """
    The default secondary location of the SQL Database.
    """
    edition: pulumi.Output[str]
    """
    The edition of the database to be created. Applies only if `create_mode` is `Default`. Valid values are: `Basic`, `Standard`, `Premium`, or `DataWarehouse`. Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
    """
    elastic_pool_name: pulumi.Output[str]
    """
    The name of the elastic database pool.
    """
    encryption: pulumi.Output[str]
    import_: pulumi.Output[dict]
    """
    A Database Import block as documented below. `create_mode` must be set to `Default`.
    """
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
    """
    max_size_bytes: pulumi.Output[str]
    """
    The maximum size that the database can grow to. Applies only if `create_mode` is `Default`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
    """
    name: pulumi.Output[str]
    """
    The name of the database.
    """
    read_scale: pulumi.Output[bool]
    """
    Read-only connections will be redirected to a high-available replica. Please see [Use read-only replicas to load-balance read-only query workloads](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-read-scale-out).
    """
    requested_service_objective_id: pulumi.Output[str]
    """
    Use `requested_service_objective_id` or `requested_service_objective_name` to set the performance level for the database.
    Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
    """
    requested_service_objective_name: pulumi.Output[str]
    """
    Use `requested_service_objective_name` or `requested_service_objective_id` to set the performance level for the database. Valid values are: `S0`, `S1`, `S2`, `S3`, `P1`, `P2`, `P4`, `P6`, `P11` and `ElasticPool`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to create the database.  This must be the same as Database Server resource group currently.
    """
    restore_point_in_time: pulumi.Output[str]
    """
    The point in time for the restore. Only applies if `create_mode` is `PointInTimeRestore` e.g. 2013-11-08T22:00:40Z
    """
    server_name: pulumi.Output[str]
    """
    The name of the SQL Server on which to create the database.
    """
    source_database_deletion_date: pulumi.Output[str]
    """
    The deletion date time of the source database. Only applies to deleted databases where `create_mode` is `PointInTimeRestore`.
    """
    source_database_id: pulumi.Output[str]
    """
    The URI of the source database if `create_mode` value is not `Default`.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    threat_detection_policy: pulumi.Output[dict]
    """
    Threat detection policy configuration. The `threat_detection_policy` block supports fields documented below.
    """
    def __init__(__self__, resource_name, opts=None, collation=None, create_mode=None, edition=None, elastic_pool_name=None, import_=None, location=None, max_size_bytes=None, name=None, read_scale=None, requested_service_objective_id=None, requested_service_objective_name=None, resource_group_name=None, restore_point_in_time=None, server_name=None, source_database_deletion_date=None, source_database_id=None, tags=None, threat_detection_policy=None, __name__=None, __opts__=None):
        """
        Allows you to manage an Azure SQL Database
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] collation: The name of the collation. Applies only if `create_mode` is `Default`.  Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] create_mode: Specifies how to create the database. Must be either `Default` to create a new database or `PointInTimeRestore` to restore from a snapshot. Defaults to `Default`.
        :param pulumi.Input[str] edition: The edition of the database to be created. Applies only if `create_mode` is `Default`. Valid values are: `Basic`, `Standard`, `Premium`, or `DataWarehouse`. Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        :param pulumi.Input[str] elastic_pool_name: The name of the elastic database pool.
        :param pulumi.Input[dict] import_: A Database Import block as documented below. `create_mode` must be set to `Default`.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] max_size_bytes: The maximum size that the database can grow to. Applies only if `create_mode` is `Default`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        :param pulumi.Input[str] name: The name of the database.
        :param pulumi.Input[bool] read_scale: Read-only connections will be redirected to a high-available replica. Please see [Use read-only replicas to load-balance read-only query workloads](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-read-scale-out).
        :param pulumi.Input[str] requested_service_objective_id: Use `requested_service_objective_id` or `requested_service_objective_name` to set the performance level for the database.
               Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        :param pulumi.Input[str] requested_service_objective_name: Use `requested_service_objective_name` or `requested_service_objective_id` to set the performance level for the database. Valid values are: `S0`, `S1`, `S2`, `S3`, `P1`, `P2`, `P4`, `P6`, `P11` and `ElasticPool`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the database.  This must be the same as Database Server resource group currently.
        :param pulumi.Input[str] restore_point_in_time: The point in time for the restore. Only applies if `create_mode` is `PointInTimeRestore` e.g. 2013-11-08T22:00:40Z
        :param pulumi.Input[str] server_name: The name of the SQL Server on which to create the database.
        :param pulumi.Input[str] source_database_deletion_date: The deletion date time of the source database. Only applies to deleted databases where `create_mode` is `PointInTimeRestore`.
        :param pulumi.Input[str] source_database_id: The URI of the source database if `create_mode` value is not `Default`.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[dict] threat_detection_policy: Threat detection policy configuration. The `threat_detection_policy` block supports fields documented below.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['collation'] = collation

        __props__['create_mode'] = create_mode

        __props__['edition'] = edition

        __props__['elastic_pool_name'] = elastic_pool_name

        __props__['import_'] = import_

        __props__['location'] = location

        __props__['max_size_bytes'] = max_size_bytes

        __props__['name'] = name

        __props__['read_scale'] = read_scale

        __props__['requested_service_objective_id'] = requested_service_objective_id

        __props__['requested_service_objective_name'] = requested_service_objective_name

        if resource_group_name is None:
            raise TypeError("Missing required property 'resource_group_name'")
        __props__['resource_group_name'] = resource_group_name

        __props__['restore_point_in_time'] = restore_point_in_time

        if server_name is None:
            raise TypeError("Missing required property 'server_name'")
        __props__['server_name'] = server_name

        __props__['source_database_deletion_date'] = source_database_deletion_date

        __props__['source_database_id'] = source_database_id

        __props__['tags'] = tags

        __props__['threat_detection_policy'] = threat_detection_policy

        __props__['creation_date'] = None
        __props__['default_secondary_location'] = None
        __props__['encryption'] = None

        super(Database, __self__).__init__(
            'azure:sql/database:Database',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

