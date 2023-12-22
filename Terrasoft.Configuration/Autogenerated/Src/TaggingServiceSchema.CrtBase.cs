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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,223,111,219,54,16,126,118,129,254,15,7,247,69,6,50,249,61,137,83,164,89,51,100,128,211,32,241,208,135,96,24,104,233,108,19,145,68,149,164,156,185,65,254,247,29,127,200,150,100,41,114,50,20,195,234,7,193,60,222,29,191,59,126,119,199,140,165,168,114,22,33,204,80,74,166,196,66,135,23,34,91,240,101,33,153,230,34,11,103,108,185,228,217,242,253,187,167,247,239,6,133,162,191,112,183,81,26,211,147,198,58,188,45,50,205,83,12,239,80,114,150,240,239,214,126,79,139,118,215,60,194,169,136,49,121,113,51,60,143,52,95,247,59,9,191,226,124,167,80,13,35,77,171,166,213,29,137,93,242,240,146,69,90,72,142,170,77,131,142,218,249,165,253,15,18,151,132,15,46,18,166,212,49,248,92,121,116,183,248,173,64,165,173,226,120,60,134,83,85,164,41,147,155,51,191,182,70,32,22,32,157,34,104,103,14,202,217,135,165,221,184,98,120,255,43,211,140,110,72,75,194,249,39,9,242,98,158,240,8,34,235,172,3,192,224,201,130,216,194,189,145,34,71,169,41,200,99,184,177,246,110,191,137,210,10,202,235,196,24,144,46,88,111,64,69,43,76,25,144,115,185,113,248,35,33,99,21,110,93,84,1,59,196,83,76,231,40,131,107,162,27,76,96,232,45,62,171,111,59,239,195,35,184,82,6,50,151,116,212,4,180,44,112,100,34,44,67,84,90,154,236,220,182,216,194,19,44,81,159,80,230,232,243,252,175,130,161,75,120,77,36,70,253,77,97,204,154,134,109,49,124,192,44,118,119,102,215,78,218,16,246,112,80,229,34,83,120,8,9,157,230,15,96,161,119,124,12,181,206,178,135,176,201,82,210,166,92,9,83,142,13,158,250,211,218,207,9,70,148,201,231,67,20,63,255,29,97,110,160,0,142,140,246,224,24,230,140,228,120,176,7,158,105,200,9,34,42,133,177,39,230,133,160,62,104,60,232,21,87,225,77,219,46,209,162,213,170,235,222,223,86,184,238,40,186,218,237,89,111,168,212,86,156,195,26,161,77,18,218,195,252,17,140,238,100,50,65,88,243,24,21,60,226,252,23,79,94,88,8,9,143,66,62,192,35,215,171,109,109,239,243,217,59,175,82,250,254,92,229,215,168,169,221,231,196,215,57,79,168,91,248,186,78,169,119,168,160,186,48,147,136,210,213,99,98,180,194,178,55,140,122,234,134,234,229,19,177,113,27,118,179,60,46,57,38,177,225,129,52,83,18,61,93,221,2,174,188,175,41,203,216,18,37,252,165,107,235,147,87,208,236,16,247,141,229,196,210,105,208,56,20,62,126,180,226,160,41,159,88,241,192,94,183,27,191,155,240,55,212,167,141,83,206,130,12,31,125,87,40,140,214,185,92,22,38,175,193,176,160,251,166,141,12,35,83,206,212,130,255,168,9,70,163,81,79,196,175,236,53,189,61,38,168,3,128,58,192,90,183,105,108,237,28,119,97,157,162,94,137,206,155,95,11,30,195,197,10,163,7,63,254,131,214,71,65,249,232,160,243,44,24,191,12,173,101,153,216,235,34,73,130,161,223,26,154,28,86,52,219,230,112,155,121,155,94,211,215,222,48,108,115,180,167,228,189,28,156,174,190,134,121,30,199,202,246,8,208,162,167,85,90,73,206,36,75,33,163,78,57,217,38,233,108,86,31,159,101,158,195,211,177,85,223,89,75,212,133,204,84,139,129,27,46,100,81,170,216,230,252,133,74,210,14,206,106,147,26,220,211,147,244,42,91,139,7,12,92,160,166,105,223,124,185,155,153,34,144,124,134,105,158,24,90,144,148,194,51,41,164,141,79,34,222,220,233,77,98,196,100,63,165,206,77,5,182,149,134,95,37,203,115,211,203,45,244,35,123,85,126,113,41,100,202,116,205,206,137,194,223,149,200,142,160,28,141,47,235,213,230,71,199,115,193,195,61,140,190,154,30,111,79,190,141,84,185,95,170,57,186,13,214,76,182,79,222,178,7,13,234,45,39,44,65,188,68,250,35,232,164,113,121,174,187,72,48,253,171,227,37,209,254,138,112,230,207,16,49,29,173,160,246,96,41,195,237,119,141,165,155,74,177,180,242,255,22,83,177,70,95,2,11,41,210,159,176,8,92,140,255,167,58,216,33,254,111,75,161,130,227,103,171,134,3,30,165,86,86,249,253,3,41,223,40,96,57,17,0,0 };
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

