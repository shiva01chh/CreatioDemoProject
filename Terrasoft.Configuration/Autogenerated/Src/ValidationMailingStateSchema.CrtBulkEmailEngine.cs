﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationMailingStateSchema

	/// <exclude/>
	public class ValidationMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationMailingStateSchema(ValidationMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a4f104b-0194-4852-ba5f-4590ab640ee7");
			Name = "ValidationMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,93,111,218,48,20,125,6,169,255,193,109,95,64,154,204,123,89,43,181,140,181,72,109,55,21,212,61,76,123,48,201,5,172,25,59,243,7,131,86,253,239,187,182,147,144,64,90,216,75,68,110,206,57,62,190,62,215,72,182,4,147,177,4,200,4,180,102,70,205,44,29,40,57,227,115,167,153,229,74,158,180,95,79,218,45,103,184,156,147,241,198,88,88,246,119,222,233,61,151,127,176,136,229,115,13,115,228,144,129,96,198,92,144,103,38,120,26,84,30,24,23,200,24,91,102,33,32,123,189,30,249,108,220,114,201,244,230,42,127,127,130,76,131,1,105,13,177,11,32,137,23,33,106,70,86,165,12,89,70,29,98,188,16,45,116,122,21,161,204,77,5,79,114,114,179,1,114,65,234,126,90,175,193,83,105,255,187,86,25,104,203,1,247,128,191,45,36,22,210,8,217,245,29,10,19,116,91,115,86,88,86,154,150,164,170,201,86,86,168,214,156,60,23,44,178,253,245,74,230,96,251,196,248,199,219,1,15,83,199,69,10,154,204,144,215,232,199,111,78,59,1,230,160,173,81,131,47,100,223,228,43,236,87,26,124,110,213,212,10,195,197,83,64,55,218,155,26,106,173,244,3,24,195,230,48,14,165,129,194,175,151,87,228,44,87,134,161,223,64,196,153,249,89,255,160,226,10,115,115,159,188,188,163,118,227,196,239,168,232,113,143,24,250,66,242,28,100,26,143,253,131,12,132,76,229,22,98,190,202,245,111,29,79,127,254,34,215,43,20,103,83,1,95,149,30,174,33,113,190,55,190,121,206,128,241,86,36,252,69,152,159,165,86,43,239,45,206,153,177,134,150,222,34,252,187,96,82,66,58,74,63,29,198,226,83,91,79,56,18,127,157,88,190,130,163,160,161,245,71,154,80,89,118,164,129,59,166,211,255,193,15,215,25,215,30,235,161,111,7,142,236,1,236,66,165,251,51,219,144,154,169,82,130,12,152,188,99,50,21,208,233,230,7,163,193,58,45,137,213,14,250,97,197,119,5,170,227,81,158,247,19,24,39,44,137,162,99,11,217,72,90,208,146,137,114,129,21,211,149,89,204,241,151,219,113,167,69,96,59,118,193,77,183,95,146,102,184,30,164,145,128,121,218,19,161,63,22,160,161,179,246,81,59,93,211,177,75,18,28,175,46,157,168,123,110,108,167,162,164,139,69,49,145,31,109,35,56,160,183,96,39,155,12,59,148,43,68,118,161,143,42,167,53,103,244,90,110,58,117,232,163,178,124,198,147,224,245,62,49,219,1,245,236,58,185,186,135,56,215,116,100,30,157,16,223,244,112,153,217,77,103,77,107,35,222,237,134,133,90,116,12,2,207,39,50,119,49,53,51,77,215,68,195,221,81,223,107,72,34,226,26,155,21,191,210,47,74,150,172,144,161,72,174,166,232,112,108,43,215,76,227,29,63,146,220,114,60,248,23,240,255,144,220,16,142,51,195,100,2,239,93,231,59,119,213,74,241,180,34,82,166,114,202,12,208,106,61,238,100,255,146,143,161,217,214,67,43,158,240,15,37,7,236,48,149,110,136,89,249,173,179,167,223,253,160,93,177,90,47,134,90,187,253,15,61,77,89,159,196,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a4f104b-0194-4852-ba5f-4590ab640ee7"));
		}

		#endregion

	}

	#endregion

}

