﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PersistentLookupColumnProcessorSchema

	/// <exclude/>
	public class PersistentLookupColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PersistentLookupColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PersistentLookupColumnProcessorSchema(PersistentLookupColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9af03088-2f4f-4c07-8b9e-00dc4da8eb75");
			Name = "PersistentLookupColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,87,91,111,219,54,20,126,86,129,254,7,46,125,145,49,79,126,79,109,3,109,236,116,222,210,45,168,211,237,161,40,10,90,58,142,57,75,164,75,82,94,133,33,255,125,135,23,217,178,68,217,73,128,38,210,209,185,126,231,90,78,11,80,59,154,2,121,0,41,169,18,107,157,220,8,190,102,143,165,164,154,9,158,220,178,28,22,197,78,72,77,254,123,253,42,42,21,227,143,100,89,41,13,197,219,214,59,74,230,57,164,70,76,37,31,128,131,100,105,135,231,142,241,239,71,98,211,106,81,8,30,254,34,161,143,158,204,185,102,154,129,234,101,184,165,169,22,210,113,32,207,27,9,143,232,31,185,201,169,82,215,228,30,164,98,232,23,215,119,66,108,203,29,70,80,22,252,94,138,20,148,18,210,138,140,70,35,50,102,124,131,225,232,76,164,100,52,69,226,151,25,172,105,153,235,247,140,103,104,53,214,213,14,196,58,94,28,21,182,84,13,134,228,15,4,155,76,8,199,63,200,122,193,244,96,240,21,205,236,202,85,206,82,146,26,111,47,57,75,174,201,123,170,160,69,29,146,126,159,8,90,48,73,141,204,191,26,25,252,186,3,105,48,189,54,207,26,19,10,153,5,194,33,161,202,162,160,178,154,214,132,25,213,148,236,105,94,2,49,32,144,146,179,239,248,204,50,180,199,214,12,100,114,16,29,53,101,119,181,110,34,246,152,50,228,39,31,74,150,89,125,127,25,117,15,168,237,243,34,35,147,233,41,45,113,209,183,249,92,126,163,55,192,51,23,137,127,247,97,221,50,200,51,27,18,219,83,13,238,227,206,189,16,9,52,19,60,175,200,194,149,186,199,119,83,242,173,50,118,16,135,61,58,40,201,55,102,191,55,105,111,155,138,156,160,7,24,50,235,159,34,223,242,16,249,130,195,216,134,74,203,210,84,175,113,219,22,130,247,218,21,197,133,114,136,63,43,144,168,132,187,142,36,229,201,235,0,171,101,133,213,18,183,201,182,30,162,64,156,88,185,182,105,92,67,85,216,224,122,124,1,174,105,108,149,69,28,254,109,134,243,78,62,150,5,186,29,95,157,26,191,26,146,83,159,7,86,124,96,17,126,58,143,214,71,208,27,209,155,223,96,90,62,130,113,66,144,223,4,227,65,134,248,14,225,29,159,147,157,146,28,89,106,208,246,84,98,37,41,156,10,166,203,49,230,179,102,157,76,244,201,10,40,47,49,99,54,112,236,145,49,162,133,131,101,24,34,153,62,153,78,99,7,207,147,133,39,90,227,176,163,233,134,196,198,11,134,147,150,48,126,226,93,244,46,203,188,237,216,121,153,120,219,67,203,95,191,57,184,13,222,248,91,130,46,37,247,81,53,243,80,35,187,23,216,178,13,205,47,9,192,171,85,65,150,126,169,244,176,101,234,208,130,177,119,217,34,182,38,241,79,222,104,242,32,43,44,97,155,147,216,198,255,59,84,67,34,74,221,107,218,77,185,193,65,93,84,171,194,248,27,42,236,147,213,235,161,140,158,8,228,10,14,98,71,134,228,86,200,57,122,30,51,51,229,172,250,47,204,104,249,138,245,192,90,74,142,105,105,229,96,49,231,216,79,146,174,114,24,47,14,125,107,219,113,220,104,77,67,68,248,48,232,63,229,13,2,166,161,102,75,183,42,118,130,247,84,226,118,210,56,89,8,107,17,234,176,45,136,129,249,96,6,194,66,185,33,48,255,129,133,167,226,182,138,196,25,89,98,55,32,190,139,236,8,101,72,223,169,143,219,174,186,80,165,246,56,118,217,149,23,14,153,203,123,17,173,42,83,132,56,147,73,6,74,51,110,15,42,124,182,135,3,217,29,246,108,207,130,180,148,157,241,216,158,12,147,43,179,80,117,181,76,55,80,80,55,236,175,166,246,254,169,136,178,68,111,46,25,143,172,88,88,139,227,177,165,117,53,117,106,252,250,102,28,27,169,112,103,95,71,133,195,87,213,18,23,34,26,143,106,254,158,85,31,232,49,177,250,7,153,108,129,58,35,179,163,141,227,81,226,86,202,188,3,5,233,162,131,167,143,77,242,205,49,98,210,136,190,46,190,51,174,100,33,15,176,53,205,230,76,46,248,25,240,199,213,122,211,5,87,193,65,51,118,170,124,130,53,72,224,41,56,61,120,230,120,134,202,28,147,195,64,208,73,87,196,91,241,29,18,52,246,178,234,111,220,34,193,227,184,190,80,28,140,120,122,113,183,251,112,218,45,233,30,226,102,90,102,39,133,116,120,126,102,238,234,174,15,30,88,73,199,240,137,129,78,30,158,158,17,146,221,119,222,206,243,103,166,217,75,121,235,72,194,50,234,25,197,161,57,119,80,179,161,60,203,237,53,102,175,42,163,206,205,120,23,243,175,238,115,235,248,243,21,224,101,19,239,255,92,74,252,63,192,207,19,178,196,140,55,105,142,91,203,170,30,207,225,227,162,21,80,242,55,66,6,113,110,86,89,158,44,181,89,77,147,73,157,71,195,102,105,201,131,240,182,26,155,212,44,149,206,136,182,11,197,139,83,44,104,220,231,89,59,176,163,138,104,133,62,110,253,178,244,75,225,24,242,252,7,164,165,118,155,190,181,81,201,26,75,34,207,15,193,6,81,250,165,15,37,167,36,92,128,231,206,192,112,134,122,10,25,79,51,188,155,193,226,23,247,223,171,157,140,44,193,156,64,113,106,82,146,38,150,212,146,177,42,7,152,19,115,235,198,131,193,185,61,232,168,77,162,165,188,126,133,63,255,3,28,200,191,87,73,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9af03088-2f4f-4c07-8b9e-00dc4da8eb75"));
		}

		#endregion

	}

	#endregion

}

