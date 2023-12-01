﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WUserConnectionServiceSchema

	/// <exclude/>
	public class WUserConnectionServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WUserConnectionServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WUserConnectionServiceSchema(WUserConnectionServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a13b5816-b92d-446e-920f-32fd4b022df3");
			Name = "WUserConnectionService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6540e867-cf9b-4150-ac5c-c90377431b34");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,85,81,79,219,48,16,126,78,37,254,131,215,189,36,82,101,241,76,7,82,97,3,49,173,208,209,110,125,168,120,112,147,163,88,115,236,96,59,69,25,226,191,239,28,39,37,105,3,133,73,168,194,231,251,238,59,223,125,119,145,44,5,147,177,24,200,12,180,102,70,221,89,122,166,228,29,95,229,154,89,174,36,157,255,50,160,209,36,33,118,231,41,232,53,143,225,160,247,116,208,11,114,195,229,138,76,11,99,33,29,110,157,233,77,46,45,79,129,34,130,51,193,255,150,225,118,188,170,120,99,149,128,120,243,146,142,144,127,189,63,8,157,195,242,197,161,249,42,13,237,167,189,234,245,13,19,183,28,76,151,3,70,71,167,52,45,225,120,191,248,202,44,195,176,86,179,216,222,162,33,203,151,130,199,36,22,204,24,130,222,220,130,104,151,144,184,210,121,224,24,210,37,104,7,171,113,198,106,71,40,212,138,163,35,89,129,29,18,227,126,158,247,131,50,164,124,84,58,249,40,46,206,141,85,41,232,203,247,35,151,74,9,194,205,117,6,88,75,165,63,202,184,228,50,185,202,221,229,14,242,217,151,181,106,105,179,178,139,145,201,174,192,98,245,51,236,223,146,11,110,139,27,120,200,185,134,20,164,53,97,243,224,180,64,142,201,30,136,243,162,149,33,137,118,219,215,169,125,114,68,78,153,129,205,36,4,79,101,202,193,103,13,43,215,222,49,216,123,149,152,35,50,41,99,249,203,133,47,21,222,55,159,20,44,80,33,151,114,173,254,64,232,97,152,115,127,114,61,157,245,7,228,84,37,197,212,22,194,189,3,221,198,96,12,91,193,198,74,231,154,101,25,36,3,23,39,112,143,0,99,207,149,78,153,109,1,188,137,126,55,74,14,200,13,78,187,146,6,222,246,139,154,45,235,214,240,5,216,182,37,172,90,155,27,39,164,200,139,60,232,6,235,42,11,228,151,240,216,205,16,70,195,50,194,69,206,19,194,19,127,224,119,36,252,228,44,116,166,139,9,211,6,66,207,55,32,42,183,232,22,213,196,129,6,155,235,23,42,143,47,165,25,172,153,38,96,30,188,0,39,130,201,42,143,114,238,139,105,124,15,41,251,153,131,46,194,118,74,180,233,48,102,18,139,166,7,164,63,199,45,52,138,99,133,251,174,95,37,189,19,233,76,137,60,149,4,53,167,139,74,248,199,237,28,232,40,73,188,87,216,255,225,166,255,93,177,38,245,200,191,17,173,246,169,3,182,29,207,185,176,160,141,3,132,237,155,51,13,204,130,191,159,115,123,143,245,198,175,133,115,14,189,177,28,43,205,81,48,179,34,195,181,249,144,51,129,245,112,2,71,125,163,130,93,63,134,164,241,10,76,73,84,26,128,106,201,182,186,208,78,0,53,182,13,219,234,72,244,34,139,221,120,184,167,177,37,228,132,28,110,68,225,195,121,238,194,241,237,128,22,135,183,195,166,175,175,251,110,251,188,197,223,214,129,10,234,207,212,95,26,247,128,211,226,10,139,22,54,144,212,25,162,61,36,117,207,254,135,166,198,182,136,234,57,160,254,203,178,9,133,88,215,188,138,232,55,19,57,124,241,147,124,18,190,242,92,218,240,237,164,200,26,162,124,39,75,215,123,95,225,241,51,188,33,107,124,188,142,73,181,132,34,156,200,41,88,139,255,150,213,41,67,108,73,199,9,117,3,173,71,163,107,105,148,124,229,126,7,153,248,21,95,174,116,180,227,95,175,247,15,127,203,123,15,67,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a13b5816-b92d-446e-920f-32fd4b022df3"));
		}

		#endregion

	}

	#endregion

}

