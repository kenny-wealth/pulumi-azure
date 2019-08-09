# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class DatasetPostgresql(pulumi.CustomResource):
    additional_properties: pulumi.Output[dict]
    """
    A map of additional properties to associate with the Data Factory Dataset PostgreSQL.
    """
    annotations: pulumi.Output[list]
    """
    List of tags that can be used for describing the Data Factory Dataset PostgreSQL.
    """
    data_factory_name: pulumi.Output[str]
    """
    The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
    """
    description: pulumi.Output[str]
    """
    The description for the Data Factory Dataset PostgreSQL.
    """
    folder: pulumi.Output[str]
    """
    The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
    """
    linked_service_name: pulumi.Output[str]
    """
    The Data Factory Linked Service name in which to associate the Dataset with.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Data Factory Dataset PostgreSQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
    """
    parameters: pulumi.Output[dict]
    """
    A map of parameters to associate with the Data Factory Dataset PostgreSQL.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to create the Data Factory Dataset PostgreSQL. Changing this forces a new resource
    """
    schema_columns: pulumi.Output[list]
    """
    A `schema_column` block as defined below.
    """
    table_name: pulumi.Output[str]
    """
    The table name of the Data Factory Dataset PostgreSQL.
    """
    def __init__(__self__, resource_name, opts=None, additional_properties=None, annotations=None, data_factory_name=None, description=None, folder=None, linked_service_name=None, name=None, parameters=None, resource_group_name=None, schema_columns=None, table_name=None, __props__=None, __name__=None, __opts__=None):
        """
        Manage a PostgreSQL Dataset inside a Azure Data Factory.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] additional_properties: A map of additional properties to associate with the Data Factory Dataset PostgreSQL.
        :param pulumi.Input[list] annotations: List of tags that can be used for describing the Data Factory Dataset PostgreSQL.
        :param pulumi.Input[str] data_factory_name: The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
        :param pulumi.Input[str] description: The description for the Data Factory Dataset PostgreSQL.
        :param pulumi.Input[str] folder: The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
        :param pulumi.Input[str] linked_service_name: The Data Factory Linked Service name in which to associate the Dataset with.
        :param pulumi.Input[str] name: Specifies the name of the Data Factory Dataset PostgreSQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        :param pulumi.Input[dict] parameters: A map of parameters to associate with the Data Factory Dataset PostgreSQL.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Data Factory Dataset PostgreSQL. Changing this forces a new resource
        :param pulumi.Input[list] schema_columns: A `schema_column` block as defined below.
        :param pulumi.Input[str] table_name: The table name of the Data Factory Dataset PostgreSQL.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/data_factory_dataset_postgresql.html.markdown.
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

            __props__['additional_properties'] = additional_properties
            __props__['annotations'] = annotations
            if data_factory_name is None:
                raise TypeError("Missing required property 'data_factory_name'")
            __props__['data_factory_name'] = data_factory_name
            __props__['description'] = description
            __props__['folder'] = folder
            if linked_service_name is None:
                raise TypeError("Missing required property 'linked_service_name'")
            __props__['linked_service_name'] = linked_service_name
            __props__['name'] = name
            __props__['parameters'] = parameters
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['schema_columns'] = schema_columns
            __props__['table_name'] = table_name
        super(DatasetPostgresql, __self__).__init__(
            'azure:datafactory/datasetPostgresql:DatasetPostgresql',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, additional_properties=None, annotations=None, data_factory_name=None, description=None, folder=None, linked_service_name=None, name=None, parameters=None, resource_group_name=None, schema_columns=None, table_name=None):
        """
        Get an existing DatasetPostgresql resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] additional_properties: A map of additional properties to associate with the Data Factory Dataset PostgreSQL.
        :param pulumi.Input[list] annotations: List of tags that can be used for describing the Data Factory Dataset PostgreSQL.
        :param pulumi.Input[str] data_factory_name: The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
        :param pulumi.Input[str] description: The description for the Data Factory Dataset PostgreSQL.
        :param pulumi.Input[str] folder: The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
        :param pulumi.Input[str] linked_service_name: The Data Factory Linked Service name in which to associate the Dataset with.
        :param pulumi.Input[str] name: Specifies the name of the Data Factory Dataset PostgreSQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        :param pulumi.Input[dict] parameters: A map of parameters to associate with the Data Factory Dataset PostgreSQL.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Data Factory Dataset PostgreSQL. Changing this forces a new resource
        :param pulumi.Input[list] schema_columns: A `schema_column` block as defined below.
        :param pulumi.Input[str] table_name: The table name of the Data Factory Dataset PostgreSQL.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/data_factory_dataset_postgresql.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["additional_properties"] = additional_properties
        __props__["annotations"] = annotations
        __props__["data_factory_name"] = data_factory_name
        __props__["description"] = description
        __props__["folder"] = folder
        __props__["linked_service_name"] = linked_service_name
        __props__["name"] = name
        __props__["parameters"] = parameters
        __props__["resource_group_name"] = resource_group_name
        __props__["schema_columns"] = schema_columns
        __props__["table_name"] = table_name
        return DatasetPostgresql(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

