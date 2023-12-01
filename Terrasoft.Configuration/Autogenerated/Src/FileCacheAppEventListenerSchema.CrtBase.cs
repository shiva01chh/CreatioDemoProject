﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileCacheAppEventListenerSchema

	/// <exclude/>
	public class FileCacheAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileCacheAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileCacheAppEventListenerSchema(FileCacheAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9f2a8a1-4a5f-4591-ad3f-3c46fdcb2c1b");
			Name = "FileCacheAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,95,111,155,48,16,127,94,165,126,135,19,125,33,47,240,222,132,84,109,212,76,149,214,173,90,86,245,97,154,42,199,92,136,53,48,200,54,104,81,148,239,62,27,8,197,134,176,221,155,239,238,119,255,239,204,73,134,178,32,20,225,7,10,65,100,190,83,193,42,231,59,150,148,130,40,150,243,96,205,82,220,160,168,24,197,235,171,227,245,21,104,42,37,227,137,133,200,178,156,207,47,9,93,115,43,66,247,248,76,56,73,80,92,4,9,156,16,5,107,66,85,46,24,202,11,74,111,184,253,136,170,81,185,17,152,232,8,96,149,18,41,111,161,11,228,190,40,30,43,228,234,11,147,10,57,10,163,255,41,12,67,88,200,50,203,136,56,44,219,183,33,131,2,106,96,64,138,2,208,0,33,237,144,13,46,236,1,139,114,155,50,10,212,56,189,236,19,110,193,101,61,16,137,77,224,199,115,6,253,44,214,12,211,88,167,241,34,88,69,20,246,85,138,134,101,44,234,218,115,164,166,240,240,78,250,207,249,5,64,29,130,86,83,248,71,213,144,62,99,62,132,188,74,20,125,39,165,245,182,188,220,32,143,155,224,199,242,121,17,121,129,66,233,142,78,230,228,248,115,158,199,15,128,161,4,21,68,75,55,40,184,187,3,223,229,69,118,181,130,205,65,119,33,179,205,207,230,182,121,57,110,62,130,138,164,37,246,148,79,255,238,142,253,26,201,195,97,25,98,59,157,135,213,85,136,34,224,101,154,206,198,212,13,185,29,13,86,123,164,191,239,69,82,102,154,249,85,67,125,207,153,2,207,77,187,111,203,74,123,96,92,91,210,179,95,239,253,79,207,202,208,251,5,68,218,73,143,120,57,13,89,2,85,41,70,134,121,2,118,110,147,27,238,100,151,166,135,245,25,213,62,175,183,175,222,238,250,98,12,78,70,119,51,122,101,0,169,136,80,176,39,60,78,81,4,29,44,116,113,139,130,8,146,1,215,231,57,242,104,219,137,101,223,82,203,12,22,97,173,90,35,219,99,147,87,250,14,178,24,161,202,89,12,223,184,134,109,140,95,223,93,240,214,198,96,92,220,78,234,106,209,193,9,56,143,160,189,36,193,103,84,79,114,141,68,247,9,31,57,217,166,24,251,158,214,233,110,159,55,27,29,207,39,247,103,0,198,117,181,184,254,154,34,112,101,193,74,104,15,232,79,47,168,161,250,218,55,191,197,33,248,142,91,198,227,55,166,246,45,167,105,164,239,207,204,132,156,253,185,102,78,255,61,35,157,216,22,213,108,77,127,1,119,242,128,142,109,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9f2a8a1-4a5f-4591-ad3f-3c46fdcb2c1b"));
		}

		#endregion

	}

	#endregion

}
