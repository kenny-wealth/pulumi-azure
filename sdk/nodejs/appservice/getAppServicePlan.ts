// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing App Service Plan (formerly known as a `Server Farm`).
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const test = azure.appservice.getAppServicePlan({
 *     name: "search-app-service-plan",
 *     resourceGroupName: "search-service",
 * });
 * 
 * export const appServicePlanId = test.id;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/app_service_plan.html.markdown.
 */
export function getAppServicePlan(args: GetAppServicePlanArgs, opts?: pulumi.InvokeOptions): Promise<GetAppServicePlanResult> & GetAppServicePlanResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetAppServicePlanResult> = pulumi.runtime.invoke("azure:appservice/getAppServicePlan:getAppServicePlan", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getAppServicePlan.
 */
export interface GetAppServicePlanArgs {
    /**
     * The name of the App Service Plan.
     */
    readonly name: string;
    /**
     * The Name of the Resource Group where the App Service Plan exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getAppServicePlan.
 */
export interface GetAppServicePlanResult {
    /**
     * A flag that indicates if it's a xenon plan (support for Windows Container)
     */
    readonly isXenon: boolean;
    /**
     * The Operating System type of the App Service Plan
     */
    readonly kind: string;
    /**
     * The Azure location where the App Service Plan exists
     */
    readonly location: string;
    /**
     * The maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan.
     */
    readonly maximumElasticWorkerCount: number;
    /**
     * Maximum number of instances that can be assigned to this App Service plan.
     */
    readonly maximumNumberOfWorkers: number;
    readonly name: string;
    /**
     * A `properties` block as documented below.
     */
    readonly properties: outputs.appservice.GetAppServicePlanProperty[];
    readonly resourceGroupName: string;
    /**
     * A `sku` block as documented below.
     */
    readonly sku: outputs.appservice.GetAppServicePlanSku;
    /**
     * A mapping of tags assigned to the resource.
     */
    readonly tags: {[key: string]: string};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
