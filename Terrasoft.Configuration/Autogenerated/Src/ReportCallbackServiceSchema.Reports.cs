﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportCallbackServiceSchema

	/// <exclude/>
	public class ReportCallbackServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportCallbackServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportCallbackServiceSchema(ReportCallbackServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a5244969-4616-4788-a99f-f6017305531d");
			Name = "ReportCallbackService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,223,111,26,57,16,126,166,82,255,7,223,246,30,22,41,50,239,52,68,74,185,75,196,169,73,171,194,169,15,81,31,204,238,176,88,241,218,91,219,203,137,139,242,191,119,198,222,101,1,45,144,34,33,240,120,126,126,243,205,88,139,18,92,37,50,96,11,176,86,56,179,242,124,106,244,74,22,181,21,94,26,253,254,221,203,251,119,131,218,73,93,176,249,214,121,40,63,30,157,249,28,236,70,102,240,96,114,80,103,47,249,119,88,158,87,184,205,188,220,132,184,157,94,161,204,82,168,241,120,106,202,210,104,254,217,20,5,138,187,251,59,169,0,83,222,128,245,96,249,84,73,208,158,47,132,123,238,84,246,107,35,39,253,55,22,78,201,249,157,200,188,177,18,92,159,6,86,213,249,197,251,15,22,10,172,128,77,149,112,110,204,190,65,101,172,159,10,165,150,34,123,110,202,13,138,79,205,1,179,247,22,35,252,32,217,173,171,30,193,163,191,10,113,88,74,37,253,246,27,252,172,165,133,18,11,115,233,254,129,64,99,19,118,193,132,180,120,35,200,135,20,164,170,151,74,102,44,163,4,251,243,99,99,246,73,56,104,79,47,33,223,93,101,95,173,169,16,110,196,99,76,255,61,100,30,242,168,50,26,141,216,181,171,203,82,216,237,77,43,184,7,239,152,95,3,83,216,60,176,204,172,152,13,81,89,1,26,34,209,248,206,122,180,111,94,181,238,217,70,90,95,11,197,102,200,0,70,95,34,230,96,80,128,167,166,12,94,223,18,223,129,206,79,196,103,25,226,167,224,183,82,137,208,221,239,124,76,119,46,230,49,80,131,237,177,184,55,243,15,120,23,241,61,4,27,217,225,188,173,137,128,4,119,104,221,153,90,103,90,122,41,148,252,31,28,19,76,195,127,76,162,189,208,216,69,44,155,64,184,118,0,44,179,176,154,36,189,189,79,70,55,145,26,167,112,136,236,233,181,77,135,77,113,212,160,9,181,233,65,104,129,61,231,216,131,207,161,251,105,114,12,91,50,12,56,12,78,160,53,137,147,20,103,112,75,142,174,47,1,127,147,14,223,2,237,3,248,181,201,3,137,105,237,196,169,196,62,135,3,251,215,129,61,14,68,123,133,232,52,21,217,26,242,190,219,244,190,150,57,243,248,111,150,183,96,108,132,101,89,176,152,225,202,163,137,173,42,108,171,70,54,17,221,226,38,164,112,123,66,84,65,148,99,117,100,250,20,93,242,133,153,123,139,11,40,29,254,248,120,228,60,36,55,217,143,36,220,201,42,162,113,103,200,167,107,200,158,111,109,81,211,210,120,172,149,74,53,62,14,102,149,118,58,195,166,81,22,124,109,245,94,212,223,3,251,18,133,169,135,113,94,107,76,158,105,227,229,170,129,130,137,165,169,125,207,244,18,58,151,71,56,72,42,97,69,201,168,184,73,146,133,135,195,53,152,36,55,11,12,218,120,193,57,95,225,211,194,58,149,16,132,95,143,130,131,224,239,233,75,181,99,96,183,195,7,79,248,36,204,244,198,60,67,26,240,138,165,99,107,146,175,95,230,139,228,42,8,63,153,124,59,247,91,69,27,28,245,31,192,57,28,148,157,148,127,183,162,170,32,191,106,70,227,103,13,206,223,25,91,10,127,96,16,69,252,31,103,116,171,234,42,92,25,112,94,55,188,3,237,40,183,251,108,99,144,186,143,4,247,54,237,158,213,22,29,118,8,86,75,238,67,233,25,26,29,90,15,59,246,18,204,135,183,51,2,235,200,241,44,239,44,234,83,163,57,185,48,156,125,161,154,76,228,138,165,127,244,175,32,78,63,13,134,71,117,92,157,204,101,216,2,68,187,144,255,109,173,177,233,159,9,17,236,77,132,238,184,204,150,219,72,239,217,95,88,223,75,95,9,175,108,141,163,142,126,217,18,64,211,51,231,121,187,85,95,79,207,102,148,30,10,81,182,255,249,5,192,19,193,186,33,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5244969-4616-4788-a99f-f6017305531d"));
		}

		#endregion

	}

	#endregion

}

