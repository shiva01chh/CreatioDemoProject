namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordProcessedHandlerSchema

	/// <exclude/>
	public class IRecordProcessedHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordProcessedHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordProcessedHandlerSchema(IRecordProcessedHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19ec078f-2d2a-4581-b154-931f817b018f");
			Name = "IRecordProcessedHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,221,106,195,48,12,133,175,87,232,59,136,236,102,131,17,223,119,89,160,140,194,122,49,40,99,47,224,218,74,226,146,88,65,118,74,199,216,187,207,113,126,232,66,23,66,64,242,57,95,142,100,43,27,116,173,84,8,159,200,44,29,21,62,125,37,91,152,178,99,233,13,89,248,94,175,238,194,123,207,88,246,229,222,122,228,34,24,54,176,255,64,69,172,15,76,10,157,67,253,38,173,174,145,215,171,32,23,66,64,230,186,166,145,252,149,143,245,108,5,42,192,87,8,28,253,208,78,0,168,6,66,58,1,196,21,161,237,142,181,81,96,102,200,63,191,239,3,7,249,28,248,29,125,69,218,109,224,16,1,195,225,50,94,108,76,128,130,248,118,60,60,163,245,233,236,23,75,64,214,74,150,13,216,176,211,151,196,161,213,200,73,190,187,160,234,226,38,21,133,236,23,159,102,34,234,110,219,36,151,46,201,183,90,155,222,35,235,48,112,200,211,12,119,49,238,109,49,248,152,235,26,123,38,163,199,121,22,226,7,58,158,80,121,24,226,61,45,89,187,30,181,13,25,160,15,242,248,60,238,50,136,135,117,198,250,39,126,255,54,99,47,60,191,97,189,233,2,81,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19ec078f-2d2a-4581-b154-931f817b018f"));
		}

		#endregion

	}

	#endregion

}

