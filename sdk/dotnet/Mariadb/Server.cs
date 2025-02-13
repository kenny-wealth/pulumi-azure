// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.MariaDB
{
    /// <summary>
    /// Manages a MariaDB Server.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/mariadb_server.html.markdown.
    /// </summary>
    public partial class Server : Pulumi.CustomResource
    {
        /// <summary>
        /// The Administrator Login for the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Output("administratorLogin")]
        public Output<string> AdministratorLogin { get; private set; } = null!;

        /// <summary>
        /// The Password associated with the `administrator_login` for the MariaDB Server.
        /// </summary>
        [Output("administratorLoginPassword")]
        public Output<string> AdministratorLoginPassword { get; private set; } = null!;

        /// <summary>
        /// The FQDN of the MariaDB Server.
        /// </summary>
        [Output("fqdn")]
        public Output<string> Fqdn { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `sku` block as defined below.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.ServerSku> Sku { get; private set; } = null!;

        /// <summary>
        /// Specifies if SSL should be enforced on connections. Possible values are `Enabled` and `Disabled`.
        /// </summary>
        [Output("sslEnforcement")]
        public Output<string> SslEnforcement { get; private set; } = null!;

        /// <summary>
        /// A `storage_profile` block as defined below.
        /// </summary>
        [Output("storageProfile")]
        public Output<Outputs.ServerStorageProfile> StorageProfile { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// Specifies the version of MariaDB to use. Possible values are `10.2` and `10.3`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Server resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Server(string name, ServerArgs args, CustomResourceOptions? options = null)
            : base("azure:mariadb/server:Server", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Server(string name, Input<string> id, ServerState? state = null, CustomResourceOptions? options = null)
            : base("azure:mariadb/server:Server", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Server resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Server Get(string name, Input<string> id, ServerState? state = null, CustomResourceOptions? options = null)
        {
            return new Server(name, id, state, options);
        }
    }

    public sealed class ServerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Administrator Login for the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("administratorLogin", required: true)]
        public Input<string> AdministratorLogin { get; set; } = null!;

        /// <summary>
        /// The Password associated with the `administrator_login` for the MariaDB Server.
        /// </summary>
        [Input("administratorLoginPassword", required: true)]
        public Input<string> AdministratorLoginPassword { get; set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A `sku` block as defined below.
        /// </summary>
        [Input("sku", required: true)]
        public Input<Inputs.ServerSkuArgs> Sku { get; set; } = null!;

        /// <summary>
        /// Specifies if SSL should be enforced on connections. Possible values are `Enabled` and `Disabled`.
        /// </summary>
        [Input("sslEnforcement", required: true)]
        public Input<string> SslEnforcement { get; set; } = null!;

        /// <summary>
        /// A `storage_profile` block as defined below.
        /// </summary>
        [Input("storageProfile", required: true)]
        public Input<Inputs.ServerStorageProfileArgs> StorageProfile { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies the version of MariaDB to use. Possible values are `10.2` and `10.3`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public ServerArgs()
        {
        }
    }

    public sealed class ServerState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Administrator Login for the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("administratorLogin")]
        public Input<string>? AdministratorLogin { get; set; }

        /// <summary>
        /// The Password associated with the `administrator_login` for the MariaDB Server.
        /// </summary>
        [Input("administratorLoginPassword")]
        public Input<string>? AdministratorLoginPassword { get; set; }

        /// <summary>
        /// The FQDN of the MariaDB Server.
        /// </summary>
        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// A `sku` block as defined below.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.ServerSkuGetArgs>? Sku { get; set; }

        /// <summary>
        /// Specifies if SSL should be enforced on connections. Possible values are `Enabled` and `Disabled`.
        /// </summary>
        [Input("sslEnforcement")]
        public Input<string>? SslEnforcement { get; set; }

        /// <summary>
        /// A `storage_profile` block as defined below.
        /// </summary>
        [Input("storageProfile")]
        public Input<Inputs.ServerStorageProfileGetArgs>? StorageProfile { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies the version of MariaDB to use. Possible values are `10.2` and `10.3`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ServerState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ServerSkuArgs : Pulumi.ResourceArgs
    {
        [Input("capacity", required: true)]
        public Input<int> Capacity { get; set; } = null!;

        [Input("family", required: true)]
        public Input<string> Family { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("tier", required: true)]
        public Input<string> Tier { get; set; } = null!;

        public ServerSkuArgs()
        {
        }
    }

    public sealed class ServerSkuGetArgs : Pulumi.ResourceArgs
    {
        [Input("capacity", required: true)]
        public Input<int> Capacity { get; set; } = null!;

        [Input("family", required: true)]
        public Input<string> Family { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("tier", required: true)]
        public Input<string> Tier { get; set; } = null!;

        public ServerSkuGetArgs()
        {
        }
    }

    public sealed class ServerStorageProfileArgs : Pulumi.ResourceArgs
    {
        [Input("autoGrow")]
        public Input<string>? AutoGrow { get; set; }

        [Input("backupRetentionDays")]
        public Input<int>? BackupRetentionDays { get; set; }

        [Input("geoRedundantBackup")]
        public Input<string>? GeoRedundantBackup { get; set; }

        [Input("storageMb", required: true)]
        public Input<int> StorageMb { get; set; } = null!;

        public ServerStorageProfileArgs()
        {
        }
    }

    public sealed class ServerStorageProfileGetArgs : Pulumi.ResourceArgs
    {
        [Input("autoGrow")]
        public Input<string>? AutoGrow { get; set; }

        [Input("backupRetentionDays")]
        public Input<int>? BackupRetentionDays { get; set; }

        [Input("geoRedundantBackup")]
        public Input<string>? GeoRedundantBackup { get; set; }

        [Input("storageMb", required: true)]
        public Input<int> StorageMb { get; set; } = null!;

        public ServerStorageProfileGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ServerSku
    {
        public readonly int Capacity;
        public readonly string Family;
        /// <summary>
        /// Specifies the name of the MariaDB Server. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;
        public readonly string Tier;

        [OutputConstructor]
        private ServerSku(
            int capacity,
            string family,
            string name,
            string tier)
        {
            Capacity = capacity;
            Family = family;
            Name = name;
            Tier = tier;
        }
    }

    [OutputType]
    public sealed class ServerStorageProfile
    {
        public readonly string? AutoGrow;
        public readonly int? BackupRetentionDays;
        public readonly string? GeoRedundantBackup;
        public readonly int StorageMb;

        [OutputConstructor]
        private ServerStorageProfile(
            string? autoGrow,
            int? backupRetentionDays,
            string? geoRedundantBackup,
            int storageMb)
        {
            AutoGrow = autoGrow;
            BackupRetentionDays = backupRetentionDays;
            GeoRedundantBackup = geoRedundantBackup;
            StorageMb = storageMb;
        }
    }
    }
}
