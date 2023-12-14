﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChangeProjectIdRecordOperationExecutorSchema

	/// <exclude/>
	public class ChangeProjectIdRecordOperationExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChangeProjectIdRecordOperationExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChangeProjectIdRecordOperationExecutorSchema(ChangeProjectIdRecordOperationExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c157fd87-3995-4137-9310-972f337c488d");
			Name = "ChangeProjectIdRecordOperationExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,107,219,64,16,61,43,144,255,48,113,32,200,96,164,123,234,24,138,235,26,31,146,154,198,244,90,182,218,145,189,141,246,131,213,202,174,40,249,239,221,15,201,218,24,187,88,7,137,153,125,243,230,205,155,149,32,28,107,69,10,132,13,106,77,106,89,154,108,46,69,201,182,141,38,134,73,113,123,243,247,246,38,105,106,38,182,240,218,214,6,249,167,147,216,226,171,10,11,7,174,179,37,10,212,172,24,48,49,45,231,82,156,63,209,152,45,132,97,134,97,109,1,22,114,175,113,107,9,97,94,145,186,126,132,249,142,136,45,174,181,252,109,27,173,232,119,44,164,166,223,20,6,141,139,63,88,52,70,106,95,153,231,57,76,235,134,115,162,219,89,23,31,145,96,36,20,158,11,24,69,219,177,100,168,107,96,2,10,169,24,82,80,161,5,104,223,161,206,122,194,60,98,84,205,175,138,21,80,56,105,87,42,131,71,88,93,20,157,56,135,143,19,127,101,88,81,59,242,90,179,61,49,232,103,74,84,8,172,44,66,165,168,90,88,125,97,222,113,43,105,186,108,24,157,128,123,207,224,231,27,182,207,68,41,107,112,48,50,185,71,65,3,117,23,247,206,218,117,25,221,20,86,130,235,230,103,10,136,83,7,125,34,130,103,71,80,126,138,154,42,162,9,7,97,111,213,211,104,144,50,154,13,114,225,192,204,14,120,56,128,82,75,14,178,162,110,49,2,15,241,86,178,105,238,217,60,121,231,249,117,110,167,151,220,25,20,141,193,155,158,68,126,193,19,124,48,47,73,222,255,239,224,51,154,157,164,215,152,23,132,197,119,174,187,133,25,92,233,165,171,51,237,104,214,141,14,33,62,227,208,94,50,218,247,75,253,63,213,118,224,126,228,16,101,243,29,22,111,159,245,182,225,54,241,210,84,85,218,55,25,251,225,147,61,209,80,99,85,174,168,117,166,43,90,162,217,180,10,169,253,229,27,46,126,144,170,65,111,240,44,29,173,104,92,104,117,217,146,43,75,215,30,124,220,106,207,227,78,221,165,88,119,92,19,23,188,122,69,1,192,74,72,239,162,13,102,27,221,218,54,158,59,13,210,39,32,27,51,212,141,123,19,146,99,202,42,116,141,178,23,60,184,111,218,53,127,143,189,122,69,19,201,246,179,70,98,198,131,154,75,98,212,113,132,78,78,63,211,24,30,30,6,179,238,58,45,11,174,134,125,93,18,113,234,218,228,3,111,52,197,153,107,220,229,226,148,205,184,231,31,215,44,223,89,17,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c157fd87-3995-4137-9310-972f337c488d"));
		}

		#endregion

	}

	#endregion

}

