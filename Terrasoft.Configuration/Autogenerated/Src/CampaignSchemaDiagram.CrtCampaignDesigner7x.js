﻿define("CampaignSchemaDiagram", ["CampaignSchemaDiagramResources", "process-schema-diagram"], function(resources) {
	Ext.define("Terrasoft.CampaignDesigner.CampaignSchemaDiagram", {
		extend: "Terrasoft.ProcessSchemaDiagram",
		alternateClassName: "Terrasoft.CampaignSchemaDiagram",

		/**
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDiagram#customizeDiagram
		 * @override
		 */
		customizeDiagram: function() {
			this.callParent(arguments);
			var svgContext = ej.Diagram.SvgContext;
			svgContext._renderImage = function(node, svg, g) {
				var attr = {
					"id": node.name + "_shape",
					"width": node.width,
					"height": node.height,
					"opacity": node.opacity,
					"preserveAspectRatio": "none"
				};
				var shape = svg.image(attr);
				shape.setAttributeNS("http://www.w3.org/1999/xlink", "xlink:href", node.shape.src);
				g.appendChild(shape);
			};
		},

		/**
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDiagram#getItemContainerNeedsToBeChanged
		 * @override
		 */
		getItemContainerNeedsToBeChanged: function() {
			return false;
		},

		/**
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDiagram#getImageUrl
		 * @override
		 */
		getImageUrl: function(imageName) {
			imageName = imageName.replace(/\.svg$/, "");
			var config = resources.localizableImages[imageName];
			if (!config) {
				config = resources.localizableImages.Default;
			}
			return Terrasoft.ImageUrlBuilder.getUrl(config);
		}
	});
	return Terrasoft.CampaignSchemaDiagram;
});
