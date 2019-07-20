// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access the configuration of the AzureRM provider.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const current = pulumi.output(azure.core.getClientConfig({}));
 * 
 * export const accountId = current.servicePrincipalApplicationId;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/client_config.html.markdown.
 */
export function getClientConfig(opts?: pulumi.InvokeOptions): Promise<GetClientConfigResult> & GetClientConfigResult {
    const promise: Promise<GetClientConfigResult> = pulumi.runtime.invoke("azure:core/getClientConfig:getClientConfig", {
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of values returned by getClientConfig.
 */
export interface GetClientConfigResult {
    readonly clientId: string;
    readonly servicePrincipalApplicationId: string;
    readonly servicePrincipalObjectId: string;
    readonly subscriptionId: string;
    readonly tenantId: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
