﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AudienceMacroDataSourceSchema

	/// <exclude/>
	public class AudienceMacroDataSourceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AudienceMacroDataSourceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AudienceMacroDataSourceSchema(AudienceMacroDataSourceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("be891925-d6a7-cb43-0fa0-d901c94a7c9d");
			Name = "AudienceMacroDataSource";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,77,79,219,64,16,61,27,137,255,176,74,47,142,20,89,244,74,196,1,76,64,145,10,162,9,180,135,170,170,22,123,72,86,216,187,102,63,2,105,197,127,239,120,215,223,31,208,86,205,37,242,120,252,222,155,55,179,179,156,166,160,50,26,1,185,5,41,169,18,15,58,8,5,127,96,27,35,169,102,130,31,30,252,58,60,240,140,98,124,67,214,123,165,33,157,87,207,205,79,36,140,197,131,5,215,76,51,80,152,128,41,31,36,108,16,151,132,9,85,234,152,156,154,152,1,143,224,138,70,82,156,83,77,215,194,200,8,108,106,102,238,19,22,145,40,207,28,79,244,126,217,228,26,88,112,165,41,215,8,126,35,217,142,106,7,230,101,238,129,68,249,123,194,184,38,159,13,200,253,25,213,209,118,205,126,2,57,33,31,143,142,142,230,5,26,240,216,1,182,209,47,24,36,241,24,180,4,26,11,158,236,201,157,2,137,58,56,68,185,135,228,135,105,61,191,67,97,11,144,38,210,66,230,68,214,132,130,199,25,50,98,133,223,97,109,147,78,73,222,72,207,235,104,193,170,123,226,60,239,245,109,133,87,160,183,98,212,5,116,95,163,202,157,96,49,57,141,227,11,150,104,144,202,183,99,176,95,71,91,72,169,117,158,128,122,154,145,75,131,105,247,38,121,92,164,148,37,203,184,136,72,200,176,84,186,140,75,221,152,28,20,80,1,162,250,249,115,136,134,107,112,209,175,76,111,111,168,196,121,182,108,46,24,138,52,163,146,41,193,111,247,25,78,226,147,161,201,140,76,206,74,186,201,172,73,61,157,206,255,51,149,133,243,38,223,42,194,21,68,44,195,230,233,149,171,239,184,10,44,227,227,43,138,118,179,4,149,124,15,206,195,34,3,37,214,94,188,43,240,90,232,197,11,83,90,185,215,254,16,181,29,155,154,248,174,195,188,140,39,77,158,149,120,14,133,193,211,114,210,57,47,205,65,41,91,95,246,60,20,137,73,249,72,207,203,142,86,121,185,159,194,232,115,166,178,132,238,191,208,196,128,111,103,195,241,11,237,0,176,113,56,166,154,70,122,210,208,87,161,248,147,79,140,63,66,236,56,243,42,6,147,234,82,71,18,254,161,89,21,214,155,118,12,149,57,114,40,154,97,162,138,234,113,41,228,219,53,178,96,165,137,61,128,197,75,38,65,169,252,152,186,204,70,224,196,205,99,239,155,98,120,92,196,137,237,96,249,14,107,86,136,41,156,235,18,4,56,75,56,39,249,1,14,174,225,57,255,247,7,77,230,240,76,122,42,138,119,237,250,60,235,83,179,134,94,89,54,239,117,176,1,125,123,47,65,247,130,126,73,182,163,178,40,176,180,170,179,45,131,230,183,56,1,116,3,50,64,200,165,189,114,34,56,219,95,227,86,240,235,5,115,75,229,6,112,94,131,48,17,28,144,136,170,150,168,121,197,139,6,97,109,131,198,248,133,233,165,37,184,231,79,227,148,241,21,219,108,181,194,175,30,104,162,192,217,224,0,37,104,35,121,142,249,119,235,188,127,215,236,152,212,184,201,10,81,216,162,164,184,55,176,234,242,30,242,255,116,135,15,78,123,62,48,131,77,153,183,183,132,202,119,66,29,44,175,21,123,94,90,220,53,109,215,140,160,34,170,11,241,59,45,158,190,225,152,139,182,131,54,134,191,223,228,91,97,63,74,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be891925-d6a7-cb43-0fa0-d901c94a7c9d"));
		}

		#endregion

	}

	#endregion

}
