namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateColumnProcessorSchema

	/// <exclude/>
	public class DateColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateColumnProcessorSchema(DateColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f8c37261-6156-4687-9016-d3e9e21442ee");
			Name = "DateColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,65,107,227,48,16,133,207,45,244,63,12,233,37,129,98,223,219,36,176,77,105,201,101,41,108,210,75,217,131,34,143,211,1,91,242,142,164,66,40,251,223,59,146,227,110,236,186,11,187,190,88,26,222,188,167,249,44,27,85,163,107,148,70,216,32,179,114,182,244,217,202,154,146,246,129,149,39,107,178,123,170,112,93,55,150,253,197,249,219,197,249,89,112,100,246,240,227,224,60,214,55,31,251,211,110,198,175,234,217,189,210,222,50,161,19,133,104,46,25,247,146,1,171,74,57,119,13,119,202,227,202,86,161,54,143,108,53,58,103,57,201,242,60,135,57,153,23,100,242,133,213,160,25,203,197,36,170,55,84,15,59,38,249,178,107,113,161,174,21,31,186,253,55,3,100,156,87,70,166,181,37,248,23,114,160,99,50,200,130,5,131,53,142,118,21,66,105,25,154,214,47,206,16,131,64,167,20,120,85,85,64,151,117,9,249,73,196,243,29,150,42,84,254,150,76,33,109,83,127,104,208,150,211,245,224,124,179,43,248,46,208,97,1,70,94,34,24,153,122,54,251,41,134,77,216,85,164,143,71,28,81,65,75,108,132,129,52,191,37,114,127,8,203,108,158,67,164,47,160,31,147,115,171,248,15,184,159,232,166,194,138,81,154,92,159,177,48,16,37,226,137,237,103,203,236,195,51,31,154,206,27,197,170,78,168,22,147,224,144,101,16,131,58,222,204,201,114,43,123,249,48,93,33,155,231,73,157,154,143,240,70,2,167,219,158,13,244,93,103,66,117,167,28,78,135,229,120,247,207,126,31,169,162,41,90,176,125,202,146,209,32,123,185,223,215,113,237,165,23,139,191,97,190,149,164,127,64,44,211,168,246,10,182,100,131,161,95,178,166,2,141,167,146,144,191,32,217,116,103,1,251,42,63,164,232,225,33,80,145,252,158,162,221,70,220,182,235,2,22,203,126,45,139,252,134,170,155,81,8,45,154,126,81,106,167,207,59,104,157,27,60,109,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f8c37261-6156-4687-9016-d3e9e21442ee"));
		}

		#endregion

	}

	#endregion

}

