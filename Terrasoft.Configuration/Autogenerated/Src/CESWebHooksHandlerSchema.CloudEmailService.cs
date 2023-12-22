﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESWebHooksHandlerSchema

	/// <exclude/>
	public class CESWebHooksHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESWebHooksHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESWebHooksHandlerSchema(CESWebHooksHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9976940-f70d-4dd0-995b-4a09639dc922");
			Name = "CESWebHooksHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("06435d27-8c1b-4953-b634-242d1f4c8b8a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,139,219,48,16,61,59,144,255,32,220,75,2,193,166,215,77,118,15,77,203,238,22,82,2,233,182,199,162,216,227,88,173,34,153,145,148,37,132,253,239,213,151,189,182,201,182,165,62,24,75,163,121,243,244,222,140,5,61,130,106,104,1,228,43,32,82,37,43,157,173,165,168,216,193,32,213,76,138,233,228,50,157,36,70,49,113,24,28,65,88,78,39,54,242,14,225,96,143,145,53,167,74,221,144,245,167,221,119,216,63,72,249,75,61,80,81,114,64,127,42,207,115,178,82,230,120,164,120,190,139,235,24,39,149,68,162,107,32,72,159,201,51,236,107,151,155,181,57,121,47,169,49,123,206,10,82,184,74,87,10,145,27,242,129,42,216,80,198,45,217,174,122,114,241,12,94,137,74,161,52,21,218,146,221,34,59,81,13,33,222,132,5,41,92,156,48,161,201,71,168,168,225,250,81,104,192,19,229,228,150,188,95,70,44,16,101,128,27,98,111,81,54,128,154,129,7,151,26,10,13,229,16,94,105,116,82,254,104,80,22,160,212,23,171,191,5,78,3,221,120,163,109,136,165,203,144,24,113,136,60,89,253,89,217,97,108,123,16,206,164,36,57,128,38,23,4,109,80,12,42,44,95,92,248,229,58,147,159,114,223,178,232,137,186,59,139,226,111,4,62,199,204,43,197,35,232,160,240,91,170,109,64,215,178,124,203,15,231,196,61,116,46,204,158,20,160,245,80,88,74,46,217,12,150,243,200,197,37,177,87,223,102,246,123,62,236,222,97,151,103,187,179,218,129,214,246,86,42,179,213,190,81,110,96,54,196,94,120,228,36,221,88,171,144,113,222,87,42,90,209,146,76,231,203,64,163,242,165,3,141,213,184,161,90,178,73,143,233,232,72,128,241,34,38,81,90,214,15,253,179,178,126,116,66,112,60,139,126,99,141,96,197,86,22,221,13,135,253,29,200,202,15,101,29,198,40,235,18,243,113,230,170,161,72,143,68,88,183,111,211,161,98,233,221,99,15,206,197,220,116,197,96,182,202,125,166,7,138,163,221,53,216,73,178,50,114,106,33,254,203,248,126,227,140,18,130,180,241,111,177,43,106,40,141,189,232,147,182,107,55,192,89,168,110,91,124,220,6,109,219,251,143,123,148,166,9,171,222,56,46,58,14,177,105,132,225,124,65,52,26,8,239,249,31,220,11,187,195,77,191,215,127,126,3,165,119,5,254,184,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9976940-f70d-4dd0-995b-4a09639dc922"));
		}

		#endregion

	}

	#endregion

}

