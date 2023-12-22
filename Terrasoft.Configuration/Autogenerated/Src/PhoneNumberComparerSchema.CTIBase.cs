﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PhoneNumberComparerSchema

	/// <exclude/>
	public class PhoneNumberComparerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PhoneNumberComparerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PhoneNumberComparerSchema(PhoneNumberComparerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("82b8c77b-e5ad-49b4-a2f0-d9ddb0e2aeed");
			Name = "PhoneNumberComparer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66546323-e613-47c2-afd8-43e728c055f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,91,79,227,70,20,126,206,74,251,31,102,221,23,71,74,157,118,251,80,137,92,40,162,236,42,18,44,180,201,150,7,74,171,137,115,146,140,100,207,152,153,49,144,238,242,223,123,230,226,196,142,157,64,217,85,219,7,120,1,207,156,203,119,238,103,224,52,5,149,209,24,200,4,164,164,74,204,117,116,44,248,156,45,114,73,53,19,252,245,171,79,175,95,181,114,197,248,130,140,87,74,67,218,219,250,70,250,36,129,216,16,171,232,61,112,144,44,174,209,156,50,126,83,59,156,192,189,142,126,133,69,158,80,121,114,159,73,80,202,8,217,208,149,49,165,169,224,205,55,18,118,157,71,39,92,51,205,192,136,68,146,111,36,44,80,1,137,19,170,212,1,185,88,10,14,31,242,116,10,18,197,103,84,130,180,100,221,110,151,244,85,158,166,84,174,134,254,123,196,53,200,185,241,211,92,72,18,91,114,163,15,63,230,44,193,59,243,49,93,145,204,200,36,220,10,85,81,33,172,91,146,150,229,211,132,197,132,173,5,142,26,113,180,62,89,44,53,48,246,224,140,234,120,9,138,232,37,226,97,82,233,138,94,114,199,244,210,222,73,184,69,24,48,35,51,182,96,90,145,80,1,149,241,210,211,181,137,152,91,50,5,177,224,179,138,140,104,173,187,187,173,188,143,8,105,74,56,102,206,32,200,54,216,191,15,134,147,70,60,81,191,107,89,154,37,56,72,78,196,91,39,226,11,96,215,84,73,208,185,228,106,216,143,135,90,230,208,239,198,67,194,230,213,56,17,116,57,129,155,156,38,29,34,80,178,188,99,10,200,183,4,121,230,52,81,150,9,37,23,162,140,236,169,16,137,11,67,168,180,13,126,217,19,29,226,15,43,198,181,123,79,12,105,61,152,84,147,4,40,250,213,92,84,188,65,230,82,164,150,107,193,110,129,227,165,126,70,236,156,223,43,122,181,32,169,193,244,244,232,41,39,165,10,15,241,24,81,174,98,192,90,179,59,72,35,23,88,207,154,122,151,236,49,222,51,146,82,116,247,132,112,227,151,230,80,30,241,85,67,52,59,100,116,130,234,64,210,105,2,125,119,63,172,68,86,237,141,236,123,208,69,165,154,70,161,140,59,188,21,152,191,154,198,120,221,212,57,158,18,66,80,55,206,233,96,26,221,138,40,116,88,74,201,77,14,114,133,58,209,115,78,19,122,209,245,45,171,207,68,35,205,57,139,109,135,223,31,96,11,75,213,243,67,237,142,162,33,93,72,145,103,166,80,189,209,29,135,166,112,65,35,16,235,134,77,38,111,107,43,199,204,246,245,213,216,90,251,139,49,246,157,21,188,153,68,198,235,99,107,250,177,83,229,8,84,88,227,36,232,195,14,57,101,74,175,99,235,108,54,65,109,61,236,156,8,198,74,59,72,190,214,68,112,194,26,134,1,57,120,100,70,20,115,13,77,85,154,114,109,102,155,100,183,84,131,187,207,220,135,241,58,86,17,78,30,242,51,204,105,158,120,15,57,177,167,192,23,216,105,6,228,199,222,94,30,59,9,57,77,182,184,126,232,17,15,6,248,204,225,169,130,123,199,32,153,237,66,38,129,206,4,79,86,86,209,159,170,6,171,183,155,152,53,224,233,237,135,98,253,36,243,88,11,105,0,89,247,239,41,224,17,199,29,130,38,236,47,211,139,8,135,59,84,108,252,140,179,219,79,162,190,2,244,148,132,249,32,104,8,84,208,29,186,224,62,181,170,115,101,152,57,119,169,236,106,207,156,153,96,248,195,74,245,249,4,106,80,29,126,172,136,34,85,201,109,98,118,187,86,171,193,225,24,81,187,64,85,118,193,8,247,182,49,104,141,153,109,54,61,253,27,77,114,8,171,50,59,36,168,103,85,208,177,122,90,59,211,206,214,26,2,105,10,230,151,64,105,74,214,45,48,77,36,14,206,195,254,44,58,3,189,20,59,51,218,207,145,11,9,153,20,49,110,182,54,58,149,241,82,184,191,216,21,180,68,83,113,29,134,123,92,138,179,4,119,195,208,53,143,195,67,18,4,29,242,83,112,245,199,239,179,107,252,43,8,188,195,226,37,149,87,215,196,252,58,194,197,119,133,2,80,76,52,17,199,197,73,232,41,237,7,202,181,155,85,184,102,240,183,174,183,218,220,118,104,74,20,209,56,159,250,195,239,58,102,80,46,163,51,198,55,4,145,243,89,167,169,110,219,255,208,147,143,149,226,203,226,251,95,47,190,190,215,60,107,255,245,249,142,40,194,50,117,52,82,31,242,36,57,151,39,105,166,49,97,201,231,207,85,198,109,130,66,80,145,182,22,171,75,228,135,114,69,101,235,226,131,153,45,63,44,143,237,130,44,3,241,197,96,109,99,170,104,12,200,84,19,228,115,158,244,7,59,7,144,55,116,35,103,27,117,213,196,19,19,5,21,214,52,181,203,118,53,114,142,53,149,90,93,98,234,239,226,126,120,121,119,252,15,223,29,181,74,122,254,243,163,84,88,149,11,50,24,32,226,164,150,122,181,130,105,72,44,21,89,60,165,19,50,24,250,146,175,192,43,147,180,31,79,184,151,231,208,215,127,14,249,84,250,87,94,69,219,77,124,157,100,166,109,191,113,71,54,117,106,109,218,16,149,147,174,41,175,111,113,207,118,173,75,153,190,107,255,112,66,162,49,24,43,194,173,6,222,246,183,151,88,123,16,142,173,152,143,154,37,246,223,126,102,112,8,237,102,199,229,146,105,24,155,127,117,22,44,19,97,236,43,22,36,99,208,155,146,250,167,217,112,75,139,231,222,123,27,226,129,221,161,30,13,68,232,220,43,22,24,235,228,60,3,183,212,26,244,177,142,206,165,135,132,57,10,20,235,162,232,10,190,249,48,94,118,211,26,97,161,195,62,68,149,224,147,85,6,197,187,180,248,28,20,235,194,35,243,203,73,108,29,146,38,161,110,86,121,146,131,102,18,59,148,204,76,114,150,180,74,62,138,142,102,51,99,127,116,140,214,105,112,236,134,244,194,212,15,216,124,172,194,246,11,123,43,184,242,105,123,92,174,147,3,127,120,48,154,93,71,229,167,5,46,202,188,220,149,170,189,174,132,104,207,142,250,224,94,181,213,83,75,90,254,249,27,122,214,166,193,70,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82b8c77b-e5ad-49b4-a2f0-d9ddb0e2aeed"));
		}

		#endregion

	}

	#endregion

}

