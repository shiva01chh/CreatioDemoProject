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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,233,37,129,197,190,167,73,160,77,233,18,40,165,208,100,47,75,15,138,60,78,5,182,228,29,141,74,67,233,127,239,88,142,219,56,141,23,234,139,165,225,233,61,205,39,201,170,18,125,165,52,194,10,137,148,119,57,39,11,103,115,179,13,164,216,56,155,220,154,2,151,101,229,136,207,207,222,206,207,6,193,27,187,133,199,157,103,44,47,63,231,135,171,9,251,234,201,173,210,236,200,160,23,133,104,46,8,183,146,1,139,66,121,63,129,71,212,129,112,133,175,188,112,69,40,237,3,57,141,222,59,138,226,52,77,97,106,236,51,146,225,204,105,208,132,249,108,120,66,61,76,231,173,220,135,178,84,180,107,231,87,22,140,245,172,172,244,235,114,224,103,227,65,215,217,32,3,18,16,206,122,179,41,16,114,71,80,53,126,117,23,119,206,110,235,32,208,49,9,94,84,17,208,39,109,74,122,16,243,247,6,115,21,10,190,54,54,147,165,35,222,85,232,242,209,242,104,143,227,95,112,47,232,97,6,86,126,34,232,237,125,60,126,18,219,42,108,10,163,247,155,237,213,194,4,78,210,27,188,69,130,95,188,165,79,166,80,159,133,96,127,136,222,141,226,135,144,191,81,142,133,5,161,98,244,93,214,194,65,148,136,123,203,222,30,196,56,249,116,78,143,173,167,149,34,85,70,104,179,97,240,72,210,138,69,93,223,212,225,124,45,115,57,162,182,144,76,211,168,142,139,247,0,123,99,71,235,142,25,116,189,199,66,118,163,60,142,142,203,245,139,24,188,239,233,162,205,26,192,93,218,146,81,33,177,220,250,73,61,102,89,139,217,255,112,95,75,210,15,112,223,40,86,205,149,108,40,7,107,254,201,216,100,104,217,228,6,169,135,103,213,238,5,220,139,60,83,209,195,239,96,178,232,247,167,182,91,137,219,122,153,193,108,222,173,37,95,20,143,181,151,39,81,52,128,186,69,169,29,126,31,101,12,211,76,137,4,0,0 };
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

