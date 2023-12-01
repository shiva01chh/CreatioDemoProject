﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookServiceSchema

	/// <exclude/>
	public class FacebookServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookServiceSchema(FacebookServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9d216b36-55c4-4c1c-94d9-b65c63013894");
			Name = "FacebookService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d3eb0c57-b6db-447c-93a0-d1e838f1d54c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,87,219,78,227,48,16,125,46,18,255,96,193,75,144,80,62,160,133,74,80,186,44,210,22,80,139,180,15,171,125,112,220,161,245,54,177,179,182,3,116,17,255,206,228,186,185,212,105,197,6,150,62,52,201,120,60,115,230,28,199,158,8,26,128,14,41,3,114,7,74,81,45,239,141,59,146,226,158,47,34,69,13,151,194,157,73,198,169,191,191,247,188,191,215,139,52,23,11,50,91,107,3,193,160,246,140,211,124,31,88,60,71,187,151,32,64,113,214,240,153,70,194,240,0,220,25,142,82,159,255,73,82,52,188,112,244,129,51,152,200,57,248,173,131,238,25,230,123,216,30,196,253,14,94,195,1,109,232,164,53,78,158,25,106,0,29,208,229,80,193,2,45,100,228,83,173,251,228,11,82,227,73,185,202,162,37,46,63,206,116,120,13,102,36,131,16,83,123,220,231,102,61,133,223,17,87,16,128,48,218,41,63,196,249,201,41,217,50,37,246,114,51,195,252,232,39,38,9,35,207,231,140,176,24,70,29,5,233,147,84,21,12,249,40,85,110,62,41,187,129,66,25,5,234,33,213,240,152,92,213,34,160,101,10,116,126,35,252,117,153,2,204,251,156,148,88,208,48,1,179,148,115,36,226,54,193,147,14,102,216,206,169,6,172,40,160,98,62,5,29,249,134,76,225,65,174,96,20,41,133,69,157,49,134,161,239,208,32,156,77,112,227,114,65,27,162,210,235,17,137,87,88,175,103,212,58,187,235,41,48,145,18,164,86,142,107,205,146,71,26,36,211,95,8,163,134,45,137,51,126,98,16,198,107,132,192,209,150,208,95,177,22,31,138,9,39,141,18,135,14,228,225,227,255,151,45,132,140,159,128,69,38,55,118,75,67,45,246,167,45,254,60,6,242,158,12,84,18,252,111,26,102,64,21,91,86,25,72,109,111,172,253,27,215,166,120,179,199,184,125,154,245,144,64,124,229,160,113,103,177,144,146,229,172,210,145,151,44,224,177,10,52,203,213,27,255,141,155,167,72,71,94,186,227,179,156,184,149,202,74,209,136,4,167,132,120,184,0,185,4,115,141,27,166,190,160,134,126,16,171,149,148,118,82,173,144,63,146,96,27,136,86,178,47,192,139,22,165,205,180,64,158,12,116,182,165,151,34,92,137,123,73,88,35,112,98,110,10,96,131,97,215,194,86,145,83,240,217,64,115,106,193,211,185,68,54,108,255,32,81,247,218,208,221,68,121,71,53,232,103,148,161,210,30,23,228,102,82,140,150,192,86,35,42,110,66,64,7,120,163,18,117,220,245,168,118,154,219,192,57,29,30,138,109,121,54,179,119,8,98,158,54,149,201,115,106,173,25,107,205,183,77,158,180,11,143,183,98,132,97,20,101,166,209,49,91,223,149,126,43,69,205,6,248,86,73,36,61,222,70,171,61,112,146,126,2,129,7,202,185,198,143,40,92,173,7,181,229,122,144,52,242,57,174,250,234,174,63,167,252,47,192,164,212,233,236,230,237,236,149,207,217,29,24,171,244,3,239,201,82,126,238,85,233,217,120,32,23,167,101,59,57,155,178,40,249,152,150,80,77,115,193,147,47,84,170,214,39,218,40,252,26,60,38,210,251,133,107,124,72,166,249,140,238,165,176,157,200,59,200,98,237,40,62,153,68,131,157,201,65,27,254,94,1,109,39,175,1,121,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d216b36-55c4-4c1c-94d9-b65c63013894"));
		}

		#endregion

	}

	#endregion

}

