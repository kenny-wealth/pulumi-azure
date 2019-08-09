// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package streamanalytics

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Stream Analytics Output to Blob Storage.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/stream_analytics_output_blob.html.markdown.
type OutputBlob struct {
	s *pulumi.ResourceState
}

// NewOutputBlob registers a new resource with the given unique name, arguments, and options.
func NewOutputBlob(ctx *pulumi.Context,
	name string, args *OutputBlobArgs, opts ...pulumi.ResourceOpt) (*OutputBlob, error) {
	if args == nil || args.DateFormat == nil {
		return nil, errors.New("missing required argument 'DateFormat'")
	}
	if args == nil || args.PathPattern == nil {
		return nil, errors.New("missing required argument 'PathPattern'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Serialization == nil {
		return nil, errors.New("missing required argument 'Serialization'")
	}
	if args == nil || args.StorageAccountKey == nil {
		return nil, errors.New("missing required argument 'StorageAccountKey'")
	}
	if args == nil || args.StorageAccountName == nil {
		return nil, errors.New("missing required argument 'StorageAccountName'")
	}
	if args == nil || args.StorageContainerName == nil {
		return nil, errors.New("missing required argument 'StorageContainerName'")
	}
	if args == nil || args.StreamAnalyticsJobName == nil {
		return nil, errors.New("missing required argument 'StreamAnalyticsJobName'")
	}
	if args == nil || args.TimeFormat == nil {
		return nil, errors.New("missing required argument 'TimeFormat'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["dateFormat"] = nil
		inputs["name"] = nil
		inputs["pathPattern"] = nil
		inputs["resourceGroupName"] = nil
		inputs["serialization"] = nil
		inputs["storageAccountKey"] = nil
		inputs["storageAccountName"] = nil
		inputs["storageContainerName"] = nil
		inputs["streamAnalyticsJobName"] = nil
		inputs["timeFormat"] = nil
	} else {
		inputs["dateFormat"] = args.DateFormat
		inputs["name"] = args.Name
		inputs["pathPattern"] = args.PathPattern
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["serialization"] = args.Serialization
		inputs["storageAccountKey"] = args.StorageAccountKey
		inputs["storageAccountName"] = args.StorageAccountName
		inputs["storageContainerName"] = args.StorageContainerName
		inputs["streamAnalyticsJobName"] = args.StreamAnalyticsJobName
		inputs["timeFormat"] = args.TimeFormat
	}
	s, err := ctx.RegisterResource("azure:streamanalytics/outputBlob:OutputBlob", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &OutputBlob{s: s}, nil
}

// GetOutputBlob gets an existing OutputBlob resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOutputBlob(ctx *pulumi.Context,
	name string, id pulumi.ID, state *OutputBlobState, opts ...pulumi.ResourceOpt) (*OutputBlob, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["dateFormat"] = state.DateFormat
		inputs["name"] = state.Name
		inputs["pathPattern"] = state.PathPattern
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["serialization"] = state.Serialization
		inputs["storageAccountKey"] = state.StorageAccountKey
		inputs["storageAccountName"] = state.StorageAccountName
		inputs["storageContainerName"] = state.StorageContainerName
		inputs["streamAnalyticsJobName"] = state.StreamAnalyticsJobName
		inputs["timeFormat"] = state.TimeFormat
	}
	s, err := ctx.ReadResource("azure:streamanalytics/outputBlob:OutputBlob", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &OutputBlob{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *OutputBlob) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *OutputBlob) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The date format. Wherever `{date}` appears in `pathPattern`, the value of this property is used as the date format instead.
func (r *OutputBlob) DateFormat() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["dateFormat"])
}

// The name of the Stream Output. Changing this forces a new resource to be created.
func (r *OutputBlob) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job.
func (r *OutputBlob) PathPattern() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["pathPattern"])
}

// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
func (r *OutputBlob) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// A `serialization` block as defined below.
func (r *OutputBlob) Serialization() *pulumi.Output {
	return r.s.State["serialization"]
}

// The Access Key which should be used to connect to this Storage Account.
func (r *OutputBlob) StorageAccountKey() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageAccountKey"])
}

// The name of the Storage Account.
func (r *OutputBlob) StorageAccountName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageAccountName"])
}

// The name of the Container within the Storage Account.
func (r *OutputBlob) StorageContainerName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageContainerName"])
}

// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
func (r *OutputBlob) StreamAnalyticsJobName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["streamAnalyticsJobName"])
}

// The time format. Wherever `{time}` appears in `pathPattern`, the value of this property is used as the time format instead.
func (r *OutputBlob) TimeFormat() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["timeFormat"])
}

// Input properties used for looking up and filtering OutputBlob resources.
type OutputBlobState struct {
	// The date format. Wherever `{date}` appears in `pathPattern`, the value of this property is used as the date format instead.
	DateFormat interface{}
	// The name of the Stream Output. Changing this forces a new resource to be created.
	Name interface{}
	// The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job.
	PathPattern interface{}
	// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A `serialization` block as defined below.
	Serialization interface{}
	// The Access Key which should be used to connect to this Storage Account.
	StorageAccountKey interface{}
	// The name of the Storage Account.
	StorageAccountName interface{}
	// The name of the Container within the Storage Account.
	StorageContainerName interface{}
	// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
	StreamAnalyticsJobName interface{}
	// The time format. Wherever `{time}` appears in `pathPattern`, the value of this property is used as the time format instead.
	TimeFormat interface{}
}

// The set of arguments for constructing a OutputBlob resource.
type OutputBlobArgs struct {
	// The date format. Wherever `{date}` appears in `pathPattern`, the value of this property is used as the date format instead.
	DateFormat interface{}
	// The name of the Stream Output. Changing this forces a new resource to be created.
	Name interface{}
	// The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job.
	PathPattern interface{}
	// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A `serialization` block as defined below.
	Serialization interface{}
	// The Access Key which should be used to connect to this Storage Account.
	StorageAccountKey interface{}
	// The name of the Storage Account.
	StorageAccountName interface{}
	// The name of the Container within the Storage Account.
	StorageContainerName interface{}
	// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
	StreamAnalyticsJobName interface{}
	// The time format. Wherever `{time}` appears in `pathPattern`, the value of this property is used as the time format instead.
	TimeFormat interface{}
}
