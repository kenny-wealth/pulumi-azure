// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package storage

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to obtain a Shared Access Signature (SAS Token) for an existing Storage Account.
// 
// Shared access signatures allow fine-grained, ephemeral access control to various aspects of an Azure Storage Account.
// 
// Note that this is an [Account SAS](https://docs.microsoft.com/en-us/rest/api/storageservices/constructing-an-account-sas)
// and *not* a [Service SAS](https://docs.microsoft.com/en-us/rest/api/storageservices/constructing-a-service-sas).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/storage_account_sas.html.markdown.
func LookupAccountSAS(ctx *pulumi.Context, args *GetAccountSASArgs) (*GetAccountSASResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["connectionString"] = args.ConnectionString
		inputs["expiry"] = args.Expiry
		inputs["httpsOnly"] = args.HttpsOnly
		inputs["permissions"] = args.Permissions
		inputs["resourceTypes"] = args.ResourceTypes
		inputs["services"] = args.Services
		inputs["start"] = args.Start
	}
	outputs, err := ctx.Invoke("azure:storage/getAccountSAS:getAccountSAS", inputs)
	if err != nil {
		return nil, err
	}
	return &GetAccountSASResult{
		ConnectionString: outputs["connectionString"],
		Expiry: outputs["expiry"],
		HttpsOnly: outputs["httpsOnly"],
		Permissions: outputs["permissions"],
		ResourceTypes: outputs["resourceTypes"],
		Sas: outputs["sas"],
		Services: outputs["services"],
		Start: outputs["start"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getAccountSAS.
type GetAccountSASArgs struct {
	// The connection string for the storage account to which this SAS applies. Typically directly from the `primaryConnectionString` attribute of a `storage.Account` resource.
	ConnectionString interface{}
	// The expiration time and date of this SAS. Must be a valid ISO-8601 format time/date string.
	Expiry interface{}
	// Only permit `https` access. If `false`, both `http` and `https` are permitted. Defaults to `true`.
	HttpsOnly interface{}
	// A `permissions` block as defined below.
	Permissions interface{}
	// A `resourceTypes` block as defined below.
	ResourceTypes interface{}
	// A `services` block as defined below.
	Services interface{}
	// The starting time and date of validity of this SAS. Must be a valid ISO-8601 format time/date string.
	Start interface{}
}

// A collection of values returned by getAccountSAS.
type GetAccountSASResult struct {
	ConnectionString interface{}
	Expiry interface{}
	HttpsOnly interface{}
	Permissions interface{}
	ResourceTypes interface{}
	// The computed Account Shared Access Signature (SAS).
	Sas interface{}
	Services interface{}
	Start interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
