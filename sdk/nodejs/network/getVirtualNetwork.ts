// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Virtual Network.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const test = azure.network.getVirtualNetwork({
 *     name: "production",
 *     resourceGroupName: "networking",
 * });
 * 
 * export const virtualNetworkId = test.id;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/virtual_network.html.markdown.
 */
export function getVirtualNetwork(args: GetVirtualNetworkArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkResult> & GetVirtualNetworkResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetVirtualNetworkResult> = pulumi.runtime.invoke("azure:network/getVirtualNetwork:getVirtualNetwork", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getVirtualNetwork.
 */
export interface GetVirtualNetworkArgs {
    /**
     * Specifies the name of the Virtual Network.
     */
    readonly name: string;
    /**
     * Specifies the name of the resource group the Virtual Network is located in.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getVirtualNetwork.
 */
export interface GetVirtualNetworkResult {
    /**
     * The list of address spaces used by the virtual network.
     */
    readonly addressSpaces: string[];
    readonly addressSpacesCollection: string[];
    /**
     * The list of DNS servers used by the virtual network.
     */
    readonly dnsServers: string[];
    /**
     * Location of the virtual network.
     */
    readonly location: string;
    readonly name: string;
    readonly resourceGroupName: string;
    /**
     * The list of name of the subnets that are attached to this virtual network.
     */
    readonly subnets: string[];
    /**
     * A mapping of name - virtual network id of the virtual network peerings.
     */
    readonly vnetPeerings: {[key: string]: string};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
