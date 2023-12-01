﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnCenterSchema

	/// <exclude/>
	public class IEsnCenterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnCenterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnCenterSchema(IEsnCenterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f745d68-871e-4874-b468-a48952af4a34");
			Name = "IEsnCenter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,75,79,219,64,16,62,131,196,127,24,165,151,86,66,246,189,13,150,170,16,80,164,22,16,41,226,80,245,176,216,227,100,133,189,27,237,174,137,80,213,255,222,125,248,25,39,38,14,41,69,201,105,95,51,59,223,55,159,119,103,195,72,138,114,65,66,132,31,40,4,145,60,86,222,136,179,152,206,50,65,20,229,204,27,79,175,78,142,127,159,28,31,101,146,178,25,76,159,165,194,244,203,74,95,219,36,9,134,198,64,122,151,200,80,208,80,175,209,171,62,8,156,233,81,128,9,83,40,98,189,211,103,152,140,37,27,161,233,219,37,190,239,195,80,102,105,74,196,115,144,247,111,4,127,162,17,74,72,81,205,121,36,33,230,2,150,92,60,194,146,170,57,88,227,133,160,18,65,242,144,146,4,24,42,51,237,21,254,252,154,195,69,246,144,208,16,104,17,65,35,128,35,131,173,21,131,29,184,68,5,153,68,1,9,125,68,23,130,102,75,146,25,74,175,52,242,87,173,134,11,34,72,10,76,51,123,54,48,230,147,104,16,220,25,55,52,242,134,190,157,93,191,56,119,62,137,228,32,248,238,218,218,6,194,146,219,182,185,64,149,9,38,131,161,95,180,204,212,100,204,178,20,5,121,72,112,168,161,126,211,225,159,255,184,14,12,160,220,175,25,146,23,92,152,184,62,94,102,122,23,23,233,169,49,111,58,48,179,1,84,177,125,114,137,93,79,153,241,91,172,237,203,209,118,220,212,169,217,150,15,11,208,132,150,155,54,16,131,237,148,254,59,225,221,98,202,159,176,18,197,191,149,193,46,80,31,56,79,224,142,237,3,172,145,127,165,61,224,177,117,34,97,57,231,22,124,212,55,209,175,2,214,161,233,251,57,55,221,168,1,184,15,198,52,213,135,65,29,107,237,83,223,22,156,12,231,152,146,59,3,110,106,155,133,3,208,99,221,9,215,155,83,245,108,44,199,182,85,90,238,89,41,163,70,50,139,77,52,139,154,23,68,8,5,198,103,3,205,237,45,146,130,75,61,57,0,63,240,58,115,209,92,31,128,233,143,28,169,210,37,163,36,39,23,96,129,184,183,30,137,82,36,156,31,118,186,218,97,94,233,118,25,167,153,232,54,210,204,100,41,115,70,23,52,209,215,28,184,161,13,182,235,245,17,163,254,194,73,73,247,235,101,162,67,169,244,241,181,76,100,79,137,156,130,84,194,84,30,21,53,238,210,202,135,43,240,157,98,58,199,4,21,238,79,79,149,35,123,125,87,240,116,138,13,148,152,234,163,115,7,121,104,91,103,188,141,78,172,156,111,136,48,219,186,145,62,106,206,13,221,64,247,214,69,150,167,116,198,64,205,137,2,129,50,75,52,88,9,50,11,67,29,62,104,14,25,87,222,154,235,201,113,223,82,64,45,197,166,255,243,23,52,72,205,133,176,73,39,47,30,29,135,115,64,148,23,100,215,231,232,7,148,73,69,88,136,43,41,104,45,133,90,119,207,199,117,56,207,216,99,89,52,219,239,202,249,122,207,89,16,154,142,235,133,125,203,12,2,195,141,57,86,184,27,216,124,4,22,22,238,24,124,7,55,176,67,189,101,94,215,98,129,26,19,187,164,218,150,201,230,26,217,54,219,7,194,252,5,86,181,232,235,136,189,225,82,233,167,237,114,199,74,187,58,70,34,197,87,128,222,11,170,176,133,116,3,123,141,211,168,245,178,50,81,214,240,174,120,46,98,223,14,104,94,140,239,249,73,209,172,142,236,14,111,200,77,94,11,183,110,185,53,92,229,193,117,114,53,142,104,239,219,108,7,158,246,160,33,123,219,155,112,215,191,204,214,50,176,141,90,44,3,61,149,146,47,55,12,228,249,120,11,165,148,12,52,52,80,198,178,179,6,242,242,245,32,106,154,90,77,184,255,42,36,39,170,167,88,254,7,81,47,11,180,70,84,67,78,47,16,85,58,54,68,29,253,113,127,203,34,139,220,63,179,39,199,118,68,255,254,2,159,217,22,132,12,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f745d68-871e-4874-b468-a48952af4a34"));
		}

		#endregion

	}

	#endregion

}
