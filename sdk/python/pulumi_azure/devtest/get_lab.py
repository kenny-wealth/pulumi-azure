# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class GetLabResult(object):
    """
    A collection of values returned by getLab.
    """
    def __init__(__self__, artifacts_storage_account_id=None, default_premium_storage_account_id=None, default_storage_account_id=None, key_vault_id=None, location=None, premium_data_disk_storage_account_id=None, storage_type=None, tags=None, unique_identifier=None, id=None):
        if artifacts_storage_account_id and not isinstance(artifacts_storage_account_id, basestring):
            raise TypeError('Expected argument artifacts_storage_account_id to be a basestring')
        __self__.artifacts_storage_account_id = artifacts_storage_account_id
        """
        The ID of the Storage Account used for Artifact Storage.
        """
        if default_premium_storage_account_id and not isinstance(default_premium_storage_account_id, basestring):
            raise TypeError('Expected argument default_premium_storage_account_id to be a basestring')
        __self__.default_premium_storage_account_id = default_premium_storage_account_id
        """
        The ID of the Default Premium Storage Account for this Dev Test Lab.
        """
        if default_storage_account_id and not isinstance(default_storage_account_id, basestring):
            raise TypeError('Expected argument default_storage_account_id to be a basestring')
        __self__.default_storage_account_id = default_storage_account_id
        """
        The ID of the Default Storage Account for this Dev Test Lab.
        """
        if key_vault_id and not isinstance(key_vault_id, basestring):
            raise TypeError('Expected argument key_vault_id to be a basestring')
        __self__.key_vault_id = key_vault_id
        """
        The ID of the Key used for this Dev Test Lab.
        """
        if location and not isinstance(location, basestring):
            raise TypeError('Expected argument location to be a basestring')
        __self__.location = location
        """
        The Azure location where the Dev Test Lab exists.
        """
        if premium_data_disk_storage_account_id and not isinstance(premium_data_disk_storage_account_id, basestring):
            raise TypeError('Expected argument premium_data_disk_storage_account_id to be a basestring')
        __self__.premium_data_disk_storage_account_id = premium_data_disk_storage_account_id
        """
        The ID of the Storage Account used for Storage of Premium Data Disk.
        """
        if storage_type and not isinstance(storage_type, basestring):
            raise TypeError('Expected argument storage_type to be a basestring')
        __self__.storage_type = storage_type
        """
        The type of storage used by the Dev Test Lab.
        """
        if tags and not isinstance(tags, dict):
            raise TypeError('Expected argument tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags to assign to the resource.
        """
        if unique_identifier and not isinstance(unique_identifier, basestring):
            raise TypeError('Expected argument unique_identifier to be a basestring')
        __self__.unique_identifier = unique_identifier
        """
        The unique immutable identifier of the Dev Test Lab.
        """
        if id and not isinstance(id, basestring):
            raise TypeError('Expected argument id to be a basestring')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

def get_lab(name=None, resource_group_name=None):
    """
    Use this data source to obtain information about a Dev Test Lab.
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __ret__ = pulumi.runtime.invoke('azure:devtest/getLab:getLab', __args__)

    return GetLabResult(
        artifacts_storage_account_id=__ret__.get('artifactsStorageAccountId'),
        default_premium_storage_account_id=__ret__.get('defaultPremiumStorageAccountId'),
        default_storage_account_id=__ret__.get('defaultStorageAccountId'),
        key_vault_id=__ret__.get('keyVaultId'),
        location=__ret__.get('location'),
        premium_data_disk_storage_account_id=__ret__.get('premiumDataDiskStorageAccountId'),
        storage_type=__ret__.get('storageType'),
        tags=__ret__.get('tags'),
        unique_identifier=__ret__.get('uniqueIdentifier'),
        id=__ret__.get('id'))
