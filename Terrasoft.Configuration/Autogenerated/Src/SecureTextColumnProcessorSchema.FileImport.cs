namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecureTextColumnProcessorSchema

	/// <exclude/>
	public class SecureTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecureTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecureTextColumnProcessorSchema(SecureTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("327ab3d6-e22f-4c90-99c4-1e825c0a5c40");
			Name = "SecureTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,197,190,167,73,96,147,210,18,88,150,66,147,94,74,15,138,60,78,4,246,200,29,73,101,67,217,255,190,99,57,110,235,108,92,168,47,150,134,167,247,52,159,36,82,37,186,74,105,132,53,50,43,103,115,159,44,45,229,102,23,88,121,99,41,185,53,5,174,202,202,178,191,188,120,187,188,24,4,103,104,7,15,7,231,177,188,126,159,127,94,205,216,87,79,110,149,246,150,13,58,81,136,230,7,227,78,50,96,89,40,231,38,240,128,58,48,174,241,143,95,218,34,148,116,207,86,163,115,150,163,56,77,83,152,26,218,35,27,159,89,13,154,49,159,13,207,168,135,233,188,149,187,80,150,138,15,237,252,39,129,33,231,21,73,191,54,7,191,55,14,116,157,13,50,96,1,97,201,153,109,129,144,91,134,170,241,171,187,248,101,105,87,7,129,142,73,240,170,138,128,46,105,83,210,79,49,79,55,152,171,80,248,133,161,76,150,142,252,161,66,155,143,86,39,123,28,95,193,111,65,15,51,32,249,137,160,183,247,241,248,89,108,171,176,45,140,62,110,182,87,11,19,56,75,111,240,22,9,126,240,150,62,61,135,250,44,4,251,125,244,110,20,223,132,252,31,229,88,88,50,42,143,174,203,90,56,136,18,241,104,217,219,131,24,39,239,206,233,169,245,180,82,172,202,8,109,54,12,14,89,90,33,212,245,77,29,206,55,50,151,35,106,11,201,52,141,234,184,248,8,176,55,118,180,233,152,65,215,123,44,100,183,202,225,232,180,92,191,136,193,223,35,93,164,172,1,220,165,45,25,21,178,151,91,63,169,199,94,214,98,246,21,238,133,36,125,3,247,141,242,170,185,146,13,229,64,230,69,198,38,67,242,38,55,200,61,60,171,118,47,96,95,229,153,138,30,238,130,201,162,223,99,109,183,22,183,205,42,131,217,188,91,75,62,40,158,106,175,207,162,104,0,117,139,82,147,239,31,172,116,168,198,128,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("327ab3d6-e22f-4c90-99c4-1e825c0a5c40"));
		}

		#endregion

	}

	#endregion

}

