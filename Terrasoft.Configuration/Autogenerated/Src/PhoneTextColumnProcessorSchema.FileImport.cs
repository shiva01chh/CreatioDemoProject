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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,233,37,129,98,223,211,36,176,77,105,9,44,75,161,201,94,150,30,20,123,156,8,236,145,119,36,149,13,101,255,251,142,228,56,141,211,120,161,190,88,26,158,222,211,124,146,72,85,104,107,149,33,172,144,89,89,83,184,100,97,168,208,91,207,202,105,67,201,163,46,113,89,213,134,221,245,213,251,245,213,192,91,77,91,120,217,91,135,213,221,113,126,186,154,177,175,158,60,170,204,25,214,104,69,33,154,27,198,173,100,192,162,84,214,78,224,121,103,8,87,248,199,45,76,233,43,122,102,147,161,181,134,163,54,77,83,152,106,218,33,107,151,155,12,50,198,98,54,188,160,30,166,243,86,110,125,85,41,222,183,243,111,4,154,172,83,36,237,154,2,220,78,91,200,66,52,200,128,133,131,33,171,55,37,66,97,24,234,198,47,52,241,221,208,54,4,65,22,147,224,77,149,30,109,210,166,164,39,49,191,30,176,80,190,116,247,154,114,89,58,114,251,26,77,49,90,158,237,113,124,11,63,132,60,204,128,228,39,130,190,214,199,227,87,113,173,253,166,212,217,97,175,125,82,152,192,69,118,131,247,200,239,3,182,116,233,216,135,131,8,204,163,117,163,248,34,226,79,140,99,97,193,168,28,218,46,105,161,32,74,196,131,101,95,11,226,155,28,141,211,115,231,105,173,88,85,145,216,108,232,45,178,116,66,152,133,91,58,156,175,101,46,231,211,22,146,105,26,213,113,241,1,95,95,234,104,221,241,130,174,245,88,184,110,148,197,209,121,57,60,134,193,223,3,91,164,188,193,219,101,45,25,53,178,147,11,63,9,99,39,107,49,255,31,236,123,73,250,2,236,7,229,84,115,29,27,198,158,244,111,25,235,28,201,233,66,35,247,224,172,219,189,128,121,147,23,42,122,120,242,58,143,126,63,131,221,74,220,214,203,28,102,243,110,45,57,66,60,151,222,93,36,209,240,233,22,99,237,244,251,7,233,119,241,58,133,4,0,0 };
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

