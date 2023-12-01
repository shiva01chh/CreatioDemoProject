﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderValidatorSchema

	/// <exclude/>
	public class SenderValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderValidatorSchema(SenderValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("86811e5f-e4f7-4c68-bd63-b614d02090b3");
			Name = "SenderValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,87,109,111,211,72,16,254,28,36,254,195,18,78,194,62,34,23,238,99,219,228,174,165,129,235,29,161,61,82,232,7,2,210,198,158,52,22,206,218,236,174,67,211,42,255,253,102,95,28,175,29,59,13,119,18,8,33,178,59,47,207,204,60,51,59,102,116,1,34,163,33,144,43,224,156,138,116,38,131,87,41,155,197,55,57,167,50,78,217,227,71,247,143,31,117,114,17,179,27,50,94,9,9,11,188,79,18,8,213,165,8,222,0,3,30,135,71,117,153,183,49,251,182,117,120,5,183,50,120,15,55,121,66,249,240,54,227,32,132,50,82,202,181,96,8,94,13,199,123,9,141,210,8,146,61,236,141,40,255,10,18,37,130,15,50,78,98,25,131,82,66,181,167,28,110,80,128,188,74,168,16,135,100,12,44,2,254,145,38,113,68,101,202,181,200,193,193,1,57,22,249,98,65,249,106,96,127,143,40,163,55,32,200,210,72,42,11,233,140,76,243,228,43,129,5,141,19,130,73,22,90,66,104,139,34,40,12,29,56,150,178,124,154,196,33,9,149,239,186,107,114,72,78,169,128,145,177,227,32,234,220,107,84,37,114,76,168,164,76,34,250,75,30,47,169,4,115,159,153,31,36,84,247,68,72,174,242,51,162,33,79,177,32,112,123,73,165,4,206,72,159,116,191,120,147,201,167,201,228,105,240,28,255,153,76,62,251,191,116,143,172,15,196,100,220,84,125,94,242,52,3,174,178,168,156,166,18,201,1,145,17,169,103,75,31,188,1,41,136,156,3,201,82,100,192,84,85,96,69,100,74,98,134,24,120,158,73,18,206,105,172,115,184,44,34,213,41,219,206,25,198,101,253,145,116,137,202,113,4,100,154,166,9,57,23,39,211,148,203,11,246,177,172,73,127,64,102,52,17,240,64,56,35,144,243,52,106,75,160,77,29,198,112,150,98,109,29,251,195,219,16,50,245,31,91,37,239,124,200,242,5,112,58,77,224,216,168,13,72,164,149,68,175,176,147,132,119,54,247,62,81,157,214,233,44,41,55,172,17,88,13,35,21,252,149,198,204,235,246,8,254,181,6,252,163,141,176,37,23,74,219,59,100,123,206,164,231,147,126,159,188,36,191,43,172,111,195,187,177,54,133,112,115,240,172,217,215,41,95,80,233,149,24,208,195,24,47,84,131,118,125,95,123,232,28,254,152,254,101,130,93,150,160,182,1,200,65,230,200,171,170,130,69,220,179,113,26,209,117,53,207,77,201,67,32,31,88,252,45,7,147,122,241,154,167,139,161,54,209,152,107,99,253,109,44,100,145,91,139,166,188,8,198,160,102,153,103,218,20,9,194,224,59,209,29,225,117,191,4,191,254,209,245,113,96,101,9,14,72,35,130,1,98,104,193,25,170,198,12,245,26,161,219,210,90,102,192,25,204,104,158,72,211,209,167,43,221,116,237,120,177,129,150,177,154,17,46,31,34,99,98,40,178,161,1,106,74,227,206,55,14,181,33,135,67,119,12,82,77,57,53,166,165,41,220,7,1,28,197,152,153,223,24,141,5,55,28,95,106,203,93,159,80,97,3,48,5,140,103,164,40,247,185,120,151,39,201,5,31,46,50,185,242,106,152,252,2,111,141,147,219,228,233,154,76,104,173,178,123,106,64,180,143,174,37,81,81,55,107,213,28,174,55,217,193,135,4,53,85,57,209,159,42,160,250,239,113,101,130,162,131,115,54,75,7,158,211,55,28,144,73,27,157,162,90,70,237,189,189,179,33,157,100,241,223,176,66,201,49,240,101,28,2,254,14,204,153,129,98,140,206,176,8,52,156,23,249,34,153,45,37,14,182,150,218,118,44,134,64,199,92,70,240,233,51,185,223,42,250,250,168,170,83,88,123,135,111,56,170,21,222,142,202,42,148,239,209,123,157,162,106,0,213,136,177,53,11,131,158,245,80,102,191,200,111,112,18,69,94,221,170,239,214,67,209,197,149,103,43,239,86,245,213,237,198,93,52,44,187,79,93,251,141,204,185,130,5,182,157,252,31,12,122,151,202,147,76,37,5,162,13,143,170,212,108,28,74,133,227,94,61,255,15,115,177,61,246,107,158,178,155,159,20,183,246,245,147,34,174,78,119,221,179,77,3,177,189,31,43,109,135,176,134,216,63,27,26,106,23,238,160,44,110,156,52,12,236,74,101,146,123,29,203,121,227,0,173,115,86,236,61,41,54,77,173,204,100,219,0,132,234,238,7,49,252,232,192,233,184,3,161,201,107,224,254,232,89,165,246,49,85,72,180,204,140,138,101,87,198,168,173,119,206,20,107,122,179,74,227,139,41,249,234,130,189,70,107,57,7,79,45,34,131,31,27,60,61,242,219,139,30,121,249,162,100,113,173,124,15,15,34,75,205,45,77,151,159,123,108,128,15,111,179,69,52,197,114,175,248,208,176,250,183,236,175,250,36,163,156,46,8,195,124,247,187,90,11,159,104,137,31,75,221,193,25,174,197,223,145,80,200,152,80,25,226,43,215,118,140,68,61,62,208,218,165,49,19,184,24,56,139,111,49,0,112,64,177,20,183,255,60,12,1,162,224,248,160,144,109,217,164,107,139,140,119,138,174,135,14,62,226,130,173,236,175,181,85,184,28,61,229,140,208,130,211,194,226,63,57,240,213,159,144,224,135,132,237,143,211,134,43,247,249,110,237,57,212,111,50,171,150,160,113,139,142,162,186,240,220,104,2,139,252,60,42,186,171,186,58,249,206,118,212,6,196,125,1,42,29,166,206,87,234,92,111,154,184,87,141,168,12,231,222,170,183,253,69,230,55,63,19,155,174,219,185,100,182,35,179,107,175,5,231,166,193,93,110,139,246,83,81,62,105,92,2,45,156,18,99,103,171,244,207,251,213,151,163,89,228,217,132,61,179,247,235,218,122,135,45,156,171,241,95,25,186,253,246,250,87,130,83,76,106,120,54,10,184,181,121,88,77,133,45,124,205,111,173,150,215,115,192,25,167,171,249,100,159,114,6,87,169,26,235,158,249,186,90,251,214,192,157,50,112,183,77,19,223,33,218,147,166,76,88,169,114,161,52,95,56,181,20,239,92,153,119,189,193,77,46,93,72,255,121,215,219,19,168,253,164,53,235,80,219,199,159,3,194,212,126,68,119,98,41,146,218,68,196,125,62,236,55,31,241,205,11,217,253,139,245,53,229,44,46,215,176,221,140,223,149,138,230,151,202,156,86,15,241,12,255,252,11,194,99,94,168,209,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86811e5f-e4f7-4c68-bd63-b614d02090b3"));
		}

		#endregion

	}

	#endregion

}
