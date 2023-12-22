﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillAnaliticsHandlerSchema

	/// <exclude/>
	public class MandrillAnaliticsHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillAnaliticsHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillAnaliticsHandlerSchema(MandrillAnaliticsHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9bc64d93-c9a0-4a3e-8013-bf6fe6a873fc");
			Name = "MandrillAnaliticsHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d25f34fe-c5f7-43c4-95a5-0f83015bba7e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,139,219,48,16,61,59,144,255,32,220,75,2,193,110,233,109,147,93,232,166,101,187,133,148,64,54,189,22,173,61,78,212,202,146,209,71,232,18,246,191,119,244,17,175,21,54,109,169,79,150,70,239,205,211,188,25,9,218,130,238,104,5,228,1,148,162,90,54,166,88,74,209,176,157,85,212,48,41,198,163,227,120,148,89,205,196,46,57,162,96,62,30,97,228,141,130,29,30,35,75,78,181,190,34,43,42,106,197,56,255,32,40,103,134,85,250,51,110,112,80,254,108,89,150,100,161,109,219,82,245,116,19,215,49,78,26,169,136,217,3,105,35,1,161,39,134,226,132,44,7,208,206,62,114,86,145,202,101,189,152,148,92,145,91,170,97,69,25,71,249,189,146,236,232,213,188,72,151,66,27,42,12,202,95,43,118,160,6,66,188,11,11,82,185,56,97,194,144,143,208,80,203,205,189,48,160,14,148,147,107,242,254,237,60,146,1,106,240,124,41,249,90,201,14,148,97,224,217,165,129,202,64,157,242,107,163,92,117,191,119,74,86,160,245,87,180,4,153,243,109,87,99,244,83,139,234,251,139,173,195,145,124,30,240,145,142,200,3,58,195,234,158,106,61,96,114,246,101,217,14,12,57,42,48,86,137,36,209,252,217,133,159,95,23,244,67,62,166,98,110,45,255,153,10,250,155,146,47,145,226,21,21,145,61,81,112,169,138,43,48,123,89,95,50,200,89,115,7,189,45,147,173,6,133,166,10,148,228,192,54,89,78,163,22,7,98,47,70,78,240,127,154,54,120,58,8,197,230,73,111,192,24,188,149,46,48,219,55,202,45,76,60,85,150,102,152,145,124,69,127,157,154,114,99,16,174,177,86,161,132,107,80,76,214,43,38,172,1,157,79,231,65,75,227,243,7,45,11,242,238,164,49,27,8,60,235,189,0,244,181,203,98,69,217,48,244,207,5,245,131,20,130,231,243,233,55,150,10,80,182,70,118,55,36,248,80,200,198,15,234,62,140,83,209,3,203,115,228,162,163,138,182,68,160,201,215,121,90,162,252,230,126,64,231,98,110,202,98,176,88,148,30,233,137,226,160,247,125,117,144,172,142,154,78,20,255,229,247,176,95,206,0,161,180,241,213,216,84,123,168,45,94,116,107,152,107,121,208,69,200,142,157,61,57,247,61,118,187,255,185,83,210,118,97,53,24,199,89,175,97,22,28,22,150,243,25,105,40,215,24,51,202,194,244,15,246,133,221,116,211,239,13,191,223,236,127,179,217,211,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9bc64d93-c9a0-4a3e-8013-bf6fe6a873fc"));
		}

		#endregion

	}

	#endregion

}

