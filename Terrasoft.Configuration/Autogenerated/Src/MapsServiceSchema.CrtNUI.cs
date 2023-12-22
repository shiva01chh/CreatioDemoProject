﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MapsServiceSchema

	/// <exclude/>
	public class MapsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MapsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MapsServiceSchema(MapsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd988fd7-6ea7-4194-ae1b-cdcd0f06646d");
			Name = "MapsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e3c1e484-f7d7-414f-86c2-8efa1a10cabc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,81,111,218,48,16,126,78,165,254,7,139,167,68,66,214,158,215,181,82,75,105,69,85,160,106,210,245,1,245,193,36,7,245,150,216,174,237,176,49,196,127,223,57,78,32,133,140,69,136,36,223,221,125,119,247,221,57,130,21,96,20,75,129,36,160,53,51,114,97,233,64,138,5,95,150,154,89,46,5,29,51,101,98,208,43,158,194,249,217,230,252,44,40,13,23,75,18,175,141,133,226,226,224,157,62,114,241,113,4,214,225,99,153,65,126,210,72,175,83,203,87,85,222,211,126,175,48,223,59,180,43,47,138,118,232,161,133,62,152,127,153,53,208,219,155,46,19,166,218,243,162,93,149,243,156,167,36,205,153,49,196,137,51,194,234,16,119,210,52,198,251,146,103,132,103,23,45,200,88,237,120,77,250,14,5,155,160,234,29,198,165,50,147,110,120,232,224,109,149,127,86,11,129,83,178,154,165,246,205,97,215,70,77,192,98,153,10,197,155,243,156,219,245,51,124,148,92,67,1,194,154,176,253,226,20,36,151,228,63,33,206,139,214,64,22,189,117,53,94,23,66,190,146,27,102,96,183,35,181,18,218,13,18,176,7,164,79,73,242,12,166,204,45,185,211,178,112,67,248,86,3,87,97,236,155,204,152,101,17,169,66,3,13,182,212,130,132,181,79,228,2,232,45,24,208,156,229,252,15,132,206,185,79,236,90,129,92,236,188,162,74,58,47,210,97,250,58,73,34,29,85,56,157,255,128,212,118,165,172,50,197,159,242,116,210,214,124,247,96,31,101,234,124,217,60,7,15,54,13,9,156,241,1,187,128,95,228,216,255,5,251,194,97,10,44,201,157,55,236,70,150,58,69,171,212,108,9,125,151,36,193,78,195,136,186,181,233,87,132,129,143,165,119,82,23,204,134,189,35,86,67,55,95,182,244,59,203,75,232,245,125,45,17,77,100,157,242,83,79,179,169,2,127,214,219,43,21,204,112,241,71,98,37,127,66,56,6,251,46,51,220,153,222,211,52,78,144,239,69,243,4,10,149,59,41,16,29,48,220,234,129,148,58,227,2,33,131,30,55,50,91,199,118,157,59,59,18,141,193,24,108,102,135,210,87,205,148,130,172,238,38,8,220,166,129,177,190,159,79,49,30,170,78,110,159,160,56,74,10,3,167,253,170,117,109,246,117,37,241,44,30,86,216,12,137,227,217,53,15,241,116,210,76,106,197,180,7,145,123,183,171,205,41,159,189,93,133,251,8,148,243,145,27,91,139,25,44,240,19,130,89,72,216,80,16,46,60,85,195,29,88,189,110,30,131,23,149,57,245,74,127,187,36,161,7,34,183,35,254,241,96,49,250,21,25,221,127,64,162,70,59,92,88,92,129,251,167,120,130,194,15,100,94,22,130,62,49,141,46,22,116,85,48,117,95,150,232,56,96,120,42,96,216,10,120,125,7,13,97,111,148,245,34,58,50,195,143,146,229,97,119,32,207,234,131,136,151,111,142,14,127,67,90,98,63,13,190,245,183,148,89,148,107,211,198,170,255,109,16,248,143,29,254,218,215,95,183,188,51,112,171,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd988fd7-6ea7-4194-ae1b-cdcd0f06646d"));
		}

		#endregion

	}

	#endregion

}

