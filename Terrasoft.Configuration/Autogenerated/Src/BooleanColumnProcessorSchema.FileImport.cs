﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BooleanColumnProcessorSchema

	/// <exclude/>
	public class BooleanColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BooleanColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BooleanColumnProcessorSchema(BooleanColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16051955-a165-4827-ad0d-ccb78ce7a0be");
			Name = "BooleanColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,84,77,143,218,48,16,61,239,74,251,31,70,244,2,210,42,185,243,85,237,178,187,21,135,82,212,66,47,85,15,198,153,128,165,196,142,198,246,170,8,241,223,59,113,18,150,208,176,151,86,205,1,156,241,155,55,51,239,217,209,34,71,91,8,137,176,66,34,97,77,234,162,153,209,169,218,122,18,78,25,29,189,168,12,231,121,97,200,221,221,30,238,110,111,188,85,122,11,223,246,214,97,62,58,189,159,103,231,185,209,221,59,132,215,226,209,139,144,206,144,66,203,8,198,124,32,220,114,117,152,101,194,218,33,60,26,147,161,208,51,147,249,92,47,201,72,180,214,80,64,198,113,12,99,165,119,72,202,37,70,130,36,76,39,189,133,209,75,36,171,184,75,237,46,210,14,171,175,104,125,230,142,189,120,218,16,88,159,231,130,246,205,123,249,60,104,80,218,58,161,89,28,147,130,219,41,11,178,108,7,120,65,172,154,209,86,109,50,132,212,16,20,21,121,57,88,221,43,200,80,21,94,69,230,209,70,77,161,248,172,210,143,39,76,5,55,242,168,116,194,153,125,183,47,208,164,253,249,69,191,131,123,88,176,77,48,1,205,127,12,232,86,99,48,248,201,156,133,223,100,74,214,141,118,3,97,8,239,201,51,222,112,214,199,233,61,92,246,193,236,135,32,249,155,59,44,129,35,95,58,199,38,45,67,233,10,241,215,174,252,97,203,201,151,25,161,112,104,219,230,176,114,140,70,172,11,117,15,206,204,209,137,58,190,228,30,23,130,68,30,52,158,244,188,69,226,233,52,202,242,18,244,166,107,126,103,71,155,64,52,142,3,58,36,215,146,119,215,236,175,91,76,208,38,30,148,249,55,67,216,8,139,253,139,45,56,192,177,150,27,117,82,41,222,150,159,139,20,72,142,47,205,176,92,59,78,196,228,95,233,95,52,132,96,94,249,170,170,4,225,147,87,9,60,9,39,190,151,103,122,197,154,175,231,9,76,166,237,88,84,11,113,9,28,189,63,204,103,116,59,147,252,167,73,194,17,47,143,47,7,92,104,178,95,125,227,42,170,16,169,47,112,88,179,25,193,169,210,167,168,149,118,14,26,85,152,192,45,43,16,38,97,171,218,113,180,175,121,110,218,219,124,181,107,209,214,78,101,170,116,180,169,178,50,245,206,121,165,232,188,222,17,164,112,114,7,253,7,218,250,156,229,88,248,44,251,66,207,121,225,246,207,191,36,22,245,105,186,82,56,21,153,197,54,211,53,168,102,226,26,25,126,9,157,39,221,53,106,247,193,173,162,237,96,136,241,243,27,97,227,183,162,137,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16051955-a165-4827-ad0d-ccb78ce7a0be"));
		}

		#endregion

	}

	#endregion

}
