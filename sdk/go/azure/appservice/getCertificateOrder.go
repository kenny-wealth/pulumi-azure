// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appservice

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing App Service Certificate Order.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/app_service_certificate_order.html.markdown.
func LookupCertificateOrder(ctx *pulumi.Context, args *GetCertificateOrderArgs) (*GetCertificateOrderResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:appservice/getCertificateOrder:getCertificateOrder", inputs)
	if err != nil {
		return nil, err
	}
	return &GetCertificateOrderResult{
		AppServiceCertificateNotRenewableReasons: outputs["appServiceCertificateNotRenewableReasons"],
		AutoRenew: outputs["autoRenew"],
		Certificates: outputs["certificates"],
		Csr: outputs["csr"],
		DistinguishedName: outputs["distinguishedName"],
		DomainVerificationToken: outputs["domainVerificationToken"],
		ExpirationTime: outputs["expirationTime"],
		IntermediateThumbprint: outputs["intermediateThumbprint"],
		IsPrivateKeyExternal: outputs["isPrivateKeyExternal"],
		KeySize: outputs["keySize"],
		Location: outputs["location"],
		Name: outputs["name"],
		ProductType: outputs["productType"],
		ResourceGroupName: outputs["resourceGroupName"],
		RootThumbprint: outputs["rootThumbprint"],
		SignedCertificateThumbprint: outputs["signedCertificateThumbprint"],
		Status: outputs["status"],
		Tags: outputs["tags"],
		ValidityInYears: outputs["validityInYears"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getCertificateOrder.
type GetCertificateOrderArgs struct {
	// The name of the App Service.
	Name interface{}
	// The Name of the Resource Group where the App Service exists.
	ResourceGroupName interface{}
}

// A collection of values returned by getCertificateOrder.
type GetCertificateOrderResult struct {
	// Reasons why App Service Certificate is not renewable at the current moment.
	AppServiceCertificateNotRenewableReasons interface{}
	// true if the certificate should be automatically renewed when it expires; otherwise, false.
	AutoRenew interface{}
	// State of the Key Vault secret. A `certificates` block as defined below.
	Certificates interface{}
	// Last CSR that was created for this order.
	Csr interface{}
	// The Distinguished Name for the App Service Certificate Order.
	DistinguishedName interface{}
	// Domain verification token.
	DomainVerificationToken interface{}
	// Certificate expiration time.
	ExpirationTime interface{}
	// Certificate thumbprint intermediate certificate.
	IntermediateThumbprint interface{}
	// Whether the private key is external or not.
	IsPrivateKeyExternal interface{}
	// Certificate key size.
	KeySize interface{}
	// The Azure location where the App Service exists.
	Location interface{}
	Name interface{}
	// Certificate product type, such as `Standard` or `WildCard`.
	ProductType interface{}
	ResourceGroupName interface{}
	// Certificate thumbprint for root certificate.
	RootThumbprint interface{}
	// Certificate thumbprint for signed certificate.
	SignedCertificateThumbprint interface{}
	// Current order status.
	Status interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// Duration in years (must be between 1 and 3).
	ValidityInYears interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
