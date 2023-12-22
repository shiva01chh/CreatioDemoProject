﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITestMessageProviderSchema

	/// <exclude/>
	public class ITestMessageProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITestMessageProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITestMessageProviderSchema(ITestMessageProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bff25474-28b1-4347-ac89-5067a0c9bd19");
			Name = "ITestMessageProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b07b1682-f254-48a2-90d7-644c52f4c69e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,75,111,26,49,16,62,39,82,254,195,40,189,180,82,5,247,60,56,132,164,17,82,35,69,73,110,85,15,198,59,203,90,241,218,91,143,93,132,162,252,247,142,109,22,54,8,232,34,130,4,98,189,243,61,60,254,60,70,212,72,141,144,8,47,232,156,32,91,250,193,216,154,82,205,130,19,94,89,115,118,250,118,118,122,18,72,153,25,60,47,200,99,125,185,241,204,245,90,163,140,197,52,184,71,131,78,73,174,225,170,47,14,103,188,10,19,227,209,149,44,114,1,147,23,36,255,128,68,98,134,143,206,254,85,5,186,84,59,28,14,225,138,66,93,11,183,24,45,159,151,5,4,101,48,137,95,104,229,23,80,90,7,158,105,160,206,60,64,104,10,246,51,104,105,134,29,158,38,76,181,146,160,90,11,59,28,156,188,37,23,43,203,15,232,43,91,208,5,60,38,124,126,185,233,49,45,60,179,56,101,63,211,160,95,1,107,161,244,202,218,92,249,10,138,133,17,53,155,144,150,93,24,63,88,98,132,214,224,176,97,122,65,160,74,88,75,32,130,116,88,94,159,199,194,142,223,91,225,197,224,41,67,30,4,189,210,249,112,4,141,179,13,58,238,139,45,193,87,8,141,112,124,168,188,93,184,74,127,153,8,88,31,175,207,11,134,51,162,213,81,4,38,176,7,110,39,214,141,95,124,143,255,100,101,185,157,29,95,6,132,177,204,203,175,4,225,96,101,114,184,217,136,172,214,149,26,69,191,76,245,39,40,135,197,238,115,187,26,38,232,154,201,161,15,206,208,232,9,41,104,79,113,103,20,164,100,88,25,116,11,75,124,40,100,213,154,101,158,22,24,153,54,122,151,185,82,235,111,199,157,245,175,91,122,12,209,254,183,203,101,36,248,125,78,69,122,126,207,209,254,184,216,198,102,172,5,113,104,182,80,238,12,121,130,164,189,204,157,104,154,184,177,172,223,163,113,123,2,47,19,237,86,35,155,89,127,204,1,82,216,39,238,147,130,19,172,74,197,121,88,230,173,147,122,135,210,186,98,71,70,150,198,238,131,42,224,134,49,119,17,50,41,224,13,102,232,47,121,79,252,243,126,144,114,188,79,66,250,254,178,227,12,56,74,84,43,243,202,103,18,151,249,206,245,150,254,153,96,119,9,117,128,126,106,18,136,130,195,70,132,212,154,96,89,213,40,246,192,147,167,18,30,132,75,221,144,130,231,11,127,139,60,119,56,71,168,85,173,120,22,236,119,72,222,197,220,37,177,167,53,117,95,147,105,20,69,107,171,169,145,76,81,101,131,46,96,154,242,234,247,59,224,249,252,235,55,116,71,219,54,245,227,175,98,158,2,135,93,70,151,39,71,186,147,177,255,159,113,19,91,31,199,221,69,214,142,71,78,48,175,48,141,232,152,141,118,60,206,249,28,214,83,115,127,251,167,214,106,120,206,197,199,30,251,71,93,189,232,125,250,220,34,255,191,4,28,106,164,228,68,243,117,240,54,181,165,143,139,31,9,241,9,73,76,107,221,207,63,84,17,19,3,108,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bff25474-28b1-4347-ac89-5067a0c9bd19"));
		}

		#endregion

	}

	#endregion

}

