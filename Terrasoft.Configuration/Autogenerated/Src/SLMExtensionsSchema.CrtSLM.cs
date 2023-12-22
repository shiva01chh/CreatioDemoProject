namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SLMExtensionsSchema

	/// <exclude/>
	public class SLMExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SLMExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SLMExtensionsSchema(SLMExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e7af41a-b3ac-4f70-b275-48bf9b53119e");
			Name = "SLMExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,84,193,110,219,48,12,61,187,64,255,129,232,46,233,48,216,247,38,205,37,43,208,2,203,48,160,222,118,86,109,38,22,106,203,134,40,165,11,138,254,251,40,201,178,227,164,107,177,75,125,35,249,200,247,72,63,91,137,6,169,19,5,66,142,90,11,106,55,38,93,181,106,35,183,86,11,35,91,149,222,127,91,223,252,49,168,136,3,58,63,123,62,63,75,44,73,181,253,87,195,252,61,64,186,18,53,170,82,104,26,161,49,149,203,6,127,42,105,224,250,253,238,52,130,121,12,15,250,164,113,203,117,88,213,130,8,174,224,72,55,35,178,44,131,5,217,166,17,122,191,236,227,251,14,11,185,145,133,131,3,58,188,35,129,6,77,213,150,148,198,174,236,160,173,179,15,53,55,144,97,61,5,20,158,238,136,44,121,246,132,131,166,117,24,199,170,126,248,230,80,61,214,227,19,188,236,14,181,33,40,172,214,172,6,12,111,9,6,117,3,166,5,83,33,20,45,23,168,107,85,233,46,55,150,159,164,169,160,145,202,26,12,89,203,183,73,7,162,236,152,105,209,9,45,26,80,236,128,235,11,55,225,98,185,138,156,28,45,50,95,31,225,26,141,213,138,150,121,100,76,23,89,204,57,208,244,46,14,149,59,89,253,66,121,187,246,210,104,102,42,73,99,217,13,186,4,231,170,36,217,9,13,188,154,173,221,251,87,248,52,160,102,151,115,15,8,197,193,2,119,37,227,188,146,49,19,128,196,199,40,42,152,249,98,190,239,48,82,36,133,32,60,177,91,122,219,90,125,21,0,145,196,117,241,248,19,104,88,99,62,5,255,18,181,197,40,38,4,159,135,86,190,0,25,234,27,233,78,57,178,216,255,160,81,60,206,223,146,246,187,213,143,252,162,255,67,97,223,241,209,66,191,138,253,135,158,240,180,236,178,92,100,33,175,169,46,113,35,152,104,170,177,39,124,5,255,114,232,184,239,236,233,29,14,166,157,186,51,90,235,45,91,126,9,144,254,34,131,45,251,244,233,238,65,66,116,189,251,200,250,47,195,167,94,250,223,11,15,15,127,24,31,135,236,52,201,185,195,231,47,222,130,201,36,239,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e7af41a-b3ac-4f70-b275-48bf9b53119e"));
		}

		#endregion

	}

	#endregion

}

