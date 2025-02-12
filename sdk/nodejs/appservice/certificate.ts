// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages an App Service certificate.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/app_service_certificate.html.markdown.
 */
export class Certificate extends pulumi.CustomResource {
    /**
     * Get an existing Certificate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CertificateState, opts?: pulumi.CustomResourceOptions): Certificate {
        return new Certificate(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:appservice/certificate:Certificate';

    /**
     * Returns true if the given object is an instance of Certificate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Certificate {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Certificate.__pulumiType;
    }

    /**
     * The expiration date for the certificate.
     */
    public /*out*/ readonly expirationDate!: pulumi.Output<string>;
    /**
     * The friendly name of the certificate.
     */
    public /*out*/ readonly friendlyName!: pulumi.Output<string>;
    /**
     * List of host names the certificate applies to.
     */
    public /*out*/ readonly hostNames!: pulumi.Output<string[]>;
    /**
     * The issue date for the certificate.
     */
    public /*out*/ readonly issueDate!: pulumi.Output<string>;
    /**
     * The name of the certificate issuer.
     */
    public /*out*/ readonly issuer!: pulumi.Output<string>;
    /**
     * The ID of the Key Vault secret. Changing this forces a new resource to be created.
     */
    public readonly keyVaultSecretId!: pulumi.Output<string | undefined>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name of the certificate. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The password to access the certificate's private key. Changing this forces a new resource to be created.
     */
    public readonly password!: pulumi.Output<string | undefined>;
    /**
     * The base64-encoded contents of the certificate. Changing this forces a new resource to be created.
     */
    public readonly pfxBlob!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource group in which to create the certificate. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The subject name of the certificate.
     */
    public /*out*/ readonly subjectName!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<{[key: string]: any}>;
    /**
     * The thumbprint for the certificate.
     */
    public /*out*/ readonly thumbprint!: pulumi.Output<string>;

    /**
     * Create a Certificate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CertificateArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CertificateArgs | CertificateState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as CertificateState | undefined;
            inputs["expirationDate"] = state ? state.expirationDate : undefined;
            inputs["friendlyName"] = state ? state.friendlyName : undefined;
            inputs["hostNames"] = state ? state.hostNames : undefined;
            inputs["issueDate"] = state ? state.issueDate : undefined;
            inputs["issuer"] = state ? state.issuer : undefined;
            inputs["keyVaultSecretId"] = state ? state.keyVaultSecretId : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["password"] = state ? state.password : undefined;
            inputs["pfxBlob"] = state ? state.pfxBlob : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["subjectName"] = state ? state.subjectName : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["thumbprint"] = state ? state.thumbprint : undefined;
        } else {
            const args = argsOrState as CertificateArgs | undefined;
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["keyVaultSecretId"] = args ? args.keyVaultSecretId : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["password"] = args ? args.password : undefined;
            inputs["pfxBlob"] = args ? args.pfxBlob : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["expirationDate"] = undefined /*out*/;
            inputs["friendlyName"] = undefined /*out*/;
            inputs["hostNames"] = undefined /*out*/;
            inputs["issueDate"] = undefined /*out*/;
            inputs["issuer"] = undefined /*out*/;
            inputs["subjectName"] = undefined /*out*/;
            inputs["thumbprint"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Certificate.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Certificate resources.
 */
export interface CertificateState {
    /**
     * The expiration date for the certificate.
     */
    readonly expirationDate?: pulumi.Input<string>;
    /**
     * The friendly name of the certificate.
     */
    readonly friendlyName?: pulumi.Input<string>;
    /**
     * List of host names the certificate applies to.
     */
    readonly hostNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The issue date for the certificate.
     */
    readonly issueDate?: pulumi.Input<string>;
    /**
     * The name of the certificate issuer.
     */
    readonly issuer?: pulumi.Input<string>;
    /**
     * The ID of the Key Vault secret. Changing this forces a new resource to be created.
     */
    readonly keyVaultSecretId?: pulumi.Input<string>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the certificate. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The password to access the certificate's private key. Changing this forces a new resource to be created.
     */
    readonly password?: pulumi.Input<string>;
    /**
     * The base64-encoded contents of the certificate. Changing this forces a new resource to be created.
     */
    readonly pfxBlob?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the certificate. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The subject name of the certificate.
     */
    readonly subjectName?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The thumbprint for the certificate.
     */
    readonly thumbprint?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Certificate resource.
 */
export interface CertificateArgs {
    /**
     * The ID of the Key Vault secret. Changing this forces a new resource to be created.
     */
    readonly keyVaultSecretId?: pulumi.Input<string>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the certificate. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The password to access the certificate's private key. Changing this forces a new resource to be created.
     */
    readonly password?: pulumi.Input<string>;
    /**
     * The base64-encoded contents of the certificate. Changing this forces a new resource to be created.
     */
    readonly pfxBlob?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the certificate. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
