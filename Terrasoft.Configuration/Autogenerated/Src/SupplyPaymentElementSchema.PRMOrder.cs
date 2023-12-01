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
	using Terrasoft.Configuration.Passport;
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

	#region Class: SupplyPaymentElementSchema

	/// <exclude/>
	public class SupplyPaymentElementSchema : Terrasoft.Configuration.SupplyPaymentElement_Passport_TerrasoftSchema
	{

		#region Constructors: Public

		public SupplyPaymentElementSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentElementSchema(SupplyPaymentElementSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentElementSchema(SupplyPaymentElementSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIeY97HvuWyT8xw8jpwkpEpPnhiUsIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("3bd175a6-d977-41b0-9091-566ad73135f7");
			index.Name = "IeY97HvuWyT8xw8jpwkpEpPnhiUs";
			index.CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			index.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			index.CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			EntitySchemaIndexColumn idIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4f208c25-99a7-4192-a03e-fcb48d4a9abc"),
				ColumnUId = new Guid("ae0e45ca-c495-4fe7-a39d-3ab7278e1617"),
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(idIndexColumn);
			EntitySchemaIndexColumn typeIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("6ff85e23-059a-44f7-b128-f5e452ca9c05"),
				ColumnUId = new Guid("dd703360-9b62-47fe-abb5-2f3ff6a57911"),
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(typeIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("11ae2eb7-8e22-4ab7-8b12-9f12420e6925");
			Name = "SupplyPaymentElement";
			ParentSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976");
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

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIeY97HvuWyT8xw8jpwkpEpPnhiUsIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPaymentElement(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentElement_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentElementSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentElementSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("11ae2eb7-8e22-4ab7-8b12-9f12420e6925"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement

	/// <summary>
	/// Installment plan: new entry.
	/// </summary>
	public class SupplyPaymentElement : Terrasoft.Configuration.SupplyPaymentElement_Passport_Terrasoft
	{

		#region Constructors: Public

		public SupplyPaymentElement(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentElement";
		}

		public SupplyPaymentElement(SupplyPaymentElement source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentElement_PRMOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentElement(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_PRMOrderEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentElement_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPaymentElement_PassportEventsProcess<TEntity> where TEntity : SupplyPaymentElement
	{

		public SupplyPaymentElement_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentElement_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("11ae2eb7-8e22-4ab7-8b12-9f12420e6925");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_PRMOrderEventsProcess

	/// <exclude/>
	public class SupplyPaymentElement_PRMOrderEventsProcess : SupplyPaymentElement_PRMOrderEventsProcess<SupplyPaymentElement>
	{

		public SupplyPaymentElement_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentElement_PRMOrderEventsProcess

	public partial class SupplyPaymentElement_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SupplyPaymentElementEventsProcess

	/// <exclude/>
	public class SupplyPaymentElementEventsProcess : SupplyPaymentElement_PRMOrderEventsProcess
	{

		public SupplyPaymentElementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

