﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebFormProcessHandlersFactorySchema

	/// <exclude/>
	public class WebFormProcessHandlersFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebFormProcessHandlersFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebFormProcessHandlersFactorySchema(WebFormProcessHandlersFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7d2888b-d78b-42a0-9b05-fc54dd2df482");
			Name = "WebFormProcessHandlersFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,86,109,111,218,48,16,254,156,74,251,15,86,250,37,145,170,252,128,190,80,177,22,186,76,108,235,86,186,126,156,220,228,0,171,137,147,218,14,29,154,248,239,59,199,78,32,47,188,168,154,134,32,224,243,249,238,185,231,94,12,167,41,200,156,70,64,166,32,4,149,217,76,5,55,25,159,177,121,33,168,98,25,255,112,242,231,195,137,83,72,198,231,228,97,37,21,164,23,173,53,234,39,9,68,90,89,6,119,192,65,176,168,163,115,75,21,237,8,39,140,191,110,132,219,0,210,52,227,253,59,2,118,201,131,219,143,59,183,198,52,82,153,96,32,81,3,117,78,5,204,17,46,185,73,168,148,231,228,9,158,199,153,72,239,69,22,129,148,159,40,143,19,16,210,156,89,149,7,182,223,121,241,156,176,136,68,250,236,254,163,228,156,132,7,108,59,154,221,26,15,106,229,32,20,226,60,215,191,21,178,10,113,9,192,201,5,91,82,5,100,194,164,186,12,75,154,113,25,247,154,31,144,95,121,211,223,133,49,97,45,146,37,19,170,160,201,145,198,90,216,73,9,217,153,131,178,191,28,1,170,16,188,227,148,92,95,19,175,35,188,34,28,222,142,243,236,249,126,9,220,89,235,231,218,16,113,10,60,54,116,217,181,229,238,11,168,69,22,247,17,215,142,250,1,116,185,146,59,80,173,200,190,23,32,86,222,163,4,129,45,192,77,73,147,162,177,60,35,119,5,139,201,155,193,27,198,190,229,96,73,5,145,198,174,9,208,56,241,154,167,125,195,151,163,91,166,72,185,231,142,139,36,41,139,240,43,246,161,107,183,131,177,200,82,207,237,175,156,90,233,115,198,184,167,31,211,85,14,65,136,46,196,25,113,219,140,186,126,48,148,158,59,127,155,185,181,243,111,220,8,80,61,140,81,33,148,163,87,228,197,51,160,130,123,42,16,140,2,225,109,162,220,239,116,130,216,176,233,180,204,250,75,84,211,29,174,219,222,42,8,250,148,222,216,235,1,7,198,67,180,128,148,90,251,82,54,237,227,26,181,30,155,14,140,83,115,238,145,197,199,56,185,167,209,11,157,87,81,200,188,207,203,70,173,233,14,181,109,140,214,203,211,2,4,236,204,163,214,149,67,44,139,37,236,203,129,18,5,248,53,138,33,143,247,25,28,113,197,212,202,212,210,22,176,114,111,187,194,172,33,131,24,227,121,202,196,75,121,11,236,175,135,102,49,7,245,169,64,87,8,161,210,22,189,233,89,59,20,228,70,180,238,52,100,134,173,244,3,104,172,111,7,47,212,79,189,2,65,68,249,85,53,151,84,66,207,244,168,106,20,108,49,163,128,215,141,50,40,127,210,164,128,75,163,56,232,244,213,69,221,163,11,195,22,90,40,183,237,28,14,144,207,8,208,216,225,145,84,131,176,70,91,89,8,134,113,236,89,39,254,142,168,237,24,42,163,159,100,52,174,206,190,111,242,216,105,86,15,159,93,99,173,109,109,99,200,4,98,12,4,163,223,16,21,10,76,30,60,175,74,196,213,96,147,40,43,219,17,94,56,226,69,138,20,62,39,112,57,29,244,192,65,233,251,34,101,179,190,235,4,199,45,38,187,210,113,26,132,30,138,121,189,93,169,237,76,154,246,173,11,102,80,215,14,147,100,234,7,55,20,111,48,12,165,65,195,225,203,169,252,243,96,54,119,125,236,31,140,109,34,123,202,18,218,215,116,201,116,75,122,168,166,12,103,253,116,91,90,122,18,120,4,154,67,212,175,255,1,5,153,84,125,28,116,196,255,139,132,46,158,35,89,104,85,141,145,54,133,165,108,235,245,23,185,50,91,226,184,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7d2888b-d78b-42a0-9b05-fc54dd2df482"));
		}

		#endregion

	}

	#endregion

}

