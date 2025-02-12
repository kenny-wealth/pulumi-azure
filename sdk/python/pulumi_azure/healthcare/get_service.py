# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetServiceResult:
    """
    A collection of values returned by getService.
    """
    def __init__(__self__, access_policy_object_ids=None, authentication_configurations=None, cors_configurations=None, cosmosdb_throughput=None, kind=None, location=None, name=None, resource_group_name=None, tags=None, id=None):
        if access_policy_object_ids and not isinstance(access_policy_object_ids, list):
            raise TypeError("Expected argument 'access_policy_object_ids' to be a list")
        __self__.access_policy_object_ids = access_policy_object_ids
        if authentication_configurations and not isinstance(authentication_configurations, list):
            raise TypeError("Expected argument 'authentication_configurations' to be a list")
        __self__.authentication_configurations = authentication_configurations
        """
        An `authentication_configuration` block as defined below.
        """
        if cors_configurations and not isinstance(cors_configurations, list):
            raise TypeError("Expected argument 'cors_configurations' to be a list")
        __self__.cors_configurations = cors_configurations
        """
        A `cors_configuration` block as defined below.
        """
        if cosmosdb_throughput and not isinstance(cosmosdb_throughput, float):
            raise TypeError("Expected argument 'cosmosdb_throughput' to be a float")
        __self__.cosmosdb_throughput = cosmosdb_throughput
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        __self__.kind = kind
        """
        The type of the service.
        """
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        __self__.location = location
        """
        The Azure Region where the Service is located.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        __self__.resource_group_name = resource_group_name
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        __self__.tags = tags
        """
        A mapping of tags to assign to the resource.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
class AwaitableGetServiceResult(GetServiceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetServiceResult(
            access_policy_object_ids=self.access_policy_object_ids,
            authentication_configurations=self.authentication_configurations,
            cors_configurations=self.cors_configurations,
            cosmosdb_throughput=self.cosmosdb_throughput,
            kind=self.kind,
            location=self.location,
            name=self.name,
            resource_group_name=self.resource_group_name,
            tags=self.tags,
            id=self.id)

def get_service(location=None,name=None,resource_group_name=None,tags=None,opts=None):
    """
    Use this data source to access information about an existing Healthcare Service
    
    :param str name: Specifies the name of the Healthcare Service.
    :param str resource_group_name: The name of the Resource Group in which the Healthcare Service exists.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/healthcare_service.html.markdown.
    """
    __args__ = dict()

    __args__['location'] = location
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['tags'] = tags
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:healthcare/getService:getService', __args__, opts=opts).value

    return AwaitableGetServiceResult(
        access_policy_object_ids=__ret__.get('accessPolicyObjectIds'),
        authentication_configurations=__ret__.get('authenticationConfigurations'),
        cors_configurations=__ret__.get('corsConfigurations'),
        cosmosdb_throughput=__ret__.get('cosmosdbThroughput'),
        kind=__ret__.get('kind'),
        location=__ret__.get('location'),
        name=__ret__.get('name'),
        resource_group_name=__ret__.get('resourceGroupName'),
        tags=__ret__.get('tags'),
        id=__ret__.get('id'))
