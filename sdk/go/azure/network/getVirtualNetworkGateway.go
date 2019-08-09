// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Virtual Network Gateway.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/virtual_network_gateway.html.markdown.
func LookupVirtualNetworkGateway(ctx *pulumi.Context, args *GetVirtualNetworkGatewayArgs) (*GetVirtualNetworkGatewayResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:network/getVirtualNetworkGateway:getVirtualNetworkGateway", inputs)
	if err != nil {
		return nil, err
	}
	return &GetVirtualNetworkGatewayResult{
		ActiveActive: outputs["activeActive"],
		BgpSettings: outputs["bgpSettings"],
		DefaultLocalNetworkGatewayId: outputs["defaultLocalNetworkGatewayId"],
		EnableBgp: outputs["enableBgp"],
		IpConfigurations: outputs["ipConfigurations"],
		Location: outputs["location"],
		Name: outputs["name"],
		ResourceGroupName: outputs["resourceGroupName"],
		Sku: outputs["sku"],
		Tags: outputs["tags"],
		Type: outputs["type"],
		VpnClientConfigurations: outputs["vpnClientConfigurations"],
		VpnType: outputs["vpnType"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getVirtualNetworkGateway.
type GetVirtualNetworkGatewayArgs struct {
	// Specifies the name of the Virtual Network Gateway.
	Name interface{}
	// Specifies the name of the resource group the Virtual Network Gateway is located in.
	ResourceGroupName interface{}
}

// A collection of values returned by getVirtualNetworkGateway.
type GetVirtualNetworkGatewayResult struct {
	// (Optional) Is this an Active-Active Gateway?
	ActiveActive interface{}
	BgpSettings interface{}
	// The ID of the local network gateway
	// through which outbound Internet traffic from the virtual network in which the
	// gateway is created will be routed (*forced tunneling*). Refer to the
	// [Azure documentation on forced tunneling](https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-forced-tunneling-rm).
	DefaultLocalNetworkGatewayId interface{}
	// Will BGP (Border Gateway Protocol) will be enabled
	// for this Virtual Network Gateway.
	EnableBgp interface{}
	// One or two `ipConfiguration` blocks documented below.
	IpConfigurations interface{}
	// The location/region where the Virtual Network Gateway is located.
	Location interface{}
	// The user-defined name of the revoked certificate.
	Name interface{}
	ResourceGroupName interface{}
	// Configuration of the size and capacity of the Virtual Network Gateway.
	Sku interface{}
	// A mapping of tags assigned to the resource.
	Tags interface{}
	// The type of the Virtual Network Gateway.
	Type interface{}
	// A `vpnClientConfiguration` block which is documented below.
	VpnClientConfigurations interface{}
	// The routing type of the Virtual Network Gateway.
	VpnType interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
