namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Product_ProductBase_TerrasoftSchema

	/// <exclude/>
	public class Product_ProductBase_TerrasoftSchema : Terrasoft.Configuration.Product_CrtProductBase_TerrasoftSchema
	{

		#region Constructors: Public

		public Product_ProductBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Product_ProductBase_TerrasoftSchema(Product_ProductBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Product_ProductBase_TerrasoftSchema(Product_ProductBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2199e29b-d54e-4322-a680-e188771f5267");
			Name = "Product_ProductBase_Terrasoft";
			ParentSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f54bcad4-1193-4261-a97d-65b92aef2bb0");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Product_ProductBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Product_ProductBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Product_ProductBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Product_ProductBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2199e29b-d54e-4322-a680-e188771f5267"));
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductBase_Terrasoft

	/// <summary>
	/// Product.
	/// </summary>
	public class Product_ProductBase_Terrasoft : Terrasoft.Configuration.Product_CrtProductBase_Terrasoft
	{

		#region Constructors: Public

		public Product_ProductBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Product_ProductBase_Terrasoft";
		}

		public Product_ProductBase_Terrasoft(Product_ProductBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Product_ProductBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Product_ProductBase_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Product_ProductBase_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("Product_ProductBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Product_ProductBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Product_ProductBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductBaseEventsProcess

	/// <exclude/>
	public partial class Product_ProductBaseEventsProcess<TEntity> : Terrasoft.Configuration.Product_CrtProductBaseEventsProcess<TEntity> where TEntity : Product_ProductBase_Terrasoft
	{

		public Product_ProductBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Product_ProductBaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2199e29b-d54e-4322-a680-e188771f5267");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _productSaveEventSubProcess;
		public ProcessFlowElement ProductSaveEventSubProcess {
			get {
				return _productSaveEventSubProcess ?? (_productSaveEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProductSaveEventSubProcess",
					SchemaElementUId = new Guid("9e5f0d4e-6aef-47c4-92d8-391c4388ab86"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1ProductSaving;
		public ProcessFlowElement StartMessage1ProductSaving {
			get {
				return _startMessage1ProductSaving ?? (_startMessage1ProductSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1ProductSaving",
					SchemaElementUId = new Guid("b80b4e0b-5510-473b-a6a7-5d3103801a98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1ProductSaving;
		public ProcessScriptTask ScriptTask1ProductSaving {
			get {
				return _scriptTask1ProductSaving ?? (_scriptTask1ProductSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1ProductSaving",
					SchemaElementUId = new Guid("f507d9df-9dc8-472b-9ce0-7da0bff9461c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1ProductSavingExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1ProductSaving;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1ProductSaving {
			get {
				return _intermediateThrowMessageEvent1ProductSaving ?? (_intermediateThrowMessageEvent1ProductSaving = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1ProductSaving",
					SchemaElementUId = new Guid("19667ab9-8a5f-4910-a1d3-0af31485f1cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ProductInserting",
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ProductSaveEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductSaveEventSubProcess };
			FlowElements[StartMessage1ProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1ProductSaving };
			FlowElements[ScriptTask1ProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1ProductSaving };
			FlowElements[IntermediateThrowMessageEvent1ProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1ProductSaving };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ProductSaveEventSubProcess":
						break;
					case "StartMessage1ProductSaving":
						e.Context.QueueTasks.Enqueue("ScriptTask1ProductSaving");
						break;
					case "ScriptTask1ProductSaving":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1ProductSaving");
						break;
					case "IntermediateThrowMessageEvent1ProductSaving":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1ProductSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ProductSaveEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1ProductSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1ProductSaving";
					result = StartMessage1ProductSaving.Execute(context);
					break;
				case "ScriptTask1ProductSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1ProductSaving";
					result = ScriptTask1ProductSaving.Execute(context, ScriptTask1ProductSavingExecute);
					break;
				case "IntermediateThrowMessageEvent1ProductSaving":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1ProductSaving.Execute(context);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1ProductSavingExecute(ProcessExecutingContext context) {
			var pictureId = Entity.GetColumnValue("PictureId");
			if (pictureId == null) { 
				return true;
			}
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, Entity.Schema.Name);
			entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"Picture.Id", pictureId));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				var pictureESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysImage");
				pictureESQ.AddAllSchemaColumns();
				var picture = pictureESQ.GetEntity(UserConnection, pictureId);
				if (picture != null) {
					Guid pictureNewGuid = Guid.NewGuid();
					var sysImageSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysImage");
					var sysImage = sysImageSchema.CreateEntity(UserConnection);
					sysImage.SetDefColumnValues();
					sysImage.SetColumnValue("Id", pictureNewGuid);
					sysImage.SetColumnValue("Name", picture.GetTypedColumnValue<string>("Name"));
					sysImage.SetColumnValue("Data", picture.GetColumnValue("Data"));
					sysImage.SetColumnValue("MimeType", picture.GetTypedColumnValue<string>("MimeType"));
					sysImage.SetColumnValue("HasRef", picture.GetTypedColumnValue<bool>("HasRef"));
					sysImage.SetColumnValue("PreviewData", picture.GetColumnValue("PreviewData"));
					sysImage.Save();
					Entity.SetColumnValue("PictureId", pictureNewGuid);
				}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Product_ProductBase_TerrasoftInserting":
							if (ActivatedEventElements.Contains("StartMessage1ProductSaving")) {
							context.QueueTasks.Enqueue("StartMessage1ProductSaving");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductBaseEventsProcess

	/// <exclude/>
	public class Product_ProductBaseEventsProcess : Product_ProductBaseEventsProcess<Product_ProductBase_Terrasoft>
	{

		public Product_ProductBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Product_ProductBaseEventsProcess

	public partial class Product_ProductBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

