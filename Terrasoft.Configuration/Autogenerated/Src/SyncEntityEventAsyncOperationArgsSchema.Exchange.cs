namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SyncEntityEventAsyncOperationArgsSchema

	/// <exclude/>
	public class SyncEntityEventAsyncOperationArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SyncEntityEventAsyncOperationArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SyncEntityEventAsyncOperationArgsSchema(SyncEntityEventAsyncOperationArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e247f3a-b8b6-4b8f-a8ea-e969f8ba34fb");
			Name = "SyncEntityEventAsyncOperationArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,111,107,194,48,16,198,95,43,248,29,14,247,102,131,209,190,87,39,136,136,8,131,9,110,31,32,166,215,46,208,166,221,37,25,116,178,239,190,75,83,215,42,78,89,95,244,207,229,201,115,191,220,93,181,40,208,84,66,34,188,34,145,48,101,106,163,101,169,83,149,57,18,86,149,122,52,60,140,134,3,103,148,206,96,87,27,139,197,244,236,155,245,121,142,210,139,77,180,70,141,164,100,167,233,219,18,70,43,109,149,85,104,110,10,162,133,169,181,124,169,48,96,92,220,176,99,5,199,121,229,142,48,99,21,44,115,97,204,4,252,66,99,84,175,62,81,219,83,171,5,101,166,217,84,185,125,174,36,72,191,231,246,22,152,192,13,203,193,161,177,237,96,24,219,146,147,182,36,102,218,54,217,130,162,205,124,51,231,125,88,5,108,30,143,16,100,30,6,143,111,15,204,181,23,6,239,143,154,222,138,239,220,224,187,133,66,157,4,174,83,200,45,149,156,209,87,252,20,49,142,99,152,25,87,20,130,234,121,23,64,4,73,152,62,141,55,30,254,157,74,173,190,26,92,62,172,37,63,8,52,142,231,160,138,42,199,130,65,66,243,64,251,49,139,126,109,226,190,113,91,140,103,101,236,140,235,197,45,158,67,231,102,194,41,6,25,218,41,24,190,245,206,116,145,49,12,37,56,131,4,132,185,176,152,244,185,189,179,144,182,129,228,246,8,205,163,239,180,250,112,8,42,241,53,76,21,210,117,210,181,83,9,188,177,127,235,181,73,254,203,216,227,241,101,92,52,63,15,35,93,207,219,73,161,125,252,157,246,172,221,33,122,26,228,88,239,250,1,29,184,93,208,9,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e247f3a-b8b6-4b8f-a8ea-e969f8ba34fb"));
		}

		#endregion

	}

	#endregion

}

