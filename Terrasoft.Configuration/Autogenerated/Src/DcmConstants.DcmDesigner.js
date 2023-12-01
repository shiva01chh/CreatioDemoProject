define("DcmConstants", ["ext-base", "terrasoft", "DcmConstantsResources"], function(Ext, Terrasoft, resources) {
	/**
	 * @class Terrasoft.configuration.DcmConstants
	 * Class DcmConstants contains constants for dcm processes.
	 */
	Ext.define("Terrasoft.configuration.DcmConstants", {
		alternateClassName: "Terrasoft.DcmConstants",
		singleton: true,

		/**
		 * Dcm schema element required type.
		 * @enum
		 */
		ElementRequiredType: {
			NOT_REQUIRED: {
				value: 0,
				displayValue: resources.localizableStrings.NotRequiredTypeCaption
			},
			REQUIRED: {
				value: 1,
				displayValue: resources.localizableStrings.RequiredTypeCaption
			}
		},

		/**
		 * Dcm schema stage transition type.
		 * @enum
		 */
		StageTransitionType: {
			NONE: {
				value: 0,
				displayValue: resources.localizableStrings.NoneStageTransitionTypeCaption
			},
			AFTER_REQUIRED: {
				value: 1,
				displayValue: resources.localizableStrings.AfterRequiredStageTransitionTypeCaption
			},
			AFTER_ALL: {
				value: 2,
				displayValue: resources.localizableStrings.AfterAllStageTransitionTypeCaption
			}
		},

		/**
		 * Dcm schema stage colors.
		 * @enum
		 * @obsolete
		 */
		 StageColors: ["#181818", "#8A8A8A", "#FFFFFF", "#D6D6D6",
			"#E06F56", "#D95031", "#E99886", "#B61303",
			"#54AA4D", "#309726", "#85C280", "#035500",
			"#4D84E2", "#2669DC", "#80A7EB", "#0026BC",
			"#B87CCF", "#7848EE", "#D6BEE3", "#4F43C2",
			"#95DBD1", "#00BFA5", "#D3F1ED", "#009688",
			"#FFAC07", "#FF8800", "#F9D68D", "#FF6534",
			"#FF795A", "#FF4013", "#FFA089", "#FF1C06",
			"#566D83", "#314D69", "#8697A7", "#031225"
		],

		/**
		 * Dcm schema stage colors mapping.
		 * @enum
		 */
		StageColorsMap: [
			{ oldColor: '#000000', newColor: '#181818' },
			{ oldColor: '#999999', newColor: '#757575' },
			{ oldColor: '#dfdfdf', newColor: '#D6D6D6' },
			{ oldColor: '#ef7e63', newColor: '#E06F56' },
			{ oldColor: '#c73920', newColor: '#D2310D' },
			{ oldColor: '#eba793', newColor: '#E99886' },
			{ oldColor: '#7f2910', newColor: '#B61303' },
			{ oldColor: '#d1e9bd', newColor: '#85C280' },
			{ oldColor: '#2c6018', newColor: '#035500' },
			{ oldColor: '#64b8df', newColor: '#4D84E2' },
			{ oldColor: '#3a8bb1', newColor: '#0058EF' },
			{ oldColor: '#d4ebf6', newColor: '#80A7EB' },
			{ oldColor: '#286581', newColor: '#0026BC' },
			{ oldColor: '#6483c3', newColor: '#B87CCF' },
			{ oldColor: '#46639f', newColor: '#7848EE' },
			{ oldColor: '#d1dcf0', newColor: '#D6BEE3' },
			{ oldColor: '#2b467e', newColor: '#4F43C2' },
			{ oldColor: '#5bc8c4', newColor: '#95DBD1' },
			{ oldColor: '#4ca6a3', newColor: '#00BFA5' },
			{ oldColor: '#bfe8e7', newColor: '#D3F1ED' },
			{ oldColor: '#327b78', newColor: '#009688' },
			{ oldColor: '#f8d162', newColor: '#FFAC07' },
			{ oldColor: '#d3ae46', newColor: '#FF8800' },
			{ oldColor: '#fbe8b2', newColor: '#F9D68D' },
			{ oldColor: '#a8882e', newColor: '#FF6534' },
			{ oldColor: '#fbad43', newColor: '#FF795A' },
			{ oldColor: '#cc8930', newColor: '#FF4013' },
			{ oldColor: '#fdd6a1', newColor: '#FFA089' },
			{ oldColor: '#a16a1f', newColor: '#FF1C06' },
			{ oldColor: '#8e8eb7', newColor: '#566D83' },
			{ oldColor: '#5e5684', newColor: '#0D2E4E' },
			{ oldColor: '#e1deed', newColor: '#8697A7' },
			{ oldColor: '#3c365b', newColor: '#031225' },
			{ oldColor: '#309726', newColor: '#0B8500' },
			{ oldColor: '#589928', newColor: '#0B8500' },
			{ oldColor: '#8ecb60', newColor: '#54AA4D' },
			{ oldColor: '#8A8A8A', newColor: '#757575' },
			{ oldColor: '#2669DC', newColor: '#0058EF' },
			{ oldColor: '#314D69', newColor: '#0D2E4E' },
			{ oldColor: '#D95031', newColor: '#D2310D' }
		]
	});

	return Terrasoft.DcmConstants;
});
