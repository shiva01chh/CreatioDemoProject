﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialNetworksUtilitiesServiceSchema

	/// <exclude/>
	public class SocialNetworksUtilitiesServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialNetworksUtilitiesServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialNetworksUtilitiesServiceSchema(SocialNetworksUtilitiesServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cbc2e8e3-d231-422a-b62b-46cfd794c146");
			Name = "SocialNetworksUtilitiesService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("27ea8385-f6b4-49fa-a40f-acfd3edac760");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,86,221,79,219,72,16,127,78,165,254,15,123,219,23,71,53,46,162,45,69,32,164,75,33,244,114,42,9,197,137,250,128,238,97,99,79,18,11,199,235,219,93,3,17,202,255,126,179,95,142,221,0,161,186,60,36,241,236,124,254,230,55,179,46,216,18,100,201,18,32,99,16,130,73,62,83,209,25,47,102,217,188,18,76,101,188,136,98,158,100,44,31,130,186,231,226,86,78,84,150,103,42,3,25,131,184,203,18,120,251,230,241,237,155,78,37,179,98,78,226,149,84,176,140,220,201,37,79,33,63,121,233,48,250,9,211,151,21,122,137,202,238,76,26,27,189,102,158,203,229,115,39,2,158,146,219,90,158,58,193,84,94,240,167,79,255,82,170,140,122,83,169,4,75,116,70,114,163,168,143,44,48,43,114,234,11,241,54,238,0,181,81,255,157,128,57,218,146,179,156,73,121,76,118,97,139,22,55,238,1,155,98,34,255,163,101,61,89,162,17,230,91,34,56,83,227,255,26,254,173,50,1,75,40,148,12,154,15,26,73,204,106,135,137,214,138,156,32,237,234,32,101,53,205,179,132,36,58,211,29,137,146,99,242,149,73,168,211,238,60,154,212,235,106,47,65,45,120,138,245,94,25,159,246,240,102,84,130,165,88,179,180,206,13,226,54,40,238,248,45,4,214,236,148,94,141,226,49,13,201,68,100,99,88,150,57,83,186,30,250,13,212,168,87,169,197,24,85,11,137,231,95,121,186,138,213,42,215,167,232,228,18,164,100,115,168,165,209,79,193,202,18,210,80,71,233,232,82,65,170,11,46,150,76,181,12,172,40,250,91,242,34,36,215,56,28,216,106,120,89,207,224,229,1,67,130,104,78,180,211,11,156,84,54,113,28,226,236,117,201,163,201,199,124,125,248,64,134,163,49,153,196,253,243,144,92,140,174,201,197,100,60,185,238,147,97,191,127,30,27,141,108,70,156,171,104,32,135,85,158,143,68,127,89,170,85,176,237,216,123,238,168,133,224,247,164,128,123,210,19,243,74,119,187,97,216,127,72,160,212,77,8,232,150,11,218,61,49,30,214,230,219,85,192,146,4,235,55,85,33,28,46,23,227,234,100,91,45,134,68,128,218,169,108,35,15,210,151,116,42,9,194,104,76,240,15,50,166,0,51,133,209,89,37,4,150,164,165,122,113,41,228,209,32,141,198,60,54,102,129,43,193,193,59,30,157,143,72,178,128,228,150,100,146,176,252,158,173,36,145,11,94,229,41,153,2,73,172,47,19,171,25,27,247,0,23,174,237,214,159,238,44,114,163,202,21,97,155,191,167,110,78,244,34,169,20,83,92,167,132,140,5,5,218,0,93,103,137,97,124,208,46,34,220,230,133,101,105,135,87,170,137,120,72,54,130,6,182,86,236,81,180,79,205,156,29,8,154,60,205,108,113,41,212,79,209,5,203,114,156,124,79,154,103,137,214,242,219,117,218,157,59,38,12,106,190,213,154,109,19,255,28,216,222,133,68,137,202,231,130,180,20,43,31,172,211,217,194,45,86,76,168,223,6,109,147,67,29,102,77,208,58,89,144,160,181,194,106,218,215,21,232,225,51,244,248,3,63,222,214,254,174,9,228,18,234,100,157,162,59,179,63,216,137,74,20,79,176,119,189,27,249,184,50,253,172,161,119,164,19,158,83,127,82,43,247,241,41,53,21,82,122,76,40,165,228,125,107,36,223,163,58,165,97,173,106,89,162,117,91,202,205,193,220,50,113,60,218,4,168,231,211,170,186,202,105,179,194,6,122,230,249,57,64,214,175,93,254,79,108,251,60,53,27,181,205,138,137,200,233,255,221,211,207,57,14,124,79,92,53,232,180,190,250,34,52,212,42,250,138,215,53,192,131,242,187,40,114,151,75,72,232,119,152,179,100,101,17,237,37,9,175,10,67,234,43,204,43,98,178,124,240,176,55,94,20,162,43,38,36,252,168,64,172,220,14,163,131,244,244,227,244,224,96,182,63,155,237,237,127,252,196,246,62,29,165,108,239,232,203,231,163,61,182,127,120,184,15,159,217,193,225,108,70,187,221,223,195,120,231,5,219,154,153,239,124,158,21,175,198,218,22,246,202,59,217,1,102,251,67,182,26,180,157,198,179,247,105,72,126,185,83,106,65,99,74,124,91,221,73,174,61,234,138,237,155,27,221,108,203,45,247,122,116,233,55,206,231,57,222,142,126,96,189,253,175,239,153,145,85,116,63,216,4,137,183,175,48,196,193,53,213,95,226,198,13,154,89,53,231,73,47,212,194,198,125,242,90,17,128,93,106,225,178,123,61,186,0,141,197,235,51,119,145,116,106,87,130,207,240,38,8,60,126,221,72,155,186,212,220,46,125,92,55,167,194,56,49,10,196,49,239,29,20,169,125,245,51,207,86,218,22,26,153,254,252,7,164,76,167,72,129,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cbc2e8e3-d231-422a-b62b-46cfd794c146"));
		}

		#endregion

	}

	#endregion

}

