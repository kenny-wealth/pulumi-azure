// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Stream Analytics Output to Microsoft SQL Server Database.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = azure.core.getResourceGroup({
 *     name: "example-resources",
 * });
 * const exampleJob = azurerm_resource_group_example.name.apply(name => azure.streamanalytics.getJob({
 *     name: "example-job",
 *     resourceGroupName: name,
 * }));
 * const exampleSqlServer = new azure.sql.SqlServer("example", {
 *     administratorLogin: "dbadmin",
 *     administratorLoginPassword: "example-password",
 *     location: azurerm_resource_group_example.location,
 *     name: "example-server",
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     version: "12.0",
 * });
 * const exampleDatabase = new azure.sql.Database("example", {
 *     collation: "SQL_LATIN1_GENERAL_CP1_CI_AS",
 *     createMode: "Default",
 *     location: azurerm_resource_group_example.location,
 *     maxSizeBytes: "268435456000",
 *     name: "exampledb",
 *     requestedServiceObjectiveName: "S0",
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     serverName: exampleSqlServer.name,
 * });
 * const exampleOutputMssql = new azure.streamanalytics.OutputMssql("example", {
 *     database: exampleDatabase.name,
 *     name: "example-output-sql",
 *     password: exampleSqlServer.administratorLoginPassword,
 *     resourceGroupName: azurerm_stream_analytics_job_example.resourceGroupName,
 *     server: exampleSqlServer.fullyQualifiedDomainName,
 *     streamAnalyticsJobName: azurerm_stream_analytics_job_example.name,
 *     table: "ExampleTable",
 *     user: exampleSqlServer.administratorLogin,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/stream_analytics_output_mssql.html.markdown.
 */
export class OutputMssql extends pulumi.CustomResource {
    /**
     * Get an existing OutputMssql resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OutputMssqlState, opts?: pulumi.CustomResourceOptions): OutputMssql {
        return new OutputMssql(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:streamanalytics/outputMssql:OutputMssql';

    /**
     * Returns true if the given object is an instance of OutputMssql.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OutputMssql {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OutputMssql.__pulumiType;
    }

    public readonly database!: pulumi.Output<string>;
    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Password used together with username, to login to the Microsoft SQL Server. Changing this forces a new resource to be created.
     */
    public readonly password!: pulumi.Output<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The SQL server url. Changing this forces a new resource to be created.
     */
    public readonly server!: pulumi.Output<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    public readonly streamAnalyticsJobName!: pulumi.Output<string>;
    /**
     * Table in the database that the output points to. Changing this forces a new resource to be created.
     */
    public readonly table!: pulumi.Output<string>;
    /**
     * Username used to login to the Microsoft SQL Server. Changing this forces a new resource to be created.
     */
    public readonly user!: pulumi.Output<string>;

    /**
     * Create a OutputMssql resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OutputMssqlArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OutputMssqlArgs | OutputMssqlState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as OutputMssqlState | undefined;
            inputs["database"] = state ? state.database : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["password"] = state ? state.password : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["server"] = state ? state.server : undefined;
            inputs["streamAnalyticsJobName"] = state ? state.streamAnalyticsJobName : undefined;
            inputs["table"] = state ? state.table : undefined;
            inputs["user"] = state ? state.user : undefined;
        } else {
            const args = argsOrState as OutputMssqlArgs | undefined;
            if (!args || args.database === undefined) {
                throw new Error("Missing required property 'database'");
            }
            if (!args || args.password === undefined) {
                throw new Error("Missing required property 'password'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.server === undefined) {
                throw new Error("Missing required property 'server'");
            }
            if (!args || args.streamAnalyticsJobName === undefined) {
                throw new Error("Missing required property 'streamAnalyticsJobName'");
            }
            if (!args || args.table === undefined) {
                throw new Error("Missing required property 'table'");
            }
            if (!args || args.user === undefined) {
                throw new Error("Missing required property 'user'");
            }
            inputs["database"] = args ? args.database : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["password"] = args ? args.password : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["server"] = args ? args.server : undefined;
            inputs["streamAnalyticsJobName"] = args ? args.streamAnalyticsJobName : undefined;
            inputs["table"] = args ? args.table : undefined;
            inputs["user"] = args ? args.user : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(OutputMssql.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OutputMssql resources.
 */
export interface OutputMssqlState {
    readonly database?: pulumi.Input<string>;
    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Password used together with username, to login to the Microsoft SQL Server. Changing this forces a new resource to be created.
     */
    readonly password?: pulumi.Input<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The SQL server url. Changing this forces a new resource to be created.
     */
    readonly server?: pulumi.Input<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    readonly streamAnalyticsJobName?: pulumi.Input<string>;
    /**
     * Table in the database that the output points to. Changing this forces a new resource to be created.
     */
    readonly table?: pulumi.Input<string>;
    /**
     * Username used to login to the Microsoft SQL Server. Changing this forces a new resource to be created.
     */
    readonly user?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a OutputMssql resource.
 */
export interface OutputMssqlArgs {
    readonly database: pulumi.Input<string>;
    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Password used together with username, to login to the Microsoft SQL Server. Changing this forces a new resource to be created.
     */
    readonly password: pulumi.Input<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The SQL server url. Changing this forces a new resource to be created.
     */
    readonly server: pulumi.Input<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    readonly streamAnalyticsJobName: pulumi.Input<string>;
    /**
     * Table in the database that the output points to. Changing this forces a new resource to be created.
     */
    readonly table: pulumi.Input<string>;
    /**
     * Username used to login to the Microsoft SQL Server. Changing this forces a new resource to be created.
     */
    readonly user: pulumi.Input<string>;
}
