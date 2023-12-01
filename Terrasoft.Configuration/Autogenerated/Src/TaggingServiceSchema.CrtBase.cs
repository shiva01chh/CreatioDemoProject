﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TaggingServiceSchema

	/// <exclude/>
	public class TaggingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TaggingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TaggingServiceSchema(TaggingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db270a93-43b8-41ee-a0b7-a35950edf93c");
			Name = "TaggingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,77,111,219,72,12,61,59,64,255,3,225,94,100,32,149,239,73,156,34,205,54,139,44,224,52,72,92,244,16,44,22,99,137,182,7,145,52,234,204,200,89,55,200,127,47,231,67,182,36,75,177,147,162,40,218,139,97,113,72,206,35,249,72,78,198,82,84,57,139,16,38,40,37,83,98,166,195,115,145,205,248,188,144,76,115,145,133,19,54,159,243,108,254,230,224,241,205,65,175,80,244,23,110,87,74,99,122,220,248,14,111,138,76,243,20,195,91,148,156,37,252,155,181,223,210,162,211,37,143,112,44,98,76,158,61,12,207,34,205,151,187,157,132,95,112,186,81,168,134,145,166,85,211,234,137,196,46,121,120,193,34,45,36,71,213,166,65,87,109,252,210,249,91,137,115,194,7,231,9,83,234,8,124,174,60,186,27,252,90,160,210,86,113,56,28,194,137,42,210,148,201,213,169,255,182,70,32,102,32,157,34,104,103,14,202,217,135,165,221,176,98,120,247,23,211,140,42,164,37,225,252,151,4,121,49,77,120,4,145,117,214,1,160,247,104,65,172,225,94,75,145,163,212,20,228,17,92,91,123,119,222,68,105,5,101,57,49,6,164,2,235,21,168,104,129,41,3,114,46,87,14,127,36,100,172,194,181,139,42,96,135,120,140,233,20,101,112,69,116,131,17,244,189,197,71,245,117,227,189,127,8,151,202,64,230,146,174,26,129,150,5,14,76,132,101,136,74,75,147,157,155,22,91,120,132,57,234,99,202,28,253,60,253,80,48,84,132,151,68,98,212,95,21,198,164,105,216,22,195,91,204,98,87,51,251,237,164,13,225,14,14,170,92,100,10,247,33,161,211,252,9,44,244,142,143,160,54,89,182,16,54,89,74,218,148,43,97,218,177,193,83,127,91,251,61,193,128,50,249,180,143,226,199,255,35,204,13,20,192,129,209,238,29,193,148,145,28,247,246,192,51,13,57,65,68,165,48,246,196,60,23,52,7,141,7,189,224,42,188,110,59,37,90,180,90,117,213,253,117,141,235,174,162,210,174,239,122,69,167,182,226,236,215,8,109,146,208,30,230,207,96,116,39,147,9,194,146,199,168,224,1,167,239,60,121,97,38,36,60,8,121,15,15,92,47,214,189,189,205,103,239,188,74,233,187,51,149,95,161,166,113,159,19,95,167,60,161,105,225,251,58,165,217,161,130,234,135,217,68,148,174,29,38,70,43,44,103,195,96,71,223,80,191,124,32,54,174,195,110,182,199,5,199,36,54,60,144,102,75,162,167,171,251,128,75,239,107,204,50,54,71,9,255,233,218,247,241,11,104,182,143,251,198,231,200,210,169,215,184,20,222,191,183,226,160,41,31,89,113,207,150,219,173,223,85,248,55,234,147,198,45,167,65,134,15,126,42,20,70,235,76,206,11,147,215,160,95,80,189,233,32,195,200,180,51,141,224,207,53,193,96,48,216,17,241,11,103,205,206,25,19,212,1,64,29,96,109,218,52,142,54,142,187,176,142,81,47,68,103,229,151,130,199,112,190,192,232,222,175,255,160,245,81,80,62,58,232,62,11,198,127,134,214,178,76,236,85,145,36,65,223,31,245,77,14,43,154,109,123,184,205,188,77,175,233,107,107,25,182,57,218,82,242,94,246,78,215,174,129,121,22,199,202,206,8,208,98,199,168,180,146,156,73,150,66,70,147,114,180,78,210,233,164,190,62,203,60,135,39,67,171,190,177,150,168,11,153,169,22,3,183,92,200,162,84,177,195,249,19,181,164,93,156,213,33,213,187,163,39,233,101,182,20,247,24,184,64,205,208,190,254,116,59,49,77,32,249,4,211,60,49,180,32,41,133,103,82,72,7,31,68,188,186,213,171,196,136,201,126,76,147,155,26,108,45,13,191,72,150,231,102,150,91,232,135,182,84,254,227,66,200,148,233,154,157,19,133,255,40,145,29,66,185,26,159,215,171,237,143,142,231,130,135,187,31,125,53,61,222,30,253,24,169,114,191,84,115,116,235,45,153,108,223,188,229,12,234,213,71,78,88,130,120,142,244,135,208,73,227,242,94,87,72,48,243,171,227,37,209,254,138,112,230,79,16,49,29,45,160,246,96,41,195,221,237,26,75,55,149,102,105,229,255,13,166,98,137,190,5,102,82,164,127,96,19,184,24,127,167,62,216,32,254,181,173,80,193,241,167,117,195,30,143,82,43,59,56,248,14,215,250,252,247,48,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db270a93-43b8-41ee-a0b7-a35950edf93c"));
		}

		#endregion

	}

	#endregion

}
