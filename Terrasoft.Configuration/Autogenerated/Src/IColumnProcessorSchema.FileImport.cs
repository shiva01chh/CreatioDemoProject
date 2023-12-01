namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IColumnProcessorSchema

	/// <exclude/>
	public class IColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IColumnProcessorSchema(IColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30c9471b-7e5a-4dc5-b5d7-b25c0e8ae3a9");
			Name = "IColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bdeb1980-c322-4103-af7f-58bfe7162080");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,177,10,195,48,12,68,231,24,252,15,130,172,37,31,208,177,129,130,151,146,161,63,224,166,114,48,216,146,145,156,41,244,223,235,166,116,40,185,77,167,119,199,145,207,168,197,207,8,119,20,241,202,161,14,35,83,136,203,42,190,70,166,225,26,19,186,92,88,170,53,155,53,93,47,184,52,31,28,85,148,208,146,103,112,35,167,53,211,36,60,163,42,139,53,141,43,235,35,197,25,226,15,59,80,208,130,55,166,9,69,163,86,164,250,247,63,129,187,120,197,67,115,183,193,107,239,239,145,158,223,41,159,115,247,154,222,116,23,85,155,208,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30c9471b-7e5a-4dc5-b5d7-b25c0e8ae3a9"));
		}

		#endregion

	}

	#endregion

}

