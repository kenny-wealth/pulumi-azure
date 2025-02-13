// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Batch
{
    /// <summary>
    /// Manages a certificate in an Azure Batch account.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/batch_certificate.html.markdown.
    /// </summary>
    public partial class Certificate : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the name of the Batch account. Changing this forces a new resource to be created.
        /// </summary>
        [Output("accountName")]
        public Output<string> AccountName { get; private set; } = null!;

        /// <summary>
        /// The base64-encoded contents of the certificate.
        /// </summary>
        [Output("certificate")]
        public Output<string> BatchCertificate { get; private set; } = null!;

        /// <summary>
        /// The format of the certificate. Possible values are `Cer` or `Pfx`.
        /// </summary>
        [Output("format")]
        public Output<string> Format { get; private set; } = null!;

        /// <summary>
        /// The generated name of the certificate.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The password to access the certificate's private key. This must and can only be specified when `format` is `Pfx`.
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// The public key of the certificate.
        /// </summary>
        [Output("publicData")]
        public Output<string> PublicData { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Batch account. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The thumbprint of the certificate. At this time the only supported value is 'SHA1'.
        /// </summary>
        [Output("thumbprint")]
        public Output<string> Thumbprint { get; private set; } = null!;

        [Output("thumbprintAlgorithm")]
        public Output<string> ThumbprintAlgorithm { get; private set; } = null!;


        /// <summary>
        /// Create a Certificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Certificate(string name, CertificateArgs args, CustomResourceOptions? options = null)
            : base("azure:batch/certificate:Certificate", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Certificate(string name, Input<string> id, CertificateState? state = null, CustomResourceOptions? options = null)
            : base("azure:batch/certificate:Certificate", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Certificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Certificate Get(string name, Input<string> id, CertificateState? state = null, CustomResourceOptions? options = null)
        {
            return new Certificate(name, id, state, options);
        }
    }

    public sealed class CertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Batch account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The base64-encoded contents of the certificate.
        /// </summary>
        [Input("certificate", required: true)]
        public Input<string> BatchCertificate { get; set; } = null!;

        /// <summary>
        /// The format of the certificate. Possible values are `Cer` or `Pfx`.
        /// </summary>
        [Input("format", required: true)]
        public Input<string> Format { get; set; } = null!;

        /// <summary>
        /// The password to access the certificate's private key. This must and can only be specified when `format` is `Pfx`.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Batch account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The thumbprint of the certificate. At this time the only supported value is 'SHA1'.
        /// </summary>
        [Input("thumbprint", required: true)]
        public Input<string> Thumbprint { get; set; } = null!;

        [Input("thumbprintAlgorithm", required: true)]
        public Input<string> ThumbprintAlgorithm { get; set; } = null!;

        public CertificateArgs()
        {
        }
    }

    public sealed class CertificateState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Batch account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("accountName")]
        public Input<string>? AccountName { get; set; }

        /// <summary>
        /// The base64-encoded contents of the certificate.
        /// </summary>
        [Input("certificate")]
        public Input<string>? BatchCertificate { get; set; }

        /// <summary>
        /// The format of the certificate. Possible values are `Cer` or `Pfx`.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The generated name of the certificate.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The password to access the certificate's private key. This must and can only be specified when `format` is `Pfx`.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The public key of the certificate.
        /// </summary>
        [Input("publicData")]
        public Input<string>? PublicData { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Batch account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The thumbprint of the certificate. At this time the only supported value is 'SHA1'.
        /// </summary>
        [Input("thumbprint")]
        public Input<string>? Thumbprint { get; set; }

        [Input("thumbprintAlgorithm")]
        public Input<string>? ThumbprintAlgorithm { get; set; }

        public CertificateState()
        {
        }
    }
}
