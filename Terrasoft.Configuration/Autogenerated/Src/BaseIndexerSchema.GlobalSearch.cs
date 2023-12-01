﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseIndexerSchema

	/// <exclude/>
	public class BaseIndexerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseIndexerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseIndexerSchema(BaseIndexerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a51b504-debb-4bfb-bddf-e53665339b06");
			Name = "BaseIndexer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,77,111,219,48,12,61,39,64,254,3,231,93,28,32,144,129,29,155,56,135,126,172,232,97,88,177,102,187,14,138,205,164,2,108,201,147,228,96,65,208,255,62,89,178,107,57,83,220,94,154,139,35,146,143,239,137,164,200,105,137,170,162,25,194,6,165,164,74,236,52,185,17,124,199,246,181,164,154,9,78,238,11,177,165,197,19,82,153,61,207,166,167,217,116,82,43,198,247,131,120,137,203,11,118,114,199,53,211,12,85,40,192,79,77,30,120,142,127,141,191,15,244,221,157,247,123,133,78,215,230,88,33,164,111,37,35,65,156,161,48,36,159,37,238,141,1,110,10,170,212,21,92,83,133,54,26,165,117,39,73,2,43,85,151,37,149,199,117,123,222,96,89,21,84,35,148,168,159,69,14,59,33,129,181,12,128,237,77,73,7,78,60,116,85,111,11,150,65,214,112,13,169,38,39,75,215,203,17,92,105,89,103,90,72,163,234,209,226,92,68,155,195,67,199,221,245,126,224,159,26,149,190,165,154,94,215,172,200,177,215,245,191,107,209,36,155,116,80,219,160,227,19,114,31,228,27,231,112,26,0,2,92,233,8,219,242,50,91,26,228,179,128,151,182,40,198,226,234,50,44,210,163,20,166,161,77,181,175,154,255,26,51,141,121,91,165,238,8,35,130,71,92,39,216,163,94,194,75,56,215,64,127,208,216,227,199,46,240,205,14,208,152,250,173,16,5,220,163,126,80,254,100,127,69,170,107,137,119,156,110,11,204,227,159,10,165,25,24,110,32,77,214,122,112,236,26,39,209,64,206,157,196,166,62,75,23,249,84,191,127,125,137,230,126,51,122,109,7,38,117,77,11,56,8,150,67,115,239,97,37,98,247,113,47,226,184,120,199,67,102,33,107,167,255,64,251,193,108,58,5,169,53,143,12,36,177,95,207,30,59,41,100,88,175,69,152,119,209,10,159,95,30,93,18,184,180,47,113,254,158,33,238,103,192,123,228,231,107,199,26,26,54,213,170,2,45,156,108,183,158,95,49,201,57,104,85,81,73,75,224,102,195,167,145,195,70,107,167,149,172,18,235,12,199,6,139,18,173,95,143,160,155,150,173,20,34,100,18,119,105,20,236,105,148,172,125,150,118,121,217,137,177,241,31,50,42,108,7,241,167,183,30,77,112,22,230,93,138,246,185,184,222,219,45,48,9,52,187,211,27,86,51,210,125,103,29,26,103,83,99,53,191,127,225,196,151,126,141,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a51b504-debb-4bfb-bddf-e53665339b06"));
		}

		#endregion

	}

	#endregion

}
