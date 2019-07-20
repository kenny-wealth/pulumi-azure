// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/monitor_action_group.html.markdown.
 */
export function getActionGroup(args: GetActionGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetActionGroupResult> & GetActionGroupResult {
    const promise: Promise<GetActionGroupResult> = pulumi.runtime.invoke("azure:monitoring/getActionGroup:getActionGroup", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getActionGroup.
 */
export interface GetActionGroupArgs {
    /**
     * Specifies the name of the Action Group.
     */
    readonly name: string;
    /**
     * Specifies the name of the resource group the Action Group is located in.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getActionGroup.
 */
export interface GetActionGroupResult {
    /**
     * One or more `email_receiver` blocks as defined below.
     */
    readonly emailReceivers: { emailAddress: string, name: string }[];
    /**
     * Whether this action group is enabled.
     */
    readonly enabled: boolean;
    /**
     * The name of the webhook receiver. 
     */
    readonly name: string;
    readonly resourceGroupName: string;
    /**
     * The short name of the action group.
     */
    readonly shortName: string;
    /**
     * One or more `sms_receiver ` blocks as defined below.
     */
    readonly smsReceivers: { countryCode: string, name: string, phoneNumber: string }[];
    /**
     * One or more `webhook_receiver ` blocks as defined below.
     */
    readonly webhookReceivers: { name: string, serviceUri: string }[];
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
