﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseBrakeMailingStateSchema

	/// <exclude/>
	public class BaseBrakeMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseBrakeMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseBrakeMailingStateSchema(BaseBrakeMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5db3ffbb-42cb-49e9-93bf-aaabc11728ef");
			Name = "BaseBrakeMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,91,79,34,49,20,126,30,19,255,67,195,190,116,18,210,240,178,47,18,55,1,68,67,162,198,21,88,159,235,244,48,52,14,237,108,219,193,91,252,239,123,218,185,192,112,113,141,36,130,237,233,249,190,115,190,115,81,124,5,54,231,9,144,25,24,195,173,94,56,54,210,106,33,211,194,112,39,181,58,61,121,63,61,137,10,43,85,74,166,175,214,193,170,223,156,183,93,12,176,139,33,154,208,248,195,64,138,158,100,148,113,107,207,200,144,91,24,26,254,4,55,92,102,232,54,117,220,65,120,152,23,143,153,76,8,127,180,206,240,196,145,196,59,28,126,79,206,72,219,61,122,15,16,27,50,173,172,227,202,33,225,157,145,235,154,34,202,203,3,73,188,157,72,229,16,223,37,203,169,124,3,114,78,126,246,122,253,10,7,148,40,161,218,184,119,70,231,96,156,132,0,172,29,36,14,68,13,93,29,55,25,92,21,82,144,75,169,120,118,15,137,204,37,40,119,143,250,34,55,144,119,146,130,235,147,143,163,206,248,19,84,246,9,214,94,35,93,40,55,210,89,177,82,183,88,170,47,131,140,215,72,141,241,166,6,172,29,241,220,151,242,58,121,155,6,235,72,139,111,34,221,224,31,79,225,51,164,99,66,222,128,91,106,113,72,197,178,64,107,141,210,61,24,233,224,90,167,52,8,249,88,100,79,227,21,150,125,34,186,161,116,166,22,53,200,18,19,223,154,81,36,23,132,182,45,228,23,233,213,214,104,88,163,132,76,16,60,5,195,240,103,162,22,154,182,40,46,48,142,153,92,1,155,187,228,86,63,119,75,255,232,10,92,147,240,31,158,21,64,255,171,110,252,69,223,67,122,198,93,223,204,14,94,28,155,91,48,248,191,66,185,144,129,141,10,99,208,217,223,250,33,117,88,37,12,187,98,218,209,166,31,174,63,252,247,94,137,131,212,83,112,131,66,160,67,210,52,27,109,164,218,72,95,203,184,230,134,20,185,64,133,68,41,241,57,233,149,28,66,215,74,255,46,192,188,86,175,208,174,224,153,204,195,129,30,78,168,75,58,13,227,140,27,236,162,78,92,101,195,48,60,186,177,214,17,78,68,199,171,227,199,129,221,113,131,19,225,192,208,195,3,23,199,236,97,9,6,104,7,189,98,54,81,180,194,142,124,96,83,200,48,136,35,129,197,108,166,115,218,44,138,152,149,148,180,99,145,190,132,187,52,122,69,143,134,143,9,12,172,127,222,196,16,60,135,155,110,243,17,217,241,223,130,103,116,47,159,70,124,54,17,241,54,164,18,135,53,217,122,115,20,180,90,159,97,79,90,182,135,114,15,92,188,206,244,20,167,215,147,86,253,19,237,148,188,60,178,241,11,36,5,150,181,126,85,22,190,9,123,254,173,14,104,215,254,179,45,88,183,124,201,91,222,143,95,114,63,80,126,76,6,66,80,207,124,208,250,41,112,51,182,81,180,167,223,182,18,241,110,111,125,173,146,149,90,59,58,237,169,217,44,193,109,239,110,107,250,234,241,38,207,75,153,1,105,5,23,150,95,127,107,240,119,54,114,121,219,190,12,119,248,249,7,208,3,41,60,15,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5db3ffbb-42cb-49e9-93bf-aaabc11728ef"));
		}

		#endregion

	}

	#endregion

}
