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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,95,111,155,48,16,127,94,165,126,135,19,125,33,47,240,222,132,84,109,212,76,149,214,173,90,86,245,97,154,42,7,46,196,26,24,100,27,180,40,202,119,159,13,132,218,134,176,221,155,239,238,119,255,239,204,72,142,162,36,49,194,15,228,156,136,98,39,131,85,193,118,52,173,56,145,180,96,193,154,102,184,65,94,211,24,175,175,142,215,87,160,168,18,148,165,22,34,207,11,54,191,36,116,205,173,72,188,199,103,194,72,138,252,34,136,227,132,40,88,147,88,22,156,162,184,160,244,134,219,143,168,90,149,27,142,169,138,0,86,25,17,226,22,250,64,238,203,242,177,70,38,191,80,33,145,33,215,250,159,194,48,132,133,168,242,156,240,195,178,123,107,210,40,136,53,12,72,89,2,106,32,100,61,178,197,133,6,176,172,182,25,141,33,214,78,47,251,132,91,112,89,15,68,96,27,248,241,156,129,153,197,154,98,150,168,52,94,56,173,137,68,83,165,108,89,218,162,170,61,195,88,23,30,222,137,249,156,95,0,52,33,40,53,137,127,100,3,49,25,243,33,228,85,32,55,157,84,214,219,242,114,131,44,105,131,31,203,231,133,23,37,114,169,58,58,153,147,227,207,121,30,63,0,154,82,148,16,45,221,160,224,238,14,124,151,23,217,213,10,54,7,213,133,220,54,63,155,219,230,197,184,249,8,106,146,85,104,40,159,254,221,29,251,53,146,135,195,210,68,119,42,15,171,171,16,69,192,170,44,155,141,169,107,114,59,26,172,246,24,255,190,231,105,149,43,230,87,5,245,61,103,10,60,55,109,211,150,149,246,192,184,178,164,102,191,217,251,159,158,149,161,247,11,136,176,147,30,241,114,26,178,56,202,138,143,12,243,4,236,220,38,55,220,201,46,77,15,235,51,202,125,209,108,95,179,221,205,197,24,156,140,254,102,24,101,0,33,9,151,176,39,44,201,144,7,61,44,116,113,139,146,112,146,3,83,231,57,242,226,174,19,75,211,82,199,12,22,97,163,218,32,187,99,83,212,234,14,210,4,161,46,104,2,223,152,130,109,180,95,223,93,240,206,198,96,92,220,78,170,106,197,131,19,112,30,65,123,73,130,207,40,159,196,26,137,234,19,62,50,178,205,48,241,61,165,211,223,62,111,54,58,158,79,238,207,0,148,169,106,49,245,53,69,224,202,130,21,87,30,208,159,94,80,77,205,181,111,127,139,67,240,29,183,148,37,111,84,238,59,78,219,72,223,159,233,9,57,251,115,205,156,254,123,70,122,177,45,106,216,38,253,5,38,160,140,80,118,7,0,0 };
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

