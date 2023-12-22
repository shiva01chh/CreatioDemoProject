namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MediumTextColumnProcessorSchema

	/// <exclude/>
	public class MediumTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MediumTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MediumTextColumnProcessorSchema(MediumTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("849d8e1e-95a1-4326-a3ca-a768f4bf5d14");
			Name = "MediumTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,106,227,48,16,134,207,41,244,29,134,244,146,192,98,223,211,36,208,166,116,201,97,151,66,147,189,44,61,40,242,56,29,176,37,239,72,42,27,74,223,189,99,57,110,226,52,46,212,23,75,195,63,255,204,124,146,140,42,209,85,74,35,172,144,89,57,155,251,100,97,77,78,219,192,202,147,53,201,61,21,184,44,43,203,254,242,226,245,242,98,16,28,153,45,60,238,156,199,242,250,99,127,156,205,216,23,79,238,149,246,150,9,157,40,68,115,197,184,149,26,176,40,148,115,19,248,133,25,133,114,133,255,253,194,22,161,52,15,108,53,58,103,57,138,211,52,133,41,153,103,100,242,153,213,160,25,243,217,240,140,122,152,206,91,185,11,101,169,120,215,238,111,12,144,113,94,25,153,215,230,224,159,201,129,174,107,131,44,88,64,88,227,104,83,32,228,150,161,106,252,234,41,14,141,129,142,181,224,69,21,1,93,210,214,73,143,10,253,189,195,92,133,194,223,146,201,36,121,228,119,21,218,124,180,60,233,114,252,3,126,11,124,152,129,145,159,8,122,167,31,143,159,196,182,10,155,130,244,190,221,94,45,76,224,44,191,193,107,100,120,32,46,147,122,14,245,105,8,248,135,232,221,40,190,137,249,19,231,24,88,48,42,143,174,75,91,56,136,18,113,111,217,59,131,24,39,31,206,233,169,245,180,82,172,202,8,109,54,12,14,89,70,49,168,235,187,58,156,175,101,47,71,212,6,146,105,26,213,49,121,15,176,183,236,104,221,49,131,174,247,88,200,110,148,195,209,105,184,126,19,131,183,61,93,52,89,3,184,75,91,106,84,200,94,238,253,164,94,123,201,197,236,43,220,183,82,233,27,184,239,148,87,205,149,108,40,7,67,255,100,77,25,26,79,57,33,247,240,172,218,94,192,190,200,67,21,61,252,12,148,69,191,63,181,221,74,220,214,203,12,102,243,110,44,57,80,60,213,94,159,69,209,0,234,6,37,118,252,189,3,214,247,29,143,139,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("849d8e1e-95a1-4326-a3ca-a768f4bf5d14"));
		}

		#endregion

	}

	#endregion

}

