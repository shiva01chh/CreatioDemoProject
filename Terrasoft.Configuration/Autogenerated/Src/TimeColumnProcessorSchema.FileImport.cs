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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,65,107,227,48,16,133,207,13,244,63,12,233,37,129,197,190,167,73,160,77,233,146,203,82,216,100,47,203,30,20,121,156,14,216,146,119,36,21,66,217,255,222,145,28,119,235,212,41,180,39,75,195,155,247,52,159,100,163,106,116,141,210,8,27,100,86,206,150,62,91,89,83,210,62,176,242,100,77,118,79,21,174,235,198,178,191,28,61,95,142,46,130,35,179,135,159,7,231,177,190,126,221,191,237,102,60,87,207,238,149,246,150,9,157,40,68,115,197,184,151,12,88,85,202,185,25,108,168,198,149,173,66,109,30,216,106,116,206,114,146,229,121,14,115,50,143,200,228,11,171,65,51,150,139,241,157,242,56,208,49,206,151,93,139,11,117,173,248,208,237,111,12,144,113,94,25,153,214,150,224,31,201,129,142,201,32,11,22,12,214,56,218,85,8,165,101,104,90,191,56,67,12,2,157,82,224,73,85,1,93,214,37,228,111,34,126,223,97,169,66,229,111,201,20,210,54,241,135,6,109,57,89,159,156,111,250,13,126,8,116,88,128,145,143,8,6,102,152,78,255,136,97,19,118,21,233,227,17,7,84,48,131,51,12,164,249,57,145,251,79,88,102,243,28,34,125,1,253,144,156,91,197,23,224,190,163,155,10,43,70,105,114,125,198,194,64,148,136,71,219,97,203,236,213,51,63,53,157,55,138,85,157,80,45,198,193,33,203,32,6,117,124,153,227,229,86,246,114,49,93,33,155,231,73,157,154,143,240,6,2,39,219,158,13,244,93,167,66,117,167,28,78,78,203,241,237,95,252,59,82,69,83,180,96,251,148,37,163,65,246,242,190,103,113,237,165,23,139,143,48,223,74,210,39,16,203,173,168,246,9,182,100,131,161,191,178,166,2,141,167,146,144,207,144,108,186,179,128,125,146,31,82,244,240,61,80,145,252,126,69,187,141,184,109,215,5,44,150,253,90,22,249,157,170,174,7,33,180,104,250,69,169,141,70,47,45,216,200,82,99,4,0,0 };
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

