// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Load Balancer Outbound Rule.
 * 
 * > **NOTE** When using this resource, the Load Balancer needs to have a FrontEnd IP Configuration and a Backend Address Pool Attached.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const testResourceGroup = new azure.core.ResourceGroup("test", {
 *     location: "West US",
 *     name: "LoadBalancerRG",
 * });
 * const testPublicIp = new azure.network.PublicIp("test", {
 *     allocationMethod: "Static",
 *     location: "West US",
 *     name: "PublicIPForLB",
 *     resourceGroupName: testResourceGroup.name,
 * });
 * const testLoadBalancer = new azure.lb.LoadBalancer("test", {
 *     frontendIpConfigurations: [{
 *         name: "PublicIPAddress",
 *         publicIpAddressId: testPublicIp.id,
 *     }],
 *     location: "West US",
 *     name: "TestLoadBalancer",
 *     resourceGroupName: testResourceGroup.name,
 * });
 * const testBackendAddressPool = new azure.lb.BackendAddressPool("test", {
 *     loadbalancerId: testLoadBalancer.id,
 *     name: "be-%d",
 *     resourceGroupName: testResourceGroup.name,
 * });
 * const testOutboundRule = new azure.lb.OutboundRule("test", {
 *     backendAddressPoolId: testBackendAddressPool.id,
 *     frontendIpConfigurations: [{
 *         name: "PublicIPAddress",
 *     }],
 *     loadbalancerId: testLoadBalancer.id,
 *     name: "OutboundRule",
 *     protocol: "Tcp",
 *     resourceGroupName: testResourceGroup.name,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/lb_outbound_rule.html.markdown.
 */
export class OutboundRule extends pulumi.CustomResource {
    /**
     * Get an existing OutboundRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OutboundRuleState, opts?: pulumi.CustomResourceOptions): OutboundRule {
        return new OutboundRule(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:lb/outboundRule:OutboundRule';

    /**
     * Returns true if the given object is an instance of OutboundRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OutboundRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OutboundRule.__pulumiType;
    }

    /**
     * The number of outbound ports to be used for NAT.
     */
    public readonly allocatedOutboundPorts!: pulumi.Output<number | undefined>;
    /**
     * The ID of the Backend Address Pool. Outbound traffic is randomly load balanced across IPs in the backend IPs.
     */
    public readonly backendAddressPoolId!: pulumi.Output<string>;
    /**
     * Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
     */
    public readonly enableTcpReset!: pulumi.Output<boolean | undefined>;
    /**
     * One or more `frontendIpConfiguration` blocks as defined below.
     */
    public readonly frontendIpConfigurations!: pulumi.Output<outputs.lb.OutboundRuleFrontendIpConfiguration[] | undefined>;
    /**
     * The timeout for the TCP idle connection
     */
    public readonly idleTimeoutInMinutes!: pulumi.Output<number | undefined>;
    /**
     * The ID of the Load Balancer in which to create the Outbound Rule. Changing this forces a new resource to be created.
     */
    public readonly loadbalancerId!: pulumi.Output<string>;
    /**
     * Specifies the name of the Outbound Rule. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The transport protocol for the external endpoint. Possible values are `Udp`, `Tcp` or `All`.
     */
    public readonly protocol!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the resource. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;

    /**
     * Create a OutboundRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OutboundRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OutboundRuleArgs | OutboundRuleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as OutboundRuleState | undefined;
            inputs["allocatedOutboundPorts"] = state ? state.allocatedOutboundPorts : undefined;
            inputs["backendAddressPoolId"] = state ? state.backendAddressPoolId : undefined;
            inputs["enableTcpReset"] = state ? state.enableTcpReset : undefined;
            inputs["frontendIpConfigurations"] = state ? state.frontendIpConfigurations : undefined;
            inputs["idleTimeoutInMinutes"] = state ? state.idleTimeoutInMinutes : undefined;
            inputs["loadbalancerId"] = state ? state.loadbalancerId : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["protocol"] = state ? state.protocol : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as OutboundRuleArgs | undefined;
            if (!args || args.backendAddressPoolId === undefined) {
                throw new Error("Missing required property 'backendAddressPoolId'");
            }
            if (!args || args.loadbalancerId === undefined) {
                throw new Error("Missing required property 'loadbalancerId'");
            }
            if (!args || args.protocol === undefined) {
                throw new Error("Missing required property 'protocol'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["allocatedOutboundPorts"] = args ? args.allocatedOutboundPorts : undefined;
            inputs["backendAddressPoolId"] = args ? args.backendAddressPoolId : undefined;
            inputs["enableTcpReset"] = args ? args.enableTcpReset : undefined;
            inputs["frontendIpConfigurations"] = args ? args.frontendIpConfigurations : undefined;
            inputs["idleTimeoutInMinutes"] = args ? args.idleTimeoutInMinutes : undefined;
            inputs["loadbalancerId"] = args ? args.loadbalancerId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["protocol"] = args ? args.protocol : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(OutboundRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OutboundRule resources.
 */
export interface OutboundRuleState {
    /**
     * The number of outbound ports to be used for NAT.
     */
    readonly allocatedOutboundPorts?: pulumi.Input<number>;
    /**
     * The ID of the Backend Address Pool. Outbound traffic is randomly load balanced across IPs in the backend IPs.
     */
    readonly backendAddressPoolId?: pulumi.Input<string>;
    /**
     * Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
     */
    readonly enableTcpReset?: pulumi.Input<boolean>;
    /**
     * One or more `frontendIpConfiguration` blocks as defined below.
     */
    readonly frontendIpConfigurations?: pulumi.Input<pulumi.Input<inputs.lb.OutboundRuleFrontendIpConfiguration>[]>;
    /**
     * The timeout for the TCP idle connection
     */
    readonly idleTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * The ID of the Load Balancer in which to create the Outbound Rule. Changing this forces a new resource to be created.
     */
    readonly loadbalancerId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Outbound Rule. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The transport protocol for the external endpoint. Possible values are `Udp`, `Tcp` or `All`.
     */
    readonly protocol?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the resource. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a OutboundRule resource.
 */
export interface OutboundRuleArgs {
    /**
     * The number of outbound ports to be used for NAT.
     */
    readonly allocatedOutboundPorts?: pulumi.Input<number>;
    /**
     * The ID of the Backend Address Pool. Outbound traffic is randomly load balanced across IPs in the backend IPs.
     */
    readonly backendAddressPoolId: pulumi.Input<string>;
    /**
     * Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
     */
    readonly enableTcpReset?: pulumi.Input<boolean>;
    /**
     * One or more `frontendIpConfiguration` blocks as defined below.
     */
    readonly frontendIpConfigurations?: pulumi.Input<pulumi.Input<inputs.lb.OutboundRuleFrontendIpConfiguration>[]>;
    /**
     * The timeout for the TCP idle connection
     */
    readonly idleTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * The ID of the Load Balancer in which to create the Outbound Rule. Changing this forces a new resource to be created.
     */
    readonly loadbalancerId: pulumi.Input<string>;
    /**
     * Specifies the name of the Outbound Rule. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The transport protocol for the external endpoint. Possible values are `Udp`, `Tcp` or `All`.
     */
    readonly protocol: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the resource. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
