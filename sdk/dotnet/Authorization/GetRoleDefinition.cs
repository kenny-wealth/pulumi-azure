// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Authorization
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Role Definition.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/role_definition.html.markdown.
        /// </summary>
        public static Task<GetRoleDefinitionResult> GetRoleDefinition(GetRoleDefinitionArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRoleDefinitionResult>("azure:authorization/getRoleDefinition:getRoleDefinition", args, options.WithVersion());
    }

    public sealed class GetRoleDefinitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the Name of either a built-in or custom Role Definition.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the ID of the Role Definition as a UUID/GUID.
        /// </summary>
        [Input("roleDefinitionId")]
        public Input<string>? RoleDefinitionId { get; set; }

        /// <summary>
        /// Specifies the Scope at which the Custom Role Definition exists.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public GetRoleDefinitionArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetRoleDefinitionResult
    {
        /// <summary>
        /// One or more assignable scopes for this Role Definition, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`.
        /// </summary>
        public readonly ImmutableArray<string> AssignableScopes;
        /// <summary>
        /// the Description of the built-in Role.
        /// </summary>
        public readonly string Description;
        public readonly string Name;
        /// <summary>
        /// a `permissions` block as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRoleDefinitionPermissionsResult> Permissions;
        public readonly string RoleDefinitionId;
        public readonly string? Scope;
        /// <summary>
        /// the Type of the Role.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetRoleDefinitionResult(
            ImmutableArray<string> assignableScopes,
            string description,
            string name,
            ImmutableArray<Outputs.GetRoleDefinitionPermissionsResult> permissions,
            string roleDefinitionId,
            string? scope,
            string type,
            string id)
        {
            AssignableScopes = assignableScopes;
            Description = description;
            Name = name;
            Permissions = permissions;
            RoleDefinitionId = roleDefinitionId;
            Scope = scope;
            Type = type;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetRoleDefinitionPermissionsResult
    {
        /// <summary>
        /// a list of actions supported by this role
        /// </summary>
        public readonly ImmutableArray<string> Actions;
        public readonly ImmutableArray<string> DataActions;
        /// <summary>
        /// a list of actions which are denied by this role
        /// </summary>
        public readonly ImmutableArray<string> NotActions;
        public readonly ImmutableArray<string> NotDataActions;

        [OutputConstructor]
        private GetRoleDefinitionPermissionsResult(
            ImmutableArray<string> actions,
            ImmutableArray<string> dataActions,
            ImmutableArray<string> notActions,
            ImmutableArray<string> notDataActions)
        {
            Actions = actions;
            DataActions = dataActions;
            NotActions = notActions;
            NotDataActions = notDataActions;
        }
    }
    }
}
