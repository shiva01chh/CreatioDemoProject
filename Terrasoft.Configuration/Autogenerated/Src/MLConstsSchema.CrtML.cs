﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLConstsSchema

	/// <exclude/>
	public class MLConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLConstsSchema(MLConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("786986e9-18ac-42e8-a1d8-4e690bf80ee5");
			Name = "MLConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,150,93,111,219,54,20,134,175,19,32,255,129,200,110,210,11,198,146,40,201,226,182,22,16,73,9,29,102,163,193,156,173,151,5,45,211,54,1,125,120,18,149,198,24,246,223,119,72,57,177,155,180,46,220,217,128,97,147,34,223,243,28,234,229,33,107,89,169,110,35,11,133,238,85,219,202,174,89,154,91,222,212,75,189,234,91,105,116,83,223,78,39,87,151,255,92,93,94,93,94,252,212,170,21,244,32,94,202,174,251,25,77,39,48,176,51,157,123,54,26,141,208,175,93,95,85,178,221,190,219,181,221,99,89,155,14,45,155,22,85,178,88,235,90,161,82,201,182,214,245,10,149,205,74,23,183,79,115,71,7,147,55,253,188,212,5,130,201,6,126,10,27,238,32,218,5,208,92,188,10,232,58,238,215,10,117,234,239,94,213,144,208,166,85,11,93,216,28,224,111,51,47,85,133,204,118,163,208,205,116,114,55,180,239,161,249,230,246,89,237,16,225,137,161,176,65,129,164,181,196,179,157,244,221,179,242,129,16,122,139,174,233,56,24,11,62,22,152,132,113,132,195,36,78,112,154,147,49,38,156,167,52,34,169,207,226,236,250,151,163,248,46,91,189,212,133,60,39,57,255,66,245,5,117,50,78,50,150,249,62,102,94,78,112,72,210,12,39,73,26,225,44,72,120,152,251,130,135,25,249,14,117,87,52,46,206,185,22,122,144,123,193,233,39,132,135,17,35,56,143,242,12,135,89,46,48,163,148,224,192,247,226,44,202,98,145,139,232,8,231,31,106,213,42,88,133,243,173,234,94,241,5,41,241,199,94,26,132,1,14,105,6,43,154,11,138,41,205,4,246,68,12,143,152,16,169,151,30,37,45,154,170,82,245,98,240,192,13,207,223,156,205,8,77,89,202,121,99,247,246,131,202,117,105,148,235,6,230,113,154,120,220,207,83,28,167,150,217,243,124,76,97,85,193,192,222,56,205,4,124,252,240,152,11,212,163,65,51,93,233,82,182,218,108,207,197,107,101,15,84,129,51,101,113,236,49,154,226,148,17,216,99,81,14,190,205,72,138,193,24,9,17,96,132,52,230,223,113,107,37,117,109,84,45,109,149,248,172,235,69,243,217,214,154,214,160,74,153,117,179,0,220,253,128,143,238,249,41,200,175,38,207,172,246,116,144,134,4,2,158,8,145,67,2,220,167,28,135,1,103,152,249,33,193,25,133,93,199,252,148,123,204,217,248,104,10,16,85,213,157,66,205,70,13,117,26,24,22,202,21,218,167,186,247,96,107,97,251,0,3,187,19,232,39,186,248,240,164,201,173,36,16,223,61,43,206,6,193,219,63,59,117,20,241,119,181,117,44,5,20,125,181,128,162,166,85,13,33,138,86,111,96,149,37,200,206,183,48,75,65,189,107,213,242,237,181,171,238,251,67,103,230,6,178,94,151,11,213,94,143,222,157,192,191,99,149,96,182,172,54,218,104,213,13,106,22,9,114,177,78,124,53,226,104,46,31,117,89,162,57,144,174,155,78,213,200,192,234,63,200,178,183,214,49,107,244,94,175,214,168,211,171,218,85,87,235,168,133,90,194,57,183,176,25,78,39,40,171,87,246,212,187,217,101,184,128,117,248,203,206,30,252,112,146,175,38,131,214,236,32,216,215,52,127,115,46,139,120,70,242,72,112,40,150,161,143,67,17,115,204,198,121,130,19,48,29,33,62,161,208,250,31,105,27,183,141,30,117,213,87,110,171,203,185,46,237,6,181,7,193,121,178,149,143,119,123,221,111,231,73,56,139,73,0,117,202,203,120,110,203,1,197,44,138,25,246,51,26,121,194,207,227,128,178,163,121,78,193,228,37,196,46,251,170,238,80,223,193,155,179,206,53,45,108,99,0,57,5,217,42,113,39,100,203,220,253,78,193,82,66,57,165,129,23,9,44,72,26,195,219,200,57,78,120,30,226,48,164,57,103,212,103,148,120,63,66,185,191,227,252,56,231,254,54,227,14,217,32,136,9,92,7,176,23,83,224,203,184,192,9,137,3,12,223,48,28,19,34,188,225,232,250,38,169,80,75,217,151,6,53,189,217,244,102,135,140,100,169,229,41,101,104,167,242,193,137,12,172,169,149,176,136,67,231,167,79,174,202,255,59,92,77,225,176,28,110,167,182,233,250,14,63,255,1,140,14,85,32,230,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("786986e9-18ac-42e8-a1d8-4e690bf80ee5"));
		}

		#endregion

	}

	#endregion

}

