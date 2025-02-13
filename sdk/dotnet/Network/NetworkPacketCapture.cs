// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    /// <summary>
    /// Configures Network Packet Capturing against a Virtual Machine using a Network Watcher.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/network_packet_capture.html.markdown.
    /// </summary>
    public partial class NetworkPacketCapture : Pulumi.CustomResource
    {
        /// <summary>
        /// One or more `filter` blocks as defined below. Changing this forces a new resource to be created.
        /// </summary>
        [Output("filters")]
        public Output<ImmutableArray<Outputs.NetworkPacketCaptureFilters>> Filters { get; private set; } = null!;

        /// <summary>
        /// The number of bytes captured per packet. The remaining bytes are truncated. Defaults to `0` (Entire Packet Captured). Changing this forces a new resource to be created.
        /// </summary>
        [Output("maximumBytesPerPacket")]
        public Output<int?> MaximumBytesPerPacket { get; private set; } = null!;

        /// <summary>
        /// Maximum size of the capture in Bytes. Defaults to `1073741824` (1GB). Changing this forces a new resource to be created.
        /// </summary>
        [Output("maximumBytesPerSession")]
        public Output<int?> MaximumBytesPerSession { get; private set; } = null!;

        /// <summary>
        /// The maximum duration of the capture session in seconds. Defaults to `18000` (5 hours). Changing this forces a new resource to be created.
        /// </summary>
        [Output("maximumCaptureDuration")]
        public Output<int?> MaximumCaptureDuration { get; private set; } = null!;

        /// <summary>
        /// The name to use for this Network Packet Capture. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Network Watcher. Changing this forces a new resource to be created.
        /// </summary>
        [Output("networkWatcherName")]
        public Output<string> NetworkWatcherName { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Network Watcher exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `storage_location` block as defined below. Changing this forces a new resource to be created.
        /// </summary>
        [Output("storageLocation")]
        public Output<Outputs.NetworkPacketCaptureStorageLocation> StorageLocation { get; private set; } = null!;

        /// <summary>
        /// The ID of the Resource to capture packets from. Changing this forces a new resource to be created.
        /// </summary>
        [Output("targetResourceId")]
        public Output<string> TargetResourceId { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkPacketCapture resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkPacketCapture(string name, NetworkPacketCaptureArgs args, CustomResourceOptions? options = null)
            : base("azure:network/networkPacketCapture:NetworkPacketCapture", name, args, MakeResourceOptions(options, ""))
        {
        }

        private NetworkPacketCapture(string name, Input<string> id, NetworkPacketCaptureState? state = null, CustomResourceOptions? options = null)
            : base("azure:network/networkPacketCapture:NetworkPacketCapture", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NetworkPacketCapture resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkPacketCapture Get(string name, Input<string> id, NetworkPacketCaptureState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkPacketCapture(name, id, state, options);
        }
    }

    public sealed class NetworkPacketCaptureArgs : Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<Inputs.NetworkPacketCaptureFiltersArgs>? _filters;

        /// <summary>
        /// One or more `filter` blocks as defined below. Changing this forces a new resource to be created.
        /// </summary>
        public InputList<Inputs.NetworkPacketCaptureFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.NetworkPacketCaptureFiltersArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The number of bytes captured per packet. The remaining bytes are truncated. Defaults to `0` (Entire Packet Captured). Changing this forces a new resource to be created.
        /// </summary>
        [Input("maximumBytesPerPacket")]
        public Input<int>? MaximumBytesPerPacket { get; set; }

        /// <summary>
        /// Maximum size of the capture in Bytes. Defaults to `1073741824` (1GB). Changing this forces a new resource to be created.
        /// </summary>
        [Input("maximumBytesPerSession")]
        public Input<int>? MaximumBytesPerSession { get; set; }

        /// <summary>
        /// The maximum duration of the capture session in seconds. Defaults to `18000` (5 hours). Changing this forces a new resource to be created.
        /// </summary>
        [Input("maximumCaptureDuration")]
        public Input<int>? MaximumCaptureDuration { get; set; }

        /// <summary>
        /// The name to use for this Network Packet Capture. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Network Watcher. Changing this forces a new resource to be created.
        /// </summary>
        [Input("networkWatcherName", required: true)]
        public Input<string> NetworkWatcherName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Network Watcher exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A `storage_location` block as defined below. Changing this forces a new resource to be created.
        /// </summary>
        [Input("storageLocation", required: true)]
        public Input<Inputs.NetworkPacketCaptureStorageLocationArgs> StorageLocation { get; set; } = null!;

        /// <summary>
        /// The ID of the Resource to capture packets from. Changing this forces a new resource to be created.
        /// </summary>
        [Input("targetResourceId", required: true)]
        public Input<string> TargetResourceId { get; set; } = null!;

        public NetworkPacketCaptureArgs()
        {
        }
    }

    public sealed class NetworkPacketCaptureState : Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<Inputs.NetworkPacketCaptureFiltersGetArgs>? _filters;

        /// <summary>
        /// One or more `filter` blocks as defined below. Changing this forces a new resource to be created.
        /// </summary>
        public InputList<Inputs.NetworkPacketCaptureFiltersGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.NetworkPacketCaptureFiltersGetArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The number of bytes captured per packet. The remaining bytes are truncated. Defaults to `0` (Entire Packet Captured). Changing this forces a new resource to be created.
        /// </summary>
        [Input("maximumBytesPerPacket")]
        public Input<int>? MaximumBytesPerPacket { get; set; }

        /// <summary>
        /// Maximum size of the capture in Bytes. Defaults to `1073741824` (1GB). Changing this forces a new resource to be created.
        /// </summary>
        [Input("maximumBytesPerSession")]
        public Input<int>? MaximumBytesPerSession { get; set; }

        /// <summary>
        /// The maximum duration of the capture session in seconds. Defaults to `18000` (5 hours). Changing this forces a new resource to be created.
        /// </summary>
        [Input("maximumCaptureDuration")]
        public Input<int>? MaximumCaptureDuration { get; set; }

        /// <summary>
        /// The name to use for this Network Packet Capture. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Network Watcher. Changing this forces a new resource to be created.
        /// </summary>
        [Input("networkWatcherName")]
        public Input<string>? NetworkWatcherName { get; set; }

        /// <summary>
        /// The name of the resource group in which the Network Watcher exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// A `storage_location` block as defined below. Changing this forces a new resource to be created.
        /// </summary>
        [Input("storageLocation")]
        public Input<Inputs.NetworkPacketCaptureStorageLocationGetArgs>? StorageLocation { get; set; }

        /// <summary>
        /// The ID of the Resource to capture packets from. Changing this forces a new resource to be created.
        /// </summary>
        [Input("targetResourceId")]
        public Input<string>? TargetResourceId { get; set; }

        public NetworkPacketCaptureState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class NetworkPacketCaptureFiltersArgs : Pulumi.ResourceArgs
    {
        [Input("localIpAddress")]
        public Input<string>? LocalIpAddress { get; set; }

        [Input("localPort")]
        public Input<string>? LocalPort { get; set; }

        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        [Input("remoteIpAddress")]
        public Input<string>? RemoteIpAddress { get; set; }

        [Input("remotePort")]
        public Input<string>? RemotePort { get; set; }

        public NetworkPacketCaptureFiltersArgs()
        {
        }
    }

    public sealed class NetworkPacketCaptureFiltersGetArgs : Pulumi.ResourceArgs
    {
        [Input("localIpAddress")]
        public Input<string>? LocalIpAddress { get; set; }

        [Input("localPort")]
        public Input<string>? LocalPort { get; set; }

        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        [Input("remoteIpAddress")]
        public Input<string>? RemoteIpAddress { get; set; }

        [Input("remotePort")]
        public Input<string>? RemotePort { get; set; }

        public NetworkPacketCaptureFiltersGetArgs()
        {
        }
    }

    public sealed class NetworkPacketCaptureStorageLocationArgs : Pulumi.ResourceArgs
    {
        [Input("filePath")]
        public Input<string>? FilePath { get; set; }

        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

        /// <summary>
        /// The URI of the storage path to save the packet capture.
        /// </summary>
        [Input("storagePath")]
        public Input<string>? StoragePath { get; set; }

        public NetworkPacketCaptureStorageLocationArgs()
        {
        }
    }

    public sealed class NetworkPacketCaptureStorageLocationGetArgs : Pulumi.ResourceArgs
    {
        [Input("filePath")]
        public Input<string>? FilePath { get; set; }

        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

        /// <summary>
        /// The URI of the storage path to save the packet capture.
        /// </summary>
        [Input("storagePath")]
        public Input<string>? StoragePath { get; set; }

        public NetworkPacketCaptureStorageLocationGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class NetworkPacketCaptureFilters
    {
        public readonly string? LocalIpAddress;
        public readonly string? LocalPort;
        public readonly string Protocol;
        public readonly string? RemoteIpAddress;
        public readonly string? RemotePort;

        [OutputConstructor]
        private NetworkPacketCaptureFilters(
            string? localIpAddress,
            string? localPort,
            string protocol,
            string? remoteIpAddress,
            string? remotePort)
        {
            LocalIpAddress = localIpAddress;
            LocalPort = localPort;
            Protocol = protocol;
            RemoteIpAddress = remoteIpAddress;
            RemotePort = remotePort;
        }
    }

    [OutputType]
    public sealed class NetworkPacketCaptureStorageLocation
    {
        public readonly string? FilePath;
        public readonly string? StorageAccountId;
        /// <summary>
        /// The URI of the storage path to save the packet capture.
        /// </summary>
        public readonly string StoragePath;

        [OutputConstructor]
        private NetworkPacketCaptureStorageLocation(
            string? filePath,
            string? storageAccountId,
            string storagePath)
        {
            FilePath = filePath;
            StorageAccountId = storageAccountId;
            StoragePath = storagePath;
        }
    }
    }
}
