// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Managed Kubernetes Cluster (AKS).
 * 
 * > **Note:** All arguments including the client secret will be stored in the raw state as plain-text.
 * [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const test = azure.containerservice.getKubernetesCluster({
 *     name: "myakscluster",
 *     resourceGroupName: "my-example-resource-group",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/kubernetes_cluster.html.markdown.
 */
export function getKubernetesCluster(args: GetKubernetesClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetKubernetesClusterResult> & GetKubernetesClusterResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetKubernetesClusterResult> = pulumi.runtime.invoke("azure:containerservice/getKubernetesCluster:getKubernetesCluster", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getKubernetesCluster.
 */
export interface GetKubernetesClusterArgs {
    /**
     * The name of the managed Kubernetes Cluster.
     */
    readonly name: string;
    /**
     * The name of the Resource Group in which the managed Kubernetes Cluster exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getKubernetesCluster.
 */
export interface GetKubernetesClusterResult {
    /**
     * A `addonProfile` block as documented below.
     */
    readonly addonProfiles: outputs.containerservice.GetKubernetesClusterAddonProfile[];
    /**
     * An `agentPoolProfile` block as documented below.
     */
    readonly agentPoolProfiles: outputs.containerservice.GetKubernetesClusterAgentPoolProfile[];
    /**
     * The DNS Prefix of the managed Kubernetes cluster.
     */
    readonly dnsPrefix: string;
    /**
     * The FQDN of the Azure Kubernetes Managed Cluster.
     */
    readonly fqdn: string;
    /**
     * A `kubeAdminConfig` block as defined below. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    readonly kubeAdminConfigs: outputs.containerservice.GetKubernetesClusterKubeAdminConfig[];
    /**
     * Raw Kubernetes config for the admin account to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    readonly kubeAdminConfigRaw: string;
    /**
     * A `kubeConfig` block as defined below.
     */
    readonly kubeConfigs: outputs.containerservice.GetKubernetesClusterKubeConfig[];
    /**
     * Base64 encoded Kubernetes configuration.
     */
    readonly kubeConfigRaw: string;
    /**
     * The version of Kubernetes used on the managed Kubernetes Cluster.
     */
    readonly kubernetesVersion: string;
    /**
     * A `linuxProfile` block as documented below.
     */
    readonly linuxProfiles: outputs.containerservice.GetKubernetesClusterLinuxProfile[];
    /**
     * The Azure Region in which the managed Kubernetes Cluster exists.
     */
    readonly location: string;
    /**
     * The name assigned to this pool of agents.
     */
    readonly name: string;
    /**
     * A `networkProfile` block as documented below.
     */
    readonly networkProfiles: outputs.containerservice.GetKubernetesClusterNetworkProfile[];
    /**
     * Auto-generated Resource Group containing AKS Cluster resources.
     */
    readonly nodeResourceGroup: string;
    readonly resourceGroupName: string;
    /**
     * A `roleBasedAccessControl` block as documented below.
     */
    readonly roleBasedAccessControls: outputs.containerservice.GetKubernetesClusterRoleBasedAccessControl[];
    /**
     * A `servicePrincipal` block as documented below.
     */
    readonly servicePrincipals: outputs.containerservice.GetKubernetesClusterServicePrincipal[];
    /**
     * A mapping of tags assigned to this resource.
     */
    readonly tags: {[key: string]: string};
    /**
     * A `windowsProfile` block as documented below.
     */
    readonly windowsProfiles: outputs.containerservice.GetKubernetesClusterWindowsProfile[];
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
