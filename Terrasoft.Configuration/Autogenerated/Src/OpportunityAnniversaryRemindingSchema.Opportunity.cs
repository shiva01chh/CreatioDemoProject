﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityAnniversaryRemindingSchema

	/// <exclude/>
	public class OpportunityAnniversaryRemindingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityAnniversaryRemindingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityAnniversaryRemindingSchema(OpportunityAnniversaryRemindingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("02869893-cf9d-42c9-bfde-d916da7a4aa1");
			Name = "OpportunityAnniversaryReminding";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,87,75,111,227,54,16,62,107,129,253,15,132,122,145,81,67,238,169,135,196,49,144,196,155,173,219,205,198,27,167,237,177,96,196,177,205,174,76,106,73,202,129,177,232,127,239,240,33,153,114,228,60,122,104,2,36,17,71,243,158,111,134,35,65,55,160,43,90,0,185,3,165,168,150,75,147,95,74,177,228,171,90,81,195,165,120,255,238,251,251,119,73,173,185,88,145,197,78,27,216,156,30,156,145,191,44,161,176,204,58,255,8,2,20,47,246,60,177,90,5,199,232,249,244,2,95,225,203,31,20,172,80,17,185,44,169,214,39,228,166,170,164,50,181,224,102,119,46,4,223,130,210,84,237,110,97,195,5,67,45,78,164,170,239,75,94,144,194,74,60,39,64,78,200,5,213,208,175,43,249,238,244,237,125,192,128,12,21,70,123,114,165,248,150,26,32,133,37,19,46,12,153,194,146,214,165,57,47,76,77,203,57,198,45,25,57,35,63,159,6,53,32,152,215,212,85,123,197,161,100,24,219,220,249,29,116,251,24,208,156,193,127,10,40,147,162,220,225,89,89,167,207,139,66,214,194,220,84,54,199,104,33,13,132,244,244,121,89,12,194,208,34,146,13,132,151,200,206,169,66,50,175,104,108,59,34,166,207,68,234,18,168,234,194,72,213,13,119,52,26,145,177,174,55,27,44,192,164,33,68,220,121,203,84,81,69,55,68,32,74,207,210,90,131,66,38,225,177,150,78,126,239,156,177,34,182,90,5,228,227,145,147,106,21,143,71,177,169,16,242,51,64,201,14,148,119,109,15,78,200,61,194,40,59,160,18,219,42,73,178,40,214,176,161,159,209,103,155,175,200,144,207,121,178,144,181,42,96,102,177,210,218,115,193,235,60,98,246,175,26,94,47,249,23,237,66,205,181,78,167,93,115,236,201,5,24,131,42,109,51,154,63,104,89,195,24,193,58,57,136,104,232,20,38,233,103,105,224,1,109,174,119,94,235,149,84,145,19,81,177,117,58,236,3,252,192,121,246,143,253,243,6,149,141,149,112,150,78,46,107,165,0,59,83,65,33,21,35,51,246,63,128,97,72,62,214,156,17,206,16,21,102,205,245,17,84,220,58,151,92,213,57,107,146,118,216,61,62,137,77,255,204,149,172,0,11,0,118,90,40,44,84,97,128,53,76,205,56,178,131,168,131,11,223,216,13,187,123,223,153,80,222,157,21,152,240,148,240,37,201,14,144,117,70,126,106,252,126,140,186,30,20,120,120,122,24,36,137,2,83,43,209,227,85,96,208,123,219,135,186,183,22,175,17,111,11,172,99,51,230,26,204,90,178,110,130,142,2,241,214,57,166,137,6,123,97,145,7,110,214,132,150,37,89,242,210,96,205,201,82,42,82,4,8,225,47,194,161,31,175,94,62,157,44,188,30,43,182,242,77,71,232,30,63,136,194,0,160,167,129,251,173,6,181,11,181,222,165,147,47,246,72,170,112,238,248,228,237,190,66,91,254,27,160,198,8,211,33,44,162,221,140,114,34,175,208,230,166,73,58,185,91,195,222,63,6,152,58,140,19,52,49,187,10,136,92,98,23,0,146,17,238,126,36,61,50,224,241,161,39,215,146,241,37,71,140,190,162,30,227,81,35,125,164,163,91,224,75,12,89,113,6,36,84,105,234,61,2,127,204,2,213,155,30,18,76,148,139,110,78,185,26,251,251,111,24,238,193,9,233,100,161,105,12,47,233,97,156,159,11,150,13,194,243,77,5,226,162,148,197,215,134,18,147,246,151,195,144,164,11,67,87,56,220,211,65,62,211,56,136,63,124,195,86,200,112,157,170,55,34,72,38,249,220,230,206,230,56,139,166,84,187,154,196,55,198,101,41,53,176,91,248,219,197,63,99,131,65,171,196,186,247,90,203,255,197,180,146,245,219,152,254,83,138,55,176,250,73,106,19,153,205,29,245,176,244,170,15,6,141,205,171,90,20,249,20,81,57,229,203,101,75,77,26,138,155,5,150,199,54,210,76,160,103,56,32,243,107,92,225,214,195,150,217,71,145,251,85,193,31,186,177,79,107,176,10,211,193,94,198,217,13,183,165,125,119,199,55,208,250,153,52,15,54,89,159,64,235,27,21,231,43,74,83,103,19,120,34,13,29,146,31,239,26,187,189,88,147,172,103,194,180,87,79,129,75,86,119,227,60,9,54,194,36,252,85,114,145,217,63,119,56,122,242,25,222,185,106,72,162,253,235,199,253,190,187,199,198,205,65,122,2,42,124,136,253,194,135,74,173,200,233,11,92,233,183,30,169,125,153,241,230,49,54,123,143,219,250,215,112,96,254,70,238,38,7,111,211,190,101,70,255,2,37,230,218,249,123,71,239,75,200,154,17,24,39,229,209,45,210,103,215,223,230,225,182,247,90,226,197,166,103,20,111,37,110,74,51,108,160,47,145,126,220,111,178,166,228,118,173,206,123,25,188,201,115,198,226,55,187,172,253,22,106,166,117,254,97,83,153,221,81,246,199,73,77,95,194,27,99,112,240,76,144,83,238,218,21,147,222,94,36,79,221,46,19,130,123,186,179,236,63,178,244,94,190,77,203,150,42,34,247,111,177,180,46,81,79,8,250,152,34,153,28,227,203,58,95,146,67,34,224,225,73,215,142,102,247,136,250,206,199,230,75,212,247,85,227,136,238,71,31,163,175,212,223,169,96,176,17,160,27,153,58,182,152,227,217,83,99,162,163,224,207,191,181,14,142,242,69,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("02869893-cf9d-42c9-bfde-d916da7a4aa1"));
		}

		#endregion

	}

	#endregion

}

