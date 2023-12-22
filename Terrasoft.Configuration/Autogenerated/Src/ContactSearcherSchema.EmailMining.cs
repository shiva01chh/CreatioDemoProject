﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactSearcherSchema

	/// <exclude/>
	public class ContactSearcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactSearcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactSearcherSchema(ContactSearcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e0e96eab-9bae-48cd-88b6-f2b4a539d08e");
			Name = "ContactSearcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a4ad19d2-642a-44f9-afc4-8956cba156db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,219,110,219,56,16,125,118,129,254,3,215,125,145,0,67,126,79,98,23,105,214,14,12,228,86,56,109,30,138,98,193,72,35,155,128,68,57,36,149,194,219,238,191,239,240,34,235,98,122,237,52,109,22,221,205,67,108,209,156,153,51,135,103,134,164,56,205,65,174,104,12,228,22,132,160,178,72,85,116,86,240,148,45,74,65,21,43,120,52,201,41,203,46,25,103,124,241,250,213,215,215,175,122,165,196,175,100,190,150,10,242,227,206,51,218,102,25,196,218,80,70,231,192,65,176,120,107,206,5,227,15,245,96,51,174,128,93,227,209,132,43,166,24,72,255,132,60,47,248,78,211,41,141,85,33,172,45,206,121,35,96,129,248,200,140,43,16,41,166,126,68,102,152,178,194,89,115,160,34,94,130,48,243,134,195,33,57,145,101,158,83,177,30,187,231,27,81,60,178,4,36,41,21,203,152,90,147,28,212,178,72,36,73,11,65,164,177,214,0,98,235,78,70,149,155,97,195,207,170,188,207,88,76,88,21,222,19,189,247,213,32,216,64,189,180,81,142,200,141,177,181,63,118,241,153,1,231,195,2,170,96,96,44,146,80,69,239,169,4,114,191,38,11,246,8,156,128,94,88,66,19,1,82,130,129,186,141,213,142,172,168,160,57,225,40,149,81,223,88,201,254,248,130,73,69,138,212,122,145,68,21,46,125,244,31,157,12,141,69,237,64,128,42,5,151,227,90,29,218,148,33,111,248,145,22,37,79,106,202,78,134,213,108,109,62,155,240,50,7,65,239,51,56,57,47,89,50,118,25,190,91,27,93,202,64,227,56,145,74,32,237,99,7,38,60,126,46,65,58,213,67,9,209,255,251,99,183,132,102,172,38,227,101,152,184,194,152,129,165,192,196,127,126,254,41,19,184,186,20,193,100,84,170,39,209,97,76,175,12,39,231,70,102,67,231,205,56,217,226,163,105,170,99,89,203,57,102,173,137,28,54,226,191,8,149,83,13,245,148,39,23,14,74,69,235,38,171,1,113,35,21,216,231,147,109,171,113,181,44,56,16,196,117,15,226,224,98,52,70,141,98,108,57,249,23,106,242,198,224,105,215,164,197,88,209,244,6,120,98,155,154,121,254,203,118,228,246,96,213,245,206,144,99,236,121,135,246,230,89,190,202,32,7,156,92,37,115,34,1,72,44,32,29,245,187,61,182,63,28,123,155,243,167,223,33,165,101,166,222,49,158,32,252,64,173,87,80,164,65,215,60,12,63,215,157,60,214,56,187,48,137,111,87,233,246,245,41,131,204,180,117,193,30,169,2,251,227,202,62,16,1,52,41,120,182,38,31,36,8,116,197,221,42,253,81,182,158,253,196,214,36,226,78,172,68,169,119,192,67,246,143,25,199,93,150,102,236,79,20,45,37,28,190,160,90,165,162,28,183,169,54,161,219,124,90,30,14,149,110,59,137,254,248,118,9,68,143,105,209,185,193,150,102,29,215,157,176,65,135,155,182,215,144,232,243,74,175,215,97,140,140,200,22,133,61,39,197,159,196,10,249,194,212,146,196,165,84,69,94,71,169,213,105,10,231,202,212,45,30,102,48,235,141,66,127,6,151,254,62,210,9,63,190,105,52,19,244,100,135,159,189,38,3,226,75,150,120,16,132,196,44,94,239,136,168,37,147,193,142,165,245,24,226,250,122,70,155,139,188,171,88,240,120,183,2,161,143,153,59,106,210,139,221,135,225,120,175,149,111,204,230,180,0,229,190,245,108,219,245,70,32,111,223,146,96,71,250,90,161,30,255,65,167,16,194,208,192,212,172,236,165,166,62,130,250,120,49,167,243,245,28,151,63,167,239,75,16,107,114,14,106,34,31,166,133,104,169,35,168,214,173,105,64,164,253,24,117,91,91,212,156,117,73,57,93,160,0,209,241,204,21,159,59,250,84,85,215,119,233,60,82,65,64,62,56,30,182,160,5,54,156,155,140,19,35,76,73,23,151,249,21,183,195,50,231,209,76,126,100,146,225,14,135,94,176,125,130,157,236,150,3,109,154,106,170,72,48,219,158,221,16,167,184,125,56,84,50,216,38,7,29,84,68,212,46,117,102,118,106,189,37,111,173,152,149,69,52,7,61,33,0,51,157,140,240,228,107,190,85,153,216,36,62,210,172,132,48,186,45,52,176,32,60,164,0,254,191,23,13,215,203,190,235,190,225,150,146,165,36,112,40,71,168,189,50,203,194,78,29,107,61,214,42,9,154,229,215,58,85,85,254,31,113,207,73,38,206,165,139,22,221,97,143,133,96,110,166,124,48,215,80,236,87,40,216,171,66,93,97,204,107,113,183,100,10,230,250,82,239,2,104,96,191,53,124,69,167,124,29,132,79,1,231,149,48,66,218,85,229,117,109,77,89,166,244,137,246,162,88,176,152,102,215,216,95,169,219,132,187,67,58,165,88,69,215,182,121,246,80,88,64,113,157,171,51,184,149,17,42,172,145,201,38,7,93,243,169,9,165,137,194,184,103,104,172,192,70,191,195,205,247,70,11,5,52,148,192,14,218,166,200,100,193,111,241,140,23,77,30,74,154,13,172,179,94,255,147,203,71,191,89,40,57,162,212,248,142,220,224,209,44,249,28,217,206,218,31,88,88,46,225,86,198,167,73,18,88,72,45,42,29,219,173,14,161,251,193,222,67,200,47,123,115,221,91,90,91,23,216,70,65,217,97,45,239,142,182,3,51,243,231,139,88,43,75,135,154,62,95,93,164,111,174,183,131,205,45,221,163,152,58,84,120,252,2,122,249,143,223,244,247,74,239,59,46,252,13,113,110,102,249,244,25,146,111,223,54,86,222,9,47,35,222,13,200,31,162,96,179,212,78,198,27,207,141,104,85,194,63,36,152,83,7,134,106,190,110,241,246,217,86,142,59,102,181,177,189,72,125,253,114,47,119,246,86,204,63,188,227,241,156,237,15,151,234,150,85,165,140,77,6,118,51,213,39,33,207,221,70,159,158,173,67,231,221,45,188,94,203,65,227,37,212,166,114,173,44,170,178,156,228,43,245,196,51,145,127,175,151,79,144,213,1,47,195,204,88,243,239,111,245,22,18,88,177,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e0e96eab-9bae-48cd-88b6-f2b4a539d08e"));
		}

		#endregion

	}

	#endregion

}

