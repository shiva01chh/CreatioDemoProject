namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration.FileImport;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: FileImportPersistentTask

	[DesignModeProperty(Name = "ImportSessionId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a4279e77ad34bc4a92be762eeee9c8e", CaptionResourceItem = "Parameters.ImportSessionId.Caption", DescriptionResourceItem = "Parameters.ImportSessionId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class FileImportPersistentTask : ProcessUserTask
	{

		#region Constructors: Public

		public FileImportPersistentTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e");
		}

		#endregion

		#region Properties: Public

		public virtual Guid ImportSessionId {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var importParametersRepository = GetImportParametersRepository(UserConnection);
			importParametersRepository.UpdateImportProcessId(ImportSessionId, Guid.Parse(OwnerUId));
			UserConnection.ProcessEngine.CompleteExecuting(UId);
			return false;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			var persistentFileImporter = GetPersistentFileImporter(UserConnection);
			try {
				persistentFileImporter.Import(ImportSessionId, Owner.InternalContext.CancellationToken);
			} catch (OperationCanceledException) {
				// The import was canceled, do nothing.
			}
			return base.CompleteExecuting(null);
		}

		public override void CancelExecuting(params object[] parameters) {
			var importParametersRepository = GetImportParametersRepository(UserConnection);
			importParametersRepository.CancelImportSession(ImportSessionId);
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public override ProcessElementNotification GetNotificationData() {
			return base.GetNotificationData();
		}

		public virtual IPersistentFileImporter GetPersistentFileImporter(UserConnection userConnection) {
			var fileImporter = ClassFactory.Get<PersistentFileImporter>(new ConstructorArgument("userConnection", UserConnection));
			return fileImporter;
		}

		public virtual IImportParametersRepository GetImportParametersRepository(UserConnection userConnection) {
			return ClassFactory.Get<IImportParametersRepository>(new ConstructorArgument("userConnection", userConnection));
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("ImportSessionId")) {
				writer.WriteValue("ImportSessionId", ImportSessionId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ImportSessionId":
					ImportSessionId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

