﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLangContentKitSchema

	/// <exclude/>
	public class MLangContentKitSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLangContentKitSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLangContentKitSchema(MLangContentKitSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("57a8cd79-1a9b-4fa1-91bb-04bde22362c4");
			Name = "MLangContentKit";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,77,111,163,48,16,61,83,169,255,97,74,47,68,138,194,61,13,185,116,171,42,106,35,85,219,253,3,94,24,136,181,96,34,127,180,155,173,250,223,119,0,155,26,146,208,112,0,60,204,188,121,126,111,176,96,21,170,61,75,17,126,161,148,76,213,185,94,220,215,34,231,133,145,76,243,90,92,95,125,92,95,5,70,113,81,192,235,65,105,172,238,250,181,95,34,113,241,32,52,215,28,213,185,4,138,211,151,91,137,5,225,194,125,201,148,90,194,246,153,137,130,58,106,20,250,137,235,54,37,142,99,88,41,83,85,76,30,214,118,253,19,247,18,21,37,41,248,195,53,228,181,132,202,148,154,151,84,110,88,129,144,118,24,11,87,31,123,0,123,243,187,228,41,164,77,203,113,71,88,194,198,239,31,124,180,28,122,158,47,178,222,163,108,246,181,132,151,22,167,251,62,38,217,6,182,167,40,129,210,141,60,125,145,207,204,81,115,20,94,155,84,24,44,26,253,131,160,64,125,215,190,40,251,242,57,65,227,217,49,224,26,201,198,90,126,211,220,229,111,108,58,28,5,166,73,220,162,200,58,185,134,218,209,62,148,150,38,37,132,75,212,219,8,154,31,86,242,127,168,64,224,59,112,170,102,130,102,179,206,41,25,73,80,137,121,18,142,12,12,227,245,153,237,181,145,61,147,172,2,65,115,158,132,169,167,107,184,158,50,107,21,183,117,167,97,202,145,58,225,250,88,112,31,192,202,60,226,29,13,61,247,185,205,79,88,50,110,58,179,158,12,64,146,1,76,231,213,17,82,114,132,117,137,151,91,212,187,58,115,46,194,132,141,143,72,63,41,235,5,197,230,88,56,0,207,1,255,114,165,213,28,106,189,67,249,206,21,130,68,109,164,80,144,97,206,200,141,81,205,165,182,118,217,155,44,92,63,216,94,89,19,202,57,202,105,35,37,166,181,204,188,194,46,48,89,111,41,159,153,30,75,124,21,187,52,207,255,55,46,181,97,37,216,94,36,147,245,46,122,52,60,3,183,139,57,180,75,199,205,249,76,39,30,178,116,7,209,27,243,134,129,184,138,163,191,117,65,208,46,166,162,30,200,33,5,13,130,37,108,185,36,131,35,167,169,143,190,232,124,53,155,117,19,21,144,151,209,16,224,38,1,97,202,178,111,17,116,251,31,182,177,213,159,237,163,187,219,180,113,247,31,221,60,244,36,102,19,19,218,69,135,65,138,249,215,127,131,46,76,198,230,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("57a8cd79-1a9b-4fa1-91bb-04bde22362c4"));
		}

		#endregion

	}

	#endregion

}

