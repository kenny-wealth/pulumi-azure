# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Workflow(pulumi.CustomResource):
    access_endpoint: pulumi.Output[str]
    """
    The Access Endpoint for the Logic App Workflow
    """
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the Logic App Workflow exists. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Logic App Workflow. Changing this forces a new resource to be created.
    """
    parameters: pulumi.Output[dict]
    """
    A map of Key-Value pairs.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the Resource Group in which the Logic App Workflow should be created. Changing this forces a new resource to be created.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    workflow_schema: pulumi.Output[str]
    """
    Specifies the Schema to use for this Logic App Workflow. Defaults to `https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#`. Changing this forces a new resource to be created.
    """
    workflow_version: pulumi.Output[str]
    """
    Specifies the version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`. Changing this forces a new resource to be create.d
    """
    def __init__(__self__, resource_name, opts=None, location=None, name=None, parameters=None, resource_group_name=None, tags=None, workflow_schema=None, workflow_version=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Logic App Workflow.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the Logic App Workflow exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Logic App Workflow. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] parameters: A map of Key-Value pairs.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the Logic App Workflow should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] workflow_schema: Specifies the Schema to use for this Logic App Workflow. Defaults to `https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] workflow_version: Specifies the version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`. Changing this forces a new resource to be create.d

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/logic_app_workflow.html.markdown.
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
            __props__['name'] = name
            __props__['parameters'] = parameters
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['workflow_schema'] = workflow_schema
            __props__['workflow_version'] = workflow_version
            __props__['access_endpoint'] = None
        super(Workflow, __self__).__init__(
            'azure:logicapps/workflow:Workflow',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, access_endpoint=None, location=None, name=None, parameters=None, resource_group_name=None, tags=None, workflow_schema=None, workflow_version=None):
        """
        Get an existing Workflow resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] access_endpoint: The Access Endpoint for the Logic App Workflow
        :param pulumi.Input[str] location: Specifies the supported Azure location where the Logic App Workflow exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Logic App Workflow. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] parameters: A map of Key-Value pairs.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the Logic App Workflow should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] workflow_schema: Specifies the Schema to use for this Logic App Workflow. Defaults to `https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] workflow_version: Specifies the version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`. Changing this forces a new resource to be create.d

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/logic_app_workflow.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["access_endpoint"] = access_endpoint
        __props__["location"] = location
        __props__["name"] = name
        __props__["parameters"] = parameters
        __props__["resource_group_name"] = resource_group_name
        __props__["tags"] = tags
        __props__["workflow_schema"] = workflow_schema
        __props__["workflow_version"] = workflow_version
        return Workflow(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

