namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMacrosInvokableSchema

	/// <exclude/>
	public class IMacrosInvokableSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMacrosInvokableSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMacrosInvokableSchema(IMacrosInvokableSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18dfac77-86d7-4509-8aee-d9ad2c50cf9c");
			Name = "IMacrosInvokable";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,185,110,195,48,12,157,109,192,255,64,32,75,187,216,123,19,100,201,80,120,200,150,118,151,21,90,113,107,73,1,69,5,8,130,254,123,37,89,118,211,75,19,73,189,131,135,17,26,221,89,72,132,3,18,9,103,123,174,119,214,244,131,242,36,120,176,166,42,111,85,89,120,55,24,245,13,66,184,174,202,240,179,34,84,1,6,173,97,164,62,8,61,65,187,23,146,108,96,92,236,187,232,70,76,184,166,105,96,227,188,214,130,174,219,156,47,28,176,61,232,68,130,222,18,36,38,214,51,171,185,163,157,125,55,14,50,32,102,102,54,107,191,204,138,216,240,47,191,84,120,113,72,32,173,49,40,227,108,245,2,188,183,40,34,106,183,128,224,71,154,212,11,133,188,78,129,203,193,71,154,242,111,219,61,242,201,30,129,79,130,129,144,61,25,7,142,41,174,244,34,70,143,105,232,105,254,127,90,74,149,76,221,18,58,63,114,86,216,52,115,57,226,178,234,51,242,180,150,215,40,255,96,187,183,208,60,8,82,94,163,97,247,56,157,110,106,121,133,230,56,221,48,166,161,22,223,39,196,254,214,9,23,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18dfac77-86d7-4509-8aee-d9ad2c50cf9c"));
		}

		#endregion

	}

	#endregion

}

