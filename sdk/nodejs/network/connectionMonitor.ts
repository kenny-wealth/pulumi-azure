// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/connection_monitor.html.markdown.
 */
export class ConnectionMonitor extends pulumi.CustomResource {
    /**
     * Get an existing ConnectionMonitor resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ConnectionMonitorState, opts?: pulumi.CustomResourceOptions): ConnectionMonitor {
        return new ConnectionMonitor(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:network/connectionMonitor:ConnectionMonitor';

    /**
     * Returns true if the given object is an instance of ConnectionMonitor.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ConnectionMonitor {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ConnectionMonitor.__pulumiType;
    }

    /**
     * Specifies whether the connection monitor will start automatically once created. Defaults to `true`. Changing this forces a new resource to be created.
     */
    public readonly autoStart!: pulumi.Output<boolean | undefined>;
    /**
     * A `destination` block as defined below.
     */
    public readonly destination!: pulumi.Output<{ address?: string, port: number, virtualMachineId?: string }>;
    /**
     * Monitoring interval in seconds. Defaults to `60`.
     */
    public readonly intervalInSeconds!: pulumi.Output<number | undefined>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the Connection Monitor. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the Network Watcher. Changing this forces a new resource to be created.
     */
    public readonly networkWatcherName!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the Connection Monitor. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * A `source` block as defined below.
     */
    public readonly source!: pulumi.Output<{ port?: number, virtualMachineId: string }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a ConnectionMonitor resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ConnectionMonitorArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ConnectionMonitorArgs | ConnectionMonitorState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ConnectionMonitorState | undefined;
            inputs["autoStart"] = state ? state.autoStart : undefined;
            inputs["destination"] = state ? state.destination : undefined;
            inputs["intervalInSeconds"] = state ? state.intervalInSeconds : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkWatcherName"] = state ? state.networkWatcherName : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["source"] = state ? state.source : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as ConnectionMonitorArgs | undefined;
            if (!args || args.destination === undefined) {
                throw new Error("Missing required property 'destination'");
            }
            if (!args || args.networkWatcherName === undefined) {
                throw new Error("Missing required property 'networkWatcherName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.source === undefined) {
                throw new Error("Missing required property 'source'");
            }
            inputs["autoStart"] = args ? args.autoStart : undefined;
            inputs["destination"] = args ? args.destination : undefined;
            inputs["intervalInSeconds"] = args ? args.intervalInSeconds : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkWatcherName"] = args ? args.networkWatcherName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["source"] = args ? args.source : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        }
        super(ConnectionMonitor.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ConnectionMonitor resources.
 */
export interface ConnectionMonitorState {
    /**
     * Specifies whether the connection monitor will start automatically once created. Defaults to `true`. Changing this forces a new resource to be created.
     */
    readonly autoStart?: pulumi.Input<boolean>;
    /**
     * A `destination` block as defined below.
     */
    readonly destination?: pulumi.Input<{ address?: pulumi.Input<string>, port: pulumi.Input<number>, virtualMachineId?: pulumi.Input<string> }>;
    /**
     * Monitoring interval in seconds. Defaults to `60`.
     */
    readonly intervalInSeconds?: pulumi.Input<number>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Connection Monitor. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the Network Watcher. Changing this forces a new resource to be created.
     */
    readonly networkWatcherName?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Connection Monitor. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A `source` block as defined below.
     */
    readonly source?: pulumi.Input<{ port?: pulumi.Input<number>, virtualMachineId: pulumi.Input<string> }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a ConnectionMonitor resource.
 */
export interface ConnectionMonitorArgs {
    /**
     * Specifies whether the connection monitor will start automatically once created. Defaults to `true`. Changing this forces a new resource to be created.
     */
    readonly autoStart?: pulumi.Input<boolean>;
    /**
     * A `destination` block as defined below.
     */
    readonly destination: pulumi.Input<{ address?: pulumi.Input<string>, port: pulumi.Input<number>, virtualMachineId?: pulumi.Input<string> }>;
    /**
     * Monitoring interval in seconds. Defaults to `60`.
     */
    readonly intervalInSeconds?: pulumi.Input<number>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Connection Monitor. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the Network Watcher. Changing this forces a new resource to be created.
     */
    readonly networkWatcherName: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Connection Monitor. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `source` block as defined below.
     */
    readonly source: pulumi.Input<{ port?: pulumi.Input<number>, virtualMachineId: pulumi.Input<string> }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
