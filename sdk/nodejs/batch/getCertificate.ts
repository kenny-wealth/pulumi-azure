// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing certificate in a Batch Account.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const example = pulumi.output(azure.batch.getCertificate({
 *     accountName: "examplebatchaccount",
 *     name: "SHA1-42C107874FD0E4A9583292A2F1098E8FE4B2EDDA",
 *     resourceGroupName: "example",
 * }));
 * 
 * export const thumbprint = example.thumbprint;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/batch_certificate.html.markdown.
 */
export function getCertificate(args: GetCertificateArgs, opts?: pulumi.InvokeOptions): Promise<GetCertificateResult> & GetCertificateResult {
    const promise: Promise<GetCertificateResult> = pulumi.runtime.invoke("azure:batch/getCertificate:getCertificate", {
        "accountName": args.accountName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getCertificate.
 */
export interface GetCertificateArgs {
    /**
     * The name of the Batch account.
     */
    readonly accountName: string;
    /**
     * The name of the Batch certificate.
     */
    readonly name: string;
    /**
     * The Name of the Resource Group where this Batch account exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getCertificate.
 */
export interface GetCertificateResult {
    readonly accountName: string;
    /**
     * The format of the certificate, such as `Cer` or `Pfx`.
     */
    readonly format: string;
    readonly name: string;
    /**
     * The public key of the certificate.
     */
    readonly publicData: string;
    readonly resourceGroupName: string;
    /**
     * The thumbprint of the certificate.
     */
    readonly thumbprint: string;
    /**
     * The algorithm of the certificate thumbprint.
     */
    readonly thumbprintAlgorithm: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
