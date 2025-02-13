# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class ElasticPool(pulumi.CustomResource):
    elastic_pool_properties: pulumi.Output[dict]
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
    """
    max_size_bytes: pulumi.Output[float]
    """
    The max data size of the elastic pool in bytes. Conflicts with `max_size_gb`.
    """
    max_size_gb: pulumi.Output[float]
    """
    The max data size of the elastic pool in gigabytes. Conflicts with `max_size_bytes`. 
    """
    name: pulumi.Output[str]
    """
    Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
    """
    per_database_settings: pulumi.Output[dict]
    """
    A `per_database_settings` block as defined below.
    
      * `maxCapacity` (`float`) - The maximum capacity any one database can consume.
      * `minCapacity` (`float`) - The minimum capacity all databases are guaranteed.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
    """
    server_name: pulumi.Output[str]
    """
    The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
    """
    sku: pulumi.Output[dict]
    """
    A `sku` block as defined below.
    
      * `capacity` (`float`) - The scale up/out capacity, representing server's compute units. For more information see the documentation for your Elasticpool configuration: [vCore-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-vcore-resource-limits-elastic-pools) or [DTU-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-dtu-resource-limits-elastic-pools).
      * `family` (`str`) - The `family` of hardware `Gen4` or `Gen5`.
      * `name` (`str`) - Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
      * `tier` (`str`) - The tier of the particular SKU. Possible values are `GeneralPurpose`, `BusinessCritical`, `Basic`, `Standard`, or `Premium`. For more information see the documentation for your Elasticpool configuration: [vCore-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-vcore-resource-limits-elastic-pools) or [DTU-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-dtu-resource-limits-elastic-pools).
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    zone_redundant: pulumi.Output[bool]
    """
    Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
    """
    def __init__(__self__, resource_name, opts=None, location=None, max_size_bytes=None, max_size_gb=None, name=None, per_database_settings=None, resource_group_name=None, server_name=None, sku=None, tags=None, zone_redundant=None, __props__=None, __name__=None, __opts__=None):
        """
        Allows you to manage an Azure SQL Elastic Pool via the `2017-10-01-preview` API which allows for `vCore` and `DTU` based configurations.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[float] max_size_bytes: The max data size of the elastic pool in bytes. Conflicts with `max_size_gb`.
        :param pulumi.Input[float] max_size_gb: The max data size of the elastic pool in gigabytes. Conflicts with `max_size_bytes`. 
        :param pulumi.Input[str] name: Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
        :param pulumi.Input[dict] per_database_settings: A `per_database_settings` block as defined below.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
        :param pulumi.Input[str] server_name: The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] sku: A `sku` block as defined below.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[bool] zone_redundant: Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
        
        The **per_database_settings** object supports the following:
        
          * `maxCapacity` (`pulumi.Input[float]`) - The maximum capacity any one database can consume.
          * `minCapacity` (`pulumi.Input[float]`) - The minimum capacity all databases are guaranteed.
        
        The **sku** object supports the following:
        
          * `capacity` (`pulumi.Input[float]`) - The scale up/out capacity, representing server's compute units. For more information see the documentation for your Elasticpool configuration: [vCore-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-vcore-resource-limits-elastic-pools) or [DTU-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-dtu-resource-limits-elastic-pools).
          * `family` (`pulumi.Input[str]`) - The `family` of hardware `Gen4` or `Gen5`.
          * `name` (`pulumi.Input[str]`) - Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
          * `tier` (`pulumi.Input[str]`) - The tier of the particular SKU. Possible values are `GeneralPurpose`, `BusinessCritical`, `Basic`, `Standard`, or `Premium`. For more information see the documentation for your Elasticpool configuration: [vCore-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-vcore-resource-limits-elastic-pools) or [DTU-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-dtu-resource-limits-elastic-pools).

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/mssql_elasticpool.html.markdown.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['location'] = location
            __props__['max_size_bytes'] = max_size_bytes
            __props__['max_size_gb'] = max_size_gb
            __props__['name'] = name
            if per_database_settings is None:
                raise TypeError("Missing required property 'per_database_settings'")
            __props__['per_database_settings'] = per_database_settings
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if server_name is None:
                raise TypeError("Missing required property 'server_name'")
            __props__['server_name'] = server_name
            if sku is None:
                raise TypeError("Missing required property 'sku'")
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['zone_redundant'] = zone_redundant
            __props__['elastic_pool_properties'] = None
        super(ElasticPool, __self__).__init__(
            'azure:mssql/elasticPool:ElasticPool',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, elastic_pool_properties=None, location=None, max_size_bytes=None, max_size_gb=None, name=None, per_database_settings=None, resource_group_name=None, server_name=None, sku=None, tags=None, zone_redundant=None):
        """
        Get an existing ElasticPool resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[float] max_size_bytes: The max data size of the elastic pool in bytes. Conflicts with `max_size_gb`.
        :param pulumi.Input[float] max_size_gb: The max data size of the elastic pool in gigabytes. Conflicts with `max_size_bytes`. 
        :param pulumi.Input[str] name: Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
        :param pulumi.Input[dict] per_database_settings: A `per_database_settings` block as defined below.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
        :param pulumi.Input[str] server_name: The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] sku: A `sku` block as defined below.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[bool] zone_redundant: Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
        
        The **elastic_pool_properties** object supports the following:
        
          * `creationDate` (`pulumi.Input[str]`)
          * `license_type` (`pulumi.Input[str]`)
          * `max_size_bytes` (`pulumi.Input[float]`) - The max data size of the elastic pool in bytes. Conflicts with `max_size_gb`.
          * `state` (`pulumi.Input[str]`)
          * `zone_redundant` (`pulumi.Input[bool]`) - Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
        
        The **per_database_settings** object supports the following:
        
          * `maxCapacity` (`pulumi.Input[float]`) - The maximum capacity any one database can consume.
          * `minCapacity` (`pulumi.Input[float]`) - The minimum capacity all databases are guaranteed.
        
        The **sku** object supports the following:
        
          * `capacity` (`pulumi.Input[float]`) - The scale up/out capacity, representing server's compute units. For more information see the documentation for your Elasticpool configuration: [vCore-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-vcore-resource-limits-elastic-pools) or [DTU-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-dtu-resource-limits-elastic-pools).
          * `family` (`pulumi.Input[str]`) - The `family` of hardware `Gen4` or `Gen5`.
          * `name` (`pulumi.Input[str]`) - Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern. 
          * `tier` (`pulumi.Input[str]`) - The tier of the particular SKU. Possible values are `GeneralPurpose`, `BusinessCritical`, `Basic`, `Standard`, or `Premium`. For more information see the documentation for your Elasticpool configuration: [vCore-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-vcore-resource-limits-elastic-pools) or [DTU-based](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-dtu-resource-limits-elastic-pools).

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/mssql_elasticpool.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["elastic_pool_properties"] = elastic_pool_properties
        __props__["location"] = location
        __props__["max_size_bytes"] = max_size_bytes
        __props__["max_size_gb"] = max_size_gb
        __props__["name"] = name
        __props__["per_database_settings"] = per_database_settings
        __props__["resource_group_name"] = resource_group_name
        __props__["server_name"] = server_name
        __props__["sku"] = sku
        __props__["tags"] = tags
        __props__["zone_redundant"] = zone_redundant
        return ElasticPool(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

