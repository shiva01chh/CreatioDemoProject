/**
 * A class diagram of package dependencies.
 */
Ext.define("Terrasoft.Designers.PackageDependenciesDiagram", {
	extend: "Terrasoft.ProcessSchemaDesignerLog",
	alternateClassName: "Terrasoft.PackageDependenciesDiagram",

	/**
	 * @inheritdoc Terrasoft.ProcessSchemaDesignerLog#designerViewModelClassName
	 * @override
	 */
	designerViewModelClassName: "Terrasoft.PackageDependenciesDiagramViewModel",

	/**
	 * @inheritdoc Terrasoft.ProcessSchemaDesignerLog#createDesignerViewModel
	 * @override
	 */
	createDesignerViewModel: function() {
		return Ext.create(this.designerViewModelClassName, {
			sandbox: this.sandbox,
			id: this.id
		});
	}

});
