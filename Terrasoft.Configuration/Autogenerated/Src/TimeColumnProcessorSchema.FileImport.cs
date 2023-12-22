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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,65,107,227,48,16,133,207,45,244,63,12,233,37,129,98,223,211,36,176,77,105,201,101,41,108,178,151,101,15,138,60,78,7,108,201,59,146,10,161,236,127,239,72,142,187,113,234,20,186,190,88,26,222,188,167,249,44,27,85,163,107,148,70,88,35,179,114,182,244,217,210,154,146,118,129,149,39,107,178,7,170,112,85,55,150,253,213,229,235,213,229,69,112,100,118,240,99,239,60,214,183,239,251,227,110,198,115,245,236,65,105,111,153,208,137,66,52,215,140,59,201,128,101,165,156,155,194,154,106,92,218,42,212,230,137,173,70,231,44,39,89,158,231,48,35,243,140,76,190,176,26,52,99,57,31,221,43,143,3,29,163,124,209,181,184,80,215,138,247,221,254,155,1,50,206,43,35,211,218,18,252,51,57,208,49,25,100,193,130,193,26,71,219,10,161,180,12,77,235,23,103,136,65,160,83,10,188,168,42,160,203,186,132,252,40,226,215,61,150,42,84,254,142,76,33,109,99,191,111,208,150,227,213,201,249,38,55,240,93,160,195,28,140,188,68,48,48,195,100,242,91,12,155,176,173,72,31,142,56,160,130,41,156,97,32,205,175,137,220,63,194,50,155,231,16,233,11,232,167,228,220,42,254,3,238,7,186,169,176,100,148,38,215,103,44,12,68,137,120,176,29,182,204,222,61,243,83,211,89,163,88,213,9,213,124,20,28,178,12,98,80,199,155,57,90,108,100,47,31,166,43,100,179,60,169,83,243,1,222,64,224,120,211,179,129,190,235,68,168,110,149,195,241,105,57,222,253,139,191,7,170,104,138,22,108,159,178,100,52,200,94,238,247,52,174,189,244,98,241,25,230,59,73,250,2,98,249,42,170,189,130,45,217,96,232,143,172,169,64,227,169,36,228,51,36,155,238,44,96,95,228,135,20,61,60,6,42,146,223,207,104,183,22,183,205,170,128,249,162,95,203,34,191,83,213,237,32,132,22,77,191,40,181,163,231,13,26,242,94,205,108,4,0,0 };
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

