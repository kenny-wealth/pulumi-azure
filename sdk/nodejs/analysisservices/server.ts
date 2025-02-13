// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages an Analysis Services Server.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const rg = new azure.core.ResourceGroup("rg", {
 *     location: "northeurope",
 *     name: "analysis-services-server-test",
 * });
 * const server = new azure.analysisservices.Server("server", {
 *     adminUsers: ["myuser@domain.tld"],
 *     enablePowerBiService: true,
 *     ipv4FirewallRules: [{
 *         name: "myRule1",
 *         rangeEnd: "210.117.252.255",
 *         rangeStart: "210.117.252.0",
 *     }],
 *     location: "northeurope",
 *     name: "analysisservicesserver",
 *     resourceGroupName: rg.name,
 *     sku: "S0",
 *     tags: {
 *         abc: 123,
 *     },
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/analysis_services_server.html.markdown.
 */
export class Server extends pulumi.CustomResource {
    /**
     * Get an existing Server resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServerState, opts?: pulumi.CustomResourceOptions): Server {
        return new Server(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:analysisservices/server:Server';

    /**
     * Returns true if the given object is an instance of Server.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Server {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Server.__pulumiType;
    }

    /**
     * List of email addresses of admin users.
     */
    public readonly adminUsers!: pulumi.Output<string[] | undefined>;
    /**
     * URI and SAS token for a blob container to store backups.
     */
    public readonly backupBlobContainerUri!: pulumi.Output<string | undefined>;
    /**
     * Indicates if the Power BI service is allowed to access or not.
     */
    public readonly enablePowerBiService!: pulumi.Output<boolean | undefined>;
    /**
     * One or more `ipv4FirewallRule` block(s) as defined below.
     */
    public readonly ipv4FirewallRules!: pulumi.Output<outputs.analysisservices.ServerIpv4FirewallRule[] | undefined>;
    /**
     * The Azure location where the Analysis Services Server exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name of the firewall rule.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Controls how the read-write server is used in the query pool. If this values is set to `All` then read-write servers are also used for queries. Otherwise with `ReadOnly` these servers do not participate in query operations.
     */
    public readonly querypoolConnectionMode!: pulumi.Output<string>;
    /**
     * The name of the Resource Group in which the Analysis Services Server should be exist. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The full name of the Analysis Services Server.
     */
    public /*out*/ readonly serverFullName!: pulumi.Output<string>;
    /**
     * SKU for the Analysis Services Server. Possible values are: `D1`, `B1`, `B2`, `S0`, `S1`, `S2`, `S4`, `S8` and `S9`
     */
    public readonly sku!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a Server resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServerArgs | ServerState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ServerState | undefined;
            inputs["adminUsers"] = state ? state.adminUsers : undefined;
            inputs["backupBlobContainerUri"] = state ? state.backupBlobContainerUri : undefined;
            inputs["enablePowerBiService"] = state ? state.enablePowerBiService : undefined;
            inputs["ipv4FirewallRules"] = state ? state.ipv4FirewallRules : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["querypoolConnectionMode"] = state ? state.querypoolConnectionMode : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["serverFullName"] = state ? state.serverFullName : undefined;
            inputs["sku"] = state ? state.sku : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as ServerArgs | undefined;
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sku === undefined) {
                throw new Error("Missing required property 'sku'");
            }
            inputs["adminUsers"] = args ? args.adminUsers : undefined;
            inputs["backupBlobContainerUri"] = args ? args.backupBlobContainerUri : undefined;
            inputs["enablePowerBiService"] = args ? args.enablePowerBiService : undefined;
            inputs["ipv4FirewallRules"] = args ? args.ipv4FirewallRules : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["querypoolConnectionMode"] = args ? args.querypoolConnectionMode : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["serverFullName"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Server.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Server resources.
 */
export interface ServerState {
    /**
     * List of email addresses of admin users.
     */
    readonly adminUsers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * URI and SAS token for a blob container to store backups.
     */
    readonly backupBlobContainerUri?: pulumi.Input<string>;
    /**
     * Indicates if the Power BI service is allowed to access or not.
     */
    readonly enablePowerBiService?: pulumi.Input<boolean>;
    /**
     * One or more `ipv4FirewallRule` block(s) as defined below.
     */
    readonly ipv4FirewallRules?: pulumi.Input<pulumi.Input<inputs.analysisservices.ServerIpv4FirewallRule>[]>;
    /**
     * The Azure location where the Analysis Services Server exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the firewall rule.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Controls how the read-write server is used in the query pool. If this values is set to `All` then read-write servers are also used for queries. Otherwise with `ReadOnly` these servers do not participate in query operations.
     */
    readonly querypoolConnectionMode?: pulumi.Input<string>;
    /**
     * The name of the Resource Group in which the Analysis Services Server should be exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The full name of the Analysis Services Server.
     */
    readonly serverFullName?: pulumi.Input<string>;
    /**
     * SKU for the Analysis Services Server. Possible values are: `D1`, `B1`, `B2`, `S0`, `S1`, `S2`, `S4`, `S8` and `S9`
     */
    readonly sku?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a Server resource.
 */
export interface ServerArgs {
    /**
     * List of email addresses of admin users.
     */
    readonly adminUsers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * URI and SAS token for a blob container to store backups.
     */
    readonly backupBlobContainerUri?: pulumi.Input<string>;
    /**
     * Indicates if the Power BI service is allowed to access or not.
     */
    readonly enablePowerBiService?: pulumi.Input<boolean>;
    /**
     * One or more `ipv4FirewallRule` block(s) as defined below.
     */
    readonly ipv4FirewallRules?: pulumi.Input<pulumi.Input<inputs.analysisservices.ServerIpv4FirewallRule>[]>;
    /**
     * The Azure location where the Analysis Services Server exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the firewall rule.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Controls how the read-write server is used in the query pool. If this values is set to `All` then read-write servers are also used for queries. Otherwise with `ReadOnly` these servers do not participate in query operations.
     */
    readonly querypoolConnectionMode?: pulumi.Input<string>;
    /**
     * The name of the Resource Group in which the Analysis Services Server should be exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * SKU for the Analysis Services Server. Possible values are: `D1`, `B1`, `B2`, `S0`, `S1`, `S2`, `S4`, `S8` and `S9`
     */
    readonly sku: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
