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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,81,107,194,48,16,199,159,43,248,29,14,247,178,193,104,223,213,9,34,34,194,96,130,219,7,136,233,217,5,218,180,187,36,3,39,251,238,187,52,117,109,197,41,123,105,218,187,127,254,247,203,93,170,69,129,166,18,18,225,21,137,132,41,247,54,94,148,122,175,50,71,194,170,82,15,7,199,225,32,114,70,233,12,182,7,99,177,152,156,125,179,62,207,81,122,177,137,87,168,145,148,108,53,93,91,194,120,169,173,178,10,205,77,65,60,55,7,45,95,42,12,24,23,55,108,89,193,113,206,220,17,102,172,130,69,46,140,25,131,79,212,70,135,229,39,106,219,183,154,83,102,234,77,149,219,229,74,130,244,123,110,111,129,49,220,176,140,142,181,109,11,195,216,150,156,180,37,49,211,166,174,22,20,77,229,155,53,239,67,22,176,94,30,33,200,60,12,158,222,30,152,107,39,12,222,159,52,157,140,159,92,244,221,64,161,78,3,87,31,114,67,37,87,244,29,239,35,38,73,2,83,227,138,66,208,97,214,6,16,65,18,238,159,70,107,15,255,78,165,86,95,53,46,31,214,146,191,8,52,74,102,160,138,42,199,130,65,194,240,64,251,107,22,255,218,36,93,227,166,25,207,202,216,41,247,139,71,60,131,214,205,132,83,68,25,218,9,24,126,116,206,116,145,49,92,74,112,6,9,8,115,97,49,237,114,123,103,33,109,13,201,227,17,154,175,190,211,234,195,33,168,212,247,112,175,144,174,147,174,156,74,225,141,253,27,175,117,250,95,198,14,143,111,227,188,254,121,24,233,122,221,86,10,205,242,119,217,179,113,135,104,63,200,177,193,224,7,216,171,43,116,0,4,0,0 };
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

