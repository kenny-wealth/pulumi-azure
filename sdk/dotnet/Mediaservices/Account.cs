// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.MediaServices
{
    /// <summary>
    /// Manages a Media Services Account.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/media_services_account.html.markdown.
    /// </summary>
    public partial class Account : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// One or more `storage_account` blocks as defined below.
        /// </summary>
        [Output("storageAccounts")]
        public Output<ImmutableArray<Outputs.AccountStorageAccounts>> StorageAccounts { get; private set; } = null!;


        /// <summary>
        /// Create a Account resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Account(string name, AccountArgs args, CustomResourceOptions? options = null)
            : base("azure:mediaservices/account:Account", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Account(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
            : base("azure:mediaservices/account:Account", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Account resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Account Get(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
        {
            return new Account(name, id, state, options);
        }
    }

    public sealed class AccountArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("storageAccounts", required: true)]
        private InputList<Inputs.AccountStorageAccountsArgs>? _storageAccounts;

        /// <summary>
        /// One or more `storage_account` blocks as defined below.
        /// </summary>
        public InputList<Inputs.AccountStorageAccountsArgs> StorageAccounts
        {
            get => _storageAccounts ?? (_storageAccounts = new InputList<Inputs.AccountStorageAccountsArgs>());
            set => _storageAccounts = value;
        }

        public AccountArgs()
        {
        }
    }

    public sealed class AccountState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("storageAccounts")]
        private InputList<Inputs.AccountStorageAccountsGetArgs>? _storageAccounts;

        /// <summary>
        /// One or more `storage_account` blocks as defined below.
        /// </summary>
        public InputList<Inputs.AccountStorageAccountsGetArgs> StorageAccounts
        {
            get => _storageAccounts ?? (_storageAccounts = new InputList<Inputs.AccountStorageAccountsGetArgs>());
            set => _storageAccounts = value;
        }

        public AccountState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class AccountStorageAccountsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Resource ID of the Media Services Account.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("isPrimary")]
        public Input<bool>? IsPrimary { get; set; }

        public AccountStorageAccountsArgs()
        {
        }
    }

    public sealed class AccountStorageAccountsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Resource ID of the Media Services Account.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("isPrimary")]
        public Input<bool>? IsPrimary { get; set; }

        public AccountStorageAccountsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class AccountStorageAccounts
    {
        /// <summary>
        /// The Resource ID of the Media Services Account.
        /// </summary>
        public readonly string Id;
        public readonly bool? IsPrimary;

        [OutputConstructor]
        private AccountStorageAccounts(
            string id,
            bool? isPrimary)
        {
            Id = id;
            IsPrimary = isPrimary;
        }
    }
    }
}
