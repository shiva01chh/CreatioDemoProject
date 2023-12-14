namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimeColumnProcessorSchema

	/// <exclude/>
	public class TimeColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimeColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimeColumnProcessorSchema(TimeColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("761b0013-5b74-46b7-87d9-cd9671c4ab75");
			Name = "TimeColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,65,107,227,48,16,133,207,45,244,63,12,233,37,129,197,190,167,73,96,155,210,37,151,82,216,164,151,178,7,69,30,167,3,182,228,142,164,66,40,251,223,59,146,227,110,157,58,133,174,47,150,134,55,239,105,62,203,70,213,232,26,165,17,214,200,172,156,45,125,182,180,166,164,93,96,229,201,154,236,150,42,92,213,141,101,127,113,254,122,113,126,22,28,153,29,252,222,59,143,245,213,251,254,99,55,227,169,122,118,171,180,183,76,232,68,33,154,75,198,157,100,192,178,82,206,77,97,77,53,46,109,21,106,115,207,86,163,115,150,147,44,207,115,152,145,121,66,38,95,88,13,154,177,156,143,110,148,199,129,142,81,190,232,90,92,168,107,197,251,110,255,211,0,25,231,149,145,105,109,9,254,137,28,232,152,12,178,96,193,96,141,163,109,133,80,90,134,166,245,139,51,196,32,208,41,5,94,84,21,208,101,93,66,254,33,226,241,6,75,21,42,127,77,166,144,182,177,223,55,104,203,241,234,232,124,147,31,112,39,208,97,14,70,94,34,24,152,97,50,249,35,134,77,216,86,164,15,71,28,80,193,20,78,48,144,230,215,68,238,31,97,153,205,115,136,244,5,244,125,114,110,21,255,1,247,19,221,84,88,50,74,147,235,51,22,6,162,68,60,216,14,91,102,239,158,249,177,233,172,81,172,234,132,106,62,10,14,89,6,49,168,227,205,28,45,54,178,151,15,211,21,178,89,158,212,169,249,0,111,32,112,188,233,217,64,223,117,34,84,183,202,225,248,184,28,239,254,217,223,3,85,52,69,11,182,79,89,50,26,100,47,247,123,26,215,94,122,177,248,10,243,181,36,125,3,177,124,21,213,94,193,150,108,48,244,44,107,42,208,120,42,9,249,4,201,166,59,11,216,23,249,33,69,15,191,2,21,201,239,33,218,173,197,109,179,42,96,190,232,215,178,200,239,88,117,53,8,161,69,211,47,74,77,158,55,62,146,90,119,100,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("761b0013-5b74-46b7-87d9-cd9671c4ab75"));
		}

		#endregion

	}

	#endregion

}

