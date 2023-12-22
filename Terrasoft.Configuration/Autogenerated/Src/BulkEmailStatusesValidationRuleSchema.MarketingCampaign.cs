﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailStatusesValidationRuleSchema

	/// <exclude/>
	public class BulkEmailStatusesValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailStatusesValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailStatusesValidationRuleSchema(BulkEmailStatusesValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c90e8fd1-a5ac-477c-8ec2-fdc321ab8f98");
			Name = "BulkEmailStatusesValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,109,79,219,72,16,254,236,74,253,15,43,223,125,216,72,156,115,159,27,136,68,32,208,72,64,17,161,215,47,39,157,22,123,146,172,112,118,195,190,80,82,196,127,191,217,23,39,182,227,0,237,29,170,160,30,239,60,51,243,204,204,227,21,108,9,122,197,114,32,183,160,20,211,114,102,178,19,41,102,124,110,21,51,92,138,143,31,158,63,126,72,172,230,98,78,166,107,109,96,57,104,61,227,249,178,132,220,29,214,217,57,8,80,60,223,57,115,202,12,219,49,94,112,241,176,99,188,133,39,179,53,214,179,82,176,207,158,157,142,240,21,190,236,247,251,228,80,219,229,146,169,245,48,62,255,197,74,94,248,90,136,178,37,144,153,84,228,206,150,247,4,150,140,151,68,27,102,172,6,157,85,238,253,154,255,202,222,149,60,39,121,201,180,38,35,116,26,59,159,105,116,217,34,223,56,224,79,100,50,93,65,206,103,60,111,190,57,60,183,188,112,112,207,62,201,228,55,5,115,151,206,25,135,178,208,159,200,181,226,143,204,64,120,185,10,15,152,151,114,133,94,130,214,108,14,167,138,205,140,15,126,229,58,118,44,214,228,104,72,82,204,68,153,91,208,225,149,63,20,29,210,193,126,176,111,220,44,38,34,151,74,97,219,66,49,29,104,199,165,2,86,172,111,172,232,132,116,47,165,40,215,228,171,6,133,35,35,194,8,144,127,108,227,121,16,75,6,81,132,170,155,20,224,65,204,205,230,70,42,71,132,167,59,242,16,168,127,131,116,218,138,222,12,222,35,110,120,147,164,149,19,57,34,59,73,38,201,203,235,153,94,43,185,2,101,56,116,231,25,25,30,43,133,227,245,76,230,96,6,100,195,190,123,120,3,254,18,204,66,238,29,134,201,88,216,37,40,118,135,195,20,34,13,201,57,152,13,57,218,79,197,68,248,9,8,76,81,55,116,68,175,74,238,91,58,41,42,50,30,153,194,140,220,198,158,72,43,12,146,33,224,59,153,122,11,109,49,213,115,203,109,151,130,166,46,64,218,203,206,148,92,210,116,19,23,45,223,22,160,128,166,211,109,160,180,231,227,36,217,68,143,31,44,43,105,192,200,174,153,66,16,3,138,214,179,234,101,199,162,160,105,72,250,61,206,151,76,221,131,65,10,252,236,232,172,53,33,158,2,135,75,152,142,85,249,246,38,181,154,179,176,167,235,43,121,33,243,251,207,92,24,77,123,131,13,59,10,180,45,43,98,46,184,54,21,231,213,33,175,65,244,116,52,126,130,220,226,232,146,226,110,243,223,163,246,6,100,99,161,173,130,211,209,214,68,123,85,51,34,212,196,233,227,13,110,20,40,191,88,224,112,234,9,7,120,8,71,232,54,220,22,40,193,42,8,182,60,240,53,17,5,60,33,70,0,67,89,54,95,84,193,5,242,25,59,57,136,94,223,23,28,183,40,30,115,240,181,220,144,179,48,213,2,93,26,96,83,111,167,205,112,27,204,36,16,152,29,23,5,117,174,155,23,47,225,111,248,19,126,43,48,86,137,72,121,125,15,91,210,133,65,207,164,90,50,99,160,240,195,142,79,81,151,104,215,118,20,77,193,172,15,255,172,129,83,205,191,247,27,89,94,58,130,107,195,224,10,240,195,109,124,83,210,3,18,116,48,65,24,96,249,130,198,4,155,1,9,23,251,82,72,154,241,179,227,213,10,53,129,254,158,254,157,62,55,93,94,208,82,15,255,82,181,237,165,74,160,142,115,3,75,249,8,180,101,189,0,49,55,11,242,71,163,142,104,61,232,50,198,16,177,47,45,180,91,25,59,223,235,106,213,157,148,37,249,204,244,86,150,58,190,52,255,175,46,157,89,145,103,254,60,77,157,120,116,40,84,212,147,46,157,250,25,133,234,101,95,176,79,163,18,5,163,83,173,174,164,249,53,193,186,46,25,150,85,188,42,133,191,12,238,63,233,46,66,12,112,82,74,13,161,136,255,32,144,121,108,80,135,66,77,115,86,50,117,136,30,27,181,140,163,20,156,134,228,207,247,124,109,183,159,195,218,167,182,125,187,171,95,239,160,235,78,183,113,234,183,189,14,87,142,65,63,255,71,105,173,217,233,240,171,224,15,22,247,183,0,97,240,42,135,75,47,103,97,92,137,193,35,196,72,242,24,67,30,246,61,202,176,118,13,240,43,80,165,180,119,212,223,33,88,200,238,91,31,248,58,112,96,154,207,104,11,6,39,106,93,83,244,168,85,129,31,127,87,137,26,138,225,246,222,52,157,224,95,228,63,194,230,99,109,22,118,214,113,208,128,223,17,216,215,196,187,173,146,17,42,92,164,142,162,252,103,193,157,238,38,126,208,138,86,249,87,250,197,74,13,117,209,68,138,222,84,168,198,242,255,4,117,29,88,239,231,110,91,112,59,192,27,21,69,59,222,162,225,149,205,66,43,254,171,255,252,11,206,188,230,111,251,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c90e8fd1-a5ac-477c-8ec2-fdc321ab8f98"));
		}

		#endregion

	}

	#endregion

}

