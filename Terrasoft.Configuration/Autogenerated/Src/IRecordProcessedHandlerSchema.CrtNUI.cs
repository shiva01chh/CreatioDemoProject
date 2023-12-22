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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,221,106,195,48,12,133,175,87,232,59,136,236,102,131,17,223,119,93,160,140,194,122,49,40,99,47,224,218,74,226,146,88,65,118,74,199,216,187,207,113,126,200,66,23,66,64,242,57,95,142,100,43,107,116,141,84,8,159,200,44,29,229,62,125,37,155,155,162,101,233,13,89,248,94,175,238,194,123,207,88,116,229,193,122,228,60,24,54,112,248,64,69,172,143,76,10,157,67,253,38,173,174,144,215,171,32,23,66,192,214,181,117,45,249,43,27,234,201,10,148,131,47,17,56,250,161,25,1,80,246,132,116,4,136,25,161,105,79,149,81,96,38,200,63,191,239,2,7,249,20,248,29,125,73,218,109,224,24,1,253,225,50,94,108,140,128,156,248,118,60,188,160,245,233,228,23,75,192,182,145,44,107,176,97,167,47,137,67,171,145,147,108,127,69,213,198,77,42,10,217,175,62,221,138,168,187,109,147,92,184,36,219,105,109,58,143,172,194,192,33,79,221,223,197,176,183,197,224,67,174,57,246,66,70,15,243,44,196,15,116,58,163,242,208,199,123,90,178,246,29,106,23,50,64,23,228,241,121,216,101,16,247,235,140,245,79,252,254,109,198,222,252,249,5,9,150,183,8,90,2,0,0 };
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

