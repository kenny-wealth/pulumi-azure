// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datafactory

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Azure Data Factory (Version 2).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/data_factory.html.markdown.
func LookupFactory(ctx *pulumi.Context, args *GetFactoryArgs) (*GetFactoryResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:datafactory/getFactory:getFactory", inputs)
	if err != nil {
		return nil, err
	}
	return &GetFactoryResult{
		GithubConfigurations: outputs["githubConfigurations"],
		Identities: outputs["identities"],
		Location: outputs["location"],
		Name: outputs["name"],
		ResourceGroupName: outputs["resourceGroupName"],
		Tags: outputs["tags"],
		VstsConfigurations: outputs["vstsConfigurations"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getFactory.
type GetFactoryArgs struct {
	// Specifies the name of the Data Factory to retrieve information about. 
	Name interface{}
	// The name of the resource group where the Data Factory exists.
	ResourceGroupName interface{}
}

// A collection of values returned by getFactory.
type GetFactoryResult struct {
	// A `githubConfiguration` block as defined below.
	GithubConfigurations interface{}
	// An `identity` block as defined below.
	Identities interface{}
	// The Azure location where the resource exists.
	Location interface{}
	Name interface{}
	ResourceGroupName interface{}
	// A mapping of tags assigned to the resource.
	// ---
	Tags interface{}
	// A `vstsConfiguration` block as defined below.
	VstsConfigurations interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
