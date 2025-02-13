// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package management

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Management Group.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/management_group.html.markdown.
func LookupGroup(ctx *pulumi.Context, args *GetGroupArgs) (*GetGroupResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["groupId"] = args.GroupId
	}
	outputs, err := ctx.Invoke("azure:management/getGroup:getGroup", inputs)
	if err != nil {
		return nil, err
	}
	return &GetGroupResult{
		DisplayName: outputs["displayName"],
		GroupId: outputs["groupId"],
		ParentManagementGroupId: outputs["parentManagementGroupId"],
		SubscriptionIds: outputs["subscriptionIds"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getGroup.
type GetGroupArgs struct {
	// Specifies the UUID of this Management Group.
	GroupId interface{}
}

// A collection of values returned by getGroup.
type GetGroupResult struct {
	// A friendly name for the Management Group.
	DisplayName interface{}
	GroupId interface{}
	// The ID of any Parent Management Group.
	ParentManagementGroupId interface{}
	// A list of Subscription ID's which are assigned to the Management Group.
	SubscriptionIds interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
