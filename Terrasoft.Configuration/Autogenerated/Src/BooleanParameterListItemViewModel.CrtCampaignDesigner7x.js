 /**
  * View model for boolean parameter item in container list.
  */
define("BooleanParameterListItemViewModel", ["BaseParameterListItemViewModel"],
	function() {
		/**
		* @class Terrasoft.configuration.BooleanParameterListItemViewModel
		*/
		Ext.define("Terrasoft.configuration.BooleanParameterListItemViewModel", {
		extend: "Terrasoft.BaseParameterListItemViewModel",
		alternateClassName: "Terrasoft.BooleanParameterListItemViewModel",

		/**
		 * @inheritdoc Terrasoft.BaseParameterListItemViewModel#getParameterInputConfig
		 * @override
		 */
		getParameterInputConfig: function() {
			return [
				{
					className: "Terrasoft.Container",
					classes: {
						wrapClassName: ["parameter-control-wrap"]
					},
					items: [
						{
							className: "Terrasoft.CheckBoxEdit",
							classes: {wrapClass: ["t-checkbox-control"]},
							markerValue: this.getControlMarkerValue(),
							checked: "$Value"
						}
					]
				},
				{
					className: "Terrasoft.Container",
					classes: {
						wrapClassName: ["parameter-label-wrap"]
					},
					items: [
						{
							className: "Terrasoft.Label",
							caption: "$Caption"
						}
					]
				}
			];
		}
	});
	return Terrasoft.BooleanParameterListItemViewModel;
});
