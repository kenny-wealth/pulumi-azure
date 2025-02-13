// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a ServiceBus Queue.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("example", {
 *     location: "West Europe",
 *     name: "my-servicebus",
 * });
 * const exampleNamespace = new azure.servicebus.Namespace("example", {
 *     location: exampleResourceGroup.location,
 *     name: "tfexSevicebusNamespace",
 *     resourceGroupName: exampleResourceGroup.name,
 *     sku: "Standard",
 *     tags: {
 *         source: "example",
 *     },
 * });
 * const exampleQueue = new azure.servicebus.Queue("example", {
 *     enablePartitioning: true,
 *     name: "tfexServicebusQueue",
 *     namespaceName: exampleNamespace.name,
 *     resourceGroupName: exampleResourceGroup.name,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/servicebus_queue.html.markdown.
 */
export class Queue extends pulumi.CustomResource {
    /**
     * Get an existing Queue resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: QueueState, opts?: pulumi.CustomResourceOptions): Queue {
        return new Queue(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:servicebus/queue:Queue';

    /**
     * Returns true if the given object is an instance of Queue.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Queue {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Queue.__pulumiType;
    }

    /**
     * The ISO 8601 timespan duration of the idle interval after which the
     * Queue is automatically deleted, minimum of 5 minutes.
     */
    public readonly autoDeleteOnIdle!: pulumi.Output<string>;
    /**
     * Boolean flag which controls whether the Queue has dead letter support when a message expires. Defaults to `false`.
     */
    public readonly deadLetteringOnMessageExpiration!: pulumi.Output<boolean | undefined>;
    /**
     * The ISO 8601 timespan duration of the TTL of messages sent to this
     * queue. This is the default value used when TTL is not set on message itself.
     */
    public readonly defaultMessageTtl!: pulumi.Output<string>;
    /**
     * The ISO 8601 timespan duration during which
     * duplicates can be detected. Default value is 10 minutes. (`PT10M`)
     */
    public readonly duplicateDetectionHistoryTimeWindow!: pulumi.Output<string>;
    public readonly enableBatchedOperations!: pulumi.Output<boolean | undefined>;
    /**
     * Boolean flag which controls whether Express Entities
     * are enabled. An express queue holds a message in memory temporarily before writing
     * it to persistent storage. Defaults to `false` for Basic and Standard. For Premium, it MUST
     * be set to `false`.
     */
    public readonly enableExpress!: pulumi.Output<boolean | undefined>;
    /**
     * Boolean flag which controls whether to enable
     * the queue to be partitioned across multiple message brokers. Changing this forces
     * a new resource to be created. Defaults to `false` for Basic and Standard. For Premium, it MUST
     * be set to `true`.
     */
    public readonly enablePartitioning!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies the supported Azure location where the resource exists.
     * Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. Maximum value is 5 minutes. Defaults to 1 minute. (`PT1M`)
     */
    public readonly lockDuration!: pulumi.Output<string>;
    /**
     * Integer value which controls when a message is automatically deadlettered. Defaults to `10`.
     */
    public readonly maxDeliveryCount!: pulumi.Output<number | undefined>;
    /**
     * Integer value which controls the size of
     * memory allocated for the queue. For supported values see the "Queue/topic size"
     * section of [this document](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quotas).
     */
    public readonly maxSizeInMegabytes!: pulumi.Output<number>;
    /**
     * Specifies the name of the ServiceBus Queue resource. Changing this forces a
     * new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the ServiceBus Namespace to create
     * this queue in. Changing this forces a new resource to be created.
     */
    public readonly namespaceName!: pulumi.Output<string>;
    /**
     * Boolean flag which controls whether
     * the Queue requires duplicate detection. Changing this forces
     * a new resource to be created. Defaults to `false`.
     */
    public readonly requiresDuplicateDetection!: pulumi.Output<boolean | undefined>;
    /**
     * Boolean flag which controls whether the Queue requires sessions.
     * This will allow ordered handling of unbounded sequences of related messages. With sessions enabled
     * a queue can guarantee first-in-first-out delivery of messages.
     * Changing this forces a new resource to be created. Defaults to `false`.
     */
    public readonly requiresSession!: pulumi.Output<boolean | undefined>;
    /**
     * The name of the resource group in which to
     * create the namespace. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    public readonly supportOrdering!: pulumi.Output<boolean | undefined>;

    /**
     * Create a Queue resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: QueueArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: QueueArgs | QueueState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as QueueState | undefined;
            inputs["autoDeleteOnIdle"] = state ? state.autoDeleteOnIdle : undefined;
            inputs["deadLetteringOnMessageExpiration"] = state ? state.deadLetteringOnMessageExpiration : undefined;
            inputs["defaultMessageTtl"] = state ? state.defaultMessageTtl : undefined;
            inputs["duplicateDetectionHistoryTimeWindow"] = state ? state.duplicateDetectionHistoryTimeWindow : undefined;
            inputs["enableBatchedOperations"] = state ? state.enableBatchedOperations : undefined;
            inputs["enableExpress"] = state ? state.enableExpress : undefined;
            inputs["enablePartitioning"] = state ? state.enablePartitioning : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["lockDuration"] = state ? state.lockDuration : undefined;
            inputs["maxDeliveryCount"] = state ? state.maxDeliveryCount : undefined;
            inputs["maxSizeInMegabytes"] = state ? state.maxSizeInMegabytes : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namespaceName"] = state ? state.namespaceName : undefined;
            inputs["requiresDuplicateDetection"] = state ? state.requiresDuplicateDetection : undefined;
            inputs["requiresSession"] = state ? state.requiresSession : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["supportOrdering"] = state ? state.supportOrdering : undefined;
        } else {
            const args = argsOrState as QueueArgs | undefined;
            if (!args || args.namespaceName === undefined) {
                throw new Error("Missing required property 'namespaceName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["autoDeleteOnIdle"] = args ? args.autoDeleteOnIdle : undefined;
            inputs["deadLetteringOnMessageExpiration"] = args ? args.deadLetteringOnMessageExpiration : undefined;
            inputs["defaultMessageTtl"] = args ? args.defaultMessageTtl : undefined;
            inputs["duplicateDetectionHistoryTimeWindow"] = args ? args.duplicateDetectionHistoryTimeWindow : undefined;
            inputs["enableBatchedOperations"] = args ? args.enableBatchedOperations : undefined;
            inputs["enableExpress"] = args ? args.enableExpress : undefined;
            inputs["enablePartitioning"] = args ? args.enablePartitioning : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["lockDuration"] = args ? args.lockDuration : undefined;
            inputs["maxDeliveryCount"] = args ? args.maxDeliveryCount : undefined;
            inputs["maxSizeInMegabytes"] = args ? args.maxSizeInMegabytes : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namespaceName"] = args ? args.namespaceName : undefined;
            inputs["requiresDuplicateDetection"] = args ? args.requiresDuplicateDetection : undefined;
            inputs["requiresSession"] = args ? args.requiresSession : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["supportOrdering"] = args ? args.supportOrdering : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure:eventhub/queue:Queue" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Queue.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Queue resources.
 */
export interface QueueState {
    /**
     * The ISO 8601 timespan duration of the idle interval after which the
     * Queue is automatically deleted, minimum of 5 minutes.
     */
    readonly autoDeleteOnIdle?: pulumi.Input<string>;
    /**
     * Boolean flag which controls whether the Queue has dead letter support when a message expires. Defaults to `false`.
     */
    readonly deadLetteringOnMessageExpiration?: pulumi.Input<boolean>;
    /**
     * The ISO 8601 timespan duration of the TTL of messages sent to this
     * queue. This is the default value used when TTL is not set on message itself.
     */
    readonly defaultMessageTtl?: pulumi.Input<string>;
    /**
     * The ISO 8601 timespan duration during which
     * duplicates can be detected. Default value is 10 minutes. (`PT10M`)
     */
    readonly duplicateDetectionHistoryTimeWindow?: pulumi.Input<string>;
    readonly enableBatchedOperations?: pulumi.Input<boolean>;
    /**
     * Boolean flag which controls whether Express Entities
     * are enabled. An express queue holds a message in memory temporarily before writing
     * it to persistent storage. Defaults to `false` for Basic and Standard. For Premium, it MUST
     * be set to `false`.
     */
    readonly enableExpress?: pulumi.Input<boolean>;
    /**
     * Boolean flag which controls whether to enable
     * the queue to be partitioned across multiple message brokers. Changing this forces
     * a new resource to be created. Defaults to `false` for Basic and Standard. For Premium, it MUST
     * be set to `true`.
     */
    readonly enablePartitioning?: pulumi.Input<boolean>;
    /**
     * Specifies the supported Azure location where the resource exists.
     * Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. Maximum value is 5 minutes. Defaults to 1 minute. (`PT1M`)
     */
    readonly lockDuration?: pulumi.Input<string>;
    /**
     * Integer value which controls when a message is automatically deadlettered. Defaults to `10`.
     */
    readonly maxDeliveryCount?: pulumi.Input<number>;
    /**
     * Integer value which controls the size of
     * memory allocated for the queue. For supported values see the "Queue/topic size"
     * section of [this document](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quotas).
     */
    readonly maxSizeInMegabytes?: pulumi.Input<number>;
    /**
     * Specifies the name of the ServiceBus Queue resource. Changing this forces a
     * new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the ServiceBus Namespace to create
     * this queue in. Changing this forces a new resource to be created.
     */
    readonly namespaceName?: pulumi.Input<string>;
    /**
     * Boolean flag which controls whether
     * the Queue requires duplicate detection. Changing this forces
     * a new resource to be created. Defaults to `false`.
     */
    readonly requiresDuplicateDetection?: pulumi.Input<boolean>;
    /**
     * Boolean flag which controls whether the Queue requires sessions.
     * This will allow ordered handling of unbounded sequences of related messages. With sessions enabled
     * a queue can guarantee first-in-first-out delivery of messages.
     * Changing this forces a new resource to be created. Defaults to `false`.
     */
    readonly requiresSession?: pulumi.Input<boolean>;
    /**
     * The name of the resource group in which to
     * create the namespace. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly supportOrdering?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a Queue resource.
 */
export interface QueueArgs {
    /**
     * The ISO 8601 timespan duration of the idle interval after which the
     * Queue is automatically deleted, minimum of 5 minutes.
     */
    readonly autoDeleteOnIdle?: pulumi.Input<string>;
    /**
     * Boolean flag which controls whether the Queue has dead letter support when a message expires. Defaults to `false`.
     */
    readonly deadLetteringOnMessageExpiration?: pulumi.Input<boolean>;
    /**
     * The ISO 8601 timespan duration of the TTL of messages sent to this
     * queue. This is the default value used when TTL is not set on message itself.
     */
    readonly defaultMessageTtl?: pulumi.Input<string>;
    /**
     * The ISO 8601 timespan duration during which
     * duplicates can be detected. Default value is 10 minutes. (`PT10M`)
     */
    readonly duplicateDetectionHistoryTimeWindow?: pulumi.Input<string>;
    readonly enableBatchedOperations?: pulumi.Input<boolean>;
    /**
     * Boolean flag which controls whether Express Entities
     * are enabled. An express queue holds a message in memory temporarily before writing
     * it to persistent storage. Defaults to `false` for Basic and Standard. For Premium, it MUST
     * be set to `false`.
     */
    readonly enableExpress?: pulumi.Input<boolean>;
    /**
     * Boolean flag which controls whether to enable
     * the queue to be partitioned across multiple message brokers. Changing this forces
     * a new resource to be created. Defaults to `false` for Basic and Standard. For Premium, it MUST
     * be set to `true`.
     */
    readonly enablePartitioning?: pulumi.Input<boolean>;
    /**
     * Specifies the supported Azure location where the resource exists.
     * Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. Maximum value is 5 minutes. Defaults to 1 minute. (`PT1M`)
     */
    readonly lockDuration?: pulumi.Input<string>;
    /**
     * Integer value which controls when a message is automatically deadlettered. Defaults to `10`.
     */
    readonly maxDeliveryCount?: pulumi.Input<number>;
    /**
     * Integer value which controls the size of
     * memory allocated for the queue. For supported values see the "Queue/topic size"
     * section of [this document](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quotas).
     */
    readonly maxSizeInMegabytes?: pulumi.Input<number>;
    /**
     * Specifies the name of the ServiceBus Queue resource. Changing this forces a
     * new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the ServiceBus Namespace to create
     * this queue in. Changing this forces a new resource to be created.
     */
    readonly namespaceName: pulumi.Input<string>;
    /**
     * Boolean flag which controls whether
     * the Queue requires duplicate detection. Changing this forces
     * a new resource to be created. Defaults to `false`.
     */
    readonly requiresDuplicateDetection?: pulumi.Input<boolean>;
    /**
     * Boolean flag which controls whether the Queue requires sessions.
     * This will allow ordered handling of unbounded sequences of related messages. With sessions enabled
     * a queue can guarantee first-in-first-out delivery of messages.
     * Changing this forces a new resource to be created. Defaults to `false`.
     */
    readonly requiresSession?: pulumi.Input<boolean>;
    /**
     * The name of the resource group in which to
     * create the namespace. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    readonly supportOrdering?: pulumi.Input<boolean>;
}
