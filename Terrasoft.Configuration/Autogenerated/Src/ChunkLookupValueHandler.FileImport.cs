﻿namespace Terrasoft.Configuration.FileImport
{
	using System;
	using Core;
	using Core.Factories;
	using Terrasoft.Common;

	#region  Class: ChunkLookupValuesHandler

	public class ChunkLookupValuesHandler
	{
		#region Events: Public

		public event Action<string, string> ProcessError;

		#endregion

		#region Fields: Private

		private readonly UserConnection UserConnection;
		private IImportLookupChunksDataProvider _importDataProvider;
		private LookupValuesProcessor _lookupValuesProcessor;
		private LookupValuesToProcess _lookupValuesToProcess;
		private string _errorMessageTemplate;

		#endregion

		#region Properties: Private

		private IImportLookupChunksDataProvider ImportDataProvider
		{
			get => _importDataProvider ?? (_importDataProvider = ClassFactory.Get<IImportLookupChunksDataProvider>(new ConstructorArgument("userConnection",
						UserConnection)));
		}

		private LookupValuesProcessor LookupValuesProcessor
		{
			get {
				if(_lookupValuesProcessor == null) {
					_lookupValuesProcessor = ClassFactory.Get<LookupValuesProcessor>(
						 new ConstructorArgument("userConnection", UserConnection),
						 new ConstructorArgument("validateRequiredColumns", true));
					_lookupValuesProcessor.ProcessError += LookupValuesProcessorError;
				}
				return _lookupValuesProcessor;
			}
		}

		private string ErrorMessageTemplate
		{
			get {
				if(_errorMessageTemplate == null) {
					IResourceStorage storage = UserConnection.Workspace.ResourceStorage;
					_errorMessageTemplate = new LocalizableString(storage, "LookupColumnProcessor",
						"LocalizableStrings.ErrorMessageTemplate.Value");
				}
				return _errorMessageTemplate;
			}
		}

		#endregion

		#region Constructors: Public

		public ChunkLookupValuesHandler(UserConnection userConnection) => UserConnection = userConnection;

		#endregion

		#region Methods: Private

		private LookupValuesToProcess GetLookupValuesToProcess(LookupValuesToProcessMemento lookupValues) {
			var lookupValuesToProcess = ClassFactory.Get<LookupValuesToProcess>(new ConstructorArgument("userConnection", UserConnection));
			lookupValuesToProcess.RestoreState(lookupValues);
			return lookupValuesToProcess;
		}

		/// <summary>
		/// Creates information about processing error.
		/// </summary>
		/// <param name="cellRefference">Information about excel cell.</param>
		/// <param name="entitySchemaUId">Entity schema unique identifier.</param>
		/// <param name="missingValue">Exception message.</param>
		/// <returns></returns>
		private string CreateColumnProcessErrorMessage(Guid entitySchemaUId, string missingValue) {
			var schema = UserConnection.EntitySchemaManager.GetItemByUId(entitySchemaUId);
			return string.Format(ErrorMessageTemplate, schema.Caption, missingValue);
		}

		private void LookupValuesProcessorError(object o, LookupValuesProcessorErrorEventArgs eventArgs) {
			Guid entitySchemaUId = eventArgs.EntitySchemaUId;
			var cellsIndexes = _lookupValuesToProcess?.GetCellsIndexes(
				entitySchemaUId, eventArgs.ColumnName, eventArgs.MissingValue);
			cellsIndexes?.ForEach(cellIndex =>
				ProcessError?.Invoke(cellIndex,
					CreateColumnProcessErrorMessage(entitySchemaUId, eventArgs.Exception.Message))
			);
		}

		#endregion

		#region Methods: Public

		public void Execute(ImportDataChunk<LookupChunkData> chunk) {
			_lookupValuesToProcess = GetLookupValuesToProcess(chunk.Data.ValuesToProcessState);
			try {
				var processedValues = LookupValuesProcessor.ProcessValues(_lookupValuesToProcess.GetItems());
				chunk.Data.ProcessedValuesState = processedValues.SaveState();
				chunk.State = ImportChunkState.Processed;
				ImportDataProvider.Update(chunk);
			} finally {
				_lookupValuesToProcess = null;
			}
		}

		#endregion
	}

	#endregion
}













