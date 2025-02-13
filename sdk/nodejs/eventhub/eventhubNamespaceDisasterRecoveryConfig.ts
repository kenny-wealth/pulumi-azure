// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages an Disaster Recovery Config for an Event Hub Namespace.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("example", {
 *     location: "West Europe",
 *     name: "eventhub-replication",
 * });
 * const primary = new azure.eventhub.EventHubNamespace("primary", {
 *     location: exampleResourceGroup.location,
 *     name: "eventhub-primary",
 *     resourceGroupName: exampleResourceGroup.name,
 *     sku: "Standard",
 * });
 * const secondary = new azure.eventhub.EventHubNamespace("secondary", {
 *     location: "West US",
 *     name: "eventhub-secondary",
 *     resourceGroupName: exampleResourceGroup.name,
 *     sku: "Standard",
 * });
 * const exampleEventhubNamespaceDisasterRecoveryConfig = new azure.eventhub.EventhubNamespaceDisasterRecoveryConfig("example", {
 *     name: "replicate-evenhub",
 *     namespaceName: primary.name,
 *     partnerNamespaceId: secondary.id,
 *     resourceGroupName: exampleResourceGroup.name,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/eventhub_namespace_disaster_recovery_config.html.markdown.
 */
export class EventhubNamespaceDisasterRecoveryConfig extends pulumi.CustomResource {
    /**
     * Get an existing EventhubNamespaceDisasterRecoveryConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EventhubNamespaceDisasterRecoveryConfigState, opts?: pulumi.CustomResourceOptions): EventhubNamespaceDisasterRecoveryConfig {
        return new EventhubNamespaceDisasterRecoveryConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:eventhub/eventhubNamespaceDisasterRecoveryConfig:EventhubNamespaceDisasterRecoveryConfig';

    /**
     * Returns true if the given object is an instance of EventhubNamespaceDisasterRecoveryConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EventhubNamespaceDisasterRecoveryConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EventhubNamespaceDisasterRecoveryConfig.__pulumiType;
    }

    /**
     * An alternate name to use when the Disaster Recovery Config's name is the same as the replicated namespace's name. 
     */
    public readonly alternateName!: pulumi.Output<string | undefined>;
    /**
     * Specifies the name of the Disaster Recovery Config. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Specifies the name of the primary EventHub Namespace to replicate. Changing this forces a new resource to be created.
     */
    public readonly namespaceName!: pulumi.Output<string>;
    /**
     * The ID of the EventHub Namespace to replicate to.
     */
    public readonly partnerNamespaceId!: pulumi.Output<string>;
    /**
     * The name of the resource group in which the Disaster Recovery Config exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;

    /**
     * Create a EventhubNamespaceDisasterRecoveryConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EventhubNamespaceDisasterRecoveryConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EventhubNamespaceDisasterRecoveryConfigArgs | EventhubNamespaceDisasterRecoveryConfigState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as EventhubNamespaceDisasterRecoveryConfigState | undefined;
            inputs["alternateName"] = state ? state.alternateName : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namespaceName"] = state ? state.namespaceName : undefined;
            inputs["partnerNamespaceId"] = state ? state.partnerNamespaceId : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as EventhubNamespaceDisasterRecoveryConfigArgs | undefined;
            if (!args || args.namespaceName === undefined) {
                throw new Error("Missing required property 'namespaceName'");
            }
            if (!args || args.partnerNamespaceId === undefined) {
                throw new Error("Missing required property 'partnerNamespaceId'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["alternateName"] = args ? args.alternateName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namespaceName"] = args ? args.namespaceName : undefined;
            inputs["partnerNamespaceId"] = args ? args.partnerNamespaceId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(EventhubNamespaceDisasterRecoveryConfig.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering EventhubNamespaceDisasterRecoveryConfig resources.
 */
export interface EventhubNamespaceDisasterRecoveryConfigState {
    /**
     * An alternate name to use when the Disaster Recovery Config's name is the same as the replicated namespace's name. 
     */
    readonly alternateName?: pulumi.Input<string>;
    /**
     * Specifies the name of the Disaster Recovery Config. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the name of the primary EventHub Namespace to replicate. Changing this forces a new resource to be created.
     */
    readonly namespaceName?: pulumi.Input<string>;
    /**
     * The ID of the EventHub Namespace to replicate to.
     */
    readonly partnerNamespaceId?: pulumi.Input<string>;
    /**
     * The name of the resource group in which the Disaster Recovery Config exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a EventhubNamespaceDisasterRecoveryConfig resource.
 */
export interface EventhubNamespaceDisasterRecoveryConfigArgs {
    /**
     * An alternate name to use when the Disaster Recovery Config's name is the same as the replicated namespace's name. 
     */
    readonly alternateName?: pulumi.Input<string>;
    /**
     * Specifies the name of the Disaster Recovery Config. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the name of the primary EventHub Namespace to replicate. Changing this forces a new resource to be created.
     */
    readonly namespaceName: pulumi.Input<string>;
    /**
     * The ID of the EventHub Namespace to replicate to.
     */
    readonly partnerNamespaceId: pulumi.Input<string>;
    /**
     * The name of the resource group in which the Disaster Recovery Config exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
