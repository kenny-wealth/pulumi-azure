// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.DataFactory
{
    /// <summary>
    /// Manages an Azure Data Factory (Version 2).
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/data_factory.html.markdown.
    /// </summary>
    public partial class Factory : Pulumi.CustomResource
    {
        /// <summary>
        /// A `github_configuration` block as defined below.
        /// </summary>
        [Output("githubConfiguration")]
        public Output<Outputs.FactoryGithubConfiguration?> GithubConfiguration { get; private set; } = null!;

        /// <summary>
        /// An `identity` block as defined below.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.FactoryIdentity> Identity { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Data Factory. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Data Factory.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// A `vsts_configuration` block as defined below.
        /// </summary>
        [Output("vstsConfiguration")]
        public Output<Outputs.FactoryVstsConfiguration?> VstsConfiguration { get; private set; } = null!;


        /// <summary>
        /// Create a Factory resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Factory(string name, FactoryArgs args, CustomResourceOptions? options = null)
            : base("azure:datafactory/factory:Factory", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Factory(string name, Input<string> id, FactoryState? state = null, CustomResourceOptions? options = null)
            : base("azure:datafactory/factory:Factory", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Factory resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Factory Get(string name, Input<string> id, FactoryState? state = null, CustomResourceOptions? options = null)
        {
            return new Factory(name, id, state, options);
        }
    }

    public sealed class FactoryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `github_configuration` block as defined below.
        /// </summary>
        [Input("githubConfiguration")]
        public Input<Inputs.FactoryGithubConfigurationArgs>? GithubConfiguration { get; set; }

        /// <summary>
        /// An `identity` block as defined below.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.FactoryIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Data Factory. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Data Factory.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

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
        /// A `vsts_configuration` block as defined below.
        /// </summary>
        [Input("vstsConfiguration")]
        public Input<Inputs.FactoryVstsConfigurationArgs>? VstsConfiguration { get; set; }

        public FactoryArgs()
        {
        }
    }

    public sealed class FactoryState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `github_configuration` block as defined below.
        /// </summary>
        [Input("githubConfiguration")]
        public Input<Inputs.FactoryGithubConfigurationGetArgs>? GithubConfiguration { get; set; }

        /// <summary>
        /// An `identity` block as defined below.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.FactoryIdentityGetArgs>? Identity { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Data Factory. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Data Factory.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

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
        /// A `vsts_configuration` block as defined below.
        /// </summary>
        [Input("vstsConfiguration")]
        public Input<Inputs.FactoryVstsConfigurationGetArgs>? VstsConfiguration { get; set; }

        public FactoryState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class FactoryGithubConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        [Input("branchName", required: true)]
        public Input<string> BranchName { get; set; } = null!;

        [Input("gitUrl", required: true)]
        public Input<string> GitUrl { get; set; } = null!;

        [Input("repositoryName", required: true)]
        public Input<string> RepositoryName { get; set; } = null!;

        [Input("rootFolder", required: true)]
        public Input<string> RootFolder { get; set; } = null!;

        public FactoryGithubConfigurationArgs()
        {
        }
    }

    public sealed class FactoryGithubConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        [Input("branchName", required: true)]
        public Input<string> BranchName { get; set; } = null!;

        [Input("gitUrl", required: true)]
        public Input<string> GitUrl { get; set; } = null!;

        [Input("repositoryName", required: true)]
        public Input<string> RepositoryName { get; set; } = null!;

        [Input("rootFolder", required: true)]
        public Input<string> RootFolder { get; set; } = null!;

        public FactoryGithubConfigurationGetArgs()
        {
        }
    }

    public sealed class FactoryIdentityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Principal (Client) in Azure Active Directory
        /// </summary>
        [Input("principalId")]
        public Input<string>? PrincipalId { get; set; }

        /// <summary>
        /// The ID of the Azure Active Directory Tenant.
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public FactoryIdentityArgs()
        {
        }
    }

    public sealed class FactoryIdentityGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Principal (Client) in Azure Active Directory
        /// </summary>
        [Input("principalId")]
        public Input<string>? PrincipalId { get; set; }

        /// <summary>
        /// The ID of the Azure Active Directory Tenant.
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public FactoryIdentityGetArgs()
        {
        }
    }

    public sealed class FactoryVstsConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        [Input("branchName", required: true)]
        public Input<string> BranchName { get; set; } = null!;

        [Input("projectName", required: true)]
        public Input<string> ProjectName { get; set; } = null!;

        [Input("repositoryName", required: true)]
        public Input<string> RepositoryName { get; set; } = null!;

        [Input("rootFolder", required: true)]
        public Input<string> RootFolder { get; set; } = null!;

        /// <summary>
        /// The ID of the Azure Active Directory Tenant.
        /// </summary>
        [Input("tenantId", required: true)]
        public Input<string> TenantId { get; set; } = null!;

        public FactoryVstsConfigurationArgs()
        {
        }
    }

    public sealed class FactoryVstsConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        [Input("branchName", required: true)]
        public Input<string> BranchName { get; set; } = null!;

        [Input("projectName", required: true)]
        public Input<string> ProjectName { get; set; } = null!;

        [Input("repositoryName", required: true)]
        public Input<string> RepositoryName { get; set; } = null!;

        [Input("rootFolder", required: true)]
        public Input<string> RootFolder { get; set; } = null!;

        /// <summary>
        /// The ID of the Azure Active Directory Tenant.
        /// </summary>
        [Input("tenantId", required: true)]
        public Input<string> TenantId { get; set; } = null!;

        public FactoryVstsConfigurationGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class FactoryGithubConfiguration
    {
        public readonly string AccountName;
        public readonly string BranchName;
        public readonly string GitUrl;
        public readonly string RepositoryName;
        public readonly string RootFolder;

        [OutputConstructor]
        private FactoryGithubConfiguration(
            string accountName,
            string branchName,
            string gitUrl,
            string repositoryName,
            string rootFolder)
        {
            AccountName = accountName;
            BranchName = branchName;
            GitUrl = gitUrl;
            RepositoryName = repositoryName;
            RootFolder = rootFolder;
        }
    }

    [OutputType]
    public sealed class FactoryIdentity
    {
        /// <summary>
        /// The ID of the Principal (Client) in Azure Active Directory
        /// </summary>
        public readonly string PrincipalId;
        /// <summary>
        /// The ID of the Azure Active Directory Tenant.
        /// </summary>
        public readonly string TenantId;
        public readonly string Type;

        [OutputConstructor]
        private FactoryIdentity(
            string principalId,
            string tenantId,
            string type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }
    }

    [OutputType]
    public sealed class FactoryVstsConfiguration
    {
        public readonly string AccountName;
        public readonly string BranchName;
        public readonly string ProjectName;
        public readonly string RepositoryName;
        public readonly string RootFolder;
        /// <summary>
        /// The ID of the Azure Active Directory Tenant.
        /// </summary>
        public readonly string TenantId;

        [OutputConstructor]
        private FactoryVstsConfiguration(
            string accountName,
            string branchName,
            string projectName,
            string repositoryName,
            string rootFolder,
            string tenantId)
        {
            AccountName = accountName;
            BranchName = branchName;
            ProjectName = projectName;
            RepositoryName = repositoryName;
            RootFolder = rootFolder;
            TenantId = tenantId;
        }
    }
    }
}
