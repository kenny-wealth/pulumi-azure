// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Shared Image within a Shared Image Gallery.
// 
// -> **NOTE** Shared Image Galleries are currently in Public Preview. You can find more information, including [how to register for the Public Preview here](https://azure.microsoft.com/en-gb/blog/announcing-the-public-preview-of-shared-image-gallery/).
type SharedImage struct {
	s *pulumi.ResourceState
}

// NewSharedImage registers a new resource with the given unique name, arguments, and options.
func NewSharedImage(ctx *pulumi.Context,
	name string, args *SharedImageArgs, opts ...pulumi.ResourceOpt) (*SharedImage, error) {
	if args == nil || args.GalleryName == nil {
		return nil, errors.New("missing required argument 'GalleryName'")
	}
	if args == nil || args.Identifier == nil {
		return nil, errors.New("missing required argument 'Identifier'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.OsType == nil {
		return nil, errors.New("missing required argument 'OsType'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["description"] = nil
		inputs["eula"] = nil
		inputs["galleryName"] = nil
		inputs["identifier"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["osType"] = nil
		inputs["privacyStatementUri"] = nil
		inputs["releaseNoteUri"] = nil
		inputs["resourceGroupName"] = nil
		inputs["tags"] = nil
	} else {
		inputs["description"] = args.Description
		inputs["eula"] = args.Eula
		inputs["galleryName"] = args.GalleryName
		inputs["identifier"] = args.Identifier
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["osType"] = args.OsType
		inputs["privacyStatementUri"] = args.PrivacyStatementUri
		inputs["releaseNoteUri"] = args.ReleaseNoteUri
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["tags"] = args.Tags
	}
	s, err := ctx.RegisterResource("azure:compute/sharedImage:SharedImage", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SharedImage{s: s}, nil
}

// GetSharedImage gets an existing SharedImage resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSharedImage(ctx *pulumi.Context,
	name string, id pulumi.ID, state *SharedImageState, opts ...pulumi.ResourceOpt) (*SharedImage, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["description"] = state.Description
		inputs["eula"] = state.Eula
		inputs["galleryName"] = state.GalleryName
		inputs["identifier"] = state.Identifier
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["osType"] = state.OsType
		inputs["privacyStatementUri"] = state.PrivacyStatementUri
		inputs["releaseNoteUri"] = state.ReleaseNoteUri
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:compute/sharedImage:SharedImage", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SharedImage{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *SharedImage) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *SharedImage) ID() *pulumi.IDOutput {
	return r.s.ID
}

// A description of this Shared Image.
func (r *SharedImage) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// The End User Licence Agreement for the Shared Image.
func (r *SharedImage) Eula() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["eula"])
}

// Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.
func (r *SharedImage) GalleryName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["galleryName"])
}

func (r *SharedImage) Identifier() *pulumi.Output {
	return r.s.State["identifier"]
}

// Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.
func (r *SharedImage) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// Specifies the name of the Shared Image. Changing this forces a new resource to be created.
func (r *SharedImage) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The type of Operating System present in this Shared Image. Possible values are `Linux` and `Windows`.
func (r *SharedImage) OsType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["osType"])
}

// The URI containing the Privacy Statement associated with this Shared Image.
func (r *SharedImage) PrivacyStatementUri() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["privacyStatementUri"])
}

// The URI containing the Release Notes associated with this Shared Image.
func (r *SharedImage) ReleaseNoteUri() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["releaseNoteUri"])
}

// The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
func (r *SharedImage) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// A mapping of tags to assign to the Shared Image.
func (r *SharedImage) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering SharedImage resources.
type SharedImageState struct {
	// A description of this Shared Image.
	Description interface{}
	// The End User Licence Agreement for the Shared Image.
	Eula interface{}
	// Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.
	GalleryName interface{}
	Identifier interface{}
	// Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the Shared Image. Changing this forces a new resource to be created.
	Name interface{}
	// The type of Operating System present in this Shared Image. Possible values are `Linux` and `Windows`.
	OsType interface{}
	// The URI containing the Privacy Statement associated with this Shared Image.
	PrivacyStatementUri interface{}
	// The URI containing the Release Notes associated with this Shared Image.
	ReleaseNoteUri interface{}
	// The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A mapping of tags to assign to the Shared Image.
	Tags interface{}
}

// The set of arguments for constructing a SharedImage resource.
type SharedImageArgs struct {
	// A description of this Shared Image.
	Description interface{}
	// The End User Licence Agreement for the Shared Image.
	Eula interface{}
	// Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.
	GalleryName interface{}
	Identifier interface{}
	// Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the Shared Image. Changing this forces a new resource to be created.
	Name interface{}
	// The type of Operating System present in this Shared Image. Possible values are `Linux` and `Windows`.
	OsType interface{}
	// The URI containing the Privacy Statement associated with this Shared Image.
	PrivacyStatementUri interface{}
	// The URI containing the Release Notes associated with this Shared Image.
	ReleaseNoteUri interface{}
	// The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A mapping of tags to assign to the Shared Image.
	Tags interface{}
}
