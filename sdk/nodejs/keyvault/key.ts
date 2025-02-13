// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Key Vault Key.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * import * as random from "@pulumi/random";
 * 
 * const current = azure.core.getClientConfig();
 * const testResourceGroup = new azure.core.ResourceGroup("test", {
 *     location: "West US",
 *     name: "my-resource-group",
 * });
 * const server = new random.RandomId("server", {
 *     byteLength: 8,
 *     keepers: {
 *         ami_id: 1,
 *     },
 * });
 * const testKeyVault = new azure.keyvault.KeyVault("test", {
 *     accessPolicies: [{
 *         keyPermissions: [
 *             "create",
 *             "get",
 *         ],
 *         objectId: current.servicePrincipalObjectId,
 *         secretPermissions: ["set"],
 *         tenantId: current.tenantId,
 *     }],
 *     location: testResourceGroup.location,
 *     name: "keyvaultkeyexample",
 *     resourceGroupName: testResourceGroup.name,
 *     skuName: "premium",
 *     tags: {
 *         environment: "Production",
 *     },
 *     tenantId: current.tenantId,
 * });
 * const generated = new azure.keyvault.Key("generated", {
 *     keyOpts: [
 *         "decrypt",
 *         "encrypt",
 *         "sign",
 *         "unwrapKey",
 *         "verify",
 *         "wrapKey",
 *     ],
 *     keySize: 2048,
 *     keyType: "RSA",
 *     keyVaultId: testKeyVault.id,
 *     name: "generated-certificate",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/key_vault_key.html.markdown.
 */
export class Key extends pulumi.CustomResource {
    /**
     * Get an existing Key resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KeyState, opts?: pulumi.CustomResourceOptions): Key {
        return new Key(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:keyvault/key:Key';

    /**
     * Returns true if the given object is an instance of Key.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Key {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Key.__pulumiType;
    }

    /**
     * Specifies the curve to use when creating an `EC` key. Possible values are `P-256`, `P-384`, `P-521`, and `SECP256K1`. This field will be required in a future release if `keyType` is `EC` or `EC-HSM`. The API will default to `P-256` if nothing is specified. Changing this forces a new resource to be created.
     */
    public readonly curve!: pulumi.Output<string>;
    /**
     * The RSA public exponent of this Key Vault Key.
     */
    public /*out*/ readonly e!: pulumi.Output<string>;
    /**
     * A list of JSON web key operations. Possible values include: `decrypt`, `encrypt`, `sign`, `unwrapKey`, `verify` and `wrapKey`. Please note these values are case sensitive.
     */
    public readonly keyOpts!: pulumi.Output<string[]>;
    /**
     * Specifies the Size of the RSA key to create in bytes. For example, 1024 or 2048. *Note*: This field is required if `keyType` is `RSA` or `RSA-HSM`. Changing this forces a new resource to be created.
     */
    public readonly keySize!: pulumi.Output<number | undefined>;
    /**
     * Specifies the Key Type to use for this Key Vault Key. Possible values are `EC` (Elliptic Curve), `EC-HSM`, `Oct` (Octet), `RSA` and `RSA-HSM`. Changing this forces a new resource to be created.
     */
    public readonly keyType!: pulumi.Output<string>;
    /**
     * The ID of the Key Vault where the Key should be created. Changing this forces a new resource to be created.
     */
    public readonly keyVaultId!: pulumi.Output<string>;
    /**
     * The RSA modulus of this Key Vault Key.
     */
    public /*out*/ readonly n!: pulumi.Output<string>;
    /**
     * Specifies the name of the Key Vault Key. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any}>;
    public readonly vaultUri!: pulumi.Output<string>;
    /**
     * The current version of the Key Vault Key.
     */
    public /*out*/ readonly version!: pulumi.Output<string>;
    /**
     * The EC X component of this Key Vault Key.
     */
    public /*out*/ readonly x!: pulumi.Output<string>;
    /**
     * The EC Y component of this Key Vault Key.
     */
    public /*out*/ readonly y!: pulumi.Output<string>;

    /**
     * Create a Key resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KeyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KeyArgs | KeyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as KeyState | undefined;
            inputs["curve"] = state ? state.curve : undefined;
            inputs["e"] = state ? state.e : undefined;
            inputs["keyOpts"] = state ? state.keyOpts : undefined;
            inputs["keySize"] = state ? state.keySize : undefined;
            inputs["keyType"] = state ? state.keyType : undefined;
            inputs["keyVaultId"] = state ? state.keyVaultId : undefined;
            inputs["n"] = state ? state.n : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vaultUri"] = state ? state.vaultUri : undefined;
            inputs["version"] = state ? state.version : undefined;
            inputs["x"] = state ? state.x : undefined;
            inputs["y"] = state ? state.y : undefined;
        } else {
            const args = argsOrState as KeyArgs | undefined;
            if (!args || args.keyOpts === undefined) {
                throw new Error("Missing required property 'keyOpts'");
            }
            if (!args || args.keyType === undefined) {
                throw new Error("Missing required property 'keyType'");
            }
            inputs["curve"] = args ? args.curve : undefined;
            inputs["keyOpts"] = args ? args.keyOpts : undefined;
            inputs["keySize"] = args ? args.keySize : undefined;
            inputs["keyType"] = args ? args.keyType : undefined;
            inputs["keyVaultId"] = args ? args.keyVaultId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vaultUri"] = args ? args.vaultUri : undefined;
            inputs["e"] = undefined /*out*/;
            inputs["n"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
            inputs["x"] = undefined /*out*/;
            inputs["y"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Key.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Key resources.
 */
export interface KeyState {
    /**
     * Specifies the curve to use when creating an `EC` key. Possible values are `P-256`, `P-384`, `P-521`, and `SECP256K1`. This field will be required in a future release if `keyType` is `EC` or `EC-HSM`. The API will default to `P-256` if nothing is specified. Changing this forces a new resource to be created.
     */
    readonly curve?: pulumi.Input<string>;
    /**
     * The RSA public exponent of this Key Vault Key.
     */
    readonly e?: pulumi.Input<string>;
    /**
     * A list of JSON web key operations. Possible values include: `decrypt`, `encrypt`, `sign`, `unwrapKey`, `verify` and `wrapKey`. Please note these values are case sensitive.
     */
    readonly keyOpts?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies the Size of the RSA key to create in bytes. For example, 1024 or 2048. *Note*: This field is required if `keyType` is `RSA` or `RSA-HSM`. Changing this forces a new resource to be created.
     */
    readonly keySize?: pulumi.Input<number>;
    /**
     * Specifies the Key Type to use for this Key Vault Key. Possible values are `EC` (Elliptic Curve), `EC-HSM`, `Oct` (Octet), `RSA` and `RSA-HSM`. Changing this forces a new resource to be created.
     */
    readonly keyType?: pulumi.Input<string>;
    /**
     * The ID of the Key Vault where the Key should be created. Changing this forces a new resource to be created.
     */
    readonly keyVaultId?: pulumi.Input<string>;
    /**
     * The RSA modulus of this Key Vault Key.
     */
    readonly n?: pulumi.Input<string>;
    /**
     * Specifies the name of the Key Vault Key. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    readonly vaultUri?: pulumi.Input<string>;
    /**
     * The current version of the Key Vault Key.
     */
    readonly version?: pulumi.Input<string>;
    /**
     * The EC X component of this Key Vault Key.
     */
    readonly x?: pulumi.Input<string>;
    /**
     * The EC Y component of this Key Vault Key.
     */
    readonly y?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Key resource.
 */
export interface KeyArgs {
    /**
     * Specifies the curve to use when creating an `EC` key. Possible values are `P-256`, `P-384`, `P-521`, and `SECP256K1`. This field will be required in a future release if `keyType` is `EC` or `EC-HSM`. The API will default to `P-256` if nothing is specified. Changing this forces a new resource to be created.
     */
    readonly curve?: pulumi.Input<string>;
    /**
     * A list of JSON web key operations. Possible values include: `decrypt`, `encrypt`, `sign`, `unwrapKey`, `verify` and `wrapKey`. Please note these values are case sensitive.
     */
    readonly keyOpts: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies the Size of the RSA key to create in bytes. For example, 1024 or 2048. *Note*: This field is required if `keyType` is `RSA` or `RSA-HSM`. Changing this forces a new resource to be created.
     */
    readonly keySize?: pulumi.Input<number>;
    /**
     * Specifies the Key Type to use for this Key Vault Key. Possible values are `EC` (Elliptic Curve), `EC-HSM`, `Oct` (Octet), `RSA` and `RSA-HSM`. Changing this forces a new resource to be created.
     */
    readonly keyType: pulumi.Input<string>;
    /**
     * The ID of the Key Vault where the Key should be created. Changing this forces a new resource to be created.
     */
    readonly keyVaultId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Key Vault Key. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    readonly vaultUri?: pulumi.Input<string>;
}
