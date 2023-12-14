﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileCopierSchema

	/// <exclude/>
	public class FileCopierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileCopierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileCopierSchema(FileCopierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8424df2e-9e56-480f-ad98-50063289ab97");
			Name = "FileCopier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8b1c57bf-1ff6-4af0-890b-4cc1ace5ccaa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,85,223,107,219,48,16,126,118,97,255,195,45,131,226,64,81,222,187,166,99,73,151,17,88,203,160,237,94,74,31,84,251,156,136,217,82,144,228,110,161,244,127,159,126,185,149,29,25,186,45,15,33,58,221,125,247,233,190,187,11,167,13,170,29,45,16,110,80,74,170,68,165,201,82,240,138,109,90,73,53,19,252,221,209,211,187,163,172,85,140,111,122,46,77,35,248,199,228,141,196,49,59,249,194,53,211,12,213,168,195,138,22,90,72,239,97,124,62,72,220,24,14,176,230,26,101,101,88,158,194,122,197,106,92,138,29,67,233,92,102,179,25,156,169,182,105,168,220,159,135,243,119,41,30,89,137,10,26,212,91,81,42,168,132,4,189,69,40,196,110,111,179,86,6,67,17,232,194,103,81,252,174,125,168,89,1,172,203,216,79,152,61,185,164,7,89,157,193,57,41,160,28,240,55,83,186,75,4,90,0,5,142,191,220,137,188,132,207,134,241,103,59,42,105,3,220,72,50,159,40,209,202,2,93,193,246,147,243,27,67,30,221,111,16,149,123,74,135,108,159,68,206,102,46,52,141,164,169,220,160,142,145,76,105,12,59,39,111,2,181,135,246,40,88,105,31,182,207,61,0,196,188,78,32,24,227,20,83,43,238,179,151,15,121,233,21,236,169,185,172,169,82,167,144,18,146,241,45,74,166,75,81,192,204,230,191,187,192,138,182,181,94,48,94,154,122,230,122,191,67,81,229,145,38,211,233,253,171,106,133,69,142,128,225,52,45,95,199,228,210,247,199,169,233,24,246,72,53,250,219,157,63,128,210,166,68,5,60,8,81,195,87,212,107,245,77,208,18,203,165,168,219,134,255,160,117,139,161,40,145,165,87,159,200,62,5,59,70,89,38,81,183,146,143,121,125,34,93,18,152,207,65,203,214,141,82,168,230,176,156,137,87,184,42,68,29,58,44,103,87,167,127,80,53,240,143,29,201,114,139,197,207,207,114,211,54,166,139,174,218,186,206,109,199,25,125,98,175,169,107,136,44,139,209,198,35,123,57,67,228,173,66,105,118,18,199,194,117,108,219,63,206,123,228,73,223,217,3,248,171,235,98,139,13,189,164,156,110,76,103,96,194,54,31,96,147,68,224,33,98,200,31,14,243,20,50,177,237,195,77,63,241,2,23,251,219,117,217,171,16,241,190,196,216,167,135,240,190,61,204,119,29,30,28,167,243,151,234,165,8,1,41,152,199,192,160,164,154,246,12,243,20,170,101,189,216,95,25,97,242,201,133,137,152,244,216,189,161,233,7,218,184,224,140,172,204,44,31,184,230,67,74,36,186,180,20,66,110,55,140,18,149,217,9,6,125,100,42,199,102,208,67,176,10,242,247,30,162,235,234,44,49,6,87,102,97,15,203,42,209,236,5,127,157,247,91,37,96,103,3,4,98,22,139,221,241,227,69,73,120,4,168,151,87,14,49,87,168,139,237,74,138,230,98,145,155,191,149,187,123,120,58,80,148,216,154,193,243,9,84,180,86,152,98,55,78,201,229,248,31,145,94,169,135,31,199,199,127,185,241,236,202,11,82,13,148,234,173,145,107,219,160,26,213,219,216,157,140,145,32,215,218,40,219,56,168,105,148,63,189,119,83,255,109,206,102,63,127,0,237,200,81,37,80,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8424df2e-9e56-480f-ad98-50063289ab97"));
		}

		#endregion

	}

	#endregion

}

