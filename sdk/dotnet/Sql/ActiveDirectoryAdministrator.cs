// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Sql
{
    /// <summary>
    /// Allows you to set a user or group as the AD administrator for an Azure SQL server
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/sql_active_directory_administrator.html.markdown.
    /// </summary>
    public partial class ActiveDirectoryAdministrator : Pulumi.CustomResource
    {
        /// <summary>
        /// The login name of the principal to set as the server administrator
        /// </summary>
        [Output("login")]
        public Output<string> Login { get; private set; } = null!;

        /// <summary>
        /// The ID of the principal to set as the server administrator
        /// </summary>
        [Output("objectId")]
        public Output<string> ObjectId { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group for the SQL server. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The name of the SQL Server on which to set the administrator. Changing this forces a new resource to be created.
        /// </summary>
        [Output("serverName")]
        public Output<string> ServerName { get; private set; } = null!;

        /// <summary>
        /// The Azure Tenant ID
        /// </summary>
        [Output("tenantId")]
        public Output<string> TenantId { get; private set; } = null!;


        /// <summary>
        /// Create a ActiveDirectoryAdministrator resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ActiveDirectoryAdministrator(string name, ActiveDirectoryAdministratorArgs args, CustomResourceOptions? options = null)
            : base("azure:sql/activeDirectoryAdministrator:ActiveDirectoryAdministrator", name, args, MakeResourceOptions(options, ""))
        {
        }

        private ActiveDirectoryAdministrator(string name, Input<string> id, ActiveDirectoryAdministratorState? state = null, CustomResourceOptions? options = null)
            : base("azure:sql/activeDirectoryAdministrator:ActiveDirectoryAdministrator", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ActiveDirectoryAdministrator resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ActiveDirectoryAdministrator Get(string name, Input<string> id, ActiveDirectoryAdministratorState? state = null, CustomResourceOptions? options = null)
        {
            return new ActiveDirectoryAdministrator(name, id, state, options);
        }
    }

    public sealed class ActiveDirectoryAdministratorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The login name of the principal to set as the server administrator
        /// </summary>
        [Input("login", required: true)]
        public Input<string> Login { get; set; } = null!;

        /// <summary>
        /// The ID of the principal to set as the server administrator
        /// </summary>
        [Input("objectId", required: true)]
        public Input<string> ObjectId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group for the SQL server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the SQL Server on which to set the administrator. Changing this forces a new resource to be created.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        /// <summary>
        /// The Azure Tenant ID
        /// </summary>
        [Input("tenantId", required: true)]
        public Input<string> TenantId { get; set; } = null!;

        public ActiveDirectoryAdministratorArgs()
        {
        }
    }

    public sealed class ActiveDirectoryAdministratorState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The login name of the principal to set as the server administrator
        /// </summary>
        [Input("login")]
        public Input<string>? Login { get; set; }

        /// <summary>
        /// The ID of the principal to set as the server administrator
        /// </summary>
        [Input("objectId")]
        public Input<string>? ObjectId { get; set; }

        /// <summary>
        /// The name of the resource group for the SQL server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The name of the SQL Server on which to set the administrator. Changing this forces a new resource to be created.
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        /// <summary>
        /// The Azure Tenant ID
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        public ActiveDirectoryAdministratorState()
        {
        }
    }
}
