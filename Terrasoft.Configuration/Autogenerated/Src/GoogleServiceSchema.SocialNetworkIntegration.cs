﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleServiceSchema

	/// <exclude/>
	public class GoogleServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleServiceSchema(GoogleServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92e7bd72-1d76-432f-a993-0073d6e7f751");
			Name = "GoogleService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,193,110,219,48,12,61,187,64,255,129,232,46,9,48,216,247,212,11,16,100,67,215,67,186,194,25,176,67,177,131,44,51,142,48,91,242,36,185,157,87,228,223,71,75,78,236,184,206,182,0,73,76,242,241,241,137,164,44,89,137,166,98,28,225,43,106,205,140,218,217,112,173,228,78,228,181,102,86,40,25,110,21,23,172,184,190,122,189,190,10,106,35,100,14,219,198,88,44,111,71,118,152,212,210,138,18,195,45,106,74,16,191,93,250,27,20,69,159,5,199,141,202,176,8,87,220,138,231,105,220,55,76,9,107,12,197,182,150,89,236,1,189,208,59,165,242,2,91,70,212,36,90,34,183,74,19,144,160,239,52,230,148,10,235,130,25,179,128,30,73,181,29,224,105,101,170,7,180,107,85,86,36,32,21,133,176,77,130,63,107,161,177,68,105,205,108,104,180,106,225,3,252,35,165,69,133,157,35,155,127,167,34,85,157,22,130,3,111,69,156,107,128,5,248,198,18,225,139,210,63,58,119,220,129,246,140,40,86,85,69,217,174,61,167,211,45,223,195,253,25,17,217,9,178,236,139,44,154,97,187,168,248,171,59,231,169,19,27,180,123,149,81,47,30,157,40,31,140,162,8,98,83,151,37,211,205,242,232,72,208,214,90,26,224,74,82,8,53,8,185,83,186,116,66,128,165,170,182,144,59,9,96,156,78,96,189,208,240,196,26,141,105,99,237,121,151,235,9,222,48,142,142,225,22,223,53,206,159,244,136,191,39,120,66,219,74,38,194,93,59,136,222,63,155,67,187,160,65,96,117,211,61,5,158,16,36,190,252,141,168,3,7,195,32,205,122,180,85,225,155,122,62,237,112,235,254,15,64,199,231,123,152,125,250,197,177,114,141,194,249,72,199,152,241,51,147,89,129,167,132,248,178,198,229,12,231,93,157,246,247,208,13,22,101,230,103,235,108,239,29,57,39,175,193,84,9,127,39,62,50,203,40,106,53,227,246,194,254,78,246,112,1,103,239,140,110,53,123,238,241,46,62,106,85,161,182,2,7,235,24,4,237,215,73,216,96,153,162,158,61,208,187,137,38,113,195,7,37,111,220,189,186,188,31,112,102,248,1,228,104,125,247,76,247,240,255,13,36,95,251,249,3,12,81,194,23,38,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92e7bd72-1d76-432f-a993-0073d6e7f751"));
		}

		#endregion

	}

	#endregion

}

