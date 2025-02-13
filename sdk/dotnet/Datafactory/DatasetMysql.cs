// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.DataFactory
{
    /// <summary>
    /// Manages a MySQL Dataset inside a Azure Data Factory.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/data_factory_dataset_mysql.html.markdown.
    /// </summary>
    public partial class DatasetMysql : Pulumi.CustomResource
    {
        /// <summary>
        /// A map of additional properties to associate with the Data Factory Dataset MySQL.
        /// </summary>
        [Output("additionalProperties")]
        public Output<ImmutableDictionary<string, string>?> AdditionalProperties { get; private set; } = null!;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Dataset MySQL.
        /// </summary>
        [Output("annotations")]
        public Output<ImmutableArray<string>> Annotations { get; private set; } = null!;

        /// <summary>
        /// The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
        /// </summary>
        [Output("dataFactoryName")]
        public Output<string> DataFactoryName { get; private set; } = null!;

        /// <summary>
        /// The description for the Data Factory Dataset MySQL.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
        /// </summary>
        [Output("folder")]
        public Output<string?> Folder { get; private set; } = null!;

        /// <summary>
        /// The Data Factory Linked Service name in which to associate the Dataset with.
        /// </summary>
        [Output("linkedServiceName")]
        public Output<string> LinkedServiceName { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Data Factory Dataset MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Dataset MySQL.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, string>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Dataset MySQL. Changing this forces a new resource
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `schema_column` block as defined below.
        /// </summary>
        [Output("schemaColumns")]
        public Output<ImmutableArray<Outputs.DatasetMysqlSchemaColumns>> SchemaColumns { get; private set; } = null!;

        /// <summary>
        /// The table name of the Data Factory Dataset MySQL.
        /// </summary>
        [Output("tableName")]
        public Output<string?> TableName { get; private set; } = null!;


        /// <summary>
        /// Create a DatasetMysql resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DatasetMysql(string name, DatasetMysqlArgs args, CustomResourceOptions? options = null)
            : base("azure:datafactory/datasetMysql:DatasetMysql", name, args, MakeResourceOptions(options, ""))
        {
        }

        private DatasetMysql(string name, Input<string> id, DatasetMysqlState? state = null, CustomResourceOptions? options = null)
            : base("azure:datafactory/datasetMysql:DatasetMysql", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DatasetMysql resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DatasetMysql Get(string name, Input<string> id, DatasetMysqlState? state = null, CustomResourceOptions? options = null)
        {
            return new DatasetMysql(name, id, state, options);
        }
    }

    public sealed class DatasetMysqlArgs : Pulumi.ResourceArgs
    {
        [Input("additionalProperties")]
        private InputMap<string>? _additionalProperties;

        /// <summary>
        /// A map of additional properties to associate with the Data Factory Dataset MySQL.
        /// </summary>
        public InputMap<string> AdditionalProperties
        {
            get => _additionalProperties ?? (_additionalProperties = new InputMap<string>());
            set => _additionalProperties = value;
        }

        [Input("annotations")]
        private InputList<string>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Dataset MySQL.
        /// </summary>
        public InputList<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
        /// </summary>
        [Input("dataFactoryName", required: true)]
        public Input<string> DataFactoryName { get; set; } = null!;

        /// <summary>
        /// The description for the Data Factory Dataset MySQL.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
        /// </summary>
        [Input("folder")]
        public Input<string>? Folder { get; set; }

        /// <summary>
        /// The Data Factory Linked Service name in which to associate the Dataset with.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<string> LinkedServiceName { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Data Factory Dataset MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Dataset MySQL.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Dataset MySQL. Changing this forces a new resource
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("schemaColumns")]
        private InputList<Inputs.DatasetMysqlSchemaColumnsArgs>? _schemaColumns;

        /// <summary>
        /// A `schema_column` block as defined below.
        /// </summary>
        public InputList<Inputs.DatasetMysqlSchemaColumnsArgs> SchemaColumns
        {
            get => _schemaColumns ?? (_schemaColumns = new InputList<Inputs.DatasetMysqlSchemaColumnsArgs>());
            set => _schemaColumns = value;
        }

        /// <summary>
        /// The table name of the Data Factory Dataset MySQL.
        /// </summary>
        [Input("tableName")]
        public Input<string>? TableName { get; set; }

        public DatasetMysqlArgs()
        {
        }
    }

    public sealed class DatasetMysqlState : Pulumi.ResourceArgs
    {
        [Input("additionalProperties")]
        private InputMap<string>? _additionalProperties;

        /// <summary>
        /// A map of additional properties to associate with the Data Factory Dataset MySQL.
        /// </summary>
        public InputMap<string> AdditionalProperties
        {
            get => _additionalProperties ?? (_additionalProperties = new InputMap<string>());
            set => _additionalProperties = value;
        }

        [Input("annotations")]
        private InputList<string>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Dataset MySQL.
        /// </summary>
        public InputList<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
        /// </summary>
        [Input("dataFactoryName")]
        public Input<string>? DataFactoryName { get; set; }

        /// <summary>
        /// The description for the Data Factory Dataset MySQL.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
        /// </summary>
        [Input("folder")]
        public Input<string>? Folder { get; set; }

        /// <summary>
        /// The Data Factory Linked Service name in which to associate the Dataset with.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<string>? LinkedServiceName { get; set; }

        /// <summary>
        /// Specifies the name of the Data Factory Dataset MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Dataset MySQL.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Dataset MySQL. Changing this forces a new resource
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("schemaColumns")]
        private InputList<Inputs.DatasetMysqlSchemaColumnsGetArgs>? _schemaColumns;

        /// <summary>
        /// A `schema_column` block as defined below.
        /// </summary>
        public InputList<Inputs.DatasetMysqlSchemaColumnsGetArgs> SchemaColumns
        {
            get => _schemaColumns ?? (_schemaColumns = new InputList<Inputs.DatasetMysqlSchemaColumnsGetArgs>());
            set => _schemaColumns = value;
        }

        /// <summary>
        /// The table name of the Data Factory Dataset MySQL.
        /// </summary>
        [Input("tableName")]
        public Input<string>? TableName { get; set; }

        public DatasetMysqlState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class DatasetMysqlSchemaColumnsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description for the Data Factory Dataset MySQL.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Specifies the name of the Data Factory Dataset MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("type")]
        public Input<string>? Type { get; set; }

        public DatasetMysqlSchemaColumnsArgs()
        {
        }
    }

    public sealed class DatasetMysqlSchemaColumnsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description for the Data Factory Dataset MySQL.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Specifies the name of the Data Factory Dataset MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("type")]
        public Input<string>? Type { get; set; }

        public DatasetMysqlSchemaColumnsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class DatasetMysqlSchemaColumns
    {
        /// <summary>
        /// The description for the Data Factory Dataset MySQL.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Specifies the name of the Data Factory Dataset MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        public readonly string Name;
        public readonly string? Type;

        [OutputConstructor]
        private DatasetMysqlSchemaColumns(
            string? description,
            string name,
            string? type)
        {
            Description = description;
            Name = name;
            Type = type;
        }
    }
    }
}
