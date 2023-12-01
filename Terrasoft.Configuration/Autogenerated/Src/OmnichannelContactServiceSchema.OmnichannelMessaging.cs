﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelContactServiceSchema

	/// <exclude/>
	public class OmnichannelContactServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelContactServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelContactServiceSchema(OmnichannelContactServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8cdf4772-e624-4018-8c84-20acee624275");
			Name = "OmnichannelContactService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,85,221,79,226,64,16,127,174,137,255,195,4,95,48,33,229,93,80,163,24,13,23,81,3,222,249,64,46,151,165,29,96,99,187,219,219,221,122,225,204,253,239,55,187,221,150,2,165,242,208,208,249,248,205,215,111,166,130,165,168,51,22,33,188,162,82,76,203,165,9,71,82,44,249,42,87,204,112,41,194,231,84,240,104,205,132,192,36,156,160,214,108,197,197,234,244,228,243,244,36,200,53,253,133,217,70,27,76,7,123,239,225,52,23,134,167,24,206,80,113,150,240,191,14,237,192,138,180,31,60,194,137,140,49,105,85,134,55,145,225,31,95,131,132,111,184,216,26,212,139,82,184,99,72,85,26,197,34,211,100,76,24,228,144,166,245,88,77,218,18,112,42,115,67,54,100,76,230,103,10,87,148,37,140,18,166,245,5,60,160,121,100,218,140,214,204,76,169,213,82,104,116,102,243,59,102,88,153,196,79,18,100,249,34,225,17,68,214,173,201,11,46,224,150,105,220,130,4,159,14,168,10,248,162,100,134,202,112,164,168,47,14,172,208,247,251,125,24,234,60,77,153,218,92,149,2,139,14,52,87,3,60,70,154,212,146,163,10,43,235,126,221,220,101,58,193,116,129,170,251,68,124,129,75,232,36,62,185,113,220,57,183,201,151,217,63,228,60,134,199,74,9,159,176,66,51,0,109,31,255,90,210,121,91,163,89,163,2,122,64,178,77,77,67,36,211,44,65,131,241,145,228,124,220,133,148,9,140,117,25,121,84,122,53,37,112,134,34,46,90,230,222,11,233,158,112,111,136,181,37,176,35,163,137,249,201,59,227,253,138,236,187,215,195,82,42,40,8,36,183,24,192,5,21,230,112,194,210,191,94,213,220,123,215,233,49,191,209,217,19,186,202,104,11,22,60,225,102,51,197,223,57,87,152,210,0,117,183,254,98,25,78,99,250,194,197,90,133,94,16,187,49,206,239,112,201,242,196,212,120,141,7,220,60,218,12,207,208,170,53,173,4,85,210,96,68,19,42,76,50,101,151,27,225,57,67,97,7,120,175,100,234,193,127,208,1,177,236,132,95,242,184,114,80,128,120,204,86,152,54,157,189,106,65,64,140,241,255,2,133,38,87,162,53,52,245,185,85,125,125,13,2,255,180,133,237,126,215,168,72,38,40,121,234,211,185,43,198,242,50,8,154,41,91,117,116,66,91,35,227,157,125,63,186,98,83,87,138,174,175,215,87,155,239,36,25,83,44,5,65,139,127,217,241,164,165,173,191,26,87,206,32,151,21,155,135,125,103,94,121,239,186,211,128,62,40,168,58,244,47,53,7,0,195,98,2,250,170,233,96,13,251,165,214,221,41,106,113,241,209,170,239,77,48,167,123,61,22,31,242,29,187,69,187,236,253,122,121,158,189,118,122,96,201,143,218,220,75,149,18,240,37,144,105,241,141,195,66,20,126,211,82,244,224,86,198,155,153,217,36,184,99,82,73,195,55,197,178,12,99,143,214,115,227,43,239,116,59,246,238,241,108,56,250,53,217,56,238,186,243,90,13,161,87,156,219,109,87,207,61,109,61,107,91,40,23,142,214,24,189,123,161,189,239,55,34,166,80,62,76,45,66,13,124,112,156,144,77,55,148,100,244,251,15,167,221,122,236,97,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8cdf4772-e624-4018-8c84-20acee624275"));
		}

		#endregion

	}

	#endregion

}

