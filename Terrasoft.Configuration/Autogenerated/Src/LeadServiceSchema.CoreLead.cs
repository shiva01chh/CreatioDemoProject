﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadServiceSchema

	/// <exclude/>
	public class LeadServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadServiceSchema(LeadServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e0595561-29cb-475e-b0ba-b8ca0af81613");
			Name = "LeadService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("555d4b37-c88a-4293-9442-4a20aed79dca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,77,79,227,48,16,61,23,137,255,48,42,135,77,165,110,122,135,182,18,31,130,101,197,199,170,101,197,161,226,96,226,105,177,54,113,130,199,238,170,170,248,239,59,182,67,63,32,45,167,237,33,85,198,111,102,222,123,51,142,22,5,82,37,50,132,7,52,70,80,57,181,233,121,169,167,106,230,140,176,170,212,135,7,203,195,131,150,35,165,103,48,94,144,197,226,228,195,59,227,243,28,51,15,166,244,10,53,26,149,125,194,140,209,204,85,134,183,165,196,124,239,97,122,202,149,230,161,245,126,220,35,62,175,1,155,228,13,166,151,34,179,165,81,72,77,8,78,100,84,81,132,6,124,126,100,112,198,221,224,60,23,68,199,112,129,210,85,185,202,2,133,186,99,192,245,122,189,62,185,162,16,102,49,28,97,101,144,80,91,200,124,22,76,75,3,57,10,9,20,19,210,126,239,29,202,153,147,186,12,27,107,13,83,123,242,177,83,170,238,208,50,145,138,59,61,171,92,217,197,8,95,157,50,88,112,93,74,54,95,188,98,24,192,23,41,30,149,214,1,217,241,77,42,247,204,74,106,142,55,204,175,38,2,199,112,38,8,87,234,90,203,160,208,75,132,254,6,241,16,96,191,190,23,104,95,74,9,21,26,86,90,16,203,20,38,123,1,82,133,202,133,1,131,89,105,36,165,171,26,189,143,69,250,149,48,162,0,205,235,54,104,123,167,174,101,123,232,25,125,35,112,90,189,58,4,37,89,132,154,42,52,236,94,128,175,179,13,90,103,52,13,215,171,6,229,244,115,34,113,230,59,212,231,78,238,153,113,24,228,166,245,173,9,75,186,214,243,242,15,38,183,81,216,0,218,191,238,199,15,237,46,252,54,234,1,139,42,23,214,59,222,190,84,90,142,162,186,113,20,235,73,51,238,172,148,139,177,93,228,30,197,229,110,145,72,204,112,21,77,31,141,168,42,148,93,223,175,229,135,130,100,47,217,59,97,183,18,98,40,253,73,165,238,194,136,175,34,95,34,220,143,11,147,125,31,237,141,34,219,191,114,74,14,161,153,106,66,214,248,253,167,236,5,11,113,199,254,119,193,227,33,14,161,3,203,192,112,206,83,148,219,155,239,39,124,106,102,196,60,52,254,5,118,144,75,57,127,177,56,234,252,198,77,158,96,9,33,189,181,3,145,180,29,223,8,62,208,113,106,222,224,173,64,39,164,191,157,132,191,139,207,4,154,72,213,45,7,241,198,198,187,190,224,47,143,237,55,20,24,38,59,100,117,78,86,194,105,109,87,60,255,129,57,47,206,255,23,223,253,34,191,129,58,23,105,136,110,217,56,110,150,179,75,230,110,59,119,20,26,38,123,12,171,109,221,216,203,26,92,175,38,27,186,35,59,245,11,28,130,91,9,201,230,230,214,75,27,123,196,155,254,161,126,56,122,11,159,179,248,60,66,45,227,23,222,191,134,24,255,254,1,229,119,20,244,248,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e0595561-29cb-475e-b0ba-b8ca0af81613"));
		}

		#endregion

	}

	#endregion

}
