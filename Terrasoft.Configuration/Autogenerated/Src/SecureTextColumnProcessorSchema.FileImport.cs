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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,139,125,79,147,192,54,165,37,176,44,133,38,123,89,122,80,228,113,42,176,71,238,72,42,27,202,254,247,29,201,113,91,103,227,133,250,98,105,120,122,79,243,73,34,85,163,107,148,70,216,32,179,114,182,244,217,202,82,105,246,129,149,55,150,178,91,83,225,186,110,44,251,203,139,215,203,139,81,112,134,246,240,112,112,30,235,171,183,249,199,213,140,67,245,236,86,105,111,217,160,19,133,104,190,48,238,37,3,86,149,114,110,6,15,168,3,227,6,127,251,149,173,66,77,247,108,53,58,103,57,137,243,60,135,185,161,39,100,227,11,171,65,51,150,139,241,25,245,56,95,118,114,23,234,90,241,161,155,127,35,48,228,188,34,233,215,150,224,159,140,3,29,179,65,6,44,32,44,57,179,171,16,74,203,208,180,126,177,139,239,150,246,49,8,116,74,130,23,85,5,116,89,151,146,127,136,249,117,131,165,10,149,191,54,84,200,210,137,63,52,104,203,201,250,100,143,211,175,240,67,208,195,2,72,126,34,24,236,125,58,125,20,219,38,236,42,163,143,155,29,212,194,12,206,210,27,189,38,130,239,188,165,79,207,33,158,133,96,191,79,222,173,226,147,144,255,161,156,10,43,70,229,209,245,89,11,7,81,34,30,45,7,123,16,227,236,205,57,63,181,158,55,138,85,157,160,45,198,193,33,75,43,132,58,222,212,241,114,43,115,57,162,174,144,205,243,164,78,139,143,0,7,99,39,219,158,25,244,189,167,66,118,167,28,78,78,203,241,69,140,254,28,233,34,21,45,224,62,109,201,104,144,189,220,250,89,28,123,89,139,197,255,112,95,75,210,39,112,223,40,175,218,43,217,82,14,100,158,101,108,10,36,111,74,131,60,192,179,233,246,2,246,69,158,169,232,225,46,152,34,249,253,140,118,27,113,219,174,11,88,44,251,181,236,157,226,169,246,234,44,138,22,80,191,40,181,248,253,5,36,65,113,237,129,4,0,0 };
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

