require (
	github.com/Azure/go-autorest/autorest/azure/cli v0.3.0
	github.com/hashicorp/terraform-plugin-sdk v1.1.1
	github.com/pkg/errors v0.8.1
	github.com/pulumi/pulumi v1.2.0
	github.com/pulumi/pulumi-terraform-bridge v1.2.1-0.20191106001426-e727be072e34
	github.com/stretchr/testify v1.4.0
	github.com/terraform-providers/terraform-provider-azurerm v1.36.0
	golang.org/x/xerrors v0.0.0-20190717185122-a985d3407aa7 // indirect
)

replace (
	github.com/hashicorp/vault => github.com/hashicorp/vault v1.2.0
	github.com/terraform-providers/terraform-provider-azurerm => github.com/pulumi/terraform-provider-azurerm v0.0.0-20191029195905-e81fa5ad3ed3
)

module github.com/pulumi/pulumi-azure

go 1.13
