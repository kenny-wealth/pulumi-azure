// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package monitoring

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access the properties of an Action Group.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/monitor_action_group.html.markdown.
func LookupActionGroup(ctx *pulumi.Context, args *GetActionGroupArgs) (*GetActionGroupResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:monitoring/getActionGroup:getActionGroup", inputs)
	if err != nil {
		return nil, err
	}
	return &GetActionGroupResult{
		EmailReceivers: outputs["emailReceivers"],
		Enabled: outputs["enabled"],
		Name: outputs["name"],
		ResourceGroupName: outputs["resourceGroupName"],
		ShortName: outputs["shortName"],
		SmsReceivers: outputs["smsReceivers"],
		WebhookReceivers: outputs["webhookReceivers"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getActionGroup.
type GetActionGroupArgs struct {
	// Specifies the name of the Action Group.
	Name interface{}
	// Specifies the name of the resource group the Action Group is located in.
	ResourceGroupName interface{}
}

// A collection of values returned by getActionGroup.
type GetActionGroupResult struct {
	// One or more `emailReceiver` blocks as defined below.
	EmailReceivers interface{}
	// Whether this action group is enabled.
	Enabled interface{}
	// The name of the webhook receiver. 
	Name interface{}
	ResourceGroupName interface{}
	// The short name of the action group.
	ShortName interface{}
	// One or more `smsReceiver ` blocks as defined below.
	SmsReceivers interface{}
	// One or more `webhookReceiver ` blocks as defined below.
	WebhookReceivers interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
