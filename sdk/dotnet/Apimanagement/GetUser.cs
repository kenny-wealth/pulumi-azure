// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ApiManagement
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing API Management User.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/api_management_user.html.markdown.
        /// </summary>
        public static Task<GetUserResult> GetUser(GetUserArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetUserResult>("azure:apimanagement/getUser:getUser", args, options.WithVersion());
    }

    public sealed class GetUserArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Name of the API Management Service in which this User exists.
        /// </summary>
        [Input("apiManagementName", required: true)]
        public Input<string> ApiManagementName { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group in which the API Management Service exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Identifier for the User.
        /// </summary>
        [Input("userId", required: true)]
        public Input<string> UserId { get; set; } = null!;

        public GetUserArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetUserResult
    {
        public readonly string ApiManagementName;
        /// <summary>
        /// The Email Address used for this User.
        /// </summary>
        public readonly string Email;
        /// <summary>
        /// The First Name for the User.
        /// </summary>
        public readonly string FirstName;
        /// <summary>
        /// The Last Name for the User.
        /// </summary>
        public readonly string LastName;
        /// <summary>
        /// Any notes about this User.
        /// </summary>
        public readonly string Note;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The current state of this User, for example `active`, `blocked` or `pending`.
        /// </summary>
        public readonly string State;
        public readonly string UserId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetUserResult(
            string apiManagementName,
            string email,
            string firstName,
            string lastName,
            string note,
            string resourceGroupName,
            string state,
            string userId,
            string id)
        {
            ApiManagementName = apiManagementName;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Note = note;
            ResourceGroupName = resourceGroupName;
            State = state;
            UserId = userId;
            Id = id;
        }
    }
}
