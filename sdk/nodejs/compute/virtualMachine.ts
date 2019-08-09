// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/virtual_machine.html.markdown.
 */
export class VirtualMachine extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachine resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VirtualMachineState, opts?: pulumi.CustomResourceOptions): VirtualMachine {
        return new VirtualMachine(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:compute/virtualMachine:VirtualMachine';

    /**
     * Returns true if the given object is an instance of VirtualMachine.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachine {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachine.__pulumiType;
    }

    /**
     * The ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    public readonly availabilitySetId!: pulumi.Output<string>;
    /**
     * A `bootDiagnostics` block.
     */
    public readonly bootDiagnostics!: pulumi.Output<{ enabled: boolean, storageUri: string } | undefined>;
    /**
     * Should the Data Disks (either the Managed Disks / VHD Blobs) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    public readonly deleteDataDisksOnTermination!: pulumi.Output<boolean | undefined>;
    /**
     * Should the OS Disk (either the Managed Disk / VHD Blob) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    public readonly deleteOsDiskOnTermination!: pulumi.Output<boolean | undefined>;
    /**
     * A `identity` block.
     */
    public readonly identity!: pulumi.Output<{ identityIds?: string[], principalId: string, type: string }>;
    /**
     * Specifies the BYOL Type for this Virtual Machine. This is only applicable to Windows Virtual Machines. Possible values are `Windows_Client` and `Windows_Server`.
     */
    public readonly licenseType!: pulumi.Output<string>;
    /**
     * Specifies the Azure Region where the Virtual Machine exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name of the Virtual Machine. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A list of Network Interface ID's which should be associated with the Virtual Machine.
     */
    public readonly networkInterfaceIds!: pulumi.Output<string[]>;
    /**
     * An `osProfile` block. Required when `createOption` in the `storageOsDisk` block is set to `FromImage`.
     */
    public readonly osProfile!: pulumi.Output<{ adminPassword?: string, adminUsername: string, computerName: string, customData: string } | undefined>;
    /**
     * A `osProfileLinuxConfig` block.
     */
    public readonly osProfileLinuxConfig!: pulumi.Output<{ disablePasswordAuthentication: boolean, sshKeys?: { keyData: string, path: string }[] } | undefined>;
    /**
     * One or more `osProfileSecrets` blocks.
     */
    public readonly osProfileSecrets!: pulumi.Output<{ sourceVaultId: string, vaultCertificates?: { certificateStore?: string, certificateUrl: string }[] }[] | undefined>;
    /**
     * A `osProfileWindowsConfig` block.
     */
    public readonly osProfileWindowsConfig!: pulumi.Output<{ additionalUnattendConfigs?: { component: string, content: string, pass: string, settingName: string }[], enableAutomaticUpgrades?: boolean, provisionVmAgent?: boolean, timezone?: string, winrms?: { certificateUrl?: string, protocol: string }[] } | undefined>;
    /**
     * A `plan` block.
     */
    public readonly plan!: pulumi.Output<{ name: string, product: string, publisher: string } | undefined>;
    /**
     * The ID of the Network Interface (which must be attached to the Virtual Machine) which should be the Primary Network Interface for this Virtual Machine.
     */
    public readonly primaryNetworkInterfaceId!: pulumi.Output<string | undefined>;
    /**
     * Specifies the name of the Resource Group in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * One or more `storageDataDisk` blocks.
     */
    public readonly storageDataDisks!: pulumi.Output<{ caching: string, createOption: string, diskSizeGb: number, lun: number, managedDiskId: string, managedDiskType: string, name: string, vhdUri?: string, writeAcceleratorEnabled?: boolean }[]>;
    /**
     * A `storageImageReference` block.
     */
    public readonly storageImageReference!: pulumi.Output<{ id?: string, offer?: string, publisher?: string, sku?: string, version: string }>;
    /**
     * A `storageOsDisk` block.
     */
    public readonly storageOsDisk!: pulumi.Output<{ caching: string, createOption: string, diskSizeGb: number, imageUri?: string, managedDiskId: string, managedDiskType: string, name: string, osType: string, vhdUri?: string, writeAcceleratorEnabled?: boolean }>;
    /**
     * A mapping of tags to assign to the Virtual Machine.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any}>;
    /**
     * Specifies the [size of the Virtual Machine](https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-size-specs/).
     */
    public readonly vmSize!: pulumi.Output<string>;
    /**
     * A list of a single item of the Availability Zone which the Virtual Machine should be allocated in.
     */
    public readonly zones!: pulumi.Output<string | undefined>;

    /**
     * Create a VirtualMachine resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VirtualMachineArgs | VirtualMachineState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as VirtualMachineState | undefined;
            inputs["availabilitySetId"] = state ? state.availabilitySetId : undefined;
            inputs["bootDiagnostics"] = state ? state.bootDiagnostics : undefined;
            inputs["deleteDataDisksOnTermination"] = state ? state.deleteDataDisksOnTermination : undefined;
            inputs["deleteOsDiskOnTermination"] = state ? state.deleteOsDiskOnTermination : undefined;
            inputs["identity"] = state ? state.identity : undefined;
            inputs["licenseType"] = state ? state.licenseType : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkInterfaceIds"] = state ? state.networkInterfaceIds : undefined;
            inputs["osProfile"] = state ? state.osProfile : undefined;
            inputs["osProfileLinuxConfig"] = state ? state.osProfileLinuxConfig : undefined;
            inputs["osProfileSecrets"] = state ? state.osProfileSecrets : undefined;
            inputs["osProfileWindowsConfig"] = state ? state.osProfileWindowsConfig : undefined;
            inputs["plan"] = state ? state.plan : undefined;
            inputs["primaryNetworkInterfaceId"] = state ? state.primaryNetworkInterfaceId : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["storageDataDisks"] = state ? state.storageDataDisks : undefined;
            inputs["storageImageReference"] = state ? state.storageImageReference : undefined;
            inputs["storageOsDisk"] = state ? state.storageOsDisk : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vmSize"] = state ? state.vmSize : undefined;
            inputs["zones"] = state ? state.zones : undefined;
        } else {
            const args = argsOrState as VirtualMachineArgs | undefined;
            if (!args || args.networkInterfaceIds === undefined) {
                throw new Error("Missing required property 'networkInterfaceIds'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.storageOsDisk === undefined) {
                throw new Error("Missing required property 'storageOsDisk'");
            }
            if (!args || args.vmSize === undefined) {
                throw new Error("Missing required property 'vmSize'");
            }
            inputs["availabilitySetId"] = args ? args.availabilitySetId : undefined;
            inputs["bootDiagnostics"] = args ? args.bootDiagnostics : undefined;
            inputs["deleteDataDisksOnTermination"] = args ? args.deleteDataDisksOnTermination : undefined;
            inputs["deleteOsDiskOnTermination"] = args ? args.deleteOsDiskOnTermination : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["licenseType"] = args ? args.licenseType : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkInterfaceIds"] = args ? args.networkInterfaceIds : undefined;
            inputs["osProfile"] = args ? args.osProfile : undefined;
            inputs["osProfileLinuxConfig"] = args ? args.osProfileLinuxConfig : undefined;
            inputs["osProfileSecrets"] = args ? args.osProfileSecrets : undefined;
            inputs["osProfileWindowsConfig"] = args ? args.osProfileWindowsConfig : undefined;
            inputs["plan"] = args ? args.plan : undefined;
            inputs["primaryNetworkInterfaceId"] = args ? args.primaryNetworkInterfaceId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["storageDataDisks"] = args ? args.storageDataDisks : undefined;
            inputs["storageImageReference"] = args ? args.storageImageReference : undefined;
            inputs["storageOsDisk"] = args ? args.storageOsDisk : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vmSize"] = args ? args.vmSize : undefined;
            inputs["zones"] = args ? args.zones : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(VirtualMachine.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VirtualMachine resources.
 */
export interface VirtualMachineState {
    /**
     * The ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    readonly availabilitySetId?: pulumi.Input<string>;
    /**
     * A `bootDiagnostics` block.
     */
    readonly bootDiagnostics?: pulumi.Input<{ enabled: pulumi.Input<boolean>, storageUri: pulumi.Input<string> }>;
    /**
     * Should the Data Disks (either the Managed Disks / VHD Blobs) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    readonly deleteDataDisksOnTermination?: pulumi.Input<boolean>;
    /**
     * Should the OS Disk (either the Managed Disk / VHD Blob) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    readonly deleteOsDiskOnTermination?: pulumi.Input<boolean>;
    /**
     * A `identity` block.
     */
    readonly identity?: pulumi.Input<{ identityIds?: pulumi.Input<pulumi.Input<string>[]>, principalId?: pulumi.Input<string>, type: pulumi.Input<string> }>;
    /**
     * Specifies the BYOL Type for this Virtual Machine. This is only applicable to Windows Virtual Machines. Possible values are `Windows_Client` and `Windows_Server`.
     */
    readonly licenseType?: pulumi.Input<string>;
    /**
     * Specifies the Azure Region where the Virtual Machine exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the Virtual Machine. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of Network Interface ID's which should be associated with the Virtual Machine.
     */
    readonly networkInterfaceIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An `osProfile` block. Required when `createOption` in the `storageOsDisk` block is set to `FromImage`.
     */
    readonly osProfile?: pulumi.Input<{ adminPassword?: pulumi.Input<string>, adminUsername: pulumi.Input<string>, computerName: pulumi.Input<string>, customData?: pulumi.Input<string> }>;
    /**
     * A `osProfileLinuxConfig` block.
     */
    readonly osProfileLinuxConfig?: pulumi.Input<{ disablePasswordAuthentication: pulumi.Input<boolean>, sshKeys?: pulumi.Input<pulumi.Input<{ keyData: pulumi.Input<string>, path: pulumi.Input<string> }>[]> }>;
    /**
     * One or more `osProfileSecrets` blocks.
     */
    readonly osProfileSecrets?: pulumi.Input<pulumi.Input<{ sourceVaultId: pulumi.Input<string>, vaultCertificates?: pulumi.Input<pulumi.Input<{ certificateStore?: pulumi.Input<string>, certificateUrl: pulumi.Input<string> }>[]> }>[]>;
    /**
     * A `osProfileWindowsConfig` block.
     */
    readonly osProfileWindowsConfig?: pulumi.Input<{ additionalUnattendConfigs?: pulumi.Input<pulumi.Input<{ component: pulumi.Input<string>, content: pulumi.Input<string>, pass: pulumi.Input<string>, settingName: pulumi.Input<string> }>[]>, enableAutomaticUpgrades?: pulumi.Input<boolean>, provisionVmAgent?: pulumi.Input<boolean>, timezone?: pulumi.Input<string>, winrms?: pulumi.Input<pulumi.Input<{ certificateUrl?: pulumi.Input<string>, protocol: pulumi.Input<string> }>[]> }>;
    /**
     * A `plan` block.
     */
    readonly plan?: pulumi.Input<{ name: pulumi.Input<string>, product: pulumi.Input<string>, publisher: pulumi.Input<string> }>;
    /**
     * The ID of the Network Interface (which must be attached to the Virtual Machine) which should be the Primary Network Interface for this Virtual Machine.
     */
    readonly primaryNetworkInterfaceId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Resource Group in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * One or more `storageDataDisk` blocks.
     */
    readonly storageDataDisks?: pulumi.Input<pulumi.Input<{ caching?: pulumi.Input<string>, createOption: pulumi.Input<string>, diskSizeGb?: pulumi.Input<number>, lun: pulumi.Input<number>, managedDiskId?: pulumi.Input<string>, managedDiskType?: pulumi.Input<string>, name: pulumi.Input<string>, vhdUri?: pulumi.Input<string>, writeAcceleratorEnabled?: pulumi.Input<boolean> }>[]>;
    /**
     * A `storageImageReference` block.
     */
    readonly storageImageReference?: pulumi.Input<{ id?: pulumi.Input<string>, offer?: pulumi.Input<string>, publisher?: pulumi.Input<string>, sku?: pulumi.Input<string>, version?: pulumi.Input<string> }>;
    /**
     * A `storageOsDisk` block.
     */
    readonly storageOsDisk?: pulumi.Input<{ caching?: pulumi.Input<string>, createOption: pulumi.Input<string>, diskSizeGb?: pulumi.Input<number>, imageUri?: pulumi.Input<string>, managedDiskId?: pulumi.Input<string>, managedDiskType?: pulumi.Input<string>, name: pulumi.Input<string>, osType?: pulumi.Input<string>, vhdUri?: pulumi.Input<string>, writeAcceleratorEnabled?: pulumi.Input<boolean> }>;
    /**
     * A mapping of tags to assign to the Virtual Machine.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies the [size of the Virtual Machine](https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-size-specs/).
     */
    readonly vmSize?: pulumi.Input<string>;
    /**
     * A list of a single item of the Availability Zone which the Virtual Machine should be allocated in.
     */
    readonly zones?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VirtualMachine resource.
 */
export interface VirtualMachineArgs {
    /**
     * The ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    readonly availabilitySetId?: pulumi.Input<string>;
    /**
     * A `bootDiagnostics` block.
     */
    readonly bootDiagnostics?: pulumi.Input<{ enabled: pulumi.Input<boolean>, storageUri: pulumi.Input<string> }>;
    /**
     * Should the Data Disks (either the Managed Disks / VHD Blobs) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    readonly deleteDataDisksOnTermination?: pulumi.Input<boolean>;
    /**
     * Should the OS Disk (either the Managed Disk / VHD Blob) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    readonly deleteOsDiskOnTermination?: pulumi.Input<boolean>;
    /**
     * A `identity` block.
     */
    readonly identity?: pulumi.Input<{ identityIds?: pulumi.Input<pulumi.Input<string>[]>, principalId?: pulumi.Input<string>, type: pulumi.Input<string> }>;
    /**
     * Specifies the BYOL Type for this Virtual Machine. This is only applicable to Windows Virtual Machines. Possible values are `Windows_Client` and `Windows_Server`.
     */
    readonly licenseType?: pulumi.Input<string>;
    /**
     * Specifies the Azure Region where the Virtual Machine exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the Virtual Machine. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of Network Interface ID's which should be associated with the Virtual Machine.
     */
    readonly networkInterfaceIds: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An `osProfile` block. Required when `createOption` in the `storageOsDisk` block is set to `FromImage`.
     */
    readonly osProfile?: pulumi.Input<{ adminPassword?: pulumi.Input<string>, adminUsername: pulumi.Input<string>, computerName: pulumi.Input<string>, customData?: pulumi.Input<string> }>;
    /**
     * A `osProfileLinuxConfig` block.
     */
    readonly osProfileLinuxConfig?: pulumi.Input<{ disablePasswordAuthentication: pulumi.Input<boolean>, sshKeys?: pulumi.Input<pulumi.Input<{ keyData: pulumi.Input<string>, path: pulumi.Input<string> }>[]> }>;
    /**
     * One or more `osProfileSecrets` blocks.
     */
    readonly osProfileSecrets?: pulumi.Input<pulumi.Input<{ sourceVaultId: pulumi.Input<string>, vaultCertificates?: pulumi.Input<pulumi.Input<{ certificateStore?: pulumi.Input<string>, certificateUrl: pulumi.Input<string> }>[]> }>[]>;
    /**
     * A `osProfileWindowsConfig` block.
     */
    readonly osProfileWindowsConfig?: pulumi.Input<{ additionalUnattendConfigs?: pulumi.Input<pulumi.Input<{ component: pulumi.Input<string>, content: pulumi.Input<string>, pass: pulumi.Input<string>, settingName: pulumi.Input<string> }>[]>, enableAutomaticUpgrades?: pulumi.Input<boolean>, provisionVmAgent?: pulumi.Input<boolean>, timezone?: pulumi.Input<string>, winrms?: pulumi.Input<pulumi.Input<{ certificateUrl?: pulumi.Input<string>, protocol: pulumi.Input<string> }>[]> }>;
    /**
     * A `plan` block.
     */
    readonly plan?: pulumi.Input<{ name: pulumi.Input<string>, product: pulumi.Input<string>, publisher: pulumi.Input<string> }>;
    /**
     * The ID of the Network Interface (which must be attached to the Virtual Machine) which should be the Primary Network Interface for this Virtual Machine.
     */
    readonly primaryNetworkInterfaceId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Resource Group in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * One or more `storageDataDisk` blocks.
     */
    readonly storageDataDisks?: pulumi.Input<pulumi.Input<{ caching?: pulumi.Input<string>, createOption: pulumi.Input<string>, diskSizeGb?: pulumi.Input<number>, lun: pulumi.Input<number>, managedDiskId?: pulumi.Input<string>, managedDiskType?: pulumi.Input<string>, name: pulumi.Input<string>, vhdUri?: pulumi.Input<string>, writeAcceleratorEnabled?: pulumi.Input<boolean> }>[]>;
    /**
     * A `storageImageReference` block.
     */
    readonly storageImageReference?: pulumi.Input<{ id?: pulumi.Input<string>, offer?: pulumi.Input<string>, publisher?: pulumi.Input<string>, sku?: pulumi.Input<string>, version?: pulumi.Input<string> }>;
    /**
     * A `storageOsDisk` block.
     */
    readonly storageOsDisk: pulumi.Input<{ caching?: pulumi.Input<string>, createOption: pulumi.Input<string>, diskSizeGb?: pulumi.Input<number>, imageUri?: pulumi.Input<string>, managedDiskId?: pulumi.Input<string>, managedDiskType?: pulumi.Input<string>, name: pulumi.Input<string>, osType?: pulumi.Input<string>, vhdUri?: pulumi.Input<string>, writeAcceleratorEnabled?: pulumi.Input<boolean> }>;
    /**
     * A mapping of tags to assign to the Virtual Machine.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies the [size of the Virtual Machine](https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-size-specs/).
     */
    readonly vmSize: pulumi.Input<string>;
    /**
     * A list of a single item of the Availability Zone which the Virtual Machine should be allocated in.
     */
    readonly zones?: pulumi.Input<string>;
}
