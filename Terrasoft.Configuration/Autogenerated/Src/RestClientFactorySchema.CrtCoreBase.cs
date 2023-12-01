namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RestClientFactorySchema

	/// <exclude/>
	public class RestClientFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RestClientFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RestClientFactorySchema(RestClientFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d31eb8c4-6fa9-4307-aac7-0b01e4d010f5");
			Name = "RestClientFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,193,110,219,48,12,134,207,14,144,119,32,210,75,10,12,246,189,109,50,96,89,135,21,232,186,33,105,31,64,117,152,88,128,44,169,36,133,32,43,246,238,99,100,101,73,187,205,39,233,231,79,234,35,105,111,122,228,104,90,132,71,36,50,28,54,82,47,130,223,216,109,34,35,54,248,241,232,117,60,170,18,91,191,133,37,178,172,58,67,241,122,60,82,241,130,112,171,14,88,56,195,124,149,163,11,103,209,203,23,211,74,160,125,54,53,77,3,55,156,250,222,208,126,94,238,37,254,1,118,157,109,59,104,9,141,32,195,242,118,245,8,109,174,0,59,43,26,8,68,216,10,172,113,99,146,19,96,20,81,14,174,143,117,155,179,194,49,61,59,219,2,139,98,183,90,70,153,254,133,84,189,102,172,63,240,223,80,186,176,86,252,31,57,127,8,190,135,206,194,226,127,152,38,70,10,145,172,70,161,51,126,237,144,50,226,223,140,131,18,13,153,30,188,78,126,54,121,54,140,79,228,38,243,79,122,128,167,229,61,72,128,164,199,77,32,48,206,1,225,75,210,46,184,190,105,114,222,169,12,161,36,242,60,207,60,197,166,174,163,124,240,189,157,201,221,105,28,165,153,147,48,101,161,195,138,11,15,204,96,50,185,132,195,234,171,234,44,173,180,61,131,193,94,223,241,67,114,238,59,221,246,81,246,211,146,124,153,179,170,143,224,113,119,182,130,105,209,175,222,235,199,180,235,28,31,158,168,87,218,70,252,140,140,58,87,103,127,230,127,241,107,25,238,180,88,135,86,11,84,150,126,149,229,162,95,15,251,205,247,65,125,43,170,166,223,111,206,16,247,52,255,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d31eb8c4-6fa9-4307-aac7-0b01e4d010f5"));
		}

		#endregion

	}

	#endregion

}

