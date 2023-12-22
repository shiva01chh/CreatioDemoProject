﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecurityTokenJobManagerSchema

	/// <exclude/>
	public class SecurityTokenJobManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecurityTokenJobManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecurityTokenJobManagerSchema(SecurityTokenJobManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb5e1e38-8367-4093-8898-11550402f541");
			Name = "SecurityTokenJobManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,85,77,111,219,48,12,61,167,64,255,131,150,93,82,32,112,54,160,167,181,9,144,165,89,183,97,253,216,210,162,135,97,7,197,102,82,173,182,36,80,82,26,163,232,127,31,37,219,137,109,36,93,47,237,33,168,104,62,242,241,137,164,36,207,192,104,30,3,187,1,68,110,212,194,70,19,37,23,98,233,144,91,161,228,225,193,211,225,65,199,25,33,151,108,162,178,76,201,147,218,25,161,121,138,102,241,61,36,46,5,220,218,239,96,30,109,144,100,125,143,176,164,192,108,146,114,99,216,39,54,131,216,161,176,249,141,122,0,249,93,205,47,184,228,75,192,224,59,24,12,216,169,113,89,198,49,31,149,231,49,139,3,114,161,112,131,101,214,131,217,95,53,103,89,128,103,32,109,84,5,24,212,34,104,55,79,69,92,134,216,147,154,72,141,181,158,174,40,198,15,97,44,72,192,207,220,0,161,159,2,171,109,9,74,26,203,165,245,101,92,163,88,113,11,133,67,155,119,48,156,113,145,230,12,214,148,212,43,203,52,160,80,73,180,241,175,211,236,232,34,28,139,125,10,38,164,109,146,157,164,192,137,214,180,10,118,29,98,177,33,251,120,124,252,225,100,47,5,170,145,45,81,57,205,36,93,252,171,82,27,139,254,22,9,121,238,129,151,132,163,52,221,6,155,240,165,123,82,138,3,50,41,244,105,138,117,141,138,42,182,2,10,181,148,133,216,66,82,248,232,234,200,110,13,32,201,42,233,228,65,173,163,239,197,78,103,9,54,148,184,97,106,74,195,243,203,12,46,192,222,171,100,71,250,157,90,157,3,221,171,163,252,94,136,138,192,2,85,198,184,214,212,67,97,60,24,248,46,241,30,22,214,118,143,160,193,162,57,242,44,200,62,236,150,238,221,209,120,111,164,211,65,0,108,241,8,214,161,52,163,219,38,35,114,172,190,188,40,36,85,211,180,244,170,22,159,20,25,171,204,71,165,200,43,142,190,208,90,136,225,134,92,141,246,239,238,184,238,212,253,195,184,97,13,83,113,85,98,193,122,173,112,67,38,93,154,86,249,58,246,30,213,35,147,240,200,198,184,116,126,128,47,233,243,21,78,51,109,243,233,58,6,29,104,183,242,29,21,225,159,195,111,161,68,147,118,52,203,105,132,179,102,241,245,110,217,121,249,179,112,249,186,57,116,126,191,152,189,67,83,9,191,18,104,29,79,217,74,137,196,199,113,186,189,102,76,175,42,218,171,210,100,22,209,69,125,51,95,128,83,37,48,149,124,158,66,210,43,166,13,166,198,138,140,23,101,111,100,43,231,51,44,180,114,56,109,174,65,45,122,187,22,198,81,52,54,6,178,121,154,255,36,142,98,33,32,241,160,66,196,64,231,29,233,187,217,226,209,153,2,67,140,167,107,218,131,189,77,142,126,99,29,108,185,116,26,216,234,191,11,33,157,133,52,39,204,233,46,78,163,94,61,90,191,213,185,209,157,194,135,240,68,69,225,115,153,169,211,242,154,56,68,106,25,111,45,252,94,179,47,251,161,3,251,204,162,131,178,145,202,78,122,102,144,26,120,11,141,27,18,253,130,76,173,128,202,223,171,109,173,189,95,191,221,194,27,247,66,119,127,229,50,73,105,15,215,23,25,61,100,248,86,11,172,124,116,169,84,68,145,64,49,26,87,210,75,225,179,254,111,21,205,233,241,141,106,238,213,231,66,155,214,162,27,238,88,117,77,192,190,153,124,225,9,41,172,77,35,217,234,127,255,0,153,115,50,27,74,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb5e1e38-8367-4093-8898-11550402f541"));
		}

		#endregion

	}

	#endregion

}

