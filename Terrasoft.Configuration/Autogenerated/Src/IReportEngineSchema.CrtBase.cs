﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IReportEngineSchema

	/// <exclude/>
	public class IReportEngineSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IReportEngineSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IReportEngineSchema(IReportEngineSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("60dd28c3-b84b-c20a-3b0d-4527842a3dc6");
			Name = "IReportEngine";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,75,79,219,64,16,62,131,196,127,88,133,11,72,85,162,246,8,73,164,10,2,138,212,80,148,68,234,1,113,216,216,147,100,85,123,215,218,93,67,35,212,255,222,217,241,219,177,141,105,203,1,216,245,60,191,249,102,102,37,15,193,68,220,3,182,6,173,185,81,91,59,188,81,114,43,118,177,230,86,40,121,118,250,118,118,122,18,27,33,119,108,117,48,22,194,235,218,25,229,131,0,60,39,108,134,247,32,65,11,175,65,38,140,148,4,105,23,202,135,160,248,92,120,125,136,197,112,5,250,69,120,64,50,195,91,110,57,134,98,53,247,44,42,160,202,185,134,29,122,97,55,1,55,230,138,45,33,82,218,174,192,90,180,100,72,98,52,26,177,177,137,195,144,235,195,52,61,39,98,204,164,114,195,76,108,84,146,139,226,77,32,60,230,57,195,71,118,79,222,200,118,238,254,81,171,8,180,21,128,49,60,146,98,242,189,238,156,46,230,62,83,91,102,247,192,52,153,29,230,146,101,255,89,0,247,177,240,157,202,27,219,129,189,118,49,95,179,223,29,214,211,220,182,34,176,160,77,183,237,187,68,40,255,219,215,199,45,160,120,40,36,24,246,186,7,204,68,51,171,80,23,11,205,45,160,126,196,233,31,157,199,130,146,74,51,169,222,73,118,163,84,192,230,102,149,26,72,114,105,140,235,28,164,159,128,79,231,228,182,118,217,72,142,37,152,56,176,173,212,88,83,89,156,72,181,72,89,118,104,175,139,46,66,34,50,91,215,60,243,170,187,127,98,76,90,83,31,233,223,130,223,230,96,225,233,153,185,6,201,208,234,42,224,220,199,190,19,91,129,133,203,179,244,148,246,203,9,191,114,147,151,212,103,91,165,91,92,211,141,6,60,255,52,211,37,216,88,75,131,30,1,152,167,97,59,25,56,2,15,103,97,100,15,131,209,212,241,69,230,88,98,183,115,230,154,62,40,184,130,52,9,17,49,17,5,89,80,102,56,30,101,246,157,67,234,136,37,125,42,250,162,51,91,137,86,67,170,29,227,27,21,91,74,179,200,173,179,13,211,58,174,33,140,2,148,118,182,88,195,85,143,48,102,191,44,72,227,130,112,73,150,122,163,197,179,177,218,33,148,56,43,148,171,158,62,210,7,51,25,135,89,27,172,15,17,180,54,65,169,191,75,132,176,168,210,197,125,64,243,37,235,236,138,57,86,22,212,111,4,101,33,60,173,220,180,103,63,28,255,58,75,241,116,11,198,211,34,114,133,188,24,44,86,164,50,184,124,118,223,22,134,244,39,236,243,167,14,111,119,220,216,180,153,62,224,169,208,74,157,149,204,76,216,151,247,96,159,103,51,225,42,27,10,142,49,173,224,127,149,56,69,154,8,91,68,220,123,250,148,41,250,127,102,144,200,39,71,11,116,181,125,213,99,85,121,60,202,198,106,123,23,220,36,66,31,48,155,209,181,193,102,137,164,244,171,135,209,7,124,21,213,54,130,3,194,30,152,241,246,56,156,186,163,159,145,232,138,36,201,210,223,55,241,49,155,102,114,135,173,218,202,167,92,1,99,231,88,64,195,98,147,12,244,242,28,78,114,234,124,10,29,177,43,115,92,231,213,2,159,4,202,239,67,170,251,116,6,87,230,204,171,176,123,58,71,90,189,32,223,124,156,35,116,30,187,87,65,136,75,133,73,196,112,50,200,222,111,110,175,148,223,114,109,75,138,212,235,186,211,185,52,150,75,47,175,110,105,117,85,159,125,206,13,65,232,211,112,216,212,166,163,202,252,100,139,5,215,22,121,44,111,73,218,142,83,55,136,81,100,19,228,78,235,203,200,208,236,76,54,95,162,67,187,168,80,28,87,222,23,211,28,201,139,106,204,57,46,151,215,157,101,176,73,46,129,48,244,238,225,47,92,4,20,95,137,23,109,176,10,137,15,64,97,125,229,165,176,85,232,129,239,127,91,29,70,14,200,30,144,148,234,208,48,205,168,24,216,187,166,169,36,199,225,215,112,92,2,247,191,203,224,240,13,243,29,55,88,119,120,214,163,190,200,32,236,209,173,116,231,126,254,0,54,72,68,109,77,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("60dd28c3-b84b-c20a-3b0d-4527842a3dc6"));
		}

		#endregion

	}

	#endregion

}

