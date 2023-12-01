namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PhoneTextColumnProcessorSchema

	/// <exclude/>
	public class PhoneTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PhoneTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PhoneTextColumnProcessorSchema(PhoneTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91251571-ba36-4a68-9430-619bc29975f7");
			Name = "PhoneTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,139,219,48,16,133,207,89,216,255,48,164,151,4,138,125,207,38,129,110,150,45,129,82,22,154,244,82,122,80,228,113,34,176,71,238,72,90,26,150,254,247,142,228,56,187,78,227,194,250,98,105,120,122,79,243,73,34,85,163,107,148,70,216,32,179,114,182,244,217,202,82,105,246,129,149,55,150,178,71,83,225,186,110,44,251,219,155,151,219,155,81,112,134,246,240,237,232,60,214,119,231,249,219,213,140,67,245,236,81,105,111,217,160,19,133,104,62,48,238,37,3,86,149,114,110,6,79,7,75,184,193,223,126,101,171,80,211,19,91,141,206,89,78,218,60,207,97,110,232,128,108,124,97,53,104,198,114,49,190,162,30,231,203,78,238,66,93,43,62,118,243,79,4,134,156,87,36,237,218,18,252,193,56,208,49,26,100,192,194,193,146,51,187,10,161,180,12,77,235,23,155,248,98,105,31,131,64,167,36,120,86,85,64,151,117,41,249,155,152,31,15,88,170,80,249,123,67,133,44,157,248,99,131,182,156,172,47,246,56,253,8,95,133,60,44,128,228,39,130,161,214,167,211,159,226,218,132,93,101,244,105,175,67,82,152,193,85,118,163,151,196,239,21,182,116,233,57,196,131,136,204,147,117,171,120,39,226,127,24,167,194,138,81,121,116,125,210,66,65,148,136,39,203,161,22,196,55,59,27,231,151,206,243,70,177,170,19,177,197,56,56,100,233,132,80,199,91,58,94,110,101,46,231,211,21,178,121,158,212,105,241,9,223,80,234,100,219,243,130,190,245,84,184,238,148,195,201,101,57,62,134,209,159,19,91,164,162,197,219,103,45,25,13,178,151,11,63,139,99,47,107,177,248,31,236,123,73,122,7,236,7,229,85,123,29,91,198,129,204,47,25,155,2,201,155,210,32,15,224,108,186,189,128,125,150,23,42,122,248,28,76,145,252,190,71,187,141,184,109,215,5,44,150,253,90,118,134,120,41,189,187,74,162,229,211,47,166,154,124,127,1,148,211,85,180,124,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91251571-ba36-4a68-9430-619bc29975f7"));
		}

		#endregion

	}

	#endregion

}

