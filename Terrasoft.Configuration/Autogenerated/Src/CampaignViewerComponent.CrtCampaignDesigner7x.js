define("CampaignViewerComponent", ["Base7xViewElement", "css!CampaignViewerComponent", "css!CampaignSchemaViewerModule", "CampaignViewerComponentPage"],
	function(Base7xViewElement) {
		class CrtCampaignViewer7xComponent extends Base7xViewElement {
			_moduleId;
			_campaignId;
			_operation;
			_loading;

		constructor() {
			super("CampaignViewerComponent");
		}

		get operation() {
			return this._operation;
		}
		set operation(value) {
			this._operation = value;
		}

		get loading() {
			return this._loading;
		}
		set loading(value) {
			this._loading = value;
		}

		get campaignId() { return this._campaignId; }
		set campaignId(value) {
			this._campaignId = value;
			this._render();
		}

		_render() {
			this.initContext(async () => {
				this._moduleId = this.sandbox.id + "_CampaignViewerModule";
				this.operation = await this.sandbox.publish("GetOperation");
				this.loadCampaignViewerModule();
			});
		}

		getCampaignViewerConfig() {
			return {
				Id: this.campaignId
			};
		}

		getMessages() {
			const messages = super.getMessages();
			return Object.assign(messages, {
				"GetOperation": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			});
		}

		loadCampaignViewerModule() {
			var viewConfig = this.getCampaignViewerConfig();
			if (viewConfig.Id) {
				this._moduleId = this.sandbox.loadModule("BaseSchemaModuleV2", {
					id: this._moduleId,
					renderTo: this._renderTo,
					instanceConfig: {
						schemaName: "CampaignViewerComponentPage",
						isSchemaConfigInitialized: true,
						useHistoryState: false,
						showMask: true,
						parameters: {
							viewModelConfig: viewConfig
						},
					}
				}, this);
			}
		}

		connectedCallback() {
			super.connectedCallback();
		}

		disconnectedCallback() {
			this.sandbox?.unloadModule(this._moduleId, this._renderTo);
			super.disconnectedCallback();
		}
	}
	if (!customElements.get('crt-campaign-viewer-7x')) {
		customElements.define('crt-campaign-viewer-7x', CrtCampaignViewer7xComponent);
	}
	return CrtCampaignViewer7xComponent;
});
