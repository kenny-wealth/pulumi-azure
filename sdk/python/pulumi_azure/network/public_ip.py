# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class PublicIp(pulumi.CustomResource):
    allocation_method: pulumi.Output[str]
    """
    Defines the allocation method for this IP address. Possible values are `Static` or `Dynamic`.
    """
    domain_name_label: pulumi.Output[str]
    """
    Label for the Domain Name. Will be used to make up the FQDN.  If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system.
    """
    fqdn: pulumi.Output[str]
    """
    Fully qualified domain name of the A DNS record associated with the public IP. `domain_name_label` must be specified to get the `fqdn`. This is the concatenation of the `domain_name_label` and the regionalized DNS zone
    """
    idle_timeout_in_minutes: pulumi.Output[float]
    """
    Specifies the timeout for the TCP idle connection. The value can be set between 4 and 30 minutes.
    """
    ip_address: pulumi.Output[str]
    """
    The IP address value that was allocated.
    """
    ip_version: pulumi.Output[str]
    """
    The IP Version to use, IPv6 or IPv4.
    """
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Public IP resource . Changing this forces a
    new resource to be created.
    """
    public_ip_address_allocation: pulumi.Output[str]
    public_ip_prefix_id: pulumi.Output[str]
    """
    If specified then public IP address allocated will be provided from the public IP prefix resource.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to
    create the public ip.
    """
    reverse_fqdn: pulumi.Output[str]
    """
    A fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.
    """
    sku: pulumi.Output[str]
    """
    The SKU of the Public IP. Accepted values are `Basic` and `Standard`. Defaults to `Basic`.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    zones: pulumi.Output[str]
    """
    A collection containing the availability zone to allocate the Public IP in.
    """
    def __init__(__self__, resource_name, opts=None, allocation_method=None, domain_name_label=None, idle_timeout_in_minutes=None, ip_version=None, location=None, name=None, public_ip_address_allocation=None, public_ip_prefix_id=None, resource_group_name=None, reverse_fqdn=None, sku=None, tags=None, zones=None, __props__=None, __name__=None, __opts__=None):
        """
        Manage a Public IP Address.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] allocation_method: Defines the allocation method for this IP address. Possible values are `Static` or `Dynamic`.
        :param pulumi.Input[str] domain_name_label: Label for the Domain Name. Will be used to make up the FQDN.  If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system.
        :param pulumi.Input[float] idle_timeout_in_minutes: Specifies the timeout for the TCP idle connection. The value can be set between 4 and 30 minutes.
        :param pulumi.Input[str] ip_version: The IP Version to use, IPv6 or IPv4.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Public IP resource . Changing this forces a
               new resource to be created.
        :param pulumi.Input[str] public_ip_prefix_id: If specified then public IP address allocated will be provided from the public IP prefix resource.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the public ip.
        :param pulumi.Input[str] reverse_fqdn: A fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.
        :param pulumi.Input[str] sku: The SKU of the Public IP. Accepted values are `Basic` and `Standard`. Defaults to `Basic`.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] zones: A collection containing the availability zone to allocate the Public IP in.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/public_ip.html.markdown.
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

            __props__['allocation_method'] = allocation_method
            __props__['domain_name_label'] = domain_name_label
            __props__['idle_timeout_in_minutes'] = idle_timeout_in_minutes
            __props__['ip_version'] = ip_version
            __props__['location'] = location
            __props__['name'] = name
            __props__['public_ip_address_allocation'] = public_ip_address_allocation
            __props__['public_ip_prefix_id'] = public_ip_prefix_id
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['reverse_fqdn'] = reverse_fqdn
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['zones'] = zones
            __props__['fqdn'] = None
            __props__['ip_address'] = None
        super(PublicIp, __self__).__init__(
            'azure:network/publicIp:PublicIp',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, allocation_method=None, domain_name_label=None, fqdn=None, idle_timeout_in_minutes=None, ip_address=None, ip_version=None, location=None, name=None, public_ip_address_allocation=None, public_ip_prefix_id=None, resource_group_name=None, reverse_fqdn=None, sku=None, tags=None, zones=None):
        """
        Get an existing PublicIp resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] allocation_method: Defines the allocation method for this IP address. Possible values are `Static` or `Dynamic`.
        :param pulumi.Input[str] domain_name_label: Label for the Domain Name. Will be used to make up the FQDN.  If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system.
        :param pulumi.Input[str] fqdn: Fully qualified domain name of the A DNS record associated with the public IP. `domain_name_label` must be specified to get the `fqdn`. This is the concatenation of the `domain_name_label` and the regionalized DNS zone
        :param pulumi.Input[float] idle_timeout_in_minutes: Specifies the timeout for the TCP idle connection. The value can be set between 4 and 30 minutes.
        :param pulumi.Input[str] ip_address: The IP address value that was allocated.
        :param pulumi.Input[str] ip_version: The IP Version to use, IPv6 or IPv4.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Public IP resource . Changing this forces a
               new resource to be created.
        :param pulumi.Input[str] public_ip_prefix_id: If specified then public IP address allocated will be provided from the public IP prefix resource.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the public ip.
        :param pulumi.Input[str] reverse_fqdn: A fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.
        :param pulumi.Input[str] sku: The SKU of the Public IP. Accepted values are `Basic` and `Standard`. Defaults to `Basic`.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] zones: A collection containing the availability zone to allocate the Public IP in.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/public_ip.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["allocation_method"] = allocation_method
        __props__["domain_name_label"] = domain_name_label
        __props__["fqdn"] = fqdn
        __props__["idle_timeout_in_minutes"] = idle_timeout_in_minutes
        __props__["ip_address"] = ip_address
        __props__["ip_version"] = ip_version
        __props__["location"] = location
        __props__["name"] = name
        __props__["public_ip_address_allocation"] = public_ip_address_allocation
        __props__["public_ip_prefix_id"] = public_ip_prefix_id
        __props__["resource_group_name"] = resource_group_name
        __props__["reverse_fqdn"] = reverse_fqdn
        __props__["sku"] = sku
        __props__["tags"] = tags
        __props__["zones"] = zones
        return PublicIp(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

