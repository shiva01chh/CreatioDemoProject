﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StageMergeUtilitiesSchema

	/// <exclude/>
	public class StageMergeUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StageMergeUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StageMergeUtilitiesSchema(StageMergeUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2f24ffb-2754-4cd5-94a8-c09dca411356");
			Name = "StageMergeUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,221,111,219,54,16,127,118,129,254,15,172,86,4,50,102,200,239,137,173,161,177,157,46,88,218,102,77,179,62,22,178,116,182,57,200,146,75,82,105,132,196,255,251,142,95,18,245,225,218,221,48,12,88,31,82,243,120,60,222,231,239,142,34,89,180,5,190,139,98,32,159,128,177,136,231,43,17,204,242,108,69,215,5,139,4,205,179,151,47,158,94,190,24,20,156,102,107,114,87,114,1,219,139,214,26,249,211,20,98,201,204,131,183,144,1,163,113,135,231,134,102,95,107,226,58,205,151,81,122,126,62,203,183,219,60,11,110,242,245,26,201,245,190,171,139,228,232,223,97,112,136,30,204,47,15,110,45,50,65,5,5,142,12,200,242,19,131,53,42,78,102,105,196,249,57,185,19,209,26,222,1,91,195,189,160,169,226,83,108,227,241,152,76,120,177,221,70,172,12,205,90,241,146,13,229,34,103,37,217,202,67,164,176,167,2,123,104,236,156,218,21,203,148,198,36,150,119,245,95,53,120,82,215,85,106,93,81,72,19,212,235,150,229,2,93,12,137,222,222,217,37,97,16,37,121,150,150,228,158,3,195,192,101,58,16,173,229,133,145,10,89,162,5,203,149,123,15,178,114,161,238,161,15,145,0,187,189,211,75,194,5,230,66,92,95,118,141,17,35,95,82,252,51,37,248,243,93,148,161,45,12,131,47,100,40,129,249,222,28,146,98,135,198,170,28,242,134,23,213,133,7,85,120,7,98,147,39,135,117,184,223,37,242,63,188,67,121,238,35,196,57,75,52,209,231,130,201,72,139,104,153,194,123,204,232,17,49,148,109,132,217,135,142,72,139,109,166,55,222,22,52,33,235,60,77,32,211,34,174,147,145,188,102,160,54,240,50,25,44,125,224,143,40,45,240,196,50,207,83,66,249,175,42,208,104,81,90,145,230,5,204,241,250,197,118,39,202,33,121,82,98,30,34,70,10,173,234,148,100,240,205,232,237,55,3,50,170,117,29,170,99,131,224,14,132,223,85,87,255,14,110,35,134,75,220,243,155,170,15,181,103,7,116,69,124,87,69,171,205,64,171,162,132,123,245,182,215,35,88,176,2,172,184,189,35,180,207,200,134,88,195,224,141,58,34,37,249,19,221,66,112,47,226,247,249,183,166,116,35,226,243,6,24,248,222,117,226,13,131,107,190,248,90,68,169,223,17,212,13,139,149,197,64,20,44,51,30,87,164,253,241,84,83,217,206,138,24,189,33,243,77,85,165,174,144,118,157,43,130,195,30,84,76,227,54,215,100,39,213,37,18,80,167,94,209,136,182,23,94,163,132,40,67,148,205,87,40,31,128,196,12,86,83,79,1,82,51,51,188,113,56,25,43,81,74,178,129,140,30,176,104,101,20,105,94,105,35,213,98,154,182,216,172,199,78,45,205,99,174,194,234,36,113,213,14,164,181,26,37,193,128,46,89,229,204,64,37,83,41,204,79,245,40,143,55,176,141,100,81,120,161,114,68,45,83,111,41,190,192,245,93,71,134,46,175,59,87,146,162,104,81,229,233,130,44,182,1,247,194,89,195,220,122,167,210,239,251,162,184,244,143,78,108,149,239,90,34,174,200,206,166,191,246,154,98,36,249,242,79,188,172,43,82,215,1,15,23,218,146,58,6,200,106,247,156,124,210,108,142,234,24,184,55,105,170,130,165,97,162,212,16,195,45,182,214,254,111,129,235,157,179,161,82,238,6,207,79,36,154,134,142,55,70,228,55,40,85,229,222,70,148,77,180,4,43,41,36,29,47,216,252,213,138,234,59,108,124,166,173,238,22,184,76,78,47,178,69,119,89,74,237,252,218,2,7,52,59,23,7,168,39,2,209,251,34,77,63,48,5,122,254,144,60,63,119,53,12,148,53,109,214,10,33,13,48,201,14,208,118,118,167,23,116,52,219,87,173,4,248,87,211,71,92,35,127,47,128,149,198,32,115,4,25,131,55,73,34,131,168,200,90,85,238,55,183,53,245,128,213,31,97,151,226,36,232,123,95,176,63,120,129,55,116,206,94,209,84,102,162,148,225,203,245,12,103,1,1,154,250,153,138,77,133,213,220,215,68,28,220,48,69,41,207,179,79,229,14,167,46,9,236,186,209,14,186,121,83,231,73,48,195,205,137,206,242,16,221,249,47,169,112,32,154,216,150,157,46,216,41,18,104,19,166,50,62,50,213,142,132,216,90,209,226,10,62,176,4,187,91,111,52,70,68,109,206,41,51,188,111,120,140,0,141,213,210,236,124,109,153,46,162,247,66,180,6,207,239,130,244,178,52,19,146,145,126,42,70,183,117,105,131,99,243,154,239,227,98,115,206,241,194,183,174,66,166,121,16,154,200,245,138,98,189,255,61,224,63,29,241,151,139,71,136,11,4,70,47,156,95,218,223,132,26,136,9,122,122,246,67,142,3,165,242,182,178,155,251,71,243,169,127,58,61,8,183,42,13,28,101,106,29,79,65,219,38,206,74,172,105,79,159,152,222,237,59,201,207,68,142,106,110,125,144,40,22,88,88,58,182,211,142,77,102,186,85,201,124,89,206,193,102,177,255,72,166,33,121,148,197,227,140,117,190,163,154,172,130,161,157,142,175,40,227,226,3,155,195,42,42,82,113,224,112,53,138,14,201,20,65,19,113,89,159,30,156,157,105,102,137,3,137,115,98,34,7,249,176,49,25,171,163,171,40,229,112,236,172,106,113,157,145,93,157,111,13,233,117,187,105,248,74,171,216,234,24,110,3,104,63,107,122,220,27,232,216,4,114,187,17,149,29,131,7,154,23,92,221,101,104,250,66,205,166,158,48,171,188,200,146,89,193,24,138,181,1,84,182,59,60,238,179,162,119,219,125,32,52,25,112,108,129,40,222,16,95,117,50,173,3,237,166,125,229,1,233,161,94,189,181,226,178,13,247,108,107,96,231,174,111,235,54,60,232,247,131,86,225,194,240,196,57,46,179,194,104,109,156,63,232,88,214,35,234,151,227,41,120,97,165,53,221,216,241,252,243,243,97,141,127,40,255,94,181,243,143,156,157,25,209,157,236,57,88,86,157,219,104,134,253,184,93,157,104,163,145,124,178,214,253,114,42,13,7,255,180,214,164,249,142,219,27,207,241,222,111,7,206,71,131,238,243,187,239,67,65,191,173,183,61,95,14,154,31,13,90,79,105,163,160,96,101,149,171,230,73,172,81,28,252,26,207,45,243,158,224,144,20,111,252,197,99,12,59,221,66,234,76,151,223,99,130,5,99,57,243,95,123,87,17,77,161,209,126,130,26,71,206,201,83,245,123,63,178,205,244,58,65,122,111,142,119,109,219,123,86,165,129,216,176,252,27,105,215,14,86,50,156,80,157,125,0,36,71,176,166,180,227,53,92,127,176,120,245,163,8,241,159,102,136,180,117,212,11,106,71,113,229,127,157,64,251,3,223,37,112,173,169,77,162,162,225,191,191,0,161,127,77,17,207,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2f24ffb-2754-4cd5-94a8-c09dca411356"));
		}

		#endregion

	}

	#endregion

}
