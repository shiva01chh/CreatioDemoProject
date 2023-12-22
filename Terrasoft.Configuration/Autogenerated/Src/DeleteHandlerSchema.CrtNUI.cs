﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeleteHandlerSchema

	/// <exclude/>
	public class DeleteHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeleteHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeleteHandlerSchema(DeleteHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9a38c7f8-2974-424a-9960-8d7d9505c288");
			Name = "DeleteHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,86,93,111,218,48,20,125,206,164,253,7,151,189,4,9,229,7,148,117,82,203,71,203,3,221,86,214,189,76,19,50,201,5,44,57,54,179,29,90,84,245,191,207,142,157,196,14,132,245,165,90,31,74,98,95,223,123,207,241,185,7,24,206,65,238,112,10,232,7,8,129,37,95,171,100,196,217,154,108,10,129,21,225,12,189,124,252,16,21,146,176,13,90,28,164,130,124,216,122,79,22,144,22,130,168,195,209,198,3,172,41,164,38,73,179,229,87,17,208,181,158,76,152,34,138,128,236,12,152,226,84,113,209,25,145,231,93,69,61,104,201,3,217,108,149,92,128,216,147,212,244,162,15,236,138,21,37,41,74,41,150,18,141,129,130,130,59,204,50,10,2,93,162,89,184,240,82,158,136,62,9,216,24,162,166,4,104,38,47,209,55,65,246,88,129,221,220,217,23,36,0,103,156,209,3,122,148,32,116,23,204,18,131,150,69,240,62,60,121,166,100,227,128,150,80,126,6,49,147,231,20,118,54,19,84,143,65,128,84,194,80,176,212,20,112,49,7,41,241,6,208,149,91,78,38,249,174,76,88,226,0,150,89,40,33,46,221,157,142,46,12,223,6,93,73,144,3,103,201,10,88,137,91,0,67,124,131,10,139,133,210,47,213,21,69,45,22,116,127,39,104,137,28,126,189,235,17,241,122,190,249,111,130,239,64,24,41,117,92,140,213,192,29,80,29,134,150,194,123,27,118,134,5,47,22,193,6,148,123,138,200,26,197,65,34,116,113,133,88,65,105,133,54,138,4,168,66,176,19,229,74,60,230,99,143,5,194,98,35,53,88,6,79,254,29,92,139,77,145,107,2,126,253,70,47,200,229,235,8,137,123,33,141,189,65,91,111,125,87,212,21,15,219,190,66,35,51,6,118,212,14,201,45,168,207,62,242,47,177,105,176,239,142,118,67,122,125,195,53,205,65,109,121,231,240,172,56,167,72,151,159,201,17,102,86,109,139,116,11,57,126,128,148,139,44,190,45,72,166,167,197,60,63,206,178,138,102,67,97,90,197,219,72,13,201,71,96,32,157,204,88,6,197,78,111,137,221,185,215,78,57,240,170,88,112,230,178,47,90,85,234,123,110,70,210,93,99,101,149,245,212,198,61,59,15,182,68,82,175,39,247,188,236,97,202,69,98,83,247,42,162,219,147,220,20,73,220,162,71,123,117,45,173,14,253,201,169,72,222,115,77,226,136,2,22,113,61,150,65,255,90,193,213,28,158,245,146,127,94,118,203,70,231,144,175,64,200,192,82,26,91,107,158,142,6,173,146,92,104,124,129,222,92,58,103,130,19,191,239,238,116,94,84,103,198,82,146,22,135,47,191,70,125,142,201,97,45,69,89,164,169,78,170,249,210,83,10,195,51,18,61,163,244,186,202,27,212,231,240,172,49,149,129,36,148,56,248,86,117,17,202,60,153,201,241,205,79,2,79,141,91,145,117,61,10,83,80,233,118,42,120,62,190,105,122,233,55,70,84,121,180,19,109,187,223,218,222,94,17,232,174,234,10,134,7,144,127,220,148,248,35,241,189,0,113,136,91,174,149,248,17,115,204,244,69,137,1,58,30,215,186,170,206,157,92,103,217,53,165,118,115,196,105,145,51,25,215,1,193,183,146,249,130,209,7,244,53,216,229,118,249,1,58,130,101,136,116,135,143,204,62,10,41,57,162,194,94,141,214,129,166,22,197,51,182,199,148,100,95,181,61,149,63,82,26,253,195,243,105,99,129,231,14,103,128,231,208,17,162,70,130,190,40,170,202,71,230,244,238,21,199,171,255,0,243,253,43,249,198,235,34,206,216,98,185,90,254,243,255,254,2,224,133,198,70,152,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a38c7f8-2974-424a-9960-8d7d9505c288"));
		}

		#endregion

	}

	#endregion

}

