Terrasoft.configuration.Structures["ActivityReleaseDetail"] = {innerHierarchyStack: ["ActivityReleaseDetail"], structureParent: "ActivityDetailV2"};
define('ActivityReleaseDetailStructure', ['ActivityReleaseDetailResources'], function(resources) {return {schemaUId:'b8eaef13-1ca6-4cbd-9a86-6b19a24e16df',schemaCaption: "Detail schema - \"Activities\" in \"Releases\" section", parentSchemaName: "ActivityDetailV2", packageName: "Release", schemaName:'ActivityReleaseDetail',parentSchemaUId:'c98e0daa-7ee5-4acd-9711-3988e14afb3b',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ActivityReleaseDetail", [],
    function() {
        return {
            /**
             * ### ##### #######
             * @type {String}
             */
            entitySchemaName: "Activity",

            messages: {},
            attributes: {},
            methods: {},
            diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
        };
    }
);


