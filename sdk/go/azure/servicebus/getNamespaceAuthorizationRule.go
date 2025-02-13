// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package servicebus

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing ServiceBus Namespace Authorization Rule.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/servicebus_namespace_authorization_rule.html.markdown.
func LookupNamespaceAuthorizationRule(ctx *pulumi.Context, args *GetNamespaceAuthorizationRuleArgs) (*GetNamespaceAuthorizationRuleResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["namespaceName"] = args.NamespaceName
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:servicebus/getNamespaceAuthorizationRule:getNamespaceAuthorizationRule", inputs)
	if err != nil {
		return nil, err
	}
	return &GetNamespaceAuthorizationRuleResult{
		Name: outputs["name"],
		NamespaceName: outputs["namespaceName"],
		PrimaryConnectionString: outputs["primaryConnectionString"],
		PrimaryKey: outputs["primaryKey"],
		ResourceGroupName: outputs["resourceGroupName"],
		SecondaryConnectionString: outputs["secondaryConnectionString"],
		SecondaryKey: outputs["secondaryKey"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getNamespaceAuthorizationRule.
type GetNamespaceAuthorizationRuleArgs struct {
	// Specifies the name of the ServiceBus Namespace Authorization Rule.
	Name interface{}
	// Specifies the name of the ServiceBus Namespace.
	NamespaceName interface{}
	// Specifies the name of the Resource Group where the ServiceBus Namespace exists.
	ResourceGroupName interface{}
}

// A collection of values returned by getNamespaceAuthorizationRule.
type GetNamespaceAuthorizationRuleResult struct {
	Name interface{}
	NamespaceName interface{}
	// The primary connection string for the authorization rule.
	PrimaryConnectionString interface{}
	// The primary access key for the authorization rule.
	PrimaryKey interface{}
	ResourceGroupName interface{}
	// The secondary connection string for the authorization rule.
	SecondaryConnectionString interface{}
	// The secondary access key for the authorization rule.
	SecondaryKey interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
